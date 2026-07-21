using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

// Token: 0x0200004D RID: 77
[Token(Token = "0x200004D")]
[RequireComponent(typeof(AudioSource))]
public class FlockChildSound : MonoBehaviour
{
	// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x5537C0", Offset = "0x5529C0", VA = "0x1805537C0")]
	public void Start()
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x553540", Offset = "0x552740", VA = "0x180553540")]
	public void PlayRandomSound()
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x553690", Offset = "0x552890", VA = "0x180553690")]
	public void ScareSound()
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x5538C0", Offset = "0x552AC0", VA = "0x1805538C0")]
	public FlockChildSound()
	{
	}

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x20")]
	public AudioSourceController controller;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip[] _idleSounds;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x30")]
	public float _idleSoundRandomChance;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip[] _flightSounds;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x40")]
	public float _flightSoundRandomChance;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip[] _scareSounds;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x50")]
	public float _pitchMin;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x54")]
	public float _pitchMax;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x58")]
	public float _volumeMin;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x5C")]
	public float _volumeMax;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x60")]
	private FlockChild _flockChild;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x68")]
	private AudioSource _audio;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x70")]
	private bool _hasLanded;
}
