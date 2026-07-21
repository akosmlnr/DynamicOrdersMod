using System;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000A89 RID: 2697
	[Token(Token = "0x2000A89")]
	public class Fixer : NPC
	{
		// Token: 0x06004DCE RID: 19918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCE")]
		[Address(RVA = "0x93B380", Offset = "0x93A580", VA = "0x18093B380", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCF")]
		[Address(RVA = "0x93AFD0", Offset = "0x93A1D0", VA = "0x18093AFD0")]
		private void Loaded()
		{
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD0")]
		[Address(RVA = "0x93AC70", Offset = "0x939E70", VA = "0x18093AC70")]
		private void EnableGreeting()
		{
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD1")]
		[Address(RVA = "0x93B1F0", Offset = "0x93A3F0", VA = "0x18093B1F0")]
		private void SetGreeted()
		{
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00014DA8 File Offset: 0x00012FA8
		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x93AD50", Offset = "0x939F50", VA = "0x18093AD50")]
		public static float GetAdditionalSigningFee()
		{
			return 0f;
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x93B470", Offset = "0x93A670", VA = "0x18093B470")]
		public Fixer()
		{
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD4")]
		[Address(RVA = "0x93AA20", Offset = "0x939C20", VA = "0x18093AA20", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD5")]
		[Address(RVA = "0x93AA00", Offset = "0x939C00", VA = "0x18093AA00", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD7")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04003663 RID: 13923
		[Token(Token = "0x4003663")]
		public const int ADDITIONAL_SIGNING_FEE_1 = 100;

		// Token: 0x04003664 RID: 13924
		[Token(Token = "0x4003664")]
		public const int ADDITIONAL_SIGNING_FEE_2 = 250;

		// Token: 0x04003665 RID: 13925
		[Token(Token = "0x4003665")]
		public const int MAX_SIGNING_FEE = 500;

		// Token: 0x04003666 RID: 13926
		[Token(Token = "0x4003666")]
		public const int ADDITIONAL_FEE_THRESHOLD = 5;

		// Token: 0x04003667 RID: 13927
		[Token(Token = "0x4003667")]
		[FieldOffset(Offset = "0x328")]
		public DialogueContainer GreetingDialogue;

		// Token: 0x04003668 RID: 13928
		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x330")]
		public string GreetedVariable;

		// Token: 0x04003669 RID: 13929
		[Token(Token = "0x4003669")]
		[FieldOffset(Offset = "0x338")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400366A RID: 13930
		[Token(Token = "0x400366A")]
		[FieldOffset(Offset = "0x339")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FixerAssembly-CSharp.dll_Excuted;
	}
}
