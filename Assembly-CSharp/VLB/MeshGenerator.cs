using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	public static class MeshGenerator
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x697C00", Offset = "0x696E00", VA = "0x180697C00")]
		private static float GetAngleOffset(int numSides)
		{
			return 0f;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x697CE0", Offset = "0x696EE0", VA = "0x180697CE0")]
		private static float GetRadiiScale(int numSides)
		{
			return 0f;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x697B80", Offset = "0x696D80", VA = "0x180697B80")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x696950", Offset = "0x695B50", VA = "0x180696950")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x697150", Offset = "0x696350", VA = "0x180697150")]
		public static Mesh GenerateConeZ_Radii(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x6969D0", Offset = "0x695BD0", VA = "0x1806969D0")]
		public static Mesh GenerateConeZ_Radii_DoubleCaps(float lengthZ, float radiusStart, float radiusEnd, int numSides, bool inverted)
		{
			return null;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x6968F0", Offset = "0x695AF0", VA = "0x1806968F0")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x697C50", Offset = "0x696E50", VA = "0x180697C50")]
		private static int GetCapAdditionalVerticesCount(MeshGenerator.CapMode capMode, int numSides)
		{
			return 0;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x697C20", Offset = "0x696E20", VA = "0x180697C20")]
		private static int GetCapAdditionalIndicesCount(MeshGenerator.CapMode capMode, int numSides)
		{
			return 0;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x697EC0", Offset = "0x6970C0", VA = "0x180697EC0")]
		public static int GetVertexCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided)
		{
			return 0;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x697C90", Offset = "0x696E90", VA = "0x180697C90")]
		public static int GetIndicesCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided)
		{
			return 0;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x697E10", Offset = "0x697010", VA = "0x180697E10")]
		public static int GetSharedMeshVertexCount()
		{
			return 0;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x697D70", Offset = "0x696F70", VA = "0x180697D70")]
		public static int GetSharedMeshIndicesCount()
		{
			return 0;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x697D40", Offset = "0x696F40", VA = "0x180697D40")]
		public static int GetSharedMeshHDVertexCount()
		{
			return 0;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x697D10", Offset = "0x696F10", VA = "0x180697D10")]
		public static int GetSharedMeshHDIndicesCount()
		{
			return 0;
		}

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		private const float kMinTruncatedRadius = 0.001f;

		// Token: 0x02000132 RID: 306
		[Token(Token = "0x2000132")]
		public enum CapMode
		{
			// Token: 0x0400060C RID: 1548
			[Token(Token = "0x400060C")]
			None,
			// Token: 0x0400060D RID: 1549
			[Token(Token = "0x400060D")]
			OneVertexPerCap_1Cap,
			// Token: 0x0400060E RID: 1550
			[Token(Token = "0x400060E")]
			OneVertexPerCap_2Caps,
			// Token: 0x0400060F RID: 1551
			[Token(Token = "0x400060F")]
			SpecificVerticesPerCap_1Cap,
			// Token: 0x04000610 RID: 1552
			[Token(Token = "0x4000610")]
			SpecificVerticesPerCap_2Caps
		}
	}
}
