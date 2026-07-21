using System;
using Il2CppDummyDll;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Heatmap
{
	// Token: 0x02000612 RID: 1554
	[Token(Token = "0x2000612")]
	public class HeatmapRegion : MonoBehaviour
	{
		// Token: 0x0600267A RID: 9850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x6BF4E0", Offset = "0x6BE6E0", VA = "0x1806BF4E0")]
		public void Create(Grid grid, int textureIndex, Material heatmapMat)
		{
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public HeatmapRegion()
		{
		}

		// Token: 0x04001E24 RID: 7716
		[Token(Token = "0x4001E24")]
		[FieldOffset(Offset = "0x20")]
		public int _textureIndex;

		// Token: 0x04001E25 RID: 7717
		[Token(Token = "0x4001E25")]
		[FieldOffset(Offset = "0x28")]
		private MeshRenderer _renderer;
	}
}
