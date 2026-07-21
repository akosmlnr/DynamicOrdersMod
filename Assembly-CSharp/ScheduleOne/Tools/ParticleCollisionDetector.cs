using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087E RID: 2174
	[Token(Token = "0x200087E")]
	public class ParticleCollisionDetector : MonoBehaviour
	{
		// Token: 0x0600398C RID: 14732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x80A020", Offset = "0x809220", VA = "0x18080A020")]
		private void Awake()
		{
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398D")]
		[Address(RVA = "0x80A070", Offset = "0x809270", VA = "0x18080A070")]
		public void OnParticleCollision(GameObject other)
		{
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398E")]
		[Address(RVA = "0x80A0D0", Offset = "0x8092D0", VA = "0x18080A0D0")]
		private void OnParticleTrigger()
		{
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398F")]
		[Address(RVA = "0x80A1A0", Offset = "0x8093A0", VA = "0x18080A1A0")]
		public ParticleCollisionDetector()
		{
		}

		// Token: 0x04002A68 RID: 10856
		[Token(Token = "0x4002A68")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<GameObject> onCollision;

		// Token: 0x04002A69 RID: 10857
		[Token(Token = "0x4002A69")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem ps;
	}
}
