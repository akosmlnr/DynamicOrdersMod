using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000067 RID: 103
[Token(Token = "0x2000067")]
[ExecuteAlways]
public class VolumetricFire : MonoBehaviour
{
	// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x578610", Offset = "0x577810", VA = "0x180578610")]
	private void Start()
	{
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x578320", Offset = "0x577520", VA = "0x180578320")]
	private void OnEnable()
	{
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x578290", Offset = "0x577490", VA = "0x180578290")]
	private void OnDisable()
	{
	}

	// Token: 0x060001EF RID: 495 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x578250", Offset = "0x577450", VA = "0x180578250")]
	private static bool IsVisible(Camera camera, Bounds bounds)
	{
		return default(bool);
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x5783B0", Offset = "0x5775B0", VA = "0x1805783B0")]
	private void RenderFlames(ScriptableRenderContext context, Camera camera)
	{
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x578560", Offset = "0x577760", VA = "0x180578560")]
	private void SetupMaterialPropertyBlock(float item)
	{
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x577C40", Offset = "0x576E40", VA = "0x180577C40")]
	private void CreateItem(float spacing, float item, Camera camera)
	{
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x578740", Offset = "0x577940", VA = "0x180578740")]
	public VolumetricFire()
	{
	}

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x20")]
	private Mesh mesh;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x28")]
	private Material material;

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Controls the number of additional meshes to render in front of and behind the original mesh")]
	[Range(1f, 20f)]
	[SerializeField]
	private int thickness;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x34")]
	[Tooltip("Controls the total distance between the frontmost mesh and the backmost mesh")]
	[SerializeField]
	[Range(0.01f, 1f)]
	private float spread;

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool billboard;

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x40")]
	private MaterialPropertyBlock materialPropertyBlock;

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x48")]
	private int internalCount;

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x4C")]
	private float randomStatic;

	// Token: 0x04000208 RID: 520
	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x50")]
	private Collider boundaryCollider;
}
