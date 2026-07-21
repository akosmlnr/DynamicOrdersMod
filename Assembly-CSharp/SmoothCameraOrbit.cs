using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004B RID: 75
[Token(Token = "0x200004B")]
[AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : MonoBehaviour
{
	// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x560650", Offset = "0x55F850", VA = "0x180560650")]
	private void Start()
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x560650", Offset = "0x55F850", VA = "0x180560650")]
	private void OnEnable()
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x55FBB0", Offset = "0x55EDB0", VA = "0x18055FBB0")]
	public void Init()
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x560020", Offset = "0x55F220", VA = "0x180560020")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x55FB70", Offset = "0x55ED70", VA = "0x18055FB70")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x560660", Offset = "0x55F860", VA = "0x180560660")]
	public SmoothCameraOrbit()
	{
	}

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 targetOffset;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x34")]
	public float distance;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x38")]
	public float maxDistance;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x3C")]
	public float minDistance;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x40")]
	public float xSpeed;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x44")]
	public float ySpeed;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x48")]
	public int yMinLimit;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x4C")]
	public int yMaxLimit;

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x50")]
	public int zoomRate;

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x54")]
	public float panSpeed;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x58")]
	public float zoomDampening;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x5C")]
	public float autoRotate;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x60")]
	public float autoRotateSpeed;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x64")]
	private float xDeg;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x68")]
	private float yDeg;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x6C")]
	private float currentDistance;

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x70")]
	private float desiredDistance;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x74")]
	private Quaternion currentRotation;

	// Token: 0x040000F2 RID: 242
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x84")]
	private Quaternion desiredRotation;

	// Token: 0x040000F3 RID: 243
	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x94")]
	private Quaternion rotation;

	// Token: 0x040000F4 RID: 244
	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 position;

	// Token: 0x040000F5 RID: 245
	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0xB0")]
	private float idleTimer;

	// Token: 0x040000F6 RID: 246
	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0xB4")]
	private float idleSmooth;
}
