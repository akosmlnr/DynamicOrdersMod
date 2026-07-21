using System;
using FishNet.Serializing;
using Il2CppDummyDll;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x02000973 RID: 2419
	[Token(Token = "0x2000973")]
	public static class INetworkedEquippableUserSerializer
	{
		// Token: 0x06004095 RID: 16533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004095")]
		[Address(RVA = "0x85B940", Offset = "0x85AB40", VA = "0x18085B940")]
		public static void WriteINetworkedEquippableUser(this Writer writer, INetworkedEquippableUser value)
		{
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004096")]
		[Address(RVA = "0x85B8C0", Offset = "0x85AAC0", VA = "0x18085B8C0")]
		public static INetworkedEquippableUser ReadINetworkedEquippableUser(this Reader reader)
		{
			return null;
		}
	}
}
