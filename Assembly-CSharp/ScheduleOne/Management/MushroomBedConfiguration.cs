using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x02000571 RID: 1393
	[Token(Token = "0x2000571")]
	public class MushroomBedConfiguration : EntityConfiguration
	{
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F97 RID: 8087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000599")]
		public MushroomBed MushroomBed
		{
			[Token(Token = "0x6001F96")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F97")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F99 RID: 8089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059A")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001F98")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F99")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0x645960", Offset = "0x644B60", VA = "0x180645960")]
		public MushroomBedConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, MushroomBed mushroomBed)
		{
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F9B")]
		[Address(RVA = "0x6452A0", Offset = "0x6444A0", VA = "0x1806452A0")]
		public string[] GetSelectedSeedIDs()
		{
			return null;
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0000B070 File Offset: 0x00009270
		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0x6454E0", Offset = "0x6446E0", VA = "0x1806454E0")]
		public bool IsAdditiveSelected(ItemDefinition additive)
		{
			return default(bool);
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0x6455E0", Offset = "0x6447E0", VA = "0x1806455E0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0x644F00", Offset = "0x644100", VA = "0x180644F00")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0x645040", Offset = "0x644240", VA = "0x180645040")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x645780", Offset = "0x644980", VA = "0x180645780", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x644EE0", Offset = "0x6440E0", VA = "0x180644EE0", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x6457A0", Offset = "0x6449A0", VA = "0x1806457A0", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x645150", Offset = "0x644350", VA = "0x180645150", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x48")]
		public ItemField Spawn;

		// Token: 0x04001A00 RID: 6656
		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x50")]
		public ItemField Additive1;

		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x58")]
		public ItemField Additive2;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x60")]
		public ItemField Additive3;

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x68")]
		public NPCField AssignedBotanist;

		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x70")]
		public ObjectField Destination;
	}
}
