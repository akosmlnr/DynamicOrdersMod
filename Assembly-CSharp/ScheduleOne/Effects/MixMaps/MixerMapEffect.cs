using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects.MixMaps
{
	// Token: 0x02000B8D RID: 2957
	[Token(Token = "0x2000B8D")]
	[Serializable]
	public class MixerMapEffect
	{
		// Token: 0x060057FC RID: 22524 RVA: 0x000164B8 File Offset: 0x000146B8
		[Token(Token = "0x60057FC")]
		[Address(RVA = "0x99DD30", Offset = "0x99CF30", VA = "0x18099DD30")]
		public bool IsPointInEffect(Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FD")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public MixerMapEffect()
		{
		}

		// Token: 0x04003A65 RID: 14949
		[Token(Token = "0x4003A65")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 Position;

		// Token: 0x04003A66 RID: 14950
		[Token(Token = "0x4003A66")]
		[FieldOffset(Offset = "0x18")]
		public float Radius;

		// Token: 0x04003A67 RID: 14951
		[Token(Token = "0x4003A67")]
		[FieldOffset(Offset = "0x20")]
		public Effect Property;
	}
}
