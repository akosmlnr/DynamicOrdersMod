using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Interaction
{
	// Token: 0x02000604 RID: 1540
	[Token(Token = "0x2000604")]
	public class InteractableObject : MonoBehaviour
	{
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x0000C660 File Offset: 0x0000A860
		[Token(Token = "0x170006AC")]
		public InteractableObject.EInteractionType _interactionType
		{
			[Token(Token = "0x6002619")]
			[Address(RVA = "0x492960", Offset = "0x491B60", VA = "0x180492960")]
			get
			{
				return InteractableObject.EInteractionType.Key_Press;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x170006AD")]
		public InteractableObject.EInteractableState _interactionState
		{
			[Token(Token = "0x600261A")]
			[Address(RVA = "0x6A20F0", Offset = "0x6A12F0", VA = "0x1806A20F0")]
			get
			{
				return InteractableObject.EInteractableState.Default;
			}
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600261B")]
		[Address(RVA = "0x4929B0", Offset = "0x491BB0", VA = "0x1804929B0")]
		public void SetInteractionType(InteractableObject.EInteractionType type)
		{
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x6C1170", Offset = "0x6C0370", VA = "0x1806C1170")]
		public void SetInteractableState(InteractableObject.EInteractableState state)
		{
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600261D")]
		[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
		public void SetMessage(string _message)
		{
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600261E")]
		[Address(RVA = "0x6C1120", Offset = "0x6C0320", VA = "0x1806C1120", Slot = "4")]
		public virtual void Hovered()
		{
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600261F")]
		[Address(RVA = "0x6C1630", Offset = "0x6C0830", VA = "0x1806C1630", Slot = "5")]
		public virtual void StartInteract()
		{
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002620")]
		[Address(RVA = "0x6C1080", Offset = "0x6C0280", VA = "0x1806C1080", Slot = "6")]
		public virtual void EndInteract()
		{
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x6C1180", Offset = "0x6C0380", VA = "0x1806C1180", Slot = "7")]
		protected virtual void ShowMessage()
		{
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x6002622")]
		[Address(RVA = "0x6C0E10", Offset = "0x6C0010", VA = "0x1806C0E10")]
		public bool CheckAngleLimit(Vector3 interactionSource)
		{
			return default(bool);
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002623")]
		[Address(RVA = "0x6C0A10", Offset = "0x6BFC10", VA = "0x1806C0A10")]
		public InteractableObject()
		{
		}

		// Token: 0x04001DBE RID: 7614
		[Token(Token = "0x4001DBE")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[SerializeField]
		protected string message;

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected InteractableObject.EInteractionType interactionType;

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected InteractableObject.EInteractableState interactionState;

		// Token: 0x04001DC1 RID: 7617
		[Token(Token = "0x4001DC1")]
		[FieldOffset(Offset = "0x30")]
		public float MaxInteractionRange;

		// Token: 0x04001DC2 RID: 7618
		[Token(Token = "0x4001DC2")]
		[FieldOffset(Offset = "0x34")]
		public bool RequiresUniqueClick;

		// Token: 0x04001DC3 RID: 7619
		[Token(Token = "0x4001DC3")]
		[FieldOffset(Offset = "0x38")]
		public int Priority;

		// Token: 0x04001DC4 RID: 7620
		[Token(Token = "0x4001DC4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Collider displayLocationCollider;

		// Token: 0x04001DC5 RID: 7621
		[Token(Token = "0x4001DC5")]
		[FieldOffset(Offset = "0x48")]
		public Transform displayLocationPoint;

		// Token: 0x04001DC6 RID: 7622
		[Token(Token = "0x4001DC6")]
		[FieldOffset(Offset = "0x50")]
		[Header("Angle Limits")]
		public bool LimitInteractionAngle;

		// Token: 0x04001DC7 RID: 7623
		[Token(Token = "0x4001DC7")]
		[FieldOffset(Offset = "0x54")]
		public float AngleLimit;

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0x58")]
		[Header("Events")]
		public UnityEvent onHovered;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onInteractStart;

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onInteractEnd;

		// Token: 0x02000605 RID: 1541
		[Token(Token = "0x2000605")]
		public enum EInteractionType
		{
			// Token: 0x04001DCC RID: 7628
			[Token(Token = "0x4001DCC")]
			Key_Press,
			// Token: 0x04001DCD RID: 7629
			[Token(Token = "0x4001DCD")]
			LeftMouse_Click
		}

		// Token: 0x02000606 RID: 1542
		[Token(Token = "0x2000606")]
		public enum EInteractableState
		{
			// Token: 0x04001DCF RID: 7631
			[Token(Token = "0x4001DCF")]
			Default,
			// Token: 0x04001DD0 RID: 7632
			[Token(Token = "0x4001DD0")]
			Invalid,
			// Token: 0x04001DD1 RID: 7633
			[Token(Token = "0x4001DD1")]
			Disabled,
			// Token: 0x04001DD2 RID: 7634
			[Token(Token = "0x4001DD2")]
			Label
		}
	}
}
