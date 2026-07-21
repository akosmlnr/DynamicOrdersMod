using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002ED RID: 749
	[Token(Token = "0x20002ED")]
	public class RunnerGameCharacter : MonoBehaviour
	{
		// Token: 0x06001162 RID: 4450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001162")]
		[Address(RVA = "0xB1FBB0", Offset = "0xB1EDB0", VA = "0x180B1FBB0")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RunnerGameCharacter()
		{
		}

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x20")]
		public RunnerGame Game;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onHit;
	}
}
