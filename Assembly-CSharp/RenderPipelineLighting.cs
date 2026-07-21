using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006A RID: 106
[Token(Token = "0x200006A")]
[ExecuteInEditMode]
public class RenderPipelineLighting : MonoBehaviour
{
	// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
	private void OnValidate()
	{
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
	private void Awake()
	{
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public RenderPipelineLighting()
	{
	}

	// Token: 0x0400020D RID: 525
	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _standardLighting;

	// Token: 0x0400020E RID: 526
	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material _standardSky;

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material _standardTerrain;

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _universalLighting;

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material _universalSky;

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Material _universalTerrain;

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _highDefinitionLighting;

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Material _highDefinitionSky;

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Material _highDefinitionTerrain;
}
