using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x17000030")]
		public override bool active
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x56A220", Offset = "0x569420", VA = "0x18056A220", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x56A180", Offset = "0x569380", VA = "0x18056A180")]
		private float StandardIlluminantY(float x)
		{
			return 0f;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x567B30", Offset = "0x566D30", VA = "0x180567B30")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x567BC0", Offset = "0x566DC0", VA = "0x180567BC0")]
		private Vector3 CalculateColorBalance(float temperature, float tint)
		{
			return default(Vector3);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x569B40", Offset = "0x568D40", VA = "0x180569B40")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x567F50", Offset = "0x567150", VA = "0x180567F50")]
		private static Vector3 ClampVector(Vector3 v, float min, float max)
		{
			return default(Vector3);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x5694E0", Offset = "0x5686E0", VA = "0x1805694E0")]
		public static Vector3 GetLiftValue(Color lift)
		{
			return default(Vector3);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x5692B0", Offset = "0x5684B0", VA = "0x1805692B0")]
		public static Vector3 GetGammaValue(Color gamma)
		{
			return default(Vector3);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5690E0", Offset = "0x5682E0", VA = "0x1805690E0")]
		public static Vector3 GetGainValue(Color gain)
		{
			return default(Vector3);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x567CE0", Offset = "0x566EE0", VA = "0x180567CE0")]
		public static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x569940", Offset = "0x568B40", VA = "0x180569940")]
		public static Vector3 GetSlopeValue(Color slope)
		{
			return default(Vector3);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x5697B0", Offset = "0x5689B0", VA = "0x1805697B0")]
		public static Vector3 GetPowerValue(Color power)
		{
			return default(Vector3);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x569650", Offset = "0x568850", VA = "0x180569650")]
		public static Vector3 GetOffsetValue(Color offset)
		{
			return default(Vector3);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x567EA0", Offset = "0x5670A0", VA = "0x180567EA0")]
		public static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x568C50", Offset = "0x567E50", VA = "0x180568C50")]
		private TextureFormat GetCurveFormat()
		{
			return (TextureFormat)0;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x568C80", Offset = "0x567E80", VA = "0x180568C80")]
		private Texture2D GetCurveTexture()
		{
			return null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x569AB0", Offset = "0x568CB0", VA = "0x180569AB0")]
		private bool IsLogLutValid(RenderTexture lut)
		{
			return default(bool);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x569630", Offset = "0x568830", VA = "0x180569630")]
		private RenderTextureFormat GetLutFormat()
		{
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x567FC0", Offset = "0x5671C0", VA = "0x180567FC0")]
		private void GenerateLut()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x569DE0", Offset = "0x568FE0", VA = "0x180569DE0", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x569CA0", Offset = "0x568EA0", VA = "0x180569CA0")]
		public void OnGUI()
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x569C10", Offset = "0x568E10", VA = "0x180569C10", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x56A1B0", Offset = "0x5693B0", VA = "0x18056A1B0")]
		public ColorGradingComponent()
		{
		}

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		private const int k_InternalLogLutSize = 32;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		private const int k_CurvePrecision = 128;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		private const float k_CurveStep = 0.0078125f;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_GradingCurves;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x28")]
		private Color[] m_pixels;

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		private static class Uniforms
		{
			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _LutParams;

			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _NeutralTonemapperParams1;

			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _NeutralTonemapperParams2;

			// Token: 0x0400025C RID: 604
			[Token(Token = "0x400025C")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _HueShift;

			// Token: 0x0400025D RID: 605
			[Token(Token = "0x400025D")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _Saturation;

			// Token: 0x0400025E RID: 606
			[Token(Token = "0x400025E")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _Contrast;

			// Token: 0x0400025F RID: 607
			[Token(Token = "0x400025F")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _Balance;

			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000260")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _Lift;

			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000261")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _InvGamma;

			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000262")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _Gain;

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			[FieldOffset(Offset = "0x28")]
			internal static readonly int _Slope;

			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			[FieldOffset(Offset = "0x2C")]
			internal static readonly int _Power;

			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000265")]
			[FieldOffset(Offset = "0x30")]
			internal static readonly int _Offset;

			// Token: 0x04000266 RID: 614
			[Token(Token = "0x4000266")]
			[FieldOffset(Offset = "0x34")]
			internal static readonly int _ChannelMixerRed;

			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			[FieldOffset(Offset = "0x38")]
			internal static readonly int _ChannelMixerGreen;

			// Token: 0x04000268 RID: 616
			[Token(Token = "0x4000268")]
			[FieldOffset(Offset = "0x3C")]
			internal static readonly int _ChannelMixerBlue;

			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000269")]
			[FieldOffset(Offset = "0x40")]
			internal static readonly int _Curves;

			// Token: 0x0400026A RID: 618
			[Token(Token = "0x400026A")]
			[FieldOffset(Offset = "0x44")]
			internal static readonly int _LogLut;

			// Token: 0x0400026B RID: 619
			[Token(Token = "0x400026B")]
			[FieldOffset(Offset = "0x48")]
			internal static readonly int _LogLut_Params;

			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400026C")]
			[FieldOffset(Offset = "0x4C")]
			internal static readonly int _ExposureEV;
		}
	}
}
