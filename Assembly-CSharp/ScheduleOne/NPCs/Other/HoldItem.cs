using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000B4B RID: 2891
	[Token(Token = "0x2000B4B")]
	public class HoldItem : MonoBehaviour
	{
		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x00016338 File Offset: 0x00014538
		// (set) Token: 0x060056C1 RID: 22209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB1")]
		public bool active
		{
			[Token(Token = "0x60056C0")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056C1")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C2")]
		[Address(RVA = "0x99D140", Offset = "0x99C340", VA = "0x18099D140")]
		public void Begin()
		{
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C3")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Update()
		{
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C4")]
		[Address(RVA = "0x99D170", Offset = "0x99C370", VA = "0x18099D170")]
		public void End()
		{
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C5")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public HoldItem()
		{
		}

		// Token: 0x040039F7 RID: 14839
		[Token(Token = "0x40039F7")]
		[FieldOffset(Offset = "0x20")]
		public NPC Npc;

		// Token: 0x040039F8 RID: 14840
		[Token(Token = "0x40039F8")]
		[FieldOffset(Offset = "0x28")]
		public AvatarEquippable Equippable;
	}
}
