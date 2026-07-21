using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Misc;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.Tools;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009AE RID: 2478
	[Token(Token = "0x20009AE")]
	public class MixingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060044C7 RID: 17607 RVA: 0x00013128 File Offset: 0x00011328
		// (set) Token: 0x060044C8 RID: 17608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC0")]
		public bool IsOpen
		{
			[Token(Token = "0x60044C7")]
			[Address(RVA = "0x6E9280", Offset = "0x6E8480", VA = "0x1806E9280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60044C8")]
			[Address(RVA = "0x6E9290", Offset = "0x6E8490", VA = "0x1806E9290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x060044C9 RID: 17609 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044CA RID: 17610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC1")]
		public MixOperation CurrentMixOperation
		{
			[Token(Token = "0x60044C9")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044CA")]
			[Address(RVA = "0x89E640", Offset = "0x89D840", VA = "0x18089E640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x060044CB RID: 17611 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x17000AC2")]
		public bool IsMixingDone
		{
			[Token(Token = "0x60044CB")]
			[Address(RVA = "0x8AB4D0", Offset = "0x8AA6D0", VA = "0x1808AB4D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x00013158 File Offset: 0x00011358
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC3")]
		public int CurrentMixTime
		{
			[Token(Token = "0x60044CC")]
			[Address(RVA = "0x8AB480", Offset = "0x8AA680", VA = "0x1808AB480")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60044CD")]
			[Address(RVA = "0x8AB500", Offset = "0x8AA700", VA = "0x1808AB500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044CF RID: 17615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC4")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60044CE")]
			[Address(RVA = "0x803790", Offset = "0x802990", VA = "0x180803790", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044CF")]
			[Address(RVA = "0x803930", Offset = "0x802B30", VA = "0x180803930", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044D1 RID: 17617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC5")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x60044D0")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044D1")]
			[Address(RVA = "0x8A68D0", Offset = "0x8A5AD0", VA = "0x1808A68D0", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044D3 RID: 17619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC6")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60044D2")]
			[Address(RVA = "0x835000", Offset = "0x834200", VA = "0x180835000", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044D3")]
			[Address(RVA = "0x8AB550", Offset = "0x8AA750", VA = "0x1808AB550", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AC7")]
		public string Name
		{
			[Token(Token = "0x60044D4")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044D6 RID: 17622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC8")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60044D5")]
			[Address(RVA = "0x598F80", Offset = "0x598180", VA = "0x180598F80", Slot = "93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044D6")]
			[Address(RVA = "0x803900", Offset = "0x802B00", VA = "0x180803900", Slot = "94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060044D7 RID: 17623 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044D8 RID: 17624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC9")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x60044D7")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x66BD40", Offset = "0x66AF40", VA = "0x18066BD40", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000ACA")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x60044D9")]
			[Address(RVA = "0x88BBC0", Offset = "0x88ADC0", VA = "0x18088BBC0", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060044DA RID: 17626 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000ACB")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x60044DA")]
			[Address(RVA = "0x8AB460", Offset = "0x8AA660", VA = "0x1808AB460", Slot = "98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060044DB RID: 17627 RVA: 0x00013170 File Offset: 0x00011370
		[Token(Token = "0x17000ACC")]
		public bool Selectable
		{
			[Token(Token = "0x60044DB")]
			[Address(RVA = "0x5AC190", Offset = "0x5AB390", VA = "0x1805AC190", Slot = "99")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x00013188 File Offset: 0x00011388
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACD")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x60044DC")]
			[Address(RVA = "0x8AB4C0", Offset = "0x8AA6C0", VA = "0x1808AB4C0", Slot = "100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60044DD")]
			[Address(RVA = "0x8AB540", Offset = "0x8AA740", VA = "0x1808AB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000ACE")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60044DE")]
			[Address(RVA = "0x8037A0", Offset = "0x8029A0", VA = "0x1808037A0", Slot = "114")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044E0 RID: 17632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACF")]
		protected MixingStationConfiguration stationConfiguration
		{
			[Token(Token = "0x60044DF")]
			[Address(RVA = "0x8037A0", Offset = "0x8029A0", VA = "0x1808037A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044E0")]
			[Address(RVA = "0x803950", Offset = "0x802B50", VA = "0x180803950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AD0")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x60044E1")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00", Slot = "115")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x17000AD1")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x60044E2")]
			[Address(RVA = "0x8AB470", Offset = "0x8AA670", VA = "0x1808AB470", Slot = "116")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044E4 RID: 17636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD2")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x60044E3")]
			[Address(RVA = "0x834F90", Offset = "0x834190", VA = "0x180834F90", Slot = "117")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044E4")]
			[Address(RVA = "0x835010", Offset = "0x834210", VA = "0x180835010", Slot = "118")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060044E6 RID: 17638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD3")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x60044E5")]
			[Address(RVA = "0x8036C0", Offset = "0x8028C0", VA = "0x1808036C0", Slot = "119")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x8A66C0", Offset = "0x8A58C0", VA = "0x1808A66C0", Slot = "120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E7")]
		[Address(RVA = "0x8A9980", Offset = "0x8A8B80", VA = "0x1808A9980", Slot = "134")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AD4")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x60044E8")]
			[Address(RVA = "0x72EF60", Offset = "0x72E160", VA = "0x18072EF60", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AD5")]
		public Transform Transform
		{
			[Token(Token = "0x60044E9")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AD6")]
		public Transform UIPoint
		{
			[Token(Token = "0x60044EA")]
			[Address(RVA = "0x88BBC0", Offset = "0x88ADC0", VA = "0x18088BBC0", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x17000AD7")]
		public bool CanBeSelected
		{
			[Token(Token = "0x60044EB")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x000131D0 File Offset: 0x000113D0
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD8")]
		public Vector3 DiscoveryBoxOffset
		{
			[Token(Token = "0x60044EC")]
			[Address(RVA = "0x8AB490", Offset = "0x8AA690", VA = "0x1808AB490")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60044ED")]
			[Address(RVA = "0x8AB510", Offset = "0x8AA710", VA = "0x1808AB510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x000131E8 File Offset: 0x000113E8
		// (set) Token: 0x060044EF RID: 17647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD9")]
		public Quaternion DiscoveryBoxRotation
		{
			[Token(Token = "0x60044EE")]
			[Address(RVA = "0x8AB4B0", Offset = "0x8AA6B0", VA = "0x1808AB4B0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60044EF")]
			[Address(RVA = "0x8AB530", Offset = "0x8AA730", VA = "0x1808AB530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x8A3340", Offset = "0x8A2540", VA = "0x1808A3340", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x8AB170", Offset = "0x8AA370", VA = "0x1808AB170", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0x8A4A40", Offset = "0x8A3C40", VA = "0x1808A4A40", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x8A43A0", Offset = "0x8A35A0", VA = "0x1808A43A0", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x8A42C0", Offset = "0x8A34C0", VA = "0x1808A42C0", Slot = "51")]
		public override string GetDefaultManagementName()
		{
			return null;
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x8A5700", Offset = "0x8A4900", VA = "0x1808A5700", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x8A96B0", Offset = "0x8A88B0", VA = "0x1808A96B0", Slot = "135")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00013200 File Offset: 0x00011400
		[Token(Token = "0x60044F7")]
		[Address(RVA = "0x8A3390", Offset = "0x8A2590", VA = "0x1808A3390", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x8A3B60", Offset = "0x8A2D60", VA = "0x1808A3B60", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x8A56E0", Offset = "0x8A48E0", VA = "0x1808A56E0", Slot = "136")]
		protected virtual void OnMinPass()
		{
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x8A5AE0", Offset = "0x8A4CE0", VA = "0x1808A5AE0", Slot = "137")]
		protected virtual void OnTimePass(int minutes)
		{
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x8A9810", Offset = "0x8A8A10", VA = "0x1808A9810")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixingOperation(MixOperation operation, int mixTime)
		{
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x8A9DD0", Offset = "0x8A8FD0", VA = "0x1808A9DD0", Slot = "138")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void SetMixOperation(NetworkConnection conn, MixOperation operation, int mixTime)
		{
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x8AA090", Offset = "0x8A9290", VA = "0x1808AA090", Slot = "139")]
		protected virtual void SetMixerToLowered()
		{
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x8A4E30", Offset = "0x8A4030", VA = "0x1808A4E30", Slot = "140")]
		public virtual void MixingStart()
		{
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x8A4C30", Offset = "0x8A3E30", VA = "0x1808A4C30")]
		[ObserversRpc]
		public void MixingDone_Networked()
		{
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x8A4D50", Offset = "0x8A3F50", VA = "0x1808A4D50", Slot = "141")]
		public virtual void MixingDone()
		{
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00013218 File Offset: 0x00011418
		[Token(Token = "0x6004501")]
		[Address(RVA = "0x8A3E20", Offset = "0x8A3020", VA = "0x1808A3E20")]
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x6004502")]
		[Address(RVA = "0x8A4BF0", Offset = "0x8A3DF0", VA = "0x1808A4BF0")]
		private bool IsCurrentMixingOperationComplete()
		{
			return default(bool);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004503")]
		[Address(RVA = "0x8A42D0", Offset = "0x8A34D0", VA = "0x1808A42D0")]
		public List<ItemInstance> GetIngredients()
		{
			return null;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x6004504")]
		[Address(RVA = "0x8A43D0", Offset = "0x8A35D0", VA = "0x1808A43D0")]
		public int GetMixQuantity()
		{
			return 0;
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x6004505")]
		[Address(RVA = "0x8A34B0", Offset = "0x8A26B0", VA = "0x1808A34B0")]
		public bool CanStartMix()
		{
			return default(bool);
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004506")]
		[Address(RVA = "0x8A47B0", Offset = "0x8A39B0", VA = "0x1808A47B0")]
		public ProductDefinition GetProduct()
		{
			return null;
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004507")]
		[Address(RVA = "0x8A4670", Offset = "0x8A3870", VA = "0x1808A4670")]
		public PropertyItemDefinition GetMixer()
		{
			return null;
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x6004508")]
		[Address(RVA = "0x8A4650", Offset = "0x8A3850", VA = "0x1808A4650")]
		public int GetMixTimeForCurrentOperation()
		{
			return 0;
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004509")]
		[Address(RVA = "0x8A8FC0", Offset = "0x8A81C0", VA = "0x1808A8FC0")]
		[ServerRpc(RequireOwnership = false)]
		public void TryCreateOutputItems()
		{
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450A")]
		[Address(RVA = "0x8AACB0", Offset = "0x8A9EB0", VA = "0x1808AACB0")]
		public void SetStartButtonClickable(bool clickable)
		{
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450B")]
		[Address(RVA = "0x8A63C0", Offset = "0x8A55C0", VA = "0x1808A63C0")]
		private void OutputChanged()
		{
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450C")]
		[Address(RVA = "0x8AB130", Offset = "0x8AA330", VA = "0x1808AB130")]
		private void StartButtonClicked(RaycastHit hit)
		{
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450D")]
		[Address(RVA = "0x8A5F40", Offset = "0x8A5140", VA = "0x1808A5F40")]
		public void Open()
		{
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450E")]
		[Address(RVA = "0x8A34F0", Offset = "0x8A26F0", VA = "0x1808A34F0")]
		public void Close()
		{
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450F")]
		[Address(RVA = "0x8A4900", Offset = "0x8A3B00", VA = "0x1808A4900")]
		public void Hovered()
		{
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004510")]
		[Address(RVA = "0x8A4B40", Offset = "0x8A3D40", VA = "0x1808A4B40")]
		public void Interacted()
		{
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x8A38A0", Offset = "0x8A2AA0", VA = "0x1808A38A0", Slot = "128")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x8A3AD0", Offset = "0x8A2CD0", VA = "0x1808A3AD0", Slot = "129")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x8AAF90", Offset = "0x8AA190", VA = "0x1808AAF90", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x8AACD0", Offset = "0x8A9ED0", VA = "0x1808AACD0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x8A9C60", Offset = "0x8A8E60", VA = "0x1808A9C60", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x8A9AB0", Offset = "0x8A8CB0", VA = "0x1808A9AB0")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x8AAAC0", Offset = "0x8A9CC0", VA = "0x1808AAAC0", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x8AA7A0", Offset = "0x8A99A0", VA = "0x1808AA7A0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x8AA600", Offset = "0x8A9800", VA = "0x1808AA600", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x8AA340", Offset = "0x8A9540", VA = "0x1808AA340")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451B")]
		[Address(RVA = "0x8AA210", Offset = "0x8A9410", VA = "0x1808AA210", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451C")]
		[Address(RVA = "0x8AA0E0", Offset = "0x8A92E0", VA = "0x1808AA0E0", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600451D")]
		[Address(RVA = "0x8A3F40", Offset = "0x8A3140", VA = "0x1808A3F40", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600451E")]
		[Address(RVA = "0x8A4850", Offset = "0x8A3A50", VA = "0x1808A4850", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451F")]
		[Address(RVA = "0x8A2BB0", Offset = "0x8A1DB0", VA = "0x1808A2BB0")]
		public MixingStation()
		{
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x8AB430", Offset = "0x8AA630", VA = "0x1808AB430")]
		[CompilerGenerated]
		private void <OnSpawnServer>g__SendMixOperation|123_0(NetworkConnection connection)
		{
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004524")]
		[Address(RVA = "0x8A4F30", Offset = "0x8A4130", VA = "0x1808A4F30", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004525")]
		[Address(RVA = "0x8A4EA0", Offset = "0x8A40A0", VA = "0x1808A4EA0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004526")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004527")]
		[Address(RVA = "0x8A8640", Offset = "0x8A7840", VA = "0x1808A8640")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004528")]
		[Address(RVA = "0x8A66C0", Offset = "0x8A58C0", VA = "0x1808A66C0", Slot = "142")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004529")]
		[Address(RVA = "0x8A7500", Offset = "0x8A6700", VA = "0x1808A7500")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452A")]
		[Address(RVA = "0x8A84D0", Offset = "0x8A76D0", VA = "0x1808A84D0")]
		private void RpcWriter___Server_SendMixingOperation_2669582547(MixOperation operation, int mixTime)
		{
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x8A6690", Offset = "0x8A5890", VA = "0x1808A6690")]
		public void RpcLogic___SendMixingOperation_2669582547(MixOperation operation, int mixTime)
		{
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x8A7450", Offset = "0x8A6650", VA = "0x1808A7450")]
		private void RpcReader___Server_SendMixingOperation_2669582547(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452D")]
		[Address(RVA = "0x8A7EB0", Offset = "0x8A70B0", VA = "0x1808A7EB0")]
		private void RpcWriter___Observers_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTime)
		{
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452E")]
		[Address(RVA = "0x8A67F0", Offset = "0x8A59F0", VA = "0x1808A67F0", Slot = "143")]
		public virtual void RpcLogic___SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTime)
		{
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452F")]
		[Address(RVA = "0x8A71B0", Offset = "0x8A63B0", VA = "0x1808A71B0")]
		private void RpcReader___Observers_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004530")]
		[Address(RVA = "0x8A90D0", Offset = "0x8A82D0", VA = "0x1808A90D0")]
		private void RpcWriter___Target_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTime)
		{
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004531")]
		[Address(RVA = "0x8A7A90", Offset = "0x8A6C90", VA = "0x1808A7A90")]
		private void RpcReader___Target_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004532")]
		[Address(RVA = "0x8A4C30", Offset = "0x8A3E30", VA = "0x1808A4C30")]
		private void RpcWriter___Observers_MixingDone_Networked_2166136261()
		{
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004533")]
		[Address(RVA = "0x8A6670", Offset = "0x8A5870", VA = "0x1808A6670")]
		public void RpcLogic___MixingDone_Networked_2166136261()
		{
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004534")]
		[Address(RVA = "0x8A70D0", Offset = "0x8A62D0", VA = "0x1808A70D0")]
		private void RpcReader___Observers_MixingDone_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x8A8FC0", Offset = "0x8A81C0", VA = "0x1808A8FC0")]
		private void RpcWriter___Server_TryCreateOutputItems_2166136261()
		{
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004536")]
		[Address(RVA = "0x8A6E80", Offset = "0x8A6080", VA = "0x1808A6E80")]
		public void RpcLogic___TryCreateOutputItems_2166136261()
		{
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004537")]
		[Address(RVA = "0x8A7A60", Offset = "0x8A6C60", VA = "0x1808A7A60")]
		private void RpcReader___Server_TryCreateOutputItems_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004538")]
		[Address(RVA = "0x8A8E50", Offset = "0x8A8050", VA = "0x1808A8E50")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004539")]
		[Address(RVA = "0x8A6D40", Offset = "0x8A5F40", VA = "0x1808A6D40", Slot = "144")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453A")]
		[Address(RVA = "0x8A7970", Offset = "0x8A6B70", VA = "0x1808A7970")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x8A8350", Offset = "0x8A7550", VA = "0x1808A8350")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x8A6DC0", Offset = "0x8A5FC0", VA = "0x1808A6DC0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453D")]
		[Address(RVA = "0x8A73C0", Offset = "0x8A65C0", VA = "0x1808A73C0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453E")]
		[Address(RVA = "0x8A9540", Offset = "0x8A8740", VA = "0x1808A9540")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453F")]
		[Address(RVA = "0x8A7CA0", Offset = "0x8A6EA0", VA = "0x1808A7CA0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004540")]
		[Address(RVA = "0x8A8770", Offset = "0x8A7970", VA = "0x1808A8770")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x8A6760", Offset = "0x8A5960", VA = "0x1808A6760", Slot = "145")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004542")]
		[Address(RVA = "0x8A7580", Offset = "0x8A6780", VA = "0x1808A7580")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004543")]
		[Address(RVA = "0x8A7D30", Offset = "0x8A6F30", VA = "0x1808A7D30")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004544")]
		[Address(RVA = "0x8A6770", Offset = "0x8A5970", VA = "0x1808A6770")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004545")]
		[Address(RVA = "0x8A7110", Offset = "0x8A6310", VA = "0x1808A7110")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004546")]
		[Address(RVA = "0x8A8CC0", Offset = "0x8A7EC0", VA = "0x1808A8CC0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004547")]
		[Address(RVA = "0x8A6C10", Offset = "0x8A5E10", VA = "0x1808A6C10", Slot = "146")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004548")]
		[Address(RVA = "0x8A7820", Offset = "0x8A6A20", VA = "0x1808A7820")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004549")]
		[Address(RVA = "0x8A93B0", Offset = "0x8A85B0", VA = "0x1808A93B0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454A")]
		[Address(RVA = "0x8A6C90", Offset = "0x8A5E90", VA = "0x1808A6C90")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x8A7BB0", Offset = "0x8A6DB0", VA = "0x1808A7BB0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454C")]
		[Address(RVA = "0x8A81B0", Offset = "0x8A73B0", VA = "0x1808A81B0")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454D")]
		[Address(RVA = "0x8A72D0", Offset = "0x8A64D0", VA = "0x1808A72D0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454E")]
		[Address(RVA = "0x8A8B50", Offset = "0x8A7D50", VA = "0x1808A8B50")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454F")]
		[Address(RVA = "0x8A6B10", Offset = "0x8A5D10", VA = "0x1808A6B10", Slot = "147")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x8A7730", Offset = "0x8A6930", VA = "0x1808A7730")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004551")]
		[Address(RVA = "0x8A8030", Offset = "0x8A7230", VA = "0x1808A8030")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004552")]
		[Address(RVA = "0x8A6B90", Offset = "0x8A5D90", VA = "0x1808A6B90")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004553")]
		[Address(RVA = "0x8A7240", Offset = "0x8A6440", VA = "0x1808A7240")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004554")]
		[Address(RVA = "0x8A9240", Offset = "0x8A8440", VA = "0x1808A9240")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004555")]
		[Address(RVA = "0x8A7B20", Offset = "0x8A6D20", VA = "0x1808A7B20")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004556")]
		[Address(RVA = "0x8A8A20", Offset = "0x8A7C20", VA = "0x1808A8A20")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x8A6970", Offset = "0x8A5B70", VA = "0x1808A6970", Slot = "148")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x8A76B0", Offset = "0x8A68B0", VA = "0x1808A76B0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x8A88F0", Offset = "0x8A7AF0", VA = "0x1808A88F0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x8A68D0", Offset = "0x8A5AD0", VA = "0x1808A68D0", Slot = "149")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x8A7630", Offset = "0x8A6830", VA = "0x1808A7630")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600455D RID: 17757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADA")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x600455C")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880")]
			get
			{
				return null;
			}
			[Token(Token = "0x600455D")]
			[Address(RVA = "0x8AB6B0", Offset = "0x8AA8B0", VA = "0x1808AB6B0")]
			set
			{
			}
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x600455E")]
		[Address(RVA = "0x8A64D0", Offset = "0x8A56D0", VA = "0x1808A64D0", Slot = "150")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.MixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004560 RID: 17760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADB")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x600455F")]
			[Address(RVA = "0x835000", Offset = "0x834200", VA = "0x180835000")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004560")]
			[Address(RVA = "0x8AB770", Offset = "0x8AA970", VA = "0x1808AB770")]
			set
			{
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004562 RID: 17762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ADC")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6004561")]
			[Address(RVA = "0x8036C0", Offset = "0x8028C0", VA = "0x1808036C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004562")]
			[Address(RVA = "0x8AB5F0", Offset = "0x8AA7F0", VA = "0x1808AB5F0")]
			set
			{
			}
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x8A2CC0", Offset = "0x8A1EC0", VA = "0x1808A2CC0", Slot = "151")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.MixingStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400316E RID: 12654
		[Token(Token = "0x400316E")]
		[FieldOffset(Offset = "0x228")]
		public ItemSlot ProductSlot;

		// Token: 0x0400316F RID: 12655
		[Token(Token = "0x400316F")]
		[FieldOffset(Offset = "0x230")]
		public ItemSlot MixerSlot;

		// Token: 0x04003170 RID: 12656
		[Token(Token = "0x4003170")]
		[FieldOffset(Offset = "0x238")]
		public ItemSlot OutputSlot;

		// Token: 0x04003174 RID: 12660
		[Token(Token = "0x4003174")]
		[FieldOffset(Offset = "0x258")]
		public bool RequiresIngredientInsertion;

		// Token: 0x0400317C RID: 12668
		[Token(Token = "0x400317C")]
		[FieldOffset(Offset = "0x290")]
		[Header("Settings")]
		public int MixTimePerItem;

		// Token: 0x0400317D RID: 12669
		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0x294")]
		public int MaxMixQuantity;

		// Token: 0x0400317E RID: 12670
		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x298")]
		[Header("Prefabs")]
		public GameObject JugPrefab;

		// Token: 0x0400317F RID: 12671
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0x2A0")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04003180 RID: 12672
		[Token(Token = "0x4003180")]
		[FieldOffset(Offset = "0x2A8")]
		public Transform CameraPosition;

		// Token: 0x04003181 RID: 12673
		[Token(Token = "0x4003181")]
		[FieldOffset(Offset = "0x2B0")]
		public Transform CameraPosition_CombineIngredients;

		// Token: 0x04003182 RID: 12674
		[Token(Token = "0x4003182")]
		[FieldOffset(Offset = "0x2B8")]
		public Transform CameraPosition_StartMachine;

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		[FieldOffset(Offset = "0x2C0")]
		public StorageVisualizer InputVisuals;

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		[FieldOffset(Offset = "0x2C8")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003185 RID: 12677
		[Token(Token = "0x4003185")]
		[FieldOffset(Offset = "0x2D0")]
		public DigitalAlarm Clock;

		// Token: 0x04003186 RID: 12678
		[Token(Token = "0x4003186")]
		[FieldOffset(Offset = "0x2D8")]
		public ToggleableLight Light;

		// Token: 0x04003187 RID: 12679
		[Token(Token = "0x4003187")]
		[FieldOffset(Offset = "0x2E0")]
		public NewMixDiscoveryBox DiscoveryBox;

		// Token: 0x04003188 RID: 12680
		[Token(Token = "0x4003188")]
		[FieldOffset(Offset = "0x2E8")]
		public Transform ItemContainer;

		// Token: 0x04003189 RID: 12681
		[Token(Token = "0x4003189")]
		[FieldOffset(Offset = "0x2F0")]
		public Transform[] IngredientTransforms;

		// Token: 0x0400318A RID: 12682
		[Token(Token = "0x400318A")]
		[FieldOffset(Offset = "0x2F8")]
		public Fillable BowlFillable;

		// Token: 0x0400318B RID: 12683
		[Token(Token = "0x400318B")]
		[FieldOffset(Offset = "0x300")]
		public Clickable StartButton;

		// Token: 0x0400318C RID: 12684
		[Token(Token = "0x400318C")]
		[FieldOffset(Offset = "0x308")]
		public Transform JugAlignment;

		// Token: 0x0400318D RID: 12685
		[Token(Token = "0x400318D")]
		[FieldOffset(Offset = "0x310")]
		public Rigidbody Anchor;

		// Token: 0x0400318E RID: 12686
		[Token(Token = "0x400318E")]
		[FieldOffset(Offset = "0x318")]
		public BoxCollider TrashSpawnVolume;

		// Token: 0x0400318F RID: 12687
		[Token(Token = "0x400318F")]
		[FieldOffset(Offset = "0x320")]
		public Transform uiPoint;

		// Token: 0x04003190 RID: 12688
		[Token(Token = "0x4003190")]
		[FieldOffset(Offset = "0x328")]
		public Transform[] accessPoints;

		// Token: 0x04003191 RID: 12689
		[Token(Token = "0x4003191")]
		[FieldOffset(Offset = "0x330")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x04003192 RID: 12690
		[Token(Token = "0x4003192")]
		[FieldOffset(Offset = "0x338")]
		[Header("Sounds")]
		public StartLoopStopAudio MachineSound;

		// Token: 0x04003193 RID: 12691
		[Token(Token = "0x4003193")]
		[FieldOffset(Offset = "0x340")]
		public AudioSourceController StartSound;

		// Token: 0x04003194 RID: 12692
		[Token(Token = "0x4003194")]
		[FieldOffset(Offset = "0x348")]
		public AudioSourceController StopSound;

		// Token: 0x04003195 RID: 12693
		[Token(Token = "0x4003195")]
		[FieldOffset(Offset = "0x350")]
		[Header("UI")]
		[Header("Mix Timing")]
		public MixingStationUIElement WorldspaceUIPrefab;

		// Token: 0x04003196 RID: 12694
		[Token(Token = "0x4003196")]
		[FieldOffset(Offset = "0x358")]
		public Sprite typeIcon;

		// Token: 0x04003197 RID: 12695
		[Token(Token = "0x4003197")]
		[FieldOffset(Offset = "0x360")]
		public UnityEvent onMixStart;

		// Token: 0x04003198 RID: 12696
		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0x368")]
		public UnityEvent onMixDone;

		// Token: 0x04003199 RID: 12697
		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0x370")]
		public UnityEvent onOutputCollected;

		// Token: 0x0400319A RID: 12698
		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0x378")]
		public UnityEvent onStartButtonClicked;

		// Token: 0x0400319B RID: 12699
		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0x380")]
		[Header("Animations")]
		[SerializeField]
		protected PlayAnimation _mixerAnimator;

		// Token: 0x0400319E RID: 12702
		[Token(Token = "0x400319E")]
		[FieldOffset(Offset = "0x3A8")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x0400319F RID: 12703
		[Token(Token = "0x400319F")]
		[FieldOffset(Offset = "0x3B0")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x040031A0 RID: 12704
		[Token(Token = "0x40031A0")]
		[FieldOffset(Offset = "0x3B8")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x040031A1 RID: 12705
		[Token(Token = "0x40031A1")]
		[FieldOffset(Offset = "0x3C0")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x040031A2 RID: 12706
		[Token(Token = "0x40031A2")]
		[FieldOffset(Offset = "0x3C1")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationAssembly-CSharp.dll_Excuted;
	}
}
