using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000849 RID: 2121
	[Token(Token = "0x2000849")]
	public class ActiveInRange : MonoBehaviour
	{
		// Token: 0x060038C6 RID: 14534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C6")]
		[Address(RVA = "0x7F69F0", Offset = "0x7F5BF0", VA = "0x1807F69F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C7")]
		[Address(RVA = "0x7F6C90", Offset = "0x7F5E90", VA = "0x1807F6C90")]
		public ActiveInRange()
		{
		}

		// Token: 0x040029D1 RID: 10705
		[Token(Token = "0x40029D1")]
		[FieldOffset(Offset = "0x20")]
		public float Distance;

		// Token: 0x040029D2 RID: 10706
		[Token(Token = "0x40029D2")]
		[FieldOffset(Offset = "0x24")]
		public bool ScaleByLODBias;

		// Token: 0x040029D3 RID: 10707
		[Token(Token = "0x40029D3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] ObjectsToActivate;

		// Token: 0x040029D4 RID: 10708
		[Token(Token = "0x40029D4")]
		[FieldOffset(Offset = "0x30")]
		public bool Reverse;

		// Token: 0x040029D5 RID: 10709
		[Token(Token = "0x40029D5")]
		[FieldOffset(Offset = "0x31")]
		private bool isVisible;
	}
}
