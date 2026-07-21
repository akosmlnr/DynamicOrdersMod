using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	public class GraffitiLoader : Loader
	{
		// Token: 0x06001960 RID: 6496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public GraffitiLoader()
		{
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x5ECC40", Offset = "0x5EBE40", VA = "0x1805ECC40", Slot = "4")]
		public override void Load(string mainPath)
		{
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x5ECA90", Offset = "0x5EBC90", VA = "0x1805ECA90")]
		private void LoadSpraySurface(WorldSpraySurfaceData surfaceData)
		{
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x5EC9F0", Offset = "0x5EBBF0", VA = "0x1805EC9F0")]
		private void EnsureStrokesHaveValidSize(SpraySurfaceData surfaceData)
		{
		}
	}
}
