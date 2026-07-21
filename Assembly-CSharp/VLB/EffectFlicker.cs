using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-flicker/")]
	public class EffectFlicker : EffectAbstractBase
	{
		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x694580", Offset = "0x693780", VA = "0x180694580", Slot = "4")]
		public override void InitFrom(EffectAbstractBase source)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x6946F0", Offset = "0x6938F0", VA = "0x1806946F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x694510", Offset = "0x693710", VA = "0x180694510")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x6944A0", Offset = "0x6936A0", VA = "0x1806944A0")]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x694410", Offset = "0x693610", VA = "0x180694410")]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x694770", Offset = "0x693970", VA = "0x180694770")]
		public EffectFlicker()
		{
		}

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		public new const string ClassName = "EffectFlicker";

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x50")]
		[Range(1f, 60f)]
		public float frequency;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x54")]
		public bool performPauses;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x58")]
		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat flickeringDuration;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x60")]
		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat pauseDuration;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x68")]
		public bool restoreIntensityOnPause;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x6C")]
		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x74")]
		[Range(0f, 0.25f)]
		public float smoothing;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x78")]
		private float m_CurrentAdditiveIntensity;
	}
}
