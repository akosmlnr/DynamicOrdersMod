using System;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.NPCs.Relation;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000ACC RID: 2764
	[Token(Token = "0x2000ACC")]
	public class Phil : Supplier
	{
		// Token: 0x06004F75 RID: 20341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F75")]
		[Address(RVA = "0x941570", Offset = "0x940770", VA = "0x180941570", Slot = "85")]
		protected override void CreateMessageConversation()
		{
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F76")]
		[Address(RVA = "0x9416A0", Offset = "0x9408A0", VA = "0x1809416A0", Slot = "139")]
		protected virtual void InstructionsRequested()
		{
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F77")]
		[Address(RVA = "0x941740", Offset = "0x940940", VA = "0x180941740", Slot = "130")]
		protected override void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F78")]
		[Address(RVA = "0x941850", Offset = "0x940A50", VA = "0x180941850")]
		public Phil()
		{
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F79")]
		[Address(RVA = "0x930E70", Offset = "0x930070", VA = "0x180930E70", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7A")]
		[Address(RVA = "0x930E50", Offset = "0x930050", VA = "0x180930E50", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7B")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7C")]
		[Address(RVA = "0x930E00", Offset = "0x930000", VA = "0x180930E00", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04003722 RID: 14114
		[Token(Token = "0x4003722")]
		[FieldOffset(Offset = "0x3D0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PhilAssembly-CSharp.dll_Excuted;

		// Token: 0x04003723 RID: 14115
		[Token(Token = "0x4003723")]
		[FieldOffset(Offset = "0x3D1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PhilAssembly-CSharp.dll_Excuted;
	}
}
