using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000059 RID: 89
[Token(Token = "0x2000059")]
public class SwooshTest : MonoBehaviour
{
	// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x561370", Offset = "0x560570", VA = "0x180561370")]
	private void Start()
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x561460", Offset = "0x560660", VA = "0x180561460")]
	private void Update()
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x561530", Offset = "0x560730", VA = "0x180561530")]
	public SwooshTest()
	{
	}

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationClip _animation;

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x28")]
	private AnimationState _animationState;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _start;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int _end;

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x38")]
	private float _startN;

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x3C")]
	private float _endN;

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x40")]
	private float _time;

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x44")]
	private float _prevTime;

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x48")]
	private float _prevAnimTime;

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private MeleeWeaponTrail _trail;

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x58")]
	private bool _firstFrame;
}
