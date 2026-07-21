using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	public class GridItemLoader : BuildableItemLoader
	{
		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004ED")]
		public override string ItemType
		{
			[Token(Token = "0x6001A23")]
			[Address(RVA = "0x5ED600", Offset = "0x5EC800", VA = "0x1805ED600", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public GridItemLoader()
		{
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x5ED310", Offset = "0x5EC510", VA = "0x1805ED310", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x5ED320", Offset = "0x5EC520", VA = "0x1805ED320", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x5ED160", Offset = "0x5EC360", VA = "0x1805ED160")]
		protected GridItem LoadAndCreate(string mainPath)
		{
			return null;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x5ECED0", Offset = "0x5EC0D0", VA = "0x1805ECED0")]
		protected GridItem LoadAndCreate(GridItemData data)
		{
			return null;
		}
	}
}
