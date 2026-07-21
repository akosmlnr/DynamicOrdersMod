using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
[Serializable]
public class DynamicGradient
{
	// Token: 0x06000032 RID: 50 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x5529C0", Offset = "0x551BC0", VA = "0x1805529C0")]
	public Color Evaluate(float value)
	{
		return default(Color);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x552AC0", Offset = "0x551CC0", VA = "0x180552AC0")]
	public DynamicGradient()
	{
	}

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x10")]
	public Gradient Gradient;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	[Range(0f, 2f)]
	[SerializeField]
	private float _saturationMultiplier;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 2f)]
	[SerializeField]
	private float _brightnessMultiplier;
}
