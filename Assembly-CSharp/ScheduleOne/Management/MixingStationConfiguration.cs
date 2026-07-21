using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x2000570")]
	public class MixingStationConfiguration : EntityConfiguration
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000597")]
		public MixingStation station
		{
			[Token(Token = "0x6001F87")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F88")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000598")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001F89")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F8A")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x644AA0", Offset = "0x643CA0", VA = "0x180644AA0")]
		public MixingStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, MixingStation station)
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x63BCC0", Offset = "0x63AEC0", VA = "0x18063BCC0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x644690", Offset = "0x643890", VA = "0x180644690")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x6447D0", Offset = "0x6439D0", VA = "0x1806447D0")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x63BD00", Offset = "0x63AF00", VA = "0x18063BD00", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0x63B970", Offset = "0x63AB70", VA = "0x18063B970", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0x644A00", Offset = "0x643C00", VA = "0x180644A00", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0x6448E0", Offset = "0x643AE0", VA = "0x1806448E0", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040019FA RID: 6650
		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x48")]
		public NPCField AssignedChemist;

		// Token: 0x040019FB RID: 6651
		[Token(Token = "0x40019FB")]
		[FieldOffset(Offset = "0x50")]
		public ObjectField Destination;

		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x58")]
		public NumberField StartThrehold;
	}
}
