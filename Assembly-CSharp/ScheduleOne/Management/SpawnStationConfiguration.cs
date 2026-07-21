using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.StationFramework;

namespace ScheduleOne.Management
{
	// Token: 0x02000577 RID: 1399
	[Token(Token = "0x2000577")]
	public class SpawnStationConfiguration : EntityConfiguration
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A2")]
		public MushroomSpawnStation Station
		{
			[Token(Token = "0x6001FE1")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE2")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A3")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001FE3")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE4")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x64C500", Offset = "0x64B700", VA = "0x18064C500")]
		public SpawnStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, MushroomSpawnStation station)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x6383F0", Offset = "0x6375F0", VA = "0x1806383F0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x64C160", Offset = "0x64B360", VA = "0x18064C160")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0000B190 File Offset: 0x00009390
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x64C2A0", Offset = "0x64B4A0", VA = "0x18064C2A0")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x638430", Offset = "0x637630", VA = "0x180638430", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x6380D0", Offset = "0x6372D0", VA = "0x1806380D0", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x64C460", Offset = "0x64B660", VA = "0x18064C460", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x64C3B0", Offset = "0x64B5B0", VA = "0x18064C3B0", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x04001A1E RID: 6686
		[Token(Token = "0x4001A1E")]
		[FieldOffset(Offset = "0x48")]
		public NPCField AssignedBotanist;

		// Token: 0x04001A1F RID: 6687
		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x50")]
		public ObjectField Destination;
	}
}
