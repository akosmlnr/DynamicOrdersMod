using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class GrowContainerPourTask : Task
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000485")]
		public override string TaskName
		{
			[Token(Token = "0x600178A")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600178B")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x00009900 File Offset: 0x00007B00
		[Token(Token = "0x17000486")]
		protected virtual bool UseCoverage
		{
			[Token(Token = "0x600178C")]
			[Address(RVA = "0x4E7120", Offset = "0x4E6320", VA = "0x1804E7120", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x00009918 File Offset: 0x00007B18
		[Token(Token = "0x17000487")]
		protected virtual bool FailOnEmpty
		{
			[Token(Token = "0x600178D")]
			[Address(RVA = "0x4E7280", Offset = "0x4E6480", VA = "0x1804E7280", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00009930 File Offset: 0x00007B30
		[Token(Token = "0x17000488")]
		protected virtual GrowContainerCameraHandler.ECameraPosition CameraPosition
		{
			[Token(Token = "0x600178E")]
			[Address(RVA = "0x5256F0", Offset = "0x5248F0", VA = "0x1805256F0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return GrowContainerCameraHandler.ECameraPosition.Closeup;
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x5B7810", Offset = "0x5B6A10", VA = "0x1805B7810")]
		public GrowContainerPourTask(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab)
		{
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x5B77A0", Offset = "0x5B69A0", VA = "0x1805B77A0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001791")]
		[Address(RVA = "0x5B7380", Offset = "0x5B6580", VA = "0x1805B7380", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001792")]
		[Address(RVA = "0x5B7030", Offset = "0x5B6230", VA = "0x1805B7030", Slot = "17")]
		protected virtual void OnInitialPour()
		{
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001793")]
		[Address(RVA = "0x5B7050", Offset = "0x5B6250", VA = "0x1805B7050")]
		protected void RemoveItem()
		{
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001794")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "18")]
		protected virtual void FullyCovered()
		{
		}

		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40014B3")]
		[FieldOffset(Offset = "0xA8")]
		protected GrowContainer growContainer;

		// Token: 0x040014B4 RID: 5300
		[Token(Token = "0x40014B4")]
		[FieldOffset(Offset = "0xB0")]
		protected ItemInstance item;

		// Token: 0x040014B5 RID: 5301
		[Token(Token = "0x40014B5")]
		[FieldOffset(Offset = "0xB8")]
		protected Pourable pourable;

		// Token: 0x040014B9 RID: 5305
		[Token(Token = "0x40014B9")]
		[FieldOffset(Offset = "0xC8")]
		protected bool removeItemAfterInitialPour;
	}
}
