using System;
using Il2CppDummyDll;

namespace FishySteamworks
{
	// Token: 0x02000205 RID: 517
	[Token(Token = "0x2000205")]
	internal struct LocalPacket
	{
		// Token: 0x06000B22 RID: 2850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x9FA650", Offset = "0x9F9850", VA = "0x1809FA650")]
		public LocalPacket(ArraySegment<byte> data, byte channel)
		{
		}

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x0")]
		public byte[] Data;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x8")]
		public int Length;

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0xC")]
		public byte Channel;
	}
}
