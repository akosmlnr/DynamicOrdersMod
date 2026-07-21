using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Building.Doors
{
	// Token: 0x020007C6 RID: 1990
	[Token(Token = "0x20007C6")]
	public class DoorKnocker : MonoBehaviour
	{
		// Token: 0x0600351F RID: 13599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600351F")]
		[Address(RVA = "0x7CF530", Offset = "0x7CE730", VA = "0x1807CF530")]
		public void Knock()
		{
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003520")]
		[Address(RVA = "0x7CF580", Offset = "0x7CE780", VA = "0x1807CF580")]
		public void PlayKnockingSound()
		{
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003521")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DoorKnocker()
		{
		}

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Animation Anim;

		// Token: 0x040026AB RID: 9899
		[Token(Token = "0x40026AB")]
		[FieldOffset(Offset = "0x28")]
		public string KnockingSoundClipName;

		// Token: 0x040026AC RID: 9900
		[Token(Token = "0x40026AC")]
		[FieldOffset(Offset = "0x30")]
		public AudioSource KnockingSound;
	}
}
