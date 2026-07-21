using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	public class PackagingStationConfiguration : EntityConfiguration
	{
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059E")]
		public PackagingStation Station
		{
			[Token(Token = "0x6001FBC")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FBD")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059F")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001FBE")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FBF")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x649650", Offset = "0x648850", VA = "0x180649650")]
		public PackagingStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, PackagingStation station)
		{
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x6383F0", Offset = "0x6375F0", VA = "0x1806383F0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0x6492B0", Offset = "0x6484B0", VA = "0x1806492B0")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0000B118 File Offset: 0x00009318
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x6493F0", Offset = "0x6485F0", VA = "0x1806493F0")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x638430", Offset = "0x637630", VA = "0x180638430", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x6380D0", Offset = "0x6372D0", VA = "0x1806380D0", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x0000B130 File Offset: 0x00009330
		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0x6495B0", Offset = "0x6487B0", VA = "0x1806495B0", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x649500", Offset = "0x648700", VA = "0x180649500", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x04001A10 RID: 6672
		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0x48")]
		public NPCField AssignedPackager;

		// Token: 0x04001A11 RID: 6673
		[Token(Token = "0x4001A11")]
		[FieldOffset(Offset = "0x50")]
		public ObjectField Destination;
	}
}
