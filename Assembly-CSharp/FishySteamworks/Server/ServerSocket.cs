using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Transporting;
using FishySteamworks.Client;
using Il2CppDummyDll;
using Steamworks;

namespace FishySteamworks.Server
{
	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000207")]
	public class ServerSocket : CommonSocket
	{
		// Token: 0x06000B50 RID: 2896 RVA: 0x00006C60 File Offset: 0x00004E60
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x9FD930", Offset = "0x9FCB30", VA = "0x1809FD930")]
		internal RemoteConnectionState GetConnectionState(int connectionId)
		{
			return RemoteConnectionState.Stopped;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x9FEF50", Offset = "0x9FE150", VA = "0x1809FEF50")]
		internal void ResetInvalidSocket()
		{
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00006C78 File Offset: 0x00004E78
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x9FF340", Offset = "0x9FE540", VA = "0x1809FF340")]
		internal bool StartConnection(string address, ushort port, int maximumClients, bool peerToPeer)
		{
			return default(bool);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x9FF7E0", Offset = "0x9FE9E0", VA = "0x1809FF7E0")]
		internal bool StopConnection()
		{
			return default(bool);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x9FF6A0", Offset = "0x9FE8A0", VA = "0x1809FF6A0")]
		internal bool StopConnection(int connectionId)
		{
			return default(bool);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x9FF9B0", Offset = "0x9FEBB0", VA = "0x1809FF9B0")]
		private bool StopConnection(int connectionId, HSteamNetConnection socket)
		{
			return default(bool);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x9FE260", Offset = "0x9FD460", VA = "0x1809FE260")]
		[MethodImpl(256)]
		private void OnRemoteConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x9FD680", Offset = "0x9FC880", VA = "0x1809FD680")]
		private void AddConnection(int connectionId, HSteamNetConnection steamConnection, CSteamID steamId)
		{
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x9FEDE0", Offset = "0x9FDFE0", VA = "0x1809FEDE0")]
		private void RemoveConnection(int connectionId)
		{
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x9FDDE0", Offset = "0x9FCFE0", VA = "0x1809FDDE0")]
		internal void IterateOutgoing()
		{
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x9FD9A0", Offset = "0x9FCBA0", VA = "0x1809FD9A0")]
		internal void IterateIncoming()
		{
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x9FEBB0", Offset = "0x9FDDB0", VA = "0x1809FEBB0")]
		private void ProcessPendingConnectionChanges()
		{
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x9FF010", Offset = "0x9FE210", VA = "0x1809FF010")]
		internal void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x9FD800", Offset = "0x9FCA00", VA = "0x1809FD800")]
		internal string GetConnectionAddress(int connectionId)
		{
			return null;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x9FF2E0", Offset = "0x9FE4E0", VA = "0x1809FF2E0")]
		internal void SetMaximumClients(int value)
		{
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x4B4460", Offset = "0x4B3660", VA = "0x1804B4460")]
		internal int GetMaximumClients()
		{
			return 0;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
		internal void SetClientHostSocket(ClientHostSocket socket)
		{
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x9FDFE0", Offset = "0x9FD1E0", VA = "0x1809FDFE0")]
		internal void OnClientHostState(bool started)
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x9FED70", Offset = "0x9FDF70", VA = "0x1809FED70")]
		internal void ReceivedFromClientHost(LocalPacket packet)
		{
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x9FFB60", Offset = "0x9FED60", VA = "0x1809FFB60")]
		public ServerSocket()
		{
		}

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x30")]
		private BidirectionalDictionary<HSteamNetConnection, int> _steamConnections;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x38")]
		private BidirectionalDictionary<CSteamID, int> _steamIds;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x40")]
		private int _maximumClients;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x44")]
		private int _nextConnectionId;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x48")]
		private HSteamListenSocket _socket;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x50")]
		private Queue<LocalPacket> _clientHostIncoming;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x58")]
		private bool _clientHostStarted;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x60")]
		private Callback<SteamNetConnectionStatusChangedCallback_t> _onRemoteConnectionStateCallback;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x68")]
		private Queue<int> _cachedConnectionIds;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x70")]
		private ClientHostSocket _clientHost;

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x78")]
		private bool _iteratingConnections;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x80")]
		private List<ServerSocket.ConnectionChange> _pendingConnectionChanges;

		// Token: 0x02000208 RID: 520
		[Token(Token = "0x2000208")]
		public struct ConnectionChange
		{
			// Token: 0x1700025A RID: 602
			// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00006CF0 File Offset: 0x00004EF0
			[Token(Token = "0x1700025A")]
			public bool IsConnect
			{
				[Token(Token = "0x6000B64")]
				[Address(RVA = "0x9F22A0", Offset = "0x9F14A0", VA = "0x1809F22A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x9F2220", Offset = "0x9F1420", VA = "0x1809F2220")]
			public ConnectionChange(int id)
			{
			}

			// Token: 0x06000B66 RID: 2918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x9F2290", Offset = "0x9F1490", VA = "0x1809F2290")]
			public ConnectionChange(int id, HSteamNetConnection steamConnection, CSteamID steamId)
			{
			}

			// Token: 0x04000BD1 RID: 3025
			[Token(Token = "0x4000BD1")]
			[FieldOffset(Offset = "0x0")]
			public int ConnectionId;

			// Token: 0x04000BD2 RID: 3026
			[Token(Token = "0x4000BD2")]
			[FieldOffset(Offset = "0x4")]
			public HSteamNetConnection SteamConnection;

			// Token: 0x04000BD3 RID: 3027
			[Token(Token = "0x4000BD3")]
			[FieldOffset(Offset = "0x8")]
			public CSteamID SteamId;
		}
	}
}
