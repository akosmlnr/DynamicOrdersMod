using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class UnluckDistanceDisabler : MonoBehaviour
{
	// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x563560", Offset = "0x562760", VA = "0x180563560")]
	public void Start()
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x563520", Offset = "0x562720", VA = "0x180563520")]
	public void DisableOnStart()
	{
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x563320", Offset = "0x562520", VA = "0x180563320")]
	public void CheckDisable()
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x563420", Offset = "0x562620", VA = "0x180563420")]
	public void CheckEnable()
	{
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x563670", Offset = "0x562870", VA = "0x180563670")]
	public UnluckDistanceDisabler()
	{
	}

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x20")]
	public int _distanceDisable;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x28")]
	public Transform _distanceFrom;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x30")]
	public bool _distanceFromMainCam;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x34")]
	public float _disableCheckInterval;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x38")]
	public float _enableCheckInterval;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x3C")]
	public bool _disableOnStart;
}
