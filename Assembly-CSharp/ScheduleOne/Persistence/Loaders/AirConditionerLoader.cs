using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	public class AirConditionerLoader : GridItemLoader
	{
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E6")]
		public override string ItemType
		{
			[Token(Token = "0x60019F9")]
			[Address(RVA = "0x5E67D0", Offset = "0x5E59D0", VA = "0x1805E67D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public AirConditionerLoader()
		{
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x5E6380", Offset = "0x5E5580", VA = "0x1805E6380", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
