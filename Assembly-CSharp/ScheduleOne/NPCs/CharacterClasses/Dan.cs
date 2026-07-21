using System;
using Il2CppDummyDll;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x2000A83")]
	public class Dan : NPC
	{
		// Token: 0x06004DA9 RID: 19881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA9")]
		[Address(RVA = "0x93A570", Offset = "0x939770", VA = "0x18093A570", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DAA")]
		[Address(RVA = "0x93A360", Offset = "0x939560", VA = "0x18093A360")]
		private void OrderCompleted()
		{
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DAB")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public Dan()
		{
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DAC")]
		[Address(RVA = "0x8F17B0", Offset = "0x8F09B0", VA = "0x1808F17B0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DAD")]
		[Address(RVA = "0x93A340", Offset = "0x939540", VA = "0x18093A340", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DAE")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DAF")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04003652 RID: 13906
		[Token(Token = "0x4003652")]
		[FieldOffset(Offset = "0x328")]
		public ShopInterface ShopInterface;

		// Token: 0x04003653 RID: 13907
		[Token(Token = "0x4003653")]
		[FieldOffset(Offset = "0x330")]
		[Header("Settings")]
		public string[] OrderCompletedLines;

		// Token: 0x04003654 RID: 13908
		[Token(Token = "0x4003654")]
		[FieldOffset(Offset = "0x338")]
		public UnityEvent onGreeting;

		// Token: 0x04003655 RID: 13909
		[Token(Token = "0x4003655")]
		[FieldOffset(Offset = "0x340")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted;

		// Token: 0x04003656 RID: 13910
		[Token(Token = "0x4003656")]
		[FieldOffset(Offset = "0x341")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DanAssembly-CSharp.dll_Excuted;
	}
}
