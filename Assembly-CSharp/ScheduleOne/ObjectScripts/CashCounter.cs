using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009D9 RID: 2521
	[Token(Token = "0x20009D9")]
	public class CashCounter : MonoBehaviour
	{
		// Token: 0x0600484B RID: 18507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600484B")]
		[Address(RVA = "0x8B99E0", Offset = "0x8B8BE0", VA = "0x1808B99E0", Slot = "4")]
		public virtual void LateUpdate()
		{
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600484C")]
		[Address(RVA = "0x8B9BB0", Offset = "0x8B8DB0", VA = "0x1808B9BB0")]
		private IEnumerator LerpNote(Transform note)
		{
			return null;
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600484D")]
		[Address(RVA = "0x8B9C40", Offset = "0x8B8E40", VA = "0x1808B9C40")]
		public CashCounter()
		{
		}

		// Token: 0x04003316 RID: 13078
		[Token(Token = "0x4003316")]
		public const float NoteLerpTime = 0.18f;

		// Token: 0x04003317 RID: 13079
		[Token(Token = "0x4003317")]
		[FieldOffset(Offset = "0x20")]
		public bool IsOn;

		// Token: 0x04003318 RID: 13080
		[Token(Token = "0x4003318")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public GameObject UpperNotes;

		// Token: 0x04003319 RID: 13081
		[Token(Token = "0x4003319")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LowerNotes;

		// Token: 0x0400331A RID: 13082
		[Token(Token = "0x400331A")]
		[FieldOffset(Offset = "0x38")]
		public Transform NoteStartPoint;

		// Token: 0x0400331B RID: 13083
		[Token(Token = "0x400331B")]
		[FieldOffset(Offset = "0x40")]
		public Transform NoteEndPoint;

		// Token: 0x0400331C RID: 13084
		[Token(Token = "0x400331C")]
		[FieldOffset(Offset = "0x48")]
		public List<Transform> MovingNotes;

		// Token: 0x0400331D RID: 13085
		[Token(Token = "0x400331D")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController Audio;

		// Token: 0x0400331E RID: 13086
		[Token(Token = "0x400331E")]
		[FieldOffset(Offset = "0x58")]
		private bool lerping;
	}
}
