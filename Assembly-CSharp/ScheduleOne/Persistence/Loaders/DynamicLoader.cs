using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003EB RID: 1003
	[Token(Token = "0x20003EB")]
	public class DynamicLoader
	{
		// Token: 0x06001957 RID: 6487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x5EBF40", Offset = "0x5EB140", VA = "0x1805EBF40")]
		public void Load(string serializedDynamicSaveData)
		{
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		public virtual void Load(DynamicSaveData saveData)
		{
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001959")]
		public static T ExtractBaseData<T>(DynamicSaveData saveData) where T : SaveData
		{
			return null;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x600195A")]
		public static bool TryExtractBaseData<T>(DynamicSaveData saveData, out T baseData) where T : SaveData
		{
			return default(bool);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DynamicLoader()
		{
		}
	}
}
