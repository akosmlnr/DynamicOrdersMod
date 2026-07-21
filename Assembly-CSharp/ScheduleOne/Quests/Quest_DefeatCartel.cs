using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x0200033C RID: 828
	[Token(Token = "0x200033C")]
	public class Quest_DefeatCartel : Quest
	{
		// Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x5A6A20", Offset = "0x5A5C20", VA = "0x1805A6A20", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x5A65E0", Offset = "0x5A57E0", VA = "0x1805A65E0")]
		private void OnSleepEnd()
		{
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x5A6700", Offset = "0x5A5900", VA = "0x1805A6700", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x5A6830", Offset = "0x5A5A30", VA = "0x1805A6830", Slot = "42")]
		public override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x5A67A0", Offset = "0x5A59A0", VA = "0x1805A67A0")]
		public void PlayCountdownMusic()
		{
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x5A6550", Offset = "0x5A5750", VA = "0x1805A6550")]
		private void Defeat()
		{
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x5A6920", Offset = "0x5A5B20", VA = "0x1805A6920", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x5A6BE0", Offset = "0x5A5DE0", VA = "0x1805A6BE0")]
		public Quest_DefeatCartel()
		{
		}

		// Token: 0x04001279 RID: 4729
		[Token(Token = "0x4001279")]
		public const float DIG_TUNNEL_COST = 10000f;

		// Token: 0x0400127A RID: 4730
		[Token(Token = "0x400127A")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public Sam Sam;

		// Token: 0x0400127B RID: 4731
		[Token(Token = "0x400127B")]
		[FieldOffset(Offset = "0x140")]
		public Manor Manor;

		// Token: 0x0400127C RID: 4732
		[Token(Token = "0x400127C")]
		[FieldOffset(Offset = "0x148")]
		public QuestEntry DigTunnelEntry;

		// Token: 0x0400127D RID: 4733
		[Token(Token = "0x400127D")]
		[FieldOffset(Offset = "0x150")]
		public QuestEntry WaitForTunnelEntry;

		// Token: 0x0400127E RID: 4734
		[Token(Token = "0x400127E")]
		[FieldOffset(Offset = "0x158")]
		public QuestEntry EnquireAboutRDXEntry;

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x160")]
		public QuestEntry ObtainRDXEntry;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x168")]
		public QuestEntry EnquireAboutBombEntry;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x170")]
		public QuestEntry KillBanditEntry;

		// Token: 0x04001282 RID: 4738
		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x178")]
		public NPC Bandit;

		// Token: 0x04001283 RID: 4739
		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x180")]
		public GameObject BanditScheduleContainer;
	}
}
