using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	public class FoliageRustleSound : MonoBehaviour
	{
		// Token: 0x06001D46 RID: 7494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x621AA0", Offset = "0x620CA0", VA = "0x180621AA0")]
		private void Awake()
		{
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x621B20", Offset = "0x620D20", VA = "0x180621B20")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x621BC0", Offset = "0x620DC0", VA = "0x180621BC0")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x621E10", Offset = "0x621010", VA = "0x180621E10")]
		private void UpdateActive()
		{
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D4A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public FoliageRustleSound()
		{
		}

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40018AF")]
		public const float ACTIVATION_RANGE_SQUARED = 900f;

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40018B0")]
		public const float COOLDOWN = 1f;

		// Token: 0x040018B1 RID: 6321
		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController Sound;

		// Token: 0x040018B2 RID: 6322
		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Container;

		// Token: 0x040018B3 RID: 6323
		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x30")]
		private float timeOnLastHit;
	}
}
