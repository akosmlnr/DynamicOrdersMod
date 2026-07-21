using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000B49 RID: 2889
	[Token(Token = "0x2000B49")]
	public class UseUmbrella : NPCDiscreteAction
	{
		// Token: 0x060056B6 RID: 22198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B6")]
		[Address(RVA = "0x9A5F90", Offset = "0x9A5190", VA = "0x1809A5F90")]
		private void Awake()
		{
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B7")]
		[Address(RVA = "0x9A6020", Offset = "0x9A5220", VA = "0x1809A6020", Slot = "4")]
		protected override void BeginOnServer()
		{
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B8")]
		[Address(RVA = "0x9A6060", Offset = "0x9A5260", VA = "0x1809A6060", Slot = "6")]
		protected override void EndOnServer()
		{
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B9")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public UseUmbrella()
		{
		}

		// Token: 0x040039F1 RID: 14833
		[Token(Token = "0x40039F1")]
		[FieldOffset(Offset = "0x28")]
		[Header("Components")]
		[SerializeField]
		private NPC _npc;

		// Token: 0x040039F2 RID: 14834
		[Token(Token = "0x40039F2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EquippableData _umbrellaData;

		// Token: 0x040039F3 RID: 14835
		[Token(Token = "0x40039F3")]
		[FieldOffset(Offset = "0x38")]
		private IEquippedItemHandler _equippedItemHandler;
	}
}
