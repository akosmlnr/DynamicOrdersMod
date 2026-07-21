using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	public class JukeboxLoader : GridItemLoader
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004EE")]
		public override string ItemType
		{
			[Token(Token = "0x6001A29")]
			[Address(RVA = "0x5EDD30", Offset = "0x5ECF30", VA = "0x1805EDD30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public JukeboxLoader()
		{
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x5EDAE0", Offset = "0x5ECCE0", VA = "0x1805EDAE0", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x5ED680", Offset = "0x5EC880", VA = "0x1805ED680", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
