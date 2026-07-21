using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	public class AutoshopAccessZone : NPCPresenceAccessZone
	{
		// Token: 0x06001D0D RID: 7437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x620090", Offset = "0x61F290", VA = "0x180620090", Slot = "5")]
		public override void SetIsOpen(bool open)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x61FF40", Offset = "0x61F140", VA = "0x18061FF40", Slot = "7")]
		protected override void MinPass()
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x620120", Offset = "0x61F320", VA = "0x180620120")]
		public AutoshopAccessZone()
		{
		}

		// Token: 0x04001882 RID: 6274
		[Token(Token = "0x4001882")]
		[FieldOffset(Offset = "0x60")]
		public Animation RollerDoorAnim;

		// Token: 0x04001883 RID: 6275
		[Token(Token = "0x4001883")]
		[FieldOffset(Offset = "0x68")]
		public VehicleDetector VehicleDetection;

		// Token: 0x04001884 RID: 6276
		[Token(Token = "0x4001884")]
		[FieldOffset(Offset = "0x70")]
		private bool rollerDoorOpen;
	}
}
