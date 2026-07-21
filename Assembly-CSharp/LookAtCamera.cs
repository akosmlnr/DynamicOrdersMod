using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004A RID: 74
[Token(Token = "0x200004A")]
public class LookAtCamera : MonoBehaviour
{
	// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x55DDF0", Offset = "0x55CFF0", VA = "0x18055DDF0")]
	public void Start()
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x55DEB0", Offset = "0x55D0B0", VA = "0x18055DEB0")]
	public void Update()
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x55DDA0", Offset = "0x55CFA0", VA = "0x18055DDA0")]
	public void LookCam()
	{
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public LookAtCamera()
	{
	}

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x20")]
	public Camera lookAtCamera;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x28")]
	public bool lookOnlyOnAwake;
}
