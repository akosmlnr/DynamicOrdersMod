using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class ActionList
{
	// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x54E050", Offset = "0x54D250", VA = "0x18054E050")]
	public ActionList(bool shuffleCallbackList = false)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
	public List<Action> GetInvocationList()
	{
		return null;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x54DF50", Offset = "0x54D150", VA = "0x18054DF50")]
	public void InvokeAll()
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x54DDB0", Offset = "0x54CFB0", VA = "0x18054DDB0")]
	public void InvokeAllStaggered(float staggerTime)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x54DD50", Offset = "0x54CF50", VA = "0x18054DD50")]
	public void Clear()
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x54DCA0", Offset = "0x54CEA0", VA = "0x18054DCA0")]
	private void Add(Action action)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x54DFF0", Offset = "0x54D1F0", VA = "0x18054DFF0")]
	private void Remove(Action action)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x54E0E0", Offset = "0x54D2E0", VA = "0x18054E0E0")]
	public static ActionList operator +(ActionList list, Action action)
	{
		return null;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x54E1A0", Offset = "0x54D3A0", VA = "0x18054E1A0")]
	public static ActionList operator -(ActionList list, Action action)
	{
		return null;
	}

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<Action> list;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x18")]
	private bool _shuffleCallbackList;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x19")]
	private bool _shuffleBeforeNextInvoke;
}
