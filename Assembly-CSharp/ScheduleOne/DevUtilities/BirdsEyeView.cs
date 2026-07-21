using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020009ED RID: 2541
	[Token(Token = "0x20009ED")]
	public class BirdsEyeView : Singleton<BirdsEyeView>
	{
		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B5D")]
		private Transform playerCam
		{
			[Token(Token = "0x60048B8")]
			[Address(RVA = "0x8F3100", Offset = "0x8F2300", VA = "0x1808F3100")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060048B9 RID: 18617 RVA: 0x00013AB8 File Offset: 0x00011CB8
		// (set) Token: 0x060048BA RID: 18618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5E")]
		public bool isEnabled
		{
			[Token(Token = "0x60048B9")]
			[Address(RVA = "0x8F30F0", Offset = "0x8F22F0", VA = "0x1808F30F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048BA")]
			[Address(RVA = "0x8F3180", Offset = "0x8F2380", VA = "0x1808F3180")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BB")]
		[Address(RVA = "0x8F1990", Offset = "0x8F0B90", VA = "0x1808F1990", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x8F3000", Offset = "0x8F2200", VA = "0x1808F3000", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x8F1FC0", Offset = "0x8F11C0", VA = "0x1808F1FC0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BE")]
		[Address(RVA = "0x8F1BC0", Offset = "0x8F0DC0", VA = "0x1808F1BC0")]
		public void Enable(Vector3 startPosition, Quaternion startRotation)
		{
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BF")]
		[Address(RVA = "0x8F1AC0", Offset = "0x8F0CC0", VA = "0x1808F1AC0")]
		public void Disable(bool reenableCameraLook = true)
		{
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C0")]
		[Address(RVA = "0x8F2420", Offset = "0x8F1620", VA = "0x1808F2420")]
		protected void UpdateLateralMovement()
		{
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C1")]
		[Address(RVA = "0x8F2E10", Offset = "0x8F2010", VA = "0x1808F2E10")]
		protected void UpdateScrollMovement()
		{
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C2")]
		[Address(RVA = "0x8F28D0", Offset = "0x8F1AD0", VA = "0x1808F28D0")]
		protected void UpdateRotation()
		{
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C3")]
		[Address(RVA = "0x8F1DD0", Offset = "0x8F0FD0", VA = "0x1808F1DD0")]
		private void FinalizeCameraMovement()
		{
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00013AD0 File Offset: 0x00011CD0
		[Token(Token = "0x60048C4")]
		[Address(RVA = "0x55FB70", Offset = "0x55ED70", VA = "0x18055FB70")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C5")]
		[Address(RVA = "0x8F1A70", Offset = "0x8F0C70", VA = "0x1808F1A70")]
		private void CancelOriginSlide()
		{
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x8F1FE0", Offset = "0x8F11E0", VA = "0x1808F1FE0")]
		public void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)
		{
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x8F3040", Offset = "0x8F2240", VA = "0x1808F3040")]
		public BirdsEyeView()
		{
		}

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public Vector3 bounds_Min;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 bounds_Max;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[FieldOffset(Offset = "0x40")]
		[Header("Camera settings")]
		public float lateralMovementSpeed;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		[FieldOffset(Offset = "0x44")]
		public float scrollMovementSpeed;

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		[FieldOffset(Offset = "0x48")]
		public float targetFollowSpeed;

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[FieldOffset(Offset = "0x4C")]
		[Header("Camera orbit settings")]
		public float xSpeed;

		// Token: 0x0400336D RID: 13165
		[Token(Token = "0x400336D")]
		[FieldOffset(Offset = "0x50")]
		public float ySpeed;

		// Token: 0x0400336E RID: 13166
		[Token(Token = "0x400336E")]
		[FieldOffset(Offset = "0x54")]
		public float yMinLimit;

		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		[FieldOffset(Offset = "0x58")]
		public float yMaxLimit;

		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 rotationOriginPoint;

		// Token: 0x04003371 RID: 13169
		[Token(Token = "0x4003371")]
		[FieldOffset(Offset = "0x68")]
		private float distance;

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[FieldOffset(Offset = "0x6C")]
		private float prevDistance;

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[FieldOffset(Offset = "0x70")]
		private float x;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[FieldOffset(Offset = "0x74")]
		private float y;

		// Token: 0x04003375 RID: 13173
		[Token(Token = "0x4003375")]
		[FieldOffset(Offset = "0x78")]
		private Transform targetTransform;

		// Token: 0x04003377 RID: 13175
		[Token(Token = "0x4003377")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine originSlideRoutine;
	}
}
