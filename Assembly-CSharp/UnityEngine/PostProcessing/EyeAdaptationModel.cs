using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[Serializable]
	public class EyeAdaptationModel : PostProcessingModel
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00002F10 File Offset: 0x00001110
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public EyeAdaptationModel.Settings settings
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x694F50", Offset = "0x694150", VA = "0x180694F50")]
			get
			{
				return default(EyeAdaptationModel.Settings);
			}
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x694F80", Offset = "0x694180", VA = "0x180694F80")]
			set
			{
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x694E70", Offset = "0x694070", VA = "0x180694E70", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x694EE0", Offset = "0x6940E0", VA = "0x180694EE0")]
		public EyeAdaptationModel()
		{
		}

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EyeAdaptationModel.Settings m_Settings;

		// Token: 0x020000C1 RID: 193
		[Token(Token = "0x20000C1")]
		public enum EyeAdaptationType
		{
			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x40003A3")]
			Progressive,
			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			Fixed
		}

		// Token: 0x020000C2 RID: 194
		[Token(Token = "0x20000C2")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060002EA RID: 746 RVA: 0x00002F28 File Offset: 0x00001128
			[Token(Token = "0x17000061")]
			public static EyeAdaptationModel.Settings defaultSettings
			{
				[Token(Token = "0x60002EA")]
				[Address(RVA = "0x69C690", Offset = "0x69B890", VA = "0x18069C690")]
				get
				{
					return default(EyeAdaptationModel.Settings);
				}
			}

			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x40003A5")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Filters the dark part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
			[Range(1f, 99f)]
			public float lowPercent;

			// Token: 0x040003A6 RID: 934
			[Token(Token = "0x40003A6")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Filters the bright part of the histogram when computing the average luminance to avoid very dark pixels from contributing to the auto exposure. Unit is in percent.")]
			[Range(1f, 99f)]
			public float highPercent;

			// Token: 0x040003A7 RID: 935
			[Token(Token = "0x40003A7")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Minimum average luminance to consider for auto exposure (in EV).")]
			public float minLuminance;

			// Token: 0x040003A8 RID: 936
			[Token(Token = "0x40003A8")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Maximum average luminance to consider for auto exposure (in EV).")]
			public float maxLuminance;

			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x40003A9")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Exposure bias. Use this to offset the global exposure of the scene.")]
			[Min(0f)]
			public float keyValue;

			// Token: 0x040003AA RID: 938
			[Token(Token = "0x40003AA")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Set this to true to let Unity handle the key value automatically based on average luminance.")]
			public bool dynamicKeyValue;

			// Token: 0x040003AB RID: 939
			[Token(Token = "0x40003AB")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Use \"Progressive\" if you want the auto exposure to be animated. Use \"Fixed\" otherwise.")]
			public EyeAdaptationModel.EyeAdaptationType adaptationType;

			// Token: 0x040003AC RID: 940
			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x1C")]
			[Tooltip("Adaptation speed from a dark to a light environment.")]
			[Min(0f)]
			public float speedUp;

			// Token: 0x040003AD RID: 941
			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Adaptation speed from a light to a dark environment.")]
			[Min(0f)]
			public float speedDown;

			// Token: 0x040003AE RID: 942
			[Token(Token = "0x40003AE")]
			[FieldOffset(Offset = "0x24")]
			[Range(-16f, -1f)]
			[Tooltip("Lower bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
			public int logMin;

			// Token: 0x040003AF RID: 943
			[Token(Token = "0x40003AF")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("Upper bound for the brightness range of the generated histogram (in EV). The bigger the spread between min & max, the lower the precision will be.")]
			[Range(1f, 16f)]
			public int logMax;
		}
	}
}
