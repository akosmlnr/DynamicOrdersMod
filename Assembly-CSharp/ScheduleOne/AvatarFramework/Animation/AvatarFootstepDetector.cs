using System;
using Il2CppDummyDll;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000827 RID: 2087
	[Token(Token = "0x2000827")]
	[RequireComponent(typeof(Avatar))]
	public class AvatarFootstepDetector : GenericFootstepDetector
	{
		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008E4")]
		private Transform _leftBone
		{
			[Token(Token = "0x6003814")]
			[Address(RVA = "0x7E7950", Offset = "0x7E6B50", VA = "0x1807E7950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170008E5")]
		private Transform _rightBone
		{
			[Token(Token = "0x6003815")]
			[Address(RVA = "0x7E7970", Offset = "0x7E6B70", VA = "0x1807E7970")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003816")]
		[Address(RVA = "0x7E74C0", Offset = "0x7E66C0", VA = "0x1807E74C0")]
		private void Awake()
		{
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003817")]
		[Address(RVA = "0x7E7520", Offset = "0x7E6720", VA = "0x1807E7520", Slot = "5")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003818")]
		[Address(RVA = "0x7E7900", Offset = "0x7E6B00", VA = "0x1807E7900")]
		public AvatarFootstepDetector()
		{
		}

		// Token: 0x04002905 RID: 10501
		[Token(Token = "0x4002905")]
		private const float StepThreshold = 0.125f;

		// Token: 0x04002906 RID: 10502
		[Token(Token = "0x4002906")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _detectionRange;

		// Token: 0x04002907 RID: 10503
		[Token(Token = "0x4002907")]
		[FieldOffset(Offset = "0x48")]
		private Avatar _avatar;

		// Token: 0x04002908 RID: 10504
		[Token(Token = "0x4002908")]
		[FieldOffset(Offset = "0x50")]
		private bool _leftDown;

		// Token: 0x04002909 RID: 10505
		[Token(Token = "0x4002909")]
		[FieldOffset(Offset = "0x51")]
		private bool _rightDown;

		// Token: 0x0400290A RID: 10506
		[Token(Token = "0x400290A")]
		[FieldOffset(Offset = "0x54")]
		private float _detectionRangeSqr;
	}
}
