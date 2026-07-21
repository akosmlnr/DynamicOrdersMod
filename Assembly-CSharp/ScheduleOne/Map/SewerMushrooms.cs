using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200054C RID: 1356
	[Token(Token = "0x200054C")]
	public class SewerMushrooms : NetworkBehaviour
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x630DF0", Offset = "0x62FFF0", VA = "0x180630DF0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x631BE0", Offset = "0x630DE0", VA = "0x180631BE0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x632380", Offset = "0x631580", VA = "0x180632380")]
		private void SetupEvents()
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x6318C0", Offset = "0x630AC0", VA = "0x1806318C0")]
		private void MushroomIndicesChanged(SyncListOperation op, int index, int oldItem, int newItem, bool asServer)
		{
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x6324D0", Offset = "0x6316D0", VA = "0x1806324D0")]
		private void SpawnMushroom(int locationIndex)
		{
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x631010", Offset = "0x630210", VA = "0x180631010")]
		private void DespawnMushroom(int locationIndex)
		{
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x632370", Offset = "0x631570", VA = "0x180632370")]
		[ServerRpc]
		private void SetMushroomSpawnLocationAvailable(int locationIndex)
		{
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x631D40", Offset = "0x630F40", VA = "0x180631D40")]
		private void RegenerateMushrooms()
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x631460", Offset = "0x630660", VA = "0x180631460")]
		public void Load(SewerData sewerData)
		{
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x631100", Offset = "0x630300", VA = "0x180631100")]
		public List<int> GetActiveMushroomLocationIndices()
		{
			return null;
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x631240", Offset = "0x630440", VA = "0x180631240")]
		private int GetNextSpawnLocation()
		{
			return 0;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x630C40", Offset = "0x62FE40", VA = "0x180630C40")]
		private bool AreLocationsInSameArea(int locationIndexA, int locationIndexB)
		{
			return default(bool);
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x630F80", Offset = "0x630180", VA = "0x180630F80")]
		private bool CanSpawnMushroom()
		{
			return default(bool);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x631170", Offset = "0x630370", VA = "0x180631170")]
		private int GetLocationIndex(int index)
		{
			return 0;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x632930", Offset = "0x631B30", VA = "0x180632930")]
		public SewerMushrooms()
		{
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x631B10", Offset = "0x630D10", VA = "0x180631B10", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x631AC0", Offset = "0x630CC0", VA = "0x180631AC0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x6321B0", Offset = "0x6313B0", VA = "0x1806321B0")]
		private void RpcWriter___Server_SetMushroomSpawnLocationAvailable_3316948804(int locationIndex)
		{
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x631EE0", Offset = "0x6310E0", VA = "0x180631EE0")]
		private void RpcLogic___SetMushroomSpawnLocationAvailable_3316948804(int locationIndex)
		{
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x632010", Offset = "0x631210", VA = "0x180632010")]
		private void RpcReader___Server_SetMushroomSpawnLocationAvailable_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x630C90", Offset = "0x62FE90", VA = "0x180630C90")]
		private void Awake_UserLogic_ScheduleOne.Map.SewerMushrooms_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400195C RID: 6492
		[Token(Token = "0x400195C")]
		[FieldOffset(Offset = "0x118")]
		[Header("Mushroom Spawning")]
		public ItemPickup MushroomObjectPrefab;

		// Token: 0x0400195D RID: 6493
		[Token(Token = "0x400195D")]
		[FieldOffset(Offset = "0x120")]
		public SewerMushrooms.SewerMushroomSpawnSettings MushroomSpawnSettings;

		// Token: 0x0400195E RID: 6494
		[Token(Token = "0x400195E")]
		[FieldOffset(Offset = "0x128")]
		public List<Transform> MushroomAreas;

		// Token: 0x0400195F RID: 6495
		[Token(Token = "0x400195F")]
		[FieldOffset(Offset = "0x130")]
		public List<Transform> MushroomLocations;

		// Token: 0x04001960 RID: 6496
		[Token(Token = "0x4001960")]
		[FieldOffset(Offset = "0x138")]
		[Header("Development & Debugging")]
		[SerializeField]
		private bool _debugMode;

		// Token: 0x04001961 RID: 6497
		[Token(Token = "0x4001961")]
		[FieldOffset(Offset = "0x140")]
		[SyncObject]
		private readonly SyncList<int> _activeMushroomLocationIndices;

		// Token: 0x04001962 RID: 6498
		[Token(Token = "0x4001962")]
		[FieldOffset(Offset = "0x148")]
		private Dictionary<int, ItemPickup> _spawnedMushroomItems;

		// Token: 0x04001963 RID: 6499
		[Token(Token = "0x4001963")]
		[FieldOffset(Offset = "0x150")]
		private List<int> _availableMushroomSpawnLocationIndices;

		// Token: 0x04001964 RID: 6500
		[Token(Token = "0x4001964")]
		[FieldOffset(Offset = "0x158")]
		private List<int> _mushroomSpawnLocationAmountPerArea;

		// Token: 0x04001965 RID: 6501
		[Token(Token = "0x4001965")]
		[FieldOffset(Offset = "0x160")]
		private int _lastMushroomSpanwnLocationIndex;

		// Token: 0x04001966 RID: 6502
		[Token(Token = "0x4001966")]
		[FieldOffset(Offset = "0x164")]
		private bool NetworkInitialize___EarlyScheduleOne.Map.SewerMushroomsAssembly-CSharp.dll_Excuted;

		// Token: 0x04001967 RID: 6503
		[Token(Token = "0x4001967")]
		[FieldOffset(Offset = "0x165")]
		private bool NetworkInitialize__LateScheduleOne.Map.SewerMushroomsAssembly-CSharp.dll_Excuted;

		// Token: 0x0200054D RID: 1357
		[Token(Token = "0x200054D")]
		[Serializable]
		public class SewerMushroomSpawnSettings
		{
			// Token: 0x06001E4D RID: 7757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E4D")]
			[Address(RVA = "0x630C20", Offset = "0x62FE20", VA = "0x180630C20")]
			public SewerMushroomSpawnSettings()
			{
			}

			// Token: 0x04001968 RID: 6504
			[Token(Token = "0x4001968")]
			[FieldOffset(Offset = "0x10")]
			public int MaxSpawnAmount;

			// Token: 0x04001969 RID: 6505
			[Token(Token = "0x4001969")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			public float RespawnAmountPerdayAsPercentage;
		}
	}
}
