using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	public class VehicleCamera : MonoBehaviour
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000369")]
		private Transform cam
		{
			[Token(Token = "0x6000FCD")]
			[Address(RVA = "0xAFFBC0", Offset = "0xAFEDC0", VA = "0x180AFFBC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x1700036A")]
		private bool NeedSecondaryClick
		{
			[Token(Token = "0x6000FCE")]
			[Address(RVA = "0xAFFB40", Offset = "0xAFED40", VA = "0x180AFFB40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0xAFF220", Offset = "0xAFE420", VA = "0x180AFF220", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0xAFF670", Offset = "0xAFE870", VA = "0x180AFF670")]
		private void Subscribe()
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0xAFF7B0", Offset = "0xAFE9B0", VA = "0x180AFF7B0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0xAFEE70", Offset = "0xAFE070", VA = "0x180AFEE70")]
		private void PlayerEnteredVehicle(LandVehicle veh)
		{
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0xAFCD60", Offset = "0xAFBF60", VA = "0x180AFCD60")]
		private void CheckForClick()
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0xAFCF10", Offset = "0xAFC110", VA = "0x180AFCF10")]
		private void CheckForMouseMovement()
		{
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0xAFE700", Offset = "0xAFD900", VA = "0x180AFE700", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0xAFD3D0", Offset = "0xAFC5D0", VA = "0x180AFD3D0")]
		private void HandleNonSecondaryClickCameraMovement()
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0xAFDCE0", Offset = "0xAFCEE0", VA = "0x180AFDCE0")]
		private void HandleSecondaryClickCameraMovement()
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0xAFD110", Offset = "0xAFC310", VA = "0x180AFD110")]
		private void ForceCameraReturn()
		{
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00007980 File Offset: 0x00005B80
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x55FB70", Offset = "0x55ED70", VA = "0x18055FB70")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0xAFD1B0", Offset = "0xAFC3B0", VA = "0x180AFD1B0")]
		private Vector3 GetTargetCameraPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0xAFEAF0", Offset = "0xAFDCF0", VA = "0x180AFEAF0")]
		private Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0xAFFA90", Offset = "0xAFEC90", VA = "0x180AFFA90")]
		public VehicleCamera()
		{
		}

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000E18")]
		private const float followDelta = 10f;

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		private const float yMinLimit = -20f;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000E1A")]
		private const float manualOverrideTime = 0.01f;

		// Token: 0x04000E1B RID: 3611
		[Token(Token = "0x4000E1B")]
		private const float manualOverrideReturnTime = 0.6f;

		// Token: 0x04000E1C RID: 3612
		[Token(Token = "0x4000E1C")]
		private const float xSpeed = 60f;

		// Token: 0x04000E1D RID: 3613
		[Token(Token = "0x4000E1D")]
		private const float ySpeed = 40f;

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		private const float yMaxLimit = 89f;

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public LandVehicle vehicle;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x28")]
		[Header("Camera Settings")]
		[SerializeField]
		protected Transform cameraOrigin;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected float lateralOffset;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected float verticalOffset;

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x38")]
		protected bool cameraReversed;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x3C")]
		protected float timeSinceCameraManuallyAdjusted;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x40")]
		protected float orbitDistance;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0x44")]
		protected Vector3 lastFrameCameraOffset;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x50")]
		protected Vector3 lastManualOffset;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x68")]
		private Transform cameraDolly;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x70")]
		private float x;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x74")]
		private float y;

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x78")]
		private float mouseIdleCooldown;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0x7C")]
		private float mouseIdleTimer;
	}
}
