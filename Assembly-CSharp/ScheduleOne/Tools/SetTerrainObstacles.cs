using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200088F RID: 2191
	[Token(Token = "0x200088F")]
	public class SetTerrainObstacles : MonoBehaviour
	{
		// Token: 0x060039E0 RID: 14816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x80D770", Offset = "0x80C970", VA = "0x18080D770")]
		private void Start()
		{
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SetTerrainObstacles()
		{
		}

		// Token: 0x04002A97 RID: 10903
		[Token(Token = "0x4002A97")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider Bounds;

		// Token: 0x04002A98 RID: 10904
		[Token(Token = "0x4002A98")]
		[FieldOffset(Offset = "0x28")]
		private TreeInstance[] Obstacle;

		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		[FieldOffset(Offset = "0x30")]
		private Terrain terrain;

		// Token: 0x04002A9A RID: 10906
		[Token(Token = "0x4002A9A")]
		[FieldOffset(Offset = "0x38")]
		private float width;

		// Token: 0x04002A9B RID: 10907
		[Token(Token = "0x4002A9B")]
		[FieldOffset(Offset = "0x3C")]
		private float lenght;

		// Token: 0x04002A9C RID: 10908
		[Token(Token = "0x4002A9C")]
		[FieldOffset(Offset = "0x40")]
		private float hight;

		// Token: 0x04002A9D RID: 10909
		[Token(Token = "0x4002A9D")]
		[FieldOffset(Offset = "0x44")]
		private bool isError;
	}
}
