using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	public class SurfaceItemLoader : BuildableItemLoader
	{
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004FB")]
		public override string ItemType
		{
			[Token(Token = "0x6001A70")]
			[Address(RVA = "0x619C60", Offset = "0x618E60", VA = "0x180619C60", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public SurfaceItemLoader()
		{
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x6199B0", Offset = "0x618BB0", VA = "0x1806199B0", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x6199C0", Offset = "0x618BC0", VA = "0x1806199C0", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x6195C0", Offset = "0x6187C0", VA = "0x1806195C0")]
		protected SurfaceItem LoadAndCreate(string mainPath)
		{
			return null;
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x619730", Offset = "0x618930", VA = "0x180619730")]
		protected SurfaceItem LoadAndCreate(SurfaceItemData data)
		{
			return null;
		}
	}
}
