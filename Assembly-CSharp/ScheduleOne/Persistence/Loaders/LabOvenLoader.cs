using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	public class LabOvenLoader : GridItemLoader
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004F0")]
		public override string ItemType
		{
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x5EE940", Offset = "0x5EDB40", VA = "0x1805EE940", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x5E67C0", Offset = "0x5E59C0", VA = "0x1805E67C0")]
		public LabOvenLoader()
		{
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A33")]
		[Address(RVA = "0x5EDDB0", Offset = "0x5ECFB0", VA = "0x1805EDDB0", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x5EE280", Offset = "0x5ED480", VA = "0x1805EE280", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
