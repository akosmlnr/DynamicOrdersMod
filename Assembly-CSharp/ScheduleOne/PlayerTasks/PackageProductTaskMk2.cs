using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Packaging;
using ScheduleOne.Product;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	public class PackageProductTaskMk2 : Task
	{
		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000477")]
		public override string TaskName
		{
			[Token(Token = "0x600173E")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600173F")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001740")]
		[Address(RVA = "0x5BEBC0", Offset = "0x5BDDC0", VA = "0x1805BEBC0")]
		public PackageProductTaskMk2(PackagingStationMk2 _station)
		{
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001741")]
		[Address(RVA = "0x5BE880", Offset = "0x5BDA80", VA = "0x1805BE880", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x04001478 RID: 5240
		[Token(Token = "0x4001478")]
		[FieldOffset(Offset = "0xA8")]
		protected PackagingStationMk2 station;

		// Token: 0x04001479 RID: 5241
		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0xB0")]
		protected FunctionalPackaging Packaging;

		// Token: 0x0400147A RID: 5242
		[Token(Token = "0x400147A")]
		[FieldOffset(Offset = "0xB8")]
		protected List<FunctionalProduct> Products;
	}
}
