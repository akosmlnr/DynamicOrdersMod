using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000AAC RID: 2732
	[Token(Token = "0x2000AAC")]
	public class Marco : NPC
	{
		// Token: 0x06004E88 RID: 20104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E88")]
		[Address(RVA = "0x93C430", Offset = "0x93B630", VA = "0x18093C430", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E89")]
		[Address(RVA = "0x93CD60", Offset = "0x93BF60", VA = "0x18093CD60", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x00014DD8 File Offset: 0x00012FD8
		[Token(Token = "0x6004E8A")]
		[Address(RVA = "0x93CCC0", Offset = "0x93BEC0", VA = "0x18093CCC0")]
		private bool ShouldShowRecoverVehicle(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x00014DF0 File Offset: 0x00012FF0
		[Token(Token = "0x6004E8B")]
		[Address(RVA = "0x93C7C0", Offset = "0x93B9C0", VA = "0x18093C7C0")]
		private bool RecoverVehicleValid(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x00014E08 File Offset: 0x00013008
		[Token(Token = "0x6004E8C")]
		[Address(RVA = "0x93CA10", Offset = "0x93BC10", VA = "0x18093CA10")]
		private bool RepaintVehicleValid(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E8D")]
		[Address(RVA = "0x93C940", Offset = "0x93BB40", VA = "0x18093C940")]
		private void RecoverVehicle()
		{
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E8E")]
		[Address(RVA = "0x93C560", Offset = "0x93B760", VA = "0x18093C560")]
		private void Loaded()
		{
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E8F")]
		[Address(RVA = "0x93C480", Offset = "0x93B680", VA = "0x18093C480")]
		private void EnableGreeting()
		{
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E90")]
		[Address(RVA = "0x93CB30", Offset = "0x93BD30", VA = "0x18093CB30")]
		private void SetGreeted()
		{
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E91")]
		[Address(RVA = "0x93CFE0", Offset = "0x93C1E0", VA = "0x18093CFE0")]
		public Marco()
		{
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x93C7A0", Offset = "0x93B9A0", VA = "0x18093C7A0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x93C780", Offset = "0x93B980", VA = "0x18093C780", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E96")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E97")]
		[Address(RVA = "0x93C070", Offset = "0x93B270", VA = "0x18093C070", Slot = "130")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.Marco_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040036B7 RID: 14007
		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x328")]
		public Transform VehicleRecoveryPoint;

		// Token: 0x040036B8 RID: 14008
		[Token(Token = "0x40036B8")]
		[FieldOffset(Offset = "0x330")]
		public VehicleDetector VehicleDetector;

		// Token: 0x040036B9 RID: 14009
		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0x338")]
		public DialogueContainer RecoveryConversation;

		// Token: 0x040036BA RID: 14010
		[Token(Token = "0x40036BA")]
		[FieldOffset(Offset = "0x340")]
		public DialogueContainer GreetingDialogue;

		// Token: 0x040036BB RID: 14011
		[Token(Token = "0x40036BB")]
		[FieldOffset(Offset = "0x348")]
		public string GreetedVariable;

		// Token: 0x040036BC RID: 14012
		[Token(Token = "0x40036BC")]
		[FieldOffset(Offset = "0x350")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted;

		// Token: 0x040036BD RID: 14013
		[Token(Token = "0x40036BD")]
		[FieldOffset(Offset = "0x351")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted;
	}
}
