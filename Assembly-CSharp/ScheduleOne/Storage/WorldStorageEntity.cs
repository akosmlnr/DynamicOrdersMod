using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008D8 RID: 2264
	[Token(Token = "0x20008D8")]
	public class WorldStorageEntity : StorageEntity, IGUIDRegisterable, ISaveable
	{
		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x000116D0 File Offset: 0x0000F8D0
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096E")]
		public Guid GUID
		{
			[Token(Token = "0x6003C56")]
			[Address(RVA = "0x82A8B0", Offset = "0x829AB0", VA = "0x18082A8B0", Slot = "44")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6003C57")]
			[Address(RVA = "0x82A9D0", Offset = "0x829BD0", VA = "0x18082A9D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C58")]
		[Address(RVA = "0x82A490", Offset = "0x829690", VA = "0x18082A490")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700096F")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003C59")]
			[Address(RVA = "0x82A950", Offset = "0x829B50", VA = "0x18082A950", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000970")]
		public string SaveFileName
		{
			[Token(Token = "0x6003C5A")]
			[Address(RVA = "0x82A8D0", Offset = "0x829AD0", VA = "0x18082A8D0", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000971")]
		public Loader Loader
		{
			[Token(Token = "0x6003C5B")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06003C5C RID: 15452 RVA: 0x000116E8 File Offset: 0x0000F8E8
		[Token(Token = "0x17000972")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003C5C")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000973")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003C5D")]
			[Address(RVA = "0x71D4E0", Offset = "0x71C6E0", VA = "0x18071D4E0", Slot = "51")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C5E")]
			[Address(RVA = "0x82A9F0", Offset = "0x829BF0", VA = "0x18082A9F0", Slot = "52")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000974")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003C5F")]
			[Address(RVA = "0x6ECFE0", Offset = "0x6EC1E0", VA = "0x1806ECFE0", Slot = "53")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C60")]
			[Address(RVA = "0x6ED030", Offset = "0x6EC230", VA = "0x1806ED030", Slot = "54")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x00011700 File Offset: 0x0000F900
		// (set) Token: 0x06003C62 RID: 15458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000975")]
		public bool HasChanged
		{
			[Token(Token = "0x6003C61")]
			[Address(RVA = "0x82A8C0", Offset = "0x829AC0", VA = "0x18082A8C0", Slot = "55")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C62")]
			[Address(RVA = "0x82A9E0", Offset = "0x829BE0", VA = "0x18082A9E0", Slot = "56")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C63")]
		[Address(RVA = "0x82A0D0", Offset = "0x8292D0", VA = "0x18082A0D0", Slot = "30")]
		public override void Awake()
		{
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C64")]
		[Address(RVA = "0x82A400", Offset = "0x829600", VA = "0x18082A400", Slot = "32")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C65")]
		[Address(RVA = "0x82A2D0", Offset = "0x8294D0", VA = "0x18082A2D0", Slot = "70")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C66")]
		[Address(RVA = "0x82A4E0", Offset = "0x8296E0", VA = "0x18082A4E0", Slot = "46")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x6003C67")]
		[Address(RVA = "0x82A550", Offset = "0x829750", VA = "0x18082A550", Slot = "71")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C68")]
		[Address(RVA = "0x82A1D0", Offset = "0x8293D0", VA = "0x18082A1D0")]
		public WorldStorageEntityData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C69")]
		[Address(RVA = "0x82A290", Offset = "0x829490", VA = "0x18082A290", Slot = "72")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C6A")]
		[Address(RVA = "0x82A360", Offset = "0x829560", VA = "0x18082A360", Slot = "73")]
		public virtual void Load(WorldStorageEntityData data)
		{
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C6B")]
		[Address(RVA = "0x82A120", Offset = "0x829320", VA = "0x18082A120", Slot = "33")]
		protected override void ContentsChanged()
		{
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C6C")]
		[Address(RVA = "0x82A630", Offset = "0x829830", VA = "0x18082A630")]
		public WorldStorageEntity()
		{
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C6E")]
		[Address(RVA = "0x82A3E0", Offset = "0x8295E0", VA = "0x18082A3E0", Slot = "37")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C6F")]
		[Address(RVA = "0x82A3B0", Offset = "0x8295B0", VA = "0x18082A3B0", Slot = "38")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C70")]
		[Address(RVA = "0x820080", Offset = "0x81F280", VA = "0x180820080", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C71")]
		[Address(RVA = "0x829E30", Offset = "0x829030", VA = "0x180829E30", Slot = "74")]
		protected virtual void Awake_UserLogic_ScheduleOne.Storage.WorldStorageEntity_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002C4A RID: 11338
		[Token(Token = "0x4002C4A")]
		[FieldOffset(Offset = "0x0")]
		public static List<WorldStorageEntity> All;

		// Token: 0x04002C4C RID: 11340
		[Token(Token = "0x4002C4C")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04002C50 RID: 11344
		[Token(Token = "0x4002C50")]
		[FieldOffset(Offset = "0x19C")]
		public GameDateTime LastContentChangeTime;

		// Token: 0x04002C51 RID: 11345
		[Token(Token = "0x4002C51")]
		[FieldOffset(Offset = "0x1A4")]
		private bool NetworkInitialize___EarlyScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted;

		// Token: 0x04002C52 RID: 11346
		[Token(Token = "0x4002C52")]
		[FieldOffset(Offset = "0x1A5")]
		private bool NetworkInitialize__LateScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted;
	}
}
