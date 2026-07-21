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
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200099E RID: 2462
	[Token(Token = "0x200099E")]
	public class DryingRack : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7E")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6004350")]
			[Address(RVA = "0x834F90", Offset = "0x834190", VA = "0x180834F90", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004351")]
			[Address(RVA = "0x8903A0", Offset = "0x88F5A0", VA = "0x1808903A0", Slot = "74")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7F")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6004352")]
			[Address(RVA = "0x8036C0", Offset = "0x8028C0", VA = "0x1808036C0", Slot = "75")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004353")]
			[Address(RVA = "0x890560", Offset = "0x88F760", VA = "0x180890560", Slot = "76")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004355 RID: 17237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A80")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6004354")]
			[Address(RVA = "0x66B650", Offset = "0x66A850", VA = "0x18066B650", Slot = "81")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004355")]
			[Address(RVA = "0x66BDD0", Offset = "0x66AFD0", VA = "0x18066BDD0", Slot = "82")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A81")]
		public string Name
		{
			[Token(Token = "0x6004356")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004358 RID: 17240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A82")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6004357")]
			[Address(RVA = "0x66B890", Offset = "0x66AA90", VA = "0x18066B890", Slot = "93")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004358")]
			[Address(RVA = "0x66C060", Offset = "0x66B260", VA = "0x18066C060", Slot = "94")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600435A RID: 17242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A83")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6004359")]
			[Address(RVA = "0x834FF0", Offset = "0x8341F0", VA = "0x180834FF0", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600435A")]
			[Address(RVA = "0x8351C0", Offset = "0x8343C0", VA = "0x1808351C0", Slot = "96")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A84")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x600435B")]
			[Address(RVA = "0x5A44C0", Offset = "0x5A36C0", VA = "0x1805A44C0", Slot = "97")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A85")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x600435C")]
			[Address(RVA = "0x66B670", Offset = "0x66A870", VA = "0x18066B670", Slot = "98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x00012D20 File Offset: 0x00010F20
		[Token(Token = "0x17000A86")]
		public bool Selectable
		{
			[Token(Token = "0x600435D")]
			[Address(RVA = "0x895730", Offset = "0x894930", VA = "0x180895730", Slot = "99")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x00012D38 File Offset: 0x00010F38
		// (set) Token: 0x0600435F RID: 17247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A87")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x600435E")]
			[Address(RVA = "0x895720", Offset = "0x894920", VA = "0x180895720", Slot = "100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600435F")]
			[Address(RVA = "0x895740", Offset = "0x894940", VA = "0x180895740")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A88")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6004360")]
			[Address(RVA = "0x803600", Offset = "0x802800", VA = "0x180803600", Slot = "114")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06004361 RID: 17249 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004362 RID: 17250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A89")]
		protected DryingRackConfiguration stationConfiguration
		{
			[Token(Token = "0x6004361")]
			[Address(RVA = "0x803600", Offset = "0x802800", VA = "0x180803600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004362")]
			[Address(RVA = "0x8037F0", Offset = "0x8029F0", VA = "0x1808037F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A8A")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6004363")]
			[Address(RVA = "0x66B570", Offset = "0x66A770", VA = "0x18066B570", Slot = "115")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x17000A8B")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6004364")]
			[Address(RVA = "0x895710", Offset = "0x894910", VA = "0x180895710", Slot = "116")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004366 RID: 17254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8C")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6004365")]
			[Address(RVA = "0x8035E0", Offset = "0x8027E0", VA = "0x1808035E0", Slot = "117")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004366")]
			[Address(RVA = "0x8037B0", Offset = "0x8029B0", VA = "0x1808037B0", Slot = "118")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004368 RID: 17256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8D")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6004367")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0", Slot = "119")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004368")]
			[Address(RVA = "0x890270", Offset = "0x88F470", VA = "0x180890270", Slot = "120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004369")]
		[Address(RVA = "0x893AF0", Offset = "0x892CF0", VA = "0x180893AF0", Slot = "134")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A8E")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x600436A")]
			[Address(RVA = "0x8035F0", Offset = "0x8027F0", VA = "0x1808035F0", Slot = "122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x0600436B RID: 17259 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A8F")]
		public Transform Transform
		{
			[Token(Token = "0x600436B")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A90")]
		public Transform UIPoint
		{
			[Token(Token = "0x600436C")]
			[Address(RVA = "0x5A44C0", Offset = "0x5A36C0", VA = "0x1805A44C0", Slot = "124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600436D RID: 17261 RVA: 0x00012D68 File Offset: 0x00010F68
		[Token(Token = "0x17000A91")]
		public bool CanBeSelected
		{
			[Token(Token = "0x600436D")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A92")]
		public ItemSlot InputSlot
		{
			[Token(Token = "0x600436E")]
			[Address(RVA = "0x803760", Offset = "0x802960", VA = "0x180803760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600436F")]
			[Address(RVA = "0x835030", Offset = "0x834230", VA = "0x180835030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A93")]
		public ItemSlot OutputSlot
		{
			[Token(Token = "0x6004370")]
			[Address(RVA = "0x803620", Offset = "0x802820", VA = "0x180803620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004371")]
			[Address(RVA = "0x803820", Offset = "0x802A20", VA = "0x180803820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x00012D80 File Offset: 0x00010F80
		// (set) Token: 0x06004373 RID: 17267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A94")]
		public bool IsOpen
		{
			[Token(Token = "0x6004372")]
			[Address(RVA = "0x834FE0", Offset = "0x8341E0", VA = "0x180834FE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004373")]
			[Address(RVA = "0x895750", Offset = "0x894950", VA = "0x180895750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004375 RID: 17269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A95")]
		public List<DryingOperation> DryingOperations
		{
			[Token(Token = "0x6004374")]
			[Address(RVA = "0x66B540", Offset = "0x66A740", VA = "0x18066B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004375")]
			[Address(RVA = "0x66BD90", Offset = "0x66AF90", VA = "0x18066BD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x88C400", Offset = "0x88B600", VA = "0x18088C400", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x88D830", Offset = "0x88CA30", VA = "0x18088D830", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x88D290", Offset = "0x88C490", VA = "0x18088D290", Slot = "50")]
		public override string GetManagementName()
		{
			return null;
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x88E4B0", Offset = "0x88D6B0", VA = "0x18088E4B0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x893990", Offset = "0x892B90", VA = "0x180893990", Slot = "135")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x88CEF0", Offset = "0x88C0F0", VA = "0x18088CEF0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00012D98 File Offset: 0x00010F98
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x88C450", Offset = "0x88B650", VA = "0x18088C450", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437D")]
		[Address(RVA = "0x88CBC0", Offset = "0x88BDC0", VA = "0x18088CBC0", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437E")]
		[Address(RVA = "0x88E4A0", Offset = "0x88D6A0", VA = "0x18088E4A0")]
		private void OnMinPass()
		{
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437F")]
		[Address(RVA = "0x88E770", Offset = "0x88D970", VA = "0x18088E770")]
		private void OnTimePass(int minutes)
		{
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x6004380")]
		[Address(RVA = "0x88C550", Offset = "0x88B750", VA = "0x18088C550")]
		public bool CanStartOperation()
		{
			return default(bool);
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004381")]
		[Address(RVA = "0x895160", Offset = "0x894360", VA = "0x180895160")]
		public void StartOperation()
		{
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004382")]
		[Address(RVA = "0x8953D0", Offset = "0x8945D0", VA = "0x1808953D0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void TryEndOperation(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004383")]
		[Address(RVA = "0x88D2C0", Offset = "0x88C4C0", VA = "0x18088D2C0")]
		public List<DryingOperation> GetOperationsAtTargetQuality()
		{
			return null;
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x6004384")]
		[Address(RVA = "0x88D430", Offset = "0x88C630", VA = "0x18088D430")]
		public int GetOutputCapacityForOperation(DryingOperation operation, EQuality quality)
		{
			return 0;
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004385")]
		[Address(RVA = "0x892780", Offset = "0x891980", VA = "0x180892780")]
		[ServerRpc(RequireOwnership = false)]
		private void SendOperation(DryingOperation op)
		{
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004386")]
		[Address(RVA = "0x88F060", Offset = "0x88E260", VA = "0x18088F060")]
		[TargetRpc]
		[ObserversRpc]
		private void PleaseReceiveOp(NetworkConnection conn, DryingOperation op)
		{
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004387")]
		[Address(RVA = "0x88FE50", Offset = "0x88F050", VA = "0x18088FE50")]
		[ObserversRpc(RunLocally = true, ExcludeServer = true)]
		private void RemoveOperation(int opIndex)
		{
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x892160", Offset = "0x891360", VA = "0x180892160")]
		[ObserversRpc]
		private void SetOperationQuantity(int opIndex, int quantity)
		{
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x00012DE0 File Offset: 0x00010FE0
		[Token(Token = "0x6004389")]
		[Address(RVA = "0x88D5D0", Offset = "0x88C7D0", VA = "0x18088D5D0")]
		public int GetTotalDryingItems()
		{
			return 0;
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438A")]
		[Address(RVA = "0x88F550", Offset = "0x88E750", VA = "0x18088F550")]
		public void RefreshHangingVisuals()
		{
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438B")]
		[Address(RVA = "0x88F400", Offset = "0x88E600", VA = "0x18088F400")]
		private void RefreshDryingEffects()
		{
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[Token(Token = "0x600438C")]
		[Address(RVA = "0x88D210", Offset = "0x88C410", VA = "0x18088D210")]
		public float GetDryMultiplier()
		{
			return 0f;
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438D")]
		[Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		private void SetQualityEffect(int index, bool isActive, EQuality quality = EQuality.Standard)
		{
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600438E")]
		[Address(RVA = "0x88C900", Offset = "0x88BB00", VA = "0x18088C900", Slot = "128")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438F")]
		[Address(RVA = "0x88CB30", Offset = "0x88BD30", VA = "0x18088CB30", Slot = "129")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004390")]
		[Address(RVA = "0x894070", Offset = "0x893270", VA = "0x180894070", Slot = "79")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004391")]
		[Address(RVA = "0x893F40", Offset = "0x893140", VA = "0x180893F40", Slot = "80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004392")]
		[Address(RVA = "0x88D6F0", Offset = "0x88C8F0", VA = "0x18088D6F0")]
		public void Hovered()
		{
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004393")]
		[Address(RVA = "0x88DB70", Offset = "0x88CD70", VA = "0x18088DB70")]
		public void Interacted()
		{
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004394")]
		[Address(RVA = "0x88E940", Offset = "0x88DB40", VA = "0x18088E940")]
		public void Open()
		{
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004395")]
		[Address(RVA = "0x88C5C0", Offset = "0x88B7C0", VA = "0x18088C5C0")]
		public void Close()
		{
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004396")]
		[Address(RVA = "0x894FC0", Offset = "0x8941C0", VA = "0x180894FC0", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004397")]
		[Address(RVA = "0x894D00", Offset = "0x893F00", VA = "0x180894D00")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004398")]
		[Address(RVA = "0x893DD0", Offset = "0x892FD0", VA = "0x180893DD0", Slot = "84")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004399")]
		[Address(RVA = "0x893C20", Offset = "0x892E20", VA = "0x180893C20")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439A")]
		[Address(RVA = "0x894B10", Offset = "0x893D10", VA = "0x180894B10", Slot = "85")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439B")]
		[Address(RVA = "0x8947F0", Offset = "0x8939F0", VA = "0x1808947F0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439C")]
		[Address(RVA = "0x894650", Offset = "0x893850", VA = "0x180894650", Slot = "86")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439D")]
		[Address(RVA = "0x894390", Offset = "0x893590", VA = "0x180894390")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600439E")]
		[Address(RVA = "0x88CF40", Offset = "0x88C140", VA = "0x18088CF40", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600439F")]
		[Address(RVA = "0x88D520", Offset = "0x88C720", VA = "0x18088D520", Slot = "60")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x895580", Offset = "0x894780", VA = "0x180895580")]
		public DryingRack()
		{
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x88DCB0", Offset = "0x88CEB0", VA = "0x18088DCB0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x88DC20", Offset = "0x88CE20", VA = "0x18088DC20", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A3")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A4")]
		[Address(RVA = "0x8928B0", Offset = "0x891AB0", VA = "0x1808928B0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A5")]
		[Address(RVA = "0x890270", Offset = "0x88F470", VA = "0x180890270", Slot = "136")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x891480", Offset = "0x890680", VA = "0x180891480")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A7")]
		[Address(RVA = "0x893230", Offset = "0x892430", VA = "0x180893230")]
		private void RpcWriter___Server_TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A8")]
		[Address(RVA = "0x890970", Offset = "0x88FB70", VA = "0x180890970")]
		public void RpcLogic___TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A9")]
		[Address(RVA = "0x8919E0", Offset = "0x890BE0", VA = "0x1808919E0")]
		private void RpcReader___Server_TryEndOperation_4146970406(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AA")]
		[Address(RVA = "0x892780", Offset = "0x891980", VA = "0x180892780")]
		private void RpcWriter___Server_SendOperation_1307702229(DryingOperation op)
		{
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AB")]
		[Address(RVA = "0x890260", Offset = "0x88F460", VA = "0x180890260")]
		private void RpcLogic___SendOperation_1307702229(DryingOperation op)
		{
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AC")]
		[Address(RVA = "0x891430", Offset = "0x890630", VA = "0x180891430")]
		private void RpcReader___Server_SendOperation_1307702229(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AD")]
		[Address(RVA = "0x8933C0", Offset = "0x8925C0", VA = "0x1808933C0")]
		private void RpcWriter___Target_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AE")]
		[Address(RVA = "0x88FFA0", Offset = "0x88F1A0", VA = "0x18088FFA0")]
		private void RpcLogic___PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AF")]
		[Address(RVA = "0x891AE0", Offset = "0x890CE0", VA = "0x180891AE0")]
		private void RpcReader___Target_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B0")]
		[Address(RVA = "0x891D50", Offset = "0x890F50", VA = "0x180891D50")]
		private void RpcWriter___Observers_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B1")]
		[Address(RVA = "0x890F40", Offset = "0x890140", VA = "0x180890F40")]
		private void RpcReader___Observers_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B2")]
		[Address(RVA = "0x891E90", Offset = "0x891090", VA = "0x180891E90")]
		private void RpcWriter___Observers_RemoveOperation_3316948804(int opIndex)
		{
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B3")]
		[Address(RVA = "0x890100", Offset = "0x88F300", VA = "0x180890100")]
		private void RpcLogic___RemoveOperation_3316948804(int opIndex)
		{
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B4")]
		[Address(RVA = "0x890F90", Offset = "0x890190", VA = "0x180890F90")]
		private void RpcReader___Observers_RemoveOperation_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B5")]
		[Address(RVA = "0x892160", Offset = "0x891360", VA = "0x180892160")]
		private void RpcWriter___Observers_SetOperationQuantity_1692629761(int opIndex, int quantity)
		{
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B6")]
		[Address(RVA = "0x890440", Offset = "0x88F640", VA = "0x180890440")]
		private void RpcLogic___SetOperationQuantity_1692629761(int opIndex, int quantity)
		{
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B7")]
		[Address(RVA = "0x8910A0", Offset = "0x8902A0", VA = "0x1808910A0")]
		private void RpcReader___Observers_SetOperationQuantity_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B8")]
		[Address(RVA = "0x892C90", Offset = "0x891E90", VA = "0x180892C90")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B9")]
		[Address(RVA = "0x890560", Offset = "0x88F760", VA = "0x180890560", Slot = "137")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BA")]
		[Address(RVA = "0x891630", Offset = "0x890830", VA = "0x180891630")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x892B60", Offset = "0x891D60", VA = "0x180892B60")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x8903A0", Offset = "0x88F5A0", VA = "0x1808903A0", Slot = "138")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BD")]
		[Address(RVA = "0x8915B0", Offset = "0x8907B0", VA = "0x1808915B0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BE")]
		[Address(RVA = "0x8930C0", Offset = "0x8922C0", VA = "0x1808930C0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043BF")]
		[Address(RVA = "0x890830", Offset = "0x88FA30", VA = "0x180890830", Slot = "139")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C0")]
		[Address(RVA = "0x8918F0", Offset = "0x890AF0", VA = "0x1808918F0")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C1")]
		[Address(RVA = "0x892600", Offset = "0x891800", VA = "0x180892600")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C2")]
		[Address(RVA = "0x8908B0", Offset = "0x88FAB0", VA = "0x1808908B0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C3")]
		[Address(RVA = "0x8913A0", Offset = "0x8905A0", VA = "0x1808913A0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C4")]
		[Address(RVA = "0x893820", Offset = "0x892A20", VA = "0x180893820")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C5")]
		[Address(RVA = "0x891CC0", Offset = "0x890EC0", VA = "0x180891CC0")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C6")]
		[Address(RVA = "0x8929E0", Offset = "0x891BE0", VA = "0x1808929E0")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C7")]
		[Address(RVA = "0x890310", Offset = "0x88F510", VA = "0x180890310", Slot = "140")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C8")]
		[Address(RVA = "0x891500", Offset = "0x890700", VA = "0x180891500")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C9")]
		[Address(RVA = "0x891FE0", Offset = "0x8911E0", VA = "0x180891FE0")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CA")]
		[Address(RVA = "0x890320", Offset = "0x88F520", VA = "0x180890320")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CB")]
		[Address(RVA = "0x891000", Offset = "0x890200", VA = "0x180891000")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CC")]
		[Address(RVA = "0x892F30", Offset = "0x892130", VA = "0x180892F30")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CD")]
		[Address(RVA = "0x890700", Offset = "0x88F900", VA = "0x180890700", Slot = "141")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CE")]
		[Address(RVA = "0x8917A0", Offset = "0x8909A0", VA = "0x1808917A0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CF")]
		[Address(RVA = "0x893690", Offset = "0x892890", VA = "0x180893690")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D0")]
		[Address(RVA = "0x890780", Offset = "0x88F980", VA = "0x180890780")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D1")]
		[Address(RVA = "0x891BD0", Offset = "0x890DD0", VA = "0x180891BD0")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D2")]
		[Address(RVA = "0x892460", Offset = "0x891660", VA = "0x180892460")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D3")]
		[Address(RVA = "0x8912B0", Offset = "0x8904B0", VA = "0x1808912B0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D4")]
		[Address(RVA = "0x892DC0", Offset = "0x891FC0", VA = "0x180892DC0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D5")]
		[Address(RVA = "0x890600", Offset = "0x88F800", VA = "0x180890600", Slot = "142")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D6")]
		[Address(RVA = "0x8916B0", Offset = "0x8908B0", VA = "0x1808916B0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x8922E0", Offset = "0x8914E0", VA = "0x1808922E0")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x890680", Offset = "0x88F880", VA = "0x180890680")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D9")]
		[Address(RVA = "0x891220", Offset = "0x890420", VA = "0x180891220")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DA")]
		[Address(RVA = "0x893520", Offset = "0x892720", VA = "0x180893520")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DB")]
		[Address(RVA = "0x891B40", Offset = "0x890D40", VA = "0x180891B40")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060043DC RID: 17372 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060043DD RID: 17373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A96")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x60043DC")]
			[Address(RVA = "0x834F90", Offset = "0x834190", VA = "0x180834F90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043DD")]
			[Address(RVA = "0x895820", Offset = "0x894A20", VA = "0x180895820")]
			set
			{
			}
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00012E10 File Offset: 0x00011010
		[Token(Token = "0x60043DE")]
		[Address(RVA = "0x88F260", Offset = "0x88E460", VA = "0x18088F260", Slot = "143")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.DryingRack(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A97")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x60043DF")]
			[Address(RVA = "0x8036C0", Offset = "0x8028C0", VA = "0x1808036C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043E0")]
			[Address(RVA = "0x8958E0", Offset = "0x894AE0", VA = "0x1808958E0")]
			set
			{
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060043E2 RID: 17378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A98")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x60043E1")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043E2")]
			[Address(RVA = "0x895760", Offset = "0x894960", VA = "0x180895760")]
			set
			{
			}
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043E3")]
		[Address(RVA = "0x88C050", Offset = "0x88B250", VA = "0x18088C050", Slot = "144")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.DryingRack_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		public const int DRY_MINS_PER_TIER = 720;

		// Token: 0x040030A1 RID: 12449
		[Token(Token = "0x40030A1")]
		public const float MAX_DRY_MULTIPLIER = 1.5f;

		// Token: 0x040030A2 RID: 12450
		[Token(Token = "0x40030A2")]
		public const float WARMTH_MIN_THRESHOLD = 20f;

		// Token: 0x040030A3 RID: 12451
		[Token(Token = "0x40030A3")]
		public const float WARMTH_MAX_THRESHOLD = 40f;

		// Token: 0x040030A4 RID: 12452
		[Token(Token = "0x40030A4")]
		[FieldOffset(Offset = "0x210")]
		[Header("Settings")]
		public int ItemCapacity;

		// Token: 0x040030A5 RID: 12453
		[Token(Token = "0x40030A5")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public Transform[] CameraPositions;

		// Token: 0x040030A6 RID: 12454
		[Token(Token = "0x40030A6")]
		[FieldOffset(Offset = "0x220")]
		public InteractableObject IntObj;

		// Token: 0x040030A7 RID: 12455
		[Token(Token = "0x40030A7")]
		[FieldOffset(Offset = "0x228")]
		public Transform uiPoint;

		// Token: 0x040030A8 RID: 12456
		[Token(Token = "0x40030A8")]
		[FieldOffset(Offset = "0x230")]
		public Transform[] accessPoints;

		// Token: 0x040030A9 RID: 12457
		[Token(Token = "0x40030A9")]
		[FieldOffset(Offset = "0x238")]
		public StorageVisualizer InputVisuals;

		// Token: 0x040030AA RID: 12458
		[Token(Token = "0x40030AA")]
		[FieldOffset(Offset = "0x240")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x040030AB RID: 12459
		[Token(Token = "0x40030AB")]
		[FieldOffset(Offset = "0x248")]
		public StorageVisualizer HangingVisuals;

		// Token: 0x040030AC RID: 12460
		[Token(Token = "0x40030AC")]
		[FieldOffset(Offset = "0x250")]
		public Transform[] HangAlignments;

		// Token: 0x040030AD RID: 12461
		[Token(Token = "0x40030AD")]
		[FieldOffset(Offset = "0x258")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x040030AE RID: 12462
		[Token(Token = "0x40030AE")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		private Transform _qualityEffectContianer;

		// Token: 0x040030AF RID: 12463
		[Token(Token = "0x40030AF")]
		[FieldOffset(Offset = "0x268")]
		[Header("UI")]
		public DryingRackUIElement WorldspaceUIPrefab;

		// Token: 0x040030B0 RID: 12464
		[Token(Token = "0x40030B0")]
		[FieldOffset(Offset = "0x270")]
		public Sprite typeIcon;

		// Token: 0x040030B1 RID: 12465
		[Token(Token = "0x40030B1")]
		[FieldOffset(Offset = "0x278")]
		[Header("Fonts")]
		[SerializeField]
		private ColorFont _qualityColourFont;

		// Token: 0x040030C0 RID: 12480
		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0x2E8")]
		public Action<DryingOperation> onOperationStart;

		// Token: 0x040030C1 RID: 12481
		[Token(Token = "0x40030C1")]
		[FieldOffset(Offset = "0x2F0")]
		public Action<DryingOperation> onOperationComplete;

		// Token: 0x040030C2 RID: 12482
		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0x2F8")]
		public Action onOperationsChanged;

		// Token: 0x040030C3 RID: 12483
		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0x300")]
		private ItemSlot[] hangSlots;

		// Token: 0x040030C4 RID: 12484
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0x308")]
		private ParticleSystem[] _qualityParticleEffect;

		// Token: 0x040030C5 RID: 12485
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0x310")]
		private List<int> requestIDs;

		// Token: 0x040030C6 RID: 12486
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0x318")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x040030C7 RID: 12487
		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0x320")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x040030C8 RID: 12488
		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0x328")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x040030C9 RID: 12489
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0x330")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted;

		// Token: 0x040030CA RID: 12490
		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0x331")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted;
	}
}
