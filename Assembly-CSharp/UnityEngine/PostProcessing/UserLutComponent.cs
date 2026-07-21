using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x1700003D")]
		public override bool active
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x577780", Offset = "0x576980", VA = "0x180577780", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x5775A0", Offset = "0x5767A0", VA = "0x1805775A0", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x577460", Offset = "0x576660", VA = "0x180577460")]
		public void OnGUI()
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x577740", Offset = "0x576940", VA = "0x180577740")]
		public UserLutComponent()
		{
		}

		// Token: 0x02000097 RID: 151
		[Token(Token = "0x2000097")]
		private static class Uniforms
		{
			// Token: 0x0400030D RID: 781
			[Token(Token = "0x400030D")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _UserLut;

			// Token: 0x0400030E RID: 782
			[Token(Token = "0x400030E")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _UserLut_Params;
		}
	}
}
