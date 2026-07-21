using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x02000568 RID: 1384
	[Token(Token = "0x2000568")]
	public class BrickPressConfiguration : EntityConfiguration
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F0D RID: 7949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000583")]
		public BrickPress BrickPress
		{
			[Token(Token = "0x6001F0C")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F0D")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001F0E RID: 7950 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F0F RID: 7951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000584")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001F0E")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F0F")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x6384F0", Offset = "0x6376F0", VA = "0x1806384F0")]
		public BrickPressConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, BrickPress station)
		{
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x6383F0", Offset = "0x6375F0", VA = "0x1806383F0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x6380F0", Offset = "0x6372F0", VA = "0x1806380F0")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x638230", Offset = "0x637430", VA = "0x180638230")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x638430", Offset = "0x637630", VA = "0x180638430", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x6380D0", Offset = "0x6372D0", VA = "0x1806380D0", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x638450", Offset = "0x637650", VA = "0x180638450", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x638340", Offset = "0x637540", VA = "0x180638340", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040019CF RID: 6607
		[Token(Token = "0x40019CF")]
		[FieldOffset(Offset = "0x48")]
		public NPCField AssignedPackager;

		// Token: 0x040019D0 RID: 6608
		[Token(Token = "0x40019D0")]
		[FieldOffset(Offset = "0x50")]
		public ObjectField Destination;
	}
}
