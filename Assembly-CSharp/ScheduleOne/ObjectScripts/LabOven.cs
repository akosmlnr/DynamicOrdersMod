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
using TMPro;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009A3 RID: 2467
	[Token(Token = "0x20009A3")]
	public class LabOven : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x17000A9B")]
		public bool isOpen
		{
			[Token(Token = "0x60043F4")]
			[Address(RVA = "0x89E510", Offset = "0x89D710", VA = "0x18089E510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A9C")]
		public OvenCookOperation CurrentOperation
		{
			[Token(Token = "0x60043F5")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043F6")]
			[Address(RVA = "0x876080", Offset = "0x875280", VA = "0x180876080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060043F8 RID: 17400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A9D")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60043F7")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043F8")]
			[Address(RVA = "0x89E640", Offset = "0x89D840", VA = "0x18089E640", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A9E")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x60043F9")]
			[Address(RVA = "0x89E4E0", Offset = "0x89D6E0", VA = "0x18089E4E0", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043FA")]
			[Address(RVA = "0x899630", Offset = "0x898830", VA = "0x180899630", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060043FC RID: 17404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A9F")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60043FB")]
			[Address(RVA = "0x89E500", Offset = "0x89D700", VA = "0x18089E500", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043FC")]
			[Address(RVA = "0x8996D0", Offset = "0x8988D0", VA = "0x1808996D0", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AA0")]
		public string Name
		{
			[Token(Token = "0x60043FD")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060043FF RID: 17407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA1")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60043FE")]
			[Address(RVA = "0x89E4D0", Offset = "0x89D6D0", VA = "0x18089E4D0", Slot = "93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043FF")]
			[Address(RVA = "0x89E620", Offset = "0x89D820", VA = "0x18089E620", Slot = "94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004401 RID: 17409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA2")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6004400")]
			[Address(RVA = "0x89E4F0", Offset = "0x89D6F0", VA = "0x18089E4F0", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004401")]
			[Address(RVA = "0x89E660", Offset = "0x89D860", VA = "0x18089E660", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06004402 RID: 17410 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AA3")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x6004402")]
			[Address(RVA = "0x875FB0", Offset = "0x8751B0", VA = "0x180875FB0", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AA4")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x6004403")]
			[Address(RVA = "0x875F80", Offset = "0x875180", VA = "0x180875F80", Slot = "98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x17000AA5")]
		public bool Selectable
		{
			[Token(Token = "0x6004404")]
			[Address(RVA = "0x66BBA0", Offset = "0x66ADA0", VA = "0x18066BBA0", Slot = "99")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x00012EE8 File Offset: 0x000110E8
		// (set) Token: 0x06004406 RID: 17414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA6")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6004405")]
			[Address(RVA = "0x66BB80", Offset = "0x66AD80", VA = "0x18066BB80", Slot = "100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004406")]
			[Address(RVA = "0x66C220", Offset = "0x66B420", VA = "0x18066C220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AA7")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6004407")]
			[Address(RVA = "0x89E4C0", Offset = "0x89D6C0", VA = "0x18089E4C0", Slot = "114")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004409 RID: 17417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA8")]
		protected LabOvenConfiguration ovenConfiguration
		{
			[Token(Token = "0x6004408")]
			[Address(RVA = "0x89E4C0", Offset = "0x89D6C0", VA = "0x18089E4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004409")]
			[Address(RVA = "0x89E6A0", Offset = "0x89D8A0", VA = "0x18089E6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AA9")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x600440A")]
			[Address(RVA = "0x88BBC0", Offset = "0x88ADC0", VA = "0x18088BBC0", Slot = "115")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x17000AAA")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x600440B")]
			[Address(RVA = "0x56E800", Offset = "0x56DA00", VA = "0x18056E800", Slot = "116")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600440D RID: 17421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AAB")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x600440C")]
			[Address(RVA = "0x6F2D10", Offset = "0x6F1F10", VA = "0x1806F2D10", Slot = "117")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600440D")]
			[Address(RVA = "0x89E680", Offset = "0x89D880", VA = "0x18089E680", Slot = "118")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600440F RID: 17423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AAC")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x600440E")]
			[Address(RVA = "0x6F2CD0", Offset = "0x6F1ED0", VA = "0x1806F2CD0", Slot = "119")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600440F")]
			[Address(RVA = "0x899320", Offset = "0x898520", VA = "0x180899320", Slot = "120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004410")]
		[Address(RVA = "0x89C130", Offset = "0x89B330", VA = "0x18089C130", Slot = "134")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AAD")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6004411")]
			[Address(RVA = "0x87F2A0", Offset = "0x87E4A0", VA = "0x18087F2A0", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06004412 RID: 17426 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AAE")]
		public Transform Transform
		{
			[Token(Token = "0x6004412")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000AAF")]
		public Transform UIPoint
		{
			[Token(Token = "0x6004413")]
			[Address(RVA = "0x875FB0", Offset = "0x8751B0", VA = "0x180875FB0", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06004414 RID: 17428 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x17000AB0")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6004414")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004415")]
		[Address(RVA = "0x895CD0", Offset = "0x894ED0", VA = "0x180895CD0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004416")]
		[Address(RVA = "0x897A00", Offset = "0x896C00", VA = "0x180897A00", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004417")]
		[Address(RVA = "0x8977E0", Offset = "0x8969E0", VA = "0x1808977E0", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004418")]
		[Address(RVA = "0x898820", Offset = "0x897A20", VA = "0x180898820", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004419")]
		[Address(RVA = "0x89BEE0", Offset = "0x89B0E0", VA = "0x18089BEE0", Slot = "135")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600441A")]
		[Address(RVA = "0x89E160", Offset = "0x89D360", VA = "0x18089E160")]
		private void Update()
		{
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600441B")]
		[Address(RVA = "0x898AC0", Offset = "0x897CC0", VA = "0x180898AC0")]
		private void OnUncappedMinPass()
		{
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600441C")]
		[Address(RVA = "0x8989A0", Offset = "0x897BA0", VA = "0x1808989A0")]
		private void OnTimePass(int minutes)
		{
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600441D")]
		[Address(RVA = "0x89DF00", Offset = "0x89D100", VA = "0x18089DF00")]
		private void UpdateOvenAppearance()
		{
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600441E")]
		[Address(RVA = "0x897370", Offset = "0x896570", VA = "0x180897370")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x600441F")]
		[Address(RVA = "0x895D20", Offset = "0x894F20", VA = "0x180895D20", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004420")]
		[Address(RVA = "0x897030", Offset = "0x896230", VA = "0x180897030", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004421")]
		[Address(RVA = "0x89C9A0", Offset = "0x89BBA0", VA = "0x18089C9A0")]
		public void SetOvenLit(bool lit)
		{
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004422")]
		[Address(RVA = "0x89C9F0", Offset = "0x89BBF0", VA = "0x18089C9F0", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004423")]
		[Address(RVA = "0x89C870", Offset = "0x89BA70", VA = "0x18089C870", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004424")]
		[Address(RVA = "0x8978C0", Offset = "0x896AC0", VA = "0x1808978C0")]
		public void Hovered()
		{
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004425")]
		[Address(RVA = "0x897D40", Offset = "0x896F40", VA = "0x180897D40")]
		public void Interacted()
		{
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004426")]
		[Address(RVA = "0x898BD0", Offset = "0x897DD0", VA = "0x180898BD0")]
		public void Open()
		{
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004427")]
		[Address(RVA = "0x8960D0", Offset = "0x8952D0", VA = "0x1808960D0")]
		public void Close()
		{
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x6004428")]
		[Address(RVA = "0x897DF0", Offset = "0x896FF0", VA = "0x180897DF0")]
		public bool IsIngredientCookable()
		{
			return default(bool);
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004429")]
		[Address(RVA = "0x89BFF0", Offset = "0x89B1F0", VA = "0x18089BFF0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCookOperation(OvenCookOperation operation)
		{
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600442A")]
		[Address(RVA = "0x89C260", Offset = "0x89B460", VA = "0x18089C260")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetCookOperation(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x600442B")]
		[Address(RVA = "0x897F30", Offset = "0x897130", VA = "0x180897F30")]
		public bool IsReadyToStart()
		{
			return default(bool);
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x600442C")]
		[Address(RVA = "0x897EF0", Offset = "0x8970F0", VA = "0x180897EF0")]
		public bool IsReadyForHarvest()
		{
			return default(bool);
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00012F90 File Offset: 0x00011190
		[Token(Token = "0x600442D")]
		[Address(RVA = "0x895E20", Offset = "0x895020", VA = "0x180895E20")]
		public bool CanOutputSpaceFitCurrentOperation()
		{
			return default(bool);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600442E")]
		[Address(RVA = "0x89C820", Offset = "0x89BA20", VA = "0x18089C820")]
		public void SetLiquidColor(Color col)
		{
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600442F")]
		[Address(RVA = "0x89DE20", Offset = "0x89D020", VA = "0x18089DE20")]
		private void UpdateLiquid()
		{
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004430")]
		[Address(RVA = "0x8968B0", Offset = "0x895AB0", VA = "0x1808968B0")]
		public StationItem[] CreateStationItems(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004431")]
		[Address(RVA = "0x8991E0", Offset = "0x8983E0", VA = "0x1808991E0")]
		public void ResetPourableContainer()
		{
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004432")]
		[Address(RVA = "0x899250", Offset = "0x898450", VA = "0x180899250")]
		public void ResetSquareTray()
		{
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004433")]
		[Address(RVA = "0x896420", Offset = "0x895620", VA = "0x180896420")]
		public LabOvenHammer CreateHammer()
		{
			return null;
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004434")]
		[Address(RVA = "0x8965B0", Offset = "0x8957B0", VA = "0x1808965B0")]
		public void CreateImpactEffects(Vector3 point, bool playSound = true)
		{
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x89D8F0", Offset = "0x89CAF0", VA = "0x18089D8F0")]
		public void Shatter(int shardQuantity, GameObject shardPrefab)
		{
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x895FB0", Offset = "0x8951B0", VA = "0x180895FB0")]
		public void ClearShards()
		{
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004437")]
		[Address(RVA = "0x895EB0", Offset = "0x8950B0", VA = "0x180895EB0")]
		public void ClearDecals()
		{
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004438")]
		[Address(RVA = "0x898FD0", Offset = "0x8981D0", VA = "0x180898FD0")]
		private void OutputSlotChanged()
		{
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004439")]
		[Address(RVA = "0x89D750", Offset = "0x89C950", VA = "0x18089D750", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600443A")]
		[Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600443B")]
		[Address(RVA = "0x89C6B0", Offset = "0x89B8B0", VA = "0x18089C6B0", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600443C")]
		[Address(RVA = "0x89C500", Offset = "0x89B700", VA = "0x18089C500")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600443D")]
		[Address(RVA = "0x89D2A0", Offset = "0x89C4A0", VA = "0x18089D2A0", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600443E")]
		[Address(RVA = "0x89CF80", Offset = "0x89C180", VA = "0x18089CF80")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600443F")]
		[Address(RVA = "0x89CDE0", Offset = "0x89BFE0", VA = "0x18089CDE0", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004440")]
		[Address(RVA = "0x89CB20", Offset = "0x89BD20", VA = "0x18089CB20")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004441")]
		[Address(RVA = "0x896D70", Offset = "0x895F70", VA = "0x180896D70", Slot = "128")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004442")]
		[Address(RVA = "0x896FA0", Offset = "0x8961A0", VA = "0x180896FA0", Slot = "129")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004443")]
		[Address(RVA = "0x8974C0", Offset = "0x8966C0", VA = "0x1808974C0", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004444")]
		[Address(RVA = "0x897810", Offset = "0x896A10", VA = "0x180897810", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004445")]
		[Address(RVA = "0x89E350", Offset = "0x89D550", VA = "0x18089E350")]
		public LabOven()
		{
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004446")]
		[Address(RVA = "0x898100", Offset = "0x897300", VA = "0x180898100", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004447")]
		[Address(RVA = "0x898070", Offset = "0x897270", VA = "0x180898070", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004448")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004449")]
		[Address(RVA = "0x89AF90", Offset = "0x89A190", VA = "0x18089AF90")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444A")]
		[Address(RVA = "0x899320", Offset = "0x898520", VA = "0x180899320", Slot = "136")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444B")]
		[Address(RVA = "0x899EC0", Offset = "0x8990C0", VA = "0x180899EC0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444C")]
		[Address(RVA = "0x89B370", Offset = "0x89A570", VA = "0x18089B370")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444D")]
		[Address(RVA = "0x8996D0", Offset = "0x8988D0", VA = "0x1808996D0", Slot = "137")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444E")]
		[Address(RVA = "0x89A070", Offset = "0x899270", VA = "0x18089A070")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x89B240", Offset = "0x89A440", VA = "0x18089B240")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004450")]
		[Address(RVA = "0x899630", Offset = "0x898830", VA = "0x180899630", Slot = "138")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004451")]
		[Address(RVA = "0x899FF0", Offset = "0x8991F0", VA = "0x180899FF0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004452")]
		[Address(RVA = "0x89AE60", Offset = "0x89A060", VA = "0x18089AE60")]
		private void RpcWriter___Server_SendCookOperation_3708012700(OvenCookOperation operation)
		{
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004453")]
		[Address(RVA = "0x899300", Offset = "0x898500", VA = "0x180899300")]
		public void RpcLogic___SendCookOperation_3708012700(OvenCookOperation operation)
		{
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004454")]
		[Address(RVA = "0x899E40", Offset = "0x899040", VA = "0x180899E40")]
		private void RpcReader___Server_SendCookOperation_3708012700(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004455")]
		[Address(RVA = "0x89A6D0", Offset = "0x8998D0", VA = "0x18089A6D0")]
		private void RpcWriter___Observers_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004456")]
		[Address(RVA = "0x8993C0", Offset = "0x8985C0", VA = "0x1808993C0")]
		public void RpcLogic___SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004457")]
		[Address(RVA = "0x899AE0", Offset = "0x898CE0", VA = "0x180899AE0")]
		private void RpcReader___Observers_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004458")]
		[Address(RVA = "0x89B910", Offset = "0x89AB10", VA = "0x18089B910")]
		private void RpcWriter___Target_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004459")]
		[Address(RVA = "0x89A420", Offset = "0x899620", VA = "0x18089A420")]
		private void RpcReader___Target_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445A")]
		[Address(RVA = "0x89B7A0", Offset = "0x89A9A0", VA = "0x18089B7A0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445B")]
		[Address(RVA = "0x8999A0", Offset = "0x898BA0", VA = "0x1808999A0", Slot = "139")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445C")]
		[Address(RVA = "0x89A330", Offset = "0x899530", VA = "0x18089A330")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445D")]
		[Address(RVA = "0x89ACE0", Offset = "0x899EE0", VA = "0x18089ACE0")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445E")]
		[Address(RVA = "0x899A20", Offset = "0x898C20", VA = "0x180899A20")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445F")]
		[Address(RVA = "0x899DB0", Offset = "0x898FB0", VA = "0x180899DB0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004460")]
		[Address(RVA = "0x89BD70", Offset = "0x89AF70", VA = "0x18089BD70")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004461")]
		[Address(RVA = "0x89A640", Offset = "0x899840", VA = "0x18089A640")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004462")]
		[Address(RVA = "0x89B0C0", Offset = "0x89A2C0", VA = "0x18089B0C0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004463")]
		[Address(RVA = "0x8995A0", Offset = "0x8987A0", VA = "0x1808995A0", Slot = "140")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004464")]
		[Address(RVA = "0x899F40", Offset = "0x899140", VA = "0x180899F40")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004465")]
		[Address(RVA = "0x89A840", Offset = "0x899A40", VA = "0x18089A840")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004466")]
		[Address(RVA = "0x8995B0", Offset = "0x8987B0", VA = "0x1808995B0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004467")]
		[Address(RVA = "0x899B90", Offset = "0x898D90", VA = "0x180899B90")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004468")]
		[Address(RVA = "0x89B610", Offset = "0x89A810", VA = "0x18089B610")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004469")]
		[Address(RVA = "0x899870", Offset = "0x898A70", VA = "0x180899870", Slot = "141")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600446A")]
		[Address(RVA = "0x89A1E0", Offset = "0x8993E0", VA = "0x18089A1E0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600446B")]
		[Address(RVA = "0x89BBE0", Offset = "0x89ADE0", VA = "0x18089BBE0")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600446C")]
		[Address(RVA = "0x8998F0", Offset = "0x898AF0", VA = "0x1808998F0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600446D")]
		[Address(RVA = "0x89A550", Offset = "0x899750", VA = "0x18089A550")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600446E")]
		[Address(RVA = "0x89AB40", Offset = "0x899D40", VA = "0x18089AB40")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600446F")]
		[Address(RVA = "0x899CC0", Offset = "0x898EC0", VA = "0x180899CC0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004470")]
		[Address(RVA = "0x89B4A0", Offset = "0x89A6A0", VA = "0x18089B4A0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004471")]
		[Address(RVA = "0x899770", Offset = "0x898970", VA = "0x180899770", Slot = "142")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004472")]
		[Address(RVA = "0x89A0F0", Offset = "0x8992F0", VA = "0x18089A0F0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004473")]
		[Address(RVA = "0x89A9C0", Offset = "0x899BC0", VA = "0x18089A9C0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004474")]
		[Address(RVA = "0x8997F0", Offset = "0x8989F0", VA = "0x1808997F0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x899C30", Offset = "0x898E30", VA = "0x180899C30")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004476")]
		[Address(RVA = "0x89BA70", Offset = "0x89AC70", VA = "0x18089BA70")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004477")]
		[Address(RVA = "0x89A4C0", Offset = "0x8996C0", VA = "0x18089A4C0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB1")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6004478")]
			[Address(RVA = "0x89E4E0", Offset = "0x89D6E0", VA = "0x18089E4E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004479")]
			[Address(RVA = "0x89E780", Offset = "0x89D980", VA = "0x18089E780")]
			set
			{
			}
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00012FA8 File Offset: 0x000111A8
		[Token(Token = "0x600447A")]
		[Address(RVA = "0x899040", Offset = "0x898240", VA = "0x180899040", Slot = "143")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.LabOven(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600447C RID: 17532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB2")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x600447B")]
			[Address(RVA = "0x89E500", Offset = "0x89D700", VA = "0x18089E500")]
			get
			{
				return null;
			}
			[Token(Token = "0x600447C")]
			[Address(RVA = "0x89E840", Offset = "0x89DA40", VA = "0x18089E840")]
			set
			{
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600447E RID: 17534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB3")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x600447D")]
			[Address(RVA = "0x6F2CD0", Offset = "0x6F1ED0", VA = "0x1806F2CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600447E")]
			[Address(RVA = "0x89E6C0", Offset = "0x89D8C0", VA = "0x18089E6C0")]
			set
			{
			}
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600447F")]
		[Address(RVA = "0x8959A0", Offset = "0x894BA0", VA = "0x1808959A0", Slot = "144")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.LabOven_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040030D5 RID: 12501
		[Token(Token = "0x40030D5")]
		public const int SOLID_INGREDIENT_COOK_LIMIT = 10;

		// Token: 0x040030D6 RID: 12502
		[Token(Token = "0x40030D6")]
		public const float FOV_OVERRIDE = 70f;

		// Token: 0x040030D9 RID: 12505
		[Token(Token = "0x40030D9")]
		[FieldOffset(Offset = "0x220")]
		public LabOven.ELightMode LightMode;

		// Token: 0x040030DA RID: 12506
		[Token(Token = "0x40030DA")]
		[FieldOffset(Offset = "0x228")]
		[Header("References")]
		public Transform CameraPosition_Default;

		// Token: 0x040030DB RID: 12507
		[Token(Token = "0x40030DB")]
		[FieldOffset(Offset = "0x230")]
		public Transform CameraPosition_Pour;

		// Token: 0x040030DC RID: 12508
		[Token(Token = "0x40030DC")]
		[FieldOffset(Offset = "0x238")]
		public Transform CameraPosition_PlaceItems;

		// Token: 0x040030DD RID: 12509
		[Token(Token = "0x40030DD")]
		[FieldOffset(Offset = "0x240")]
		public Transform CameraPosition_Breaking;

		// Token: 0x040030DE RID: 12510
		[Token(Token = "0x40030DE")]
		[FieldOffset(Offset = "0x248")]
		public InteractableObject IntObj;

		// Token: 0x040030DF RID: 12511
		[Token(Token = "0x40030DF")]
		[FieldOffset(Offset = "0x250")]
		public LabOvenDoor Door;

		// Token: 0x040030E0 RID: 12512
		[Token(Token = "0x40030E0")]
		[FieldOffset(Offset = "0x258")]
		public LabOvenWireTray WireTray;

		// Token: 0x040030E1 RID: 12513
		[Token(Token = "0x40030E1")]
		[FieldOffset(Offset = "0x260")]
		public ToggleableLight OvenLight;

		// Token: 0x040030E2 RID: 12514
		[Token(Token = "0x40030E2")]
		[FieldOffset(Offset = "0x268")]
		public LabOvenButton Button;

		// Token: 0x040030E3 RID: 12515
		[Token(Token = "0x40030E3")]
		[FieldOffset(Offset = "0x270")]
		public TextMeshPro TimerLabel;

		// Token: 0x040030E4 RID: 12516
		[Token(Token = "0x40030E4")]
		[FieldOffset(Offset = "0x278")]
		public ToggleableLight Light;

		// Token: 0x040030E5 RID: 12517
		[Token(Token = "0x40030E5")]
		[FieldOffset(Offset = "0x280")]
		public Transform PourableContainer;

		// Token: 0x040030E6 RID: 12518
		[Token(Token = "0x40030E6")]
		[FieldOffset(Offset = "0x288")]
		public Transform ItemContainer;

		// Token: 0x040030E7 RID: 12519
		[Token(Token = "0x40030E7")]
		[FieldOffset(Offset = "0x290")]
		public Animation PourAnimation;

		// Token: 0x040030E8 RID: 12520
		[Token(Token = "0x40030E8")]
		[FieldOffset(Offset = "0x298")]
		public SkinnedMeshRenderer LiquidMesh;

		// Token: 0x040030E9 RID: 12521
		[Token(Token = "0x40030E9")]
		[FieldOffset(Offset = "0x2A0")]
		public StorageVisualizer InputVisuals;

		// Token: 0x040030EA RID: 12522
		[Token(Token = "0x40030EA")]
		[FieldOffset(Offset = "0x2A8")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x040030EB RID: 12523
		[Token(Token = "0x40030EB")]
		[FieldOffset(Offset = "0x2B0")]
		public MeshRenderer CookedLiquidMesh;

		// Token: 0x040030EC RID: 12524
		[Token(Token = "0x40030EC")]
		[FieldOffset(Offset = "0x2B8")]
		public Animation RemoveTrayAnimation;

		// Token: 0x040030ED RID: 12525
		[Token(Token = "0x40030ED")]
		[FieldOffset(Offset = "0x2C0")]
		public Transform SquareTray;

		// Token: 0x040030EE RID: 12526
		[Token(Token = "0x40030EE")]
		[FieldOffset(Offset = "0x2C8")]
		public Transform HammerSpawnPoint;

		// Token: 0x040030EF RID: 12527
		[Token(Token = "0x40030EF")]
		[FieldOffset(Offset = "0x2D0")]
		public Transform HammerContainer;

		// Token: 0x040030F0 RID: 12528
		[Token(Token = "0x40030F0")]
		[FieldOffset(Offset = "0x2D8")]
		public Transform OafBastard;

		// Token: 0x040030F1 RID: 12529
		[Token(Token = "0x40030F1")]
		[FieldOffset(Offset = "0x2E0")]
		public Transform DecalContainer;

		// Token: 0x040030F2 RID: 12530
		[Token(Token = "0x40030F2")]
		[FieldOffset(Offset = "0x2E8")]
		public Transform DecalMaxBounds;

		// Token: 0x040030F3 RID: 12531
		[Token(Token = "0x40030F3")]
		[FieldOffset(Offset = "0x2F0")]
		public Transform DecalMinBounds;

		// Token: 0x040030F4 RID: 12532
		[Token(Token = "0x40030F4")]
		[FieldOffset(Offset = "0x2F8")]
		public BoxCollider CookedLiquidCollider;

		// Token: 0x040030F5 RID: 12533
		[Token(Token = "0x40030F5")]
		[FieldOffset(Offset = "0x300")]
		public Transform[] ShardSpawnPoints;

		// Token: 0x040030F6 RID: 12534
		[Token(Token = "0x40030F6")]
		[FieldOffset(Offset = "0x308")]
		public ParticleSystem ShatterParticles;

		// Token: 0x040030F7 RID: 12535
		[Token(Token = "0x40030F7")]
		[FieldOffset(Offset = "0x310")]
		public Transform uiPoint;

		// Token: 0x040030F8 RID: 12536
		[Token(Token = "0x40030F8")]
		[FieldOffset(Offset = "0x318")]
		public Transform[] accessPoints;

		// Token: 0x040030F9 RID: 12537
		[Token(Token = "0x40030F9")]
		[FieldOffset(Offset = "0x320")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x040030FA RID: 12538
		[Token(Token = "0x40030FA")]
		[FieldOffset(Offset = "0x328")]
		public Transform[] SolidIngredientSpawnPoints;

		// Token: 0x040030FB RID: 12539
		[Token(Token = "0x40030FB")]
		[FieldOffset(Offset = "0x330")]
		public BoxCollider TrayDetectionArea;

		// Token: 0x040030FC RID: 12540
		[Token(Token = "0x40030FC")]
		[FieldOffset(Offset = "0x338")]
		[Header("Sounds")]
		public AudioSourceController ButtonSound;

		// Token: 0x040030FD RID: 12541
		[Token(Token = "0x40030FD")]
		[FieldOffset(Offset = "0x340")]
		public AudioSourceController DingSound;

		// Token: 0x040030FE RID: 12542
		[Token(Token = "0x40030FE")]
		[FieldOffset(Offset = "0x348")]
		public AudioSourceController RunLoopSound;

		// Token: 0x040030FF RID: 12543
		[Token(Token = "0x40030FF")]
		[FieldOffset(Offset = "0x350")]
		public AudioSourceController ImpactSound;

		// Token: 0x04003100 RID: 12544
		[Token(Token = "0x4003100")]
		[FieldOffset(Offset = "0x358")]
		public AudioSourceController ShatterSound;

		// Token: 0x04003101 RID: 12545
		[Token(Token = "0x4003101")]
		[FieldOffset(Offset = "0x360")]
		[Header("UI")]
		public LabOvenUIElement WorldspaceUIPrefab;

		// Token: 0x04003102 RID: 12546
		[Token(Token = "0x4003102")]
		[FieldOffset(Offset = "0x368")]
		public Sprite typeIcon;

		// Token: 0x04003103 RID: 12547
		[Token(Token = "0x4003103")]
		[FieldOffset(Offset = "0x370")]
		[Header("Prefabs")]
		public LabOvenHammer HammerPrefab;

		// Token: 0x04003104 RID: 12548
		[Token(Token = "0x4003104")]
		[FieldOffset(Offset = "0x378")]
		public GameObject SmashDecalPrefab;

		// Token: 0x04003107 RID: 12551
		[Token(Token = "0x4003107")]
		[FieldOffset(Offset = "0x390")]
		public ItemSlot IngredientSlot;

		// Token: 0x04003108 RID: 12552
		[Token(Token = "0x4003108")]
		[FieldOffset(Offset = "0x398")]
		public ItemSlot OutputSlot;

		// Token: 0x04003110 RID: 12560
		[Token(Token = "0x4003110")]
		[FieldOffset(Offset = "0x3D0")]
		private Vector3 pourableContainerDefaultPos;

		// Token: 0x04003111 RID: 12561
		[Token(Token = "0x4003111")]
		[FieldOffset(Offset = "0x3DC")]
		private Quaternion pourableContainerDefaultRot;

		// Token: 0x04003112 RID: 12562
		[Token(Token = "0x4003112")]
		[FieldOffset(Offset = "0x3EC")]
		private Vector3 squareTrayDefaultPos;

		// Token: 0x04003113 RID: 12563
		[Token(Token = "0x4003113")]
		[FieldOffset(Offset = "0x3F8")]
		private Quaternion squareTrayDefaultRot;

		// Token: 0x04003114 RID: 12564
		[Token(Token = "0x4003114")]
		[FieldOffset(Offset = "0x408")]
		private List<GameObject> decals;

		// Token: 0x04003115 RID: 12565
		[Token(Token = "0x4003115")]
		[FieldOffset(Offset = "0x410")]
		private List<GameObject> shards;

		// Token: 0x04003116 RID: 12566
		[Token(Token = "0x4003116")]
		[FieldOffset(Offset = "0x418")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003117 RID: 12567
		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0x420")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003118 RID: 12568
		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0x428")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003119 RID: 12569
		[Token(Token = "0x4003119")]
		[FieldOffset(Offset = "0x430")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted;

		// Token: 0x0400311A RID: 12570
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0x431")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted;

		// Token: 0x020009A4 RID: 2468
		[Token(Token = "0x20009A4")]
		public enum ELightMode
		{
			// Token: 0x0400311C RID: 12572
			[Token(Token = "0x400311C")]
			Off,
			// Token: 0x0400311D RID: 12573
			[Token(Token = "0x400311D")]
			On,
			// Token: 0x0400311E RID: 12574
			[Token(Token = "0x400311E")]
			Flash
		}

		// Token: 0x020009A5 RID: 2469
		[Token(Token = "0x20009A5")]
		public enum EState
		{
			// Token: 0x04003120 RID: 12576
			[Token(Token = "0x4003120")]
			CanBegin,
			// Token: 0x04003121 RID: 12577
			[Token(Token = "0x4003121")]
			MissingItems,
			// Token: 0x04003122 RID: 12578
			[Token(Token = "0x4003122")]
			InsufficentProduct,
			// Token: 0x04003123 RID: 12579
			[Token(Token = "0x4003123")]
			OutputSlotFull,
			// Token: 0x04003124 RID: 12580
			[Token(Token = "0x4003124")]
			Mismatch
		}
	}
}
