using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Property;
using ScheduleOne.UI.Phone.Delivery;
using ScheduleOne.UI.Shop;

namespace ScheduleOne.Delivery
{
	// Token: 0x0200072E RID: 1838
	[Token(Token = "0x200072E")]
	public class DeliveryManager : NetworkSingleton<DeliveryManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06003005 RID: 12293 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003006 RID: 12294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000F")]
		public event Action<DeliveryInstance> onDeliveryCreated
		{
			[Token(Token = "0x6003005")]
			[Address(RVA = "0x764010", Offset = "0x763210", VA = "0x180764010")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003006")]
			[Address(RVA = "0x764230", Offset = "0x763430", VA = "0x180764230")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06003007 RID: 12295 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003008 RID: 12296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000010")]
		public event Action<DeliveryInstance> onDeliveryCompleted
		{
			[Token(Token = "0x6003007")]
			[Address(RVA = "0x763F50", Offset = "0x763150", VA = "0x180763F50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003008")]
			[Address(RVA = "0x764170", Offset = "0x763370", VA = "0x180764170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007DD")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003009")]
			[Address(RVA = "0x764140", Offset = "0x763340", VA = "0x180764140", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007DE")]
		public string SaveFileName
		{
			[Token(Token = "0x600300A")]
			[Address(RVA = "0x764110", Offset = "0x763310", VA = "0x180764110", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007DF")]
		public Loader Loader
		{
			[Token(Token = "0x600300B")]
			[Address(RVA = "0x57F810", Offset = "0x57EA10", VA = "0x18057F810", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x170007E0")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x600300C")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E1")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x600300D")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600300E")]
			[Address(RVA = "0x57F870", Offset = "0x57EA70", VA = "0x18057F870", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E2")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x600300F")]
			[Address(RVA = "0x6BCCA0", Offset = "0x6BBEA0", VA = "0x1806BCCA0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003010")]
			[Address(RVA = "0x6BCD20", Offset = "0x6BBF20", VA = "0x1806BCD20", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E3")]
		public bool HasChanged
		{
			[Token(Token = "0x6003011")]
			[Address(RVA = "0x6BCC80", Offset = "0x6BBE80", VA = "0x1806BCC80", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003012")]
			[Address(RVA = "0x6BCD10", Offset = "0x6BBF10", VA = "0x1806BCD10", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x0000EF10 File Offset: 0x0000D110
		[Token(Token = "0x170007E4")]
		public int LoadOrder
		{
			[Token(Token = "0x6003013")]
			[Address(RVA = "0x755920", Offset = "0x754B20", VA = "0x180755920", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007E5")]
		public List<DeliveryReceipt> DisplayedDeliveryHistory
		{
			[Token(Token = "0x6003014")]
			[Address(RVA = "0x7640D0", Offset = "0x7632D0", VA = "0x1807640D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003015")]
		[Address(RVA = "0x7614C0", Offset = "0x7606C0", VA = "0x1807614C0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003016")]
		[Address(RVA = "0x763AD0", Offset = "0x762CD0", VA = "0x180763AD0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003017")]
		[Address(RVA = "0x761C00", Offset = "0x760E00", VA = "0x180761C00", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003018")]
		[Address(RVA = "0x762270", Offset = "0x761470", VA = "0x180762270", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003019")]
		[Address(RVA = "0x7623F0", Offset = "0x7615F0", VA = "0x1807623F0")]
		private void OnTimePass(int minutes)
		{
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x0000EF28 File Offset: 0x0000D128
		[Token(Token = "0x600301A")]
		[Address(RVA = "0x761C90", Offset = "0x760E90", VA = "0x180761C90")]
		public bool IsLoadingBayFree(Property destination, int loadingDockIndex)
		{
			return default(bool);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600301B")]
		[Address(RVA = "0x7636E0", Offset = "0x7628E0", VA = "0x1807636E0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendDelivery(DeliveryInstance delivery)
		{
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600301C")]
		[Address(RVA = "0x762950", Offset = "0x761B50", VA = "0x180762950")]
		[ServerRpc(RequireOwnership = false)]
		public void RecordDeliveryReceipt_Server(DeliveryReceipt receipt, string originalOrderID = "")
		{
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600301D")]
		[Address(RVA = "0x762750", Offset = "0x761950", VA = "0x180762750")]
		[TargetRpc]
		[ObserversRpc]
		private void ReceiveDelivery(NetworkConnection conn, DeliveryInstance delivery)
		{
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600301E")]
		[Address(RVA = "0x763970", Offset = "0x762B70", VA = "0x180763970")]
		[ObserversRpc(RunLocally = true)]
		private void SetDeliveryState(string deliveryID, EDeliveryStatus status)
		{
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600301F")]
		[Address(RVA = "0x761620", Offset = "0x760820", VA = "0x180761620")]
		private DeliveryInstance GetDelivery(string deliveryID)
		{
			return null;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003020")]
		[Address(RVA = "0x761700", Offset = "0x760900", VA = "0x180761700")]
		public DeliveryInstance GetDelivery(Property destination)
		{
			return null;
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003021")]
		[Address(RVA = "0x761540", Offset = "0x760740", VA = "0x180761540")]
		public DeliveryInstance GetActiveShopDelivery(DeliveryShop shop)
		{
			return null;
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003022")]
		[Address(RVA = "0x761AF0", Offset = "0x760CF0", VA = "0x180761AF0")]
		public ShopInterface GetShopInterface(string shopName)
		{
			return null;
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003023")]
		[Address(RVA = "0x7617E0", Offset = "0x7609E0", VA = "0x1807617E0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003024")]
		[Address(RVA = "0x761D60", Offset = "0x760F60", VA = "0x180761D60")]
		public void Load(DeliveriesData data)
		{
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003025")]
		[Address(RVA = "0x763D00", Offset = "0x762F00", VA = "0x180763D00")]
		public DeliveryManager()
		{
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003027")]
		[Address(RVA = "0x762020", Offset = "0x761220", VA = "0x180762020", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003028")]
		[Address(RVA = "0x761F80", Offset = "0x761180", VA = "0x180761F80", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003029")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302A")]
		[Address(RVA = "0x7636E0", Offset = "0x7628E0", VA = "0x1807636E0")]
		private void RpcWriter___Server_SendDelivery_2813439055(DeliveryInstance delivery)
		{
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302B")]
		[Address(RVA = "0x763070", Offset = "0x762270", VA = "0x180763070")]
		public void RpcLogic___SendDelivery_2813439055(DeliveryInstance delivery)
		{
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302C")]
		[Address(RVA = "0x763380", Offset = "0x762580", VA = "0x180763380")]
		private void RpcReader___Server_SendDelivery_2813439055(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302D")]
		[Address(RVA = "0x762950", Offset = "0x761B50", VA = "0x180762950")]
		private void RpcWriter___Server_RecordDeliveryReceipt_Server_2582461062(DeliveryReceipt receipt, string originalOrderID = "")
		{
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302E")]
		[Address(RVA = "0x762BC0", Offset = "0x761DC0", VA = "0x180762BC0")]
		public void RpcLogic___RecordDeliveryReceipt_Server_2582461062(DeliveryReceipt receipt, string originalOrderID = "")
		{
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302F")]
		[Address(RVA = "0x763310", Offset = "0x762510", VA = "0x180763310")]
		private void RpcReader___Server_RecordDeliveryReceipt_Server_2582461062(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003030")]
		[Address(RVA = "0x763430", Offset = "0x762630", VA = "0x180763430")]
		private void RpcWriter___Observers_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003031")]
		[Address(RVA = "0x762AB0", Offset = "0x761CB0", VA = "0x180762AB0")]
		private void RpcLogic___ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003032")]
		[Address(RVA = "0x763240", Offset = "0x762440", VA = "0x180763240")]
		private void RpcReader___Observers_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003033")]
		[Address(RVA = "0x763810", Offset = "0x762A10", VA = "0x180763810")]
		private void RpcWriter___Target_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003034")]
		[Address(RVA = "0x7633D0", Offset = "0x7625D0", VA = "0x1807633D0")]
		private void RpcReader___Target_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003035")]
		[Address(RVA = "0x763570", Offset = "0x762770", VA = "0x180763570")]
		private void RpcWriter___Observers_SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003036")]
		[Address(RVA = "0x763080", Offset = "0x762280", VA = "0x180763080")]
		private void RpcLogic___SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x763290", Offset = "0x762490", VA = "0x180763290")]
		private void RpcReader___Observers_SetDeliveryState_316609003(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003038")]
		[Address(RVA = "0x761470", Offset = "0x760670", VA = "0x180761470", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Delivery.DeliveryManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002374 RID: 9076
		[Token(Token = "0x4002374")]
		[FieldOffset(Offset = "0x120")]
		public List<DeliveryInstance> Deliveries;

		// Token: 0x04002377 RID: 9079
		[Token(Token = "0x4002377")]
		[FieldOffset(Offset = "0x138")]
		private DeliveriesLoader loader;

		// Token: 0x0400237B RID: 9083
		[Token(Token = "0x400237B")]
		[FieldOffset(Offset = "0x158")]
		private List<string> writtenVehicles;

		// Token: 0x0400237D RID: 9085
		[Token(Token = "0x400237D")]
		[FieldOffset(Offset = "0x168")]
		[SyncObject]
		private readonly SyncList<DeliveryReceipt> _deliveryHistory;

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0x170")]
		[SyncObject]
		private readonly SyncList<DeliveryReceipt> _displayedDeliveryHistory;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0x178")]
		private Dictionary<DeliveryInstance, int> _minsSinceVehicleEmpty;

		// Token: 0x04002380 RID: 9088
		[Token(Token = "0x4002380")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002381 RID: 9089
		[Token(Token = "0x4002381")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted;
	}
}
