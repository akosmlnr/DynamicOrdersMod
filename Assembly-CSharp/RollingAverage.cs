using System;
using Il2CppDummyDll;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002E")]
public class RollingAverage<T>
{
	// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AC")]
	public RollingAverage(int capacity, Func<T, T, T> add, Func<T, T, T> sub, Func<T, float, T> div)
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000AD")]
	public void Add(T value)
	{
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000AE RID: 174 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x1700000C")]
	public T Average
	{
		[Token(Token = "0x60000AE")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000AF RID: 175 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x1700000D")]
	public int Count
	{
		[Token(Token = "0x60000AF")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000B0 RID: 176 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x1700000E")]
	public int Capacity
	{
		[Token(Token = "0x60000B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B1")]
	public void Clear()
	{
	}

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x0")]
	private readonly T[] buffer;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x0")]
	private readonly Func<T, T, T> add;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x0")]
	private readonly Func<T, T, T> sub;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x0")]
	private readonly Func<T, float, T> div;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x0")]
	private int head;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x0")]
	private int count;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x0")]
	private T sum;
}
