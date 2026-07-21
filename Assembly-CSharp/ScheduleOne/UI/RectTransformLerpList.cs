using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CBF RID: 3263
	[Token(Token = "0x2000CBF")]
	public class RectTransformLerpList : RectTransformLerp
	{
		// Token: 0x06005F44 RID: 24388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F44")]
		[Address(RVA = "0xA0FCF0", Offset = "0xA0EEF0", VA = "0x180A0FCF0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F45")]
		[Address(RVA = "0xA0FFB0", Offset = "0xA0F1B0", VA = "0x180A0FFB0")]
		public void LerpTo(int index, float duration)
		{
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F46")]
		[Address(RVA = "0xA10430", Offset = "0xA0F630", VA = "0x180A10430")]
		public void LerpTo(int index)
		{
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x00017D78 File Offset: 0x00015F78
		[Token(Token = "0x6005F47")]
		[Address(RVA = "0xA0FEA0", Offset = "0xA0F0A0", VA = "0x180A0FEA0")]
		private float GetDurationMultiplier(Vector2 start, Vector2 end)
		{
			return 0f;
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F48")]
		[Address(RVA = "0xA10440", Offset = "0xA0F640", VA = "0x180A10440")]
		public RectTransformLerpList()
		{
		}

		// Token: 0x04004195 RID: 16789
		[Token(Token = "0x4004195")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform[] _targetPositions;

		// Token: 0x04004196 RID: 16790
		[Token(Token = "0x4004196")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _scaleDurationWithDistance;

		// Token: 0x04004197 RID: 16791
		[Token(Token = "0x4004197")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _lerpLocalPosition;

		// Token: 0x04004198 RID: 16792
		[Token(Token = "0x4004198")]
		[FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool _lerpScale;

		// Token: 0x04004199 RID: 16793
		[Token(Token = "0x4004199")]
		[FieldOffset(Offset = "0x4C")]
		private float _longestDistance;
	}
}
