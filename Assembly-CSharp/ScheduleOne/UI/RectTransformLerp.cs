using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CBA RID: 3258
	[Token(Token = "0x2000CBA")]
	[RequireComponent(typeof(RectTransform))]
	public class RectTransformLerp : MonoBehaviour
	{
		// Token: 0x06005F30 RID: 24368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F30")]
		[Address(RVA = "0xA10460", Offset = "0xA0F660", VA = "0x180A10460", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F31")]
		[Address(RVA = "0xA104B0", Offset = "0xA0F6B0", VA = "0x180A104B0")]
		public void LerpLocalPosition(Vector3 endLocalPosition, float duration = -1f)
		{
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F32")]
		[Address(RVA = "0xA10670", Offset = "0xA0F870", VA = "0x180A10670")]
		public void LerpLocalScale(Vector3 endLocalscale, float duration = -1f)
		{
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F33")]
		[Address(RVA = "0x9C22A0", Offset = "0x9C14A0", VA = "0x1809C22A0")]
		public RectTransformLerp()
		{
		}

		// Token: 0x04004180 RID: 16768
		[Token(Token = "0x4004180")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float _defaultLerpDuration;

		// Token: 0x04004181 RID: 16769
		[Token(Token = "0x4004181")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _lerpPosition;

		// Token: 0x04004182 RID: 16770
		[Token(Token = "0x4004182")]
		[FieldOffset(Offset = "0x28")]
		protected RectTransform _rectTransform;

		// Token: 0x04004183 RID: 16771
		[Token(Token = "0x4004183")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine _positionRoutine;

		// Token: 0x04004184 RID: 16772
		[Token(Token = "0x4004184")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine _scaleRoutine;
	}
}
