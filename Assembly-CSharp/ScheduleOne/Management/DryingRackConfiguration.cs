using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x0200056D RID: 1389
	[Token(Token = "0x200056D")]
	public class DryingRackConfiguration : EntityConfiguration
	{
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F55 RID: 8021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058F")]
		public DryingRack Rack
		{
			[Token(Token = "0x6001F54")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F55")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F57 RID: 8023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000590")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001F56")]
			[Address(RVA = "0x467500", Offset = "0x466700", VA = "0x180467500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F57")]
			[Address(RVA = "0x5944F0", Offset = "0x5936F0", VA = "0x1805944F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x642920", Offset = "0x641B20", VA = "0x180642920")]
		public DryingRackConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, DryingRack rack)
		{
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x642820", Offset = "0x641A20", VA = "0x180642820", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x642460", Offset = "0x641660", VA = "0x180642460")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x6425A0", Offset = "0x6417A0", VA = "0x1806425A0")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x642860", Offset = "0x641A60", VA = "0x180642860", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x642440", Offset = "0x641640", VA = "0x180642440", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x642880", Offset = "0x641A80", VA = "0x180642880", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x6426B0", Offset = "0x6418B0", VA = "0x1806426B0", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040019E9 RID: 6633
		[Token(Token = "0x40019E9")]
		[FieldOffset(Offset = "0x48")]
		public NPCField AssignedBotanist;

		// Token: 0x040019EA RID: 6634
		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0x50")]
		public QualityField TargetQuality;

		// Token: 0x040019EB RID: 6635
		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x58")]
		public NumberField StartThreshold;

		// Token: 0x040019EC RID: 6636
		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x60")]
		public ObjectField Destination;
	}
}
