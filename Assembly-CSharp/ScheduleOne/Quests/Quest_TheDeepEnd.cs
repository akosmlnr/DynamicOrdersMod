using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.ScriptableObjects;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x0200034A RID: 842
	[Token(Token = "0x200034A")]
	public class Quest_TheDeepEnd : Quest
	{
		// Token: 0x060014A4 RID: 5284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x5A9700", Offset = "0x5A8900", VA = "0x1805A9700", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x5A9250", Offset = "0x5A8450", VA = "0x1805A9250", Slot = "34")]
		public override void Begin(bool network = true)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x5A94B0", Offset = "0x5A86B0", VA = "0x1805A94B0")]
		public void SetupFirstMeeting()
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x5A9A10", Offset = "0x5A8C10", VA = "0x1805A9A10")]
		private void ThomasDialogueNodeDisplayed(string nodeLabel)
		{
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x5A9270", Offset = "0x5A8470", VA = "0x1805A9270")]
		private void HourPass()
		{
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x5A91A0", Offset = "0x5A83A0", VA = "0x1805A91A0")]
		private void BeforeSleep()
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x5A95A0", Offset = "0x5A87A0", VA = "0x1805A95A0")]
		private void SleepFadeOut()
		{
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x5A9400", Offset = "0x5A8600", VA = "0x1805A9400", Slot = "42")]
		public override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x5A9C40", Offset = "0x5A8E40", VA = "0x1805A9C40")]
		public Quest_TheDeepEnd()
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x5A9BD0", Offset = "0x5A8DD0", VA = "0x1805A9BD0")]
		[CompilerGenerated]
		private IEnumerator <ThomasDialogueNodeDisplayed>g__Wait|13_0()
		{
			return null;
		}

		// Token: 0x0400129F RID: 4767
		[Token(Token = "0x400129F")]
		public const float MEETING_REMINDER_TIME = 36f;

		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		public const float KIDNAP_TIME = 82f;

		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		[FieldOffset(Offset = "0x138")]
		private bool kidnapQueued;

		// Token: 0x040012A2 RID: 4770
		[Token(Token = "0x40012A2")]
		[FieldOffset(Offset = "0x139")]
		private bool meetingSetup;

		// Token: 0x040012A3 RID: 4771
		[Token(Token = "0x40012A3")]
		[FieldOffset(Offset = "0x140")]
		public Thomas Thomas;

		// Token: 0x040012A4 RID: 4772
		[Token(Token = "0x40012A4")]
		[FieldOffset(Offset = "0x148")]
		public ManorGate Gate;

		// Token: 0x040012A5 RID: 4773
		[Token(Token = "0x40012A5")]
		[FieldOffset(Offset = "0x150")]
		public ModularSwitch Switch;

		// Token: 0x040012A6 RID: 4774
		[Token(Token = "0x40012A6")]
		[FieldOffset(Offset = "0x158")]
		public Transform MeetingTeleportPoint;

		// Token: 0x040012A7 RID: 4775
		[Token(Token = "0x40012A7")]
		[FieldOffset(Offset = "0x160")]
		public PhoneCallData PostMeetingCall;

		// Token: 0x040012A8 RID: 4776
		[Token(Token = "0x40012A8")]
		[FieldOffset(Offset = "0x168")]
		public SystemTriggerObject PostMeetingTrigger;
	}
}
