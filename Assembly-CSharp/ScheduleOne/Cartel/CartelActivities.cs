using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000795 RID: 1941
	[Token(Token = "0x2000795")]
	public class CartelActivities : NetworkBehaviour
	{
		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000848")]
		public CartelActivity CurrentGlobalActivity
		{
			[Token(Token = "0x60033AB")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033AC")]
			[Address(RVA = "0x5AF0A0", Offset = "0x5AE2A0", VA = "0x1805AF0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x0000FB58 File Offset: 0x0000DD58
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000849")]
		public int HoursUntilNextGlobalActivity
		{
			[Token(Token = "0x60033AD")]
			[Address(RVA = "0x5219D0", Offset = "0x520BD0", VA = "0x1805219D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60033AE")]
			[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033AF")]
		[Address(RVA = "0x78F740", Offset = "0x78E940", VA = "0x18078F740")]
		private void Start()
		{
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B0")]
		[Address(RVA = "0x78EDE0", Offset = "0x78DFE0", VA = "0x18078EDE0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60033B1")]
		[Address(RVA = "0x78E760", Offset = "0x78D960", VA = "0x18078E760")]
		public CartelRegionActivities GetRegionalActivities(EMapRegion region)
		{
			return null;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x78EBD0", Offset = "0x78DDD0", VA = "0x18078EBD0")]
		private void HourPass()
		{
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B3")]
		[Address(RVA = "0x78F890", Offset = "0x78EA90", VA = "0x18078F890")]
		private void TryStartActivity()
		{
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B4")]
		[Address(RVA = "0x78F490", Offset = "0x78E690", VA = "0x18078F490")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void StartGlobalActivity(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033B5")]
		[Address(RVA = "0x78DDD0", Offset = "0x78CFD0", VA = "0x18078DDD0")]
		private void ActivityEnded()
		{
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x0000FB70 File Offset: 0x0000DD70
		[Token(Token = "0x60033B6")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
		private bool CanNewActivityBegin()
		{
			return default(bool);
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60033B7")]
		[Address(RVA = "0x78DEF0", Offset = "0x78D0F0", VA = "0x18078DEF0")]
		private List<CartelActivity> GetActivitiesReadyToStart()
		{
			return null;
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60033B8")]
		[Address(RVA = "0x78E860", Offset = "0x78DA60", VA = "0x18078E860")]
		private List<EMapRegion> GetValidRegionsForActivity()
		{
			return null;
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x0000FB88 File Offset: 0x0000DD88
		[Token(Token = "0x60033B9")]
		[Address(RVA = "0x78E310", Offset = "0x78D510", VA = "0x18078E310")]
		public static int GetNewCooldown()
		{
			return 0;
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		[Token(Token = "0x60033BA")]
		[Address(RVA = "0x78E050", Offset = "0x78D250", VA = "0x18078E050")]
		private static float GetInfluenceFraction()
		{
			return 0f;
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BB")]
		[Address(RVA = "0x78FE90", Offset = "0x78F090", VA = "0x18078FE90")]
		public CartelActivities()
		{
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BC")]
		[Address(RVA = "0x78ED10", Offset = "0x78DF10", VA = "0x18078ED10", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BD")]
		[Address(RVA = "0x6A38F0", Offset = "0x6A2AF0", VA = "0x1806A38F0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BE")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BF")]
		[Address(RVA = "0x78F1B0", Offset = "0x78E3B0", VA = "0x18078F1B0")]
		private void RpcWriter___Observers_StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x78EED0", Offset = "0x78E0D0", VA = "0x18078EED0")]
		private void RpcLogic___StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x78F090", Offset = "0x78E290", VA = "0x18078F090")]
		private void RpcReader___Observers_StartGlobalActivity_1796582335(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x78F320", Offset = "0x78E520", VA = "0x18078F320")]
		private void RpcWriter___Target_StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x78F120", Offset = "0x78E320", VA = "0x18078F120")]
		private void RpcReader___Target_StartGlobalActivity_1796582335(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x040025DA RID: 9690
		[Token(Token = "0x40025DA")]
		public const int MAX_COOLDOWN_HOURS = 24;

		// Token: 0x040025DB RID: 9691
		[Token(Token = "0x40025DB")]
		public const int MIN_COOLDOWN_HOURS = 6;

		// Token: 0x040025DE RID: 9694
		[Token(Token = "0x40025DE")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public List<CartelActivity> GlobalActivities;

		// Token: 0x040025DF RID: 9695
		[Token(Token = "0x40025DF")]
		[FieldOffset(Offset = "0x130")]
		public CartelRegionActivities[] RegionalActivities;

		// Token: 0x040025E0 RID: 9696
		[Token(Token = "0x40025E0")]
		[FieldOffset(Offset = "0x138")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelActivitiesAssembly-CSharp.dll_Excuted;

		// Token: 0x040025E1 RID: 9697
		[Token(Token = "0x40025E1")]
		[FieldOffset(Offset = "0x139")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelActivitiesAssembly-CSharp.dll_Excuted;
	}
}
