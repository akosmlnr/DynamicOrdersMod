using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Storage
{
	// Token: 0x020008CF RID: 2255
	[Token(Token = "0x20008CF")]
	public class StorageManager : NetworkSingleton<StorageManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700095B")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003C16")]
			[Address(RVA = "0x825C20", Offset = "0x824E20", VA = "0x180825C20", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06003C17 RID: 15383 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700095C")]
		public string SaveFileName
		{
			[Token(Token = "0x6003C17")]
			[Address(RVA = "0x825BF0", Offset = "0x824DF0", VA = "0x180825BF0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700095D")]
		public Loader Loader
		{
			[Token(Token = "0x6003C18")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06003C19 RID: 15385 RVA: 0x000115E0 File Offset: 0x0000F7E0
		[Token(Token = "0x1700095E")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003C19")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06003C1A RID: 15386 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C1B RID: 15387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700095F")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003C1A")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C1B")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003C1D RID: 15389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000960")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003C1C")]
			[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C1D")]
			[Address(RVA = "0x5A45A0", Offset = "0x5A37A0", VA = "0x1805A45A0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x000115F8 File Offset: 0x0000F7F8
		// (set) Token: 0x06003C1F RID: 15391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000961")]
		public bool HasChanged
		{
			[Token(Token = "0x6003C1E")]
			[Address(RVA = "0x511360", Offset = "0x510560", VA = "0x180511360", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003C1F")]
			[Address(RVA = "0x5A4540", Offset = "0x5A3740", VA = "0x1805A4540", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x00011610 File Offset: 0x0000F810
		[Token(Token = "0x17000962")]
		public int LoadOrder
		{
			[Token(Token = "0x6003C20")]
			[Address(RVA = "0x71D590", Offset = "0x71C790", VA = "0x18071D590", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C21")]
		[Address(RVA = "0x825720", Offset = "0x824920", VA = "0x180825720", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x8259B0", Offset = "0x824BB0", VA = "0x1808259B0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x8257A0", Offset = "0x8249A0", VA = "0x1808257A0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x825AE0", Offset = "0x824CE0", VA = "0x180825AE0")]
		public StorageManager()
		{
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C25")]
		[Address(RVA = "0x825A90", Offset = "0x824C90", VA = "0x180825A90", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C26")]
		[Address(RVA = "0x825A40", Offset = "0x824C40", VA = "0x180825A40", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x8256D0", Offset = "0x8248D0", VA = "0x1808256D0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Storage.StorageManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002C22 RID: 11298
		[Token(Token = "0x4002C22")]
		[FieldOffset(Offset = "0x120")]
		private StorageLoader loader;

		// Token: 0x04002C27 RID: 11303
		[Token(Token = "0x4002C27")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002C28 RID: 11304
		[Token(Token = "0x4002C28")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Storage.StorageManagerAssembly-CSharp.dll_Excuted;
	}
}
