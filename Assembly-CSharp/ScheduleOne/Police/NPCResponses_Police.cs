using System;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;

namespace ScheduleOne.Police
{
	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x2000781")]
	public class NPCResponses_Police : NPCResponses
	{
		// Token: 0x060032C2 RID: 12994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C2")]
		[Address(RVA = "0x76ED30", Offset = "0x76DF30", VA = "0x18076ED30", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x76EF80", Offset = "0x76E180", VA = "0x18076EF80", Slot = "17")]
		public override void HitByCar(LandVehicle vehicle)
		{
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C4")]
		[Address(RVA = "0x76F5D0", Offset = "0x76E7D0", VA = "0x18076F5D0", Slot = "13")]
		public override void NoticedDrugDeal(Player player)
		{
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C5")]
		[Address(RVA = "0x76F7A0", Offset = "0x76E9A0", VA = "0x18076F7A0", Slot = "7")]
		public override void NoticedPettyCrime(Player player)
		{
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x76FA60", Offset = "0x76EC60", VA = "0x18076FA60", Slot = "8")]
		public override void NoticedVandalism(Player player)
		{
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C7")]
		[Address(RVA = "0x770B40", Offset = "0x76FD40", VA = "0x180770B40", Slot = "9")]
		public override void SawPickpocketing(Player player)
		{
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C8")]
		[Address(RVA = "0x770250", Offset = "0x76F450", VA = "0x180770250", Slot = "12")]
		public override void PlayerFailedPickpocket(Player player)
		{
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x76F230", Offset = "0x76E430", VA = "0x18076F230", Slot = "10")]
		public override void NoticePlayerBrandishingWeapon(Player player)
		{
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CA")]
		[Address(RVA = "0x76F400", Offset = "0x76E600", VA = "0x18076F400", Slot = "11")]
		public override void NoticePlayerDischargingWeapon(Player player)
		{
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CB")]
		[Address(RVA = "0x76FF70", Offset = "0x76F170", VA = "0x18076FF70", Slot = "15")]
		public override void NoticedWantedPlayer(Player player)
		{
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CC")]
		[Address(RVA = "0x76F920", Offset = "0x76EB20", VA = "0x18076F920", Slot = "16")]
		public override void NoticedSuspiciousPlayer(Player player)
		{
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CD")]
		[Address(RVA = "0x76FC30", Offset = "0x76EE30", VA = "0x18076FC30", Slot = "14")]
		public override void NoticedViolatingCurfew(Player player)
		{
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x7706D0", Offset = "0x76F8D0", VA = "0x1807706D0", Slot = "19")]
		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CF")]
		[Address(RVA = "0x770840", Offset = "0x76FA40", VA = "0x180770840", Slot = "21")]
		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D0")]
		[Address(RVA = "0x7709A0", Offset = "0x76FBA0", VA = "0x1807709A0", Slot = "20")]
		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D1")]
		[Address(RVA = "0x770500", Offset = "0x76F700", VA = "0x180770500", Slot = "22")]
		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D2")]
		[Address(RVA = "0x770420", Offset = "0x76F620", VA = "0x180770420", Slot = "23")]
		public override void RespondToAimedAt(Player player)
		{
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D3")]
		[Address(RVA = "0x76F1D0", Offset = "0x76E3D0", VA = "0x18076F1D0", Slot = "18")]
		public override void ImpactReceived(Impact impact)
		{
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D4")]
		[Address(RVA = "0x76EE10", Offset = "0x76E010", VA = "0x18076EE10", Slot = "5")]
		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D5")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public NPCResponses_Police()
		{
		}

		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x400255A")]
		[FieldOffset(Offset = "0x30")]
		private PoliceOfficer officer;
	}
}
