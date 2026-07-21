using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Networking
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	public class ReplicationQueue : NetworkSingleton<ReplicationQueue>
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0000A428 File Offset: 0x00008628
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000515")]
		public bool ReplicationDoneForLocalPlayer
		{
			[Token(Token = "0x6001B97")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B98")]
			[Address(RVA = "0x5A4550", Offset = "0x5A3750", VA = "0x1805A4550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x17000516")]
		public bool LocalPlayerReplicationTimedOut
		{
			[Token(Token = "0x6001B99")]
			[Address(RVA = "0x617C80", Offset = "0x616E80", VA = "0x180617C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000517")]
		public string CurrentReplicationTask
		{
			[Token(Token = "0x6001B9A")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B9B")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x616F70", Offset = "0x616170", VA = "0x180616F70")]
		public static void Enqueue(string taskName, NetworkConnection target, Action<NetworkConnection> callback, int approximateSizeBytes = 32)
		{
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x617030", Offset = "0x616230", VA = "0x180617030")]
		public static float GetReplicationDuration(int approximateSizeBytes)
		{
			return 0f;
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x617510", Offset = "0x616710", VA = "0x180617510", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x6174E0", Offset = "0x6166E0", VA = "0x1806174E0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x6173D0", Offset = "0x6165D0", VA = "0x1806173D0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x617600", Offset = "0x616800", VA = "0x180617600")]
		[TargetRpc]
		private void SetReplicationDone(NetworkConnection conn)
		{
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x617730", Offset = "0x616930", VA = "0x180617730")]
		[TargetRpc]
		private void SetReplicationTask(NetworkConnection conn, string task)
		{
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x616D10", Offset = "0x615F10", VA = "0x180616D10")]
		private void Enqueue_(string taskName, NetworkConnection target, Action<NetworkConnection> callback, int approximateSizeBytes = 32)
		{
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x617890", Offset = "0x616A90", VA = "0x180617890")]
		private void Update()
		{
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x617240", Offset = "0x616440", VA = "0x180617240")]
		private void NotifyActiveReplicationTask(ReplicationQueue.ReplicationRequest request)
		{
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x617040", Offset = "0x616240", VA = "0x180617040")]
		public List<ReplicationQueue.ReplicationRequest> GetRequestsForConnection(NetworkConnection conn)
		{
			return null;
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x617B60", Offset = "0x616D60", VA = "0x180617B60")]
		public ReplicationQueue()
		{
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x617150", Offset = "0x616350", VA = "0x180617150", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x617100", Offset = "0x616300", VA = "0x180617100", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x617600", Offset = "0x616800", VA = "0x180617600")]
		private void RpcWriter___Target_SetReplicationDone_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x617530", Offset = "0x616730", VA = "0x180617530")]
		private void RpcLogic___SetReplicationDone_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x617560", Offset = "0x616760", VA = "0x180617560")]
		private void RpcReader___Target_SetReplicationDone_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x617730", Offset = "0x616930", VA = "0x180617730")]
		private void RpcWriter___Target_SetReplicationTask_2971853958(NetworkConnection conn, string task)
		{
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x617540", Offset = "0x616740", VA = "0x180617540")]
		private void RpcLogic___SetReplicationTask_2971853958(NetworkConnection conn, string task)
		{
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x617590", Offset = "0x616790", VA = "0x180617590")]
		private void RpcReader___Target_SetReplicationTask_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x616CA0", Offset = "0x615EA0", VA = "0x180616CA0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040017BE RID: 6078
		[Token(Token = "0x40017BE")]
		public const int RATE_LIMIT_BYTES_PER_SECOND = 51200;

		// Token: 0x040017BF RID: 6079
		[Token(Token = "0x40017BF")]
		public const int MAX_REPLICATION_DURATION = 45;

		// Token: 0x040017C2 RID: 6082
		[Token(Token = "0x40017C2")]
		[FieldOffset(Offset = "0x130")]
		private Dictionary<NetworkConnection, List<ReplicationQueue.ReplicationRequest>> requestsByConnection;

		// Token: 0x040017C3 RID: 6083
		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x138")]
		private List<ReplicationQueue.ReplicationRequest> queue;

		// Token: 0x040017C4 RID: 6084
		[Token(Token = "0x40017C4")]
		[FieldOffset(Offset = "0x140")]
		private int currentByteBudget;

		// Token: 0x040017C5 RID: 6085
		[Token(Token = "0x40017C5")]
		[FieldOffset(Offset = "0x144")]
		private float timeOnLastReplicationTaskRPC;

		// Token: 0x040017C6 RID: 6086
		[Token(Token = "0x40017C6")]
		[FieldOffset(Offset = "0x148")]
		private float timeOnReplicationStart;

		// Token: 0x040017C7 RID: 6087
		[Token(Token = "0x40017C7")]
		[FieldOffset(Offset = "0x14C")]
		private bool NetworkInitialize___EarlyScheduleOne.Networking.ReplicationQueueAssembly-CSharp.dll_Excuted;

		// Token: 0x040017C8 RID: 6088
		[Token(Token = "0x40017C8")]
		[FieldOffset(Offset = "0x14D")]
		private bool NetworkInitialize__LateScheduleOne.Networking.ReplicationQueueAssembly-CSharp.dll_Excuted;

		// Token: 0x020004FE RID: 1278
		[Token(Token = "0x20004FE")]
		public class ReplicationRequest
		{
			// Token: 0x06001BB2 RID: 7090 RVA: 0x0000A470 File Offset: 0x00008670
			[Token(Token = "0x6001BB2")]
			[Address(RVA = "0x617CC0", Offset = "0x616EC0", VA = "0x180617CC0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x06001BB3 RID: 7091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001BB3")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ReplicationRequest()
			{
			}

			// Token: 0x040017C9 RID: 6089
			[Token(Token = "0x40017C9")]
			[FieldOffset(Offset = "0x10")]
			public string TaskName;

			// Token: 0x040017CA RID: 6090
			[Token(Token = "0x40017CA")]
			[FieldOffset(Offset = "0x18")]
			public NetworkConnection Target;

			// Token: 0x040017CB RID: 6091
			[Token(Token = "0x40017CB")]
			[FieldOffset(Offset = "0x20")]
			public Action<NetworkConnection> Callback;

			// Token: 0x040017CC RID: 6092
			[Token(Token = "0x40017CC")]
			[FieldOffset(Offset = "0x28")]
			public int ApproximateSizeBytes;
		}
	}
}
