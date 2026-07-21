using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000430 RID: 1072
	[Token(Token = "0x2000430")]
	public class BuildableItemLoader : Loader
	{
		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E8")]
		public virtual string ItemType
		{
			[Token(Token = "0x6001A04")]
			[Address(RVA = "0x5E7A00", Offset = "0x5E6C00", VA = "0x1805E7A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x170004E9")]
		public virtual int LoadOrder
		{
			[Token(Token = "0x6001A05")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x5E7900", Offset = "0x5E6B00", VA = "0x1805E7900")]
		public BuildableItemLoader()
		{
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x5E7800", Offset = "0x5E6A00", VA = "0x1805E7800", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x5E7600", Offset = "0x5E6800", VA = "0x1805E7600", Slot = "7")]
		public virtual void Load(DynamicSaveData data)
		{
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x5E75B0", Offset = "0x5E67B0", VA = "0x1805E75B0")]
		public BuildableItemData GetBuildableItemData(string mainPath)
		{
			return null;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A0A")]
		protected T GetData<T>(string mainPath) where T : BuildableItemData
		{
			return null;
		}
	}
}
