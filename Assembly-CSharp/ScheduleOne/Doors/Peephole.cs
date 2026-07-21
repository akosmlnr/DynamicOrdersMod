using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	public class Peephole : MonoBehaviour
	{
		// Token: 0x06002E7F RID: 11903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x74C0A0", Offset = "0x74B2A0", VA = "0x18074C0A0")]
		public void Open()
		{
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E80")]
		[Address(RVA = "0x74C030", Offset = "0x74B230", VA = "0x18074C030")]
		public void Close()
		{
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public Peephole()
		{
		}

		// Token: 0x0400226B RID: 8811
		[Token(Token = "0x400226B")]
		[FieldOffset(Offset = "0x20")]
		public Animation DoorAnim;

		// Token: 0x0400226C RID: 8812
		[Token(Token = "0x400226C")]
		[FieldOffset(Offset = "0x28")]
		public AudioSourceController OpenSound;

		// Token: 0x0400226D RID: 8813
		[Token(Token = "0x400226D")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController CloseSound;
	}
}
