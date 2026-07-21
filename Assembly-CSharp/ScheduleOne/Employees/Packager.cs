using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x0200067E RID: 1662
	[Token(Token = "0x200067E")]
	public class Packager : Employee, IConfigurable
	{
		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000763")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6002AF3")]
			[Address(RVA = "0x704610", Offset = "0x703810", VA = "0x180704610", Slot = "150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002AF5 RID: 10997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000764")]
		protected PackagerConfiguration configuration
		{
			[Token(Token = "0x6002AF4")]
			[Address(RVA = "0x704610", Offset = "0x703810", VA = "0x180704610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AF5")]
			[Address(RVA = "0x704640", Offset = "0x703840", VA = "0x180704640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000765")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6002AF6")]
			[Address(RVA = "0x6F2CD0", Offset = "0x6F1ED0", VA = "0x1806F2CD0", Slot = "151")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x0000DA40 File Offset: 0x0000BC40
		[Token(Token = "0x17000766")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6002AF7")]
			[Address(RVA = "0x704600", Offset = "0x703800", VA = "0x180704600", Slot = "152")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000767")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6002AF8")]
			[Address(RVA = "0x6F63D0", Offset = "0x6F55D0", VA = "0x1806F63D0", Slot = "153")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AF9")]
			[Address(RVA = "0x704620", Offset = "0x703820", VA = "0x180704620", Slot = "154")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002AFB RID: 11003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000768")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6002AFA")]
			[Address(RVA = "0x6F63C0", Offset = "0x6F55C0", VA = "0x1806F63C0", Slot = "155")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AFB")]
			[Address(RVA = "0x7037B0", Offset = "0x7029B0", VA = "0x1807037B0", Slot = "156")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x703B60", Offset = "0x702D60", VA = "0x180703B60", Slot = "170")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000769")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6002AFD")]
			[Address(RVA = "0x6F2D10", Offset = "0x6F1F10", VA = "0x1806F2D10", Slot = "158")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700076A")]
		public Transform Transform
		{
			[Token(Token = "0x6002AFE")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "159")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002AFF RID: 11007 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700076B")]
		public Transform UIPoint
		{
			[Token(Token = "0x6002AFF")]
			[Address(RVA = "0x6F8500", Offset = "0x6F7700", VA = "0x1806F8500", Slot = "160")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002B00 RID: 11008 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[Token(Token = "0x1700076C")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6002B00")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "162")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700076D")]
		public Property ParentProperty
		{
			[Token(Token = "0x6002B01")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00", Slot = "163")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B02")]
		[Address(RVA = "0x7021A0", Offset = "0x7013A0", VA = "0x1807021A0", Slot = "131")]
		protected override void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B03")]
		[Address(RVA = "0x6F0E40", Offset = "0x6F0040", VA = "0x1806F0E40", Slot = "132")]
		protected override void UnassignProperty()
		{
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B04")]
		[Address(RVA = "0x703780", Offset = "0x702980", VA = "0x180703780", Slot = "137")]
		protected override void ResetConfiguration()
		{
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B05")]
		[Address(RVA = "0x702520", Offset = "0x701720", VA = "0x180702520", Slot = "138")]
		protected override void Fire()
		{
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B06")]
		[Address(RVA = "0x703540", Offset = "0x702740", VA = "0x180703540", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B07")]
		[Address(RVA = "0x703A00", Offset = "0x702C00", VA = "0x180703A00", Slot = "171")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0000DA70 File Offset: 0x0000BC70
		[Token(Token = "0x6002B08")]
		[Address(RVA = "0x7032C0", Offset = "0x7024C0", VA = "0x1807032C0", Slot = "141")]
		protected override bool IsAnyWorkInProgress()
		{
			return default(bool);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B09")]
		[Address(RVA = "0x704010", Offset = "0x703210", VA = "0x180704010", Slot = "140")]
		protected override void UpdateBehaviour()
		{
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0x703F30", Offset = "0x703130", VA = "0x180703F30")]
		private void StartPackaging(PackagingStation station)
		{
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0B")]
		[Address(RVA = "0x6F5B60", Offset = "0x6F4D60", VA = "0x1806F5B60")]
		private void StartPress(BrickPress press)
		{
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0C")]
		[Address(RVA = "0x703DC0", Offset = "0x702FC0", VA = "0x180703DC0")]
		private void StartMoveItem(PackagingStation station)
		{
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0D")]
		[Address(RVA = "0x703CC0", Offset = "0x702EC0", VA = "0x180703CC0")]
		private void StartMoveItem(BrickPress press)
		{
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B0E")]
		[Address(RVA = "0x702F30", Offset = "0x702130", VA = "0x180702F30")]
		protected PackagingStation GetStationToAttend()
		{
			return null;
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0x702890", Offset = "0x701A90", VA = "0x180702890")]
		protected BrickPress GetBrickPress()
		{
			return null;
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B10")]
		[Address(RVA = "0x702CE0", Offset = "0x701EE0", VA = "0x180702CE0")]
		protected PackagingStation GetStationMoveItems()
		{
			return null;
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x702640", Offset = "0x701840", VA = "0x180702640")]
		protected BrickPress GetBrickPressMoveItems()
		{
			return null;
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x7030A0", Offset = "0x7022A0", VA = "0x1807030A0")]
		protected AdvancedTransitRoute GetTransitRouteReady(out ItemInstance item)
		{
			return null;
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x703C90", Offset = "0x702E90", VA = "0x180703C90", Slot = "142")]
		protected override bool ShouldIdle()
		{
			return default(bool);
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x702A00", Offset = "0x701C00", VA = "0x180702A00", Slot = "143")]
		public override EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B15")]
		[Address(RVA = "0x702260", Offset = "0x701460", VA = "0x180702260", Slot = "164")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x702490", Offset = "0x701690", VA = "0x180702490", Slot = "165")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B17")]
		[Address(RVA = "0x702A20", Offset = "0x701C20", VA = "0x180702A20", Slot = "116")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x702C50", Offset = "0x701E50", VA = "0x180702C50", Slot = "117")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B19")]
		[Address(RVA = "0x704580", Offset = "0x703780", VA = "0x180704580", Slot = "118")]
		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1A")]
		[Address(RVA = "0x7045E0", Offset = "0x7037E0", VA = "0x1807045E0")]
		public Packager()
		{
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0x703390", Offset = "0x702590", VA = "0x180703390", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1C")]
		[Address(RVA = "0x703310", Offset = "0x702510", VA = "0x180703310", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x7038D0", Offset = "0x702AD0", VA = "0x1807038D0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x7037B0", Offset = "0x7029B0", VA = "0x1807037B0", Slot = "172")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x703850", Offset = "0x702A50", VA = "0x180703850")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002B22 RID: 11042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076E")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6002B21")]
			[Address(RVA = "0x6F63C0", Offset = "0x6F55C0", VA = "0x1806F63C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B22")]
			[Address(RVA = "0x704660", Offset = "0x703860", VA = "0x180704660")]
			set
			{
			}
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x7036C0", Offset = "0x7028C0", VA = "0x1807036C0", Slot = "173")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Packager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B24")]
		[Address(RVA = "0x6F2F00", Offset = "0x6F2100", VA = "0x1806F2F00", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x0400203E RID: 8254
		[Token(Token = "0x400203E")]
		[FieldOffset(Offset = "0x3C0")]
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x0400203F RID: 8255
		[Token(Token = "0x400203F")]
		[FieldOffset(Offset = "0x3C8")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04002040 RID: 8256
		[Token(Token = "0x4002040")]
		[FieldOffset(Offset = "0x3D0")]
		public PackagingStationBehaviour PackagingBehaviour;

		// Token: 0x04002041 RID: 8257
		[Token(Token = "0x4002041")]
		[FieldOffset(Offset = "0x3D8")]
		public BrickPressBehaviour BrickPressBehaviour;

		// Token: 0x04002042 RID: 8258
		[Token(Token = "0x4002042")]
		[FieldOffset(Offset = "0x3E0")]
		[Header("UI")]
		public PackagerUIElement WorldspaceUIPrefab;

		// Token: 0x04002043 RID: 8259
		[Token(Token = "0x4002043")]
		[FieldOffset(Offset = "0x3E8")]
		public Transform uiPoint;

		// Token: 0x04002044 RID: 8260
		[Token(Token = "0x4002044")]
		[FieldOffset(Offset = "0x3F0")]
		[Header("Settings")]
		public int MaxAssignedStations;

		// Token: 0x04002045 RID: 8261
		[Token(Token = "0x4002045")]
		[FieldOffset(Offset = "0x3F4")]
		[Header("Proficiency Settings")]
		public float PackagingSpeedMultiplier;

		// Token: 0x04002049 RID: 8265
		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x410")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x0400204A RID: 8266
		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x418")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400204B RID: 8267
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x419")]
		private bool NetworkInitialize__LateScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted;
	}
}
