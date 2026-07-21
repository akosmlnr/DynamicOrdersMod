using System;
using System.Threading;
using Il2CppDummyDll;
using Steamworks;

namespace FishySteamworks.Client
{
	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	public class ClientSocket : CommonSocket
	{
		// Token: 0x06000B6F RID: 2927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x9F0A30", Offset = "0x9EFC30", VA = "0x1809F0A30")]
		private void CheckTimeout()
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00006D38 File Offset: 0x00004F38
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x9F1270", Offset = "0x9F0470", VA = "0x1809F1270")]
		internal bool StartConnection(string address, ushort port, bool peerToPeer)
		{
			return default(bool);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x9F0DB0", Offset = "0x9EFFB0", VA = "0x1809F0DB0")]
		private void OnLocalConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00006D50 File Offset: 0x00004F50
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x9F1650", Offset = "0x9F0850", VA = "0x1809F1650")]
		internal bool StopConnection()
		{
			return default(bool);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x9F0B10", Offset = "0x9EFD10", VA = "0x1809F0B10")]
		internal void IterateIncoming()
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x9F1130", Offset = "0x9F0330", VA = "0x1809F1130")]
		internal void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x9F0D90", Offset = "0x9EFF90", VA = "0x1809F0D90")]
		internal void IterateOutgoing()
		{
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x9F1850", Offset = "0x9F0A50", VA = "0x1809F1850")]
		public ClientSocket()
		{
		}

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x30")]
		private Callback<SteamNetConnectionStatusChangedCallback_t> _onLocalConnectionStateCallback;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x38")]
		private CSteamID _hostSteamID;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		[FieldOffset(Offset = "0x40")]
		private HSteamNetConnection _socket;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x48")]
		private Thread _timeoutThread;

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0x50")]
		private float _connectTimeout;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		private const float CONNECT_TIMEOUT_DURATION = 8000f;
	}
}
