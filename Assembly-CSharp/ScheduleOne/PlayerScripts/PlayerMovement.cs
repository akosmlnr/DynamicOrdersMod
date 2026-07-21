using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	public class PlayerMovement : PlayerSingleton<PlayerMovement>
	{
		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		// (set) Token: 0x06002578 RID: 9592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000690")]
		public bool CanMove
		{
			[Token(Token = "0x6002577")]
			[Address(RVA = "0x58D090", Offset = "0x58C290", VA = "0x18058D090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002578")]
			[Address(RVA = "0x58D250", Offset = "0x58C450", VA = "0x18058D250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		// (set) Token: 0x0600257A RID: 9594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000691")]
		public bool CanJump
		{
			[Token(Token = "0x6002579")]
			[Address(RVA = "0x6B6E40", Offset = "0x6B6040", VA = "0x1806B6E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600257A")]
			[Address(RVA = "0x6B6F10", Offset = "0x6B6110", VA = "0x1806B6F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x17000692")]
		public Vector3 Movement
		{
			[Token(Token = "0x600257B")]
			[Address(RVA = "0x6B6EF0", Offset = "0x6B60F0", VA = "0x1806B6EF0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x0000C420 File Offset: 0x0000A620
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000693")]
		public bool IsJumping
		{
			[Token(Token = "0x600257C")]
			[Address(RVA = "0x6B6E70", Offset = "0x6B6070", VA = "0x1806B6E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600257D")]
			[Address(RVA = "0x6B6F60", Offset = "0x6B6160", VA = "0x1806B6F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x0000C438 File Offset: 0x0000A638
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000694")]
		public float TimeAirborne
		{
			[Token(Token = "0x600257E")]
			[Address(RVA = "0x4CBFA0", Offset = "0x4CB1A0", VA = "0x1804CBFA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600257F")]
			[Address(RVA = "0x4E12A0", Offset = "0x4E04A0", VA = "0x1804E12A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x0000C450 File Offset: 0x0000A650
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000695")]
		public float TimeGrounded
		{
			[Token(Token = "0x6002580")]
			[Address(RVA = "0x4E1290", Offset = "0x4E0490", VA = "0x1804E1290")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002581")]
			[Address(RVA = "0x4E12B0", Offset = "0x4E04B0", VA = "0x1804E12B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x0000C468 File Offset: 0x0000A668
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000696")]
		public bool IsGrounded
		{
			[Token(Token = "0x6002582")]
			[Address(RVA = "0x496DF0", Offset = "0x495FF0", VA = "0x180496DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002583")]
			[Address(RVA = "0x496E70", Offset = "0x496070", VA = "0x180496E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x0000C480 File Offset: 0x0000A680
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000697")]
		public bool IsCrouched
		{
			[Token(Token = "0x6002584")]
			[Address(RVA = "0x6B6E60", Offset = "0x6B6060", VA = "0x1806B6E60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002585")]
			[Address(RVA = "0x6B6F50", Offset = "0x6B6150", VA = "0x1806B6F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x0000C498 File Offset: 0x0000A698
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000698")]
		public float StandingScale
		{
			[Token(Token = "0x6002586")]
			[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002587")]
			[Address(RVA = "0x49B890", Offset = "0x49AA90", VA = "0x18049B890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000699")]
		public bool IsRagdolled
		{
			[Token(Token = "0x6002588")]
			[Address(RVA = "0x4D4690", Offset = "0x4D3890", VA = "0x1804D4690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002589")]
			[Address(RVA = "0x4D4A40", Offset = "0x4D3C40", VA = "0x1804D4A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069A")]
		public bool IsSprinting
		{
			[Token(Token = "0x600258A")]
			[Address(RVA = "0x4D4750", Offset = "0x4D3950", VA = "0x1804D4750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600258B")]
			[Address(RVA = "0x4D4AD0", Offset = "0x4D3CD0", VA = "0x1804D4AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069B")]
		public bool ForceSprint
		{
			[Token(Token = "0x600258C")]
			[Address(RVA = "0x6B6E50", Offset = "0x6B6050", VA = "0x1806B6E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600258D")]
			[Address(RVA = "0x6B6F40", Offset = "0x6B6140", VA = "0x1806B6F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069C")]
		public float CurrentStaminaReserve
		{
			[Token(Token = "0x600258E")]
			[Address(RVA = "0x4944A0", Offset = "0x4936A0", VA = "0x1804944A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600258F")]
			[Address(RVA = "0x6B6F30", Offset = "0x6B6130", VA = "0x1806B6F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x0000C510 File Offset: 0x0000A710
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069D")]
		public float CurrentSprintMultiplier
		{
			[Token(Token = "0x6002590")]
			[Address(RVA = "0x4C20F0", Offset = "0x4C12F0", VA = "0x1804C20F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002591")]
			[Address(RVA = "0x6B6F20", Offset = "0x6B6120", VA = "0x1806B6F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069E")]
		public LandVehicle CurrentVehicle
		{
			[Token(Token = "0x6002592")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002593")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069F")]
		public Ladder CurrentLadder
		{
			[Token(Token = "0x6002594")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002595")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x0000C528 File Offset: 0x0000A728
		[Token(Token = "0x170006A0")]
		public bool IsOnLadder
		{
			[Token(Token = "0x6002596")]
			[Address(RVA = "0x6B6E80", Offset = "0x6B6080", VA = "0x1806B6E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x0000C540 File Offset: 0x0000A740
		[Token(Token = "0x170006A1")]
		public float MoveSpeedMultiplier
		{
			[Token(Token = "0x6002597")]
			[Address(RVA = "0x6B6ED0", Offset = "0x6B60D0", VA = "0x1806B6ED0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x6B2070", Offset = "0x6B1270", VA = "0x1806B2070", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x6B53D0", Offset = "0x6B45D0", VA = "0x1806B53D0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259A")]
		[Address(RVA = "0x6B64C0", Offset = "0x6B56C0", VA = "0x1806B64C0")]
		private void Update()
		{
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x6B28C0", Offset = "0x6B1AC0", VA = "0x1806B28C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259C")]
		[Address(RVA = "0x6B3580", Offset = "0x6B2780", VA = "0x1806B3580")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259D")]
		[Address(RVA = "0x6B38E0", Offset = "0x6B2AE0", VA = "0x1806B38E0")]
		private void Move()
		{
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x6B2440", Offset = "0x6B1640", VA = "0x1806B2440")]
		private void ClampMovement()
		{
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0000C558 File Offset: 0x0000A758
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x6B2990", Offset = "0x6B1B90", VA = "0x1806B2990")]
		private float GetSurfaceAngle()
		{
			return 0f;
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0000C570 File Offset: 0x0000A770
		[Token(Token = "0x60025A0")]
		[Address(RVA = "0x6B2930", Offset = "0x6B1B30", VA = "0x1806B2930")]
		private bool GetIsGrounded()
		{
			return default(bool);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x6B5690", Offset = "0x6B4890", VA = "0x1806B5690")]
		public void Teleport(Vector3 position, bool alignFeetToPosition = false)
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x6B5280", Offset = "0x6B4480", VA = "0x1806B5280")]
		public void SetResidualVelocity(Vector3 dir, float force, float time)
		{
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A3")]
		[Address(RVA = "0x6B67B0", Offset = "0x6B59B0", VA = "0x1806B67B0")]
		public void WarpToNavMesh(bool clearVelocity = false)
		{
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x6B5C80", Offset = "0x6B4E80", VA = "0x1806B5C80")]
		private void UpdateHorizontalAxis()
		{
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x6B62D0", Offset = "0x6B54D0", VA = "0x1806B62D0")]
		private void UpdateVerticalAxis()
		{
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x6B2B70", Offset = "0x6B1D70", VA = "0x1806B2B70")]
		public void Jump()
		{
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x6B5010", Offset = "0x6B4210", VA = "0x1806B5010")]
		public void SetCrouched(bool c)
		{
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x6B5900", Offset = "0x6B4B00", VA = "0x1806B5900")]
		private void TryToggleCrouch()
		{
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0000C588 File Offset: 0x0000A788
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x6B20D0", Offset = "0x6B12D0", VA = "0x1806B20D0")]
		private bool CanStand()
		{
			return default(bool);
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AA")]
		[Address(RVA = "0x6B5AA0", Offset = "0x6B4CA0", VA = "0x1806B5AA0")]
		private void UpdateCrouchVignetteEffect()
		{
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AB")]
		[Address(RVA = "0x6B6190", Offset = "0x6B5390", VA = "0x1806B6190")]
		private void UpdatePlayerHeight()
		{
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AC")]
		[Address(RVA = "0x6B36A0", Offset = "0x6B28A0", VA = "0x1806B36A0")]
		public void LerpPlayerRotation(Quaternion rotation, float lerpTime)
		{
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x6B3610", Offset = "0x6B2810", VA = "0x1806B3610")]
		private IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime)
		{
			return null;
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AE")]
		[Address(RVA = "0x6B5150", Offset = "0x6B4350", VA = "0x1806B5150")]
		public void SetPlayerRotation(Quaternion rotation)
		{
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AF")]
		[Address(RVA = "0x6B2840", Offset = "0x6B1A40", VA = "0x1806B2840")]
		private void EnterVehicle(LandVehicle vehicle)
		{
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B0")]
		[Address(RVA = "0x6B2880", Offset = "0x6B1A80", VA = "0x1806B2880")]
		private void ExitVehicle(LandVehicle veh, Transform exitPoint)
		{
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B1")]
		[Address(RVA = "0x6B4DA0", Offset = "0x6B3FA0", VA = "0x1806B4DA0")]
		public void RegisterMovementEvent(int threshold, Action action)
		{
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B2")]
		[Address(RVA = "0x6B2550", Offset = "0x6B1750", VA = "0x1806B2550")]
		public void DeregisterMovementEvent(Action action)
		{
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B3")]
		[Address(RVA = "0x6B5E70", Offset = "0x6B5070", VA = "0x1806B5E70")]
		private void UpdateMovementEvents()
		{
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B4")]
		[Address(RVA = "0x6B2420", Offset = "0x6B1620", VA = "0x1806B2420")]
		public void ChangeStamina(float change, bool notify = true)
		{
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B5")]
		[Address(RVA = "0x6B5300", Offset = "0x6B4500", VA = "0x1806B5300")]
		public void SetStamina(float value, bool notify = true)
		{
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B6")]
		[Address(RVA = "0x6B1FE0", Offset = "0x6B11E0", VA = "0x1806B1FE0")]
		public void AddSprintBlocker(string tag)
		{
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B7")]
		[Address(RVA = "0x6B4F80", Offset = "0x6B4180", VA = "0x1806B4F80")]
		public void RemoveSprintBlocker(string tag)
		{
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B8")]
		[Address(RVA = "0x6B3770", Offset = "0x6B2970", VA = "0x1806B3770")]
		public void MountLadder(Ladder ladder)
		{
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B9")]
		[Address(RVA = "0x6B2750", Offset = "0x6B1950", VA = "0x1806B2750")]
		public void DismountLadder()
		{
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BA")]
		[Address(RVA = "0x6B2BF0", Offset = "0x6B1DF0", VA = "0x1806B2BF0")]
		private void LadderMove()
		{
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BB")]
		[Address(RVA = "0x6B4CD0", Offset = "0x6B3ED0", VA = "0x1806B4CD0")]
		private void PlayLadderClimbSound()
		{
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x6B6B80", Offset = "0x6B5D80", VA = "0x1806B6B80")]
		public PlayerMovement()
		{
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x6B5950", Offset = "0x6B4B50", VA = "0x1806B5950")]
		[CompilerGenerated]
		private IEnumerator <Jump>g__JumpRoutine|142_0()
		{
			return null;
		}

		// Token: 0x04001D20 RID: 7456
		[Token(Token = "0x4001D20")]
		public const float DevSprintMultiplier = 1f;

		// Token: 0x04001D21 RID: 7457
		[Token(Token = "0x4001D21")]
		public const float WalkSpeed = 3.25f;

		// Token: 0x04001D22 RID: 7458
		[Token(Token = "0x4001D22")]
		[FieldOffset(Offset = "0x0")]
		public static float StaticMoveSpeedMultiplier;

		// Token: 0x04001D23 RID: 7459
		[Token(Token = "0x4001D23")]
		public const float InputSensitivity = 7f;

		// Token: 0x04001D24 RID: 7460
		[Token(Token = "0x4001D24")]
		public const float InputDeadZone = 0.001f;

		// Token: 0x04001D25 RID: 7461
		[Token(Token = "0x4001D25")]
		public const float SlipperyMovementMultiplier = 0.98f;

		// Token: 0x04001D26 RID: 7462
		[Token(Token = "0x4001D26")]
		public const float GroundedThreshold = 0.05f;

		// Token: 0x04001D27 RID: 7463
		[Token(Token = "0x4001D27")]
		public const float SlopeThreshold = 5f;

		// Token: 0x04001D28 RID: 7464
		[Token(Token = "0x4001D28")]
		public const float SlopeForce = 1f;

		// Token: 0x04001D29 RID: 7465
		[Token(Token = "0x4001D29")]
		public const float SlopeForceRayLength = 1.5f;

		// Token: 0x04001D2A RID: 7466
		[Token(Token = "0x4001D2A")]
		public const float ControllerRadius = 0.35f;

		// Token: 0x04001D2B RID: 7467
		[Token(Token = "0x4001D2B")]
		public const float DefaultCharacterControllerHeight = 1.85f;

		// Token: 0x04001D2C RID: 7468
		[Token(Token = "0x4001D2C")]
		public const float CrouchHeightMultiplier = 0.65f;

		// Token: 0x04001D2D RID: 7469
		[Token(Token = "0x4001D2D")]
		public const float CrouchTime = 0.2f;

		// Token: 0x04001D2E RID: 7470
		[Token(Token = "0x4001D2E")]
		public const float CrouchSpeedMultipler = 0.6f;

		// Token: 0x04001D2F RID: 7471
		[Token(Token = "0x4001D2F")]
		public const float CrouchedVigIntensity = 0.35f;

		// Token: 0x04001D30 RID: 7472
		[Token(Token = "0x4001D30")]
		public const float CrouchedVigSmoothness = 0.7f;

		// Token: 0x04001D31 RID: 7473
		[Token(Token = "0x4001D31")]
		public const bool SprintingRequiresStamina = false;

		// Token: 0x04001D32 RID: 7474
		[Token(Token = "0x4001D32")]
		public const float SprintChangeRate = 4f;

		// Token: 0x04001D33 RID: 7475
		[Token(Token = "0x4001D33")]
		public const float SprintMultiplier = 1.9f;

		// Token: 0x04001D34 RID: 7476
		[Token(Token = "0x4001D34")]
		public const float StaminaDrainRate = 12.5f;

		// Token: 0x04001D35 RID: 7477
		[Token(Token = "0x4001D35")]
		public const float StaminaRestoreRate = 25f;

		// Token: 0x04001D36 RID: 7478
		[Token(Token = "0x4001D36")]
		public const float StaminaRestoreDelay = 1f;

		// Token: 0x04001D37 RID: 7479
		[Token(Token = "0x4001D37")]
		[FieldOffset(Offset = "0x4")]
		public static float StaminaReserveMax;

		// Token: 0x04001D38 RID: 7480
		[Token(Token = "0x4001D38")]
		public const float JumpForce = 5.25f;

		// Token: 0x04001D39 RID: 7481
		[Token(Token = "0x4001D39")]
		[FieldOffset(Offset = "0x8")]
		public static float JumpMultiplier;

		// Token: 0x04001D3A RID: 7482
		[Token(Token = "0x4001D3A")]
		[FieldOffset(Offset = "0xC")]
		public static float GravityMultiplier;

		// Token: 0x04001D3B RID: 7483
		[Token(Token = "0x4001D3B")]
		public const float BaseGravityMultiplier = 1.4f;

		// Token: 0x04001D3C RID: 7484
		[Token(Token = "0x4001D3C")]
		public const float VerticalLadderSpeedMultiplier = 1.2f;

		// Token: 0x04001D3D RID: 7485
		[Token(Token = "0x4001D3D")]
		public const float LateralLadderSpeedMultiplier = 0.5f;

		// Token: 0x04001D3E RID: 7486
		[Token(Token = "0x4001D3E")]
		public const float LadderTopBuffer = 0.15f;

		// Token: 0x04001D3F RID: 7487
		[Token(Token = "0x4001D3F")]
		public const float LadderPitchAdjustment = 60f;

		// Token: 0x04001D40 RID: 7488
		[Token(Token = "0x4001D40")]
		public const float DismountForce = 7f;

		// Token: 0x04001D41 RID: 7489
		[Token(Token = "0x4001D41")]
		public const float DismountForceDuration = 0.5f;

		// Token: 0x04001D42 RID: 7490
		[Token(Token = "0x4001D42")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Player Player;

		// Token: 0x04001D43 RID: 7491
		[Token(Token = "0x4001D43")]
		[FieldOffset(Offset = "0x28")]
		public CharacterController Controller;

		// Token: 0x04001D44 RID: 7492
		[Token(Token = "0x4001D44")]
		[FieldOffset(Offset = "0x30")]
		[Header("Jump/fall settings")]
		[FormerlySerializedAs("groundDetectionMask")]
		public LayerMask GroundDetectionMask;

		// Token: 0x04001D54 RID: 7508
		[Token(Token = "0x4001D54")]
		[FieldOffset(Offset = "0x68")]
		public readonly FloatStack MoveSpeedMultiplierStack;

		// Token: 0x04001D55 RID: 7509
		[Token(Token = "0x4001D55")]
		[FieldOffset(Offset = "0x70")]
		public Action<float> onStaminaReserveChanged;

		// Token: 0x04001D56 RID: 7510
		[Token(Token = "0x4001D56")]
		[FieldOffset(Offset = "0x78")]
		public Action onJump;

		// Token: 0x04001D57 RID: 7511
		[Token(Token = "0x4001D57")]
		[FieldOffset(Offset = "0x80")]
		public Action onLand;

		// Token: 0x04001D58 RID: 7512
		[Token(Token = "0x4001D58")]
		[FieldOffset(Offset = "0x88")]
		public Action onCrouch;

		// Token: 0x04001D59 RID: 7513
		[Token(Token = "0x4001D59")]
		[FieldOffset(Offset = "0x90")]
		public Action onUncrouch;

		// Token: 0x04001D5A RID: 7514
		[Token(Token = "0x4001D5A")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 movement;

		// Token: 0x04001D5B RID: 7515
		[Token(Token = "0x4001D5B")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 lastFrameMovement;

		// Token: 0x04001D5C RID: 7516
		[Token(Token = "0x4001D5C")]
		[FieldOffset(Offset = "0xB0")]
		private float movementY;

		// Token: 0x04001D5D RID: 7517
		[Token(Token = "0x4001D5D")]
		[FieldOffset(Offset = "0xB4")]
		private float timeOnLadderDismount;

		// Token: 0x04001D5E RID: 7518
		[Token(Token = "0x4001D5E")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 ladderDismountDir;

		// Token: 0x04001D5F RID: 7519
		[Token(Token = "0x4001D5F")]
		[FieldOffset(Offset = "0xC4")]
		private float horizontalAxis;

		// Token: 0x04001D60 RID: 7520
		[Token(Token = "0x4001D60")]
		[FieldOffset(Offset = "0xC8")]
		private float verticalAxis;

		// Token: 0x04001D61 RID: 7521
		[Token(Token = "0x4001D61")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<int, MotionEvent> movementEvents;

		// Token: 0x04001D62 RID: 7522
		[Token(Token = "0x4001D62")]
		[FieldOffset(Offset = "0xD8")]
		private float timeSinceStaminaDrain;

		// Token: 0x04001D63 RID: 7523
		[Token(Token = "0x4001D63")]
		[FieldOffset(Offset = "0xDC")]
		private bool sprintActive;

		// Token: 0x04001D64 RID: 7524
		[Token(Token = "0x4001D64")]
		[FieldOffset(Offset = "0xDD")]
		private bool sprintReleased;

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0xE0")]
		private List<string> sprintBlockers;

		// Token: 0x04001D66 RID: 7526
		[Token(Token = "0x4001D66")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 residualVelocityDirection;

		// Token: 0x04001D67 RID: 7527
		[Token(Token = "0x4001D67")]
		[FieldOffset(Offset = "0xF4")]
		private float residualVelocityForce;

		// Token: 0x04001D68 RID: 7528
		[Token(Token = "0x4001D68")]
		[FieldOffset(Offset = "0xF8")]
		private float residualVelocityDuration;

		// Token: 0x04001D69 RID: 7529
		[Token(Token = "0x4001D69")]
		[FieldOffset(Offset = "0xFC")]
		private float residualVelocityTimeRemaining;

		// Token: 0x04001D6A RID: 7530
		[Token(Token = "0x4001D6A")]
		[FieldOffset(Offset = "0x100")]
		private bool teleport;

		// Token: 0x04001D6B RID: 7531
		[Token(Token = "0x4001D6B")]
		[FieldOffset(Offset = "0x104")]
		private Vector3 teleportPosition;

		// Token: 0x04001D6C RID: 7532
		[Token(Token = "0x4001D6C")]
		[FieldOffset(Offset = "0x110")]
		private float playerLadderYPosOnLastClimbSound;

		// Token: 0x04001D6D RID: 7533
		[Token(Token = "0x4001D6D")]
		[FieldOffset(Offset = "0x118")]
		private Coroutine playerRotCoroutine;
	}
}
