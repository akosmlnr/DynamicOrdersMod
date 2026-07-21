using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000799 RID: 1945
	[Token(Token = "0x2000799")]
	public class CartelDealer : Dealer
	{
		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x0000FC00 File Offset: 0x0000DE00
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084A")]
		public bool IsAcceptingDeals
		{
			[Token(Token = "0x60033CF")]
			[Address(RVA = "0x794740", Offset = "0x793940", VA = "0x180794740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033D0")]
			[Address(RVA = "0x794750", Offset = "0x793950", VA = "0x180794750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700084B")]
		private GoonPool GoonPool
		{
			[Token(Token = "0x60033D1")]
			[Address(RVA = "0x7946C0", Offset = "0x7938C0", VA = "0x1807946C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x7945C0", Offset = "0x7937C0", VA = "0x1807945C0", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D3")]
		[Address(RVA = "0x793B60", Offset = "0x792D60", VA = "0x180793B60", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x793C80", Offset = "0x792E80", VA = "0x180793C80")]
		public void RandomizeInventory()
		{
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D5")]
		[Address(RVA = "0x793BE0", Offset = "0x792DE0", VA = "0x180793BE0")]
		public void RandomizeAppearance()
		{
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x7936E0", Offset = "0x7928E0", VA = "0x1807936E0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ConfigureGoonSettings(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D7")]
		[Address(RVA = "0x794430", Offset = "0x793630", VA = "0x180794430")]
		public void SetIsAcceptingDeals(bool accepting)
		{
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x60033D8")]
		[Address(RVA = "0x7936B0", Offset = "0x7928B0", VA = "0x1807936B0")]
		public bool CanCurrentlyAcceptDeal()
		{
			return default(bool);
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D9")]
		[Address(RVA = "0x793990", Offset = "0x792B90", VA = "0x180793990")]
		private void DiedOrKnockedOut()
		{
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DA")]
		[Address(RVA = "0x794670", Offset = "0x793870", VA = "0x180794670")]
		public CartelDealer()
		{
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DB")]
		[Address(RVA = "0x793A80", Offset = "0x792C80", VA = "0x180793A80", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DC")]
		[Address(RVA = "0x793A60", Offset = "0x792C60", VA = "0x180793A60", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DD")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DE")]
		[Address(RVA = "0x794160", Offset = "0x793360", VA = "0x180794160")]
		private void RpcWriter___Observers_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x793E10", Offset = "0x793010", VA = "0x180793E10")]
		private void RpcLogic___ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x794050", Offset = "0x793250", VA = "0x180794050")]
		private void RpcReader___Observers_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E1")]
		[Address(RVA = "0x7942D0", Offset = "0x7934D0", VA = "0x1807942D0")]
		private void RpcWriter___Target_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E2")]
		[Address(RVA = "0x7940E0", Offset = "0x7932E0", VA = "0x1807940E0")]
		private void RpcReader___Target_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E3")]
		[Address(RVA = "0x793660", Offset = "0x792860", VA = "0x180793660", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x040025EA RID: 9706
		[Token(Token = "0x40025EA")]
		public const float DEALER_DEFEATED_INFLUENCE_CHANGE = -0.1f;

		// Token: 0x040025EB RID: 9707
		[Token(Token = "0x40025EB")]
		public const int PRODUCT_COUNT_MIN = 2;

		// Token: 0x040025EC RID: 9708
		[Token(Token = "0x40025EC")]
		public const int PRODUCT_COUNT_MAX = 4;

		// Token: 0x040025ED RID: 9709
		[Token(Token = "0x40025ED")]
		public const int PRODUCT_QUANTITY_MIN = 1;

		// Token: 0x040025EE RID: 9710
		[Token(Token = "0x40025EE")]
		public const int PRODUCT_QUANTITY_MAX = 10;

		// Token: 0x040025F0 RID: 9712
		[Token(Token = "0x40025F0")]
		[FieldOffset(Offset = "0x428")]
		[Header("Cartel Dealer Inventory Settings")]
		public ProductDefinition[] RandomProducts;

		// Token: 0x040025F1 RID: 9713
		[Token(Token = "0x40025F1")]
		[FieldOffset(Offset = "0x430")]
		public EQuality ProductQuality;

		// Token: 0x040025F2 RID: 9714
		[Token(Token = "0x40025F2")]
		[FieldOffset(Offset = "0x438")]
		public PackagingDefinition DefaultPackaging;

		// Token: 0x040025F3 RID: 9715
		[Token(Token = "0x40025F3")]
		[FieldOffset(Offset = "0x440")]
		private CartelGoonAppearance appearance;

		// Token: 0x040025F4 RID: 9716
		[Token(Token = "0x40025F4")]
		[FieldOffset(Offset = "0x448")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelDealerAssembly-CSharp.dll_Excuted;

		// Token: 0x040025F5 RID: 9717
		[Token(Token = "0x40025F5")]
		[FieldOffset(Offset = "0x449")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelDealerAssembly-CSharp.dll_Excuted;
	}
}
