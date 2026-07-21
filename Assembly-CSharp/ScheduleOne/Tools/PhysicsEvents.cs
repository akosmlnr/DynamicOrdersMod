using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000883 RID: 2179
	[Token(Token = "0x2000883")]
	public class PhysicsEvents : MonoBehaviour
	{
		// Token: 0x060039B6 RID: 14774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039B6")]
		[Address(RVA = "0x80BCA0", Offset = "0x80AEA0", VA = "0x18080BCA0")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039B7")]
		[Address(RVA = "0x80BD90", Offset = "0x80AF90", VA = "0x18080BD90")]
		public void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039B8")]
		[Address(RVA = "0x80BA80", Offset = "0x80AC80", VA = "0x18080BA80")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039B9")]
		[Address(RVA = "0x80BB90", Offset = "0x80AD90", VA = "0x18080BB90")]
		public void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60039BA")]
		[Address(RVA = "0x80B910", Offset = "0x80AB10", VA = "0x18080B910")]
		private static string GetHierarchyString(Transform transform)
		{
			return null;
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039BB")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PhysicsEvents()
		{
		}

		// Token: 0x04002A79 RID: 10873
		[Token(Token = "0x4002A79")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04002A7A RID: 10874
		[Token(Token = "0x4002A7A")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<Collider> OnTriggerEnterEvent;

		// Token: 0x04002A7B RID: 10875
		[Token(Token = "0x4002A7B")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<Collider> OnTriggerExitEvent;

		// Token: 0x04002A7C RID: 10876
		[Token(Token = "0x4002A7C")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<Collision> OnCollisionEnterEvent;

		// Token: 0x04002A7D RID: 10877
		[Token(Token = "0x4002A7D")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent<Collision> OnCollisionExitEvent;
	}
}
