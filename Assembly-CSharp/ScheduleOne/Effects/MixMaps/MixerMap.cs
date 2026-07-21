using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects.MixMaps
{
	// Token: 0x02000B8C RID: 2956
	[Token(Token = "0x2000B8C")]
	[Serializable]
	public class MixerMap : ScriptableObject
	{
		// Token: 0x060057F9 RID: 22521 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60057F9")]
		[Address(RVA = "0x99E390", Offset = "0x99D590", VA = "0x18099E390")]
		public MixerMapEffect GetEffectAtPoint(Vector2 point)
		{
			return null;
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60057FA")]
		[Address(RVA = "0x99E5C0", Offset = "0x99D7C0", VA = "0x18099E5C0")]
		public MixerMapEffect GetEffect(Effect property)
		{
			return null;
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FB")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public MixerMap()
		{
		}

		// Token: 0x04003A63 RID: 14947
		[Token(Token = "0x4003A63")]
		[FieldOffset(Offset = "0x18")]
		public float MapRadius;

		// Token: 0x04003A64 RID: 14948
		[Token(Token = "0x4003A64")]
		[FieldOffset(Offset = "0x20")]
		public List<MixerMapEffect> Effects;
	}
}
