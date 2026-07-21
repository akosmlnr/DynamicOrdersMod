using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	[Serializable]
	public sealed class ColorGradingCurve
	{
		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x691610", Offset = "0x690810", VA = "0x180691610")]
		public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x691380", Offset = "0x690580", VA = "0x180691380")]
		public void Cache()
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x691590", Offset = "0x690790", VA = "0x180691590")]
		public float Evaluate(float t)
		{
			return 0f;
		}

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Loop;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_ZeroValue;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Range;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x28")]
		private AnimationCurve m_InternalLoopingCurve;
	}
}
