using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000048 RID: 72
[Token(Token = "0x2000048")]
public class RandomMaterial : MonoBehaviour
{
	// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x55E3E0", Offset = "0x55D5E0", VA = "0x18055E3E0")]
	public void Start()
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x55E3E0", Offset = "0x55D5E0", VA = "0x18055E3E0")]
	public void ChangeMaterial()
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public RandomMaterial()
	{
	}

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x20")]
	public Renderer targetRenderer;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x28")]
	public Material[] materials;
}
