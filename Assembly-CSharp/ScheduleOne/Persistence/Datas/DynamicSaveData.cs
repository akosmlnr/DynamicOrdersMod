using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200045F RID: 1119
	[Token(Token = "0x200045F")]
	[Serializable]
	public class DynamicSaveData : SaveData
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x603F30", Offset = "0x603130", VA = "0x180603F30")]
		public DynamicSaveData(SaveData baseData)
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x603A70", Offset = "0x602C70", VA = "0x180603A70")]
		public void AddData(string name, string contents)
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x603CC0", Offset = "0x602EC0", VA = "0x180603CC0")]
		public void AddData(string name, SaveData data)
		{
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x603D20", Offset = "0x602F20", VA = "0x180603D20")]
		public string GetData(string name)
		{
			return null;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x603EA0", Offset = "0x6030A0", VA = "0x180603EA0")]
		public bool TryGetData(string name, out string data)
		{
			return default(bool);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A9D")]
		public T GetData<T>(string name, bool warn = true) where T : SaveData
		{
			return null;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x6001A9E")]
		public bool TryGetData<T>(string name, out T data) where T : SaveData
		{
			return default(bool);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001A9F")]
		public T ExtractBaseData<T>() where T : SaveData
		{
			return null;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x6001AA0")]
		public bool TryExtractBaseData<T>(out T data) where T : SaveData
		{
			return default(bool);
		}

		// Token: 0x04001657 RID: 5719
		[Token(Token = "0x4001657")]
		[FieldOffset(Offset = "0x28")]
		public string BaseData;

		// Token: 0x04001658 RID: 5720
		[Token(Token = "0x4001658")]
		[FieldOffset(Offset = "0x30")]
		public List<DynamicSaveData.AdditionalData> AdditionalDatas;

		// Token: 0x02000460 RID: 1120
		[Token(Token = "0x2000460")]
		[Serializable]
		public class AdditionalData
		{
			// Token: 0x06001AA1 RID: 6817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AA1")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public AdditionalData()
			{
			}

			// Token: 0x04001659 RID: 5721
			[Token(Token = "0x4001659")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x0400165A RID: 5722
			[Token(Token = "0x400165A")]
			[FieldOffset(Offset = "0x18")]
			public string Contents;
		}
	}
}
