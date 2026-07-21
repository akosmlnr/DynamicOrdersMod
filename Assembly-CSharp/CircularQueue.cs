using System;
using Il2CppDummyDll;
using Unity.Collections;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
public class CircularQueue<T> where T : struct
{
	// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009F")]
	public CircularQueue(int capacity)
	{
	}

	// Token: 0x17000009 RID: 9
	[Token(Token = "0x17000009")]
	public T this[int i]
	{
		[Token(Token = "0x60000A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x1700000A")]
	public int Capacity
	{
		[Token(Token = "0x60000A1")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x1700000B")]
	public int Count
	{
		[Token(Token = "0x60000A2")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A3")]
	public void Enqueue(T item)
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A4")]
	public void Dequeue()
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A5")]
	public void Clear()
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x60000A6")]
	private int modulo(int i, int m)
	{
		return 0;
	}

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x0")]
	public NativeArray<T> q;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x0")]
	private int idx;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x0")]
	private int cap;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x0")]
	private int length;
}
