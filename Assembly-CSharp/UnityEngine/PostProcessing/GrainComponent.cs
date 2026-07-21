using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000036")]
		public override bool active
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x56ECF0", Offset = "0x56DEF0", VA = "0x18056ECF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x5677A0", Offset = "0x5669A0", VA = "0x1805677A0", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x56E850", Offset = "0x56DA50", VA = "0x18056E850", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x56ECB0", Offset = "0x56DEB0", VA = "0x18056ECB0")]
		public GrainComponent()
		{
		}

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_GrainLookupRT;

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		private static class Uniforms
		{
			// Token: 0x0400029A RID: 666
			[Token(Token = "0x400029A")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _Grain_Params1;

			// Token: 0x0400029B RID: 667
			[Token(Token = "0x400029B")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Grain_Params2;

			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _GrainTex;

			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _Phase;
		}
	}
}
