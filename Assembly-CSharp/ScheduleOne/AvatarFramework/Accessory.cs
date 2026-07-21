using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	public class Accessory : MonoBehaviour
	{
		// Token: 0x0600361A RID: 13850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x7C3710", Offset = "0x7C2910", VA = "0x1807C3710")]
		private void Awake()
		{
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600361B")]
		[Address(RVA = "0x7C3480", Offset = "0x7C2680", VA = "0x1807C3480")]
		public void ApplyColor(Color col)
		{
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x7C3640", Offset = "0x7C2840", VA = "0x1807C3640")]
		public void ApplyShapeKeys(float gender, float weight)
		{
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x7C3790", Offset = "0x7C2990", VA = "0x1807C3790")]
		public void BindBones(Transform[] bones)
		{
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x7C3800", Offset = "0x7C2A00", VA = "0x1807C3800")]
		public Accessory()
		{
		}

		// Token: 0x04002717 RID: 10007
		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public string Name;

		// Token: 0x04002718 RID: 10008
		[Token(Token = "0x4002718")]
		[FieldOffset(Offset = "0x28")]
		public string AssetPath;

		// Token: 0x04002719 RID: 10009
		[Token(Token = "0x4002719")]
		[FieldOffset(Offset = "0x30")]
		public bool ReduceFootSize;

		// Token: 0x0400271A RID: 10010
		[Token(Token = "0x400271A")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float FootSizeReduction;

		// Token: 0x0400271B RID: 10011
		[Token(Token = "0x400271B")]
		[FieldOffset(Offset = "0x38")]
		public bool ShouldBlockHair;

		// Token: 0x0400271C RID: 10012
		[Token(Token = "0x400271C")]
		[FieldOffset(Offset = "0x39")]
		public bool ColorAllMeshes;

		// Token: 0x0400271D RID: 10013
		[Token(Token = "0x400271D")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public MeshRenderer[] meshesToColor;

		// Token: 0x0400271E RID: 10014
		[Token(Token = "0x400271E")]
		[FieldOffset(Offset = "0x48")]
		public SkinnedMeshRenderer[] skinnedMeshesToColor;

		// Token: 0x0400271F RID: 10015
		[Token(Token = "0x400271F")]
		[FieldOffset(Offset = "0x50")]
		public SkinnedMeshRenderer[] skinnedMeshesToBind;

		// Token: 0x04002720 RID: 10016
		[Token(Token = "0x4002720")]
		[FieldOffset(Offset = "0x58")]
		public SkinnedMeshRenderer[] shapeKeyMeshRends;
	}
}
