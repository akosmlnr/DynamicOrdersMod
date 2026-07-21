using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[Serializable]
	public class BloomModel : PostProcessingModel
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00002C88 File Offset: 0x00000E88
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public BloomModel.Settings settings
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x691060", Offset = "0x690260", VA = "0x180691060")]
			get
			{
				return default(BloomModel.Settings);
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x691080", Offset = "0x690280", VA = "0x180691080")]
			set
			{
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x690F20", Offset = "0x690120", VA = "0x180690F20", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x690FC0", Offset = "0x6901C0", VA = "0x180690FC0")]
		public BloomModel()
		{
		}

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BloomModel.Settings m_Settings;

		// Token: 0x020000A6 RID: 166
		[Token(Token = "0x20000A6")]
		[Serializable]
		public struct BloomSettings
		{
			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060002B9 RID: 697 RVA: 0x00002CA0 File Offset: 0x00000EA0
			// (set) Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000046")]
			public float thresholdLinear
			{
				[Token(Token = "0x60002B9")]
				[Address(RVA = "0x6910E0", Offset = "0x6902E0", VA = "0x1806910E0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60002B8")]
				[Address(RVA = "0x6910F0", Offset = "0x6902F0", VA = "0x1806910F0")]
				set
				{
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060002BA RID: 698 RVA: 0x00002CB8 File Offset: 0x00000EB8
			[Token(Token = "0x17000047")]
			public static BloomModel.BloomSettings defaultSettings
			{
				[Token(Token = "0x60002BA")]
				[Address(RVA = "0x6910B0", Offset = "0x6902B0", VA = "0x1806910B0")]
				get
				{
					return default(BloomModel.BloomSettings);
				}
			}

			// Token: 0x0400033D RID: 829
			[Token(Token = "0x400033D")]
			[FieldOffset(Offset = "0x0")]
			[Min(0f)]
			[Tooltip("Strength of the bloom filter.")]
			public float intensity;

			// Token: 0x0400033E RID: 830
			[Token(Token = "0x400033E")]
			[FieldOffset(Offset = "0x4")]
			[Min(0f)]
			[Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			// Token: 0x0400033F RID: 831
			[Token(Token = "0x400033F")]
			[FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
			public float softKnee;

			// Token: 0x04000340 RID: 832
			[Token(Token = "0x4000340")]
			[FieldOffset(Offset = "0xC")]
			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			// Token: 0x04000341 RID: 833
			[Token(Token = "0x4000341")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;
		}

		// Token: 0x020000A7 RID: 167
		[Token(Token = "0x20000A7")]
		[Serializable]
		public struct LensDirtSettings
		{
			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060002BB RID: 699 RVA: 0x00002CD0 File Offset: 0x00000ED0
			[Token(Token = "0x17000048")]
			public static BloomModel.LensDirtSettings defaultSettings
			{
				[Token(Token = "0x60002BB")]
				[Address(RVA = "0x695C00", Offset = "0x694E00", VA = "0x180695C00")]
				get
				{
					return default(BloomModel.LensDirtSettings);
				}
			}

			// Token: 0x04000342 RID: 834
			[Token(Token = "0x4000342")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
			public Texture texture;

			// Token: 0x04000343 RID: 835
			[Token(Token = "0x4000343")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Amount of lens dirtiness.")]
			[Min(0f)]
			public float intensity;
		}

		// Token: 0x020000A8 RID: 168
		[Token(Token = "0x20000A8")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060002BC RID: 700 RVA: 0x00002CE8 File Offset: 0x00000EE8
			[Token(Token = "0x17000049")]
			public static BloomModel.Settings defaultSettings
			{
				[Token(Token = "0x60002BC")]
				[Address(RVA = "0x69C6F0", Offset = "0x69B8F0", VA = "0x18069C6F0")]
				get
				{
					return default(BloomModel.Settings);
				}
			}

			// Token: 0x04000344 RID: 836
			[Token(Token = "0x4000344")]
			[FieldOffset(Offset = "0x0")]
			public BloomModel.BloomSettings bloom;

			// Token: 0x04000345 RID: 837
			[Token(Token = "0x4000345")]
			[FieldOffset(Offset = "0x18")]
			public BloomModel.LensDirtSettings lensDirt;
		}
	}
}
