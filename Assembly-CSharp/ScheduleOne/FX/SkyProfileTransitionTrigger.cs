using System;
using Funly.SkyStudio;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.FX
{
	// Token: 0x02000692 RID: 1682
	[Token(Token = "0x2000692")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Collider))]
	public class SkyProfileTransitionTrigger : MonoBehaviour
	{
		// Token: 0x06002B8A RID: 11146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x71E910", Offset = "0x71DB10", VA = "0x18071E910")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x71EA40", Offset = "0x71DC40", VA = "0x18071EA40")]
		public void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x71EB70", Offset = "0x71DD70", VA = "0x18071EB70")]
		public SkyProfileTransitionTrigger()
		{
		}

		// Token: 0x040020CC RID: 8396
		[Token(Token = "0x40020CC")]
		[FieldOffset(Offset = "0x20")]
		public SkyProfile TransitionToOnEnter;

		// Token: 0x040020CD RID: 8397
		[Token(Token = "0x40020CD")]
		[FieldOffset(Offset = "0x28")]
		public SkyProfile TransitionToOnExit;

		// Token: 0x040020CE RID: 8398
		[Token(Token = "0x40020CE")]
		[FieldOffset(Offset = "0x30")]
		public float TransitionDuration;
	}
}
