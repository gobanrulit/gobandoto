﻿using System;
using System.IO;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x02000367 RID: 871
	public class TextureLoader : MonoBehaviour
	{
		// Token: 0x0600125B RID: 4699 RVA: 0x000754D4 File Offset: 0x000736D4
		public static Texture2D LoadTextureFromUrl(string url)
		{
			if (url.StartsWith("file:///"))
			{
				url = url.Substring("file:///".Length);
			}
			else
			{
				url = Path.GetFullPath(url);
			}
			return TextureLoader.LoadTexture(url);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00075508 File Offset: 0x00073708
		public static Texture2D LoadTexture(string fileName)
		{
			string a = Path.GetExtension(fileName).ToLower();
			if (a == ".png" || a == ".jpg")
			{
				Texture2D texture2D = new Texture2D(1, 1);
				texture2D.LoadImage(File.ReadAllBytes(fileName));
				return texture2D;
			}
			if (a == ".dds")
			{
				return TextureLoader.LoadDDSManual(fileName);
			}
			if (a == ".tga")
			{
				return TextureLoader.LoadTGA(fileName);
			}
			Debug.Log("texture not supported : " + fileName);
			return null;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0007558C File Offset: 0x0007378C
		public static Texture2D LoadTGA(string fileName)
		{
			Texture2D result;
			using (FileStream fileStream = File.OpenRead(fileName))
			{
				result = TextureLoader.LoadTGA(fileStream);
			}
			return result;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000755C4 File Offset: 0x000737C4
		public static Texture2D LoadDDSManual(string ddsPath)
		{
			Texture2D result;
			try
			{
				byte[] array = File.ReadAllBytes(ddsPath);
				if (array[4] != 124)
				{
					throw new Exception("Invalid DDS DXTn texture. Unable to read");
				}
				int height = (int)array[13] * 256 + (int)array[12];
				int width = (int)array[17] * 256 + (int)array[16];
				byte b = array[87];
				TextureFormat textureFormat = TextureFormat.DXT5;
				if (b == 49)
				{
					textureFormat = TextureFormat.DXT1;
				}
				if (b == 53)
				{
					textureFormat = TextureFormat.DXT5;
				}
				int num = 128;
				byte[] array2 = new byte[array.Length - num];
				Buffer.BlockCopy(array, num, array2, 0, array.Length - num);
				FileInfo fileInfo = new FileInfo(ddsPath);
				Texture2D texture2D = new Texture2D(width, height, textureFormat, false);
				texture2D.LoadRawTextureData(array2);
				texture2D.Apply();
				texture2D.name = fileInfo.Name;
				result = texture2D;
			}
			catch (Exception ex)
			{
				string str = "Could not load DDS: ";
				Exception ex2 = ex;
				Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null));
				result = new Texture2D(8, 8);
			}
			return result;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000756AC File Offset: 0x000738AC
		public static Texture2D LoadTGA(Stream TGAStream)
		{
			Texture2D result;
			try
			{
				using (BinaryReader binaryReader = new BinaryReader(TGAStream))
				{
					TextureLoader.TgaHeader tgaHeader = TextureLoader.LoadTgaHeader(binaryReader);
					short num = (short)tgaHeader.width;
					short num2 = (short)tgaHeader.height;
					int bits = (int)tgaHeader.bits;
					bool flag = (tgaHeader.descriptor & 32) == 32;
					Texture2D texture2D = new Texture2D((int)num, (int)num2);
					Color32[] array = new Color32[(int)(num * num2)];
					int num3 = (int)(num * num2);
					if (bits == 32)
					{
						for (int i = 1; i <= (int)num2; i++)
						{
							for (int j = 0; j < (int)num; j++)
							{
								byte b = binaryReader.ReadByte();
								byte g = binaryReader.ReadByte();
								byte r = binaryReader.ReadByte();
								byte a = binaryReader.ReadByte();
								int num4;
								if (flag)
								{
									num4 = num3 - i * (int)num + j;
								}
								else
								{
									num4 = num3 - ((int)num2 - i + 1) * (int)num + j;
								}
								array[num4] = new Color32(r, g, b, a);
							}
						}
					}
					else
					{
						if (bits != 24)
						{
							throw new Exception("TGA texture had non 32/24 bit depth.");
						}
						for (int k = 1; k <= (int)num2; k++)
						{
							for (int l = 0; l < (int)num; l++)
							{
								byte b2 = binaryReader.ReadByte();
								byte g2 = binaryReader.ReadByte();
								byte r2 = binaryReader.ReadByte();
								int num5;
								if (flag)
								{
									num5 = num3 - k * (int)num + l;
								}
								else
								{
									num5 = num3 - ((int)num2 - k + 1) * (int)num + l;
								}
								array[num5] = new Color32(r2, g2, b2, byte.MaxValue);
							}
						}
					}
					texture2D.SetPixels32(array);
					texture2D.Apply();
					result = texture2D;
				}
			}
			catch (Exception message)
			{
				Debug.LogWarning(message);
				result = null;
			}
			return result;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0007586C File Offset: 0x00073A6C
		private static TextureLoader.TgaHeader LoadTgaHeader(BinaryReader r)
		{
			TextureLoader.TgaHeader tgaHeader = new TextureLoader.TgaHeader();
			r.BaseStream.Seek(0L, SeekOrigin.Current);
			tgaHeader.identSize = r.ReadByte();
			tgaHeader.colorMapType = r.ReadByte();
			tgaHeader.imageType = r.ReadByte();
			tgaHeader.colorMapStart = r.ReadUInt16();
			tgaHeader.colorMapLength = r.ReadUInt16();
			tgaHeader.colorMapBits = r.ReadByte();
			tgaHeader.xStart = r.ReadUInt16();
			tgaHeader.ySstart = r.ReadUInt16();
			tgaHeader.width = r.ReadUInt16();
			tgaHeader.height = r.ReadUInt16();
			tgaHeader.bits = r.ReadByte();
			tgaHeader.descriptor = r.ReadByte();
			Debug.LogFormat("TGA descriptor = {0}", new object[]
			{
				tgaHeader.descriptor
			});
			if (tgaHeader.imageType == 0)
			{
				new Exception("TGA image contains no data.");
			}
			if (tgaHeader.imageType > 10)
			{
				new Exception("compressed TGA not supported.");
			}
			if (tgaHeader.imageType == 1 || tgaHeader.imageType == 9)
			{
				new Exception("color indexed TGA not supported.");
			}
			if (tgaHeader.bits != 24 && tgaHeader.bits != 32)
			{
				throw new Exception("only 24/32 bits TGA supported.");
			}
			if (tgaHeader.width <= 0 || tgaHeader.height <= 0)
			{
				throw new Exception("TGA texture has invalid size.");
			}
			r.BaseStream.Seek((long)((ulong)tgaHeader.identSize), SeekOrigin.Current);
			return tgaHeader;
		}

		// Token: 0x02000C34 RID: 3124
		private class TgaHeader
		{
			// Token: 0x04003DF4 RID: 15860
			public byte identSize;

			// Token: 0x04003DF5 RID: 15861
			public byte colorMapType;

			// Token: 0x04003DF6 RID: 15862
			public byte imageType;

			// Token: 0x04003DF7 RID: 15863
			public ushort colorMapStart;

			// Token: 0x04003DF8 RID: 15864
			public ushort colorMapLength;

			// Token: 0x04003DF9 RID: 15865
			public byte colorMapBits;

			// Token: 0x04003DFA RID: 15866
			public ushort xStart;

			// Token: 0x04003DFB RID: 15867
			public ushort ySstart;

			// Token: 0x04003DFC RID: 15868
			public ushort width;

			// Token: 0x04003DFD RID: 15869
			public ushort height;

			// Token: 0x04003DFE RID: 15870
			public byte bits;

			// Token: 0x04003DFF RID: 15871
			public byte descriptor;
		}
	}
}
