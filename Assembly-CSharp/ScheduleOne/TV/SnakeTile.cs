using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.TV
{
	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	public class SnakeTile : MonoBehaviour
	{
		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00008220 File Offset: 0x00006420
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A6")]
		public SnakeTile.TileType Type
		{
			[Token(Token = "0x6001180")]
			[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
			[CompilerGenerated]
			get
			{
				return SnakeTile.TileType.Empty;
			}
			[Token(Token = "0x6001181")]
			[Address(RVA = "0x4929C0", Offset = "0x491BC0", VA = "0x1804929C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001182")]
		[Address(RVA = "0xB25B90", Offset = "0xB24D90", VA = "0x180B25B90")]
		public void SetType(SnakeTile.TileType type, int index = 0)
		{
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001183")]
		[Address(RVA = "0xB25A30", Offset = "0xB24C30", VA = "0x180B25A30")]
		public void SetPosition(Vector2 position, float tileSize)
		{
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001184")]
		[Address(RVA = "0xB25D20", Offset = "0xB24F20", VA = "0x180B25D20")]
		public SnakeTile()
		{
		}

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 Position;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x2C")]
		public Color SnakeColor;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x3C")]
		public Color FoodColor;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform RectTransform;

		// Token: 0x04001032 RID: 4146
		[Token(Token = "0x4001032")]
		[FieldOffset(Offset = "0x58")]
		public Image Image;

		// Token: 0x020002F1 RID: 753
		[Token(Token = "0x20002F1")]
		public enum TileType
		{
			// Token: 0x04001034 RID: 4148
			[Token(Token = "0x4001034")]
			Empty,
			// Token: 0x04001035 RID: 4149
			[Token(Token = "0x4001035")]
			Snake,
			// Token: 0x04001036 RID: 4150
			[Token(Token = "0x4001036")]
			Food
		}
	}
}
