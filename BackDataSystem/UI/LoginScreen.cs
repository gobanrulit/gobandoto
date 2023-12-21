using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BackDataSystem.UI
{
	// Token: 0x0200090E RID: 2318
	public class LoginScreen : MonoBehaviourSingleton<LoginScreen>
	{
		// Token: 0x06005041 RID: 20545 RVA: 0x001B3935 File Offset: 0x001B1B35
		protected override void Awake()
		{
			base.Awake();
			this.task = this.Run();
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x001B3949 File Offset: 0x001B1B49
		public void CreateButton()
		{
			this.create = true;
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x001B3952 File Offset: 0x001B1B52
		public void LoginButton()
		{
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x001B3954 File Offset: 0x001B1B54
		private Task Run()
		{
			LoginScreen.<Run>d__12 <Run>d__;
			<Run>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Run>d__.<>4__this = this;
			<Run>d__.<>1__state = -1;
			<Run>d__.<>t__builder.Start<LoginScreen.<Run>d__12>(ref <Run>d__);
			return <Run>d__.<>t__builder.Task;
		}

		// Token: 0x0400303D RID: 12349
		[SerializeField]
		private TMP_InputField usernameField;

		// Token: 0x0400303E RID: 12350
		[SerializeField]
		private TMP_InputField passwordField;

		// Token: 0x0400303F RID: 12351
		[SerializeField]
		private TMP_InputField emailField;

		// Token: 0x04003040 RID: 12352
		[SerializeField]
		private GameObject errorDisplay;

		// Token: 0x04003041 RID: 12353
		[SerializeField]
		private TMP_Text errorDisplayText;

		// Token: 0x04003042 RID: 12354
		[SerializeField]
		private Button[] buttons;

		// Token: 0x04003043 RID: 12355
		private TaskCompletionSource<Task<Player>> playerNameSource;

		// Token: 0x04003044 RID: 12356
		private bool create;

		// Token: 0x04003045 RID: 12357
		private Task task;
	}
}
