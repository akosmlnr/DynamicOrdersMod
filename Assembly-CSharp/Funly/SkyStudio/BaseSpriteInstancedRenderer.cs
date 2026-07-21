using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public abstract class BaseSpriteInstancedRenderer : MonoBehaviour
	{
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x000068D0 File Offset: 0x00004AD0
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000248")]
		public int maxSprites
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x4929C0", Offset = "0x491BC0", VA = "0x1804929C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000249")]
		protected Camera m_ViewerCamera
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x4CB630", Offset = "0x4CA830", VA = "0x1804CB630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x59B0A0", Offset = "0x59A2A0", VA = "0x18059B0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x9EFE70", Offset = "0x9EF070", VA = "0x1809EFE70")]
		private void Start()
		{
		}

		// Token: 0x06000A75 RID: 2677
		[Token(Token = "0x6000A75")]
		protected abstract Bounds CalculateMeshBounds();

		// Token: 0x06000A76 RID: 2678
		[Token(Token = "0x6000A76")]
		protected abstract BaseSpriteItemData CreateSpriteItemData();

		// Token: 0x06000A77 RID: 2679
		[Token(Token = "0x6000A77")]
		protected abstract bool IsRenderingEnabled();

		// Token: 0x06000A78 RID: 2680
		[Token(Token = "0x6000A78")]
		protected abstract int GetNextSpawnCount();

		// Token: 0x06000A79 RID: 2681
		[Token(Token = "0x6000A79")]
		protected abstract void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale);

		// Token: 0x06000A7A RID: 2682
		[Token(Token = "0x6000A7A")]
		protected abstract void ConfigureSpriteItemData(BaseSpriteItemData data);

		// Token: 0x06000A7B RID: 2683
		[Token(Token = "0x6000A7B")]
		protected abstract void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data);

		// Token: 0x06000A7C RID: 2684
		[Token(Token = "0x6000A7C")]
		protected abstract void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock);

		// Token: 0x06000A7D RID: 2685 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x9EEF90", Offset = "0x9EE190", VA = "0x1809EEF90")]
		private BaseSpriteItemData DequeueNextSpriteItemData()
		{
			return null;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x9EFDD0", Offset = "0x9EEFD0", VA = "0x1809EFDD0")]
		private void ReturnSpriteItemData(BaseSpriteItemData splash)
		{
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x9EF660", Offset = "0x9EE860", VA = "0x1809EF660", Slot = "12")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x9EF310", Offset = "0x9EE510", VA = "0x1809EF310")]
		private void GenerateNewSprites()
		{
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x9EEE00", Offset = "0x9EE000", VA = "0x1809EEE00")]
		private void AdvanceAllSprites()
		{
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x9EF6D0", Offset = "0x9EE8D0", VA = "0x1809EF6D0")]
		private void RenderAllSprites()
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x9EF590", Offset = "0x9EE790", VA = "0x1809EF590")]
		protected Mesh GetMesh()
		{
			return null;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x9EF040", Offset = "0x9EE240", VA = "0x1809EF040", Slot = "13")]
		protected virtual Mesh GenerateMesh()
		{
			return null;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x9EFF10", Offset = "0x9EF110", VA = "0x1809EFF10")]
		protected BaseSpriteInstancedRenderer()
		{
		}

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		public const int kArrayMaxSprites = 1000;

		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Mesh used to render the instances onto. If empty, a quad will be used.")]
		public Mesh modelMesh;

		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Sky Studio sprite sheet animated shader material.")]
		public Material renderMaterial;

		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x38")]
		protected Queue<BaseSpriteItemData> m_Available;

		// Token: 0x04000B3B RID: 2875
		[Token(Token = "0x4000B3B")]
		[FieldOffset(Offset = "0x40")]
		protected HashSet<BaseSpriteItemData> m_Active;

		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x48")]
		private MaterialPropertyBlock m_PropertyBlock;

		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0x50")]
		private Matrix4x4[] m_ModelMatrices;

		// Token: 0x04000B3E RID: 2878
		[Token(Token = "0x4000B3E")]
		[FieldOffset(Offset = "0x58")]
		private float[] m_StartTimes;

		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x4000B3F")]
		[FieldOffset(Offset = "0x60")]
		private float[] m_EndTimes;

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x68")]
		protected SpriteSheetData m_SpriteSheetLayout;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0x70")]
		protected Texture m_SpriteTexture;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0x78")]
		protected Color m_TintColor;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x90")]
		protected Mesh m_DefaltModelMesh;
	}
}
