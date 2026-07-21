using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200044D RID: 1101
	[Token(Token = "0x200044D")]
	public class ProceduralGridItemLoader : BuildableItemLoader
	{
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004F6")]
		public override string ItemType
		{
			[Token(Token = "0x6001A5C")]
			[Address(RVA = "0x6162A0", Offset = "0x6154A0", VA = "0x1806162A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[Token(Token = "0x170004F7")]
		public override int LoadOrder
		{
			[Token(Token = "0x6001A5D")]
			[Address(RVA = "0x616320", Offset = "0x615520", VA = "0x180616320", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public ProceduralGridItemLoader()
		{
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x616210", Offset = "0x615410", VA = "0x180616210", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x616220", Offset = "0x615420", VA = "0x180616220", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x6160A0", Offset = "0x6152A0", VA = "0x1806160A0")]
		protected ProceduralGridItem LoadAndCreate(string mainPath)
		{
			return null;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x615C00", Offset = "0x614E00", VA = "0x180615C00")]
		protected ProceduralGridItem LoadAndCreate(ProceduralGridItemData data)
		{
			return null;
		}
	}
}
