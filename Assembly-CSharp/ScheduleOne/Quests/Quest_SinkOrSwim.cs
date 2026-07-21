using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	public class Quest_SinkOrSwim : Quest
	{
		// Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x5A8450", Offset = "0x5A7650", VA = "0x1805A8450", Slot = "30")]
		protected override void Awake()
		{
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x5A8B70", Offset = "0x5A7D70", VA = "0x1805A8B70", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x5A8790", Offset = "0x5A7990", VA = "0x1805A8790")]
		private void HourPass()
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x5A8850", Offset = "0x5A7A50", VA = "0x1805A8850")]
		private void SleepStart()
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x5A8A70", Offset = "0x5A7C70", VA = "0x1805A8A70")]
		private void SpawnLoanSharkVehicle()
		{
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x5A8490", Offset = "0x5A7690", VA = "0x1805A8490")]
		private void CheckArrival()
		{
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x5A8800", Offset = "0x5A7A00", VA = "0x1805A8800", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x5A8F50", Offset = "0x5A8150", VA = "0x1805A8F50")]
		private void UpdateName()
		{
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x5A9120", Offset = "0x5A8320", VA = "0x1805A9120")]
		public Quest_SinkOrSwim()
		{
		}

		// Token: 0x0400129A RID: 4762
		[Token(Token = "0x400129A")]
		public const int DAYS_TO_COMPLETE = 4;

		// Token: 0x0400129B RID: 4763
		[Token(Token = "0x400129B")]
		[FieldOffset(Offset = "0x138")]
		public string QuestName;

		// Token: 0x0400129C RID: 4764
		[Token(Token = "0x400129C")]
		[FieldOffset(Offset = "0x140")]
		public int NelsonCallTime;

		// Token: 0x0400129D RID: 4765
		[Token(Token = "0x400129D")]
		[FieldOffset(Offset = "0x148")]
		public Transform LoanSharkVehiclePosition;

		// Token: 0x0400129E RID: 4766
		[Token(Token = "0x400129E")]
		[FieldOffset(Offset = "0x150")]
		public GameObject LoanSharkGraves;
	}
}
