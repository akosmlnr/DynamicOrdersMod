using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020007CB RID: 1995
	[Token(Token = "0x20007CB")]
	[RequireComponent(typeof(Rigidbody))]
	public class TrashContainerCollider : MonoBehaviour
	{
		// Token: 0x06003567 RID: 13671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003567")]
		[Address(RVA = "0x7D2C90", Offset = "0x7D1E90", VA = "0x1807D2C90")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003568")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TrashContainerCollider()
		{
		}

		// Token: 0x040026C7 RID: 9927
		[Token(Token = "0x40026C7")]
		[FieldOffset(Offset = "0x20")]
		public TrashContainer Container;
	}
}
