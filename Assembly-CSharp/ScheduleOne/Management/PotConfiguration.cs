using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x02000575 RID: 1397
	[Token(Token = "0x2000575")]
	public class PotConfiguration : EntityConfiguration
	{
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A0")]
		public Pot Pot
		{
			[Token(Token = "0x6001FCA")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FCB")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A1")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001FCC")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FCD")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0x64B880", Offset = "0x64AA80", VA = "0x18064B880")]
		public PotConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Pot pot)
		{
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x64B420", Offset = "0x64A620", VA = "0x18064B420")]
		public bool IsAdditiveSelected(ItemDefinition additive)
		{
			return default(bool);
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0x64B1E0", Offset = "0x64A3E0", VA = "0x18064B1E0")]
		public string[] GetSelectedSeedIDs()
		{
			return null;
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0x64B520", Offset = "0x64A720", VA = "0x18064B520", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x64AE40", Offset = "0x64A040", VA = "0x18064AE40")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0000B160 File Offset: 0x00009360
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x64AF80", Offset = "0x64A180", VA = "0x18064AF80")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x645780", Offset = "0x644980", VA = "0x180645780", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0x644EE0", Offset = "0x6440E0", VA = "0x180644EE0", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x0000B178 File Offset: 0x00009378
		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0x64B6C0", Offset = "0x64A8C0", VA = "0x18064B6C0", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0x64B090", Offset = "0x64A290", VA = "0x18064B090", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x04001A14 RID: 6676
		[Token(Token = "0x4001A14")]
		[FieldOffset(Offset = "0x48")]
		public ItemField Seed;

		// Token: 0x04001A15 RID: 6677
		[Token(Token = "0x4001A15")]
		[FieldOffset(Offset = "0x50")]
		public ItemField Additive1;

		// Token: 0x04001A16 RID: 6678
		[Token(Token = "0x4001A16")]
		[FieldOffset(Offset = "0x58")]
		public ItemField Additive2;

		// Token: 0x04001A17 RID: 6679
		[Token(Token = "0x4001A17")]
		[FieldOffset(Offset = "0x60")]
		public ItemField Additive3;

		// Token: 0x04001A18 RID: 6680
		[Token(Token = "0x4001A18")]
		[FieldOffset(Offset = "0x68")]
		public NPCField AssignedBotanist;

		// Token: 0x04001A19 RID: 6681
		[Token(Token = "0x4001A19")]
		[FieldOffset(Offset = "0x70")]
		public ObjectField Destination;
	}
}
