using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000033 RID: 51
[Token(Token = "0x2000033")]
[ExecuteAlways]
public class CircularTextMeshPro : MonoBehaviour
{
	// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x551720", Offset = "0x550920", VA = "0x180551720")]
	private void Reset()
	{
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x551380", Offset = "0x550580", VA = "0x180551380")]
	private void Awake()
	{
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x551510", Offset = "0x550710", VA = "0x180551510")]
	private void OnEnable()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x551420", Offset = "0x550620", VA = "0x180551420")]
	private void OnDisable()
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x5515F0", Offset = "0x5507F0", VA = "0x1805515F0")]
	private void OnValidate()
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x551600", Offset = "0x550800", VA = "0x180551600")]
	private void ReactToTextChanged(global::UnityEngine.Object obj)
	{
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x551780", Offset = "0x550980", VA = "0x180551780")]
	private void WarpText()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x5520C0", Offset = "0x5512C0", VA = "0x1805520C0")]
	public CircularTextMeshPro()
	{
	}

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Text text;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve vertexCurve;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x30")]
	public float yCurveScaling;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x34")]
	private bool isForceUpdatingMesh;
}
