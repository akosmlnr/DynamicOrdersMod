using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x02000573 RID: 1395
	[Token(Token = "0x2000573")]
	public class PackagerConfiguration : EntityConfiguration
	{
		// Token: 0x06001FAD RID: 8109 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "4")]
		public override bool AllowRename()
		{
			return default(bool);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[Token(Token = "0x1700059B")]
		public int AssignedStationCount
		{
			[Token(Token = "0x6001FAE")]
			[Address(RVA = "0x649250", Offset = "0x648450", VA = "0x180649250")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059C")]
		public Packager packager
		{
			[Token(Token = "0x6001FAF")]
			[Address(RVA = "0x467500", Offset = "0x466700", VA = "0x180467500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FB0")]
			[Address(RVA = "0x5944F0", Offset = "0x5936F0", VA = "0x1805944F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059D")]
		public EmployeeHome assignedHome
		{
			[Token(Token = "0x6001FB1")]
			[Address(RVA = "0x4674F0", Offset = "0x4666F0", VA = "0x1804674F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FB2")]
			[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB3")]
		[Address(RVA = "0x648BE0", Offset = "0x647DE0", VA = "0x180648BE0")]
		public PackagerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Packager _packager)
		{
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0x6486A0", Offset = "0x6478A0", VA = "0x1806486A0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0000B0E8 File Offset: 0x000092E8
		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0x6483D0", Offset = "0x6475D0", VA = "0x1806483D0")]
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0x6478E0", Offset = "0x646AE0", VA = "0x1806478E0")]
		public void AssignedStationsChanged(List<BuildableItem> objects)
		{
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x0000B100 File Offset: 0x00009300
		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0x648B20", Offset = "0x647D20", VA = "0x180648B20", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x6481B0", Offset = "0x6473B0", VA = "0x1806481B0", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x648290", Offset = "0x647490", VA = "0x180648290")]
		private void HomeChanged(BuildableItem newItem)
		{
		}

		// Token: 0x04001A08 RID: 6664
		[Token(Token = "0x4001A08")]
		[FieldOffset(Offset = "0x40")]
		public ObjectField Home;

		// Token: 0x04001A09 RID: 6665
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x48")]
		public ObjectListField Stations;

		// Token: 0x04001A0A RID: 6666
		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x50")]
		public RouteListField Routes;

		// Token: 0x04001A0B RID: 6667
		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x58")]
		public List<PackagingStation> AssignedStations;

		// Token: 0x04001A0C RID: 6668
		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0x60")]
		public List<BrickPress> AssignedBrickPresses;
	}
}
