using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	public class PolygonHelper : MonoBehaviour
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PolygonHelper()
		{
		}

		// Token: 0x0200013A RID: 314
		[Token(Token = "0x200013A")]
		public struct Plane2D
		{
			// Token: 0x060004FA RID: 1274 RVA: 0x00004008 File Offset: 0x00002208
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x698870", Offset = "0x697A70", VA = "0x180698870")]
			public float Distance(Vector2 point)
			{
				return 0f;
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x00004020 File Offset: 0x00002220
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x6985E0", Offset = "0x6977E0", VA = "0x1806985E0")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x00004038 File Offset: 0x00002238
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x698A20", Offset = "0x697C20", VA = "0x180698A20")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x00004050 File Offset: 0x00002250
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x6989F0", Offset = "0x697BF0", VA = "0x1806989F0")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x00004068 File Offset: 0x00002268
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x698920", Offset = "0x697B20", VA = "0x180698920")]
			public static PolygonHelper.Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(PolygonHelper.Plane2D);
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x00004080 File Offset: 0x00002280
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x6988D0", Offset = "0x697AD0", VA = "0x1806988D0")]
			public static PolygonHelper.Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(PolygonHelper.Plane2D);
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x6988A0", Offset = "0x697AA0", VA = "0x1806988A0")]
			public void Flip()
			{
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x698630", Offset = "0x697830", VA = "0x180698630")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x698B30", Offset = "0x697D30", VA = "0x180698B30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000620 RID: 1568
			[Token(Token = "0x4000620")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			// Token: 0x04000621 RID: 1569
			[Token(Token = "0x4000621")]
			[FieldOffset(Offset = "0x8")]
			public float distance;
		}
	}
}
