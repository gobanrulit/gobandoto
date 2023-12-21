using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace BackDataSystem.UI
{
	// Token: 0x02000912 RID: 2322
	public class TermsAndConditions : MonoBehaviourSingleton<TermsAndConditions>
	{
		// Token: 0x0600505A RID: 20570 RVA: 0x001B3D7E File Offset: 0x001B1F7E
		public static Task Run()
		{
			return MonoBehaviourSingleton<TermsAndConditions>.Instance.RunImpl();
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x001B3D8C File Offset: 0x001B1F8C
		private Task RunImpl()
		{
			TermsAndConditions.<RunImpl>d__3 <RunImpl>d__;
			<RunImpl>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RunImpl>d__.<>4__this = this;
			<RunImpl>d__.<>1__state = -1;
			<RunImpl>d__.<>t__builder.Start<TermsAndConditions.<RunImpl>d__3>(ref <RunImpl>d__);
			return <RunImpl>d__.<>t__builder.Task;
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x001B3DCF File Offset: 0x001B1FCF
		public void OkButtonPressed()
		{
			this.source.SetResult(null);
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x001B3DDD File Offset: 0x001B1FDD
		public void DontShowToggled(bool isOn)
		{
			PlayerPrefs.SetInt("DONT_SHOW_T&C", isOn ? 1 : 0);
		}

		// Token: 0x04003052 RID: 12370
		private const string DontShowKey = "DONT_SHOW_T&C";

		// Token: 0x04003053 RID: 12371
		private TaskCompletionSource<object> source;
	}
}
