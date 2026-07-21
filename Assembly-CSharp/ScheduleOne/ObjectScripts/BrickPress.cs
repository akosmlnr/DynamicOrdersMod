using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000984 RID: 2436
	[Token(Token = "0x2000984")]
	public class BrickPress : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x17000A1E")]
		public bool isOpen
		{
			[Token(Token = "0x600414F")]
			[Address(RVA = "0x875FC0", Offset = "0x8751C0", VA = "0x180875FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06004150 RID: 16720 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004151 RID: 16721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1F")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6004150")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004151")]
			[Address(RVA = "0x876080", Offset = "0x875280", VA = "0x180876080", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004153 RID: 16723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A20")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6004152")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004153")]
			[Address(RVA = "0x872380", Offset = "0x871580", VA = "0x180872380", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004155 RID: 16725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A21")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6004154")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004155")]
			[Address(RVA = "0x872420", Offset = "0x871620", VA = "0x180872420", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06004156 RID: 16726 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004157 RID: 16727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A22")]
		public ItemSlot[] ProductSlots
		{
			[Token(Token = "0x6004156")]
			[Address(RVA = "0x66B540", Offset = "0x66A740", VA = "0x18066B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004157")]
			[Address(RVA = "0x66BD90", Offset = "0x66AF90", VA = "0x18066BD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004159 RID: 16729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A23")]
		public ItemSlot OutputSlot
		{
			[Token(Token = "0x6004158")]
			[Address(RVA = "0x834F80", Offset = "0x834180", VA = "0x180834F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004159")]
			[Address(RVA = "0x8760A0", Offset = "0x8752A0", VA = "0x1808760A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A24")]
		public string Name
		{
			[Token(Token = "0x600415A")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A25")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x600415B")]
			[Address(RVA = "0x834F70", Offset = "0x834170", VA = "0x180834F70", Slot = "93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600415C")]
			[Address(RVA = "0x8351E0", Offset = "0x8343E0", VA = "0x1808351E0", Slot = "94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A26")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x600415D")]
			[Address(RVA = "0x66B8A0", Offset = "0x66AAA0", VA = "0x18066B8A0", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600415E")]
			[Address(RVA = "0x8760C0", Offset = "0x8752C0", VA = "0x1808760C0", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A27")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x600415F")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06004160 RID: 16736 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A28")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6004160")]
			[Address(RVA = "0x66B570", Offset = "0x66A770", VA = "0x18066B570", Slot = "98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x000127C8 File Offset: 0x000109C8
		[Token(Token = "0x17000A29")]
		public bool Selectable
		{
			[Token(Token = "0x6004161")]
			[Address(RVA = "0x875FA0", Offset = "0x8751A0", VA = "0x180875FA0", Slot = "99")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06004162 RID: 16738 RVA: 0x000127E0 File Offset: 0x000109E0
		// (set) Token: 0x06004163 RID: 16739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2A")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6004162")]
			[Address(RVA = "0x875F90", Offset = "0x875190", VA = "0x180875F90", Slot = "100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004163")]
			[Address(RVA = "0x876070", Offset = "0x875270", VA = "0x180876070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A2B")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6004164")]
			[Address(RVA = "0x66B8C0", Offset = "0x66AAC0", VA = "0x18066B8C0", Slot = "114")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004166 RID: 16742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2C")]
		protected BrickPressConfiguration stationConfiguration
		{
			[Token(Token = "0x6004165")]
			[Address(RVA = "0x66B8C0", Offset = "0x66AAC0", VA = "0x18066B8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004166")]
			[Address(RVA = "0x66C0A0", Offset = "0x66B2A0", VA = "0x18066C0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A2D")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6004167")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0", Slot = "115")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x000127F8 File Offset: 0x000109F8
		[Token(Token = "0x17000A2E")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6004168")]
			[Address(RVA = "0x572510", Offset = "0x571710", VA = "0x180572510", Slot = "116")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600416A RID: 16746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2F")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6004169")]
			[Address(RVA = "0x875FB0", Offset = "0x8751B0", VA = "0x180875FB0", Slot = "117")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600416A")]
			[Address(RVA = "0x8760E0", Offset = "0x8752E0", VA = "0x1808760E0", Slot = "118")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600416C RID: 16748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A30")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x600416B")]
			[Address(RVA = "0x875F80", Offset = "0x875180", VA = "0x180875F80", Slot = "119")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600416C")]
			[Address(RVA = "0x872250", Offset = "0x871450", VA = "0x180872250", Slot = "120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600416D")]
		[Address(RVA = "0x8747C0", Offset = "0x8739C0", VA = "0x1808747C0", Slot = "134")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A31")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x600416E")]
			[Address(RVA = "0x66B560", Offset = "0x66A760", VA = "0x18066B560", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A32")]
		public Transform Transform
		{
			[Token(Token = "0x600416F")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A33")]
		public Transform UIPoint
		{
			[Token(Token = "0x6004170")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x00012810 File Offset: 0x00010A10
		[Token(Token = "0x17000A34")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6004171")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004172")]
		[Address(RVA = "0x86ED50", Offset = "0x86DF50", VA = "0x18086ED50", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004173")]
		[Address(RVA = "0x870FF0", Offset = "0x8701F0", VA = "0x180870FF0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004174")]
		[Address(RVA = "0x8706B0", Offset = "0x86F8B0", VA = "0x1808706B0", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004175")]
		[Address(RVA = "0x871210", Offset = "0x870410", VA = "0x180871210", Slot = "136")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004176")]
		[Address(RVA = "0x871A20", Offset = "0x870C20", VA = "0x180871A20", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004177")]
		[Address(RVA = "0x874660", Offset = "0x873860", VA = "0x180874660", Slot = "135")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004178")]
		[Address(RVA = "0x86FDA0", Offset = "0x86EFA0", VA = "0x18086FDA0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x6004179")]
		[Address(RVA = "0x86EDA0", Offset = "0x86DFA0", VA = "0x18086EDA0", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417A")]
		[Address(RVA = "0x86FC50", Offset = "0x86EE50", VA = "0x18086FC50", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417B")]
		[Address(RVA = "0x874D40", Offset = "0x873F40", VA = "0x180874D40", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417C")]
		[Address(RVA = "0x874C10", Offset = "0x873E10", VA = "0x180874C10", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x600417D")]
		[Address(RVA = "0x870A90", Offset = "0x86FC90", VA = "0x180870A90")]
		public PackagingStation.EState GetState()
		{
			return PackagingStation.EState.CanBegin;
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600417E")]
		[Address(RVA = "0x875CB0", Offset = "0x874EB0", VA = "0x180875CB0")]
		private void UpdateInputVisuals()
		{
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x00012858 File Offset: 0x00010A58
		[Token(Token = "0x600417F")]
		[Address(RVA = "0x870D80", Offset = "0x86FF80", VA = "0x180870D80")]
		public bool HasSufficientProduct(out ProductItemInstance product)
		{
			return default(bool);
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004180")]
		[Address(RVA = "0x86FFB0", Offset = "0x86F1B0", VA = "0x18086FFB0")]
		public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity)
		{
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004181")]
		[Address(RVA = "0x86F410", Offset = "0x86E610", VA = "0x18086F410")]
		public Draggable CreateFunctionalContainer(ProductItemInstance instance, float productScale, out List<FunctionalProduct> products)
		{
			return null;
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004182")]
		[Address(RVA = "0x872030", Offset = "0x871230", VA = "0x180872030")]
		public void PlayPressAnim()
		{
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004183")]
		[Address(RVA = "0x86F1C0", Offset = "0x86E3C0", VA = "0x18086F1C0")]
		public void CompletePress(ProductItemInstance product)
		{
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004184")]
		[Address(RVA = "0x8706E0", Offset = "0x86F8E0", VA = "0x1808706E0")]
		public List<FunctionalProduct> GetProductInMould()
		{
			return null;
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004185")]
		[Address(RVA = "0x86F990", Offset = "0x86EB90", VA = "0x18086F990", Slot = "128")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004186")]
		[Address(RVA = "0x86FBC0", Offset = "0x86EDC0", VA = "0x18086FBC0", Slot = "129")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004187")]
		[Address(RVA = "0x870EB0", Offset = "0x8700B0", VA = "0x180870EB0")]
		public void Hovered()
		{
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x871160", Offset = "0x870360", VA = "0x180871160")]
		public void Interacted()
		{
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004189")]
		[Address(RVA = "0x871C30", Offset = "0x870E30", VA = "0x180871C30")]
		public void Open()
		{
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418A")]
		[Address(RVA = "0x86EE70", Offset = "0x86E070", VA = "0x18086EE70")]
		public void Close()
		{
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418B")]
		[Address(RVA = "0x875AA0", Offset = "0x874CA0", VA = "0x180875AA0", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x8757E0", Offset = "0x8749E0", VA = "0x1808757E0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x874AA0", Offset = "0x873CA0", VA = "0x180874AA0", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x8748F0", Offset = "0x873AF0", VA = "0x1808748F0")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x8755F0", Offset = "0x8747F0", VA = "0x1808755F0", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004190")]
		[Address(RVA = "0x8752D0", Offset = "0x8744D0", VA = "0x1808752D0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004191")]
		[Address(RVA = "0x875130", Offset = "0x874330", VA = "0x180875130", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004192")]
		[Address(RVA = "0x874E70", Offset = "0x874070", VA = "0x180874E70")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004193")]
		[Address(RVA = "0x86FE90", Offset = "0x86F090", VA = "0x18086FE90", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004194")]
		[Address(RVA = "0x8709E0", Offset = "0x86FBE0", VA = "0x1808709E0", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004195")]
		[Address(RVA = "0x875E90", Offset = "0x875090", VA = "0x180875E90")]
		public BrickPress()
		{
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004196")]
		[Address(RVA = "0x875C40", Offset = "0x874E40", VA = "0x180875C40")]
		[CompilerGenerated]
		private IEnumerator <PlayPressAnim>g__Routine|110_0()
		{
			return null;
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004197")]
		[Address(RVA = "0x8713C0", Offset = "0x8705C0", VA = "0x1808713C0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004198")]
		[Address(RVA = "0x871330", Offset = "0x870530", VA = "0x180871330", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004199")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419A")]
		[Address(RVA = "0x873870", Offset = "0x872A70", VA = "0x180873870")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419B")]
		[Address(RVA = "0x872250", Offset = "0x871450", VA = "0x180872250", Slot = "137")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419C")]
		[Address(RVA = "0x872AE0", Offset = "0x871CE0", VA = "0x180872AE0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419D")]
		[Address(RVA = "0x873C50", Offset = "0x872E50", VA = "0x180873C50")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419E")]
		[Address(RVA = "0x872420", Offset = "0x871620", VA = "0x180872420", Slot = "138")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419F")]
		[Address(RVA = "0x872C90", Offset = "0x871E90", VA = "0x180872C90")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A0")]
		[Address(RVA = "0x873B20", Offset = "0x872D20", VA = "0x180873B20")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A1")]
		[Address(RVA = "0x872380", Offset = "0x871580", VA = "0x180872380", Slot = "139")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A2")]
		[Address(RVA = "0x872C10", Offset = "0x871E10", VA = "0x180872C10")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A3")]
		[Address(RVA = "0x874080", Offset = "0x873280", VA = "0x180874080")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0x8726F0", Offset = "0x8718F0", VA = "0x1808726F0", Slot = "140")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x872F50", Offset = "0x872150", VA = "0x180872F50")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0x8736F0", Offset = "0x8728F0", VA = "0x1808736F0")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A7")]
		[Address(RVA = "0x872770", Offset = "0x871970", VA = "0x180872770")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x872A50", Offset = "0x871C50", VA = "0x180872A50")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x8744F0", Offset = "0x8736F0", VA = "0x1808744F0")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x8731C0", Offset = "0x8723C0", VA = "0x1808731C0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041AB")]
		[Address(RVA = "0x8739A0", Offset = "0x872BA0", VA = "0x1808739A0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041AC")]
		[Address(RVA = "0x8722F0", Offset = "0x8714F0", VA = "0x1808722F0", Slot = "141")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060041AD RID: 16813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041AD")]
		[Address(RVA = "0x872B60", Offset = "0x871D60", VA = "0x180872B60")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041AE")]
		[Address(RVA = "0x873250", Offset = "0x872450", VA = "0x180873250")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041AF")]
		[Address(RVA = "0x872300", Offset = "0x871500", VA = "0x180872300")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B0")]
		[Address(RVA = "0x872830", Offset = "0x871A30", VA = "0x180872830")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B1")]
		[Address(RVA = "0x873EF0", Offset = "0x8730F0", VA = "0x180873EF0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B2")]
		[Address(RVA = "0x8725C0", Offset = "0x8717C0", VA = "0x1808725C0", Slot = "142")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B3")]
		[Address(RVA = "0x872E00", Offset = "0x872000", VA = "0x180872E00")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B4")]
		[Address(RVA = "0x874360", Offset = "0x873560", VA = "0x180874360")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B5")]
		[Address(RVA = "0x872640", Offset = "0x871840", VA = "0x180872640")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B6")]
		[Address(RVA = "0x8730D0", Offset = "0x8722D0", VA = "0x1808730D0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B7")]
		[Address(RVA = "0x873550", Offset = "0x872750", VA = "0x180873550")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B8")]
		[Address(RVA = "0x872960", Offset = "0x871B60", VA = "0x180872960")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041B9")]
		[Address(RVA = "0x873D80", Offset = "0x872F80", VA = "0x180873D80")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BA")]
		[Address(RVA = "0x8724C0", Offset = "0x8716C0", VA = "0x1808724C0", Slot = "143")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BB")]
		[Address(RVA = "0x872D10", Offset = "0x871F10", VA = "0x180872D10")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BC")]
		[Address(RVA = "0x8733D0", Offset = "0x8725D0", VA = "0x1808733D0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BD")]
		[Address(RVA = "0x872540", Offset = "0x871740", VA = "0x180872540")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BE")]
		[Address(RVA = "0x8728D0", Offset = "0x871AD0", VA = "0x1808728D0")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041BF")]
		[Address(RVA = "0x8741F0", Offset = "0x8733F0", VA = "0x1808741F0")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C0")]
		[Address(RVA = "0x873040", Offset = "0x872240", VA = "0x180873040")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060041C2 RID: 16834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A35")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x60041C1")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480")]
			get
			{
				return null;
			}
			[Token(Token = "0x60041C2")]
			[Address(RVA = "0x8761C0", Offset = "0x8753C0", VA = "0x1808761C0")]
			set
			{
			}
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x00012870 File Offset: 0x00010A70
		[Token(Token = "0x60041C3")]
		[Address(RVA = "0x8720B0", Offset = "0x8712B0", VA = "0x1808720B0", Slot = "144")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.BrickPress(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060041C4 RID: 16836 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060041C5 RID: 16837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A36")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x60041C4")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60041C5")]
			[Address(RVA = "0x876280", Offset = "0x875480", VA = "0x180876280")]
			set
			{
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x060041C6 RID: 16838 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060041C7 RID: 16839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A37")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x60041C6")]
			[Address(RVA = "0x875F80", Offset = "0x875180", VA = "0x180875F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60041C7")]
			[Address(RVA = "0x876100", Offset = "0x875300", VA = "0x180876100")]
			set
			{
			}
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C8")]
		[Address(RVA = "0x86E940", Offset = "0x86DB40", VA = "0x18086E940", Slot = "145")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.BrickPress_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002F88 RID: 12168
		[Token(Token = "0x4002F88")]
		public const int INPUT_SLOT_COUNT = 2;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[FieldOffset(Offset = "0x228")]
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x230")]
		public Transform CameraPosition_Pouring;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x238")]
		public Transform CameraPosition_Raising;

		// Token: 0x04002F8F RID: 12175
		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x240")]
		public InteractableObject IntObj;

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x248")]
		public Transform uiPoint;

		// Token: 0x04002F91 RID: 12177
		[Token(Token = "0x4002F91")]
		[FieldOffset(Offset = "0x250")]
		public Transform StandPoint;

		// Token: 0x04002F92 RID: 12178
		[Token(Token = "0x4002F92")]
		[FieldOffset(Offset = "0x258")]
		public Transform[] accessPoints;

		// Token: 0x04002F93 RID: 12179
		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x260")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x04002F94 RID: 12180
		[Token(Token = "0x4002F94")]
		[FieldOffset(Offset = "0x268")]
		public BrickPressContainer Container1;

		// Token: 0x04002F95 RID: 12181
		[Token(Token = "0x4002F95")]
		[FieldOffset(Offset = "0x270")]
		public BrickPressContainer Container2;

		// Token: 0x04002F96 RID: 12182
		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x278")]
		public Transform ItemContainer;

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		[FieldOffset(Offset = "0x280")]
		public Transform ContainerSpawnPoint;

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		[FieldOffset(Offset = "0x288")]
		public PackagingDefinition BrickPackaging;

		// Token: 0x04002F99 RID: 12185
		[Token(Token = "0x4002F99")]
		[FieldOffset(Offset = "0x290")]
		public BoxCollider MouldDetection;

		// Token: 0x04002F9A RID: 12186
		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0x298")]
		public BrickPressHandle Handle;

		// Token: 0x04002F9B RID: 12187
		[Token(Token = "0x4002F9B")]
		[FieldOffset(Offset = "0x2A0")]
		public Transform PressTransform;

		// Token: 0x04002F9C RID: 12188
		[Token(Token = "0x4002F9C")]
		[FieldOffset(Offset = "0x2A8")]
		public Transform PressTransform_Raised;

		// Token: 0x04002F9D RID: 12189
		[Token(Token = "0x4002F9D")]
		[FieldOffset(Offset = "0x2B0")]
		public Transform PressTransform_Lowered;

		// Token: 0x04002F9E RID: 12190
		[Token(Token = "0x4002F9E")]
		[FieldOffset(Offset = "0x2B8")]
		public AudioSourceController SlamSound;

		// Token: 0x04002F9F RID: 12191
		[Token(Token = "0x4002F9F")]
		[FieldOffset(Offset = "0x2C0")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x04002FA0 RID: 12192
		[Token(Token = "0x4002FA0")]
		[FieldOffset(Offset = "0x2C8")]
		[Header("Prefabs")]
		public Draggable FunctionalContainerPrefab;

		// Token: 0x04002FA1 RID: 12193
		[Token(Token = "0x4002FA1")]
		[FieldOffset(Offset = "0x2D0")]
		[Header("UI")]
		public BrickPressUIElement WorldspaceUIPrefab;

		// Token: 0x04002FA2 RID: 12194
		[Token(Token = "0x4002FA2")]
		[FieldOffset(Offset = "0x2D8")]
		public Sprite typeIcon;

		// Token: 0x04002FAC RID: 12204
		[Token(Token = "0x4002FAC")]
		[FieldOffset(Offset = "0x320")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04002FAD RID: 12205
		[Token(Token = "0x4002FAD")]
		[FieldOffset(Offset = "0x328")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04002FAE RID: 12206
		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0x330")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0x338")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted;

		// Token: 0x04002FB0 RID: 12208
		[Token(Token = "0x4002FB0")]
		[FieldOffset(Offset = "0x339")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BrickPressAssembly-CSharp.dll_Excuted;
	}
}
