using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Arrow
{
	// Token: 0x020003AC RID: 940
	public class SimpleArrowRenderer : ArrowRenderer
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x0008B643 File Offset: 0x00089843
		private void Awake()
		{
			this.bodyMesh = new Mesh();
			this.tipMesh = new Mesh();
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0008B65B File Offset: 0x0008985B
		public override void SetPositions(Vector3 startPosition, Vector3 endPosition)
		{
			base.SetPositions(startPosition, endPosition);
			this.UpdateMeshes();
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0008B66C File Offset: 0x0008986C
		private void UpdateMeshes()
		{
			float num = 0f;
			for (int i = 0; i < this.Positions.Count - 1; i++)
			{
				num += Vector3.Distance(this.Positions[i], this.Positions[i + 1]);
			}
			float num2 = num - this.tipLength;
			float num3 = 0f;
			List<Vector3> list = new List<Vector3>
			{
				this.Positions[0]
			};
			for (int j = 0; j < this.Positions.Count - 1; j++)
			{
				float num4 = Vector3.Distance(this.Positions[j], this.Positions[j + 1]);
				num3 += num4;
				if (num3 >= num2)
				{
					Vector3 item = Vector3.Lerp(this.Positions[j], this.Positions[j + 1], 1f - (num3 - num2) / num4);
					list.Add(item);
					break;
				}
				list.Add(this.Positions[j + 1]);
			}
			this.CreateLineMesh(list, this.bodyWidth, this.bodyMesh);
			this.CreateLineMesh(new Vector3[]
			{
				list.Last<Vector3>(),
				this.Positions.Last<Vector3>()
			}, this.tipWidth, this.tipMesh);
			this.bodyMeshFilter.mesh = this.bodyMesh;
			this.tipMeshFilter.mesh = this.tipMesh;
			base.transform.position = this.start;
			base.transform.rotation = Quaternion.LookRotation(this.end - this.start, this.upwards);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0008B828 File Offset: 0x00089A28
		private void CreateLineMesh(IReadOnlyList<Vector3> positions, float width, Mesh mesh)
		{
			Vector3 right = Vector3.right;
			this.vertices.Clear();
			foreach (Vector3 a in positions)
			{
				this.vertices.Add(a + right * (width / 2f));
				this.vertices.Add(a - right * (width / 2f));
			}
			this.triangles.Clear();
			for (int i = 0; i < this.vertices.Count - 3; i += 2)
			{
				this.AddTriangle(i, i + 1, i + 3);
				this.AddTriangle(i, i + 3, i + 2);
			}
			float num = 0f;
			for (int j = 0; j < positions.Count - 1; j++)
			{
				num += Vector3.Distance(positions[j], positions[j + 1]);
			}
			this.uvs.Clear();
			float num2 = 0f;
			for (int k = 0; k < positions.Count - 1; k++)
			{
				this.uvs.Add(new Vector2(num2 / num, 1f));
				this.uvs.Add(new Vector2(num2 / num, 0f));
				num2 += Vector3.Distance(positions[k], positions[k + 1]);
			}
			this.uvs.Add(new Vector2(1f, 1f));
			this.uvs.Add(new Vector2(1f, 0f));
			mesh.Clear();
			mesh.SetVertices(this.vertices);
			mesh.SetTriangles(this.triangles, 0);
			mesh.SetUVs(0, this.uvs);
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0008BA18 File Offset: 0x00089C18
		private void AddTriangle(int i0, int i1, int i2)
		{
			this.triangles.Add(i0);
			this.triangles.Add(i1);
			this.triangles.Add(i2);
		}

		// Token: 0x040016D4 RID: 5844
		[Space]
		[SerializeField]
		private float tipWidth = 0.2f;

		// Token: 0x040016D5 RID: 5845
		[SerializeField]
		private float tipLength = 0.5f;

		// Token: 0x040016D6 RID: 5846
		[SerializeField]
		private float bodyWidth = 0.1f;

		// Token: 0x040016D7 RID: 5847
		[SerializeField]
		private MeshFilter tipMeshFilter;

		// Token: 0x040016D8 RID: 5848
		[SerializeField]
		private MeshFilter bodyMeshFilter;

		// Token: 0x040016D9 RID: 5849
		private readonly List<Vector3> vertices = new List<Vector3>();

		// Token: 0x040016DA RID: 5850
		private readonly List<int> triangles = new List<int>();

		// Token: 0x040016DB RID: 5851
		private readonly List<Vector2> uvs = new List<Vector2>();

		// Token: 0x040016DC RID: 5852
		private Mesh bodyMesh;

		// Token: 0x040016DD RID: 5853
		private Mesh tipMesh;
	}
}
