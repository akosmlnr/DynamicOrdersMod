using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A5 RID: 1445
	[Token(Token = "0x20005A5")]
	[RequireComponent(typeof(ReflectionProbe))]
	public class ReflectionProbeUpdater : MonoBehaviour
	{
		// Token: 0x06002106 RID: 8454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x6844F0", Offset = "0x6836F0", VA = "0x1806844F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x6845D0", Offset = "0x6837D0", VA = "0x1806845D0")]
		private void Start()
		{
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x684910", Offset = "0x683B10", VA = "0x180684910")]
		private void UpdateProbe()
		{
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x684580", Offset = "0x683780", VA = "0x180684580")]
		private IEnumerator ProcessQueue()
		{
			return null;
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ReflectionProbeUpdater()
		{
		}

		// Token: 0x04001AE4 RID: 6884
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0x20")]
		public ReflectionProbe Probe;

		// Token: 0x04001AE5 RID: 6885
		[Token(Token = "0x4001AE5")]
		[FieldOffset(Offset = "0x0")]
		private static List<ReflectionProbe> renderQueue;

		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0x8")]
		private static Coroutine RenderRoutine;
	}
}
