using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public class PortalAnimator : MonoBehaviour
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x7B4E30", Offset = "0x7B4030", VA = "0x1807B4E30")]
		private void Start()
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x7B4EE0", Offset = "0x7B40E0", VA = "0x1807B4EE0")]
		private void Update()
		{
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x7B4FD0", Offset = "0x7B41D0", VA = "0x1807B4FD0")]
		public PortalAnimator()
		{
		}

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x24")]
		public float duration;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x28")]
		public float delayFadeOut;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 scale;
	}
}
