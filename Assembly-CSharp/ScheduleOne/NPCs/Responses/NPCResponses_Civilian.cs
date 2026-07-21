using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Law;
using ScheduleOne.Noise;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Responses
{
	// Token: 0x02000A6A RID: 2666
	[Token(Token = "0x2000A6A")]
	public class NPCResponses_Civilian : NPCResponses
	{
		// Token: 0x06004D18 RID: 19736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D18")]
		[Address(RVA = "0x93EFD0", Offset = "0x93E1D0", VA = "0x18093EFD0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D19")]
		[Address(RVA = "0x93FB20", Offset = "0x93ED20", VA = "0x18093FB20", Slot = "5")]
		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x93F560", Offset = "0x93E760", VA = "0x18093F560", Slot = "6")]
		public override void ExplosionHeard(NoiseEvent explosionSound)
		{
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D1B")]
		[Address(RVA = "0x93FC90", Offset = "0x93EE90", VA = "0x18093FC90", Slot = "12")]
		public override void PlayerFailedPickpocket(Player player)
		{
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D1C")]
		[Address(RVA = "0x9404E0", Offset = "0x93F6E0", VA = "0x1809404E0", Slot = "19")]
		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D1D")]
		[Address(RVA = "0x940240", Offset = "0x93F440", VA = "0x180940240", Slot = "22")]
		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D1E")]
		[Address(RVA = "0x940740", Offset = "0x93F940", VA = "0x180940740", Slot = "21")]
		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D1F")]
		[Address(RVA = "0x940A90", Offset = "0x93FC90", VA = "0x180940A90", Slot = "20")]
		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D20")]
		[Address(RVA = "0x940780", Offset = "0x93F980", VA = "0x180940780")]
		private void RespondToLethalOrRepeatedAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D21")]
		[Address(RVA = "0x9400E0", Offset = "0x93F2E0", VA = "0x1809400E0", Slot = "23")]
		public override void RespondToAimedAt(Player player)
		{
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D22")]
		[Address(RVA = "0x93F000", Offset = "0x93E200", VA = "0x18093F000")]
		private void ExecuteThreatResponse(NPCResponses_Civilian.EAttackResponse response, Player target, Vector3 threatOrigin, [Optional] Crime crime)
		{
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x00014B50 File Offset: 0x00012D50
		[Token(Token = "0x6004D23")]
		[Address(RVA = "0x93F7B0", Offset = "0x93E9B0", VA = "0x18093F7B0")]
		private NPCResponses_Civilian.EAttackResponse GetThreatResponse(NPCResponses_Civilian.EThreatType type, Player threatSource)
		{
			return NPCResponses_Civilian.EAttackResponse.None;
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D24")]
		[Address(RVA = "0x940C60", Offset = "0x93FE60", VA = "0x180940C60")]
		public NPCResponses_Civilian()
		{
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004D29")]
		[Address(RVA = "0x940BD0", Offset = "0x93FDD0", VA = "0x180940BD0")]
		[CompilerGenerated]
		private IEnumerator <ExecuteThreatResponse>g__WaitForThreatResponseEnd|17_4(Func<bool> condition)
		{
			return null;
		}

		// Token: 0x04003600 RID: 13824
		[Token(Token = "0x4003600")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Response Settings")]
		public bool CanCallPolice;

		// Token: 0x04003601 RID: 13825
		[Token(Token = "0x4003601")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool OverrideThreatResponses;

		// Token: 0x04003602 RID: 13826
		[Token(Token = "0x4003602")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public NPCResponses_Civilian.EAttackResponse ThreatResponseOverride;

		// Token: 0x04003603 RID: 13827
		[Token(Token = "0x4003603")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NPCResponses_Civilian.EAttackResponse currentThreatResponse;

		// Token: 0x04003604 RID: 13828
		[Token(Token = "0x4003604")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float lastThreatTime;

		// Token: 0x02000A6B RID: 2667
		[Token(Token = "0x2000A6B")]
		public enum EAttackResponse
		{
			// Token: 0x04003606 RID: 13830
			[Token(Token = "0x4003606")]
			None,
			// Token: 0x04003607 RID: 13831
			[Token(Token = "0x4003607")]
			Panic,
			// Token: 0x04003608 RID: 13832
			[Token(Token = "0x4003608")]
			Flee,
			// Token: 0x04003609 RID: 13833
			[Token(Token = "0x4003609")]
			CallPolice,
			// Token: 0x0400360A RID: 13834
			[Token(Token = "0x400360A")]
			Fight
		}

		// Token: 0x02000A6C RID: 2668
		[Token(Token = "0x2000A6C")]
		public enum EThreatType
		{
			// Token: 0x0400360C RID: 13836
			[Token(Token = "0x400360C")]
			None,
			// Token: 0x0400360D RID: 13837
			[Token(Token = "0x400360D")]
			AimedAt,
			// Token: 0x0400360E RID: 13838
			[Token(Token = "0x400360E")]
			GunshotHeard,
			// Token: 0x0400360F RID: 13839
			[Token(Token = "0x400360F")]
			ExplosionHeard
		}
	}
}
