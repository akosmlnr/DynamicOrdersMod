using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Trash
{
	// Token: 0x020007C9 RID: 1993
	[Token(Token = "0x20007C9")]
	public class TrashBag : TrashItem
	{
		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600353D RID: 13629 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600353E RID: 13630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000866")]
		public TrashContent Content
		{
			[Token(Token = "0x600353D")]
			[Address(RVA = "0x4B47B0", Offset = "0x4B39B0", VA = "0x1804B47B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600353E")]
			[Address(RVA = "0x4B5320", Offset = "0x4B4520", VA = "0x1804B5320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600353F")]
		[Address(RVA = "0x7D2AE0", Offset = "0x7D1CE0", VA = "0x1807D2AE0")]
		public void LoadContent(TrashContentData data)
		{
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003540")]
		[Address(RVA = "0x7D2980", Offset = "0x7D1B80", VA = "0x1807D2980", Slot = "32")]
		public override TrashItemData GetData()
		{
			return null;
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003541")]
		[Address(RVA = "0x7D2B10", Offset = "0x7D1D10", VA = "0x1807D2B10")]
		public TrashBag()
		{
		}
	}
}
