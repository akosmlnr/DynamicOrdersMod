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
using ScheduleOne.Decoration;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009B4 RID: 2484
	[Token(Token = "0x20009B4")]
	public class PackagingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045D9 RID: 17881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE6")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60045D8")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D9")]
			[Address(RVA = "0x876080", Offset = "0x875280", VA = "0x180876080", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045DB RID: 17883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE7")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x60045DA")]
			[Address(RVA = "0x66B8C0", Offset = "0x66AAC0", VA = "0x18066B8C0", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045DB")]
			[Address(RVA = "0x8B4810", Offset = "0x8B3A10", VA = "0x1808B4810", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060045DC RID: 17884 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045DD RID: 17885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE8")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60045DC")]
			[Address(RVA = "0x875FB0", Offset = "0x8751B0", VA = "0x180875FB0", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045DD")]
			[Address(RVA = "0x8B9320", Offset = "0x8B8520", VA = "0x1808B9320", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060045DE RID: 17886 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AE9")]
		public string Name
		{
			[Token(Token = "0x60045DE")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEA")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60045DF")]
			[Address(RVA = "0x72EF70", Offset = "0x72E170", VA = "0x18072EF70", Slot = "93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045E0")]
			[Address(RVA = "0x72EFF0", Offset = "0x72E1F0", VA = "0x18072EFF0", Slot = "94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEB")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x60045E1")]
			[Address(RVA = "0x72EF60", Offset = "0x72E160", VA = "0x18072EF60", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045E2")]
			[Address(RVA = "0x72EFD0", Offset = "0x72E1D0", VA = "0x18072EFD0", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AEC")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x60045E3")]
			[Address(RVA = "0x834F90", Offset = "0x834190", VA = "0x180834F90", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060045E4 RID: 17892 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AED")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x60045E4")]
			[Address(RVA = "0x66B890", Offset = "0x66AA90", VA = "0x18066B890", Slot = "98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x00013350 File Offset: 0x00011550
		[Token(Token = "0x17000AEE")]
		public bool Selectable
		{
			[Token(Token = "0x60045E5")]
			[Address(RVA = "0x72EFA0", Offset = "0x72E1A0", VA = "0x18072EFA0", Slot = "99")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x00013368 File Offset: 0x00011568
		// (set) Token: 0x060045E7 RID: 17895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEF")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x60045E6")]
			[Address(RVA = "0x87F2C0", Offset = "0x87E4C0", VA = "0x18087F2C0", Slot = "100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60045E7")]
			[Address(RVA = "0x87F410", Offset = "0x87E610", VA = "0x18087F410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AF0")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60045E8")]
			[Address(RVA = "0x87F2A0", Offset = "0x87E4A0", VA = "0x18087F2A0", Slot = "114")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060045E9 RID: 17897 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045EA RID: 17898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF1")]
		protected PackagingStationConfiguration stationConfiguration
		{
			[Token(Token = "0x60045E9")]
			[Address(RVA = "0x87F2A0", Offset = "0x87E4A0", VA = "0x18087F2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045EA")]
			[Address(RVA = "0x87F440", Offset = "0x87E640", VA = "0x18087F440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060045EB RID: 17899 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AF2")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x60045EB")]
			[Address(RVA = "0x8036C0", Offset = "0x8028C0", VA = "0x1808036C0", Slot = "115")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x00013380 File Offset: 0x00011580
		[Token(Token = "0x17000AF3")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x60045EC")]
			[Address(RVA = "0x56A480", Offset = "0x569680", VA = "0x18056A480", Slot = "116")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045EE RID: 17902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF4")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x60045ED")]
			[Address(RVA = "0x87F2E0", Offset = "0x87E4E0", VA = "0x18087F2E0", Slot = "117")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045EE")]
			[Address(RVA = "0x87F420", Offset = "0x87E620", VA = "0x18087F420", Slot = "118")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060045EF RID: 17903 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060045F0 RID: 17904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF5")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x60045EF")]
			[Address(RVA = "0x87F2B0", Offset = "0x87E4B0", VA = "0x18087F2B0", Slot = "119")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045F0")]
			[Address(RVA = "0x8B46E0", Offset = "0x8B38E0", VA = "0x1808B46E0", Slot = "120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F1")]
		[Address(RVA = "0x8B6E80", Offset = "0x8B6080", VA = "0x1808B6E80", Slot = "134")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060045F2 RID: 17906 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AF6")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x60045F2")]
			[Address(RVA = "0x8035E0", Offset = "0x8027E0", VA = "0x1808035E0", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060045F3 RID: 17907 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AF7")]
		public Transform Transform
		{
			[Token(Token = "0x60045F3")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AF8")]
		public Transform UIPoint
		{
			[Token(Token = "0x60045F4")]
			[Address(RVA = "0x834F90", Offset = "0x834190", VA = "0x180834F90", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x17000AF9")]
		public bool CanBeSelected
		{
			[Token(Token = "0x60045F5")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F6")]
		[Address(RVA = "0x8B2090", Offset = "0x8B1290", VA = "0x1808B2090", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F7")]
		[Address(RVA = "0x8B3330", Offset = "0x8B2530", VA = "0x1808B3330", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x878E10", Offset = "0x878010", VA = "0x180878E10", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60045F9")]
		[Address(RVA = "0x8B2BD0", Offset = "0x8B1DD0", VA = "0x1808B2BD0", Slot = "51")]
		public override string GetDefaultManagementName()
		{
			return null;
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x8B3C40", Offset = "0x8B2E40", VA = "0x1808B3C40", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x8B6D70", Offset = "0x8B5F70", VA = "0x1808B6D70", Slot = "135")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x8B29A0", Offset = "0x8B1BA0", VA = "0x1808B29A0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x8B20E0", Offset = "0x8B12E0", VA = "0x1808B20E0", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x8B2850", Offset = "0x8B1A50", VA = "0x1808B2850", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FF")]
		[Address(RVA = "0x8B74F0", Offset = "0x8B66F0", VA = "0x1808B74F0", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004600")]
		[Address(RVA = "0x8B73C0", Offset = "0x8B65C0", VA = "0x1808B73C0", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004601")]
		[Address(RVA = "0x8B31F0", Offset = "0x8B23F0", VA = "0x1808B31F0")]
		public void Hovered()
		{
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004602")]
		[Address(RVA = "0x8B34A0", Offset = "0x8B26A0", VA = "0x1808B34A0")]
		public void Interacted()
		{
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004603")]
		[Address(RVA = "0x8B3D90", Offset = "0x8B2F90", VA = "0x1808B3D90")]
		public void Open()
		{
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004604")]
		[Address(RVA = "0x8B21B0", Offset = "0x8B13B0", VA = "0x1808B21B0")]
		public void Close()
		{
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x000133C8 File Offset: 0x000115C8
		[Token(Token = "0x6004605")]
		[Address(RVA = "0x8B2C90", Offset = "0x8B1E90", VA = "0x1808B2C90")]
		public PackagingStation.EState GetState(PackagingStation.EMode mode)
		{
			return PackagingStation.EState.CanBegin;
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004606")]
		[Address(RVA = "0x8B8450", Offset = "0x8B7650", VA = "0x1808B8450")]
		public void Unpack()
		{
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004607")]
		[Address(RVA = "0x8B4190", Offset = "0x8B3390", VA = "0x1808B4190")]
		public void PackSingleInstance()
		{
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004608")]
		[Address(RVA = "0x8B6FB0", Offset = "0x8B61B0", VA = "0x1808B6FB0")]
		public void SetHatchOpen(bool open)
		{
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004609")]
		[Address(RVA = "0x8B8650", Offset = "0x8B7850", VA = "0x1808B8650")]
		public void UpdatePackagingVisuals()
		{
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460A")]
		[Address(RVA = "0x8B83F0", Offset = "0x8B75F0", VA = "0x1808B83F0")]
		public void SetVisualsLocked(bool locked)
		{
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460B")]
		[Address(RVA = "0x8B8690", Offset = "0x8B7890", VA = "0x1808B8690")]
		public void UpdatePackagingVisuals(int quantity)
		{
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460C")]
		[Address(RVA = "0x8B8C10", Offset = "0x8B7E10", VA = "0x1808B8C10")]
		public void UpdateProductVisuals()
		{
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460D")]
		[Address(RVA = "0x8B8C50", Offset = "0x8B7E50", VA = "0x1808B8C50")]
		public void UpdateProductVisuals(int quantity)
		{
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460E")]
		[Address(RVA = "0x8B8400", Offset = "0x8B7600", VA = "0x1808B8400", Slot = "136")]
		public virtual void StartTask()
		{
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600460F")]
		[Address(RVA = "0x8B8250", Offset = "0x8B7450", VA = "0x1808B8250", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004610")]
		[Address(RVA = "0x8B7F90", Offset = "0x8B7190", VA = "0x1808B7F90")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004611")]
		[Address(RVA = "0x8B7250", Offset = "0x8B6450", VA = "0x1808B7250", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004612")]
		[Address(RVA = "0x8B70A0", Offset = "0x8B62A0", VA = "0x1808B70A0")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004613")]
		[Address(RVA = "0x8B7DA0", Offset = "0x8B6FA0", VA = "0x1808B7DA0", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004614")]
		[Address(RVA = "0x8B7A80", Offset = "0x8B6C80", VA = "0x1808B7A80")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004615")]
		[Address(RVA = "0x8B78E0", Offset = "0x8B6AE0", VA = "0x1808B78E0", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004616")]
		[Address(RVA = "0x8B7620", Offset = "0x8B6820", VA = "0x1808B7620")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004617")]
		[Address(RVA = "0x8B2590", Offset = "0x8B1790", VA = "0x1808B2590", Slot = "128")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004618")]
		[Address(RVA = "0x8B27C0", Offset = "0x8B19C0", VA = "0x1808B27C0", Slot = "129")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004619")]
		[Address(RVA = "0x8B2AB0", Offset = "0x8B1CB0", VA = "0x1808B2AB0", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600461A")]
		[Address(RVA = "0x8B2BE0", Offset = "0x8B1DE0", VA = "0x1808B2BE0", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461B")]
		[Address(RVA = "0x8B9190", Offset = "0x8B8390", VA = "0x1808B9190")]
		public PackagingStation()
		{
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461C")]
		[Address(RVA = "0x8B35E0", Offset = "0x8B27E0", VA = "0x1808B35E0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461D")]
		[Address(RVA = "0x8B3550", Offset = "0x8B2750", VA = "0x1808B3550", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461E")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461F")]
		[Address(RVA = "0x8B5F80", Offset = "0x8B5180", VA = "0x1808B5F80")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004620")]
		[Address(RVA = "0x8B46E0", Offset = "0x8B38E0", VA = "0x1808B46E0", Slot = "137")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x8B51F0", Offset = "0x8B43F0", VA = "0x1808B51F0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004622")]
		[Address(RVA = "0x8B6360", Offset = "0x8B5560", VA = "0x1808B6360")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004623")]
		[Address(RVA = "0x8B48B0", Offset = "0x8B3AB0", VA = "0x1808B48B0", Slot = "138")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004624")]
		[Address(RVA = "0x8B53A0", Offset = "0x8B45A0", VA = "0x1808B53A0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004625")]
		[Address(RVA = "0x8B6230", Offset = "0x8B5430", VA = "0x1808B6230")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004626")]
		[Address(RVA = "0x8B4810", Offset = "0x8B3A10", VA = "0x1808B4810", Slot = "139")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004627")]
		[Address(RVA = "0x8B5320", Offset = "0x8B4520", VA = "0x1808B5320")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004628")]
		[Address(RVA = "0x8B6790", Offset = "0x8B5990", VA = "0x1808B6790")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004629")]
		[Address(RVA = "0x8B4E00", Offset = "0x8B4000", VA = "0x1808B4E00", Slot = "140")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462A")]
		[Address(RVA = "0x8B5660", Offset = "0x8B4860", VA = "0x1808B5660")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462B")]
		[Address(RVA = "0x8B5E00", Offset = "0x8B5000", VA = "0x1808B5E00")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462C")]
		[Address(RVA = "0x8B4E80", Offset = "0x8B4080", VA = "0x1808B4E80")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462D")]
		[Address(RVA = "0x8B5160", Offset = "0x8B4360", VA = "0x1808B5160")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462E")]
		[Address(RVA = "0x8B6C00", Offset = "0x8B5E00", VA = "0x1808B6C00")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600462F")]
		[Address(RVA = "0x8B58D0", Offset = "0x8B4AD0", VA = "0x1808B58D0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004630")]
		[Address(RVA = "0x8B60B0", Offset = "0x8B52B0", VA = "0x1808B60B0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004631")]
		[Address(RVA = "0x8B4780", Offset = "0x8B3980", VA = "0x1808B4780", Slot = "141")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004632")]
		[Address(RVA = "0x8B5270", Offset = "0x8B4470", VA = "0x1808B5270")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004633")]
		[Address(RVA = "0x8B5960", Offset = "0x8B4B60", VA = "0x1808B5960")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004634")]
		[Address(RVA = "0x8B4790", Offset = "0x8B3990", VA = "0x1808B4790")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004635")]
		[Address(RVA = "0x8B4F40", Offset = "0x8B4140", VA = "0x1808B4F40")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004636")]
		[Address(RVA = "0x8B6600", Offset = "0x8B5800", VA = "0x1808B6600")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004637")]
		[Address(RVA = "0x8B4CD0", Offset = "0x8B3ED0", VA = "0x1808B4CD0", Slot = "142")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004638")]
		[Address(RVA = "0x8B5510", Offset = "0x8B4710", VA = "0x1808B5510")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004639")]
		[Address(RVA = "0x8B6A70", Offset = "0x8B5C70", VA = "0x1808B6A70")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463A")]
		[Address(RVA = "0x8B4D50", Offset = "0x8B3F50", VA = "0x1808B4D50")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463B")]
		[Address(RVA = "0x8B57E0", Offset = "0x8B49E0", VA = "0x1808B57E0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463C")]
		[Address(RVA = "0x8B5C60", Offset = "0x8B4E60", VA = "0x1808B5C60")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463D")]
		[Address(RVA = "0x8B5070", Offset = "0x8B4270", VA = "0x1808B5070")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463E")]
		[Address(RVA = "0x8B6490", Offset = "0x8B5690", VA = "0x1808B6490")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600463F")]
		[Address(RVA = "0x8B4BD0", Offset = "0x8B3DD0", VA = "0x1808B4BD0", Slot = "143")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004640")]
		[Address(RVA = "0x8B5420", Offset = "0x8B4620", VA = "0x1808B5420")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004641")]
		[Address(RVA = "0x8B5AE0", Offset = "0x8B4CE0", VA = "0x1808B5AE0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004642")]
		[Address(RVA = "0x8B4C50", Offset = "0x8B3E50", VA = "0x1808B4C50")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004643")]
		[Address(RVA = "0x8B4FE0", Offset = "0x8B41E0", VA = "0x1808B4FE0")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004644")]
		[Address(RVA = "0x8B6900", Offset = "0x8B5B00", VA = "0x1808B6900")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004645")]
		[Address(RVA = "0x8B5750", Offset = "0x8B4950", VA = "0x1808B5750")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004647 RID: 17991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFA")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6004646")]
			[Address(RVA = "0x66B8C0", Offset = "0x66AAC0", VA = "0x18066B8C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004647")]
			[Address(RVA = "0x8B9480", Offset = "0x8B8680", VA = "0x1808B9480")]
			set
			{
			}
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x000133E0 File Offset: 0x000115E0
		[Token(Token = "0x6004648")]
		[Address(RVA = "0x8B4540", Offset = "0x8B3740", VA = "0x1808B4540", Slot = "144")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.PackagingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600464A RID: 17994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFB")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6004649")]
			[Address(RVA = "0x875FB0", Offset = "0x8751B0", VA = "0x180875FB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600464A")]
			[Address(RVA = "0x8B9540", Offset = "0x8B8740", VA = "0x1808B9540")]
			set
			{
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x0600464B RID: 17995 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600464C RID: 17996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFC")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x600464B")]
			[Address(RVA = "0x87F2B0", Offset = "0x87E4B0", VA = "0x18087F2B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600464C")]
			[Address(RVA = "0x8B93C0", Offset = "0x8B85C0", VA = "0x1808B93C0")]
			set
			{
			}
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600464D")]
		[Address(RVA = "0x8B1920", Offset = "0x8B0B20", VA = "0x1808B1920", Slot = "145")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.PackagingStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040031CF RID: 12751
		[Token(Token = "0x40031CF")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public Light OverheadLight;

		// Token: 0x040031D0 RID: 12752
		[Token(Token = "0x40031D0")]
		[FieldOffset(Offset = "0x220")]
		public MeshRenderer OverheadLightMeshRend;

		// Token: 0x040031D1 RID: 12753
		[Token(Token = "0x40031D1")]
		[FieldOffset(Offset = "0x228")]
		public RockerSwitch Switch;

		// Token: 0x040031D2 RID: 12754
		[Token(Token = "0x40031D2")]
		[FieldOffset(Offset = "0x230")]
		public Transform CameraPosition;

		// Token: 0x040031D3 RID: 12755
		[Token(Token = "0x40031D3")]
		[FieldOffset(Offset = "0x238")]
		public Transform CameraPosition_Task;

		// Token: 0x040031D4 RID: 12756
		[Token(Token = "0x40031D4")]
		[FieldOffset(Offset = "0x240")]
		public InteractableObject IntObj;

		// Token: 0x040031D5 RID: 12757
		[Token(Token = "0x40031D5")]
		[FieldOffset(Offset = "0x248")]
		public Transform ActivePackagingAlignent;

		// Token: 0x040031D6 RID: 12758
		[Token(Token = "0x40031D6")]
		[FieldOffset(Offset = "0x250")]
		public Transform[] ActiveProductAlignments;

		// Token: 0x040031D7 RID: 12759
		[Token(Token = "0x40031D7")]
		[FieldOffset(Offset = "0x258")]
		public Transform Container;

		// Token: 0x040031D8 RID: 12760
		[Token(Token = "0x40031D8")]
		[FieldOffset(Offset = "0x260")]
		public Collider OutputCollider;

		// Token: 0x040031D9 RID: 12761
		[Token(Token = "0x40031D9")]
		[FieldOffset(Offset = "0x268")]
		public Transform Hatch;

		// Token: 0x040031DA RID: 12762
		[Token(Token = "0x40031DA")]
		[FieldOffset(Offset = "0x270")]
		public Transform[] PackagingAlignments;

		// Token: 0x040031DB RID: 12763
		[Token(Token = "0x40031DB")]
		[FieldOffset(Offset = "0x278")]
		public Transform[] ProductAlignments;

		// Token: 0x040031DC RID: 12764
		[Token(Token = "0x40031DC")]
		[FieldOffset(Offset = "0x280")]
		public Transform uiPoint;

		// Token: 0x040031DD RID: 12765
		[Token(Token = "0x40031DD")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x040031DE RID: 12766
		[Token(Token = "0x40031DE")]
		[FieldOffset(Offset = "0x290")]
		public Transform StandPoint;

		// Token: 0x040031DF RID: 12767
		[Token(Token = "0x40031DF")]
		[FieldOffset(Offset = "0x298")]
		public Transform[] accessPoints;

		// Token: 0x040031E0 RID: 12768
		[Token(Token = "0x40031E0")]
		[FieldOffset(Offset = "0x2A0")]
		public AudioSourceController HatchOpenSound;

		// Token: 0x040031E1 RID: 12769
		[Token(Token = "0x40031E1")]
		[FieldOffset(Offset = "0x2A8")]
		public AudioSourceController HatchCloseSound;

		// Token: 0x040031E2 RID: 12770
		[Token(Token = "0x40031E2")]
		[FieldOffset(Offset = "0x2B0")]
		[Header("UI")]
		public PackagingStationUIElement WorldspaceUIPrefab;

		// Token: 0x040031E3 RID: 12771
		[Token(Token = "0x40031E3")]
		[FieldOffset(Offset = "0x2B8")]
		public Sprite typeIcon;

		// Token: 0x040031E4 RID: 12772
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x2C0")]
		[Header("Slot Display Points")]
		public Transform PackagingSlotPosition;

		// Token: 0x040031E5 RID: 12773
		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x2C8")]
		public Transform ProductSlotPosition;

		// Token: 0x040031E6 RID: 12774
		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x2D0")]
		public Transform OutputSlotPosition;

		// Token: 0x040031E7 RID: 12775
		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x2D8")]
		[Header("Materials")]
		public Material LightMeshOnMat;

		// Token: 0x040031E8 RID: 12776
		[Token(Token = "0x40031E8")]
		[FieldOffset(Offset = "0x2E0")]
		public Material LightMeshOffMat;

		// Token: 0x040031E9 RID: 12777
		[Token(Token = "0x40031E9")]
		[FieldOffset(Offset = "0x2E8")]
		[Header("Settings")]
		public float PackagerEmployeeSpeedMultiplier;

		// Token: 0x040031EA RID: 12778
		[Token(Token = "0x40031EA")]
		[FieldOffset(Offset = "0x2EC")]
		public Vector3 HatchClosedRotation;

		// Token: 0x040031EB RID: 12779
		[Token(Token = "0x40031EB")]
		[FieldOffset(Offset = "0x2F8")]
		public Vector3 HatchOpenRotation;

		// Token: 0x040031EC RID: 12780
		[Token(Token = "0x40031EC")]
		[FieldOffset(Offset = "0x304")]
		public float HatchLerpTime;

		// Token: 0x040031EF RID: 12783
		[Token(Token = "0x40031EF")]
		[FieldOffset(Offset = "0x318")]
		public ItemSlot PackagingSlot;

		// Token: 0x040031F0 RID: 12784
		[Token(Token = "0x40031F0")]
		[FieldOffset(Offset = "0x320")]
		public ItemSlot ProductSlot;

		// Token: 0x040031F1 RID: 12785
		[Token(Token = "0x40031F1")]
		[FieldOffset(Offset = "0x328")]
		public ItemSlot OutputSlot;

		// Token: 0x040031F2 RID: 12786
		[Token(Token = "0x40031F2")]
		[FieldOffset(Offset = "0x330")]
		private bool hatchOpen;

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		[FieldOffset(Offset = "0x338")]
		private Coroutine hatchRoutine;

		// Token: 0x040031F4 RID: 12788
		[Token(Token = "0x40031F4")]
		[FieldOffset(Offset = "0x340")]
		private List<string> PackagingSlotModelID;

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		[FieldOffset(Offset = "0x348")]
		private List<string> ProductSlotModelID;

		// Token: 0x040031FD RID: 12797
		[Token(Token = "0x40031FD")]
		[FieldOffset(Offset = "0x380")]
		private bool visualsLocked;

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		[FieldOffset(Offset = "0x388")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x040031FF RID: 12799
		[Token(Token = "0x40031FF")]
		[FieldOffset(Offset = "0x390")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003200 RID: 12800
		[Token(Token = "0x4003200")]
		[FieldOffset(Offset = "0x398")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003201 RID: 12801
		[Token(Token = "0x4003201")]
		[FieldOffset(Offset = "0x3A0")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x04003202 RID: 12802
		[Token(Token = "0x4003202")]
		[FieldOffset(Offset = "0x3A1")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x020009B5 RID: 2485
		[Token(Token = "0x20009B5")]
		public enum EMode
		{
			// Token: 0x04003204 RID: 12804
			[Token(Token = "0x4003204")]
			Package,
			// Token: 0x04003205 RID: 12805
			[Token(Token = "0x4003205")]
			Unpackage
		}

		// Token: 0x020009B6 RID: 2486
		[Token(Token = "0x20009B6")]
		public enum EState
		{
			// Token: 0x04003207 RID: 12807
			[Token(Token = "0x4003207")]
			CanBegin,
			// Token: 0x04003208 RID: 12808
			[Token(Token = "0x4003208")]
			MissingItems,
			// Token: 0x04003209 RID: 12809
			[Token(Token = "0x4003209")]
			InsufficentProduct,
			// Token: 0x0400320A RID: 12810
			[Token(Token = "0x400320A")]
			OutputSlotFull,
			// Token: 0x0400320B RID: 12811
			[Token(Token = "0x400320B")]
			Mismatch,
			// Token: 0x0400320C RID: 12812
			[Token(Token = "0x400320C")]
			PackageSlotFull,
			// Token: 0x0400320D RID: 12813
			[Token(Token = "0x400320D")]
			ProductSlotFull
		}
	}
}
