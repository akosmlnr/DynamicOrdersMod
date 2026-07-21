using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects.MixMaps
{
	// Token: 0x02000B90 RID: 2960
	[Token(Token = "0x2000B90")]
	public class MixMapEffect : MonoBehaviour
	{
		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06005805 RID: 22533 RVA: 0x000164E8 File Offset: 0x000146E8
		[Token(Token = "0x17000CBF")]
		public Vector2 Position
		{
			[Token(Token = "0x6005805")]
			[Address(RVA = "0x99DCC0", Offset = "0x99CEC0", VA = "0x18099DCC0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005806")]
		[Address(RVA = "0x99DC30", Offset = "0x99CE30", VA = "0x18099DC30")]
		public void OnValidate()
		{
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005807")]
		[Address(RVA = "0x55E020", Offset = "0x55D220", VA = "0x18055E020")]
		public MixMapEffect()
		{
		}

		// Token: 0x04003A6E RID: 14958
		[Token(Token = "0x4003A6E")]
		[FieldOffset(Offset = "0x20")]
		public Effect Property;

		// Token: 0x04003A6F RID: 14959
		[Token(Token = "0x4003A6F")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.05f, 3f)]
		public float Radius;
	}
}
