using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00003030 File Offset: 0x00001230
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public VignetteModel.Settings settings
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x69E1E0", Offset = "0x69D3E0", VA = "0x18069E1E0")]
			get
			{
				return default(VignetteModel.Settings);
			}
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x69E210", Offset = "0x69D410", VA = "0x18069E210")]
			set
			{
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x69E0B0", Offset = "0x69D2B0", VA = "0x18069E0B0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x69E140", Offset = "0x69D340", VA = "0x18069E140")]
		public VignetteModel()
		{
		}

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private VignetteModel.Settings m_Settings;

		// Token: 0x020000D3 RID: 211
		[Token(Token = "0x20000D3")]
		public enum Mode
		{
			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			Classic,
			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			Masked
		}

		// Token: 0x020000D4 RID: 212
		[Token(Token = "0x20000D4")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000308 RID: 776 RVA: 0x00003048 File Offset: 0x00001248
			[Token(Token = "0x1700006D")]
			public static VignetteModel.Settings defaultSettings
			{
				[Token(Token = "0x6000308")]
				[Address(RVA = "0x69C790", Offset = "0x69B990", VA = "0x18069C790")]
				get
				{
					return default(VignetteModel.Settings);
				}
			}

			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x40003D9")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
			public VignetteModel.Mode mode;

			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			[FieldOffset(Offset = "0x4")]
			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			// Token: 0x040003DB RID: 987
			[Token(Token = "0x40003DB")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x040003DC RID: 988
			[Token(Token = "0x40003DC")]
			[FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			// Token: 0x040003DD RID: 989
			[Token(Token = "0x40003DD")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Smoothness of the vignette borders.")]
			[Range(0.01f, 1f)]
			public float smoothness;

			// Token: 0x040003DE RID: 990
			[Token(Token = "0x40003DE")]
			[FieldOffset(Offset = "0x24")]
			[Tooltip("Lower values will make a square-ish vignette.")]
			[Range(0f, 1f)]
			public float roundness;

			// Token: 0x040003DF RID: 991
			[Token(Token = "0x40003DF")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("A black and white mask to use as a vignette.")]
			public Texture mask;

			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x40003E0")]
			[FieldOffset(Offset = "0x30")]
			[Range(0f, 1f)]
			[Tooltip("Mask opacity.")]
			public float opacity;

			// Token: 0x040003E1 RID: 993
			[Token(Token = "0x40003E1")]
			[FieldOffset(Offset = "0x34")]
			[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
			public bool rounded;
		}
	}
}
