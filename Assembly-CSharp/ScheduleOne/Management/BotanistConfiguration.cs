using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;

namespace ScheduleOne.Management
{
	// Token: 0x02000567 RID: 1383
	[Token(Token = "0x2000567")]
	public class BotanistConfiguration : EntityConfiguration
	{
		// Token: 0x06001EF6 RID: 7926 RVA: 0x0000AE18 File Offset: 0x00009018
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "4")]
		public override bool AllowRename()
		{
			return default(bool);
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057E")]
		public List<Pot> AssignedPots
		{
			[Token(Token = "0x6001EF7")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EF8")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057F")]
		public List<DryingRack> AssignedRacks
		{
			[Token(Token = "0x6001EF9")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EFA")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001EFC RID: 7932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000580")]
		public List<MushroomBed> AssignedBeds
		{
			[Token(Token = "0x6001EFB")]
			[Address(RVA = "0x467500", Offset = "0x466700", VA = "0x180467500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EFC")]
			[Address(RVA = "0x5944F0", Offset = "0x5936F0", VA = "0x1805944F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000581")]
		public List<MushroomSpawnStation> AssignedSpawnStations
		{
			[Token(Token = "0x6001EFD")]
			[Address(RVA = "0x4674F0", Offset = "0x4666F0", VA = "0x1804674F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EFE")]
			[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000582")]
		public EmployeeHome AssignedHome
		{
			[Token(Token = "0x6001EFF")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F00")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x637A10", Offset = "0x636C10", VA = "0x180637A10")]
		public BotanistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Botanist _botanist)
		{
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x637610", Offset = "0x636810", VA = "0x180637610", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x637070", Offset = "0x636270", VA = "0x180637070")]
		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x636810", Offset = "0x635A10", VA = "0x180636810")]
		public void AssignsChanged(List<BuildableItem> objects)
		{
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x636DC0", Offset = "0x635FC0", VA = "0x180636DC0")]
		private NPCField GetNPCField(IConfigurable configurable)
		{
			return null;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x6376C0", Offset = "0x6368C0", VA = "0x1806376C0", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x636E50", Offset = "0x636050", VA = "0x180636E50", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x636F30", Offset = "0x636130", VA = "0x180636F30")]
		private void HomeChanged(BuildableItem newItem)
		{
		}

		// Token: 0x040019C3 RID: 6595
		[Token(Token = "0x40019C3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Type[] AssignableTypes;

		// Token: 0x040019C4 RID: 6596
		[Token(Token = "0x40019C4")]
		[FieldOffset(Offset = "0x40")]
		public ObjectField Home;

		// Token: 0x040019C5 RID: 6597
		[Token(Token = "0x40019C5")]
		[FieldOffset(Offset = "0x48")]
		public ObjectField Supplies;

		// Token: 0x040019C6 RID: 6598
		[Token(Token = "0x40019C6")]
		[FieldOffset(Offset = "0x50")]
		public ObjectListField Assigns;

		// Token: 0x040019CC RID: 6604
		[Token(Token = "0x40019CC")]
		[FieldOffset(Offset = "0x80")]
		private List<BuildableItem> _thisBotanistAssignedOn;

		// Token: 0x040019CD RID: 6605
		[Token(Token = "0x40019CD")]
		[FieldOffset(Offset = "0x88")]
		private Botanist _botanist;
	}
}
