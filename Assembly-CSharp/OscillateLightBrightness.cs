using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000066 RID: 102
[Token(Token = "0x2000066")]
public class OscillateLightBrightness : MonoBehaviour
{
	// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x571880", Offset = "0x570A80", VA = "0x180571880")]
	private void Start()
	{
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x5718D0", Offset = "0x570AD0", VA = "0x1805718D0")]
	private void Update()
	{
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public OscillateLightBrightness()
	{
	}

	// Token: 0x040001FD RID: 509
	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x20")]
	private Light lightComponent;

	// Token: 0x040001FE RID: 510
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(0f, 10f)]
	private float lower;

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Range(0f, 10f)]
	private float upper;
}
