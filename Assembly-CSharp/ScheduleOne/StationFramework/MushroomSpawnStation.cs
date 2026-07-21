using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008EB RID: 2283
	[Token(Token = "0x20008EB")]
	public class MushroomSpawnStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06003CCE RID: 15566 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CCF RID: 15567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000985")]
		public Transform CameraTransform
		{
			[Token(Token = "0x6003CCE")]
			[Address(RVA = "0x598F80", Offset = "0x598180", VA = "0x180598F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CCF")]
			[Address(RVA = "0x803900", Offset = "0x802B00", VA = "0x180803900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06003CD0 RID: 15568 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CD1 RID: 15569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000986")]
		public Transform TaskCameraTransform
		{
			[Token(Token = "0x6003CD0")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CD1")]
			[Address(RVA = "0x66BD40", Offset = "0x66AF40", VA = "0x18066BD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06003CD2 RID: 15570 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CD3 RID: 15571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000987")]
		public Transform TaskContainer
		{
			[Token(Token = "0x6003CD2")]
			[Address(RVA = "0x8035F0", Offset = "0x8027F0", VA = "0x1808035F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CD3")]
			[Address(RVA = "0x8037D0", Offset = "0x8029D0", VA = "0x1808037D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06003CD4 RID: 15572 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CD5 RID: 15573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000988")]
		public Transform SyringeStartTransform
		{
			[Token(Token = "0x6003CD4")]
			[Address(RVA = "0x8037A0", Offset = "0x8029A0", VA = "0x1808037A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CD5")]
			[Address(RVA = "0x803950", Offset = "0x802B50", VA = "0x180803950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06003CD6 RID: 15574 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CD7 RID: 15575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000989")]
		public Transform GrainBagStartTransform
		{
			[Token(Token = "0x6003CD6")]
			[Address(RVA = "0x834F90", Offset = "0x834190", VA = "0x180834F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CD7")]
			[Address(RVA = "0x835010", Offset = "0x834210", VA = "0x180835010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CD9 RID: 15577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098A")]
		public ItemSlot GrainBagSlot
		{
			[Token(Token = "0x6003CD8")]
			[Address(RVA = "0x66B890", Offset = "0x66AA90", VA = "0x18066B890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CD9")]
			[Address(RVA = "0x66C060", Offset = "0x66B260", VA = "0x18066C060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CDB RID: 15579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098B")]
		public ItemSlot SyringeSlot
		{
			[Token(Token = "0x6003CDA")]
			[Address(RVA = "0x834FF0", Offset = "0x8341F0", VA = "0x180834FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CDB")]
			[Address(RVA = "0x8351C0", Offset = "0x8343C0", VA = "0x1808351C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CDD RID: 15581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098C")]
		public ItemSlot OutputSlot
		{
			[Token(Token = "0x6003CDC")]
			[Address(RVA = "0x834FD0", Offset = "0x8341D0", VA = "0x180834FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CDD")]
			[Address(RVA = "0x835100", Offset = "0x834300", VA = "0x180835100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06003CDE RID: 15582 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CDF RID: 15583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098D")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6003CDE")]
			[Address(RVA = "0x803600", Offset = "0x802800", VA = "0x180803600", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CDF")]
			[Address(RVA = "0x8037F0", Offset = "0x8029F0", VA = "0x1808037F0", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06003CE0 RID: 15584 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CE1 RID: 15585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098E")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6003CE0")]
			[Address(RVA = "0x8035E0", Offset = "0x8027E0", VA = "0x1808035E0", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CE1")]
			[Address(RVA = "0x835060", Offset = "0x834260", VA = "0x180835060", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CE3 RID: 15587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098F")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6003CE2")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CE3")]
			[Address(RVA = "0x835120", Offset = "0x834320", VA = "0x180835120", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000990")]
		public string Name
		{
			[Token(Token = "0x6003CE4")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CE6 RID: 15590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000991")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6003CE5")]
			[Address(RVA = "0x803760", Offset = "0x802960", VA = "0x180803760", Slot = "93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CE6")]
			[Address(RVA = "0x835030", Offset = "0x834230", VA = "0x180835030", Slot = "94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CE8 RID: 15592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000992")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6003CE7")]
			[Address(RVA = "0x803620", Offset = "0x802820", VA = "0x180803620", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CE8")]
			[Address(RVA = "0x803820", Offset = "0x802A20", VA = "0x180803820", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000993")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6003CE9")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06003CEA RID: 15594 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000994")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6003CEA")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480", Slot = "98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x17000995")]
		public bool Selectable
		{
			[Token(Token = "0x6003CEB")]
			[Address(RVA = "0x834FE0", Offset = "0x8341E0", VA = "0x180834FE0", Slot = "99")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x000118E0 File Offset: 0x0000FAE0
		// (set) Token: 0x06003CED RID: 15597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000996")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6003CEC")]
			[Address(RVA = "0x834FA0", Offset = "0x8341A0", VA = "0x180834FA0", Slot = "100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003CED")]
			[Address(RVA = "0x835050", Offset = "0x834250", VA = "0x180835050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000997")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6003CEE")]
			[Address(RVA = "0x834F70", Offset = "0x834170", VA = "0x180834F70", Slot = "114")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000998")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6003CEF")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880", Slot = "115")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x000118F8 File Offset: 0x0000FAF8
		[Token(Token = "0x17000999")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6003CF0")]
			[Address(RVA = "0x834F60", Offset = "0x834160", VA = "0x180834F60", Slot = "116")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CF2 RID: 15602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099A")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6003CF1")]
			[Address(RVA = "0x66B540", Offset = "0x66A740", VA = "0x18066B540", Slot = "117")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CF2")]
			[Address(RVA = "0x66BD90", Offset = "0x66AF90", VA = "0x18066BD90", Slot = "118")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CF4 RID: 15604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099B")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6003CF3")]
			[Address(RVA = "0x834F80", Offset = "0x834180", VA = "0x180834F80", Slot = "119")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CF4")]
			[Address(RVA = "0x831150", Offset = "0x830350", VA = "0x180831150", Slot = "120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700099C")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6003CF5")]
			[Address(RVA = "0x835000", Offset = "0x834200", VA = "0x180835000", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700099D")]
		public Transform Transform
		{
			[Token(Token = "0x6003CF6")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700099E")]
		public Transform UIPoint
		{
			[Token(Token = "0x6003CF7")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06003CF8 RID: 15608 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x1700099F")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6003CF8")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003CFA RID: 15610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A0")]
		private SpawnStationConfiguration _stationConfiguration
		{
			[Token(Token = "0x6003CF9")]
			[Address(RVA = "0x834F70", Offset = "0x834170", VA = "0x180834F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CFA")]
			[Address(RVA = "0x8351E0", Offset = "0x8343E0", VA = "0x1808351E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFB")]
		[Address(RVA = "0x82F570", Offset = "0x82E770", VA = "0x18082F570", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFC")]
		[Address(RVA = "0x82FEC0", Offset = "0x82F0C0", VA = "0x18082FEC0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003CFD")]
		[Address(RVA = "0x82FDE0", Offset = "0x82EFE0", VA = "0x18082FDE0", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFE")]
		[Address(RVA = "0x830D80", Offset = "0x82FF80", VA = "0x180830D80", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFF")]
		[Address(RVA = "0x82FA30", Offset = "0x82EC30", VA = "0x18082FA30", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00011928 File Offset: 0x0000FB28
		[Token(Token = "0x6003D00")]
		[Address(RVA = "0x82F5C0", Offset = "0x82E7C0", VA = "0x18082F5C0", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x834C80", Offset = "0x833E80", VA = "0x180834C80")]
		public void Use()
		{
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x830BD0", Offset = "0x82FDD0", VA = "0x180830BD0")]
		private void OnInterfaceExited()
		{
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00011940 File Offset: 0x0000FB40
		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x82FB00", Offset = "0x82ED00", VA = "0x18082FB00")]
		public bool DoesStationContainRequiredItems()
		{
			return default(bool);
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00011958 File Offset: 0x0000FB58
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x82FB50", Offset = "0x82ED50", VA = "0x18082FB50")]
		public bool DoesStationHaveOutputSpace()
		{
			return default(bool);
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x833D80", Offset = "0x832F80", VA = "0x180833D80", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x833C50", Offset = "0x832E50", VA = "0x180833C50", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D07")]
		[Address(RVA = "0x833800", Offset = "0x832A00", VA = "0x180833800", Slot = "134")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D08")]
		[Address(RVA = "0x8336A0", Offset = "0x8328A0", VA = "0x1808336A0", Slot = "135")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003D09")]
		[Address(RVA = "0x82F770", Offset = "0x82E970", VA = "0x18082F770", Slot = "128")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0A")]
		[Address(RVA = "0x82F9A0", Offset = "0x82EBA0", VA = "0x18082F9A0", Slot = "129")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0B")]
		[Address(RVA = "0x834AE0", Offset = "0x833CE0", VA = "0x180834AE0", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0C")]
		[Address(RVA = "0x834820", Offset = "0x833A20", VA = "0x180834820")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0D")]
		[Address(RVA = "0x833AE0", Offset = "0x832CE0", VA = "0x180833AE0", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0E")]
		[Address(RVA = "0x833930", Offset = "0x832B30", VA = "0x180833930")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D0F")]
		[Address(RVA = "0x834630", Offset = "0x833830", VA = "0x180834630", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x834310", Offset = "0x833510", VA = "0x180834310")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x834170", Offset = "0x833370", VA = "0x180834170", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x833EB0", Offset = "0x8330B0", VA = "0x180833EB0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003D13")]
		[Address(RVA = "0x82FCC0", Offset = "0x82EEC0", VA = "0x18082FCC0", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003D14")]
		[Address(RVA = "0x82FE10", Offset = "0x82F010", VA = "0x18082FE10", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D15")]
		[Address(RVA = "0x834E70", Offset = "0x834070", VA = "0x180834E70")]
		public MushroomSpawnStation()
		{
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D16")]
		[Address(RVA = "0x830570", Offset = "0x82F770", VA = "0x180830570", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D17")]
		[Address(RVA = "0x8304E0", Offset = "0x82F6E0", VA = "0x1808304E0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D18")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D19")]
		[Address(RVA = "0x832C90", Offset = "0x831E90", VA = "0x180832C90")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1A")]
		[Address(RVA = "0x8313C0", Offset = "0x8305C0", VA = "0x1808313C0", Slot = "136")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1B")]
		[Address(RVA = "0x831CD0", Offset = "0x830ED0", VA = "0x180831CD0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1C")]
		[Address(RVA = "0x832B60", Offset = "0x831D60", VA = "0x180832B60")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1D")]
		[Address(RVA = "0x831280", Offset = "0x830480", VA = "0x180831280", Slot = "137")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1E")]
		[Address(RVA = "0x831C50", Offset = "0x830E50", VA = "0x180831C50")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1F")]
		[Address(RVA = "0x8328B0", Offset = "0x831AB0", VA = "0x1808328B0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D20")]
		[Address(RVA = "0x831150", Offset = "0x830350", VA = "0x180831150", Slot = "138")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D21")]
		[Address(RVA = "0x831B20", Offset = "0x830D20", VA = "0x180831B20")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D22")]
		[Address(RVA = "0x8330C0", Offset = "0x8322C0", VA = "0x1808330C0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D23")]
		[Address(RVA = "0x831730", Offset = "0x830930", VA = "0x180831730", Slot = "139")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D24")]
		[Address(RVA = "0x831F90", Offset = "0x831190", VA = "0x180831F90")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D25")]
		[Address(RVA = "0x832730", Offset = "0x831930", VA = "0x180832730")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D26")]
		[Address(RVA = "0x8317B0", Offset = "0x8309B0", VA = "0x1808317B0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D27")]
		[Address(RVA = "0x831A90", Offset = "0x830C90", VA = "0x180831A90")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D28")]
		[Address(RVA = "0x833530", Offset = "0x832730", VA = "0x180833530")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D29")]
		[Address(RVA = "0x832200", Offset = "0x831400", VA = "0x180832200")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2A")]
		[Address(RVA = "0x8329E0", Offset = "0x831BE0", VA = "0x1808329E0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2B")]
		[Address(RVA = "0x8311F0", Offset = "0x8303F0", VA = "0x1808311F0", Slot = "140")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2C")]
		[Address(RVA = "0x831BA0", Offset = "0x830DA0", VA = "0x180831BA0")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2D")]
		[Address(RVA = "0x832290", Offset = "0x831490", VA = "0x180832290")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2E")]
		[Address(RVA = "0x831200", Offset = "0x830400", VA = "0x180831200")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2F")]
		[Address(RVA = "0x831870", Offset = "0x830A70", VA = "0x180831870")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D30")]
		[Address(RVA = "0x832F30", Offset = "0x832130", VA = "0x180832F30")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D31")]
		[Address(RVA = "0x831600", Offset = "0x830800", VA = "0x180831600", Slot = "141")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D32")]
		[Address(RVA = "0x831E40", Offset = "0x831040", VA = "0x180831E40")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D33")]
		[Address(RVA = "0x8333A0", Offset = "0x8325A0", VA = "0x1808333A0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D34")]
		[Address(RVA = "0x831680", Offset = "0x830880", VA = "0x180831680")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D35")]
		[Address(RVA = "0x832110", Offset = "0x831310", VA = "0x180832110")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D36")]
		[Address(RVA = "0x832590", Offset = "0x831790", VA = "0x180832590")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D37")]
		[Address(RVA = "0x8319A0", Offset = "0x830BA0", VA = "0x1808319A0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D38")]
		[Address(RVA = "0x832DC0", Offset = "0x831FC0", VA = "0x180832DC0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D39")]
		[Address(RVA = "0x831500", Offset = "0x830700", VA = "0x180831500", Slot = "142")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3A")]
		[Address(RVA = "0x831D50", Offset = "0x830F50", VA = "0x180831D50")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3B")]
		[Address(RVA = "0x832410", Offset = "0x831610", VA = "0x180832410")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3C")]
		[Address(RVA = "0x831580", Offset = "0x830780", VA = "0x180831580")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3D")]
		[Address(RVA = "0x831910", Offset = "0x830B10", VA = "0x180831910")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x833230", Offset = "0x832430", VA = "0x180833230")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3F")]
		[Address(RVA = "0x832080", Offset = "0x831280", VA = "0x180832080")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003D41 RID: 15681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A1")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6003D40")]
			[Address(RVA = "0x8035E0", Offset = "0x8027E0", VA = "0x1808035E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D41")]
			[Address(RVA = "0x8352C0", Offset = "0x8344C0", VA = "0x1808352C0")]
			set
			{
			}
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00011970 File Offset: 0x0000FB70
		[Token(Token = "0x6003D42")]
		[Address(RVA = "0x830FB0", Offset = "0x8301B0", VA = "0x180830FB0", Slot = "143")]
		public virtual bool ReadSyncVar___ScheduleOne.StationFramework.MushroomSpawnStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A2")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6003D43")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D44")]
			[Address(RVA = "0x835380", Offset = "0x834580", VA = "0x180835380")]
			set
			{
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003D46 RID: 15686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A3")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6003D45")]
			[Address(RVA = "0x834F80", Offset = "0x834180", VA = "0x180834F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D46")]
			[Address(RVA = "0x835200", Offset = "0x834400", VA = "0x180835200")]
			set
			{
			}
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D47")]
		[Address(RVA = "0x82F560", Offset = "0x82E760", VA = "0x18082F560", Slot = "144")]
		protected virtual void Awake_UserLogic_ScheduleOne.StationFramework.MushroomSpawnStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002CA9 RID: 11433
		[Token(Token = "0x4002CA9")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private Transform _uiPoint;

		// Token: 0x04002CAA RID: 11434
		[Token(Token = "0x4002CAA")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private Transform[] _accessPoints;

		// Token: 0x04002CAB RID: 11435
		[Token(Token = "0x4002CAB")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private ItemDefinition _grainBagDefinition;

		// Token: 0x04002CAC RID: 11436
		[Token(Token = "0x4002CAC")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private SporeSyringeDefinition[] _validSporeSyringeDefinitions;

		// Token: 0x04002CAD RID: 11437
		[Token(Token = "0x4002CAD")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private StorageVisualizer _grainBagVisualizer;

		// Token: 0x04002CAE RID: 11438
		[Token(Token = "0x4002CAE")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private StorageVisualizer _syringeVisualizer;

		// Token: 0x04002CAF RID: 11439
		[Token(Token = "0x4002CAF")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private StorageVisualizer _outputVisualizer;

		// Token: 0x04002CB0 RID: 11440
		[Token(Token = "0x4002CB0")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private ConfigurationReplicator _configReplicator;

		// Token: 0x04002CB1 RID: 11441
		[Token(Token = "0x4002CB1")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		private Sprite _typeIcon;

		// Token: 0x04002CB2 RID: 11442
		[Token(Token = "0x4002CB2")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		private WorldspaceUIElement _worldspaceUIPrefab;

		// Token: 0x04002CB8 RID: 11448
		[Token(Token = "0x4002CB8")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		private UnityEvent onUse;

		// Token: 0x04002CB9 RID: 11449
		[Token(Token = "0x4002CB9")]
		[FieldOffset(Offset = "0x290")]
		[SerializeField]
		private UnityEvent onUseEnded;

		// Token: 0x04002CC7 RID: 11463
		[Token(Token = "0x4002CC7")]
		[FieldOffset(Offset = "0x2F8")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04002CC8 RID: 11464
		[Token(Token = "0x4002CC8")]
		[FieldOffset(Offset = "0x300")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04002CC9 RID: 11465
		[Token(Token = "0x4002CC9")]
		[FieldOffset(Offset = "0x308")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04002CCA RID: 11466
		[Token(Token = "0x4002CCA")]
		[FieldOffset(Offset = "0x310")]
		private bool NetworkInitialize___EarlyScheduleOne.StationFramework.MushroomSpawnStationAssembly-CSharp.dll_Excuted;

		// Token: 0x04002CCB RID: 11467
		[Token(Token = "0x4002CCB")]
		[FieldOffset(Offset = "0x311")]
		private bool NetworkInitialize__LateScheduleOne.StationFramework.MushroomSpawnStationAssembly-CSharp.dll_Excuted;
	}
}
