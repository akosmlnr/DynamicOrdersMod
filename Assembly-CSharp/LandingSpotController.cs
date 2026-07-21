using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000054 RID: 84
[Token(Token = "0x2000054")]
public class LandingSpotController : MonoBehaviour
{
	// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x55B850", Offset = "0x55AA50", VA = "0x18055B850")]
	public void Start()
	{
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x55B700", Offset = "0x55A900", VA = "0x18055B700")]
	public void ScareAll()
	{
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x55B5A0", Offset = "0x55A7A0", VA = "0x18055B5A0")]
	public void ScareAll(float minDelay, float maxDelay)
	{
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x55B450", Offset = "0x55A650", VA = "0x18055B450")]
	public void LandAll()
	{
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x55B350", Offset = "0x55A550", VA = "0x18055B350")]
	public IEnumerator InstantLandOnStart(float delay)
	{
		return null;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x55B3D0", Offset = "0x55A5D0", VA = "0x18055B3D0")]
	public IEnumerator InstantLand(float delay)
	{
		return null;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x55BAD0", Offset = "0x55ACD0", VA = "0x18055BAD0")]
	public LandingSpotController()
	{
	}

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x20")]
	public bool _randomRotate;

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 _autoCatchDelay;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 _autoDismountDelay;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x34")]
	public float _maxBirdDistance;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x38")]
	public float _minBirdDistance;

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x3C")]
	public bool _takeClosest;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x40")]
	public FlockController _flock;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x48")]
	public bool _landOnStart;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x49")]
	public bool _soarLand;

	// Token: 0x0400016E RID: 366
	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x4A")]
	public bool _onlyBirdsAbove;

	// Token: 0x0400016F RID: 367
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x4C")]
	public float _landingSpeedModifier;

	// Token: 0x04000170 RID: 368
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x50")]
	public float _landingTurnSpeedModifier;

	// Token: 0x04000171 RID: 369
	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x58")]
	public Transform _featherPS;

	// Token: 0x04000172 RID: 370
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x60")]
	public Transform _thisT;

	// Token: 0x04000173 RID: 371
	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x68")]
	public int _activeLandingSpots;

	// Token: 0x04000174 RID: 372
	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x6C")]
	public float _snapLandDistance;

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x70")]
	public float _landedRotateSpeed;

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x74")]
	public float _gizmoSize;
}
