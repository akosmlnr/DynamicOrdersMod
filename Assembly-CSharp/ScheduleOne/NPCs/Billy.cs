using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Quests;
using ScheduleOne.UI.Handover;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A3D RID: 2621
	[Token(Token = "0x2000A3D")]
	public class Billy : NPC
	{
		// Token: 0x06004A3F RID: 19007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A3F")]
		[Address(RVA = "0x8F12E0", Offset = "0x8F04E0", VA = "0x1808F12E0", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x8F17D0", Offset = "0x8F09D0", VA = "0x1808F17D0")]
		public void OpenRDXTradeHandover()
		{
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x8F1560", Offset = "0x8F0760", VA = "0x1808F1560")]
		private void HandoverOutcome(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> givenItems, float payment)
		{
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x6004A42")]
		[Address(RVA = "0x8F1330", Offset = "0x8F0530", VA = "0x1808F1330")]
		private float GetSucccessChance(List<ItemInstance> items, float price)
		{
			return 0f;
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A43")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public Billy()
		{
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A44")]
		[Address(RVA = "0x8F17B0", Offset = "0x8F09B0", VA = "0x1808F17B0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A45")]
		[Address(RVA = "0x8F1750", Offset = "0x8F0950", VA = "0x1808F1750", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A46")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A47")]
		[Address(RVA = "0x8F0FC0", Offset = "0x8F01C0", VA = "0x1808F0FC0", Slot = "130")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Billy_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400349B RID: 13467
		[Token(Token = "0x400349B")]
		public const int REQUESTED_PRODUCT_AMOUNT = 20;

		// Token: 0x0400349C RID: 13468
		[Token(Token = "0x400349C")]
		public const string REQUESTED_PRODUCT_ID = "cocaine";

		// Token: 0x0400349D RID: 13469
		[Token(Token = "0x400349D")]
		[FieldOffset(Offset = "0x328")]
		[Header("References")]
		public Contract TradeContract;

		// Token: 0x0400349E RID: 13470
		[Token(Token = "0x400349E")]
		[FieldOffset(Offset = "0x330")]
		public ItemDefinition RDXDefinition;

		// Token: 0x0400349F RID: 13471
		[Token(Token = "0x400349F")]
		[FieldOffset(Offset = "0x338")]
		private Customer customerComp;

		// Token: 0x040034A0 RID: 13472
		[Token(Token = "0x40034A0")]
		[FieldOffset(Offset = "0x340")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted;

		// Token: 0x040034A1 RID: 13473
		[Token(Token = "0x40034A1")]
		[FieldOffset(Offset = "0x341")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted;
	}
}
