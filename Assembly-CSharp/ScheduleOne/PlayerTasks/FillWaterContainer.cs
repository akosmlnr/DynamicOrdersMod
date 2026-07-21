using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Property;
using ScheduleOne.Tools;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	public class FillWaterContainer : Task
	{
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046C")]
		public new string TaskName
		{
			[Token(Token = "0x60016F2")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60016F3")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x5B5E30", Offset = "0x5B5030", VA = "0x1805B5E30")]
		public FillWaterContainer(Tap tap, WaterContainerInstance waterContainerItem)
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x5B5890", Offset = "0x5B4A90", VA = "0x1805B5890", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x5B5D50", Offset = "0x5B4F50", VA = "0x1805B5D50", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x5B5C60", Offset = "0x5B4E60", VA = "0x1805B5C60")]
		private void UpdateInstruction()
		{
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x5B5A00", Offset = "0x5B4C00", VA = "0x1805B5A00")]
		private void UpdateFillSound()
		{
		}

		// Token: 0x0400143D RID: 5181
		[Token(Token = "0x400143D")]
		[FieldOffset(Offset = "0xA8")]
		private Tap _tap;

		// Token: 0x0400143E RID: 5182
		[Token(Token = "0x400143E")]
		[FieldOffset(Offset = "0xB0")]
		private WaterContainerInstance _waterContainerItem;

		// Token: 0x0400143F RID: 5183
		[Token(Token = "0x400143F")]
		[FieldOffset(Offset = "0xB8")]
		private FillableWaterContainer _fillable;
	}
}
