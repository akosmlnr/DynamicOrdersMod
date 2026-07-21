using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x0200056B RID: 1387
	[Token(Token = "0x200056B")]
	public class ChemistryStationConfiguration : EntityConfiguration
	{
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058A")]
		public ChemistryStation Station
		{
			[Token(Token = "0x6001F36")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F37")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058B")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001F38")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x63BDC0", Offset = "0x63AFC0", VA = "0x18063BDC0")]
		public ChemistryStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, ChemistryStation station)
		{
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3B")]
		[Address(RVA = "0x63BCC0", Offset = "0x63AEC0", VA = "0x18063BCC0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0x63B990", Offset = "0x63AB90", VA = "0x18063B990")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0x63BAD0", Offset = "0x63ACD0", VA = "0x18063BAD0")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0x63BD00", Offset = "0x63AF00", VA = "0x18063BD00", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0x63B970", Offset = "0x63AB70", VA = "0x18063B970", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x6001F40")]
		[Address(RVA = "0x63BD20", Offset = "0x63AF20", VA = "0x18063BD20", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x63BBE0", Offset = "0x63ADE0", VA = "0x18063BBE0", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040019DF RID: 6623
		[Token(Token = "0x40019DF")]
		[FieldOffset(Offset = "0x48")]
		public NPCField AssignedChemist;

		// Token: 0x040019E0 RID: 6624
		[Token(Token = "0x40019E0")]
		[FieldOffset(Offset = "0x50")]
		public StationRecipeField Recipe;

		// Token: 0x040019E1 RID: 6625
		[Token(Token = "0x40019E1")]
		[FieldOffset(Offset = "0x58")]
		public ObjectField Destination;
	}
}
