using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000834 RID: 2100
	[Token(Token = "0x2000834")]
	public class AvatarGun : AvatarRangedWeapon
	{
		// Token: 0x06003856 RID: 14422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003856")]
		[Address(RVA = "0x7E7A20", Offset = "0x7E6C20", VA = "0x1807E7A20", Slot = "12")]
		protected override void Shoot(Vector3 endPoint)
		{
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x7E7990", Offset = "0x7E6B90", VA = "0x1807E7990")]
		private IEnumerator Flash(Vector3 endPoint)
		{
			return null;
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003858")]
		[Address(RVA = "0x7E7D00", Offset = "0x7E6F00", VA = "0x1807E7D00")]
		public AvatarGun()
		{
		}

		// Token: 0x0400294D RID: 10573
		[Token(Token = "0x400294D")]
		[FieldOffset(Offset = "0x110")]
		[Header("References")]
		public Animation Anim;

		// Token: 0x0400294E RID: 10574
		[Token(Token = "0x400294E")]
		[FieldOffset(Offset = "0x118")]
		public ParticleSystem ShellParticles;

		// Token: 0x0400294F RID: 10575
		[Token(Token = "0x400294F")]
		[FieldOffset(Offset = "0x120")]
		public ParticleSystem SmokeParticles;

		// Token: 0x04002950 RID: 10576
		[Token(Token = "0x4002950")]
		[FieldOffset(Offset = "0x128")]
		public Transform FlashObject;

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		[FieldOffset(Offset = "0x130")]
		[Header("Prefabs")]
		public GameObject RayPrefab;

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		[FieldOffset(Offset = "0x138")]
		private Coroutine flashRoutine;
	}
}
