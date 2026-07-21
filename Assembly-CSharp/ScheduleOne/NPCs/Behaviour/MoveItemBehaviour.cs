using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AF4 RID: 2804
	[Token(Token = "0x2000AF4")]
	public class MoveItemBehaviour : Behaviour
	{
		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x00015648 File Offset: 0x00013848
		// (set) Token: 0x060051B9 RID: 20921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C43")]
		public bool Initialized
		{
			[Token(Token = "0x60051B8")]
			[Address(RVA = "0x6782D0", Offset = "0x6774D0", VA = "0x1806782D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051B9")]
			[Address(RVA = "0x6783C0", Offset = "0x6775C0", VA = "0x1806783C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BA")]
		[Address(RVA = "0x953510", Offset = "0x952710", VA = "0x180953510")]
		public void Initialize(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1, bool _skipPickup = false)
		{
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BB")]
		[Address(RVA = "0x954AB0", Offset = "0x953CB0", VA = "0x180954AB0")]
		public void Resume(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1)
		{
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BC")]
		[Address(RVA = "0x952B90", Offset = "0x951D90", VA = "0x180952B90", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BD")]
		[Address(RVA = "0x954970", Offset = "0x953B70", VA = "0x180954970", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BE")]
		[Address(RVA = "0x954A90", Offset = "0x953C90", VA = "0x180954A90", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BF")]
		[Address(RVA = "0x952D10", Offset = "0x951F10", VA = "0x180952D10", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C0")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C1")]
		[Address(RVA = "0x954B10", Offset = "0x953D10", VA = "0x180954B10")]
		private void StartTransit()
		{
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x00015660 File Offset: 0x00013860
		[Token(Token = "0x60051C2")]
		[Address(RVA = "0x953D80", Offset = "0x952F80", VA = "0x180953D80")]
		private bool IsNpcInventoryItemValid(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C3")]
		[Address(RVA = "0x952E30", Offset = "0x952030", VA = "0x180952E30")]
		private void EndTransit()
		{
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C4")]
		[Address(RVA = "0x954490", Offset = "0x953690", VA = "0x180954490", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C5")]
		[Address(RVA = "0x955510", Offset = "0x954710", VA = "0x180955510")]
		public void WalkToSource()
		{
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C6")]
		[Address(RVA = "0x953410", Offset = "0x952610", VA = "0x180953410")]
		public void GrabItem()
		{
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C7")]
		[Address(RVA = "0x954DE0", Offset = "0x953FE0", VA = "0x180954DE0")]
		private void TakeItem()
		{
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C8")]
		[Address(RVA = "0x9552F0", Offset = "0x9544F0", VA = "0x1809552F0")]
		public void WalkToDestination()
		{
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C9")]
		[Address(RVA = "0x954990", Offset = "0x953B90", VA = "0x180954990")]
		public void PlaceItem()
		{
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x00015678 File Offset: 0x00013878
		[Token(Token = "0x60051CA")]
		[Address(RVA = "0x952F40", Offset = "0x952140", VA = "0x180952F40")]
		private int GetAmountToGrab()
		{
			return 0;
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CB")]
		[Address(RVA = "0x954D50", Offset = "0x953F50", VA = "0x180954D50")]
		private void StopCurrentActivity()
		{
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x60051CC")]
		[Address(RVA = "0x953E10", Offset = "0x953010", VA = "0x180953E10")]
		public bool IsTransitRouteValid(TransitRoute route, string itemID, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x000156A8 File Offset: 0x000138A8
		[Token(Token = "0x60051CD")]
		[Address(RVA = "0x954090", Offset = "0x953290", VA = "0x180954090")]
		public bool IsTransitRouteValid(TransitRoute route, ItemInstance templateItem, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x000156C0 File Offset: 0x000138C0
		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x954070", Offset = "0x953270", VA = "0x180954070")]
		public bool IsTransitRouteValid(TransitRoute route, string itemID)
		{
			return default(bool);
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x000156D8 File Offset: 0x000138D8
		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x953B10", Offset = "0x952D10", VA = "0x180953B10")]
		public bool IsDestinationValid(TransitRoute route, ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x000156F0 File Offset: 0x000138F0
		[Token(Token = "0x60051D0")]
		[Address(RVA = "0x953B30", Offset = "0x952D30", VA = "0x180953B30")]
		public bool IsDestinationValid(TransitRoute route, ItemInstance item, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x00015708 File Offset: 0x00013908
		[Token(Token = "0x60051D1")]
		[Address(RVA = "0x952C20", Offset = "0x951E20", VA = "0x180952C20")]
		public bool CanGetToSource(TransitRoute route)
		{
			return default(bool);
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051D2")]
		[Address(RVA = "0x953350", Offset = "0x952550", VA = "0x180953350")]
		private Transform GetSourceAccessPoint(TransitRoute route)
		{
			return null;
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x00015720 File Offset: 0x00013920
		[Token(Token = "0x60051D3")]
		[Address(RVA = "0x953A80", Offset = "0x952C80", VA = "0x180953A80")]
		private bool IsAtSource()
		{
			return default(bool);
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x60051D4")]
		[Address(RVA = "0x952BB0", Offset = "0x951DB0", VA = "0x180952BB0")]
		public bool CanGetToDestination(TransitRoute route)
		{
			return default(bool);
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051D5")]
		[Address(RVA = "0x953040", Offset = "0x952240", VA = "0x180953040")]
		private Transform GetDestinationAccessPoint(TransitRoute route)
		{
			return null;
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x60051D6")]
		[Address(RVA = "0x9537F0", Offset = "0x9529F0", VA = "0x1809537F0")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x953150", Offset = "0x952350", VA = "0x180953150")]
		public MoveItemData GetSaveData()
		{
			return null;
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D8")]
		[Address(RVA = "0x9541F0", Offset = "0x9533F0", VA = "0x1809541F0")]
		public void Load(MoveItemData moveItemData)
		{
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D9")]
		[Address(RVA = "0x955780", Offset = "0x954980", VA = "0x180955780")]
		public MoveItemBehaviour()
		{
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051DA")]
		[Address(RVA = "0x955280", Offset = "0x954480", VA = "0x180955280")]
		[CompilerGenerated]
		private IEnumerator <WalkToSource>g__Routine|26_0()
		{
			return null;
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051DC")]
		[Address(RVA = "0x955100", Offset = "0x954300", VA = "0x180955100")]
		[CompilerGenerated]
		private IEnumerator <GrabItem>g__Routine|27_0()
		{
			return null;
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x955210", Offset = "0x954410", VA = "0x180955210")]
		[CompilerGenerated]
		private IEnumerator <WalkToDestination>g__Routine|29_0()
		{
			return null;
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x955170", Offset = "0x954370", VA = "0x180955170")]
		[CompilerGenerated]
		private IEnumerator <PlaceItem>g__Routine|30_0()
		{
			return null;
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x954470", Offset = "0x953670", VA = "0x180954470", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x954450", Offset = "0x953650", VA = "0x180954450", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x040037F0 RID: 14320
		[Token(Token = "0x40037F0")]
		[FieldOffset(Offset = "0x170")]
		private TransitRoute assignedRoute;

		// Token: 0x040037F1 RID: 14321
		[Token(Token = "0x40037F1")]
		[FieldOffset(Offset = "0x178")]
		private ItemInstance itemToRetrieveTemplate;

		// Token: 0x040037F2 RID: 14322
		[Token(Token = "0x40037F2")]
		[FieldOffset(Offset = "0x180")]
		private int grabbedAmount;

		// Token: 0x040037F3 RID: 14323
		[Token(Token = "0x40037F3")]
		[FieldOffset(Offset = "0x184")]
		private int maxMoveAmount;

		// Token: 0x040037F4 RID: 14324
		[Token(Token = "0x40037F4")]
		[FieldOffset(Offset = "0x188")]
		private MoveItemBehaviour.EState currentState;

		// Token: 0x040037F5 RID: 14325
		[Token(Token = "0x40037F5")]
		[FieldOffset(Offset = "0x190")]
		private Coroutine walkToSourceRoutine;

		// Token: 0x040037F6 RID: 14326
		[Token(Token = "0x40037F6")]
		[FieldOffset(Offset = "0x198")]
		private Coroutine grabRoutine;

		// Token: 0x040037F7 RID: 14327
		[Token(Token = "0x40037F7")]
		[FieldOffset(Offset = "0x1A0")]
		private Coroutine walkToDestinationRoutine;

		// Token: 0x040037F8 RID: 14328
		[Token(Token = "0x40037F8")]
		[FieldOffset(Offset = "0x1A8")]
		private Coroutine placingRoutine;

		// Token: 0x040037F9 RID: 14329
		[Token(Token = "0x40037F9")]
		[FieldOffset(Offset = "0x1B0")]
		private bool skipPickup;

		// Token: 0x040037FA RID: 14330
		[Token(Token = "0x40037FA")]
		[FieldOffset(Offset = "0x1B1")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040037FB RID: 14331
		[Token(Token = "0x40037FB")]
		[FieldOffset(Offset = "0x1B2")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x02000AF5 RID: 2805
		[Token(Token = "0x2000AF5")]
		public enum EState
		{
			// Token: 0x040037FD RID: 14333
			[Token(Token = "0x40037FD")]
			Idle,
			// Token: 0x040037FE RID: 14334
			[Token(Token = "0x40037FE")]
			WalkingToSource,
			// Token: 0x040037FF RID: 14335
			[Token(Token = "0x40037FF")]
			Grabbing,
			// Token: 0x04003800 RID: 14336
			[Token(Token = "0x4003800")]
			WalkingToDestination,
			// Token: 0x04003801 RID: 14337
			[Token(Token = "0x4003801")]
			Placing
		}
	}
}
