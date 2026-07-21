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
using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200098C RID: 2444
	[Token(Token = "0x200098C")]
	public class Cauldron : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x00012960 File Offset: 0x00010B60
		[Token(Token = "0x17000A3F")]
		public bool isOpen
		{
			[Token(Token = "0x60041EE")]
			[Address(RVA = "0x87F300", Offset = "0x87E500", VA = "0x18087F300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060041F0 RID: 16880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A40")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60041EF")]
			[Address(RVA = "0x5A44C0", Offset = "0x5A36C0", VA = "0x1805A44C0", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041F0")]
			[Address(RVA = "0x5A4580", Offset = "0x5A3780", VA = "0x1805A4580", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A41")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x60041F1")]
			[Address(RVA = "0x72EF90", Offset = "0x72E190", VA = "0x18072EF90", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041F2")]
			[Address(RVA = "0x87AAD0", Offset = "0x879CD0", VA = "0x18087AAD0", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060041F3 RID: 16883 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060041F4 RID: 16884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A42")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60041F3")]
			[Address(RVA = "0x87F2D0", Offset = "0x87E4D0", VA = "0x18087F2D0", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041F4")]
			[Address(RVA = "0x87AB70", Offset = "0x879D70", VA = "0x18087AB70", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A43")]
		public string Name
		{
			[Token(Token = "0x60041F5")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060041F7 RID: 16887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A44")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60041F6")]
			[Address(RVA = "0x72EF70", Offset = "0x72E170", VA = "0x18072EF70", Slot = "93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041F7")]
			[Address(RVA = "0x72EFF0", Offset = "0x72E1F0", VA = "0x18072EFF0", Slot = "94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060041F9 RID: 16889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A45")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x60041F8")]
			[Address(RVA = "0x72EF60", Offset = "0x72E160", VA = "0x18072EF60", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60041F9")]
			[Address(RVA = "0x72EFD0", Offset = "0x72E1D0", VA = "0x18072EFD0", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A46")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x60041FA")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060041FB RID: 16891 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A47")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x60041FB")]
			[Address(RVA = "0x66B570", Offset = "0x66A770", VA = "0x18066B570", Slot = "98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060041FC RID: 16892 RVA: 0x00012978 File Offset: 0x00010B78
		[Token(Token = "0x17000A48")]
		public bool Selectable
		{
			[Token(Token = "0x60041FC")]
			[Address(RVA = "0x72EFA0", Offset = "0x72E1A0", VA = "0x18072EFA0", Slot = "99")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x00012990 File Offset: 0x00010B90
		// (set) Token: 0x060041FE RID: 16894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A49")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x60041FD")]
			[Address(RVA = "0x87F2C0", Offset = "0x87E4C0", VA = "0x18087F2C0", Slot = "100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041FE")]
			[Address(RVA = "0x87F410", Offset = "0x87E610", VA = "0x18087F410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A4A")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60041FF")]
			[Address(RVA = "0x87F2A0", Offset = "0x87E4A0", VA = "0x18087F2A0", Slot = "114")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004201 RID: 16897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4B")]
		protected CauldronConfiguration cauldronConfiguration
		{
			[Token(Token = "0x6004200")]
			[Address(RVA = "0x87F2A0", Offset = "0x87E4A0", VA = "0x18087F2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004201")]
			[Address(RVA = "0x87F440", Offset = "0x87E640", VA = "0x18087F440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06004202 RID: 16898 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A4C")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6004202")]
			[Address(RVA = "0x66B560", Offset = "0x66A760", VA = "0x18066B560", Slot = "115")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06004203 RID: 16899 RVA: 0x000129A8 File Offset: 0x00010BA8
		[Token(Token = "0x17000A4D")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6004203")]
			[Address(RVA = "0x87F290", Offset = "0x87E490", VA = "0x18087F290", Slot = "116")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06004204 RID: 16900 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004205 RID: 16901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4E")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6004204")]
			[Address(RVA = "0x87F2E0", Offset = "0x87E4E0", VA = "0x18087F2E0", Slot = "117")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004205")]
			[Address(RVA = "0x87F420", Offset = "0x87E620", VA = "0x18087F420", Slot = "118")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06004206 RID: 16902 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004207 RID: 16903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4F")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6004206")]
			[Address(RVA = "0x87F2B0", Offset = "0x87E4B0", VA = "0x18087F2B0", Slot = "119")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004207")]
			[Address(RVA = "0x87A9A0", Offset = "0x879BA0", VA = "0x18087A9A0", Slot = "120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x87D6D0", Offset = "0x87C8D0", VA = "0x18087D6D0", Slot = "134")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06004209 RID: 16905 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A50")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6004209")]
			[Address(RVA = "0x875F80", Offset = "0x875180", VA = "0x180875F80", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A51")]
		public Transform Transform
		{
			[Token(Token = "0x600420A")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A52")]
		public Transform UIPoint
		{
			[Token(Token = "0x600420B")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x000129C0 File Offset: 0x00010BC0
		[Token(Token = "0x17000A53")]
		public bool CanBeSelected
		{
			[Token(Token = "0x600420C")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x0600420D RID: 16909 RVA: 0x000129D8 File Offset: 0x00010BD8
		[Token(Token = "0x17000A54")]
		private bool isCooking
		{
			[Token(Token = "0x600420D")]
			[Address(RVA = "0x87F2F0", Offset = "0x87E4F0", VA = "0x18087F2F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x877250", Offset = "0x876450", VA = "0x180877250", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420F")]
		[Address(RVA = "0x8792C0", Offset = "0x8784C0", VA = "0x1808792C0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004210")]
		[Address(RVA = "0x878E10", Offset = "0x878010", VA = "0x180878E10", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004211")]
		[Address(RVA = "0x87EE10", Offset = "0x87E010", VA = "0x18087EE10", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004212")]
		[Address(RVA = "0x879CE0", Offset = "0x878EE0", VA = "0x180879CE0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004213")]
		[Address(RVA = "0x87D570", Offset = "0x87C770", VA = "0x18087D570", Slot = "135")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004214")]
		[Address(RVA = "0x877E70", Offset = "0x877070", VA = "0x180877E70", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004215")]
		[Address(RVA = "0x879CD0", Offset = "0x878ED0", VA = "0x180879CD0")]
		private void OnMinPass()
		{
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004216")]
		[Address(RVA = "0x879E70", Offset = "0x879070", VA = "0x180879E70")]
		private void OnTimePass(int minutes)
		{
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004217")]
		[Address(RVA = "0x8781A0", Offset = "0x8773A0", VA = "0x1808781A0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004218")]
		[Address(RVA = "0x879180", Offset = "0x878380", VA = "0x180879180")]
		public void Hovered()
		{
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004219")]
		[Address(RVA = "0x879430", Offset = "0x878630", VA = "0x180879430")]
		public void Interacted()
		{
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421A")]
		[Address(RVA = "0x87A0D0", Offset = "0x8792D0", VA = "0x18087A0D0")]
		public void Open()
		{
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421B")]
		[Address(RVA = "0x8773C0", Offset = "0x8765C0", VA = "0x1808773C0")]
		public void Close()
		{
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x000129F0 File Offset: 0x00010BF0
		[Token(Token = "0x600421C")]
		[Address(RVA = "0x8772C0", Offset = "0x8764C0", VA = "0x1808772C0", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421D")]
		[Address(RVA = "0x87F0B0", Offset = "0x87E2B0", VA = "0x18087F0B0")]
		private void UpdateIngredientVisuals()
		{
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600421E")]
		[Address(RVA = "0x878720", Offset = "0x877920", VA = "0x180878720")]
		public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity)
		{
		}

		// Token: 0x0600421F RID: 16927 RVA: 0x00012A08 File Offset: 0x00010C08
		[Token(Token = "0x600421F")]
		[Address(RVA = "0x878EF0", Offset = "0x8780F0", VA = "0x180878EF0")]
		public Cauldron.EState GetState()
		{
			return Cauldron.EState.MissingIngredients;
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x00012A20 File Offset: 0x00010C20
		[Token(Token = "0x6004220")]
		[Address(RVA = "0x879110", Offset = "0x878310", VA = "0x180879110")]
		public bool HasOutputSpace()
		{
			return default(bool);
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x00012A38 File Offset: 0x00010C38
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x87A670", Offset = "0x879870", VA = "0x18087A670")]
		public EQuality RemoveIngredients()
		{
			return EQuality.Trash;
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x00012A50 File Offset: 0x00010C50
		[Token(Token = "0x6004222")]
		[Address(RVA = "0x879040", Offset = "0x878240", VA = "0x180879040")]
		public bool HasIngredients()
		{
			return default(bool);
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004223")]
		[Address(RVA = "0x87C4A0", Offset = "0x87B6A0", VA = "0x18087C4A0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendCookOperation(int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004224")]
		[Address(RVA = "0x87EB50", Offset = "0x87DD50", VA = "0x18087EB50")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void StartCookOperation(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004225")]
		[Address(RVA = "0x8782F0", Offset = "0x8774F0", VA = "0x1808782F0")]
		[ObserversRpc]
		public void FinishCookOperation()
		{
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004226")]
		[Address(RVA = "0x8772A0", Offset = "0x8764A0", VA = "0x1808772A0")]
		private void ButtonClicked(RaycastHit hit)
		{
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004227")]
		[Address(RVA = "0x877710", Offset = "0x876910", VA = "0x180877710")]
		public void CreateTrash(List<StationItem> mixerItems)
		{
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004228")]
		[Address(RVA = "0x87DC50", Offset = "0x87CE50", VA = "0x18087DC50", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004229")]
		[Address(RVA = "0x87DB20", Offset = "0x87CD20", VA = "0x18087DB20", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422A")]
		[Address(RVA = "0x87E9B0", Offset = "0x87DBB0", VA = "0x18087E9B0", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422B")]
		[Address(RVA = "0x87E6F0", Offset = "0x87D8F0", VA = "0x18087E6F0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x87D9B0", Offset = "0x87CBB0", VA = "0x18087D9B0", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x87D800", Offset = "0x87CA00", VA = "0x18087D800")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422E")]
		[Address(RVA = "0x87E500", Offset = "0x87D700", VA = "0x18087E500", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422F")]
		[Address(RVA = "0x87E1E0", Offset = "0x87D3E0", VA = "0x18087E1E0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004230")]
		[Address(RVA = "0x87E040", Offset = "0x87D240", VA = "0x18087E040", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004231")]
		[Address(RVA = "0x87DD80", Offset = "0x87CF80", VA = "0x18087DD80")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004232")]
		[Address(RVA = "0x877BB0", Offset = "0x876DB0", VA = "0x180877BB0", Slot = "128")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004233")]
		[Address(RVA = "0x877DE0", Offset = "0x876FE0", VA = "0x180877DE0", Slot = "129")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004234")]
		[Address(RVA = "0x878410", Offset = "0x877610", VA = "0x180878410", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004235")]
		[Address(RVA = "0x878E40", Offset = "0x878040", VA = "0x180878E40", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004236")]
		[Address(RVA = "0x87F180", Offset = "0x87E380", VA = "0x18087F180")]
		public Cauldron()
		{
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004237")]
		[Address(RVA = "0x879570", Offset = "0x878770", VA = "0x180879570", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004238")]
		[Address(RVA = "0x8794E0", Offset = "0x8786E0", VA = "0x1808794E0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004239")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423A")]
		[Address(RVA = "0x87C610", Offset = "0x87B810", VA = "0x18087C610")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423B")]
		[Address(RVA = "0x87A9A0", Offset = "0x879BA0", VA = "0x18087A9A0", Slot = "136")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423C")]
		[Address(RVA = "0x87B510", Offset = "0x87A710", VA = "0x18087B510")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423D")]
		[Address(RVA = "0x87C4A0", Offset = "0x87B6A0", VA = "0x18087C4A0")]
		private void RpcWriter___Server_SendCookOperation_3536682170(int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423E")]
		[Address(RVA = "0x87A980", Offset = "0x879B80", VA = "0x18087A980")]
		public void RpcLogic___SendCookOperation_3536682170(int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423F")]
		[Address(RVA = "0x87B490", Offset = "0x87A690", VA = "0x18087B490")]
		private void RpcReader___Server_SendCookOperation_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004240")]
		[Address(RVA = "0x87C330", Offset = "0x87B530", VA = "0x18087C330")]
		private void RpcWriter___Observers_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004241")]
		[Address(RVA = "0x87AF80", Offset = "0x87A180", VA = "0x18087AF80")]
		public void RpcLogic___StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004242")]
		[Address(RVA = "0x87B400", Offset = "0x87A600", VA = "0x18087B400")]
		private void RpcReader___Observers_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004243")]
		[Address(RVA = "0x87D400", Offset = "0x87C600", VA = "0x18087D400")]
		private void RpcWriter___Target_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004244")]
		[Address(RVA = "0x87BC80", Offset = "0x87AE80", VA = "0x18087BC80")]
		private void RpcReader___Target_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x8782F0", Offset = "0x8774F0", VA = "0x1808782F0")]
		private void RpcWriter___Observers_FinishCookOperation_2166136261()
		{
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x87A870", Offset = "0x879A70", VA = "0x18087A870")]
		public void RpcLogic___FinishCookOperation_2166136261()
		{
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004247")]
		[Address(RVA = "0x87B030", Offset = "0x87A230", VA = "0x18087B030")]
		private void RpcReader___Observers_FinishCookOperation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004248")]
		[Address(RVA = "0x87C9F0", Offset = "0x87BBF0", VA = "0x18087C9F0")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004249")]
		[Address(RVA = "0x87AB70", Offset = "0x879D70", VA = "0x18087AB70", Slot = "137")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424A")]
		[Address(RVA = "0x87B6C0", Offset = "0x87A8C0", VA = "0x18087B6C0")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424B")]
		[Address(RVA = "0x87C8C0", Offset = "0x87BAC0", VA = "0x18087C8C0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424C")]
		[Address(RVA = "0x87AAD0", Offset = "0x879CD0", VA = "0x18087AAD0", Slot = "138")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424D")]
		[Address(RVA = "0x87B640", Offset = "0x87A840", VA = "0x18087B640")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424E")]
		[Address(RVA = "0x87CE20", Offset = "0x87C020", VA = "0x18087CE20")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424F")]
		[Address(RVA = "0x87AE40", Offset = "0x87A040", VA = "0x18087AE40", Slot = "139")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004250")]
		[Address(RVA = "0x87B980", Offset = "0x87AB80", VA = "0x18087B980")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004251")]
		[Address(RVA = "0x87C1B0", Offset = "0x87B3B0", VA = "0x18087C1B0")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004252")]
		[Address(RVA = "0x87AEC0", Offset = "0x87A0C0", VA = "0x18087AEC0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004253")]
		[Address(RVA = "0x87B370", Offset = "0x87A570", VA = "0x18087B370")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004254")]
		[Address(RVA = "0x87D290", Offset = "0x87C490", VA = "0x18087D290")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004255")]
		[Address(RVA = "0x87BBF0", Offset = "0x87ADF0", VA = "0x18087BBF0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004256")]
		[Address(RVA = "0x87C740", Offset = "0x87B940", VA = "0x18087C740")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004257")]
		[Address(RVA = "0x87AA40", Offset = "0x879C40", VA = "0x18087AA40", Slot = "140")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004258")]
		[Address(RVA = "0x87B590", Offset = "0x87A790", VA = "0x18087B590")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004259")]
		[Address(RVA = "0x87BD10", Offset = "0x87AF10", VA = "0x18087BD10")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600425A")]
		[Address(RVA = "0x87AA50", Offset = "0x879C50", VA = "0x18087AA50")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x87B150", Offset = "0x87A350", VA = "0x18087B150")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600425C")]
		[Address(RVA = "0x87CC90", Offset = "0x87BE90", VA = "0x18087CC90")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600425D")]
		[Address(RVA = "0x87AD10", Offset = "0x879F10", VA = "0x18087AD10", Slot = "141")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600425E")]
		[Address(RVA = "0x87B830", Offset = "0x87AA30", VA = "0x18087B830")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600425F")]
		[Address(RVA = "0x87D100", Offset = "0x87C300", VA = "0x18087D100")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004260")]
		[Address(RVA = "0x87AD90", Offset = "0x879F90", VA = "0x18087AD90")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004261")]
		[Address(RVA = "0x87BB00", Offset = "0x87AD00", VA = "0x18087BB00")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004262")]
		[Address(RVA = "0x87C010", Offset = "0x87B210", VA = "0x18087C010")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004263")]
		[Address(RVA = "0x87B280", Offset = "0x87A480", VA = "0x18087B280")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004264")]
		[Address(RVA = "0x87CB20", Offset = "0x87BD20", VA = "0x18087CB20")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004265")]
		[Address(RVA = "0x87AC10", Offset = "0x879E10", VA = "0x18087AC10", Slot = "142")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004266")]
		[Address(RVA = "0x87B740", Offset = "0x87A940", VA = "0x18087B740")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004267")]
		[Address(RVA = "0x87BE90", Offset = "0x87B090", VA = "0x18087BE90")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004268")]
		[Address(RVA = "0x87AC90", Offset = "0x879E90", VA = "0x18087AC90")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004269")]
		[Address(RVA = "0x87B1F0", Offset = "0x87A3F0", VA = "0x18087B1F0")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426A")]
		[Address(RVA = "0x87CF90", Offset = "0x87C190", VA = "0x18087CF90")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426B")]
		[Address(RVA = "0x87BA70", Offset = "0x87AC70", VA = "0x18087BA70")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x0600426C RID: 17004 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600426D RID: 17005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A55")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x600426C")]
			[Address(RVA = "0x72EF90", Offset = "0x72E190", VA = "0x18072EF90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600426D")]
			[Address(RVA = "0x87F520", Offset = "0x87E720", VA = "0x18087F520")]
			set
			{
			}
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x00012A68 File Offset: 0x00010C68
		[Token(Token = "0x600426E")]
		[Address(RVA = "0x87A4D0", Offset = "0x8796D0", VA = "0x18087A4D0", Slot = "143")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.Cauldron(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004270 RID: 17008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A56")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x600426F")]
			[Address(RVA = "0x87F2D0", Offset = "0x87E4D0", VA = "0x18087F2D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004270")]
			[Address(RVA = "0x87F5E0", Offset = "0x87E7E0", VA = "0x18087F5E0")]
			set
			{
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004272 RID: 17010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A57")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6004271")]
			[Address(RVA = "0x87F2B0", Offset = "0x87E4B0", VA = "0x18087F2B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004272")]
			[Address(RVA = "0x87F460", Offset = "0x87E660", VA = "0x18087F460")]
			set
			{
			}
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004273")]
		[Address(RVA = "0x876B80", Offset = "0x875D80", VA = "0x180876B80", Slot = "144")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.Cauldron_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002FCE RID: 12238
		[Token(Token = "0x4002FCE")]
		public const int INGREDIENT_SLOT_COUNT = 4;

		// Token: 0x04002FCF RID: 12239
		[Token(Token = "0x4002FCF")]
		public const int COCA_LEAF_REQUIRED = 20;

		// Token: 0x04002FD0 RID: 12240
		[Token(Token = "0x4002FD0")]
		[FieldOffset(Offset = "0x210")]
		public ItemSlot[] IngredientSlots;

		// Token: 0x04002FD1 RID: 12241
		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x218")]
		public ItemSlot LiquidSlot;

		// Token: 0x04002FD2 RID: 12242
		[Token(Token = "0x4002FD2")]
		[FieldOffset(Offset = "0x220")]
		public ItemSlot OutputSlot;

		// Token: 0x04002FD4 RID: 12244
		[Token(Token = "0x4002FD4")]
		[FieldOffset(Offset = "0x230")]
		public int CookTime;

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x238")]
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0x240")]
		public Transform CameraPosition_CombineIngredients;

		// Token: 0x04002FD7 RID: 12247
		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x248")]
		public Transform CameraPosition_StartMachine;

		// Token: 0x04002FD8 RID: 12248
		[Token(Token = "0x4002FD8")]
		[FieldOffset(Offset = "0x250")]
		public InteractableObject IntObj;

		// Token: 0x04002FD9 RID: 12249
		[Token(Token = "0x4002FD9")]
		[FieldOffset(Offset = "0x258")]
		public Transform[] accessPoints;

		// Token: 0x04002FDA RID: 12250
		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x260")]
		public Transform StandPoint;

		// Token: 0x04002FDB RID: 12251
		[Token(Token = "0x4002FDB")]
		[FieldOffset(Offset = "0x268")]
		public Transform uiPoint;

		// Token: 0x04002FDC RID: 12252
		[Token(Token = "0x4002FDC")]
		[FieldOffset(Offset = "0x270")]
		public StorageVisualizer LiquidVisuals;

		// Token: 0x04002FDD RID: 12253
		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0x278")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x04002FDE RID: 12254
		[Token(Token = "0x4002FDE")]
		[FieldOffset(Offset = "0x280")]
		public CauldronDisplayTub PrimaryTub;

		// Token: 0x04002FDF RID: 12255
		[Token(Token = "0x4002FDF")]
		[FieldOffset(Offset = "0x288")]
		public CauldronDisplayTub SecondaryTub;

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0x290")]
		public Transform ItemContainer;

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x298")]
		public Transform GasolineSpawnPoint;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x2A0")]
		public Transform TubSpawnPoint;

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x2A8")]
		public Transform[] LeafSpawns;

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x2B0")]
		public Light OverheadLight;

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x2B8")]
		public Fillable CauldronFillable;

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x2C0")]
		public Clickable StartButtonClickable;

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x2C8")]
		public DigitalAlarm Alarm;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x2D0")]
		public ToggleableLight Light;

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x2D8")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x2E0")]
		public BoxCollider TrashSpawnVolume;

		// Token: 0x04002FEB RID: 12267
		[Token(Token = "0x4002FEB")]
		[FieldOffset(Offset = "0x2E8")]
		public Transform LeafDragProjectionPlane;

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0x2F0")]
		[Header("Prefabs")]
		public StationItem CocaLeafPrefab;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0x2F8")]
		public StationItem GasolinePrefab;

		// Token: 0x04002FEE RID: 12270
		[Token(Token = "0x4002FEE")]
		[FieldOffset(Offset = "0x300")]
		public Draggable TubPrefab;

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0x308")]
		public QualityItemDefinition CocaineBaseDefinition;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0x310")]
		[Header("UI")]
		public CauldronUIElement WorldspaceUIPrefab;

		// Token: 0x04002FF1 RID: 12273
		[Token(Token = "0x4002FF1")]
		[FieldOffset(Offset = "0x318")]
		public Sprite typeIcon;

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0x320")]
		public UnityEvent onStartButtonClicked;

		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		[FieldOffset(Offset = "0x328")]
		public UnityEvent onCookStart;

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0x330")]
		public UnityEvent onCookEnd;

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0x338")]
		public int RemainingCookTime;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0x33C")]
		public EQuality InputQuality;

		// Token: 0x04003000 RID: 12288
		[Token(Token = "0x4003000")]
		[FieldOffset(Offset = "0x380")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003001 RID: 12289
		[Token(Token = "0x4003001")]
		[FieldOffset(Offset = "0x388")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x390")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04003003 RID: 12291
		[Token(Token = "0x4003003")]
		[FieldOffset(Offset = "0x398")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted;

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x399")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.CauldronAssembly-CSharp.dll_Excuted;

		// Token: 0x0200098D RID: 2445
		[Token(Token = "0x200098D")]
		public enum EState
		{
			// Token: 0x04003006 RID: 12294
			[Token(Token = "0x4003006")]
			MissingIngredients,
			// Token: 0x04003007 RID: 12295
			[Token(Token = "0x4003007")]
			Ready,
			// Token: 0x04003008 RID: 12296
			[Token(Token = "0x4003008")]
			Cooking,
			// Token: 0x04003009 RID: 12297
			[Token(Token = "0x4003009")]
			OutputFull
		}
	}
}
