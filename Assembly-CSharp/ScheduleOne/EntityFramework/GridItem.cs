using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x0200065B RID: 1627
	[Token(Token = "0x200065B")]
	public class GridItem : BuildableItem
	{
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000718")]
		public FootprintTile OriginFootprint
		{
			[Token(Token = "0x60028DB")]
			[Address(RVA = "0x6DA220", Offset = "0x6D9420", VA = "0x1806DA220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x17000719")]
		public int FootprintX
		{
			[Token(Token = "0x60028DC")]
			[Address(RVA = "0x6D9F80", Offset = "0x6D9180", VA = "0x1806D9F80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x1700071A")]
		public int FootprintY
		{
			[Token(Token = "0x60028DD")]
			[Address(RVA = "0x6DA0D0", Offset = "0x6D92D0", VA = "0x1806DA0D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060028DF RID: 10463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071B")]
		public Grid OwnerGrid
		{
			[Token(Token = "0x60028DE")]
			[Address(RVA = "0x6DA280", Offset = "0x6D9480", VA = "0x1806DA280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028DF")]
			[Address(RVA = "0x6DA290", Offset = "0x6D9490", VA = "0x1806DA290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E0")]
		[Address(RVA = "0x6D6EC0", Offset = "0x6D60C0", VA = "0x1806D6EC0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E1")]
		[Address(RVA = "0x6D9800", Offset = "0x6D8A00", VA = "0x1806D9800", Slot = "54")]
		protected override void SendInitializationToServer()
		{
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E2")]
		[Address(RVA = "0x6D9730", Offset = "0x6D8930", VA = "0x1806D9730", Slot = "53")]
		protected override void SendInitializationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E3")]
		[Address(RVA = "0x6D7C00", Offset = "0x6D6E00", VA = "0x1806D7C00")]
		[ServerRpc(RequireOwnership = false)]
		public void InitializeGridItem_Server(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E4")]
		[Address(RVA = "0x6D7880", Offset = "0x6D6A80", VA = "0x1806D7880")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void InitializeGridItem_Client(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E5")]
		[Address(RVA = "0x6D7D90", Offset = "0x6D6F90", VA = "0x1806D7D90", Slot = "66")]
		public virtual void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E6")]
		[Address(RVA = "0x6D9AC0", Offset = "0x6D8CC0", VA = "0x1806D9AC0")]
		protected void SetGridData(Guid gridGUID, Vector2 originCoordinate, int rotation)
		{
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x60028E7")]
		[Address(RVA = "0x6D9D90", Offset = "0x6D8F90", VA = "0x1806D9D90")]
		private int ValidateRotation(int rotation)
		{
			return 0;
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x6D7FC0", Offset = "0x6D71C0", VA = "0x1806D7FC0")]
		private void ProcessGridData()
		{
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E9")]
		[Address(RVA = "0x6D8850", Offset = "0x6D7A50", VA = "0x1806D8850")]
		private void RefreshTransform()
		{
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EA")]
		[Address(RVA = "0x6D7120", Offset = "0x6D6320", VA = "0x1806D7120")]
		private void ClearPositionData()
		{
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x6D7380", Offset = "0x6D6580", VA = "0x1806D7380", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EC")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "67")]
		protected virtual void OnTileTemperatureChanged(Tile tile, float newTemp)
		{
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x60028ED")]
		[Address(RVA = "0x6D7490", Offset = "0x6D6690", VA = "0x1806D7490")]
		public float GetAverageTileTemperature()
		{
			return 0f;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0000D350 File Offset: 0x0000B550
		[Token(Token = "0x60028EE")]
		[Address(RVA = "0x6D73A0", Offset = "0x6D65A0", VA = "0x1806D73A0")]
		public float GetAverageCosmeticTileTemperature()
		{
			return 0f;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x6D6FA0", Offset = "0x6D61A0", VA = "0x1806D6FA0", Slot = "68")]
		public virtual void CalculateFootprintTileIntersections()
		{
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x6D9A00", Offset = "0x6D8C00", VA = "0x1806D9A00")]
		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x6D7670", Offset = "0x6D6870", VA = "0x1806D7670")]
		public FootprintTile GetFootprintTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x6D7770", Offset = "0x6D6970", VA = "0x1806D7770")]
		public Tile GetParentTileAtFootprintCoordinate(Coordinate footprintCoord)
		{
			return null;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0000D368 File Offset: 0x0000B568
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x6D7060", Offset = "0x6D6260", VA = "0x1806D7060", Slot = "69")]
		public virtual bool CanShareTileWith(List<GridItem> obstacles)
		{
			return default(bool);
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x6D7580", Offset = "0x6D6780", VA = "0x1806D7580", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x6D9EB0", Offset = "0x6D90B0", VA = "0x1806D9EB0")]
		public GridItem()
		{
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x6D9D20", Offset = "0x6D8F20", VA = "0x1806D9D20")]
		[CompilerGenerated]
		private IEnumerator <ProcessGridData>g__Routine|23_0()
		{
			return null;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x6D7E90", Offset = "0x6D7090", VA = "0x1806D7E90", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x6D7E60", Offset = "0x6D7060", VA = "0x1806D7E60", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x6D93C0", Offset = "0x6D85C0", VA = "0x1806D93C0")]
		private void RpcWriter___Server_InitializeGridItem_Server_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FC")]
		[Address(RVA = "0x6D8E90", Offset = "0x6D8090", VA = "0x1806D8E90")]
		public void RpcLogic___InitializeGridItem_Server_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FD")]
		[Address(RVA = "0x6D8FE0", Offset = "0x6D81E0", VA = "0x1806D8FE0")]
		private void RpcReader___Server_InitializeGridItem_Server_2821640832(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x6D9570", Offset = "0x6D8770", VA = "0x1806D9570")]
		private void RpcWriter___Target_InitializeGridItem_Client_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FF")]
		[Address(RVA = "0x6D8DA0", Offset = "0x6D7FA0", VA = "0x1806D8DA0")]
		private void RpcLogic___InitializeGridItem_Client_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002900")]
		[Address(RVA = "0x6D90E0", Offset = "0x6D82E0", VA = "0x1806D90E0")]
		private void RpcReader___Target_InitializeGridItem_Client_1883577149(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002901")]
		[Address(RVA = "0x6D91F0", Offset = "0x6D83F0", VA = "0x1806D91F0")]
		private void RpcWriter___Observers_InitializeGridItem_Client_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002902")]
		[Address(RVA = "0x6D8ED0", Offset = "0x6D80D0", VA = "0x1806D8ED0")]
		private void RpcReader___Observers_InitializeGridItem_Client_1883577149(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002903")]
		[Address(RVA = "0x6D6E00", Offset = "0x6D6000", VA = "0x1806D6E00", Slot = "70")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.GridItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x1D0")]
		[HideInInspector]
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		// Token: 0x04001F55 RID: 8021
		[Token(Token = "0x4001F55")]
		[FieldOffset(Offset = "0x1E0")]
		protected Guid _ownerGridGUID;

		// Token: 0x04001F56 RID: 8022
		[Token(Token = "0x4001F56")]
		[FieldOffset(Offset = "0x1F0")]
		protected Vector2 _originCoordinate;

		// Token: 0x04001F57 RID: 8023
		[Token(Token = "0x4001F57")]
		[FieldOffset(Offset = "0x1F8")]
		protected int _rotation;

		// Token: 0x04001F58 RID: 8024
		[Token(Token = "0x4001F58")]
		[FieldOffset(Offset = "0x200")]
		public List<CoordinatePair> CoordinatePairs;

		// Token: 0x04001F59 RID: 8025
		[Token(Token = "0x4001F59")]
		[FieldOffset(Offset = "0x208")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F5A RID: 8026
		[Token(Token = "0x4001F5A")]
		[FieldOffset(Offset = "0x209")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted;
	}
}
