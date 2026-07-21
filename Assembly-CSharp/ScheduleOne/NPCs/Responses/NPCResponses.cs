using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Actions;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.NPCs.Responses
{
	// Token: 0x02000A69 RID: 2665
	[Token(Token = "0x2000A69")]
	public class NPCResponses : MonoBehaviour
	{
		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06004D00 RID: 19712 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004D01 RID: 19713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF3")]
		private protected NPC npc
		{
			[Token(Token = "0x6004D00")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6004D01")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06004D02 RID: 19714 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BF4")]
		protected NPCActions actions
		{
			[Token(Token = "0x6004D02")]
			[Address(RVA = "0x92B610", Offset = "0x92A810", VA = "0x18092B610")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D03")]
		[Address(RVA = "0x92AFD0", Offset = "0x92A1D0", VA = "0x18092AFD0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D04")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		public virtual void GunshotHeard(NoiseEvent gunshotSound)
		{
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D05")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		public virtual void ExplosionHeard(NoiseEvent explosionSound)
		{
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D06")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "7")]
		public virtual void NoticedPettyCrime(Player player)
		{
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D07")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "8")]
		public virtual void NoticedVandalism(Player player)
		{
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D08")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "9")]
		public virtual void SawPickpocketing(Player player)
		{
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D09")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "10")]
		public virtual void NoticePlayerBrandishingWeapon(Player player)
		{
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D0A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "11")]
		public virtual void NoticePlayerDischargingWeapon(Player player)
		{
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D0B")]
		[Address(RVA = "0x92B460", Offset = "0x92A660", VA = "0x18092B460", Slot = "12")]
		public virtual void PlayerFailedPickpocket(Player player)
		{
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D0C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "13")]
		public virtual void NoticedDrugDeal(Player player)
		{
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D0D")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "14")]
		public virtual void NoticedViolatingCurfew(Player player)
		{
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D0E")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "15")]
		public virtual void NoticedWantedPlayer(Player player)
		{
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D0F")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "16")]
		public virtual void NoticedSuspiciousPlayer(Player player)
		{
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D10")]
		[Address(RVA = "0x92B050", Offset = "0x92A250", VA = "0x18092B050", Slot = "17")]
		public virtual void HitByCar(LandVehicle vehicle)
		{
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D11")]
		[Address(RVA = "0x92B2F0", Offset = "0x92A4F0", VA = "0x18092B2F0", Slot = "18")]
		public virtual void ImpactReceived(Impact impact)
		{
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D12")]
		[Address(RVA = "0x92B530", Offset = "0x92A730", VA = "0x18092B530", Slot = "19")]
		protected virtual void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D13")]
		[Address(RVA = "0x92B530", Offset = "0x92A730", VA = "0x18092B530", Slot = "20")]
		protected virtual void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D14")]
		[Address(RVA = "0x92B5A0", Offset = "0x92A7A0", VA = "0x18092B5A0", Slot = "21")]
		protected virtual void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D15")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "22")]
		protected virtual void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D16")]
		[Address(RVA = "0x92B4C0", Offset = "0x92A6C0", VA = "0x18092B4C0", Slot = "23")]
		public virtual void RespondToAimedAt(Player player)
		{
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D17")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public NPCResponses()
		{
		}

		// Token: 0x040035F7 RID: 13815
		[Token(Token = "0x40035F7")]
		public const float ASSAULT_RELATIONSHIPCHANGE = -0.25f;

		// Token: 0x040035F8 RID: 13816
		[Token(Token = "0x40035F8")]
		public const float DEADLYASSAULT_RELATIONSHIPCHANGE = -1f;

		// Token: 0x040035F9 RID: 13817
		[Token(Token = "0x40035F9")]
		public const float AIMED_AT_RELATIONSHIPCHANGE = -0.5f;

		// Token: 0x040035FA RID: 13818
		[Token(Token = "0x40035FA")]
		public const float PICKPOCKET_RELATIONSHIPCHANGE = -0.25f;

		// Token: 0x040035FC RID: 13820
		[Token(Token = "0x40035FC")]
		private const float INITIALIZED_TIME_OFFSET = 100f;

		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		private const float TIME_THRESHOLD = 20f;

		// Token: 0x040035FE RID: 13822
		[Token(Token = "0x40035FE")]
		[FieldOffset(Offset = "0x28")]
		protected float timeSinceLastImpact;

		// Token: 0x040035FF RID: 13823
		[Token(Token = "0x40035FF")]
		[FieldOffset(Offset = "0x2C")]
		protected float timeSinceAimedAt;
	}
}
