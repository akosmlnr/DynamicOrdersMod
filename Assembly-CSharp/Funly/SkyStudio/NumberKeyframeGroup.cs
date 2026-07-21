using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	[Serializable]
	public class NumberKeyframeGroup : KeyframeGroup<NumberKeyframe>
	{
		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x8D91D0", Offset = "0x8D83D0", VA = "0x1808D91D0")]
		public NumberKeyframeGroup(string name, float min, float max)
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x8D9240", Offset = "0x8D8440", VA = "0x1808D9240")]
		public NumberKeyframeGroup(string name, float min, float max, NumberKeyframe frame)
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x8D8ED0", Offset = "0x8D80D0", VA = "0x1808D8ED0")]
		public float GetFirstValue()
		{
			return 0f;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x8D91B0", Offset = "0x8D83B0", VA = "0x1808D91B0")]
		public float ValueToPercent(float value)
		{
			return 0f;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x8D9170", Offset = "0x8D8370", VA = "0x1808D9170")]
		public float ValuePercentAtTime(float time)
		{
			return 0f;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x8D9140", Offset = "0x8D8340", VA = "0x1808D9140")]
		public float PercentToValue(float percent)
		{
			return 0f;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x8D8F20", Offset = "0x8D8120", VA = "0x1808D8F20")]
		public float NumericValueAtTime(float time)
		{
			return 0f;
		}

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x28")]
		public float minValue;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x2C")]
		public float maxValue;
	}
}
