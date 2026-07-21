using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	[Serializable]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public BuiltinDebugViewsModel.Settings settings
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x6911C0", Offset = "0x6903C0", VA = "0x1806911C0")]
			get
			{
				return default(BuiltinDebugViewsModel.Settings);
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x691210", Offset = "0x690410", VA = "0x180691210")]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x1700004B")]
		public bool willInterrupt
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x6911E0", Offset = "0x6903E0", VA = "0x1806911E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x691120", Offset = "0x690320", VA = "0x180691120", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x691110", Offset = "0x690310", VA = "0x180691110")]
		public bool IsModeActive(BuiltinDebugViewsModel.Mode mode)
		{
			return default(bool);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x691170", Offset = "0x690370", VA = "0x180691170")]
		public BuiltinDebugViewsModel()
		{
		}

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuiltinDebugViewsModel.Settings m_Settings;

		// Token: 0x020000AA RID: 170
		[Token(Token = "0x20000AA")]
		[Serializable]
		public struct DepthSettings
		{
			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060002C3 RID: 707 RVA: 0x00002D48 File Offset: 0x00000F48
			[Token(Token = "0x1700004C")]
			public static BuiltinDebugViewsModel.DepthSettings defaultSettings
			{
				[Token(Token = "0x60002C3")]
				[Address(RVA = "0x693AC0", Offset = "0x692CC0", VA = "0x180693AC0")]
				get
				{
					return default(BuiltinDebugViewsModel.DepthSettings);
				}
			}

			// Token: 0x04000347 RID: 839
			[Token(Token = "0x4000347")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[Tooltip("Scales the camera far plane before displaying the depth map.")]
			public float scale;
		}

		// Token: 0x020000AB RID: 171
		[Token(Token = "0x20000AB")]
		[Serializable]
		public struct MotionVectorsSettings
		{
			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x00002D60 File Offset: 0x00000F60
			[Token(Token = "0x1700004D")]
			public static BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x698210", Offset = "0x697410", VA = "0x180698210")]
				get
				{
					return default(BuiltinDebugViewsModel.MotionVectorsSettings);
				}
			}

			// Token: 0x04000348 RID: 840
			[Token(Token = "0x4000348")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Opacity of the source render.")]
			[Range(0f, 1f)]
			public float sourceOpacity;

			// Token: 0x04000349 RID: 841
			[Token(Token = "0x4000349")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Opacity of the per-pixel motion vector colors.")]
			[Range(0f, 1f)]
			public float motionImageOpacity;

			// Token: 0x0400034A RID: 842
			[Token(Token = "0x400034A")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
			[Min(0f)]
			public float motionImageAmplitude;

			// Token: 0x0400034B RID: 843
			[Token(Token = "0x400034B")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Opacity for the motion vector arrows.")]
			[Range(0f, 1f)]
			public float motionVectorsOpacity;

			// Token: 0x0400034C RID: 844
			[Token(Token = "0x400034C")]
			[FieldOffset(Offset = "0x10")]
			[Range(8f, 64f)]
			[Tooltip("The arrow density on screen.")]
			public int motionVectorsResolution;

			// Token: 0x0400034D RID: 845
			[Token(Token = "0x400034D")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Tweaks the arrows length.")]
			[Min(0f)]
			public float motionVectorsAmplitude;
		}

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		public enum Mode
		{
			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			None,
			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			Depth,
			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			Normals,
			// Token: 0x04000352 RID: 850
			[Token(Token = "0x4000352")]
			MotionVectors,
			// Token: 0x04000353 RID: 851
			[Token(Token = "0x4000353")]
			AmbientOcclusion,
			// Token: 0x04000354 RID: 852
			[Token(Token = "0x4000354")]
			EyeAdaptation,
			// Token: 0x04000355 RID: 853
			[Token(Token = "0x4000355")]
			FocusPlane,
			// Token: 0x04000356 RID: 854
			[Token(Token = "0x4000356")]
			PreGradingLog,
			// Token: 0x04000357 RID: 855
			[Token(Token = "0x4000357")]
			LogLut,
			// Token: 0x04000358 RID: 856
			[Token(Token = "0x4000358")]
			UserLut
		}

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060002C5 RID: 709 RVA: 0x00002D78 File Offset: 0x00000F78
			[Token(Token = "0x1700004E")]
			public static BuiltinDebugViewsModel.Settings defaultSettings
			{
				[Token(Token = "0x60002C5")]
				[Address(RVA = "0x69CA50", Offset = "0x69BC50", VA = "0x18069CA50")]
				get
				{
					return default(BuiltinDebugViewsModel.Settings);
				}
			}

			// Token: 0x04000359 RID: 857
			[Token(Token = "0x4000359")]
			[FieldOffset(Offset = "0x0")]
			public BuiltinDebugViewsModel.Mode mode;

			// Token: 0x0400035A RID: 858
			[Token(Token = "0x400035A")]
			[FieldOffset(Offset = "0x4")]
			public BuiltinDebugViewsModel.DepthSettings depth;

			// Token: 0x0400035B RID: 859
			[Token(Token = "0x400035B")]
			[FieldOffset(Offset = "0x8")]
			public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;
		}
	}
}
