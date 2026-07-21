using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	[Serializable]
	public class GrainModel : PostProcessingModel
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00002F70 File Offset: 0x00001170
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public GrainModel.Settings settings
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x524810", Offset = "0x523A10", VA = "0x180524810")]
			get
			{
				return default(GrainModel.Settings);
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x565570", Offset = "0x564770", VA = "0x180565570")]
			set
			{
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x6952B0", Offset = "0x6944B0", VA = "0x1806952B0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x6952F0", Offset = "0x6944F0", VA = "0x1806952F0")]
		public GrainModel()
		{
		}

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GrainModel.Settings m_Settings;

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000C6")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000065 RID: 101
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x00002F88 File Offset: 0x00001188
			[Token(Token = "0x17000065")]
			public static GrainModel.Settings defaultSettings
			{
				[Token(Token = "0x60002F4")]
				[Address(RVA = "0x69C830", Offset = "0x69BA30", VA = "0x18069C830")]
				get
				{
					return default(GrainModel.Settings);
				}
			}

			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Enable the use of colored grain.")]
			public bool colored;

			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			[Tooltip("Grain strength. Higher means more visible grain.")]
			public float intensity;

			// Token: 0x040003B5 RID: 949
			[Token(Token = "0x40003B5")]
			[FieldOffset(Offset = "0x8")]
			[Range(0.3f, 3f)]
			[Tooltip("Grain particle size.")]
			public float size;

			// Token: 0x040003B6 RID: 950
			[Token(Token = "0x40003B6")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
			[Range(0f, 1f)]
			public float luminanceContribution;
		}
	}
}
