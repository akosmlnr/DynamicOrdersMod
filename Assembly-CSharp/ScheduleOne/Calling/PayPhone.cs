using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Lighting;
using ScheduleOne.ScriptableObjects;
using UnityEngine;

namespace ScheduleOne.Calling
{
	// Token: 0x020007A8 RID: 1960
	[Token(Token = "0x20007A8")]
	public class PayPhone : MonoBehaviour
	{
		// Token: 0x06003483 RID: 13443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x79CE20", Offset = "0x79C020", VA = "0x18079CE20")]
		private void Start()
		{
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003484")]
		[Address(RVA = "0x79CA70", Offset = "0x79BC70", VA = "0x18079CA70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003485")]
		[Address(RVA = "0x79CA40", Offset = "0x79BC40", VA = "0x18079CA40")]
		private void OnCallStarted(PhoneCallData data)
		{
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x79C9E0", Offset = "0x79BBE0", VA = "0x18079C9E0")]
		private void OnCallCompleted(PhoneCallData data)
		{
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x79CA10", Offset = "0x79BC10", VA = "0x18079CA10")]
		private void OnCallQueued(PhoneCallData data)
		{
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003488")]
		[Address(RVA = "0x79D430", Offset = "0x79C630", VA = "0x18079D430")]
		private void UpdateCallState()
		{
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003489")]
		[Address(RVA = "0x79CDB0", Offset = "0x79BFB0", VA = "0x18079CDB0")]
		private IEnumerator PeriodicRing()
		{
			return null;
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x79C730", Offset = "0x79B930", VA = "0x18079C730")]
		public void Hovered()
		{
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348B")]
		[Address(RVA = "0x79C7B0", Offset = "0x79B9B0", VA = "0x18079C7B0")]
		public void Interacted()
		{
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x0000FD20 File Offset: 0x0000DF20
		[Token(Token = "0x600348C")]
		[Address(RVA = "0x79C670", Offset = "0x79B870", VA = "0x18079C670")]
		private bool CanInteract()
		{
			return default(bool);
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PayPhone()
		{
		}

		// Token: 0x0400264A RID: 9802
		[Token(Token = "0x400264A")]
		public const float RING_INTERVAL = 4f;

		// Token: 0x0400264B RID: 9803
		[Token(Token = "0x400264B")]
		public const float RING_RANGE = 9f;

		// Token: 0x0400264C RID: 9804
		[Token(Token = "0x400264C")]
		private const float ringRangeSquared = 81f;

		// Token: 0x0400264D RID: 9805
		[Token(Token = "0x400264D")]
		[FieldOffset(Offset = "0x20")]
		public PhoneCallData QueuedCall;

		// Token: 0x0400264E RID: 9806
		[Token(Token = "0x400264E")]
		[FieldOffset(Offset = "0x28")]
		public PhoneCallData ActiveCall;

		// Token: 0x0400264F RID: 9807
		[Token(Token = "0x400264F")]
		[FieldOffset(Offset = "0x30")]
		public BlinkingLight Light;

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[FieldOffset(Offset = "0x38")]
		public AudioSourceController RingSound;

		// Token: 0x04002651 RID: 9809
		[Token(Token = "0x4002651")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController AnswerSound;

		// Token: 0x04002652 RID: 9810
		[Token(Token = "0x4002652")]
		[FieldOffset(Offset = "0x48")]
		public InteractableObject IntObj;

		// Token: 0x04002653 RID: 9811
		[Token(Token = "0x4002653")]
		[FieldOffset(Offset = "0x50")]
		public Transform CameraPosition;

		// Token: 0x04002654 RID: 9812
		[Token(Token = "0x4002654")]
		[FieldOffset(Offset = "0x58")]
		private float lastRingTime;

		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine periodicRingHandle;
	}
}
