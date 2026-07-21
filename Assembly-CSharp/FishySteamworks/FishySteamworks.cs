using System;
using System.Runtime.CompilerServices;
using FishNet.Managing;
using FishNet.Transporting;
using FishySteamworks.Client;
using FishySteamworks.Server;
using Il2CppDummyDll;
using UnityEngine;

namespace FishySteamworks
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	public class FishySteamworks : Transport
	{
		// Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x9F50D0", Offset = "0x9F42D0", VA = "0x1809F50D0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x9F5560", Offset = "0x9F4760", VA = "0x1809F5560", Slot = "4")]
		public override void Initialize(NetworkManager networkManager, int transportIndex)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x9F5C90", Offset = "0x9F4E90", VA = "0x1809F5C90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x9F6860", Offset = "0x9F5A60", VA = "0x1809F6860")]
		private void Update()
		{
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x9F5050", Offset = "0x9F4250", VA = "0x1809F5050")]
		private void CreateChannelData()
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x9F5520", Offset = "0x9F4720", VA = "0x1809F5520")]
		private bool InitializeRelayNetworkAccess()
		{
			return default(bool);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x9F5A00", Offset = "0x9F4C00", VA = "0x1809F5A00")]
		public bool IsNetworkAccessAvailable()
		{
			return default(bool);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x9F5140", Offset = "0x9F4340", VA = "0x1809F5140", Slot = "5")]
		public override string GetConnectionAddress(int connectionId)
		{
			return null;
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000B2B RID: 2859 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		public override event Action<ClientConnectionStateArgs> OnClientConnectionState
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x9F6930", Offset = "0x9F5B30", VA = "0x1809F6930", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x9F6CE0", Offset = "0x9F5EE0", VA = "0x1809F6CE0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B2E RID: 2862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		public override event Action<ServerConnectionStateArgs> OnServerConnectionState
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x9F6B60", Offset = "0x9F5D60", VA = "0x1809F6B60", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x9F6F10", Offset = "0x9F6110", VA = "0x1809F6F10", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000B2F RID: 2863 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public override event Action<RemoteConnectionStateArgs> OnRemoteConnectionState
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x9F6AA0", Offset = "0x9F5CA0", VA = "0x1809F6AA0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x9F6E50", Offset = "0x9F6050", VA = "0x1809F6E50", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x9F52F0", Offset = "0x9F44F0", VA = "0x1809F52F0", Slot = "15")]
		public override LocalConnectionState GetConnectionState(bool server)
		{
			return LocalConnectionState.Stopped;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x9F5280", Offset = "0x9F4480", VA = "0x1809F5280", Slot = "16")]
		public override RemoteConnectionState GetConnectionState(int connectionId)
		{
			return RemoteConnectionState.Stopped;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x9F5410", Offset = "0x9F4610", VA = "0x1809F5410", Slot = "12")]
		public override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs)
		{
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x9F54B0", Offset = "0x9F46B0", VA = "0x1809F54B0", Slot = "13")]
		public override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs)
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x9F5470", Offset = "0x9F4670", VA = "0x1809F5470", Slot = "14")]
		public override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs)
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x9F5A20", Offset = "0x9F4C20", VA = "0x1809F5A20", Slot = "25")]
		public override void IterateIncoming(bool server)
		{
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x9F5C40", Offset = "0x9F4E40", VA = "0x1809F5C40", Slot = "26")]
		public override void IterateOutgoing(bool server)
		{
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B39 RID: 2873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public override event Action<ClientReceivedDataArgs> OnClientReceivedData
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x9F69E0", Offset = "0x9F5BE0", VA = "0x1809F69E0", Slot = "19")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x9F5430", Offset = "0x9F4630", VA = "0x1809F5430", Slot = "21")]
		public override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs)
		{
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B3C RID: 2876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000B")]
		public override event Action<ServerReceivedDataArgs> OnServerReceivedData
		{
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x9F6C20", Offset = "0x9F5E20", VA = "0x1809F6C20", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x9F6FD0", Offset = "0x9F61D0", VA = "0x1809F6FD0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x9F54D0", Offset = "0x9F46D0", VA = "0x1809F54D0", Slot = "24")]
		public override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs)
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x9F5CF0", Offset = "0x9F4EF0", VA = "0x1809F5CF0", Slot = "17")]
		public override void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x9F5CB0", Offset = "0x9F4EB0", VA = "0x1809F5CB0", Slot = "18")]
		public override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x9F53F0", Offset = "0x9F45F0", VA = "0x1809F53F0", Slot = "30")]
		public override int GetMaximumClients()
		{
			return 0;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x9F5FF0", Offset = "0x9F51F0", VA = "0x1809F5FF0", Slot = "31")]
		public override void SetMaximumClients(int value)
		{
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0", Slot = "32")]
		public override void SetClientAddress(string address)
		{
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470", Slot = "34")]
		public override void SetServerBindAddress(string address, IPAddressType addressType)
		{
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x9F6060", Offset = "0x9F5260", VA = "0x1809F6060", Slot = "36")]
		public override void SetPort(ushort port)
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x9F6290", Offset = "0x9F5490", VA = "0x1809F6290", Slot = "38")]
		public override bool StartConnection(bool server)
		{
			return default(bool);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x9F6680", Offset = "0x9F5880", VA = "0x1809F6680", Slot = "39")]
		public override bool StopConnection(bool server)
		{
			return default(bool);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x9F66F0", Offset = "0x9F58F0", VA = "0x1809F66F0", Slot = "40")]
		public override bool StopConnection(int connectionId, bool immediately)
		{
			return default(bool);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x9F6070", Offset = "0x9F5270", VA = "0x1809F6070", Slot = "41")]
		public override void Shutdown()
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x9F62B0", Offset = "0x9F54B0", VA = "0x1809F62B0")]
		private bool StartServer()
		{
			return default(bool);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x9F6840", Offset = "0x9F5A40", VA = "0x1809F6840")]
		private bool StopServer()
		{
			return default(bool);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x9F60C0", Offset = "0x9F52C0", VA = "0x1809F60C0")]
		private bool StartClient(string address)
		{
			return default(bool);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x9F6620", Offset = "0x9F5820", VA = "0x1809F6620")]
		private bool StopClient()
		{
			return default(bool);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00006C30 File Offset: 0x00004E30
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x9F64D0", Offset = "0x9F56D0", VA = "0x1809F64D0")]
		private bool StopClient(int connectionId, bool immediately)
		{
			return default(bool);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00006C48 File Offset: 0x00004E48
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x9F5320", Offset = "0x9F4520", VA = "0x1809F5320", Slot = "42")]
		public override int GetMTU(byte channel)
		{
			return 0;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x9F68B0", Offset = "0x9F5AB0", VA = "0x1809F68B0")]
		public FishySteamworks()
		{
		}

		// Token: 0x04000BB4 RID: 2996
		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public ulong LocalUserSteamID;

		// Token: 0x04000BB5 RID: 2997
		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Address server should bind to.")]
		[SerializeField]
		private string _serverBindAddress;

		// Token: 0x04000BB6 RID: 2998
		[Token(Token = "0x4000BB6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Port to use.")]
		private ushort _port;

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0x42")]
		[SerializeField]
		[Tooltip("Maximum number of players which may be connected at once.")]
		[Range(1f, 65535f)]
		private ushort _maximumClients;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("True if using peer to peer socket.")]
		[SerializeField]
		private bool _peerToPeer;

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Address client should connect to.")]
		private string _clientAddress;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x50")]
		private int[] _mtus;

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		[FieldOffset(Offset = "0x58")]
		private ClientSocket _client;

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4000BBC")]
		[FieldOffset(Offset = "0x60")]
		private ClientHostSocket _clientHost;

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x68")]
		private ServerSocket _server;

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x70")]
		private bool _shutdownCalled;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		internal const int CLIENT_HOST_ID = 32767;
	}
}
