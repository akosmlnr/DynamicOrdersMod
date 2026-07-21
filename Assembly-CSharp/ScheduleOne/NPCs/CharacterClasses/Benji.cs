using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000ACA RID: 2762
	[Token(Token = "0x2000ACA")]
	public class Benji : Dealer
	{
		// Token: 0x06004F66 RID: 20326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F66")]
		[Address(RVA = "0x932370", Offset = "0x931570", VA = "0x180932370", Slot = "92")]
		protected override void OnTick()
		{
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F67")]
		[Address(RVA = "0x932240", Offset = "0x931440", VA = "0x180932240", Slot = "146")]
		protected override void AddCustomer(Customer customer)
		{
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F68")]
		[Address(RVA = "0x932820", Offset = "0x931A20", VA = "0x180932820", Slot = "147")]
		public override void RemoveCustomer(Customer customer)
		{
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F69")]
		[Address(RVA = "0x9327E0", Offset = "0x9319E0", VA = "0x1809327E0", Slot = "149")]
		protected override void RecruitmentRequested()
		{
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6A")]
		[Address(RVA = "0x932910", Offset = "0x931B10", VA = "0x180932910", Slot = "143")]
		protected override void UpdatePotentialDealerPoI()
		{
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6B")]
		[Address(RVA = "0x932950", Offset = "0x931B50", VA = "0x180932950")]
		public Benji()
		{
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6C")]
		[Address(RVA = "0x932350", Offset = "0x931550", VA = "0x180932350", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6D")]
		[Address(RVA = "0x932330", Offset = "0x931530", VA = "0x180932330", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6E")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6F")]
		[Address(RVA = "0x793660", Offset = "0x792860", VA = "0x180793660", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x0400371D RID: 14109
		[Token(Token = "0x400371D")]
		[FieldOffset(Offset = "0x420")]
		public UnityEvent onRecruitmentRequested;

		// Token: 0x0400371E RID: 14110
		[Token(Token = "0x400371E")]
		[FieldOffset(Offset = "0x428")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted;

		// Token: 0x0400371F RID: 14111
		[Token(Token = "0x400371F")]
		[FieldOffset(Offset = "0x429")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted;
	}
}
