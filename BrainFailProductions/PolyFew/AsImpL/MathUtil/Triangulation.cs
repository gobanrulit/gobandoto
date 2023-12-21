using System;
using System.Collections.Generic;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	// Token: 0x02000373 RID: 883
	public static class Triangulation
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x00076984 File Offset: 0x00074B84
		public static List<Triangle> TriangulateConvexPolygon(List<Vertex> vertices, bool preserveOriginalVertices = true)
		{
			List<Vertex> list = preserveOriginalVertices ? new List<Vertex>(vertices) : vertices;
			List<Triangle> list2 = new List<Triangle>();
			while (list.Count != 3)
			{
				Vertex vertex = Triangulation.FindMaxAreaEarVertex(list);
				list2.Add(Triangulation.ClipTriangle(vertex, list));
			}
			list2.Add(new Triangle(list[0], list[1], list[2]));
			return list2;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000769E4 File Offset: 0x00074BE4
		public static List<Triangle> TriangulateByEarClipping(List<Vertex> origVertices, Vector3 planeNormal, string meshName, bool preserveOriginalVertices = true)
		{
			List<Triangle> list = new List<Triangle>();
			List<Vertex> list2 = preserveOriginalVertices ? new List<Vertex>(origVertices) : origVertices;
			for (int i = 0; i < list2.Count; i++)
			{
				int index = MathUtility.ClampListIndex(i + 1, list2.Count);
				int index2 = MathUtility.ClampListIndex(i - 1, list2.Count);
				list2[i].PreviousVertex = list2[index2];
				list2[i].NextVertex = list2[index];
			}
			List<Vertex> list3 = Triangulation.FindEarVertices(list2, planeNormal);
			while (list2.Count != 3)
			{
				if (list3.Count == 0)
				{
					planeNormal = -planeNormal;
					list3 = Triangulation.FindEarVertices(list2, planeNormal);
				}
				if (list3.Count == 0)
				{
					Debug.LogWarningFormat("Cannot find a proper reprojection for mesh '{0}'. Using fallback polygon triangulation.", new object[]
					{
						meshName
					});
					Triangle item = Triangulation.ClipTriangle(list2[0], list2);
					list.Add(item);
				}
				else
				{
					Triangle item2 = Triangulation.ClipEar(Triangulation.FindMaxAreaEarVertex(list3), list3, list2, planeNormal);
					list.Add(item2);
				}
			}
			list.Add(new Triangle(list2[0], list2[1], list2[2]));
			return list;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00076AFC File Offset: 0x00074CFC
		public static Triangle ClipTriangle(Vertex vertex, List<Vertex> vertices)
		{
			Vertex previousVertex = vertex.PreviousVertex;
			Vertex nextVertex = vertex.NextVertex;
			Triangle result = new Triangle(previousVertex, vertex, nextVertex);
			vertices.Remove(vertex);
			previousVertex.NextVertex = nextVertex;
			nextVertex.PreviousVertex = previousVertex;
			return result;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00076B38 File Offset: 0x00074D38
		private static Triangle ClipEar(Vertex earVertex, List<Vertex> earVertices, List<Vertex> vertices, Vector3 planeNormal)
		{
			Vertex previousVertex = earVertex.PreviousVertex;
			Vertex nextVertex = earVertex.NextVertex;
			Triangle result = Triangulation.ClipTriangle(earVertex, vertices);
			earVertices.Remove(earVertex);
			if (Triangulation.IsVertexEar(previousVertex, vertices, planeNormal))
			{
				earVertices.Add(previousVertex);
			}
			else
			{
				earVertices.Remove(previousVertex);
			}
			if (Triangulation.IsVertexEar(nextVertex, vertices, planeNormal))
			{
				earVertices.Add(nextVertex);
				return result;
			}
			earVertices.Remove(nextVertex);
			return result;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00076B98 File Offset: 0x00074D98
		private static Vertex FindMaxAreaEarVertex(List<Vertex> earVertices)
		{
			Vertex vertex = earVertices[0];
			foreach (Vertex vertex2 in earVertices)
			{
				if (vertex2.TriangleArea < vertex.TriangleArea)
				{
					vertex = vertex2;
				}
			}
			return vertex;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00076BF8 File Offset: 0x00074DF8
		private static List<Vertex> FindEarVertices(List<Vertex> vertices, Vector3 planeNormal)
		{
			List<Vertex> list = new List<Vertex>();
			for (int i = 0; i < vertices.Count; i++)
			{
				if (Triangulation.IsVertexEar(vertices[i], vertices, planeNormal))
				{
					list.Add(vertices[i]);
				}
			}
			return list;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00076C3C File Offset: 0x00074E3C
		private static bool IsVertexReflex(Vertex v, Vector3 vNormal)
		{
			Vector2 posOnPlane = v.PreviousVertex.GetPosOnPlane(vNormal);
			Vector2 posOnPlane2 = v.GetPosOnPlane(vNormal);
			Vector2 posOnPlane3 = v.NextVertex.GetPosOnPlane(vNormal);
			return !MathUtility.IsTriangleOrientedClockwise(posOnPlane, posOnPlane2, posOnPlane3);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00076C74 File Offset: 0x00074E74
		private static bool IsVertexEar(Vertex v, List<Vertex> vertices, Vector3 planeNormal)
		{
			if (Triangulation.IsVertexReflex(v, planeNormal))
			{
				return false;
			}
			Vector2 posOnPlane = v.PreviousVertex.GetPosOnPlane(planeNormal);
			Vector2 posOnPlane2 = v.GetPosOnPlane(planeNormal);
			Vector2 posOnPlane3 = v.NextVertex.GetPosOnPlane(planeNormal);
			bool flag = false;
			for (int i = 0; i < vertices.Count; i++)
			{
				if (v != vertices[i] && v.PreviousVertex != vertices[i] && v.NextVertex != vertices[i] && Triangulation.IsVertexReflex(vertices[i], planeNormal))
				{
					Vector2 posOnPlane4 = vertices[i].GetPosOnPlane(planeNormal);
					if (MathUtility.IsPointInTriangle(posOnPlane, posOnPlane2, posOnPlane3, posOnPlane4))
					{
						flag = true;
						break;
					}
				}
			}
			return !flag;
		}
	}
}
