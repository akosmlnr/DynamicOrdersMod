using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004F RID: 79
[Token(Token = "0x200004F")]
public class FlockScare : MonoBehaviour
{
	// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x557340", Offset = "0x556540", VA = "0x180557340")]
	private void CheckProximityToLandingSpots()
	{
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x557650", Offset = "0x556850", VA = "0x180557650")]
	private void IterateLandingSpots()
	{
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x5571D0", Offset = "0x5563D0", VA = "0x1805571D0")]
	private bool CheckDistanceToLandingSpot(LandingSpotController lc)
	{
		return default(bool);
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x5575C0", Offset = "0x5567C0", VA = "0x1805575C0")]
	private void Invoker()
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x557730", Offset = "0x556930", VA = "0x180557730")]
	private void OnEnable()
	{
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x5576F0", Offset = "0x5568F0", VA = "0x1805576F0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x557800", Offset = "0x556A00", VA = "0x180557800")]
	public FlockScare()
	{
	}

	// Token: 0x0400014C RID: 332
	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x20")]
	public LandingSpotController[] landingSpotControllers;

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x28")]
	public float scareInterval;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x2C")]
	public float distanceToScare;

	// Token: 0x0400014F RID: 335
	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x30")]
	public int checkEveryNthLandingSpot;

	// Token: 0x04000150 RID: 336
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x34")]
	public int InvokeAmounts;

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x38")]
	private int lsc;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x3C")]
	private int ls;

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x40")]
	private LandingSpotController currentController;
}
