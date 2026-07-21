using System;
using Il2CppDummyDll;
using ScheduleOne.Property;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000AB0 RID: 2736
	[Token(Token = "0x2000AB0")]
	public class Ming : NPC
	{
		// Token: 0x06004EA9 RID: 20137 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004EA9")]
		[Address(RVA = "0x93D230", Offset = "0x93C430", VA = "0x18093D230", Slot = "109")]
		public override string GetNameAddress()
		{
			return null;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EAA")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public Ming()
		{
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EAB")]
		[Address(RVA = "0x93D260", Offset = "0x93C460", VA = "0x18093D260", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EAC")]
		[Address(RVA = "0x93D240", Offset = "0x93C440", VA = "0x18093D240", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EAD")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x040036C4 RID: 14020
		[Token(Token = "0x40036C4")]
		[FieldOffset(Offset = "0x328")]
		public Property Property;

		// Token: 0x040036C5 RID: 14021
		[Token(Token = "0x40036C5")]
		[FieldOffset(Offset = "0x330")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MingAssembly-CSharp.dll_Excuted;

		// Token: 0x040036C6 RID: 14022
		[Token(Token = "0x40036C6")]
		[FieldOffset(Offset = "0x331")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MingAssembly-CSharp.dll_Excuted;
	}
}
