using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x0200082E RID: 2094
	[Token(Token = "0x200082E")]
	public class FlashlightAvatarEquippable : AvatarEquippable
	{
		// Token: 0x0600383F RID: 14399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x7F32F0", Offset = "0x7F24F0", VA = "0x1807F32F0", Slot = "5")]
		public override void Equip(Avatar _avatar)
		{
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x7E7440", Offset = "0x7E6640", VA = "0x1807E7440")]
		public FlashlightAvatarEquippable()
		{
		}

		// Token: 0x04002939 RID: 10553
		[Token(Token = "0x4002939")]
		[FieldOffset(Offset = "0x58")]
		public OptimizedLight Light;
	}
}
