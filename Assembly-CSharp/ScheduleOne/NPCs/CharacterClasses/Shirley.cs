using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.UI.Phone;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000ACE RID: 2766
	[Token(Token = "0x2000ACE")]
	public class Shirley : Supplier
	{
		// Token: 0x06004F82 RID: 20354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F82")]
		[Address(RVA = "0x944560", Offset = "0x943760", VA = "0x180944560", Slot = "133")]
		protected override void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F83")]
		[Address(RVA = "0x9446C0", Offset = "0x9438C0", VA = "0x1809446C0")]
		public Shirley()
		{
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F84")]
		[Address(RVA = "0x930E70", Offset = "0x930070", VA = "0x180930E70", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x930E50", Offset = "0x930050", VA = "0x180930E50", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F86")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F87")]
		[Address(RVA = "0x930E00", Offset = "0x930000", VA = "0x180930E00", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04003726 RID: 14118
		[Token(Token = "0x4003726")]
		[FieldOffset(Offset = "0x3D0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ShirleyAssembly-CSharp.dll_Excuted;

		// Token: 0x04003727 RID: 14119
		[Token(Token = "0x4003727")]
		[FieldOffset(Offset = "0x3D1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ShirleyAssembly-CSharp.dll_Excuted;
	}
}
