using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020009F6 RID: 2550
	[Token(Token = "0x20009F6")]
	public class GameManager : NetworkSingleton<GameManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x00013B48 File Offset: 0x00011D48
		[Token(Token = "0x17000B61")]
		public static bool IS_TUTORIAL
		{
			[Token(Token = "0x60048E2")]
			[Address(RVA = "0x8F5F60", Offset = "0x8F5160", VA = "0x1808F5F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x00013B60 File Offset: 0x00011D60
		[Token(Token = "0x17000B62")]
		public static int Seed
		{
			[Token(Token = "0x60048E3")]
			[Address(RVA = "0x8F60C0", Offset = "0x8F52C0", VA = "0x1808F60C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060048E5 RID: 18661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B63")]
		public Sprite OrganisationLogo
		{
			[Token(Token = "0x60048E4")]
			[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048E5")]
			[Address(RVA = "0x5A45A0", Offset = "0x5A37A0", VA = "0x1805A45A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060048E6 RID: 18662 RVA: 0x00013B78 File Offset: 0x00011D78
		[Token(Token = "0x17000B64")]
		public bool IsTutorial
		{
			[Token(Token = "0x60048E6")]
			[Address(RVA = "0x8F5FE0", Offset = "0x8F51E0", VA = "0x1808F5FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060048E7 RID: 18663 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B65")]
		public string SaveFolderName
		{
			[Token(Token = "0x60048E7")]
			[Address(RVA = "0x8F6090", Offset = "0x8F5290", VA = "0x1808F6090", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060048E8 RID: 18664 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B66")]
		public string SaveFileName
		{
			[Token(Token = "0x60048E8")]
			[Address(RVA = "0x8F6060", Offset = "0x8F5260", VA = "0x1808F6060", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B67")]
		public Loader Loader
		{
			[Token(Token = "0x60048E9")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060048EA RID: 18666 RVA: 0x00013B90 File Offset: 0x00011D90
		[Token(Token = "0x17000B68")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60048EA")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060048EC RID: 18668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B69")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60048EB")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048EC")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060048EE RID: 18670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6A")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60048ED")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048EE")]
			[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x00013BA8 File Offset: 0x00011DA8
		// (set) Token: 0x060048F0 RID: 18672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6B")]
		public bool HasChanged
		{
			[Token(Token = "0x60048EF")]
			[Address(RVA = "0x6288D0", Offset = "0x627AD0", VA = "0x1806288D0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048F0")]
			[Address(RVA = "0x628A10", Offset = "0x627C10", VA = "0x180628A10", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[Token(Token = "0x17000B6C")]
		public int LoadOrder
		{
			[Token(Token = "0x60048F1")]
			[Address(RVA = "0x6288F0", Offset = "0x627AF0", VA = "0x1806288F0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x8F5280", Offset = "0x8F4480", VA = "0x1808F5280", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x8F58B0", Offset = "0x8F4AB0", VA = "0x1808F58B0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x8F5BD0", Offset = "0x8F4DD0", VA = "0x1808F5BD0")]
		[TargetRpc]
		public void SetGameData(NetworkConnection conn, GameData data)
		{
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x8F56B0", Offset = "0x8F48B0", VA = "0x1808F56B0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60048F6")]
		[Address(RVA = "0x8F5600", Offset = "0x8F4800", VA = "0x1808F5600", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x8F5740", Offset = "0x8F4940", VA = "0x1808F5740")]
		public void Load(GameData data, string path)
		{
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F8")]
		[Address(RVA = "0x8F5310", Offset = "0x8F4510", VA = "0x1808F5310")]
		[Button]
		public void EndTutorial(bool natural)
		{
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x8F5D30", Offset = "0x8F4F30", VA = "0x1808F5D30")]
		public GameManager()
		{
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FA")]
		[Address(RVA = "0x8F5810", Offset = "0x8F4A10", VA = "0x1808F5810", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FB")]
		[Address(RVA = "0x8F57C0", Offset = "0x8F49C0", VA = "0x1808F57C0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FC")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FD")]
		[Address(RVA = "0x8F5BD0", Offset = "0x8F4DD0", VA = "0x1808F5BD0")]
		private void RpcWriter___Target_SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x8F5AB0", Offset = "0x8F4CB0", VA = "0x1808F5AB0")]
		public void RpcLogic___SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x8F5B30", Offset = "0x8F4D30", VA = "0x1808F5B30")]
		private void RpcReader___Target_SetGameData_3076874643(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004900")]
		[Address(RVA = "0x8F5220", Offset = "0x8F4420", VA = "0x1808F5220", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.DevUtilities.GameManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		public const bool IS_DEMO = false;

		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		[FieldOffset(Offset = "0x0")]
		public static bool IS_BETA;

		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int seed;

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[FieldOffset(Offset = "0x128")]
		public string OrganisationName;

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0x138")]
		public GameSettings Settings;

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[FieldOffset(Offset = "0x140")]
		public Transform SpawnPoint;

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[FieldOffset(Offset = "0x148")]
		public Transform NoHomeRespawnPoint;

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[FieldOffset(Offset = "0x150")]
		public Transform Temp;

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent onSettingsLoaded;

		// Token: 0x040033A1 RID: 13217
		[Token(Token = "0x40033A1")]
		[FieldOffset(Offset = "0x160")]
		private GameDataLoader loader;

		// Token: 0x040033A6 RID: 13222
		[Token(Token = "0x40033A6")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x040033A7 RID: 13223
		[Token(Token = "0x40033A7")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted;
	}
}
