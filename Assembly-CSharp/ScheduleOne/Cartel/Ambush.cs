using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Core;
using ScheduleOne.Economy;
using ScheduleOne.Levelling;
using ScheduleOne.Map;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000788 RID: 1928
	[Token(Token = "0x2000788")]
	public class Ambush : CartelActivity
	{
		// Token: 0x0600334E RID: 13134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600334E")]
		[Address(RVA = "0x783CA0", Offset = "0x782EA0", VA = "0x180783CA0", Slot = "4")]
		public override void Activate(EMapRegion region)
		{
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600334F")]
		[Address(RVA = "0x7844B0", Offset = "0x7836B0", VA = "0x1807844B0", Slot = "7")]
		protected override void Deactivate()
		{
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003350")]
		[Address(RVA = "0x784620", Offset = "0x783820", VA = "0x180784620", Slot = "5")]
		protected override void MinPassed()
		{
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x6003351")]
		[Address(RVA = "0x783EB0", Offset = "0x7830B0", VA = "0x180783EB0")]
		private bool CanPlayerBeAmbushed(Player player)
		{
			return default(bool);
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003352")]
		[Address(RVA = "0x783F50", Offset = "0x783150", VA = "0x180783F50")]
		private void ContractReceiptRecorded(ContractReceipt receipt)
		{
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003353")]
		[Address(RVA = "0x784C10", Offset = "0x783E10", VA = "0x180784C10")]
		private void SpawnAmbush(Player target, Vector3[] potentialSpawnPoints)
		{
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003354")]
		[Address(RVA = "0x7853B0", Offset = "0x7845B0", VA = "0x1807853B0")]
		[Button]
		public void TriggerAmbushForPlayer()
		{
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003355")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public Ambush()
		{
		}

		// Token: 0x040025AD RID: 9645
		[Token(Token = "0x40025AD")]
		public const float MIN_DISTANCE_TO_POLICE_OFFICER = 15f;

		// Token: 0x040025AE RID: 9646
		[Token(Token = "0x40025AE")]
		public const int CANCEL_AMBUSH_AFTER_MINS = 360;

		// Token: 0x040025AF RID: 9647
		[Token(Token = "0x40025AF")]
		public const float AMBUSH_DEFEATED_INFLUENCE_CHANGE = -0.1f;

		// Token: 0x040025B0 RID: 9648
		[Token(Token = "0x40025B0")]
		[FieldOffset(Offset = "0x0")]
		public static FullRank MIN_RANK_FOR_RANGED_WEAPONS;

		// Token: 0x040025B1 RID: 9649
		[Token(Token = "0x40025B1")]
		[FieldOffset(Offset = "0x40")]
		private CartelRegionActivities _regionActivities;

		// Token: 0x040025B2 RID: 9650
		[Token(Token = "0x40025B2")]
		[FieldOffset(Offset = "0x48")]
		[Header("Settings")]
		public AvatarWeapon[] RangedWeapons;

		// Token: 0x040025B3 RID: 9651
		[Token(Token = "0x40025B3")]
		[FieldOffset(Offset = "0x50")]
		public AvatarWeapon[] MeleeWeapons;

		// Token: 0x040025B4 RID: 9652
		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0x58")]
		[Header("Debugging & Development")]
		public EMapRegion region;
	}
}
