using System;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Levelling;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000ABA RID: 2746
	[Token(Token = "0x2000ABA")]
	public class Ray : NPC
	{
		// Token: 0x06004EE2 RID: 20194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE2")]
		[Address(RVA = "0x941E50", Offset = "0x941050", VA = "0x180941E50", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE3")]
		[Address(RVA = "0x941980", Offset = "0x940B80", VA = "0x180941980")]
		private void Loaded()
		{
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE4")]
		[Address(RVA = "0x9418A0", Offset = "0x940AA0", VA = "0x1809418A0")]
		private void EnableGreeting()
		{
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE5")]
		[Address(RVA = "0x941CC0", Offset = "0x940EC0", VA = "0x180941CC0")]
		private void SetGreeted()
		{
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE6")]
		[Address(RVA = "0x941BE0", Offset = "0x940DE0", VA = "0x180941BE0")]
		private void NotifyPlayerOfManorRebuild()
		{
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE7")]
		[Address(RVA = "0x9421C0", Offset = "0x9413C0", VA = "0x1809421C0")]
		public Ray()
		{
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE8")]
		[Address(RVA = "0x941BC0", Offset = "0x940DC0", VA = "0x180941BC0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE9")]
		[Address(RVA = "0x941BA0", Offset = "0x940DA0", VA = "0x180941BA0", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x040036DE RID: 14046
		[Token(Token = "0x40036DE")]
		[FieldOffset(Offset = "0x328")]
		public DialogueContainer GreetingDialogue;

		// Token: 0x040036DF RID: 14047
		[Token(Token = "0x40036DF")]
		[FieldOffset(Offset = "0x330")]
		public string GreetedVariable;

		// Token: 0x040036E0 RID: 14048
		[Token(Token = "0x40036E0")]
		[FieldOffset(Offset = "0x338")]
		public string IntroductionMessage;

		// Token: 0x040036E1 RID: 14049
		[Token(Token = "0x40036E1")]
		[FieldOffset(Offset = "0x340")]
		public string IntroSentVariable;

		// Token: 0x040036E2 RID: 14050
		[Token(Token = "0x40036E2")]
		[FieldOffset(Offset = "0x348")]
		[Header("Intro message conditions")]
		public FullRank IntroRank;

		// Token: 0x040036E3 RID: 14051
		[Token(Token = "0x40036E3")]
		[FieldOffset(Offset = "0x350")]
		public int IntroDaysPlayed;

		// Token: 0x040036E4 RID: 14052
		[Token(Token = "0x40036E4")]
		[FieldOffset(Offset = "0x354")]
		public float IntroNetworth;

		// Token: 0x040036E5 RID: 14053
		[Token(Token = "0x40036E5")]
		[FieldOffset(Offset = "0x358")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.RayAssembly-CSharp.dll_Excuted;

		// Token: 0x040036E6 RID: 14054
		[Token(Token = "0x40036E6")]
		[FieldOffset(Offset = "0x359")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.RayAssembly-CSharp.dll_Excuted;
	}
}
