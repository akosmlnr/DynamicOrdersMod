using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x0200059E RID: 1438
	[Token(Token = "0x200059E")]
	[RequireComponent(typeof(ToggleableLight))]
	public class BlinkingLight : MonoBehaviour
	{
		// Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x66C950", Offset = "0x66BB50", VA = "0x18066C950")]
		private void Awake()
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x66CA10", Offset = "0x66BC10", VA = "0x18066CA10")]
		private void Update()
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x66C9A0", Offset = "0x66BBA0", VA = "0x18066C9A0")]
		private IEnumerator Blink()
		{
			return null;
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x66CAA0", Offset = "0x66BCA0", VA = "0x18066CAA0")]
		public BlinkingLight()
		{
		}

		// Token: 0x04001ABA RID: 6842
		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x20")]
		public bool IsOn;

		// Token: 0x04001ABB RID: 6843
		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x24")]
		public float OnTime;

		// Token: 0x04001ABC RID: 6844
		[Token(Token = "0x4001ABC")]
		[FieldOffset(Offset = "0x28")]
		public float OffTime;

		// Token: 0x04001ABD RID: 6845
		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0x30")]
		private ToggleableLight light;

		// Token: 0x04001ABE RID: 6846
		[Token(Token = "0x4001ABE")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine blinkRoutine;
	}
}
