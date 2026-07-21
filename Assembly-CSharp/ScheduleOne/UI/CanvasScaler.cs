using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C1E RID: 3102
	[Token(Token = "0x2000C1E")]
	[RequireComponent(typeof(CanvasScaler))]
	public class CanvasScaler : MonoBehaviour
	{
		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06005AF4 RID: 23284 RVA: 0x000170E8 File Offset: 0x000152E8
		[Token(Token = "0x17000D2B")]
		public static float NormalizedCanvasScaleFactor
		{
			[Token(Token = "0x6005AF4")]
			[Address(RVA = "0x9C27D0", Offset = "0x9C19D0", VA = "0x1809C27D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF5")]
		[Address(RVA = "0x9C22C0", Offset = "0x9C14C0", VA = "0x1809C22C0")]
		public void Awake()
		{
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF6")]
		[Address(RVA = "0x9C24E0", Offset = "0x9C16E0", VA = "0x1809C24E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF7")]
		[Address(RVA = "0x9C2620", Offset = "0x9C1820", VA = "0x1809C2620")]
		private void RefreshScale()
		{
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF8")]
		[Address(RVA = "0x9C26D0", Offset = "0x9C18D0", VA = "0x1809C26D0")]
		public static void SetScaleFactor(float scaleFactor)
		{
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF9")]
		[Address(RVA = "0x9C27B0", Offset = "0x9C19B0", VA = "0x1809C27B0")]
		public CanvasScaler()
		{
		}

		// Token: 0x04003D6D RID: 15725
		[Token(Token = "0x4003D6D")]
		[FieldOffset(Offset = "0x0")]
		public static float CanvasScaleFactor;

		// Token: 0x04003D6E RID: 15726
		[Token(Token = "0x4003D6E")]
		[FieldOffset(Offset = "0x8")]
		public static Action OnCanvasScaleFactorChanged;

		// Token: 0x04003D6F RID: 15727
		[Token(Token = "0x4003D6F")]
		[FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		// Token: 0x04003D70 RID: 15728
		[Token(Token = "0x4003D70")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 referenceResolution;

		// Token: 0x04003D71 RID: 15729
		[Token(Token = "0x4003D71")]
		[FieldOffset(Offset = "0x30")]
		private CanvasScaler canvasScaler;
	}
}
