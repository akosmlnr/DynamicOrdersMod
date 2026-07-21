using System;
using Il2CppDummyDll;

namespace ScheduleOne.Doors
{
	// Token: 0x020006DB RID: 1755
	[Token(Token = "0x20006DB")]
	public class SewerDoorController : DoorController
	{
		// Token: 0x06002E98 RID: 11928 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x6002E98")]
		[Address(RVA = "0x74C7F0", Offset = "0x74B9F0", VA = "0x18074C7F0", Slot = "26")]
		protected override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x74CA00", Offset = "0x74BC00", VA = "0x18074CA00", Slot = "25")]
		public override void ExteriorHandleInteracted()
		{
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9A")]
		[Address(RVA = "0x7457F0", Offset = "0x7449F0", VA = "0x1807457F0")]
		public SewerDoorController()
		{
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0x74CD00", Offset = "0x74BF00", VA = "0x18074CD00", Slot = "33")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9C")]
		[Address(RVA = "0x74CCD0", Offset = "0x74BED0", VA = "0x18074CCD0", Slot = "34")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9D")]
		[Address(RVA = "0x6A38B0", Offset = "0x6A2AB0", VA = "0x1806A38B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9E")]
		[Address(RVA = "0x74C780", Offset = "0x74B980", VA = "0x18074C780", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04002283 RID: 8835
		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0x198")]
		private bool NetworkInitialize___EarlyScheduleOne.Doors.SewerDoorControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002284 RID: 8836
		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0x199")]
		private bool NetworkInitialize__LateScheduleOne.Doors.SewerDoorControllerAssembly-CSharp.dll_Excuted;
	}
}
