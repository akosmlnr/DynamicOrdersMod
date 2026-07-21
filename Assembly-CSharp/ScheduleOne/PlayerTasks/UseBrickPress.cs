using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Product;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	public class UseBrickPress : Task
	{
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047D")]
		public override string TaskName
		{
			[Token(Token = "0x6001760")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001761")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x5C9410", Offset = "0x5C8610", VA = "0x1805C9410")]
		public UseBrickPress(BrickPress _press, ProductItemInstance _product)
		{
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x5C93B0", Offset = "0x5C85B0", VA = "0x1805C93B0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x5C8E40", Offset = "0x5C8040", VA = "0x1805C8E40", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001765")]
		[Address(RVA = "0x5C8A40", Offset = "0x5C7C40", VA = "0x1805C8A40")]
		private void CheckMould()
		{
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001766")]
		[Address(RVA = "0x5C8760", Offset = "0x5C7960", VA = "0x1805C8760")]
		private void BeginPress()
		{
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x5C8C30", Offset = "0x5C7E30", VA = "0x1805C8C30")]
		private void FinishPress()
		{
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x5C9340", Offset = "0x5C8540", VA = "0x1805C9340")]
		[CompilerGenerated]
		private IEnumerator <.ctor>g__CheckMould|11_0()
		{
			return null;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x5C92D0", Offset = "0x5C84D0", VA = "0x1805C92D0")]
		[CompilerGenerated]
		private IEnumerator <FinishPress>g__Wait|16_0()
		{
			return null;
		}

		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x4001495")]
		public const float PRODUCT_SCALE = 0.75f;

		// Token: 0x04001497 RID: 5271
		[Token(Token = "0x4001497")]
		[FieldOffset(Offset = "0xA8")]
		protected UseBrickPress.EStep currentStep;

		// Token: 0x04001498 RID: 5272
		[Token(Token = "0x4001498")]
		[FieldOffset(Offset = "0xB0")]
		protected BrickPress press;

		// Token: 0x04001499 RID: 5273
		[Token(Token = "0x4001499")]
		[FieldOffset(Offset = "0xB8")]
		protected ProductItemInstance product;

		// Token: 0x0400149A RID: 5274
		[Token(Token = "0x400149A")]
		[FieldOffset(Offset = "0xC0")]
		protected List<FunctionalProduct> products;

		// Token: 0x0400149B RID: 5275
		[Token(Token = "0x400149B")]
		[FieldOffset(Offset = "0xC8")]
		protected Draggable container;

		// Token: 0x020003A1 RID: 929
		[Token(Token = "0x20003A1")]
		public enum EStep
		{
			// Token: 0x0400149D RID: 5277
			[Token(Token = "0x400149D")]
			Pouring,
			// Token: 0x0400149E RID: 5278
			[Token(Token = "0x400149E")]
			Pressing,
			// Token: 0x0400149F RID: 5279
			[Token(Token = "0x400149F")]
			Complete
		}
	}
}
