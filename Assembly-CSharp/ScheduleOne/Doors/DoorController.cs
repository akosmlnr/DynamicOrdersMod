using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Doors
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	public class DoorController : NetworkBehaviour
	{
		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x0000E610 File Offset: 0x0000C810
		// (set) Token: 0x06002E47 RID: 11847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BA")]
		public bool IsOpen
		{
			[Token(Token = "0x6002E46")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E47")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x0000E628 File Offset: 0x0000C828
		// (set) Token: 0x06002E49 RID: 11849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BB")]
		public bool openedByNPC
		{
			[Token(Token = "0x6002E48")]
			[Address(RVA = "0x745890", Offset = "0x744A90", VA = "0x180745890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E49")]
			[Address(RVA = "0x745900", Offset = "0x744B00", VA = "0x180745900")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x0000E640 File Offset: 0x0000C840
		// (set) Token: 0x06002E4B RID: 11851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BC")]
		public int detectedNPCCount
		{
			[Token(Token = "0x6002E4A")]
			[Address(RVA = "0x745880", Offset = "0x744A80", VA = "0x180745880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E4B")]
			[Address(RVA = "0x7458E0", Offset = "0x744AE0", VA = "0x1807458E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x0000E658 File Offset: 0x0000C858
		// (set) Token: 0x06002E4D RID: 11853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BD")]
		public float timeSinceNPCSensed
		{
			[Token(Token = "0x6002E4C")]
			[Address(RVA = "0x7458C0", Offset = "0x744AC0", VA = "0x1807458C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002E4D")]
			[Address(RVA = "0x745930", Offset = "0x744B30", VA = "0x180745930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x0000E670 File Offset: 0x0000C870
		// (set) Token: 0x06002E4F RID: 11855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BE")]
		public bool playerDetectedSinceOpened
		{
			[Token(Token = "0x6002E4E")]
			[Address(RVA = "0x7458A0", Offset = "0x744AA0", VA = "0x1807458A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E4F")]
			[Address(RVA = "0x745910", Offset = "0x744B10", VA = "0x180745910")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x0000E688 File Offset: 0x0000C888
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BF")]
		public int detectedPlayerCount
		{
			[Token(Token = "0x6002E50")]
			[Address(RVA = "0x6288F0", Offset = "0x627AF0", VA = "0x1806288F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002E51")]
			[Address(RVA = "0x7458F0", Offset = "0x744AF0", VA = "0x1807458F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C0")]
		public float timeSincePlayerSensed
		{
			[Token(Token = "0x6002E52")]
			[Address(RVA = "0x7458D0", Offset = "0x744AD0", VA = "0x1807458D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002E53")]
			[Address(RVA = "0x745940", Offset = "0x744B40", VA = "0x180745940")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C1")]
		public float timeInCurrentState
		{
			[Token(Token = "0x6002E54")]
			[Address(RVA = "0x7458B0", Offset = "0x744AB0", VA = "0x1807458B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002E55")]
			[Address(RVA = "0x745920", Offset = "0x744B20", VA = "0x180745920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E56")]
		[Address(RVA = "0x743FE0", Offset = "0x7431E0", VA = "0x180743FE0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E57")]
		[Address(RVA = "0x745550", Offset = "0x744750", VA = "0x180745550", Slot = "20")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E58")]
		[Address(RVA = "0x7456E0", Offset = "0x7448E0", VA = "0x1807456E0", Slot = "21")]
		protected virtual void Update()
		{
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E59")]
		[Address(RVA = "0x744890", Offset = "0x743A90", VA = "0x180744890", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E5A")]
		[Address(RVA = "0x744460", Offset = "0x743660", VA = "0x180744460", Slot = "22")]
		public virtual void InteriorHandleHovered()
		{
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E5B")]
		[Address(RVA = "0x7445E0", Offset = "0x7437E0", VA = "0x1807445E0", Slot = "23")]
		public virtual void InteriorHandleInteracted()
		{
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E5C")]
		[Address(RVA = "0x744200", Offset = "0x743400", VA = "0x180744200", Slot = "24")]
		public virtual void ExteriorHandleHovered()
		{
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E5D")]
		[Address(RVA = "0x744380", Offset = "0x743580", VA = "0x180744380", Slot = "25")]
		public virtual void ExteriorHandleInteracted()
		{
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		[Token(Token = "0x6002E5E")]
		[Address(RVA = "0x7440B0", Offset = "0x7432B0", VA = "0x1807440B0")]
		public bool CanPlayerAccess(EDoorSide side)
		{
			return default(bool);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		[Token(Token = "0x6002E5F")]
		[Address(RVA = "0x744030", Offset = "0x743230", VA = "0x180744030", Slot = "26")]
		protected virtual bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E60")]
		[Address(RVA = "0x7446B0", Offset = "0x7438B0", VA = "0x1807446B0", Slot = "27")]
		public virtual void NPCVicinityEnter(EDoorSide side)
		{
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E61")]
		[Address(RVA = "0x744750", Offset = "0x743950", VA = "0x180744750", Slot = "28")]
		public virtual void NPCVicinityExit(EDoorSide side)
		{
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E62")]
		[Address(RVA = "0x7448E0", Offset = "0x743AE0", VA = "0x1807448E0", Slot = "29")]
		public virtual void PlayerVicinityEnter(EDoorSide side)
		{
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E63")]
		[Address(RVA = "0x744990", Offset = "0x743B90", VA = "0x180744990", Slot = "30")]
		public virtual void PlayerVicinityExit(EDoorSide side)
		{
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E64")]
		[Address(RVA = "0x745070", Offset = "0x744270", VA = "0x180745070")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetIsOpen_Server(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E65")]
		[Address(RVA = "0x7452B0", Offset = "0x7444B0", VA = "0x1807452B0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetIsOpen(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E66")]
		[Address(RVA = "0x7451F0", Offset = "0x7443F0", VA = "0x1807451F0", Slot = "31")]
		public virtual void SetIsOpen(bool open, EDoorSide openSide)
		{
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E67")]
		[Address(RVA = "0x7440E0", Offset = "0x7432E0", VA = "0x1807440E0", Slot = "32")]
		protected virtual void CheckAutoCloseForDistantPlayer()
		{
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x7457F0", Offset = "0x7449F0", VA = "0x1807457F0")]
		public DoorController()
		{
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E6A")]
		[Address(RVA = "0x744770", Offset = "0x743970", VA = "0x180744770", Slot = "33")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E6B")]
		[Address(RVA = "0x5914E0", Offset = "0x5906E0", VA = "0x1805914E0", Slot = "34")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E6C")]
		[Address(RVA = "0x6A38B0", Offset = "0x6A2AB0", VA = "0x1806A38B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E6D")]
		[Address(RVA = "0x744DB0", Offset = "0x743FB0", VA = "0x180744DB0")]
		private void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E6E")]
		[Address(RVA = "0x7449D0", Offset = "0x743BD0", VA = "0x1807449D0")]
		public void RpcLogic___SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x744AA0", Offset = "0x743CA0", VA = "0x180744AA0")]
		private void RpcReader___Server_SetIsOpen_Server_1319291243(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x744C40", Offset = "0x743E40", VA = "0x180744C40")]
		private void RpcWriter___Observers_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E71")]
		[Address(RVA = "0x7449B0", Offset = "0x743BB0", VA = "0x1807449B0")]
		public void RpcLogic___SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E72")]
		[Address(RVA = "0x744A00", Offset = "0x743C00", VA = "0x180744A00")]
		private void RpcReader___Observers_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E73")]
		[Address(RVA = "0x744F10", Offset = "0x744110", VA = "0x180744F10")]
		private void RpcWriter___Target_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E74")]
		[Address(RVA = "0x744BA0", Offset = "0x743DA0", VA = "0x180744BA0")]
		private void RpcReader___Target_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E75")]
		[Address(RVA = "0x743CB0", Offset = "0x742EB0", VA = "0x180743CB0", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.Doors.DoorController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002247 RID: 8775
		[Token(Token = "0x4002247")]
		public const float DISTANT_PLAYER_THRESHOLD = 40f;

		// Token: 0x04002249 RID: 8777
		[Token(Token = "0x4002249")]
		[FieldOffset(Offset = "0x11C")]
		public EDoorAccess PlayerAccess;

		// Token: 0x0400224A RID: 8778
		[Token(Token = "0x400224A")]
		[FieldOffset(Offset = "0x120")]
		public bool AutoOpenForPlayer;

		// Token: 0x0400224B RID: 8779
		[Token(Token = "0x400224B")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Header("References")]
		protected InteractableObject[] InteriorIntObjs;

		// Token: 0x0400224C RID: 8780
		[Token(Token = "0x400224C")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected InteractableObject[] ExteriorIntObjs;

		// Token: 0x0400224D RID: 8781
		[Token(Token = "0x400224D")]
		[FieldOffset(Offset = "0x138")]
		[Tooltip("Used to block player from entering when the door is open for an NPC, but player isn't permitted access.")]
		[SerializeField]
		protected BoxCollider PlayerBlocker;

		// Token: 0x0400224E RID: 8782
		[Token(Token = "0x400224E")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Header("Animation")]
		protected Animation InteriorDoorHandleAnimation;

		// Token: 0x0400224F RID: 8783
		[Token(Token = "0x400224F")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected Animation ExteriorDoorHandleAnimation;

		// Token: 0x04002250 RID: 8784
		[Token(Token = "0x4002250")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Header("Settings")]
		protected bool AutoCloseOnSleep;

		// Token: 0x04002251 RID: 8785
		[Token(Token = "0x4002251")]
		[FieldOffset(Offset = "0x151")]
		[SerializeField]
		protected bool AutoCloseOnDistantPlayer;

		// Token: 0x04002252 RID: 8786
		[Token(Token = "0x4002252")]
		[FieldOffset(Offset = "0x152")]
		[SerializeField]
		[Header("NPC Access")]
		protected bool OpenableByNPCs;

		// Token: 0x04002253 RID: 8787
		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		[Tooltip("How many seconds to wait after NPC passes through to return to original state")]
		protected float ReturnToOriginalTime;

		// Token: 0x04002254 RID: 8788
		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent<EDoorSide> onDoorOpened;

		// Token: 0x04002255 RID: 8789
		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent onDoorClosed;

		// Token: 0x04002256 RID: 8790
		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x168")]
		private EDoorSide lastOpenSide;

		// Token: 0x0400225A RID: 8794
		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x178")]
		private bool autoOpenedForPlayer;

		// Token: 0x0400225F RID: 8799
		[Token(Token = "0x400225F")]
		[FieldOffset(Offset = "0x188")]
		[HideInInspector]
		public string noAccessErrorMessage;

		// Token: 0x04002260 RID: 8800
		[Token(Token = "0x4002260")]
		[FieldOffset(Offset = "0x190")]
		private bool NetworkInitialize___EarlyScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002261 RID: 8801
		[Token(Token = "0x4002261")]
		[FieldOffset(Offset = "0x191")]
		private bool NetworkInitialize__LateScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted;
	}
}
