using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	public class ChemistConfiguration : EntityConfiguration
	{
		// Token: 0x06001F28 RID: 7976 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "4")]
		public override bool AllowRename()
		{
			return default(bool);
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x17000587")]
		public int TotalStations
		{
			[Token(Token = "0x6001F29")]
			[Address(RVA = "0x63B8E0", Offset = "0x63AAE0", VA = "0x18063B8E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000588")]
		public Chemist chemist
		{
			[Token(Token = "0x6001F2A")]
			[Address(RVA = "0x4674F0", Offset = "0x4666F0", VA = "0x1804674F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F2B")]
			[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000589")]
		public EmployeeHome assignedHome
		{
			[Token(Token = "0x6001F2C")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F2D")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x63B1B0", Offset = "0x63A3B0", VA = "0x18063B1B0")]
		public ChemistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Chemist _chemist)
		{
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x63A810", Offset = "0x639A10", VA = "0x18063A810", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x63A3C0", Offset = "0x6395C0", VA = "0x18063A3C0")]
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x638EB0", Offset = "0x6380B0", VA = "0x180638EB0")]
		public void AssignedStationsChanged(List<BuildableItem> objects)
		{
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x63B0C0", Offset = "0x63A2C0", VA = "0x18063B0C0", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x63A1D0", Offset = "0x6393D0", VA = "0x18063A1D0", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x63A280", Offset = "0x639480", VA = "0x18063A280")]
		private void HomeChanged(BuildableItem newItem)
		{
		}

		// Token: 0x040019D6 RID: 6614
		[Token(Token = "0x40019D6")]
		[FieldOffset(Offset = "0x40")]
		public ObjectField Home;

		// Token: 0x040019D7 RID: 6615
		[Token(Token = "0x40019D7")]
		[FieldOffset(Offset = "0x48")]
		public ObjectListField Stations;

		// Token: 0x040019D8 RID: 6616
		[Token(Token = "0x40019D8")]
		[FieldOffset(Offset = "0x50")]
		public List<ChemistryStation> ChemStations;

		// Token: 0x040019D9 RID: 6617
		[Token(Token = "0x40019D9")]
		[FieldOffset(Offset = "0x58")]
		public List<LabOven> LabOvens;

		// Token: 0x040019DA RID: 6618
		[Token(Token = "0x40019DA")]
		[FieldOffset(Offset = "0x60")]
		public List<Cauldron> Cauldrons;

		// Token: 0x040019DB RID: 6619
		[Token(Token = "0x40019DB")]
		[FieldOffset(Offset = "0x68")]
		public List<MixingStation> MixStations;
	}
}
