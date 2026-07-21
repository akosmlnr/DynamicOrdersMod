using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00003000 File Offset: 0x00001200
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public UserLutModel.Settings settings
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x524810", Offset = "0x523A10", VA = "0x180524810")]
			get
			{
				return default(UserLutModel.Settings);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x691360", Offset = "0x690560", VA = "0x180691360")]
			set
			{
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x69DFC0", Offset = "0x69D1C0", VA = "0x18069DFC0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x69E030", Offset = "0x69D230", VA = "0x18069E030")]
		public UserLutModel()
		{
		}

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserLutModel.Settings m_Settings;

		// Token: 0x020000D1 RID: 209
		[Token(Token = "0x20000D1")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000303 RID: 771 RVA: 0x00003018 File Offset: 0x00001218
			[Token(Token = "0x1700006B")]
			public static UserLutModel.Settings defaultSettings
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x69C5E0", Offset = "0x69B7E0", VA = "0x18069C5E0")]
				get
				{
					return default(UserLutModel.Settings);
				}
			}

			// Token: 0x040003D3 RID: 979
			[Token(Token = "0x40003D3")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture2D lut;

			// Token: 0x040003D4 RID: 980
			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Blending factor.")]
			public float contribution;
		}
	}
}
