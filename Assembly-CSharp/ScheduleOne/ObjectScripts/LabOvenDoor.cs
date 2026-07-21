using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009A9 RID: 2473
	[Token(Token = "0x20009A9")]
	public class LabOvenDoor : MonoBehaviour
	{
		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x00013008 File Offset: 0x00011208
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB7")]
		public bool Interactable
		{
			[Token(Token = "0x6004491")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004492")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x00013020 File Offset: 0x00011220
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB8")]
		public float TargetPosition
		{
			[Token(Token = "0x6004493")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004494")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x00013038 File Offset: 0x00011238
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB9")]
		public float ActualPosition
		{
			[Token(Token = "0x6004495")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004496")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004497")]
		[Address(RVA = "0x8A1330", Offset = "0x8A0530", VA = "0x1808A1330")]
		private void Start()
		{
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004498")]
		[Address(RVA = "0x8A0EE0", Offset = "0x8A00E0", VA = "0x1808A0EE0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004499")]
		[Address(RVA = "0x8A1130", Offset = "0x8A0330", VA = "0x1808A1130")]
		private void Move()
		{
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x8A0030", Offset = "0x89F230", VA = "0x1808A0030")]
		public void SetInteractable(bool interactable)
		{
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600449B")]
		[Address(RVA = "0x8A12A0", Offset = "0x8A04A0", VA = "0x1808A12A0")]
		public void SetPosition(float newPosition)
		{
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600449C")]
		[Address(RVA = "0x8A0B70", Offset = "0x89FD70", VA = "0x1808A0B70")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x600449D")]
		[Address(RVA = "0x8A0C10", Offset = "0x89FE10", VA = "0x1808A0C10")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600449E")]
		[Address(RVA = "0x8A0B60", Offset = "0x89FD60", VA = "0x1808A0B60")]
		public void ClickEnd()
		{
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600449F")]
		[Address(RVA = "0x8A1460", Offset = "0x8A0660", VA = "0x1808A1460")]
		public LabOvenDoor()
		{
		}

		// Token: 0x04003134 RID: 12596
		[Token(Token = "0x4003134")]
		public const float HIT_OFFSET_MAX = 0.24f;

		// Token: 0x04003135 RID: 12597
		[Token(Token = "0x4003135")]
		public const float HIT_OFFSET_MIN = -0.25f;

		// Token: 0x04003136 RID: 12598
		[Token(Token = "0x4003136")]
		public const float DOOR_ANGLE_CLOSED = 90f;

		// Token: 0x04003137 RID: 12599
		[Token(Token = "0x4003137")]
		public const float DOOR_ANGLE_OPEN = 10f;

		// Token: 0x0400313B RID: 12603
		[Token(Token = "0x400313B")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Clickable HandleClickable;

		// Token: 0x0400313C RID: 12604
		[Token(Token = "0x400313C")]
		[FieldOffset(Offset = "0x38")]
		public Transform Door;

		// Token: 0x0400313D RID: 12605
		[Token(Token = "0x400313D")]
		[FieldOffset(Offset = "0x40")]
		public Transform PlaneNormal;

		// Token: 0x0400313E RID: 12606
		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve HitMapCurve;

		// Token: 0x0400313F RID: 12607
		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0x50")]
		[Header("Sounds")]
		public AudioSourceController OpenSound;

		// Token: 0x04003140 RID: 12608
		[Token(Token = "0x4003140")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController CloseSound;

		// Token: 0x04003141 RID: 12609
		[Token(Token = "0x4003141")]
		[FieldOffset(Offset = "0x60")]
		public AudioSourceController ShutSound;

		// Token: 0x04003142 RID: 12610
		[Token(Token = "0x4003142")]
		[FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		public float DoorMoveSpeed;

		// Token: 0x04003143 RID: 12611
		[Token(Token = "0x4003143")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 clickOffset;

		// Token: 0x04003144 RID: 12612
		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0x78")]
		private bool isMoving;
	}
}
