using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000857 RID: 2135
	[Token(Token = "0x2000857")]
	[RequireComponent(typeof(Rigidbody))]
	public class CombatNPCDetector : MonoBehaviour
	{
		// Token: 0x060038FA RID: 14586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FA")]
		[Address(RVA = "0x7F9520", Offset = "0x7F8720", VA = "0x1807F9520")]
		private void Awake()
		{
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60038FB")]
		[Address(RVA = "0x7F98A0", Offset = "0x7F8AA0", VA = "0x1807F98A0")]
		private IEnumerator UpdateWhileDetected()
		{
			return null;
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x7F95E0", Offset = "0x7F87E0", VA = "0x1807F95E0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x7F97A0", Offset = "0x7F89A0", VA = "0x1807F97A0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x7F9910", Offset = "0x7F8B10", VA = "0x1807F9910")]
		public CombatNPCDetector()
		{
		}

		// Token: 0x040029FE RID: 10750
		[Token(Token = "0x40029FE")]
		[FieldOffset(Offset = "0x20")]
		public bool DetectOnlyInCombat;

		// Token: 0x040029FF RID: 10751
		[Token(Token = "0x40029FF")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onDetected;

		// Token: 0x04002A00 RID: 10752
		[Token(Token = "0x4002A00")]
		[FieldOffset(Offset = "0x30")]
		public float ContactTimeForDetection;

		// Token: 0x04002A01 RID: 10753
		[Token(Token = "0x4002A01")]
		[FieldOffset(Offset = "0x38")]
		private NPC npcInContact;

		// Token: 0x04002A02 RID: 10754
		[Token(Token = "0x4002A02")]
		[FieldOffset(Offset = "0x40")]
		private float contactTime;

		// Token: 0x04002A03 RID: 10755
		[Token(Token = "0x4002A03")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine detectionRoutine;
	}
}
