using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using Unity.AI.Navigation;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005F7 RID: 1527
	[Token(Token = "0x20005F7")]
	public class PlayerManager : Singleton<PlayerManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000688")]
		public string SaveFolderName
		{
			[Token(Token = "0x600255B")]
			[Address(RVA = "0x6B1FB0", Offset = "0x6B11B0", VA = "0x1806B1FB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000689")]
		public string SaveFileName
		{
			[Token(Token = "0x600255C")]
			[Address(RVA = "0x6B1F80", Offset = "0x6B1180", VA = "0x1806B1F80", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700068A")]
		public Loader Loader
		{
			[Token(Token = "0x600255D")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x1700068B")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x600255E")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068C")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x600255F")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002560")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068D")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6002561")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002562")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0000C330 File Offset: 0x0000A530
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068E")]
		public bool HasChanged
		{
			[Token(Token = "0x6002563")]
			[Address(RVA = "0x496DF0", Offset = "0x495FF0", VA = "0x180496DF0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002564")]
			[Address(RVA = "0x496E70", Offset = "0x496070", VA = "0x180496E70", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x1700068F")]
		public int LoadOrder
		{
			[Token(Token = "0x6002565")]
			[Address(RVA = "0x596F60", Offset = "0x596160", VA = "0x180596F60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x6B06A0", Offset = "0x6AF8A0", VA = "0x1806B06A0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x6B0730", Offset = "0x6AF930", VA = "0x1806B0730", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002568")]
		[Address(RVA = "0x6B06F0", Offset = "0x6AF8F0", VA = "0x1806B06F0", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x6B1880", Offset = "0x6B0A80", VA = "0x1806B1880", Slot = "33")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x6B0B90", Offset = "0x6AFD90", VA = "0x1806B0B90")]
		public void SavePlayer(Player player)
		{
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256B")]
		[Address(RVA = "0x6B07C0", Offset = "0x6AF9C0", VA = "0x1806B07C0")]
		public void LoadPlayer(PlayerData data, string containerPath)
		{
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x6B0320", Offset = "0x6AF520", VA = "0x1806B0320")]
		public void AllPlayerFilesLoaded()
		{
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x6B1020", Offset = "0x6B0220", VA = "0x1806B1020")]
		public bool TryGetPlayerData(string playerCode, out PlayerData data, out string inventoryString, out string appearanceString, out string clothingString, out VariableData[] variables)
		{
			return default(bool);
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x6B1DF0", Offset = "0x6B0FF0", VA = "0x1806B1DF0")]
		public PlayerManager()
		{
		}

		// Token: 0x04001D13 RID: 7443
		[Token(Token = "0x4001D13")]
		[FieldOffset(Offset = "0x28")]
		private PlayersLoader loader;

		// Token: 0x04001D18 RID: 7448
		[Token(Token = "0x4001D18")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected List<PlayerData> loadedPlayerData;

		// Token: 0x04001D19 RID: 7449
		[Token(Token = "0x4001D19")]
		[FieldOffset(Offset = "0x50")]
		protected List<string> loadedPlayerDataPaths;

		// Token: 0x04001D1A RID: 7450
		[Token(Token = "0x4001D1A")]
		[FieldOffset(Offset = "0x58")]
		protected List<string> loadedPlayerFileNames;

		// Token: 0x04001D1B RID: 7451
		[Token(Token = "0x4001D1B")]
		[FieldOffset(Offset = "0x60")]
		public NavMeshSurface PlayerRecoverySurface;
	}
}
