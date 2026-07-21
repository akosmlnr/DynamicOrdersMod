using System;
using System.Collections.Generic;
using FishNet.Transporting;
using FishySteamworks.Server;
using Il2CppDummyDll;

namespace FishySteamworks.Client
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	public class ClientHostSocket : CommonSocket
	{
		// Token: 0x06000B67 RID: 2919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x9F0340", Offset = "0x9EF540", VA = "0x1809F0340")]
		internal void CheckSetStarted()
		{
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x9F07F0", Offset = "0x9EF9F0", VA = "0x1809F07F0")]
		internal bool StartConnection(ServerSocket serverSocket)
		{
			return default(bool);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790", Slot = "4")]
		protected override void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00006D20 File Offset: 0x00004F20
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x9F0860", Offset = "0x9EFA60", VA = "0x1809F0860")]
		internal bool StopConnection()
		{
			return default(bool);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x9F0380", Offset = "0x9EF580", VA = "0x1809F0380")]
		internal void IterateIncoming()
		{
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x9F0550", Offset = "0x9EF750", VA = "0x1809F0550")]
		internal void ReceivedFromLocalServer(LocalPacket packet)
		{
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x9F05B0", Offset = "0x9EF7B0", VA = "0x1809F05B0")]
		internal void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x9F0970", Offset = "0x9EFB70", VA = "0x1809F0970")]
		public ClientHostSocket()
		{
		}

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x30")]
		private ServerSocket _server;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x38")]
		private Queue<LocalPacket> _incoming;
	}
}
