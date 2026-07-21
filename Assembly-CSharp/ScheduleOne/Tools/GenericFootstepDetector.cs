using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000871 RID: 2161
	[Token(Token = "0x2000871")]
	public abstract class GenericFootstepDetector : MonoBehaviour
	{
		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		// (set) Token: 0x06003957 RID: 14679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700090B")]
		public float VolumeMultiplier
		{
			[Token(Token = "0x6003956")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003957")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003958")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003959")]
		[Address(RVA = "0x7FE320", Offset = "0x7FD520", VA = "0x1807FE320", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395A")]
		[Address(RVA = "0x7FE480", Offset = "0x7FD680", VA = "0x1807FE480")]
		protected void TriggerStep(EMaterialType materialType, Vector3 stepPosition)
		{
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		[Token(Token = "0x600395B")]
		[Address(RVA = "0x7FE050", Offset = "0x7FD250", VA = "0x1807FE050")]
		protected bool IsCooldown()
		{
			return default(bool);
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[Token(Token = "0x600395C")]
		[Address(RVA = "0x7FE080", Offset = "0x7FD280", VA = "0x1807FE080")]
		protected bool IsGrounded(out EMaterialType surfaceType)
		{
			return default(bool);
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395D")]
		[Address(RVA = "0x7FE5E0", Offset = "0x7FD7E0", VA = "0x1807FE5E0")]
		protected GenericFootstepDetector()
		{
		}

		// Token: 0x04002A40 RID: 10816
		[Token(Token = "0x4002A40")]
		private const float GroundDetectionRange = 0.15f;

		// Token: 0x04002A41 RID: 10817
		[Token(Token = "0x4002A41")]
		private const float GroundDetectionRayOriginShift = 0.5f;

		// Token: 0x04002A43 RID: 10819
		[Token(Token = "0x4002A43")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _baseVolume;

		// Token: 0x04002A44 RID: 10820
		[Token(Token = "0x4002A44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _stepDetectionCooldown;

		// Token: 0x04002A45 RID: 10821
		[Token(Token = "0x4002A45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform _referencePoint;

		// Token: 0x04002A46 RID: 10822
		[Token(Token = "0x4002A46")]
		[FieldOffset(Offset = "0x38")]
		private float _timeOnLastStep;

		// Token: 0x04002A47 RID: 10823
		[Token(Token = "0x4002A47")]
		[FieldOffset(Offset = "0x0")]
		private static LayerMask _groundDetectionLayerMask;
	}
}
