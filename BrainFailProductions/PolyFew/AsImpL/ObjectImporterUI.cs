using System;
using UnityEngine;
using UnityEngine.UI;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x0200036D RID: 877
	[RequireComponent(typeof(ObjectImporter))]
	public class ObjectImporterUI : MonoBehaviour
	{
		// Token: 0x0600127F RID: 4735 RVA: 0x00076178 File Offset: 0x00074378
		private void Awake()
		{
			if (this.progressSlider != null)
			{
				this.progressSlider.maxValue = 100f;
				this.progressSlider.gameObject.SetActive(false);
			}
			if (this.progressImage != null)
			{
				this.progressImage.gameObject.SetActive(false);
			}
			if (this.progressText != null)
			{
				this.progressText.gameObject.SetActive(false);
			}
			this.objImporter = base.GetComponent<ObjectImporter>();
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000761FE File Offset: 0x000743FE
		private void OnEnable()
		{
			this.objImporter.ImportingComplete += this.OnImportComplete;
			this.objImporter.ImportingStart += this.OnImportStart;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0007622E File Offset: 0x0007442E
		private void OnDisable()
		{
			this.objImporter.ImportingComplete -= this.OnImportComplete;
			this.objImporter.ImportingStart -= this.OnImportStart;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00076260 File Offset: 0x00074460
		private void Update()
		{
			bool flag = Loader.totalProgress.singleProgress.Count > 0;
			if (!flag)
			{
				return;
			}
			int numImportRequests = this.objImporter.NumImportRequests;
			int num = numImportRequests - Loader.totalProgress.singleProgress.Count;
			if (flag)
			{
				float num2 = 100f * (float)num / (float)numImportRequests;
				float num3 = 0f;
				foreach (SingleLoadingProgress singleLoadingProgress in Loader.totalProgress.singleProgress)
				{
					if (num3 < singleLoadingProgress.percentage)
					{
						num3 = singleLoadingProgress.percentage;
					}
				}
				num2 += num3 / (float)numImportRequests;
				if (this.progressSlider != null)
				{
					this.progressSlider.value = num2;
					this.progressSlider.gameObject.SetActive(flag);
				}
				if (this.progressImage != null)
				{
					this.progressImage.fillAmount = num2 / 100f;
					this.progressImage.gameObject.SetActive(flag);
				}
				if (this.progressText != null)
				{
					if (!flag)
					{
						this.progressText.gameObject.SetActive(false);
						this.progressText.text = "";
						return;
					}
					this.progressText.gameObject.SetActive(flag);
					this.progressText.text = "Loading " + Loader.totalProgress.singleProgress.Count.ToString() + " objects...";
					string text = "";
					int num4 = 0;
					foreach (SingleLoadingProgress singleLoadingProgress2 in Loader.totalProgress.singleProgress)
					{
						if (num4 > 4)
						{
							text += "...";
							break;
						}
						if (!string.IsNullOrEmpty(singleLoadingProgress2.message))
						{
							if (num4 > 0)
							{
								text += "; ";
							}
							text += singleLoadingProgress2.message;
							num4++;
						}
					}
					if (text != "")
					{
						Text text2 = this.progressText;
						text2.text = text2.text + "\n" + text;
						return;
					}
				}
			}
			else
			{
				this.OnImportComplete();
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x000764C0 File Offset: 0x000746C0
		private void OnImportStart()
		{
			if (this.progressText != null)
			{
				this.progressText.text = "";
			}
			if (this.progressSlider != null)
			{
				this.progressSlider.value = 0f;
				this.progressSlider.gameObject.SetActive(true);
			}
			if (this.progressImage != null)
			{
				this.progressImage.fillAmount = 0f;
				this.progressImage.gameObject.SetActive(true);
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0007654C File Offset: 0x0007474C
		private void OnImportComplete()
		{
			if (this.progressText != null)
			{
				this.progressText.text = "";
			}
			if (this.progressSlider != null)
			{
				this.progressSlider.value = 100f;
				this.progressSlider.gameObject.SetActive(false);
			}
			if (this.progressImage != null)
			{
				this.progressImage.fillAmount = 1f;
				this.progressImage.gameObject.SetActive(false);
			}
		}

		// Token: 0x04001473 RID: 5235
		[Tooltip("Text for activity messages")]
		public Text progressText;

		// Token: 0x04001474 RID: 5236
		[Tooltip("Slider for the overall progress")]
		public Slider progressSlider;

		// Token: 0x04001475 RID: 5237
		[Tooltip("Panel with the Image Type set to Filled")]
		public Image progressImage;

		// Token: 0x04001476 RID: 5238
		private ObjectImporter objImporter;
	}
}
