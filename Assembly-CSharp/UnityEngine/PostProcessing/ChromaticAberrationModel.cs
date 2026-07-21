using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	[Serializable]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00002D90 File Offset: 0x00000F90
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		public ChromaticAberrationModel.Settings settings
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x524810", Offset = "0x523A10", VA = "0x180524810")]
			get
			{
				return default(ChromaticAberrationModel.Settings);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x691360", Offset = "0x690560", VA = "0x180691360")]
			set
			{
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x691270", Offset = "0x690470", VA = "0x180691270", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x6912E0", Offset = "0x6904E0", VA = "0x1806912E0")]
		public ChromaticAberrationModel()
		{
		}

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ChromaticAberrationModel.Settings m_Settings;

		// Token: 0x020000AF RID: 175
		[Token(Token = "0x20000AF")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060002CA RID: 714 RVA: 0x00002DA8 File Offset: 0x00000FA8
			[Token(Token = "0x17000050")]
			public static ChromaticAberrationModel.Settings defaultSettings
			{
				[Token(Token = "0x60002CA")]
				[Address(RVA = "0x69CAA0", Offset = "0x69BCA0", VA = "0x18069CAA0")]
				get
				{
					return default(ChromaticAberrationModel.Settings);
				}
			}

			// Token: 0x0400035D RID: 861
			[Token(Token = "0x400035D")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Shift the hue of chromatic aberrations.")]
			public Texture2D spectralTexture;

			// Token: 0x0400035E RID: 862
			[Token(Token = "0x400035E")]
			[FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Amount of tangential distortion.")]
			public float intensity;
		}
	}
}
