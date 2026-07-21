using System;
using Il2CppDummyDll;
using ScheduleOne.Cartel;
using ScheduleOne.Combat;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Police
{
	// Token: 0x0200077F RID: 1919
	[Token(Token = "0x200077F")]
	public class NPCResponses_CartelGoon : NPCResponses
	{
		// Token: 0x060032B2 RID: 12978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x76E7E0", Offset = "0x76D9E0", VA = "0x18076E7E0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x76E7F0", Offset = "0x76D9F0", VA = "0x18076E7F0", Slot = "6")]
		public override void ExplosionHeard(NoiseEvent explosionSound)
		{
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B4")]
		[Address(RVA = "0x76E7F0", Offset = "0x76D9F0", VA = "0x18076E7F0", Slot = "5")]
		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B5")]
		[Address(RVA = "0x76EA60", Offset = "0x76DC60", VA = "0x18076EA60", Slot = "11")]
		public override void NoticePlayerDischargingWeapon(Player player)
		{
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B6")]
		[Address(RVA = "0x76EAF0", Offset = "0x76DCF0", VA = "0x18076EAF0", Slot = "12")]
		public override void PlayerFailedPickpocket(Player player)
		{
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B7")]
		[Address(RVA = "0x76E890", Offset = "0x76DA90", VA = "0x18076E890", Slot = "17")]
		public override void HitByCar(LandVehicle vehicle)
		{
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B8")]
		[Address(RVA = "0x76E8D0", Offset = "0x76DAD0", VA = "0x18076E8D0", Slot = "18")]
		public override void ImpactReceived(Impact impact)
		{
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B9")]
		[Address(RVA = "0x76EB30", Offset = "0x76DD30", VA = "0x18076EB30", Slot = "23")]
		public override void RespondToAimedAt(Player player)
		{
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032BA")]
		[Address(RVA = "0x76EB70", Offset = "0x76DD70", VA = "0x18076EB70", Slot = "22")]
		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032BB")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public NPCResponses_CartelGoon()
		{
		}

		// Token: 0x04002557 RID: 9559
		[Token(Token = "0x4002557")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public CartelGoon Goon;
	}
}
