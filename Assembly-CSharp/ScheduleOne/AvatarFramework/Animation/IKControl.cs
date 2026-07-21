using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200082D RID: 2093
	[Token(Token = "0x200082D")]
	[RequireComponent(typeof(Animator))]
	public class IKControl : MonoBehaviour
	{
		// Token: 0x0600383C RID: 14396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600383C")]
		[Address(RVA = "0x7F37A0", Offset = "0x7F29A0", VA = "0x1807F37A0")]
		private void Start()
		{
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600383D")]
		[Address(RVA = "0x7F3550", Offset = "0x7F2750", VA = "0x1807F3550")]
		private void OnAnimatorIK()
		{
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600383E")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public IKControl()
		{
		}

		// Token: 0x04002935 RID: 10549
		[Token(Token = "0x4002935")]
		[FieldOffset(Offset = "0x20")]
		protected Animator animator;

		// Token: 0x04002936 RID: 10550
		[Token(Token = "0x4002936")]
		[FieldOffset(Offset = "0x28")]
		public bool ikActive;

		// Token: 0x04002937 RID: 10551
		[Token(Token = "0x4002937")]
		[FieldOffset(Offset = "0x30")]
		public Transform rightHandObj;

		// Token: 0x04002938 RID: 10552
		[Token(Token = "0x4002938")]
		[FieldOffset(Offset = "0x38")]
		public Transform lookObj;
	}
}
