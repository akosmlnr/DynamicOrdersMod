using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public DepthOfFieldModel.Settings settings
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x693A90", Offset = "0x692C90", VA = "0x180693A90")]
			get
			{
				return default(DepthOfFieldModel.Settings);
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x693AB0", Offset = "0x692CB0", VA = "0x180693AB0")]
			set
			{
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x693A00", Offset = "0x692C00", VA = "0x180693A00", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x693A40", Offset = "0x692C40", VA = "0x180693A40")]
		public DepthOfFieldModel()
		{
		}

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DepthOfFieldModel.Settings m_Settings;

		// Token: 0x020000BC RID: 188
		[Token(Token = "0x20000BC")]
		public enum KernelSize
		{
			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			Small,
			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4000398")]
			Medium,
			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4000399")]
			Large,
			// Token: 0x0400039A RID: 922
			[Token(Token = "0x400039A")]
			VeryLarge
		}

		// Token: 0x020000BD RID: 189
		[Token(Token = "0x20000BD")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060002E0 RID: 736 RVA: 0x00002EC8 File Offset: 0x000010C8
			[Token(Token = "0x1700005D")]
			public static DepthOfFieldModel.Settings defaultSettings
			{
				[Token(Token = "0x60002E0")]
				[Address(RVA = "0x69C800", Offset = "0x69BA00", VA = "0x18069C800")]
				get
				{
					return default(DepthOfFieldModel.Settings);
				}
			}

			// Token: 0x0400039B RID: 923
			[Token(Token = "0x400039B")]
			[FieldOffset(Offset = "0x0")]
			[Min(0.1f)]
			[Tooltip("Distance to the point of focus.")]
			public float focusDistance;

			// Token: 0x0400039C RID: 924
			[Token(Token = "0x400039C")]
			[FieldOffset(Offset = "0x4")]
			[Range(0.05f, 32f)]
			[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
			public float aperture;

			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400039D")]
			[FieldOffset(Offset = "0x8")]
			[Range(1f, 300f)]
			[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
			public float focalLength;

			// Token: 0x0400039E RID: 926
			[Token(Token = "0x400039E")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
			public bool useCameraFov;

			// Token: 0x0400039F RID: 927
			[Token(Token = "0x400039F")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
			public DepthOfFieldModel.KernelSize kernelSize;
		}
	}
}
