using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	[Serializable]
	public class VisionEventReceipt
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x5E5DB0", Offset = "0x5E4FB0", VA = "0x1805E5DB0")]
		public VisionEventReceipt(NetworkObject target, EVisualState state)
		{
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public VisionEventReceipt()
		{
		}

		// Token: 0x04001544 RID: 5444
		[Token(Token = "0x4001544")]
		[FieldOffset(Offset = "0x10")]
		public NetworkObject Target;

		// Token: 0x04001545 RID: 5445
		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x18")]
		public EVisualState State;
	}
}
