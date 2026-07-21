using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007C1 RID: 1985
	[Token(Token = "0x20007C1")]
	public class CornerObstacle : MonoBehaviour
	{
		// Token: 0x0600350D RID: 13581 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600350D")]
		[Address(RVA = "0x7CF1F0", Offset = "0x7CE3F0", VA = "0x1807CF1F0")]
		public List<Tile> GetNeighbourTiles(Tile pairedTile)
		{
			return null;
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x0000FE70 File Offset: 0x0000E070
		[Token(Token = "0x600350E")]
		[Address(RVA = "0x7CF1D0", Offset = "0x7CE3D0", VA = "0x1807CF1D0")]
		private bool ApproxEquals(float a, float b, float precision)
		{
			return default(bool);
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350F")]
		[Address(RVA = "0x7CF4D0", Offset = "0x7CE6D0", VA = "0x1807CF4D0")]
		public CornerObstacle()
		{
		}

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[FieldOffset(Offset = "0x20")]
		public bool obstacleEnabled;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[FieldOffset(Offset = "0x28")]
		public FootprintTile parentFootprint;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 coordinates;
	}
}
