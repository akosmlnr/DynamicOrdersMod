using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000051 RID: 81
[Token(Token = "0x2000051")]
public class LandingButtons : MonoBehaviour
{
	// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x55ADF0", Offset = "0x559FF0", VA = "0x18055ADF0")]
	public void OnGUI()
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x55B340", Offset = "0x55A540", VA = "0x18055B340")]
	public LandingButtons()
	{
	}

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x20")]
	public LandingSpotController _landingSpotController;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x28")]
	public FlockController _flockController;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x30")]
	public float hSliderValue;
}
