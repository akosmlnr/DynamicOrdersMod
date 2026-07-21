using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	[Serializable]
	public class GenericSaveData : SaveData
	{
		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x604AD0", Offset = "0x603CD0", VA = "0x180604AD0")]
		public GenericSaveData(string guid)
		{
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x6044D0", Offset = "0x6036D0", VA = "0x1806044D0")]
		public void Add(string key, bool value)
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x6043D0", Offset = "0x6035D0", VA = "0x1806043D0")]
		public void Add(string key, float value)
		{
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x6045D0", Offset = "0x6037D0", VA = "0x1806045D0")]
		public void Add(string key, int value)
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x6042C0", Offset = "0x6034C0", VA = "0x1806042C0")]
		public void Add(string key, string value)
		{
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x6046D0", Offset = "0x6038D0", VA = "0x1806046D0")]
		public bool GetBool(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x6047D0", Offset = "0x6039D0", VA = "0x1806047D0")]
		public float GetFloat(string key, float defaultValue = 0f)
		{
			return 0f;
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x6048D0", Offset = "0x603AD0", VA = "0x1806048D0")]
		public int GetInt(string key, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x6049D0", Offset = "0x603BD0", VA = "0x1806049D0")]
		public string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		// Token: 0x04001664 RID: 5732
		[Token(Token = "0x4001664")]
		[FieldOffset(Offset = "0x28")]
		public string GUID;

		// Token: 0x04001665 RID: 5733
		[Token(Token = "0x4001665")]
		[FieldOffset(Offset = "0x30")]
		public List<GenericSaveData.BoolValue> boolValues;

		// Token: 0x04001666 RID: 5734
		[Token(Token = "0x4001666")]
		[FieldOffset(Offset = "0x38")]
		public List<GenericSaveData.FloatValue> floatValues;

		// Token: 0x04001667 RID: 5735
		[Token(Token = "0x4001667")]
		[FieldOffset(Offset = "0x40")]
		public List<GenericSaveData.IntValue> intValues;

		// Token: 0x04001668 RID: 5736
		[Token(Token = "0x4001668")]
		[FieldOffset(Offset = "0x48")]
		public List<GenericSaveData.StringValue> stringValues;

		// Token: 0x02000466 RID: 1126
		[Token(Token = "0x2000466")]
		[Serializable]
		public class BoolValue
		{
			// Token: 0x06001AB1 RID: 6833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AB1")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public BoolValue()
			{
			}

			// Token: 0x04001669 RID: 5737
			[Token(Token = "0x4001669")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x0400166A RID: 5738
			[Token(Token = "0x400166A")]
			[FieldOffset(Offset = "0x18")]
			public bool value;
		}

		// Token: 0x02000467 RID: 1127
		[Token(Token = "0x2000467")]
		[Serializable]
		public class FloatValue
		{
			// Token: 0x06001AB2 RID: 6834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public FloatValue()
			{
			}

			// Token: 0x0400166B RID: 5739
			[Token(Token = "0x400166B")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x0400166C RID: 5740
			[Token(Token = "0x400166C")]
			[FieldOffset(Offset = "0x18")]
			public float value;
		}

		// Token: 0x02000468 RID: 1128
		[Token(Token = "0x2000468")]
		[Serializable]
		public class IntValue
		{
			// Token: 0x06001AB3 RID: 6835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AB3")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public IntValue()
			{
			}

			// Token: 0x0400166D RID: 5741
			[Token(Token = "0x400166D")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x0400166E RID: 5742
			[Token(Token = "0x400166E")]
			[FieldOffset(Offset = "0x18")]
			public int value;
		}

		// Token: 0x02000469 RID: 1129
		[Token(Token = "0x2000469")]
		[Serializable]
		public class StringValue
		{
			// Token: 0x06001AB4 RID: 6836 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public StringValue()
			{
			}

			// Token: 0x0400166F RID: 5743
			[Token(Token = "0x400166F")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x04001670 RID: 5744
			[Token(Token = "0x4001670")]
			[FieldOffset(Offset = "0x18")]
			public string value;
		}
	}
}
