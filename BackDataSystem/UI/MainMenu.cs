using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BackDataSystem.UI
{
	// Token: 0x0200090F RID: 2319
	public class MainMenu : MonoBehaviourSingleton<MainMenu>
	{
		// Token: 0x06005046 RID: 20550 RVA: 0x001B39A0 File Offset: 0x001B1BA0
		public Task Run()
		{
			MainMenu.<Run>d__4 <Run>d__;
			<Run>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<MainMenu.<Run>d__4>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x001B39DB File Offset: 0x001B1BDB
		private void HeroButtonPressed(Character character)
		{
			Debug.Log("Not implemented yet; character preview");
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x001B39E7 File Offset: 0x001B1BE7
		public void EnterBlocklordsButton()
		{
			SceneManager.LoadScene("Main", LoadSceneMode.Single);
		}

		// Token: 0x04003046 RID: 12358
		[SerializeField]
		private GameObject firstTimePanel;

		// Token: 0x04003047 RID: 12359
		[SerializeField]
		private GameObject defaultPanel;

		// Token: 0x04003048 RID: 12360
		[SerializeField]
		private GameObject heroButtonPrefab;

		// Token: 0x04003049 RID: 12361
		[SerializeField]
		private Transform heroButtonParent;
	}
}
