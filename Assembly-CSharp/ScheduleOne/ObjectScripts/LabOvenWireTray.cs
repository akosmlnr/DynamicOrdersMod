using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009AB RID: 2475
	[Token(Token = "0x20009AB")]
	public class LabOvenWireTray : MonoBehaviour
	{
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x00013068 File Offset: 0x00011268
		// (set) Token: 0x060044A5 RID: 17573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABA")]
		public bool Interactable
		{
			[Token(Token = "0x60044A4")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60044A5")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x00013080 File Offset: 0x00011280
		// (set) Token: 0x060044A7 RID: 17575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABB")]
		public float TargetPosition
		{
			[Token(Token = "0x60044A6")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60044A7")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x00013098 File Offset: 0x00011298
		// (set) Token: 0x060044A9 RID: 17577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABC")]
		public float ActualPosition
		{
			[Token(Token = "0x60044A8")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60044A9")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AA")]
		[Address(RVA = "0x8A1EB0", Offset = "0x8A10B0", VA = "0x1808A1EB0")]
		private void Start()
		{
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AB")]
		[Address(RVA = "0x8A1B20", Offset = "0x8A0D20", VA = "0x1808A1B20")]
		private void LateUpdate()
		{
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AC")]
		[Address(RVA = "0x8A1CB0", Offset = "0x8A0EB0", VA = "0x1808A1CB0")]
		private void Move()
		{
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AD")]
		[Address(RVA = "0x8A16F0", Offset = "0x8A08F0", VA = "0x1808A16F0")]
		private void ClampAngle()
		{
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AE")]
		[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
		public void SetInteractable(bool interactable)
		{
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044AF")]
		[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
		public void SetPosition(float position)
		{
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044B0")]
		[Address(RVA = "0x8A1840", Offset = "0x8A0A40", VA = "0x1808A1840")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x000130B0 File Offset: 0x000112B0
		[Token(Token = "0x60044B1")]
		[Address(RVA = "0x8A1850", Offset = "0x8A0A50", VA = "0x1808A1850")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044B2")]
		[Address(RVA = "0x8A1830", Offset = "0x8A0A30", VA = "0x1808A1830")]
		public void ClickEnd()
		{
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044B3")]
		[Address(RVA = "0x8A1EC0", Offset = "0x8A10C0", VA = "0x1808A1EC0")]
		public LabOvenWireTray()
		{
		}

		// Token: 0x04003150 RID: 12624
		[Token(Token = "0x4003150")]
		public const float HIT_OFFSET_MAX = 0.24f;

		// Token: 0x04003151 RID: 12625
		[Token(Token = "0x4003151")]
		public const float HIT_OFFSET_MIN = -0.25f;

		// Token: 0x04003155 RID: 12629
		[Token(Token = "0x4003155")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform Tray;

		// Token: 0x04003156 RID: 12630
		[Token(Token = "0x4003156")]
		[FieldOffset(Offset = "0x38")]
		public Transform PlaneNormal;

		// Token: 0x04003157 RID: 12631
		[Token(Token = "0x4003157")]
		[FieldOffset(Offset = "0x40")]
		public Transform ClosedPosition;

		// Token: 0x04003158 RID: 12632
		[Token(Token = "0x4003158")]
		[FieldOffset(Offset = "0x48")]
		public Transform OpenPosition;

		// Token: 0x04003159 RID: 12633
		[Token(Token = "0x4003159")]
		[FieldOffset(Offset = "0x50")]
		public LabOvenDoor OvenDoor;

		// Token: 0x0400315A RID: 12634
		[Token(Token = "0x400315A")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public float MoveSpeed;

		// Token: 0x0400315B RID: 12635
		[Token(Token = "0x400315B")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve DoorClampCurve;

		// Token: 0x0400315C RID: 12636
		[Token(Token = "0x400315C")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 clickOffset;

		// Token: 0x0400315D RID: 12637
		[Token(Token = "0x400315D")]
		[FieldOffset(Offset = "0x74")]
		private bool isMoving;
	}
}
