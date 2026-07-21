using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x20002F6")]
	public class TVInteractable : MonoBehaviour
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0xB28750", Offset = "0xB27950", VA = "0x180B28750")]
		private void Start()
		{
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A4")]
		[Address(RVA = "0xB286A0", Offset = "0xB278A0", VA = "0x180B286A0")]
		private void Hovered()
		{
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A5")]
		[Address(RVA = "0xB28720", Offset = "0xB27920", VA = "0x180B28720")]
		private void Interacted()
		{
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A6")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TVInteractable()
		{
		}

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[FieldOffset(Offset = "0x20")]
		public InteractableObject IntObj;

		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		[FieldOffset(Offset = "0x28")]
		public TVInterface Interface;
	}
}
