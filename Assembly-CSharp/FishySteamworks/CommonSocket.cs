using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using FishNet.Transporting;
using Il2CppDummyDll;
using Steamworks;

namespace FishySteamworks
{
	// Token: 0x02000204 RID: 516
	[Token(Token = "0x2000204")]
	public abstract class CommonSocket
	{
		// Token: 0x06000B19 RID: 2841 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x496F90", Offset = "0x496190", VA = "0x180496F90")]
		internal LocalConnectionState GetLocalConnectionState()
		{
			return LocalConnectionState.Stopped;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x9F2100", Offset = "0x9F1300", VA = "0x1809F2100", Slot = "4")]
		protected virtual void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x9F1D50", Offset = "0x9F0F50", VA = "0x1809F1D50", Slot = "5")]
		internal virtual void Initialize(Transport t)
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x9F1B30", Offset = "0x9F0D30", VA = "0x1809F1B30")]
		protected byte[] GetIPBytes(string address)
		{
			return null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x9F1E40", Offset = "0x9F1040", VA = "0x1809F1E40")]
		protected EResult Send(HSteamNetConnection steamConnection, ArraySegment<byte> segment, byte channelId)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x9F1A00", Offset = "0x9F0C00", VA = "0x1809F1A00")]
		internal void ClearQueue(ConcurrentQueue<LocalPacket> queue)
		{
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x9F1AA0", Offset = "0x9F0CA0", VA = "0x1809F1AA0")]
		internal void ClearQueue(Queue<LocalPacket> queue)
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x9F1C20", Offset = "0x9F0E20", VA = "0x1809F1C20")]
		protected void GetMessage(IntPtr ptr, byte[] buffer, out ArraySegment<byte> segment, out byte channel)
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x9F21C0", Offset = "0x9F13C0", VA = "0x1809F21C0")]
		protected CommonSocket()
		{
		}

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x10")]
		private LocalConnectionState _connectionState;

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x11")]
		protected bool PeerToPeer;

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x18")]
		protected Transport Transport;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0x20")]
		protected IntPtr[] MessagePointers;

		// Token: 0x04000BAF RID: 2991
		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0x28")]
		protected byte[] InboundBuffer;

		// Token: 0x04000BB0 RID: 2992
		[Token(Token = "0x4000BB0")]
		protected const int MAX_MESSAGES = 256;
	}
}
