using System;
using FMOD.Studio;
using FMODUnity;
using Game.Core;
using Game.UI;
using TOOLS;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using ZFramework;

namespace BackDataSystem.UI
{
	// Token: 0x0200090D RID: 2317
	public class IntroVideo : MonoBehaviour
	{
		// Token: 0x06005036 RID: 20534 RVA: 0x001B3582 File Offset: 0x001B1782
		private void Start()
		{
			this.videoPlayer.started += this.VideoPlayer_started;
			this.videoPlayer.loopPointReached += this.VideoPlayer_loopPointReached;
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x001B35B2 File Offset: 0x001B17B2
		private void VideoPlayer_loopPointReached(VideoPlayer source)
		{
			UnityAction playEndAction = this.PlayEndAction;
			if (playEndAction != null)
			{
				playEndAction();
			}
			this.PlayEndAction = null;
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x001B35CC File Offset: 0x001B17CC
		private void VideoPlayer_started(VideoPlayer source)
		{
			UnityAction playStartAction = this.PlayStartAction;
			if (playStartAction != null)
			{
				playStartAction();
			}
			this.PlayStartAction = null;
			Debug.Log("StartPlay");
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x001B35F0 File Offset: 0x001B17F0
		public void SetVideoClip(string videoClipName, UnityAction startAction, UnityAction endAction, VideoAudioType audioType)
		{
			VideoClip videoClip = null;
			SingletonMono<Game.Core.ResMgr>.GetInstance().GetEventVideo(this._resLoader, videoClipName, delegate(VideoClip video)
			{
				videoClip = video;
			});
			if (videoClip != null)
			{
				UnityAction playEndAction = this.PlayEndAction;
				if (playEndAction != null)
				{
					playEndAction();
				}
				UnityAction playStartAction = this.PlayStartAction;
				if (playStartAction != null)
				{
					playStartAction();
				}
				this.PlayEndAction = endAction;
				this.PlayStartAction = startAction;
				this.videoPlayer.Stop();
				this.videoPlayer.clip = videoClip;
				this.videoPlayer.Prepare();
				this.videoPlayer.prepareCompleted += delegate(VideoPlayer v)
				{
					this.videoPlayer.Play();
					this.PlayFmodAudio(audioType);
				};
				return;
			}
			if (!(this.videoPlayer.clip == null))
			{
				this.videoPlayer.Pause();
			}
			Debug.LogError("事件视频为空，请检查tool工具中的配置; Event VideoClip is null ,please check tool's setting");
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x001B36DC File Offset: 0x001B18DC
		public void SetVideoClip(string bundleName, string videoClipName, UnityAction startAction, UnityAction endAction, VideoAudioType audioType)
		{
			Debug.Log(bundleName + "/" + videoClipName);
			VideoClip videoClip = null;
			SingletonMono<Game.Core.ResMgr>.GetInstance().GetAdventureVideo(this._resLoader, bundleName, videoClipName, delegate(VideoClip video)
			{
				videoClip = video;
			});
			if (videoClip != null)
			{
				UnityAction playEndAction = this.PlayEndAction;
				if (playEndAction != null)
				{
					playEndAction();
				}
				UnityAction playStartAction = this.PlayStartAction;
				if (playStartAction != null)
				{
					playStartAction();
				}
				this.PlayEndAction = endAction;
				this.PlayStartAction = startAction;
				this.videoPlayer.Stop();
				this.videoPlayer.clip = videoClip;
				this.videoPlayer.Prepare();
				this.videoPlayer.prepareCompleted += delegate(VideoPlayer v)
				{
					Debug.Log("Play video");
					this.videoPlayer.Play();
					this.PlayFmodAudio(audioType);
				};
				return;
			}
			if (!(this.videoPlayer.clip == null))
			{
				Debug.Log("Pause video");
				this.videoPlayer.Pause();
			}
			Debug.LogError("事件视频为空，请检查tool工具中的配置; Event VideoClip is null ,please check tool's setting");
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x001B37E4 File Offset: 0x001B19E4
		public void SetVideoFinished()
		{
			UnityAction playStartAction = this.PlayStartAction;
			if (playStartAction != null)
			{
				playStartAction();
			}
			UnityAction playEndAction = this.PlayEndAction;
			if (playEndAction != null)
			{
				playEndAction();
			}
			Debug.LogError("close video");
			this.StopFmodAudio();
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x001B3818 File Offset: 0x001B1A18
		public bool VideoIsPlaying()
		{
			if (this.videoPlayer != null)
			{
				return this.videoPlayer.isPlaying;
			}
			Debug.LogError("Videoclip is null");
			return false;
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x001B383F File Offset: 0x001B1A3F
		private void OnDestroy()
		{
			this._resLoader.Recycle2Cache();
			this.StopFmodAudio();
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x001B3854 File Offset: 0x001B1A54
		private void PlayFmodAudio(VideoAudioType type)
		{
			string path = string.Empty;
			if (type != VideoAudioType.EventAudio)
			{
				if (type != VideoAudioType.AdventureAudio)
				{
					throw new ArgumentOutOfRangeException("type", type, null);
				}
				path = SingletonScriptableObject<AudioTemplateManager>.Instance.AdventureVideoAudioBasePath + "/" + this.videoPlayer.clip.name;
			}
			else
			{
				path = SingletonScriptableObject<AudioTemplateManager>.Instance.EventVideoAudioBasePath + "/" + this.videoPlayer.clip.name;
			}
			if (!SingletonMono<AudioManager>.GetInstance().HasAudio(path))
			{
				return;
			}
			this.StopFmodAudio();
			this.eventVideoLoopSoundInstance = RuntimeManager.CreateInstance(path);
			this.eventVideoLoopSoundInstance.start();
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x001B38FC File Offset: 0x001B1AFC
		private void StopFmodAudio()
		{
			this.eventVideoLoopSoundInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
			this.eventVideoLoopSoundInstance.release();
		}

		// Token: 0x04003036 RID: 12342
		[SerializeField]
		private VideoPlayer videoPlayer;

		// Token: 0x04003037 RID: 12343
		private ResLoader _resLoader = ResLoader.Allocate();

		// Token: 0x04003038 RID: 12344
		public UnityAction PlayEndAction;

		// Token: 0x04003039 RID: 12345
		public UnityAction PlayStartAction;

		// Token: 0x0400303A RID: 12346
		private EventInstance eventVideoLoopSoundInstance;

		// Token: 0x0400303B RID: 12347
		public UIEventSysPop _EventSysPop;

		// Token: 0x0400303C RID: 12348
		private string curVideoAudioName = string.Empty;
	}
}
