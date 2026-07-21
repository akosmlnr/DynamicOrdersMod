using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E26 RID: 3622
	[Token(Token = "0x2000E26")]
	public class Explosion : MonoBehaviour
	{
		// Token: 0x060067EC RID: 26604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067EC")]
		[Address(RVA = "0xAA98B0", Offset = "0xAA8AB0", VA = "0x180AA98B0")]
		public void Initialize(Vector3 origin, ExplosionData data)
		{
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067ED")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public Explosion()
		{
		}

		// Token: 0x04004971 RID: 18801
		[Token(Token = "0x4004971")]
		[FieldOffset(Offset = "0x20")]
		public AudioSourceController Sound;
	}
}
