using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000047 RID: 71
[Token(Token = "0x2000047")]
public class RotateMoveCamera : MonoBehaviour
{
	// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x55EAD0", Offset = "0x55DCD0", VA = "0x18055EAD0")]
	private void Update()
	{
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x55ED30", Offset = "0x55DF30", VA = "0x18055ED30")]
	public RotateMoveCamera()
	{
	}

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Camera;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x28")]
	public float minX;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x2C")]
	public float maxX;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x30")]
	public float minY;

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x34")]
	public float maxY;

	// Token: 0x040000CF RID: 207
	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x38")]
	public float sensX;

	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x3C")]
	public float sensY;

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x40")]
	private float rotationY;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x44")]
	private float rotationX;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x48")]
	private float MouseX;

	// Token: 0x040000D4 RID: 212
	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x4C")]
	private float MouseY;
}
