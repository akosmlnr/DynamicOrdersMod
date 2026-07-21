using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
public class LandingSpot : MonoBehaviour
{
	// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x55D510", Offset = "0x55C710", VA = "0x18055D510")]
	public void Start()
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x55C8F0", Offset = "0x55BAF0", VA = "0x18055C8F0")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x55BFE0", Offset = "0x55B1E0", VA = "0x18055BFE0")]
	public void LateUpdate()
	{
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x55D630", Offset = "0x55C830", VA = "0x18055D630")]
	public void StraightenBird()
	{
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x55D200", Offset = "0x55C400", VA = "0x18055D200")]
	public void RotateBird()
	{
	}

	// Token: 0x0600015D RID: 349 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x55BB30", Offset = "0x55AD30", VA = "0x18055BB30")]
	public IEnumerator GetFlockChild(float minDelay, float maxDelay)
	{
		return null;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x55BBC0", Offset = "0x55ADC0", VA = "0x18055BBC0")]
	public void InstantLand()
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x55CE90", Offset = "0x55C090", VA = "0x18055CE90")]
	public void ReleaseFlockChild()
	{
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public LandingSpot()
	{
	}

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public FlockChild landingChild;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool landing;

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x2C")]
	private int lerpCounter;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public LandingSpotController _controller;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x38")]
	private bool _idle;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x40")]
	public Transform _thisT;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x48")]
	public bool _gotcha;
}
