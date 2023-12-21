using System;
using System.Collections.Generic;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x0200035F RID: 863
	public class DataSet
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x000716F7 File Offset: 0x0006F8F7
		public string CurrGroupName
		{
			get
			{
				if (this.currGroup == null)
				{
					return "";
				}
				return this.currGroup.name;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00071712 File Offset: 0x0006F912
		public bool IsEmpty
		{
			get
			{
				return this.vertList.Count == 0;
			}
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00071724 File Offset: 0x0006F924
		public static string GetFaceIndicesKey(DataSet.FaceIndices fi)
		{
			return string.Concat(new string[]
			{
				fi.vertIdx.ToString(),
				"/",
				fi.uvIdx.ToString(),
				"/",
				fi.normIdx.ToString()
			});
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0007177C File Offset: 0x0006F97C
		public static string FixMaterialName(string mtlName)
		{
			return mtlName.Replace(':', '_').Replace('\\', '_').Replace('/', '_').Replace('*', '_').Replace('?', '_').Replace('<', '_').Replace('>', '_').Replace('|', '_');
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x000717D4 File Offset: 0x0006F9D4
		public DataSet()
		{
			DataSet.ObjectData objectData = new DataSet.ObjectData();
			objectData.name = "default";
			this.objectList.Add(objectData);
			this.currObjData = objectData;
			DataSet.FaceGroupData faceGroupData = new DataSet.FaceGroupData();
			faceGroupData.name = "default";
			objectData.faceGroups.Add(faceGroupData);
			this.currGroup = faceGroupData;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00071874 File Offset: 0x0006FA74
		public void AddObject(string objectName)
		{
			string materialName = this.currObjData.faceGroups[this.currObjData.faceGroups.Count - 1].materialName;
			if (this.noFaceDefined)
			{
				this.objectList.Remove(this.currObjData);
			}
			DataSet.ObjectData objectData = new DataSet.ObjectData();
			objectData.name = objectName;
			this.objectList.Add(objectData);
			DataSet.FaceGroupData faceGroupData = new DataSet.FaceGroupData();
			faceGroupData.materialName = materialName;
			faceGroupData.name = "default";
			objectData.faceGroups.Add(faceGroupData);
			this.currGroup = faceGroupData;
			this.currObjData = objectData;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00071910 File Offset: 0x0006FB10
		public void AddGroup(string groupName)
		{
			string materialName = this.currObjData.faceGroups[this.currObjData.faceGroups.Count - 1].materialName;
			if (this.currGroup.IsEmpty)
			{
				this.currObjData.faceGroups.Remove(this.currGroup);
			}
			DataSet.FaceGroupData faceGroupData = new DataSet.FaceGroupData();
			faceGroupData.materialName = materialName;
			if (groupName == null)
			{
				groupName = "Unnamed-" + this.unnamedGroupIndex.ToString();
				this.unnamedGroupIndex++;
			}
			faceGroupData.name = groupName;
			this.currObjData.faceGroups.Add(faceGroupData);
			this.currGroup = faceGroupData;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x000719C0 File Offset: 0x0006FBC0
		public void AddMaterialName(string matName)
		{
			if (!this.currGroup.IsEmpty)
			{
				this.AddGroup(matName);
			}
			if (this.currGroup.name == "default")
			{
				this.currGroup.name = matName;
			}
			this.currGroup.materialName = matName;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00071A10 File Offset: 0x0006FC10
		public void AddVertex(Vector3 vertex)
		{
			this.vertList.Add(vertex);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00071A1E File Offset: 0x0006FC1E
		public void AddUV(Vector2 uv)
		{
			this.uvList.Add(uv);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00071A2C File Offset: 0x0006FC2C
		public void AddNormal(Vector3 normal)
		{
			this.normalList.Add(normal);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00071A3A File Offset: 0x0006FC3A
		public void AddColor(Color color)
		{
			this.colorList.Add(color);
			this.currObjData.hasColors = true;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00071A54 File Offset: 0x0006FC54
		public void AddFaceIndices(DataSet.FaceIndices faceIdx)
		{
			this.noFaceDefined = false;
			this.currGroup.faces.Add(faceIdx);
			this.currObjData.allFaces.Add(faceIdx);
			if (faceIdx.normIdx >= 0)
			{
				this.currObjData.hasNormals = true;
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00071A94 File Offset: 0x0006FC94
		public void PrintSummary()
		{
			string text = string.Concat(new string[]
			{
				"This data set has ",
				this.objectList.Count.ToString(),
				" object(s)\n  ",
				this.vertList.Count.ToString(),
				" vertices\n  ",
				this.uvList.Count.ToString(),
				" uvs\n  ",
				this.normalList.Count.ToString(),
				" normals"
			});
			foreach (DataSet.ObjectData objectData in this.objectList)
			{
				text = string.Concat(new string[]
				{
					text,
					"\n  ",
					objectData.name,
					" has ",
					objectData.faceGroups.Count.ToString(),
					" group(s)"
				});
				foreach (DataSet.FaceGroupData faceGroupData in objectData.faceGroups)
				{
					text = string.Concat(new string[]
					{
						text,
						"\n    ",
						faceGroupData.name,
						" has ",
						faceGroupData.faces.Count.ToString(),
						" faces(s)"
					});
				}
			}
			Debug.Log(text);
		}

		// Token: 0x0400140F RID: 5135
		public List<DataSet.ObjectData> objectList = new List<DataSet.ObjectData>();

		// Token: 0x04001410 RID: 5136
		public List<Vector3> vertList = new List<Vector3>();

		// Token: 0x04001411 RID: 5137
		public List<Vector2> uvList = new List<Vector2>();

		// Token: 0x04001412 RID: 5138
		public List<Vector3> normalList = new List<Vector3>();

		// Token: 0x04001413 RID: 5139
		public List<Color> colorList = new List<Color>();

		// Token: 0x04001414 RID: 5140
		private int unnamedGroupIndex = 1;

		// Token: 0x04001415 RID: 5141
		private DataSet.ObjectData currObjData;

		// Token: 0x04001416 RID: 5142
		private DataSet.FaceGroupData currGroup;

		// Token: 0x04001417 RID: 5143
		private bool noFaceDefined = true;

		// Token: 0x02000C11 RID: 3089
		public struct FaceIndices
		{
			// Token: 0x04003CFF RID: 15615
			public int vertIdx;

			// Token: 0x04003D00 RID: 15616
			public int uvIdx;

			// Token: 0x04003D01 RID: 15617
			public int normIdx;
		}

		// Token: 0x02000C12 RID: 3090
		public class ObjectData
		{
			// Token: 0x04003D02 RID: 15618
			public string name;

			// Token: 0x04003D03 RID: 15619
			public List<DataSet.FaceGroupData> faceGroups = new List<DataSet.FaceGroupData>();

			// Token: 0x04003D04 RID: 15620
			public List<DataSet.FaceIndices> allFaces = new List<DataSet.FaceIndices>();

			// Token: 0x04003D05 RID: 15621
			public bool hasNormals;

			// Token: 0x04003D06 RID: 15622
			public bool hasColors;
		}

		// Token: 0x02000C13 RID: 3091
		public class FaceGroupData
		{
			// Token: 0x06005AB2 RID: 23218 RVA: 0x001F41C4 File Offset: 0x001F23C4
			public FaceGroupData()
			{
				this.faces = new List<DataSet.FaceIndices>();
			}

			// Token: 0x17000BED RID: 3053
			// (get) Token: 0x06005AB3 RID: 23219 RVA: 0x001F41D7 File Offset: 0x001F23D7
			public bool IsEmpty
			{
				get
				{
					return this.faces.Count == 0;
				}
			}

			// Token: 0x04003D07 RID: 15623
			public string name;

			// Token: 0x04003D08 RID: 15624
			public string materialName;

			// Token: 0x04003D09 RID: 15625
			public List<DataSet.FaceIndices> faces;
		}
	}
}
