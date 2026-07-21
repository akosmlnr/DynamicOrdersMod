using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[Serializable]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00002BF8 File Offset: 0x00000DF8
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		public AmbientOcclusionModel.Settings settings
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x524810", Offset = "0x523A10", VA = "0x180524810")]
			get
			{
				return default(AmbientOcclusionModel.Settings);
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x565570", Offset = "0x564770", VA = "0x180565570")]
			set
			{
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x5654C0", Offset = "0x5646C0", VA = "0x1805654C0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x565510", Offset = "0x564710", VA = "0x180565510")]
		public AmbientOcclusionModel()
		{
		}

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AmbientOcclusionModel.Settings m_Settings;

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		public enum SampleCount
		{
			// Token: 0x04000316 RID: 790
			[Token(Token = "0x4000316")]
			Lowest = 3,
			// Token: 0x04000317 RID: 791
			[Token(Token = "0x4000317")]
			Low = 6,
			// Token: 0x04000318 RID: 792
			[Token(Token = "0x4000318")]
			Medium = 10,
			// Token: 0x04000319 RID: 793
			[Token(Token = "0x4000319")]
			High = 16
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060002AA RID: 682 RVA: 0x00002C10 File Offset: 0x00000E10
			[Token(Token = "0x17000040")]
			public static AmbientOcclusionModel.Settings defaultSettings
			{
				[Token(Token = "0x60002AA")]
				[Address(RVA = "0x573B30", Offset = "0x572D30", VA = "0x180573B30")]
				get
				{
					return default(AmbientOcclusionModel.Settings);
				}
			}

			// Token: 0x0400031A RID: 794
			[Token(Token = "0x400031A")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 4f)]
			[Tooltip("Degree of darkness produced by the effect.")]
			public float intensity;

			// Token: 0x0400031B RID: 795
			[Token(Token = "0x400031B")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			[Min(0.0001f)]
			public float radius;

			// Token: 0x0400031C RID: 796
			[Token(Token = "0x400031C")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Number of sample points, which affects quality and performance.")]
			public AmbientOcclusionModel.SampleCount sampleCount;

			// Token: 0x0400031D RID: 797
			[Token(Token = "0x400031D")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Halves the resolution of the effect to increase performance at the cost of visual quality.")]
			public bool downsampling;

			// Token: 0x0400031E RID: 798
			[Token(Token = "0x400031E")]
			[FieldOffset(Offset = "0xD")]
			[Tooltip("Forces compatibility with Forward rendered objects when working with the Deferred rendering path.")]
			public bool forceForwardCompatibility;

			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			[FieldOffset(Offset = "0xE")]
			[Tooltip("Enables the ambient-only mode in that the effect only affects ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering.")]
			public bool ambientOnly;

			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			[FieldOffset(Offset = "0xF")]
			[Tooltip("Toggles the use of a higher precision depth texture with the forward rendering path (may impact performances). Has no effect with the deferred rendering path.")]
			public bool highPrecision;
		}
	}
}
