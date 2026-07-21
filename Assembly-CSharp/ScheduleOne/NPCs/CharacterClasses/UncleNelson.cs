using System;
using Il2CppDummyDll;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000AC7 RID: 2759
	[Token(Token = "0x2000AC7")]
	public class UncleNelson : NPC
	{
		// Token: 0x06004F56 RID: 20310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x9461D0", Offset = "0x9453D0", VA = "0x1809461D0")]
		public void SendInitialMessage()
		{
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x9463B0", Offset = "0x9455B0", VA = "0x1809463B0")]
		public UncleNelson()
		{
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x93AA20", Offset = "0x939C20", VA = "0x18093AA20", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x93AA00", Offset = "0x939C00", VA = "0x18093AA00", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F5B")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04003715 RID: 14101
		[Token(Token = "0x4003715")]
		[FieldOffset(Offset = "0x328")]
		public string InitialMessage_Demo;

		// Token: 0x04003716 RID: 14102
		[Token(Token = "0x4003716")]
		[FieldOffset(Offset = "0x330")]
		public string InitialMessage;

		// Token: 0x04003717 RID: 14103
		[Token(Token = "0x4003717")]
		[FieldOffset(Offset = "0x338")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted;

		// Token: 0x04003718 RID: 14104
		[Token(Token = "0x4003718")]
		[FieldOffset(Offset = "0x339")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.UncleNelsonAssembly-CSharp.dll_Excuted;
	}
}
