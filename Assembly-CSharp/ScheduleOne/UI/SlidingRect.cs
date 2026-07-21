using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CC0 RID: 3264
	[Token(Token = "0x2000CC0")]
	public class SlidingRect : MonoBehaviour
	{
		// Token: 0x06005F49 RID: 24393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F49")]
		[Address(RVA = "0xA12CB0", Offset = "0xA11EB0", VA = "0x180A12CB0")]
		public void Update()
		{
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0xA12D70", Offset = "0xA11F70", VA = "0x180A12D70")]
		public SlidingRect()
		{
		}

		// Token: 0x0400419A RID: 16794
		[Token(Token = "0x400419A")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform Rect;

		// Token: 0x0400419B RID: 16795
		[Token(Token = "0x400419B")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 Start;

		// Token: 0x0400419C RID: 16796
		[Token(Token = "0x400419C")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 End;

		// Token: 0x0400419D RID: 16797
		[Token(Token = "0x400419D")]
		[FieldOffset(Offset = "0x38")]
		public float Duration;

		// Token: 0x0400419E RID: 16798
		[Token(Token = "0x400419E")]
		[FieldOffset(Offset = "0x3C")]
		public float SpeedMultiplier;

		// Token: 0x0400419F RID: 16799
		[Token(Token = "0x400419F")]
		[FieldOffset(Offset = "0x40")]
		private float _time;
	}
}
