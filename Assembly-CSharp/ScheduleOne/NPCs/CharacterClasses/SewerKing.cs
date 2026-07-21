using System;
using Il2CppDummyDll;
using ScheduleOne.Property;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000AC1 RID: 2753
	[Token(Token = "0x2000AC1")]
	public class SewerKing : NPC
	{
		// Token: 0x06004F22 RID: 20258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F22")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F23")]
		[Address(RVA = "0x944360", Offset = "0x943560", VA = "0x180944360", Slot = "92")]
		protected override void OnTick()
		{
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F24")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public SewerKing()
		{
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F25")]
		[Address(RVA = "0x93D260", Offset = "0x93C460", VA = "0x18093D260", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F26")]
		[Address(RVA = "0x93D240", Offset = "0x93C440", VA = "0x18093D240", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F27")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F28")]
		[Address(RVA = "0x944350", Offset = "0x943550", VA = "0x180944350", Slot = "130")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.SewerKing_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003704 RID: 14084
		[Token(Token = "0x4003704")]
		[FieldOffset(Offset = "0x328")]
		public SewerOffice sewerOffice;

		// Token: 0x04003705 RID: 14085
		[Token(Token = "0x4003705")]
		[FieldOffset(Offset = "0x330")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SewerKingAssembly-CSharp.dll_Excuted;

		// Token: 0x04003706 RID: 14086
		[Token(Token = "0x4003706")]
		[FieldOffset(Offset = "0x331")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SewerKingAssembly-CSharp.dll_Excuted;
	}
}
