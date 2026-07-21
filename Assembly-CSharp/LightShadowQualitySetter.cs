using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
public class LightShadowQualitySetter : MonoBehaviour
{
	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x55D700", Offset = "0x55C900", VA = "0x18055D700")]
	private void Awake()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x55D770", Offset = "0x55C970", VA = "0x18055D770")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x55D810", Offset = "0x55CA10", VA = "0x18055D810")]
	private void Start()
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x55D7E0", Offset = "0x55C9E0", VA = "0x18055D7E0")]
	private void OnQualityChange(int previousIdx, int newIdx)
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x55D840", Offset = "0x55CA40", VA = "0x18055D840")]
	private void ToggleAdditionalLightShadows(bool on)
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x55DA70", Offset = "0x55CC70", VA = "0x18055DA70")]
	public LightShadowQualitySetter()
	{
	}

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<Light, LightShadows> originalLightShadows;
}
