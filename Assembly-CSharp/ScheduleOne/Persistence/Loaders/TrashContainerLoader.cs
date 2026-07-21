using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000455 RID: 1109
	[Token(Token = "0x2000455")]
	public class TrashContainerLoader : GridItemLoader
	{
		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004FE")]
		public override string ItemType
		{
			[Token(Token = "0x6001A7E")]
			[Address(RVA = "0x61B030", Offset = "0x61A230", VA = "0x18061B030", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x5EED30", Offset = "0x5EDF30", VA = "0x1805EED30")]
		public TrashContainerLoader()
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A80")]
		[Address(RVA = "0x61AE60", Offset = "0x61A060", VA = "0x18061AE60", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A81")]
		[Address(RVA = "0x61AC60", Offset = "0x619E60", VA = "0x18061AC60", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
