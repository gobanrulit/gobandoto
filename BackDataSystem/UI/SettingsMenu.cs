using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BackDataSystem.UI
{
	// Token: 0x02000911 RID: 2321
	public class SettingsMenu : MonoBehaviourSingleton<SettingsMenu>
	{
		// Token: 0x0600504E RID: 20558 RVA: 0x001B3A64 File Offset: 0x001B1C64
		private void Start()
		{
			this.settingsDict = new Dictionary<SettingsMenu.eSetting, SettingsMenu.Setting>(this.settings.Count);
			foreach (SettingsMenu.Setting setting in this.settings)
			{
				this.settingsDict[setting.name] = setting;
				if (setting.slider != null)
				{
					setting.slider.value = (setting.value = PlayerPrefs.GetFloat(setting.name.ToString(), setting.value));
					this.UpdateSetting(setting.value, setting.name);
				}
				if (setting.toggle != null)
				{
					setting.value = PlayerPrefs.GetFloat(setting.name.ToString(), setting.value);
					setting.toggle.isOn = (setting.value >= 1f);
					this.UpdateSetting(setting.toggle.isOn, setting.name);
				}
			}
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x001B3B90 File Offset: 0x001B1D90
		public void OnMasterVolumeChanged(float newValue)
		{
			this.SettingChanged(newValue, SettingsMenu.eSetting.MasterVolume);
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x001B3B9A File Offset: 0x001B1D9A
		public void OnMusicVolumeChanged(float newValue)
		{
			this.SettingChanged(newValue, SettingsMenu.eSetting.MusicVolume);
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x001B3BA4 File Offset: 0x001B1DA4
		public void OnSFXVolumeChanged(float newValue)
		{
			this.SettingChanged(newValue, SettingsMenu.eSetting.SFXVolume);
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x001B3BAE File Offset: 0x001B1DAE
		public void OnVSyncChanged(bool newValue)
		{
			this.SettingChanged(newValue, SettingsMenu.eSetting.VSync);
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x001B3BB8 File Offset: 0x001B1DB8
		public void OnFullScreenChanged(bool newValue)
		{
			this.SettingChanged(newValue, SettingsMenu.eSetting.FullScreen);
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x001B3BC4 File Offset: 0x001B1DC4
		private void SettingChanged(bool newValue, SettingsMenu.eSetting settingName)
		{
			Debug.Log(settingName.ToString() + " set to " + newValue.ToString());
			float value = (float)(newValue ? 0 : 1);
			PlayerPrefs.SetFloat(settingName.ToString(), value);
			this.settingsDict[settingName].value = value;
			this.UpdateSetting(newValue, settingName);
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x001B3C2C File Offset: 0x001B1E2C
		private void SettingChanged(float newValue, SettingsMenu.eSetting settingName)
		{
			Debug.Log(settingName.ToString() + " set to " + newValue.ToString());
			PlayerPrefs.SetFloat(settingName.ToString(), newValue);
			this.settingsDict[settingName].value = newValue;
			this.UpdateSetting(newValue, settingName);
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x001B3C89 File Offset: 0x001B1E89
		private void UpdateSetting(bool newValue, SettingsMenu.eSetting settingName)
		{
			if (settingName == SettingsMenu.eSetting.VSync)
			{
				QualitySettings.vSyncCount = (newValue ? 0 : 1);
				return;
			}
			if (settingName != SettingsMenu.eSetting.FullScreen)
			{
				Debug.LogError("Unrecognised setting " + settingName.ToString());
				return;
			}
			Screen.fullScreen = newValue;
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x001B3CC8 File Offset: 0x001B1EC8
		private void UpdateSetting(float newValue, SettingsMenu.eSetting settingName)
		{
			switch (settingName)
			{
			case SettingsMenu.eSetting.MasterVolume:
				this.musicAudioSource.volume = newValue * this.GetSetting(SettingsMenu.eSetting.MusicVolume);
				this.sfxAudioSource.volume = newValue * this.GetSetting(SettingsMenu.eSetting.SFXVolume);
				return;
			case SettingsMenu.eSetting.MusicVolume:
				this.musicAudioSource.volume = newValue * this.GetSetting(SettingsMenu.eSetting.MasterVolume);
				return;
			case SettingsMenu.eSetting.SFXVolume:
				this.sfxAudioSource.volume = newValue * this.GetSetting(SettingsMenu.eSetting.MasterVolume);
				return;
			default:
				Debug.LogError("Unrecognised setting " + settingName.ToString());
				return;
			}
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x001B3D58 File Offset: 0x001B1F58
		private float GetSetting(SettingsMenu.eSetting settingName)
		{
			return this.settingsDict[settingName].value;
		}

		// Token: 0x0400304E RID: 12366
		[SerializeField]
		private AudioSource musicAudioSource;

		// Token: 0x0400304F RID: 12367
		[SerializeField]
		private AudioSource sfxAudioSource;

		// Token: 0x04003050 RID: 12368
		[SerializeField]
		private List<SettingsMenu.Setting> settings = new List<SettingsMenu.Setting>();

		// Token: 0x04003051 RID: 12369
		private Dictionary<SettingsMenu.eSetting, SettingsMenu.Setting> settingsDict;

		// Token: 0x02000F13 RID: 3859
		private enum eSetting
		{
			// Token: 0x040044C2 RID: 17602
			MasterVolume,
			// Token: 0x040044C3 RID: 17603
			MusicVolume,
			// Token: 0x040044C4 RID: 17604
			SFXVolume,
			// Token: 0x040044C5 RID: 17605
			VSync,
			// Token: 0x040044C6 RID: 17606
			FullScreen
		}

		// Token: 0x02000F14 RID: 3860
		[Serializable]
		private class Setting
		{
			// Token: 0x040044C7 RID: 17607
			public SettingsMenu.eSetting name;

			// Token: 0x040044C8 RID: 17608
			public float value;

			// Token: 0x040044C9 RID: 17609
			public Slider slider;

			// Token: 0x040044CA RID: 17610
			public Toggle toggle;
		}
	}
}
