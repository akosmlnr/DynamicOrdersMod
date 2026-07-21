using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200088C RID: 2188
	[Token(Token = "0x200088C")]
	public class RigidbodyEventBroadcaster : MonoBehaviour
	{
		// Token: 0x060039DA RID: 14810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x80D3D0", Offset = "0x80C5D0", VA = "0x18080D3D0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RigidbodyEventBroadcaster()
		{
		}

		// Token: 0x04002A94 RID: 10900
		[Token(Token = "0x4002A94")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<Collider> onTriggerEnter;
	}
}
