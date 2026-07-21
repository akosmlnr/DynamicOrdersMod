using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	public class Quest_WelcomeToHylandPoint : Quest
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x5AABE0", Offset = "0x5A9DE0", VA = "0x1805AABE0", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x5AAF00", Offset = "0x5AA100", VA = "0x1805AAF00")]
		private void Update()
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x5AAC50", Offset = "0x5A9E50", VA = "0x1805AAC50", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x5AA8D0", Offset = "0x5A9AD0", VA = "0x1805AA8D0")]
		public void BlowupRV()
		{
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x5AADF0", Offset = "0x5A9FF0", VA = "0x1805AADF0")]
		public void SetRVDestroyed()
		{
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x5AB160", Offset = "0x5AA360", VA = "0x1805AB160")]
		public Quest_WelcomeToHylandPoint()
		{
		}

		// Token: 0x040012B9 RID: 4793
		[Token(Token = "0x40012B9")]
		[FieldOffset(Offset = "0x138")]
		public QuestEntry ReturnToRVQuest;

		// Token: 0x040012BA RID: 4794
		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0x140")]
		public QuestEntry ReadMessagesQuest;

		// Token: 0x040012BB RID: 4795
		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x148")]
		public RV RV;

		// Token: 0x040012BC RID: 4796
		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0x150")]
		public UncleNelson Nelson;

		// Token: 0x040012BD RID: 4797
		[Token(Token = "0x40012BD")]
		[FieldOffset(Offset = "0x158")]
		[Header("Settings")]
		public float ExplosionMaxDist;

		// Token: 0x040012BE RID: 4798
		[Token(Token = "0x40012BE")]
		[FieldOffset(Offset = "0x15C")]
		public float ExplosionMinDist;

		// Token: 0x040012BF RID: 4799
		[Token(Token = "0x40012BF")]
		[FieldOffset(Offset = "0x160")]
		private float cameraLookTime;
	}
}
