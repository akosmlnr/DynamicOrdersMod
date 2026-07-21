using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000428 RID: 1064
	[Token(Token = "0x2000428")]
	public class NPCLoader : DynamicLoader
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E4")]
		public virtual string NPCType
		{
			[Token(Token = "0x60019EE")]
			[Address(RVA = "0x5F3730", Offset = "0x5F2930", VA = "0x1805F3730", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x5F3630", Offset = "0x5F2830", VA = "0x1805F3630")]
		public NPCLoader()
		{
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x5F3150", Offset = "0x5F2350", VA = "0x1805F3150", Slot = "4")]
		public override void Load(DynamicSaveData saveData)
		{
		}
	}
}
