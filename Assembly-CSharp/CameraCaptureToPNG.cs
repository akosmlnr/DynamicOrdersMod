using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
public class CameraCaptureToPNG : MonoBehaviour
{
	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x550500", Offset = "0x54F700", VA = "0x180550500")]
	private void Update()
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x550490", Offset = "0x54F690", VA = "0x180550490")]
	private IEnumerator CaptureCameraView()
	{
		return null;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x550590", Offset = "0x54F790", VA = "0x180550590")]
	public CameraCaptureToPNG()
	{
	}

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x20")]
	public Camera targetCamera;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x28")]
	public int width;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x2C")]
	public int height;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x30")]
	public KeyCode captureKey;
}
