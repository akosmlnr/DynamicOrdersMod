using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CC3 RID: 3267
	[Token(Token = "0x2000CC3")]
	public class UIMover : MonoBehaviour
	{
		// Token: 0x06005F58 RID: 24408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F58")]
		[Address(RVA = "0xA1CD40", Offset = "0xA1BF40", VA = "0x180A1CD40")]
		private void Start()
		{
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F59")]
		[Address(RVA = "0xA1CD90", Offset = "0xA1BF90", VA = "0x180A1CD90")]
		public void Update()
		{
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0xA1CE20", Offset = "0xA1C020", VA = "0x180A1CE20")]
		public UIMover()
		{
		}

		// Token: 0x040041A4 RID: 16804
		[Token(Token = "0x40041A4")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform Rect;

		// Token: 0x040041A5 RID: 16805
		[Token(Token = "0x40041A5")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 MinSpeed;

		// Token: 0x040041A6 RID: 16806
		[Token(Token = "0x40041A6")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 MaxSpeed;

		// Token: 0x040041A7 RID: 16807
		[Token(Token = "0x40041A7")]
		[FieldOffset(Offset = "0x38")]
		public float SpeedMultiplier;

		// Token: 0x040041A8 RID: 16808
		[Token(Token = "0x40041A8")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 speed;
	}
}
