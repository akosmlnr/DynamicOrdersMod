using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200085A RID: 2138
	[Token(Token = "0x200085A")]
	public class DelayedUnityEvent : MonoBehaviour
	{
		// Token: 0x0600390A RID: 14602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600390A")]
		[Address(RVA = "0x7FA100", Offset = "0x7F9300", VA = "0x1807FA100")]
		[Button]
		public void Execute()
		{
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600390B")]
		[Address(RVA = "0x557960", Offset = "0x556B60", VA = "0x180557960")]
		public DelayedUnityEvent()
		{
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600390C")]
		[Address(RVA = "0x7FA270", Offset = "0x7F9470", VA = "0x1807FA270")]
		[CompilerGenerated]
		private IEnumerator <Execute>g__Wait|3_0()
		{
			return null;
		}

		// Token: 0x04002A0F RID: 10767
		[Token(Token = "0x4002A0F")]
		[FieldOffset(Offset = "0x20")]
		public float Delay;

		// Token: 0x04002A10 RID: 10768
		[Token(Token = "0x4002A10")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onDelayStart;

		// Token: 0x04002A11 RID: 10769
		[Token(Token = "0x4002A11")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onDelayedExecute;
	}
}
