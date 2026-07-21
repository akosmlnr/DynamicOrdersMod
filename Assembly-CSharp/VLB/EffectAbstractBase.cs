using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	[AddComponentMenu("")]
	public class EffectAbstractBase : MonoBehaviour
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00003390 File Offset: 0x00001590
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		[Obsolete("Use 'restoreIntensityOnDisable' instead")]
		public bool restoreBaseIntensity
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x6466D0", Offset = "0x6458D0", VA = "0x1806466D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x6466F0", Offset = "0x6458F0", VA = "0x1806466F0")]
			set
			{
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x693EF0", Offset = "0x6930F0", VA = "0x180693EF0", Slot = "4")]
		public virtual void InitFrom(EffectAbstractBase Source)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x693E70", Offset = "0x693070", VA = "0x180693E70")]
		private void GetIntensity(VolumetricLightBeamSD beam)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x693E00", Offset = "0x693000", VA = "0x180693E00")]
		private void GetIntensity(VolumetricLightBeamHD beam)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x694290", Offset = "0x693490", VA = "0x180694290")]
		private void SetIntensity(VolumetricLightBeamSD beam, float additive)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x694330", Offset = "0x693530", VA = "0x180694330")]
		private void SetIntensity(VolumetricLightBeamHD beam, float additive)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x693FB0", Offset = "0x6931B0", VA = "0x180693FB0")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x693BB0", Offset = "0x692DB0", VA = "0x180693BB0")]
		private void Awake()
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x693FA0", Offset = "0x6931A0", VA = "0x180693FA0", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x693F70", Offset = "0x693170", VA = "0x180693F70")]
		private void OnDisable()
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x6943F0", Offset = "0x6935F0", VA = "0x1806943F0")]
		public EffectAbstractBase()
		{
		}

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		public const string ClassName = "EffectAbstractBase";

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x20")]
		public EffectAbstractBase.ComponentsToChange componentsToChange;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("restoreBaseIntensity")]
		public bool restoreIntensityOnDisable;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x28")]
		protected VolumetricLightBeamAbstractBase m_Beam;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x30")]
		protected Light m_Light;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x38")]
		protected VolumetricDustParticles m_Particles;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x40")]
		protected float m_BaseIntensityBeamInside;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x44")]
		protected float m_BaseIntensityBeamOutside;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x48")]
		protected float m_BaseIntensityLight;

		// Token: 0x020000F5 RID: 245
		[Token(Token = "0x20000F5")]
		[Flags]
		public enum ComponentsToChange
		{
			// Token: 0x040004F3 RID: 1267
			[Token(Token = "0x40004F3")]
			UnityLight = 1,
			// Token: 0x040004F4 RID: 1268
			[Token(Token = "0x40004F4")]
			VolumetricLightBeam = 2,
			// Token: 0x040004F5 RID: 1269
			[Token(Token = "0x40004F5")]
			VolumetricDustParticles = 4
		}
	}
}
