using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200042D RID: 1069
	[Token(Token = "0x200042D")]
	public class BrickPressLoader : GridItemLoader
	{
		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004E7")]
		public override string ItemType
		{
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x5E7530", Offset = "0x5E6730", VA = "0x1805E7530", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019FD")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public BrickPressLoader()
		{
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x5E6BF0", Offset = "0x5E5DF0", VA = "0x1805E6BF0", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x5E6FA0", Offset = "0x5E61A0", VA = "0x1805E6FA0", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
