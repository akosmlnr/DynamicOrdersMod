using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
public class LightningLightController : MonoBehaviour
{
	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x55DBF0", Offset = "0x55CDF0", VA = "0x18055DBF0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x55DB60", Offset = "0x55CD60", VA = "0x18055DB60")]
	private void OnDisable()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x55DAF0", Offset = "0x55CCF0", VA = "0x18055DAF0")]
	private IEnumerator DoStrikeRoutine()
	{
		return null;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x55DD80", Offset = "0x55CF80", VA = "0x18055DD80")]
	public LightningLightController()
	{
	}

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x20")]
	[Header("Light Entries (max 4)")]
	public LightningLightController.LightEntry[] lightEntries;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x28")]
	[Header("Auto-Strike Timing")]
	public float minTimeBetweenStrikes;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x2C")]
	public float maxTimeBetweenStrikes;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine _strikeCo;

	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[Serializable]
	public class LightEntry
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x55D6E0", Offset = "0x55C8E0", VA = "0x18055D6E0")]
		public LightEntry()
		{
		}

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x10")]
		public Light light;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve flashCurve;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x20")]
		public float maxIntensity;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x24")]
		public float strikeDuration;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x28")]
		public float startDelay;
	}
}
