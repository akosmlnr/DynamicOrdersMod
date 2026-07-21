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
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Misc;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000997 RID: 2455
	[Token(Token = "0x2000997")]
	public class ChemistryStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x17000A5F")]
		public bool isOpen
		{
			[Token(Token = "0x600429E")]
			[Address(RVA = "0x88BBD0", Offset = "0x88ADD0", VA = "0x18088BBD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600429F RID: 17055 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042A0 RID: 17056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A60")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x600429F")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042A0")]
			[Address(RVA = "0x876080", Offset = "0x875280", VA = "0x180876080", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042A2 RID: 17058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A61")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x60042A1")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042A2")]
			[Address(RVA = "0x887760", Offset = "0x886960", VA = "0x180887760", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042A4 RID: 17060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A62")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60042A3")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042A4")]
			[Address(RVA = "0x887800", Offset = "0x886A00", VA = "0x180887800", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042A6 RID: 17062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A63")]
		public ChemistryCookOperation CurrentCookOperation
		{
			[Token(Token = "0x60042A5")]
			[Address(RVA = "0x5A44C0", Offset = "0x5A36C0", VA = "0x1805A44C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042A6")]
			[Address(RVA = "0x5A4580", Offset = "0x5A3780", VA = "0x1805A4580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060042A7 RID: 17063 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A64")]
		public string Name
		{
			[Token(Token = "0x60042A7")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042A9 RID: 17065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A65")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60042A8")]
			[Address(RVA = "0x875F80", Offset = "0x875180", VA = "0x180875F80", Slot = "93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042A9")]
			[Address(RVA = "0x88BC80", Offset = "0x88AE80", VA = "0x18088BC80", Slot = "94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042AB RID: 17067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A66")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x60042AA")]
			[Address(RVA = "0x88BBC0", Offset = "0x88ADC0", VA = "0x18088BBC0", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042AB")]
			[Address(RVA = "0x88BCB0", Offset = "0x88AEB0", VA = "0x18088BCB0", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A67")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x60042AC")]
			[Address(RVA = "0x803600", Offset = "0x802800", VA = "0x180803600", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A68")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x8035E0", Offset = "0x8027E0", VA = "0x1808035E0", Slot = "98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x00012B88 File Offset: 0x00010D88
		[Token(Token = "0x17000A69")]
		public bool Selectable
		{
			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x72EFB0", Offset = "0x72E1B0", VA = "0x18072EFB0", Slot = "99")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x00012BA0 File Offset: 0x00010DA0
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A6A")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x60042AF")]
			[Address(RVA = "0x88BBB0", Offset = "0x88ADB0", VA = "0x18088BBB0", Slot = "100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60042B0")]
			[Address(RVA = "0x88BCA0", Offset = "0x88AEA0", VA = "0x18088BCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060042B1 RID: 17073 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A6B")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60042B1")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00", Slot = "114")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060042B2 RID: 17074 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042B3 RID: 17075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A6C")]
		protected ChemistryStationConfiguration stationConfiguration
		{
			[Token(Token = "0x60042B2")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B3")]
			[Address(RVA = "0x700530", Offset = "0x6FF730", VA = "0x180700530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060042B4 RID: 17076 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A6D")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x60042B4")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0", Slot = "115")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x00012BB8 File Offset: 0x00010DB8
		[Token(Token = "0x17000A6E")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x60042B5")]
			[Address(RVA = "0x570DE0", Offset = "0x56FFE0", VA = "0x180570DE0", Slot = "116")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060042B6 RID: 17078 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042B7 RID: 17079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A6F")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x60042B6")]
			[Address(RVA = "0x72EFC0", Offset = "0x72E1C0", VA = "0x18072EFC0", Slot = "117")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B7")]
			[Address(RVA = "0x72F0E0", Offset = "0x72E2E0", VA = "0x18072F0E0", Slot = "118")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060042B9 RID: 17081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A70")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x60042B8")]
			[Address(RVA = "0x72EF90", Offset = "0x72E190", VA = "0x18072EF90", Slot = "119")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B9")]
			[Address(RVA = "0x887490", Offset = "0x886690", VA = "0x180887490", Slot = "120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x88A200", Offset = "0x889400", VA = "0x18088A200", Slot = "134")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060042BB RID: 17083 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A71")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x60042BB")]
			[Address(RVA = "0x875FB0", Offset = "0x8751B0", VA = "0x180875FB0", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060042BC RID: 17084 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A72")]
		public Transform Transform
		{
			[Token(Token = "0x60042BC")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A73")]
		public Transform UIPoint
		{
			[Token(Token = "0x60042BD")]
			[Address(RVA = "0x803600", Offset = "0x802800", VA = "0x180803600", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x00012BD0 File Offset: 0x00010DD0
		[Token(Token = "0x17000A74")]
		public bool CanBeSelected
		{
			[Token(Token = "0x60042BE")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042BF")]
		[Address(RVA = "0x883EC0", Offset = "0x8830C0", VA = "0x180883EC0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C0")]
		[Address(RVA = "0x885980", Offset = "0x884B80", VA = "0x180885980", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60042C1")]
		[Address(RVA = "0x885730", Offset = "0x884930", VA = "0x180885730", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C2")]
		[Address(RVA = "0x886570", Offset = "0x885770", VA = "0x180886570", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C3")]
		[Address(RVA = "0x889F70", Offset = "0x889170", VA = "0x180889F70", Slot = "135")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x00012BE8 File Offset: 0x00010DE8
		[Token(Token = "0x60042C4")]
		[Address(RVA = "0x883F10", Offset = "0x883110", VA = "0x180883F10", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C5")]
		[Address(RVA = "0x884DA0", Offset = "0x883FA0", VA = "0x180884DA0", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x886560", Offset = "0x885760", VA = "0x180886560", Slot = "136")]
		protected virtual void OnMinPass()
		{
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x8868E0", Offset = "0x885AE0", VA = "0x1808868E0")]
		private void OnTimePass(int minutes)
		{
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C8")]
		[Address(RVA = "0x88B8F0", Offset = "0x88AAF0", VA = "0x18088B8F0")]
		private void UpdateClock()
		{
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C9")]
		[Address(RVA = "0x88BA40", Offset = "0x88AC40", VA = "0x18088BA40", Slot = "137")]
		protected virtual void Update()
		{
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60042CA")]
		[Address(RVA = "0x884360", Offset = "0x883560", VA = "0x180884360")]
		public Beaker CreateBeaker()
		{
			return null;
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60042CB")]
		[Address(RVA = "0x8844D0", Offset = "0x8836D0", VA = "0x1808844D0")]
		public StirringRod CreateStirringRod()
		{
			return null;
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CC")]
		[Address(RVA = "0x88A0D0", Offset = "0x8892D0", VA = "0x18088A0D0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCookOperation(ChemistryCookOperation op)
		{
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x88A330", Offset = "0x889530", VA = "0x18088A330")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetCookOperation(NetworkConnection conn, ChemistryCookOperation operation)
		{
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x885230", Offset = "0x884430", VA = "0x180885230")]
		[ObserversRpc]
		private void FinalizeOperation()
		{
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CF")]
		[Address(RVA = "0x887180", Offset = "0x886380", VA = "0x180887180")]
		public void ResetStation()
		{
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x00012C00 File Offset: 0x00010E00
		[Token(Token = "0x60042D0")]
		[Address(RVA = "0x8850D0", Offset = "0x8842D0", VA = "0x1808850D0")]
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60042D1")]
		[Address(RVA = "0x885650", Offset = "0x884850", VA = "0x180885650")]
		public List<ItemInstance> GetIngredients()
		{
			return null;
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x00012C18 File Offset: 0x00010E18
		[Token(Token = "0x60042D2")]
		[Address(RVA = "0x885810", Offset = "0x884A10", VA = "0x180885810")]
		public bool HasIngredientsForRecipe(StationRecipe recipe)
		{
			return default(bool);
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D3")]
		[Address(RVA = "0x884650", Offset = "0x883850", VA = "0x180884650")]
		public void CreateTrash(List<StationItem> mixerItems)
		{
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D4")]
		[Address(RVA = "0x885840", Offset = "0x884A40", VA = "0x180885840")]
		public void Hovered()
		{
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D5")]
		[Address(RVA = "0x885CC0", Offset = "0x884EC0", VA = "0x180885CC0")]
		public void Interacted()
		{
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D6")]
		[Address(RVA = "0x885140", Offset = "0x884340", VA = "0x180885140")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x886BF0", Offset = "0x885DF0", VA = "0x180886BF0")]
		public void Open()
		{
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D8")]
		[Address(RVA = "0x884010", Offset = "0x883210", VA = "0x180884010")]
		public void Close()
		{
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D9")]
		[Address(RVA = "0x88A9E0", Offset = "0x889BE0", VA = "0x18088A9E0", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DA")]
		[Address(RVA = "0x88A8B0", Offset = "0x889AB0", VA = "0x18088A8B0", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DB")]
		[Address(RVA = "0x88B740", Offset = "0x88A940", VA = "0x18088B740", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DC")]
		[Address(RVA = "0x88B480", Offset = "0x88A680", VA = "0x18088B480")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DD")]
		[Address(RVA = "0x88A740", Offset = "0x889940", VA = "0x18088A740", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DE")]
		[Address(RVA = "0x88A590", Offset = "0x889790", VA = "0x18088A590")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DF")]
		[Address(RVA = "0x88B290", Offset = "0x88A490", VA = "0x18088B290", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E0")]
		[Address(RVA = "0x88AF70", Offset = "0x88A170", VA = "0x18088AF70")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E1")]
		[Address(RVA = "0x88ADD0", Offset = "0x889FD0", VA = "0x18088ADD0", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E2")]
		[Address(RVA = "0x88AB10", Offset = "0x889D10", VA = "0x18088AB10")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60042E3")]
		[Address(RVA = "0x884AF0", Offset = "0x883CF0", VA = "0x180884AF0", Slot = "128")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E4")]
		[Address(RVA = "0x884D10", Offset = "0x883F10", VA = "0x180884D10", Slot = "129")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60042E5")]
		[Address(RVA = "0x885350", Offset = "0x884550", VA = "0x180885350", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60042E6")]
		[Address(RVA = "0x885760", Offset = "0x884960", VA = "0x180885760", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E7")]
		[Address(RVA = "0x88BAC0", Offset = "0x88ACC0", VA = "0x18088BAC0")]
		public ChemistryStation()
		{
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x885E00", Offset = "0x885000", VA = "0x180885E00", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EB")]
		[Address(RVA = "0x885D70", Offset = "0x884F70", VA = "0x180885D70", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042ED")]
		[Address(RVA = "0x889020", Offset = "0x888220", VA = "0x180889020")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EE")]
		[Address(RVA = "0x887490", Offset = "0x886690", VA = "0x180887490", Slot = "138")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x887FC0", Offset = "0x8871C0", VA = "0x180887FC0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F0")]
		[Address(RVA = "0x888EF0", Offset = "0x8880F0", VA = "0x180888EF0")]
		private void RpcWriter___Server_SendCookOperation_3552222198(ChemistryCookOperation op)
		{
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x887480", Offset = "0x886680", VA = "0x180887480")]
		public void RpcLogic___SendCookOperation_3552222198(ChemistryCookOperation op)
		{
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F2")]
		[Address(RVA = "0x887F50", Offset = "0x887150", VA = "0x180887F50")]
		private void RpcReader___Server_SendCookOperation_3552222198(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x888790", Offset = "0x887990", VA = "0x180888790")]
		private void RpcWriter___Observers_SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
		{
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F4")]
		[Address(RVA = "0x887530", Offset = "0x886730", VA = "0x180887530")]
		public void RpcLogic___SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
		{
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F5")]
		[Address(RVA = "0x887C40", Offset = "0x886E40", VA = "0x180887C40")]
		private void RpcReader___Observers_SetCookOperation_1024887225(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F6")]
		[Address(RVA = "0x8899A0", Offset = "0x888BA0", VA = "0x1808899A0")]
		private void RpcWriter___Target_SetCookOperation_1024887225(NetworkConnection conn, ChemistryCookOperation operation)
		{
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F7")]
		[Address(RVA = "0x888520", Offset = "0x887720", VA = "0x180888520")]
		private void RpcReader___Target_SetCookOperation_1024887225(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F8")]
		[Address(RVA = "0x885230", Offset = "0x884430", VA = "0x180885230")]
		private void RpcWriter___Observers_FinalizeOperation_2166136261()
		{
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F9")]
		[Address(RVA = "0x887230", Offset = "0x886430", VA = "0x180887230")]
		private void RpcLogic___FinalizeOperation_2166136261()
		{
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FA")]
		[Address(RVA = "0x887C10", Offset = "0x886E10", VA = "0x180887C10")]
		private void RpcReader___Observers_FinalizeOperation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FB")]
		[Address(RVA = "0x889400", Offset = "0x888600", VA = "0x180889400")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x887800", Offset = "0x886A00", VA = "0x180887800", Slot = "139")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x888170", Offset = "0x887370", VA = "0x180888170")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x8892D0", Offset = "0x8884D0", VA = "0x1808892D0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FF")]
		[Address(RVA = "0x887760", Offset = "0x886960", VA = "0x180887760", Slot = "140")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004300")]
		[Address(RVA = "0x8880F0", Offset = "0x8872F0", VA = "0x1808880F0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004301")]
		[Address(RVA = "0x889830", Offset = "0x888A30", VA = "0x180889830")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004302")]
		[Address(RVA = "0x887AD0", Offset = "0x886CD0", VA = "0x180887AD0", Slot = "141")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004303")]
		[Address(RVA = "0x888430", Offset = "0x887630", VA = "0x180888430")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004304")]
		[Address(RVA = "0x888D70", Offset = "0x887F70", VA = "0x180888D70")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004305")]
		[Address(RVA = "0x887B50", Offset = "0x886D50", VA = "0x180887B50")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004306")]
		[Address(RVA = "0x887EC0", Offset = "0x8870C0", VA = "0x180887EC0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004307")]
		[Address(RVA = "0x889E00", Offset = "0x889000", VA = "0x180889E00")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004308")]
		[Address(RVA = "0x888700", Offset = "0x887900", VA = "0x180888700")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004309")]
		[Address(RVA = "0x889150", Offset = "0x888350", VA = "0x180889150")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430A")]
		[Address(RVA = "0x8876D0", Offset = "0x8868D0", VA = "0x1808876D0", Slot = "142")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430B")]
		[Address(RVA = "0x888040", Offset = "0x887240", VA = "0x180888040")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430C")]
		[Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430D")]
		[Address(RVA = "0x8876E0", Offset = "0x8868E0", VA = "0x1808876E0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430E")]
		[Address(RVA = "0x887CA0", Offset = "0x886EA0", VA = "0x180887CA0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430F")]
		[Address(RVA = "0x8896A0", Offset = "0x8888A0", VA = "0x1808896A0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004310")]
		[Address(RVA = "0x8879A0", Offset = "0x886BA0", VA = "0x1808879A0", Slot = "143")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004311")]
		[Address(RVA = "0x8882E0", Offset = "0x8874E0", VA = "0x1808882E0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004312")]
		[Address(RVA = "0x889C70", Offset = "0x888E70", VA = "0x180889C70")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004313")]
		[Address(RVA = "0x887A20", Offset = "0x886C20", VA = "0x180887A20")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004314")]
		[Address(RVA = "0x888610", Offset = "0x887810", VA = "0x180888610")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004315")]
		[Address(RVA = "0x888BD0", Offset = "0x887DD0", VA = "0x180888BD0")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004316")]
		[Address(RVA = "0x887DD0", Offset = "0x886FD0", VA = "0x180887DD0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004317")]
		[Address(RVA = "0x889530", Offset = "0x888730", VA = "0x180889530")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004318")]
		[Address(RVA = "0x8878A0", Offset = "0x886AA0", VA = "0x1808878A0", Slot = "144")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004319")]
		[Address(RVA = "0x8881F0", Offset = "0x8873F0", VA = "0x1808881F0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431A")]
		[Address(RVA = "0x888A50", Offset = "0x887C50", VA = "0x180888A50")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431B")]
		[Address(RVA = "0x887920", Offset = "0x886B20", VA = "0x180887920")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431C")]
		[Address(RVA = "0x887D40", Offset = "0x886F40", VA = "0x180887D40")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431D")]
		[Address(RVA = "0x889B00", Offset = "0x888D00", VA = "0x180889B00")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431E")]
		[Address(RVA = "0x888580", Offset = "0x887780", VA = "0x180888580")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600431F RID: 17183 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004320 RID: 17184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A75")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x600431F")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004320")]
			[Address(RVA = "0x88BD90", Offset = "0x88AF90", VA = "0x18088BD90")]
			set
			{
			}
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x00012C30 File Offset: 0x00010E30
		[Token(Token = "0x6004321")]
		[Address(RVA = "0x886FE0", Offset = "0x8861E0", VA = "0x180886FE0", Slot = "145")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.ChemistryStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004323 RID: 17187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A76")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6004322")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004323")]
			[Address(RVA = "0x88BE50", Offset = "0x88B050", VA = "0x18088BE50")]
			set
			{
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A77")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6004324")]
			[Address(RVA = "0x72EF90", Offset = "0x72E190", VA = "0x18072EF90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004325")]
			[Address(RVA = "0x88BCD0", Offset = "0x88AED0", VA = "0x18088BCD0")]
			set
			{
			}
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004326")]
		[Address(RVA = "0x883A40", Offset = "0x882C40", VA = "0x180883A40", Slot = "146")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.ChemistryStation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003040 RID: 12352
		[Token(Token = "0x4003040")]
		public const float FOV_OVERRIDE = 65f;

		// Token: 0x04003041 RID: 12353
		[Token(Token = "0x4003041")]
		public const int INPUT_SLOT_COUNT = 3;

		// Token: 0x04003046 RID: 12358
		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0x230")]
		public ItemSlot[] IngredientSlots;

		// Token: 0x04003047 RID: 12359
		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x238")]
		public ItemSlot OutputSlot;

		// Token: 0x04003048 RID: 12360
		[Token(Token = "0x4003048")]
		[FieldOffset(Offset = "0x240")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04003049 RID: 12361
		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0x248")]
		public Transform CameraPosition_Default;

		// Token: 0x0400304A RID: 12362
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x250")]
		public Transform CameraPosition_Stirring;

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x258")]
		public Transform StaticBeaker;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x260")]
		public Transform StaticFunnel;

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x268")]
		public Transform StaticStirringRod;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x270")]
		public Transform ItemContainer;

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x278")]
		public LabStand LabStand;

		// Token: 0x04003050 RID: 12368
		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0x280")]
		public StorageVisualizer InputVisuals;

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x288")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x290")]
		public Rigidbody AnchorRb;

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x298")]
		public BunsenBurner Burner;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x2A0")]
		public BoilingFlask BoilingFlask;

		// Token: 0x04003055 RID: 12373
		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0x2A8")]
		public DigitalAlarm Alarm;

		// Token: 0x04003056 RID: 12374
		[Token(Token = "0x4003056")]
		[FieldOffset(Offset = "0x2B0")]
		public Transform uiPoint;

		// Token: 0x04003057 RID: 12375
		[Token(Token = "0x4003057")]
		[FieldOffset(Offset = "0x2B8")]
		public Transform[] accessPoints;

		// Token: 0x04003058 RID: 12376
		[Token(Token = "0x4003058")]
		[FieldOffset(Offset = "0x2C0")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x04003059 RID: 12377
		[Token(Token = "0x4003059")]
		[FieldOffset(Offset = "0x2C8")]
		public BoxCollider TrashSpawnVolume;

		// Token: 0x0400305A RID: 12378
		[Token(Token = "0x400305A")]
		[FieldOffset(Offset = "0x2D0")]
		public Transform ExplosionPoint;

		// Token: 0x0400305B RID: 12379
		[Token(Token = "0x400305B")]
		[FieldOffset(Offset = "0x2D8")]
		[Header("Slot Display Points")]
		public Transform InputSlotsPosition;

		// Token: 0x0400305C RID: 12380
		[Token(Token = "0x400305C")]
		[FieldOffset(Offset = "0x2E0")]
		public Transform OutputSlotPosition;

		// Token: 0x0400305D RID: 12381
		[Token(Token = "0x400305D")]
		[FieldOffset(Offset = "0x2E8")]
		[Header("Transforms")]
		public Transform[] IngredientTransforms;

		// Token: 0x0400305E RID: 12382
		[Token(Token = "0x400305E")]
		[FieldOffset(Offset = "0x2F0")]
		public Transform BeakerAlignmentTransform;

		// Token: 0x0400305F RID: 12383
		[Token(Token = "0x400305F")]
		[FieldOffset(Offset = "0x2F8")]
		[Header("Prefabs")]
		public GameObject BeakerPrefab;

		// Token: 0x04003060 RID: 12384
		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x300")]
		public StirringRod StirringRodPrefab;

		// Token: 0x04003061 RID: 12385
		[Token(Token = "0x4003061")]
		[FieldOffset(Offset = "0x308")]
		[Header("UI")]
		public ChemistryStationUIElement WorldspaceUIPrefab;

		// Token: 0x04003062 RID: 12386
		[Token(Token = "0x4003062")]
		[FieldOffset(Offset = "0x310")]
		public Sprite typeIcon;

		// Token: 0x0400306A RID: 12394
		[Token(Token = "0x400306A")]
		[FieldOffset(Offset = "0x348")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x0400306B RID: 12395
		[Token(Token = "0x400306B")]
		[FieldOffset(Offset = "0x350")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x0400306C RID: 12396
		[Token(Token = "0x400306C")]
		[FieldOffset(Offset = "0x358")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x0400306D RID: 12397
		[Token(Token = "0x400306D")]
		[FieldOffset(Offset = "0x360")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted;

		// Token: 0x0400306E RID: 12398
		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x361")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.ChemistryStationAssembly-CSharp.dll_Excuted;

		// Token: 0x02000998 RID: 2456
		[Token(Token = "0x2000998")]
		public enum EStep
		{
			// Token: 0x04003070 RID: 12400
			[Token(Token = "0x4003070")]
			CombineIngredients,
			// Token: 0x04003071 RID: 12401
			[Token(Token = "0x4003071")]
			Stir,
			// Token: 0x04003072 RID: 12402
			[Token(Token = "0x4003072")]
			LowerBoilingFlask,
			// Token: 0x04003073 RID: 12403
			[Token(Token = "0x4003073")]
			PourIntoBoilingFlask,
			// Token: 0x04003074 RID: 12404
			[Token(Token = "0x4003074")]
			RaiseBoilingFlask,
			// Token: 0x04003075 RID: 12405
			[Token(Token = "0x4003075")]
			StartHeat,
			// Token: 0x04003076 RID: 12406
			[Token(Token = "0x4003076")]
			Cook,
			// Token: 0x04003077 RID: 12407
			[Token(Token = "0x4003077")]
			LowerBoilingFlaskAgain,
			// Token: 0x04003078 RID: 12408
			[Token(Token = "0x4003078")]
			PourThroughFilter
		}
	}
}
