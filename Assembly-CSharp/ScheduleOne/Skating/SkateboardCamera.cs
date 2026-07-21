using System;
using FishNet.Object;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x02000322 RID: 802
	[Token(Token = "0x2000322")]
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardCamera : NetworkBehaviour
	{
		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003F1")]
		private Transform cam
		{
			[Token(Token = "0x600133A")]
			[Address(RVA = "0x592600", Offset = "0x591800", VA = "0x180592600")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x170003F2")]
		private bool NeedSecondaryClick
		{
			[Token(Token = "0x600133B")]
			[Address(RVA = "0x592580", Offset = "0x591780", VA = "0x180592580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x58F4E0", Offset = "0x58E6E0", VA = "0x18058F4E0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x591720", Offset = "0x590920", VA = "0x180591720")]
		private void OnPlayerMountedSkateboard(Skateboard skateboard)
		{
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x591AD0", Offset = "0x590CD0", VA = "0x180591AD0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x591520", Offset = "0x590720", VA = "0x180591520")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x592150", Offset = "0x591350", VA = "0x180592150")]
		private void Update()
		{
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x58F530", Offset = "0x58E730", VA = "0x18058F530")]
		private void CheckForClick()
		{
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x58F720", Offset = "0x58E920", VA = "0x18058F720")]
		private void CheckForMouseMovement()
		{
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x591080", Offset = "0x590280", VA = "0x180591080")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x591B20", Offset = "0x590D20", VA = "0x180591B20")]
		private void UpdateCamera()
		{
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x58FC80", Offset = "0x58EE80", VA = "0x18058FC80")]
		private void HandleNonSecondaryClickCameraMovement()
		{
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x5905F0", Offset = "0x58F7F0", VA = "0x1805905F0")]
		private void HandleSecondaryClickCameraMovement()
		{
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x591F00", Offset = "0x591100", VA = "0x180591F00")]
		private void UpdateFOV()
		{
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x58F940", Offset = "0x58EB40", VA = "0x18058F940")]
		private void ForceCameraReturn()
		{
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x55FB70", Offset = "0x55ED70", VA = "0x18055FB70")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x58FA00", Offset = "0x58EC00", VA = "0x18058FA00")]
		private Vector3 GetTargetCameraPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x591110", Offset = "0x590310", VA = "0x180591110")]
		private Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x592480", Offset = "0x591680", VA = "0x180592480")]
		public SkateboardCamera()
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x591500", Offset = "0x590700", VA = "0x180591500", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x5914E0", Offset = "0x5906E0", VA = "0x1805914E0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x58F170", Offset = "0x58E370", VA = "0x18058F170")]
		private void Awake_UserLogic_ScheduleOne.Skating.SkateboardCamera_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		private const float followDelta = 7.5f;

		// Token: 0x040011B7 RID: 4535
		[Token(Token = "0x40011B7")]
		private const float yMinLimit = -20f;

		// Token: 0x040011B8 RID: 4536
		[Token(Token = "0x40011B8")]
		private const float manualOverrideTime = 0.01f;

		// Token: 0x040011B9 RID: 4537
		[Token(Token = "0x40011B9")]
		private const float manualOverrideReturnTime = 0.6f;

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x40011BA")]
		private const float xSpeed = 60f;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x40011BB")]
		private const float ySpeed = 40f;

		// Token: 0x040011BC RID: 4540
		[Token(Token = "0x40011BC")]
		private const float yMaxLimit = 89f;

		// Token: 0x040011BD RID: 4541
		[Token(Token = "0x40011BD")]
		[FieldOffset(Offset = "0x118")]
		[Header("References")]
		public Transform cameraOrigin;

		// Token: 0x040011BE RID: 4542
		[Token(Token = "0x40011BE")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public float CameraFollowSpeed;

		// Token: 0x040011BF RID: 4543
		[Token(Token = "0x40011BF")]
		[FieldOffset(Offset = "0x124")]
		public float HorizontalOffset;

		// Token: 0x040011C0 RID: 4544
		[Token(Token = "0x40011C0")]
		[FieldOffset(Offset = "0x128")]
		public float VerticalOffset;

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x12C")]
		public float CameraDownAngle;

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x130")]
		[Header("Settings")]
		public float FOVMultiplier_MinSpeed;

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x134")]
		public float FOVMultiplier_MaxSpeed;

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x138")]
		public float FOVMultiplierChangeRate;

		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x140")]
		private Skateboard board;

		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x148")]
		private float currentFovMultiplier;

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x14C")]
		private bool cameraReversed;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x14D")]
		private bool cameraAdjusted;

		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x150")]
		private float timeSinceCameraManuallyAdjusted;

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x154")]
		private float orbitDistance;

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 lastFrameCameraOffset;

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x164")]
		private Vector3 lastManualOffset;

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x170")]
		private Transform targetTransform;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x178")]
		private Transform cameraDolly;

		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x180")]
		private float x;

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x184")]
		private float y;

		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0x188")]
		private float mouseIdleCooldown;

		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x18C")]
		private float mouseIdleTimer;

		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x190")]
		private bool NetworkInitialize___EarlyScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted;

		// Token: 0x040011D4 RID: 4564
		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0x191")]
		private bool NetworkInitialize__LateScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted;
	}
}
