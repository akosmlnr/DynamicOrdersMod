using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	public class LabelledSurfaceItemLoader : SurfaceItemLoader
	{
		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170004EF")]
		public override string ItemType
		{
			[Token(Token = "0x6001A2D")]
			[Address(RVA = "0x5EED40", Offset = "0x5EDF40", VA = "0x1805EED40", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x5EED30", Offset = "0x5EDF30", VA = "0x1805EED30")]
		public LabelledSurfaceItemLoader()
		{
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0x5EEB80", Offset = "0x5EDD80", VA = "0x1805EEB80", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x5EE9C0", Offset = "0x5EDBC0", VA = "0x1805EE9C0", Slot = "7")]
		public override void Load(DynamicSaveData data)
		{
		}
	}
}
