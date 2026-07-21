using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x0200056C RID: 1388
	[Token(Token = "0x200056C")]
	public class CleanerConfiguration : EntityConfiguration
	{
		// Token: 0x06001F45 RID: 8005 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "4")]
		public override bool AllowRename()
		{
			return default(bool);
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058C")]
		public Cleaner cleaner
		{
			[Token(Token = "0x6001F46")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F47")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F49 RID: 8009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058D")]
		public List<TrashContainerItem> binItems
		{
			[Token(Token = "0x6001F48")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F49")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058E")]
		public EmployeeHome assignedHome
		{
			[Token(Token = "0x6001F4A")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F4B")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0x63C7F0", Offset = "0x63B9F0", VA = "0x18063C7F0")]
		public CleanerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cleaner _cleaner)
		{
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0x63C700", Offset = "0x63B900", VA = "0x18063C700", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x6001F4E")]
		[Address(RVA = "0x63C5C0", Offset = "0x63B7C0", VA = "0x18063C5C0")]
		private bool IsObjValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0x63C190", Offset = "0x63B390", VA = "0x18063C190")]
		public void AssignedBinsChanged(List<BuildableItem> objects)
		{
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x6001F50")]
		[Address(RVA = "0x63C730", Offset = "0x63B930", VA = "0x18063C730", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F51")]
		[Address(RVA = "0x63C3D0", Offset = "0x63B5D0", VA = "0x18063C3D0", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F52")]
		[Address(RVA = "0x63C480", Offset = "0x63B680", VA = "0x18063C480")]
		private void HomeChanged(BuildableItem newItem)
		{
		}

		// Token: 0x040019E3 RID: 6627
		[Token(Token = "0x40019E3")]
		[FieldOffset(Offset = "0x40")]
		public ObjectField Home;

		// Token: 0x040019E4 RID: 6628
		[Token(Token = "0x40019E4")]
		[FieldOffset(Offset = "0x48")]
		public ObjectListField Bins;
	}
}
