using System;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200089D RID: 2205
	[Token(Token = "0x200089D")]
	public class PackagingStationMk2 : PackagingStation
	{
		// Token: 0x06003A12 RID: 14866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x807B70", Offset = "0x806D70", VA = "0x180807B70", Slot = "136")]
		public override void StartTask()
		{
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A13")]
		[Address(RVA = "0x807D50", Offset = "0x806F50", VA = "0x180807D50")]
		public PackagingStationMk2()
		{
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A14")]
		[Address(RVA = "0x807B50", Offset = "0x806D50", VA = "0x180807B50", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A15")]
		[Address(RVA = "0x807B30", Offset = "0x806D30", VA = "0x180807B30", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A16")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A17")]
		[Address(RVA = "0x807AE0", Offset = "0x806CE0", VA = "0x180807AE0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04002AD4 RID: 10964
		[Token(Token = "0x4002AD4")]
		[FieldOffset(Offset = "0x3A8")]
		public PackagingTool PackagingTool;

		// Token: 0x04002AD5 RID: 10965
		[Token(Token = "0x4002AD5")]
		[FieldOffset(Offset = "0x3B0")]
		private bool NetworkInitialize___EarlyScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted;

		// Token: 0x04002AD6 RID: 10966
		[Token(Token = "0x4002AD6")]
		[FieldOffset(Offset = "0x3B1")]
		private bool NetworkInitialize__LateScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted;
	}
}
