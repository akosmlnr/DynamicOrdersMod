using System;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Core.Audio;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BEA RID: 3050
	[Token(Token = "0x2000BEA")]
	[RequireComponent(typeof(Rigidbody))]
	public class RBImpactSounds : MonoBehaviour
	{
		// Token: 0x06005A37 RID: 23095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A37")]
		[Address(RVA = "0x9B25B0", Offset = "0x9B17B0", VA = "0x1809B25B0")]
		private void Awake()
		{
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A38")]
		[Address(RVA = "0x9B2910", Offset = "0x9B1B10", VA = "0x1809B2910")]
		private void OnImpacted(Impact impact)
		{
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A39")]
		[Address(RVA = "0x9B2730", Offset = "0x9B1930", VA = "0x1809B2730")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RBImpactSounds()
		{
		}

		// Token: 0x04003C51 RID: 15441
		[Token(Token = "0x4003C51")]
		public const float MinImpactMomentum = 4f;

		// Token: 0x04003C52 RID: 15442
		[Token(Token = "0x4003C52")]
		public const float SoundCooldown = 0.25f;

		// Token: 0x04003C53 RID: 15443
		[Token(Token = "0x4003C53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("Material")]
		private EImpactSound _material;

		// Token: 0x04003C54 RID: 15444
		[Token(Token = "0x4003C54")]
		[FieldOffset(Offset = "0x24")]
		private float _lastImpactTime;

		// Token: 0x04003C55 RID: 15445
		[Token(Token = "0x4003C55")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody _rb;
	}
}
