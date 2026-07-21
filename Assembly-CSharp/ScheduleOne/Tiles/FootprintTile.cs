using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Building;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	public class FootprintTile : MonoBehaviour
	{
		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CB")]
		public Tile MatchedStandardTile
		{
			[Token(Token = "0x6001263")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001265")]
		[Address(RVA = "0xB1BCC0", Offset = "0xB1AEC0", VA = "0x180B1BCC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0", Slot = "5")]
		public virtual void Initialize(Tile matchedTile)
		{
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x6001267")]
		[Address(RVA = "0xB1B850", Offset = "0xB1AA50", VA = "0x180B1B850")]
		public bool AreCornerObstaclesBlocked(Tile proposedTile)
		{
			return default(bool);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001268")]
		[Address(RVA = "0xB1BCF0", Offset = "0xB1AEF0", VA = "0x180B1BCF0")]
		public FootprintTile()
		{
		}

		// Token: 0x040010C7 RID: 4295
		[Token(Token = "0x40010C7")]
		[FieldOffset(Offset = "0x20")]
		public TileAppearance tileAppearance;

		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0x28")]
		public TileDetector tileDetector;

		// Token: 0x040010C9 RID: 4297
		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x30")]
		public int X;

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x34")]
		public int Y;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x38")]
		public float RequiredOffset;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x40")]
		public List<CornerObstacle> Corners;
	}
}
