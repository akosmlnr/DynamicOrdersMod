using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	public class SoilPourerLoader : GridItemLoader
	{
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004F8")]
		public override string ItemType
		{
			[Token(Token = "0x6001A63")]
			[Address(RVA = "0x6188C0", Offset = "0x617AC0", VA = "0x1806188C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x5EED30", Offset = "0x5EDF30", VA = "0x1805EED30")]
		public SoilPourerLoader()
		{
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x618710", Offset = "0x617910", VA = "0x180618710", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A66")]
		[Address(RVA = "0x618520", Offset = "0x617720", VA = "0x180618520", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
