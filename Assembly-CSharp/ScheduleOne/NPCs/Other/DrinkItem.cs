using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000B4A RID: 2890
	[Token(Token = "0x2000B4A")]
	public class DrinkItem : MonoBehaviour
	{
		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060056BA RID: 22202 RVA: 0x00016320 File Offset: 0x00014520
		// (set) Token: 0x060056BB RID: 22203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB0")]
		public bool active
		{
			[Token(Token = "0x60056BA")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056BB")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BC")]
		[Address(RVA = "0x9944B0", Offset = "0x9936B0", VA = "0x1809944B0")]
		private void Awake()
		{
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BD")]
		[Address(RVA = "0x994540", Offset = "0x993740", VA = "0x180994540")]
		public void Begin()
		{
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BE")]
		[Address(RVA = "0x9945F0", Offset = "0x9937F0", VA = "0x1809945F0")]
		public void End()
		{
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BF")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DrinkItem()
		{
		}

		// Token: 0x040039F4 RID: 14836
		[Token(Token = "0x40039F4")]
		[FieldOffset(Offset = "0x20")]
		public NPC Npc;

		// Token: 0x040039F5 RID: 14837
		[Token(Token = "0x40039F5")]
		[FieldOffset(Offset = "0x28")]
		public AvatarEquippable DrinkPrefab;
	}
}
