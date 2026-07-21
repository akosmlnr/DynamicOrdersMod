using System;
using Il2CppDummyDll;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A4B RID: 2635
	[Token(Token = "0x2000A4B")]
	public class NPCAwareness : MonoBehaviour
	{
		// Token: 0x06004BA1 RID: 19361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA1")]
		[Address(RVA = "0x919100", Offset = "0x918300", VA = "0x180919100", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004BA2 RID: 19362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA2")]
		[Address(RVA = "0x9195C0", Offset = "0x9187C0", VA = "0x1809195C0")]
		public void SetAwarenessActive(bool active)
		{
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA3")]
		[Address(RVA = "0x919620", Offset = "0x918820", VA = "0x180919620")]
		public void VisionEvent(VisionEventReceipt vEvent)
		{
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA4")]
		[Address(RVA = "0x919470", Offset = "0x918670", VA = "0x180919470")]
		public void NoiseEvent(NoiseEvent nEvent)
		{
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA5")]
		[Address(RVA = "0x9193B0", Offset = "0x9185B0", VA = "0x1809193B0")]
		public void HitByCar(LandVehicle vehicle)
		{
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0x620750", Offset = "0x61F950", VA = "0x180620750")]
		public NPCAwareness()
		{
		}

		// Token: 0x04003513 RID: 13587
		[Token(Token = "0x4003513")]
		public const float PLAYER_AIM_DETECTION_RANGE = 15f;

		// Token: 0x04003514 RID: 13588
		[Token(Token = "0x4003514")]
		[FieldOffset(Offset = "0x20")]
		public bool AwarenessActiveByDefault;

		// Token: 0x04003515 RID: 13589
		[Token(Token = "0x4003515")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public VisionCone VisionCone;

		// Token: 0x04003516 RID: 13590
		[Token(Token = "0x4003516")]
		[FieldOffset(Offset = "0x30")]
		public Listener Listener;

		// Token: 0x04003517 RID: 13591
		[Token(Token = "0x4003517")]
		[FieldOffset(Offset = "0x38")]
		public NPCResponses Responses;

		// Token: 0x04003518 RID: 13592
		[Token(Token = "0x4003518")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent<Player> onNoticedGeneralCrime;

		// Token: 0x04003519 RID: 13593
		[Token(Token = "0x4003519")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent<Player> onNoticedPettyCrime;

		// Token: 0x0400351A RID: 13594
		[Token(Token = "0x400351A")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent<Player> onNoticedDrugDealing;

		// Token: 0x0400351B RID: 13595
		[Token(Token = "0x400351B")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent<Player> onNoticedPlayerViolatingCurfew;

		// Token: 0x0400351C RID: 13596
		[Token(Token = "0x400351C")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent<Player> onNoticedSuspiciousPlayer;

		// Token: 0x0400351D RID: 13597
		[Token(Token = "0x400351D")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent<NoiseEvent> onGunshotHeard;

		// Token: 0x0400351E RID: 13598
		[Token(Token = "0x400351E")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent<NoiseEvent> onExplosionHeard;

		// Token: 0x0400351F RID: 13599
		[Token(Token = "0x400351F")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent<LandVehicle> onHitByCar;

		// Token: 0x04003520 RID: 13600
		[Token(Token = "0x4003520")]
		[FieldOffset(Offset = "0x80")]
		private NPC npc;
	}
}
