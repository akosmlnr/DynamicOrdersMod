using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-pulse/")]
	public class EffectPulse : EffectAbstractBase
	{
		// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x694BB0", Offset = "0x693DB0", VA = "0x180694BB0", Slot = "4")]
		public override void InitFrom(EffectAbstractBase source)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x694CF0", Offset = "0x693EF0", VA = "0x180694CF0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x694B40", Offset = "0x693D40", VA = "0x180694B40")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x694D70", Offset = "0x693F70", VA = "0x180694D70")]
		public EffectPulse()
		{
		}

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		public new const string ClassName = "EffectPulse";

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x50")]
		[Range(0.1f, 60f)]
		public float frequency;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x54")]
		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude;
	}
}
