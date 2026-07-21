using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	public class DraggableConstraint : MonoBehaviour
	{
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x17000460")]
		private Vector3 RelativePos
		{
			[Token(Token = "0x6001685")]
			[Address(RVA = "0x59A5C0", Offset = "0x5997C0", VA = "0x18059A5C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x59A370", Offset = "0x599570", VA = "0x18059A370")]
		private void Start()
		{
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x59A200", Offset = "0x599400", VA = "0x18059A200")]
		public void SetContainer(Transform container)
		{
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x5996E0", Offset = "0x5988E0", VA = "0x1805996E0", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x5996F0", Offset = "0x5988F0", VA = "0x1805996F0", Slot = "5")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168A")]
		[Address(RVA = "0x59A060", Offset = "0x599260", VA = "0x18059A060")]
		private void ProportionalClamp()
		{
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x5998C0", Offset = "0x598AC0", VA = "0x1805998C0")]
		private void LockRotationX()
		{
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x599C90", Offset = "0x598E90", VA = "0x180599C90")]
		private void LockRotationY()
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x599280", Offset = "0x598480", VA = "0x180599280")]
		private void AlignToContainerPlane()
		{
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x599520", Offset = "0x598720", VA = "0x180599520")]
		private void ClampUpRot()
		{
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x59A5B0", Offset = "0x5997B0", VA = "0x18059A5B0")]
		public DraggableConstraint()
		{
		}

		// Token: 0x040013D1 RID: 5073
		[Token(Token = "0x40013D1")]
		[FieldOffset(Offset = "0x20")]
		public Transform Container;

		// Token: 0x040013D2 RID: 5074
		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody Anchor;

		// Token: 0x040013D3 RID: 5075
		[Token(Token = "0x40013D3")]
		[FieldOffset(Offset = "0x30")]
		public bool ProportionalZClamp;

		// Token: 0x040013D4 RID: 5076
		[Token(Token = "0x40013D4")]
		[FieldOffset(Offset = "0x31")]
		public bool AlignUpToContainerPlane;

		// Token: 0x040013D5 RID: 5077
		[Token(Token = "0x40013D5")]
		[FieldOffset(Offset = "0x32")]
		[Header("Up Direction Clamping")]
		public bool ClampUpDirection;

		// Token: 0x040013D6 RID: 5078
		[Token(Token = "0x40013D6")]
		[FieldOffset(Offset = "0x34")]
		public float UpDirectionMaxDifference;

		// Token: 0x040013D7 RID: 5079
		[Token(Token = "0x40013D7")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 startLocalPos;

		// Token: 0x040013D8 RID: 5080
		[Token(Token = "0x40013D8")]
		[FieldOffset(Offset = "0x48")]
		private Draggable draggable;

		// Token: 0x040013D9 RID: 5081
		[Token(Token = "0x40013D9")]
		[FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;
	}
}
