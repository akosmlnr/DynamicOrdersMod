using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000243 RID: 579 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x17000031")]
		public override bool active
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x56AFC0", Offset = "0x56A1C0", VA = "0x18056AFC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x56A480", Offset = "0x569680", VA = "0x18056A480", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x56A280", Offset = "0x569480", VA = "0x18056A280")]
		private float CalculateFocalLength()
		{
			return 0f;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x56A320", Offset = "0x569520", VA = "0x18056A320")]
		private float CalculateMaxCoCRadius(int screenHeight)
		{
			return 0f;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x56A3A0", Offset = "0x5695A0", VA = "0x18056A3A0")]
		private bool CheckHistory(int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x56AF30", Offset = "0x56A130", VA = "0x18056AF30")]
		private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
		{
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x56A510", Offset = "0x569710", VA = "0x18056A510")]
		public void Prepare(RenderTexture source, Material uberMaterial, bool antialiasCoC, Vector2 taaJitter, float taaBlending)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x56A490", Offset = "0x569690", VA = "0x18056A490", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x56AF80", Offset = "0x56A180", VA = "0x18056AF80")]
		public DepthOfFieldComponent()
		{
		}

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		private const string k_ShaderString = "Hidden/Post FX/Depth Of Field";

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_CoCHistory;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		private const float k_FilmHeight = 0.024f;

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		private static class Uniforms
		{
			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _DepthOfFieldTex;

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _DepthOfFieldCoCTex;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Distance;

			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _LensCoeff;

			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _MaxCoC;

			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _RcpMaxCoC;

			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _RcpAspect;

			// Token: 0x04000277 RID: 631
			[Token(Token = "0x4000277")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _MainTex;

			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _CoCTex;

			// Token: 0x04000279 RID: 633
			[Token(Token = "0x4000279")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _TaaParams;

			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			[FieldOffset(Offset = "0x28")]
			internal static readonly int _DepthOfFieldParams;
		}
	}
}
