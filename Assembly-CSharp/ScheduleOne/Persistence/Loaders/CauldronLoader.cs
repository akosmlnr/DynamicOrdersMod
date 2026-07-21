using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	public class CauldronLoader : GridItemLoader
	{
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004EA")]
		public override string ItemType
		{
			[Token(Token = "0x6001A0B")]
			[Address(RVA = "0x5E96A0", Offset = "0x5E88A0", VA = "0x1805E96A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public CauldronLoader()
		{
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x5E8BE0", Offset = "0x5E7DE0", VA = "0x1805E8BE0", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x5E9010", Offset = "0x5E8210", VA = "0x1805E9010", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
