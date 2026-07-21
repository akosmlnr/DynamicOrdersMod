using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000050 RID: 80
[Token(Token = "0x2000050")]
public class FlockWaypointTrigger : MonoBehaviour
{
	// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x557830", Offset = "0x556A30", VA = "0x180557830")]
	public void Start()
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x557930", Offset = "0x556B30", VA = "0x180557930")]
	public void Trigger()
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x557960", Offset = "0x556B60", VA = "0x180557960")]
	public FlockWaypointTrigger()
	{
	}

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x20")]
	public float _timer;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x28")]
	public FlockChild _flockChild;
}
