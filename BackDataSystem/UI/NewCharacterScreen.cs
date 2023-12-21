using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BackDataSystem.UI
{
	// Token: 0x02000910 RID: 2320
	public class NewCharacterScreen : MonoBehaviourSingleton<NewCharacterScreen>
	{
		// Token: 0x0600504A RID: 20554 RVA: 0x001B39FC File Offset: 0x001B1BFC
		public static Task<Character> CreateCharacter()
		{
			return MonoBehaviourSingleton<NewCharacterScreen>.Instance.CreateCharacterImpl();
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x001B3A08 File Offset: 0x001B1C08
		private Task<Character> CreateCharacterImpl()
		{
			NewCharacterScreen.<CreateCharacterImpl>d__5 <CreateCharacterImpl>d__;
			<CreateCharacterImpl>d__.<>t__builder = AsyncTaskMethodBuilder<Character>.Create();
			<CreateCharacterImpl>d__.<>4__this = this;
			<CreateCharacterImpl>d__.<>1__state = -1;
			<CreateCharacterImpl>d__.<>t__builder.Start<NewCharacterScreen.<CreateCharacterImpl>d__5>(ref <CreateCharacterImpl>d__);
			return <CreateCharacterImpl>d__.<>t__builder.Task;
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x001B3A4B File Offset: 0x001B1C4B
		public void CreateButton()
		{
			this.createButton.SetResult(true);
		}

		// Token: 0x0400304A RID: 12362
		[SerializeField]
		private TMP_InputField firstNameField;

		// Token: 0x0400304B RID: 12363
		[SerializeField]
		private TMP_InputField surnameField;

		// Token: 0x0400304C RID: 12364
		[SerializeField]
		private Toggle maleToggle;

		// Token: 0x0400304D RID: 12365
		private TaskCompletionSource<bool> createButton;
	}
}
