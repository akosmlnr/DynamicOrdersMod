using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	public class Quest_UnfavourableAgreements : Quest
	{
		// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0", Slot = "30")]
		protected override void Awake()
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x5AA500", Offset = "0x5A9700", VA = "0x1805AA500", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x5A9CC0", Offset = "0x5A8EC0", VA = "0x1805A9CC0")]
		private void CheckQuestStart()
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x5A9C90", Offset = "0x5A8E90", VA = "0x1805A9C90", Slot = "34")]
		public override void Begin(bool network = true)
		{
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x5AA1D0", Offset = "0x5A93D0", VA = "0x1805AA1D0", Slot = "44")]
		protected override void OnUncappedMinPass()
		{
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x5AA380", Offset = "0x5A9580", VA = "0x1805AA380", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x5AA0B0", Offset = "0x5A92B0", VA = "0x1805AA0B0")]
		private void MeetingEnded()
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x5A9FF0", Offset = "0x5A91F0", VA = "0x1805A9FF0")]
		private void DriveCallback(VehicleAgent.ENavigationResult result)
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x5AA2D0", Offset = "0x5A94D0", VA = "0x1805AA2D0")]
		private void Park()
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x5AA730", Offset = "0x5A9930", VA = "0x1805AA730")]
		public Quest_UnfavourableAgreements()
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x5AA6C0", Offset = "0x5A98C0", VA = "0x1805AA6C0")]
		[CompilerGenerated]
		private IEnumerator <MeetingEnded>g__Wait|14_0()
		{
			return null;
		}

		// Token: 0x040012AE RID: 4782
		[Token(Token = "0x40012AE")]
		[FieldOffset(Offset = "0x138")]
		public LandVehicle MeetingVehicle;

		// Token: 0x040012AF RID: 4783
		[Token(Token = "0x40012AF")]
		[FieldOffset(Offset = "0x140")]
		public ParkingLot MeetingParkingLot;

		// Token: 0x040012B0 RID: 4784
		[Token(Token = "0x40012B0")]
		[FieldOffset(Offset = "0x148")]
		public ParkingLot ManorParkingLot;

		// Token: 0x040012B1 RID: 4785
		[Token(Token = "0x40012B1")]
		[FieldOffset(Offset = "0x150")]
		public Thomas Thomas;

		// Token: 0x040012B2 RID: 4786
		[Token(Token = "0x40012B2")]
		[FieldOffset(Offset = "0x158")]
		public QuestEntry ReadMessageQuestEntry;

		// Token: 0x040012B3 RID: 4787
		[Token(Token = "0x40012B3")]
		[FieldOffset(Offset = "0x160")]
		public QuestEntry MeetingQuestEntry;

		// Token: 0x040012B4 RID: 4788
		[Token(Token = "0x40012B4")]
		[FieldOffset(Offset = "0x168")]
		public Quest PrereqQuest;

		// Token: 0x040012B5 RID: 4789
		[Token(Token = "0x40012B5")]
		[FieldOffset(Offset = "0x170")]
		public UnityEvent onMeetingConcluded;
	}
}
