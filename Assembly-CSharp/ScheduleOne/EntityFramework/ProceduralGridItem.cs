using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x2000661")]
	public class ProceduralGridItem : BuildableItem
	{
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002926 RID: 10534 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		[Token(Token = "0x17000720")]
		public int FootprintXSize
		{
			[Token(Token = "0x6002926")]
			[Address(RVA = "0x6DD860", Offset = "0x6DCA60", VA = "0x1806DD860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x0000D410 File Offset: 0x0000B610
		[Token(Token = "0x17000721")]
		public int FootprintYSize
		{
			[Token(Token = "0x6002927")]
			[Address(RVA = "0x6DD9B0", Offset = "0x6DCBB0", VA = "0x1806DD9B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002928")]
		[Address(RVA = "0x6DB280", Offset = "0x6DA480", VA = "0x1806DB280", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002929")]
		[Address(RVA = "0x6DD180", Offset = "0x6DC380", VA = "0x1806DD180", Slot = "54")]
		protected override void SendInitializationToServer()
		{
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x6DD0E0", Offset = "0x6DC2E0", VA = "0x1806DD0E0", Slot = "53")]
		protected override void SendInitializationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x6DBF70", Offset = "0x6DB170", VA = "0x1806DBF70")]
		[ServerRpc(RequireOwnership = false)]
		public void InitializeProceduralGridItem_Server(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292C")]
		[Address(RVA = "0x6DBC40", Offset = "0x6DAE40", VA = "0x1806DBC40", Slot = "66")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void InitializeProceduralGridItem_Client(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292D")]
		[Address(RVA = "0x6DC0F0", Offset = "0x6DB2F0", VA = "0x1806DC0F0", Slot = "67")]
		public virtual void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292E")]
		[Address(RVA = "0x6DD3E0", Offset = "0x6DC5E0", VA = "0x1806DD3E0", Slot = "68")]
		protected virtual void SetProceduralGridData(int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches)
		{
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292F")]
		[Address(RVA = "0x6DC7E0", Offset = "0x6DB9E0", VA = "0x1806DC7E0")]
		private void RefreshTransform()
		{
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002930")]
		[Address(RVA = "0x6DB420", Offset = "0x6DA620", VA = "0x1806DB420")]
		private void ClearPositionData()
		{
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002931")]
		[Address(RVA = "0x6DB550", Offset = "0x6DA750", VA = "0x1806DB550", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002932")]
		[Address(RVA = "0x6DBB50", Offset = "0x6DAD50", VA = "0x1806DBB50", Slot = "49")]
		protected override Property GetProperty([Optional] Transform searchTransform)
		{
			return null;
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002933")]
		[Address(RVA = "0x6DB360", Offset = "0x6DA560", VA = "0x1806DB360", Slot = "69")]
		public virtual void CalculateFootprintTileIntersections()
		{
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002934")]
		[Address(RVA = "0x6DD320", Offset = "0x6DC520", VA = "0x1806DD320")]
		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002935")]
		[Address(RVA = "0x6DBA50", Offset = "0x6DAC50", VA = "0x1806DBA50")]
		public FootprintTile GetFootprintTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002936")]
		[Address(RVA = "0x6DB690", Offset = "0x6DA890", VA = "0x1806DB690", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002937")]
		[Address(RVA = "0x6DD790", Offset = "0x6DC990", VA = "0x1806DD790")]
		public ProceduralGridItem()
		{
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002938")]
		[Address(RVA = "0x6DD720", Offset = "0x6DC920", VA = "0x1806DD720")]
		[CompilerGenerated]
		private IEnumerator <SetProceduralGridData>g__Routine|15_0()
		{
			return null;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293A")]
		[Address(RVA = "0x6DC3C0", Offset = "0x6DB5C0", VA = "0x1806DC3C0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293B")]
		[Address(RVA = "0x6DC340", Offset = "0x6DB540", VA = "0x1806DC340", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293C")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293D")]
		[Address(RVA = "0x6DBF70", Offset = "0x6DB170", VA = "0x1806DBF70")]
		private void RpcWriter___Server_InitializeProceduralGridItem_Server_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293E")]
		[Address(RVA = "0x6DCAE0", Offset = "0x6DBCE0", VA = "0x1806DCAE0")]
		public void RpcLogic___InitializeProceduralGridItem_Server_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293F")]
		[Address(RVA = "0x6DCC00", Offset = "0x6DBE00", VA = "0x1806DCC00")]
		private void RpcReader___Server_InitializeProceduralGridItem_Server_638911643(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002940")]
		[Address(RVA = "0x6DCF50", Offset = "0x6DC150", VA = "0x1806DCF50")]
		private void RpcWriter___Target_InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002941")]
		[Address(RVA = "0x6DCA90", Offset = "0x6DBC90", VA = "0x1806DCA90", Slot = "70")]
		public virtual void RpcLogic___InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002942")]
		[Address(RVA = "0x6DCCD0", Offset = "0x6DBED0", VA = "0x1806DCCD0")]
		private void RpcReader___Target_InitializeProceduralGridItem_Client_3164718044(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002943")]
		[Address(RVA = "0x6DCDB0", Offset = "0x6DBFB0", VA = "0x1806DCDB0")]
		private void RpcWriter___Observers_InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002944")]
		[Address(RVA = "0x6DCB20", Offset = "0x6DBD20", VA = "0x1806DCB20")]
		private void RpcReader___Observers_InitializeProceduralGridItem_Client_3164718044(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0000D440 File Offset: 0x0000B640
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000722")]
		public int SyncAccessor_Rotation
		{
			[Token(Token = "0x6002945")]
			[Address(RVA = "0x6DDB00", Offset = "0x6DCD00", VA = "0x1806DDB00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002946")]
			[Address(RVA = "0x6DDB20", Offset = "0x6DCD20", VA = "0x1806DDB20")]
			set
			{
			}
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x6DC6C0", Offset = "0x6DB8C0", VA = "0x1806DC6C0", Slot = "71")]
		public virtual bool ReadSyncVar___ScheduleOne.EntityFramework.ProceduralGridItem(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000723")]
		public List<CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches
		{
			[Token(Token = "0x6002948")]
			[Address(RVA = "0x6DDB10", Offset = "0x6DCD10", VA = "0x1806DDB10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002949")]
			[Address(RVA = "0x6DDBD0", Offset = "0x6DCDD0", VA = "0x1806DDBD0")]
			set
			{
			}
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x6DB1C0", Offset = "0x6DA3C0", VA = "0x1806DB1C0", Slot = "72")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.ProceduralGridItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001F67 RID: 8039
		[Token(Token = "0x4001F67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Header("Grid item data")]
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public ProceduralTile.EProceduralTileType ProceduralTileType;

		// Token: 0x04001F69 RID: 8041
		[Token(Token = "0x4001F69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		[HideInInspector]
		[SyncVar]
		public int Rotation;

		// Token: 0x04001F6A RID: 8042
		[Token(Token = "0x4001F6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[HideInInspector]
		[SyncVar]
		public List<CoordinateProceduralTilePair> footprintTileMatches;

		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public SyncVar<int> syncVar___Rotation;

		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public SyncVar<List<CoordinateProceduralTilePair>> syncVar___footprintTileMatches;

		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F9")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted;

		// Token: 0x02000662 RID: 1634
		[Token(Token = "0x2000662")]
		public class FootprintTileMatch
		{
			// Token: 0x0600294B RID: 10571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600294B")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public FootprintTileMatch()
			{
			}

			// Token: 0x04001F6F RID: 8047
			[Token(Token = "0x4001F6F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FootprintTile footprint;

			// Token: 0x04001F70 RID: 8048
			[Token(Token = "0x4001F70")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ProceduralTile matchedTile;
		}
	}
}
