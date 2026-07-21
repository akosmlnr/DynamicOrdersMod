using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	[Serializable]
	public class MotionBlurModel : PostProcessingModel
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public MotionBlurModel.Settings settings
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x4D6F10", Offset = "0x4D6110", VA = "0x1804D6F10")]
			get
			{
				return default(MotionBlurModel.Settings);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x4D6F30", Offset = "0x4D6130", VA = "0x1804D6F30")]
			set
			{
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x6981A0", Offset = "0x6973A0", VA = "0x1806981A0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x6981D0", Offset = "0x6973D0", VA = "0x1806981D0")]
		public MotionBlurModel()
		{
		}

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MotionBlurModel.Settings m_Settings;

		// Token: 0x020000C8 RID: 200
		[Token(Token = "0x20000C8")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000067 RID: 103
			// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002FB8 File Offset: 0x000011B8
			[Token(Token = "0x17000067")]
			public static MotionBlurModel.Settings defaultSettings
			{
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0x69C9F0", Offset = "0x69BBF0", VA = "0x18069C9F0")]
				get
				{
					return default(MotionBlurModel.Settings);
				}
			}

			// Token: 0x040003B8 RID: 952
			[Token(Token = "0x40003B8")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
			[Range(0f, 360f)]
			public float shutterAngle;

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("The amount of sample points, which affects quality and performances.")]
			[Range(4f, 32f)]
			public int sampleCount;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
			[Range(0f, 1f)]
			public float frameBlending;
		}
	}
}
