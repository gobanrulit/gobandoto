using System;
using System.Collections.Generic;
using UnityEngine;

namespace ArchieAndrews.PrefabBrush
{
	// Token: 0x02000356 RID: 854
	[CreateAssetMenu(fileName = "[NEW]PB_SaveFile", menuName = "PrefabBrush/Prefab Brush Save", order = 0)]
	[Serializable]
	public class PB_SaveObject : ScriptableObject
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x0006F8C8 File Offset: 0x0006DAC8
		public void AddPrefab(GameObject prefab)
		{
			PB_PrefabData pb_PrefabData = new PB_PrefabData();
			pb_PrefabData.prefab = prefab;
			pb_PrefabData.selected = true;
			this.prefabData.Add(pb_PrefabData);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0006F8F8 File Offset: 0x0006DAF8
		public void UpgradeSave()
		{
			if (this.prefabList.Count == 0)
			{
				return;
			}
			for (int i = 0; i < this.prefabList.Count; i++)
			{
				this.AddPrefab(this.prefabList[i]);
			}
			this.prefabList.Clear();
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0006F948 File Offset: 0x0006DB48
		public List<PB_PrefabData> GetActivePrefabs()
		{
			List<PB_PrefabData> list = new List<PB_PrefabData>();
			for (int i = 0; i < this.prefabData.Count; i++)
			{
				if (this.prefabData[i].selected)
				{
					list.Add(this.prefabData[i]);
				}
			}
			return list;
		}

		// Token: 0x040013AB RID: 5035
		public List<GameObject> prefabList = new List<GameObject>();

		// Token: 0x040013AC RID: 5036
		public List<PB_PrefabData> prefabData = new List<PB_PrefabData>();

		// Token: 0x040013AD RID: 5037
		public PB_PaintType paintType;

		// Token: 0x040013AE RID: 5038
		public float brushSize = 1f;

		// Token: 0x040013AF RID: 5039
		public float minBrushSize = 0.1f;

		// Token: 0x040013B0 RID: 5040
		public float maxBrushSize = 20f;

		// Token: 0x040013B1 RID: 5041
		public float paintDeltaDistance = 0.4f;

		// Token: 0x040013B2 RID: 5042
		public float maxPaintDeltaDistance = 3f;

		// Token: 0x040013B3 RID: 5043
		public float minPaintDeltaDistance = 0.1f;

		// Token: 0x040013B4 RID: 5044
		public int prefabsPerStroke = 1;

		// Token: 0x040013B5 RID: 5045
		public int maxprefabsPerStroke = 20;

		// Token: 0x040013B6 RID: 5046
		public int minprefabsPerStroke = 1;

		// Token: 0x040013B7 RID: 5047
		public float spawnHeight = 10f;

		// Token: 0x040013B8 RID: 5048
		public bool addRigidbodyToPaintedPrefab = true;

		// Token: 0x040013B9 RID: 5049
		public float physicsIterations = 100f;

		// Token: 0x040013BA RID: 5050
		public bool checkLayer;

		// Token: 0x040013BB RID: 5051
		public bool checkTag;

		// Token: 0x040013BC RID: 5052
		public bool checkSlope;

		// Token: 0x040013BD RID: 5053
		public bool ignorePaintedPrefabs;

		// Token: 0x040013BE RID: 5054
		public bool ignoreTriggers = true;

		// Token: 0x040013BF RID: 5055
		public PB_Direction chainPivotAxis;

		// Token: 0x040013C0 RID: 5056
		public PB_Direction chainDirection;

		// Token: 0x040013C1 RID: 5057
		public int requiredTagMask;

		// Token: 0x040013C2 RID: 5058
		public int requiredLayerMask;

		// Token: 0x040013C3 RID: 5059
		public float minRequiredSlope;

		// Token: 0x040013C4 RID: 5060
		public float maxRequiredSlope;

		// Token: 0x040013C5 RID: 5061
		public Vector3 prefabOriginOffset;

		// Token: 0x040013C6 RID: 5062
		public Vector3 prefabRotationOffset;

		// Token: 0x040013C7 RID: 5063
		public PB_DragModType draggingAction;

		// Token: 0x040013C8 RID: 5064
		public PB_Direction rotationAxis;

		// Token: 0x040013C9 RID: 5065
		public float rotationSensitivity = 10f;

		// Token: 0x040013CA RID: 5066
		public PB_ParentingStyle parentingStyle;

		// Token: 0x040013CB RID: 5067
		public GameObject parent;

		// Token: 0x040013CC RID: 5068
		public bool rotateToMatchSurface;

		// Token: 0x040013CD RID: 5069
		public PB_Direction rotateSurfaceDirection;

		// Token: 0x040013CE RID: 5070
		public bool randomizeRotation;

		// Token: 0x040013CF RID: 5071
		public float minXRotation;

		// Token: 0x040013D0 RID: 5072
		public float maxXRotation;

		// Token: 0x040013D1 RID: 5073
		public float minYRotation;

		// Token: 0x040013D2 RID: 5074
		public float maxYRotation;

		// Token: 0x040013D3 RID: 5075
		public float minZRotation;

		// Token: 0x040013D4 RID: 5076
		public float maxZRotation;

		// Token: 0x040013D5 RID: 5077
		public PB_ScaleType scaleType;

		// Token: 0x040013D6 RID: 5078
		public PB_SaveApplicationType scaleApplicationType;

		// Token: 0x040013D7 RID: 5079
		public float minScale = 1f;

		// Token: 0x040013D8 RID: 5080
		public float maxScale = 1f;

		// Token: 0x040013D9 RID: 5081
		public float minXScale = 1f;

		// Token: 0x040013DA RID: 5082
		public float maxXScale = 1f;

		// Token: 0x040013DB RID: 5083
		public float minYScale = 1f;

		// Token: 0x040013DC RID: 5084
		public float maxYScale = 1f;

		// Token: 0x040013DD RID: 5085
		public float minZScale = 1f;

		// Token: 0x040013DE RID: 5086
		public float maxZScale = 1f;

		// Token: 0x040013DF RID: 5087
		public List<GameObject> parentList = new List<GameObject>();

		// Token: 0x040013E0 RID: 5088
		public float eraseBrushSize = 1f;

		// Token: 0x040013E1 RID: 5089
		public float minEraseBrushSize = 0.1f;

		// Token: 0x040013E2 RID: 5090
		public float maxEraseBrushSize = 20f;

		// Token: 0x040013E3 RID: 5091
		public PB_EraseTypes eraseType;

		// Token: 0x040013E4 RID: 5092
		public bool checkLayerForErase;

		// Token: 0x040013E5 RID: 5093
		public bool checkTagForErase;

		// Token: 0x040013E6 RID: 5094
		public bool checkSlopeForErase;

		// Token: 0x040013E7 RID: 5095
		public bool mustBeSelectedInBrush;

		// Token: 0x040013E8 RID: 5096
		public int requiredTagMaskForErase;

		// Token: 0x040013E9 RID: 5097
		public int requiredLayerMaskForErase;

		// Token: 0x040013EA RID: 5098
		public float minRequiredSlopeForErase;

		// Token: 0x040013EB RID: 5099
		public float maxRequiredSlopeForErase;

		// Token: 0x040013EC RID: 5100
		public PB_EraseDetectionType eraseDetection;

		// Token: 0x040013ED RID: 5101
		public KeyCode paintBrushHotKey = KeyCode.P;

		// Token: 0x040013EE RID: 5102
		public bool paintBrushHoldKey = true;

		// Token: 0x040013EF RID: 5103
		public KeyCode removeBrushHotKey = KeyCode.LeftControl;

		// Token: 0x040013F0 RID: 5104
		public bool removeBrushHoldKey = true;

		// Token: 0x040013F1 RID: 5105
		public KeyCode disableBrushHotKey = KeyCode.I;

		// Token: 0x040013F2 RID: 5106
		public bool disableBrushHoldKey = true;
	}
}
