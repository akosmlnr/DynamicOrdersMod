using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Packaging;
using ScheduleOne.Product;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200039A RID: 922
	[Token(Token = "0x200039A")]
	public class PackageProductTask : Task
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000476")]
		public override string TaskName
		{
			[Token(Token = "0x6001736")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001737")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
		public PackageProductTask(PackagingStation _station)
		{
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x5BF2D0", Offset = "0x5BE4D0", VA = "0x1805BF2D0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x5BF720", Offset = "0x5BE920", VA = "0x1805BF720", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x5BF240", Offset = "0x5BE440", VA = "0x1805BF240")]
		private void FullyPacked()
		{
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173C")]
		[Address(RVA = "0x5BF270", Offset = "0x5BE470", VA = "0x1805BF270")]
		private void Sealed()
		{
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173D")]
		[Address(RVA = "0x491630", Offset = "0x490830", VA = "0x180491630")]
		private void ReachedOutput()
		{
		}

		// Token: 0x04001474 RID: 5236
		[Token(Token = "0x4001474")]
		[FieldOffset(Offset = "0xA8")]
		protected PackagingStation station;

		// Token: 0x04001475 RID: 5237
		[Token(Token = "0x4001475")]
		[FieldOffset(Offset = "0xB0")]
		protected FunctionalPackaging Packaging;

		// Token: 0x04001476 RID: 5238
		[Token(Token = "0x4001476")]
		[FieldOffset(Offset = "0xB8")]
		protected List<FunctionalProduct> Products;
	}
}
