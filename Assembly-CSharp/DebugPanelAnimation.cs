using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
[RequireComponent(typeof(Image))]
public class DebugPanelAnimation : MonoBehaviour
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x552380", Offset = "0x551580", VA = "0x180552380")]
	private void Awake()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x552540", Offset = "0x551740", VA = "0x180552540")]
	private void Update()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x552470", Offset = "0x551670", VA = "0x180552470")]
	public void Play()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x552760", Offset = "0x551960", VA = "0x180552760")]
	public DebugPanelAnimation()
	{
	}

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	[Header("Target Image")]
	public Image targetImage;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	[Header("Animation Settings")]
	public DebugPanelAnimation.AnimationType animationType;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve alphaCurve;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x38")]
	public float duration;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x3C")]
	private float timer;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x40")]
	private bool isPlaying;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x44")]
	private Color originalColor;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 originalScale;

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public enum AnimationType
	{
		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		Alpha,
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		Scale
	}
}
