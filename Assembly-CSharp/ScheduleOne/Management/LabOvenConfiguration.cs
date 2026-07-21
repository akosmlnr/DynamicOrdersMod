using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x0200056F RID: 1391
	[Token(Token = "0x200056F")]
	public class LabOvenConfiguration : EntityConfiguration
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000595")]
		public LabOven Oven
		{
			[Token(Token = "0x6001F79")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F7A")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000596")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001F7B")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F7C")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x6443E0", Offset = "0x6435E0", VA = "0x1806443E0")]
		public LabOvenConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, LabOven oven)
		{
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0x6383F0", Offset = "0x6375F0", VA = "0x1806383F0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x644040", Offset = "0x643240", VA = "0x180644040")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x644180", Offset = "0x643380", VA = "0x180644180")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0x638430", Offset = "0x637630", VA = "0x180638430", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F82")]
		[Address(RVA = "0x6380D0", Offset = "0x6372D0", VA = "0x1806380D0", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x6001F83")]
		[Address(RVA = "0x644340", Offset = "0x643540", VA = "0x180644340", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F84")]
		[Address(RVA = "0x644290", Offset = "0x643490", VA = "0x180644290", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040019F6 RID: 6646
		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x48")]
		public NPCField AssignedChemist;

		// Token: 0x040019F7 RID: 6647
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x50")]
		public ObjectField Destination;
	}
}
