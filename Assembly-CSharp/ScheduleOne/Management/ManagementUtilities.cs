using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000590 RID: 1424
	[Token(Token = "0x2000590")]
	public class ManagementUtilities : Singleton<ManagementUtilities>
	{
		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CC")]
		public Sprite StorageTypeIcon
		{
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002099 RID: 8345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CD")]
		public StorageUIElement StorageUIElementPrefab
		{
			[Token(Token = "0x6002098")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002099")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x67A530", Offset = "0x679730", VA = "0x18067A530", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x67A570", Offset = "0x679770", VA = "0x18067A570")]
		public ManagementUtilities()
		{
		}

		// Token: 0x04001A78 RID: 6776
		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x28")]
		public List<SeedDefinition> Seeds;

		// Token: 0x04001A79 RID: 6777
		[Token(Token = "0x4001A79")]
		[FieldOffset(Offset = "0x30")]
		public List<ShroomSpawnDefinition> MushroomSpawns;
	}
}
