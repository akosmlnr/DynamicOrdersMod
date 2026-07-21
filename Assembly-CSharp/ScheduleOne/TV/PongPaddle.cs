using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	public class PongPaddle : MonoBehaviour
	{
		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00008178 File Offset: 0x00006378
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039E")]
		public float TargetY
		{
			[Token(Token = "0x600114F")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001150")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
		public void SetTargetY(float y)
		{
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001152")]
		[Address(RVA = "0xB1E4C0", Offset = "0xB1D6C0", VA = "0x180B1E4C0")]
		private void Update()
		{
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001153")]
		[Address(RVA = "0xB1E4C0", Offset = "0xB1D6C0", VA = "0x180B1E4C0")]
		private void UpdateMove()
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x557960", Offset = "0x556B60", VA = "0x180557960")]
		public PongPaddle()
		{
		}

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		public const float BOUND_Y = 160f;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		public const float MOVE_SPEED = 20f;

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x20")]
		public float SpeedMultiplier;

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform Rect;
	}
}
