using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	public class Draggable : Clickable
	{
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045E")]
		public Rigidbody Rb
		{
			[Token(Token = "0x6001678")]
			[Address(RVA = "0x4CB630", Offset = "0x4CA830", VA = "0x1804CB630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001679")]
			[Address(RVA = "0x59B0A0", Offset = "0x59A2A0", VA = "0x18059B0A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x000096A8 File Offset: 0x000078A8
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045F")]
		public override CursorManager.ECursorType HoveredCursor
		{
			[Token(Token = "0x600167A")]
			[Address(RVA = "0x4E0A00", Offset = "0x4DFC00", VA = "0x1804E0A00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return CursorManager.ECursorType.Default;
			}
			[Token(Token = "0x600167B")]
			[Address(RVA = "0x59B090", Offset = "0x59A290", VA = "0x18059B090", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x59A6B0", Offset = "0x5998B0", VA = "0x18059A6B0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x59A840", Offset = "0x599A40", VA = "0x18059A840", Slot = "9")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "10")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167F")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "11")]
		public virtual void PostFixedUpdate()
		{
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x59AC60", Offset = "0x599E60", VA = "0x18059AC60", Slot = "12")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x59AEB0", Offset = "0x59A0B0", VA = "0x18059AEB0", Slot = "13")]
		protected virtual void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x59AF10", Offset = "0x59A110", VA = "0x18059AF10", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x59A7A0", Offset = "0x5999A0", VA = "0x18059A7A0", Slot = "7")]
		public override void EndClick()
		{
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x59AFB0", Offset = "0x59A1B0", VA = "0x18059AFB0")]
		public Draggable()
		{
		}

		// Token: 0x040013B5 RID: 5045
		[Token(Token = "0x40013B5")]
		[FieldOffset(Offset = "0x50")]
		[Header("Drag Force")]
		public float DragForceMultiplier;

		// Token: 0x040013B6 RID: 5046
		[Token(Token = "0x40013B6")]
		[FieldOffset(Offset = "0x58")]
		public Transform DragForceOrigin;

		// Token: 0x040013B7 RID: 5047
		[Token(Token = "0x40013B7")]
		[FieldOffset(Offset = "0x60")]
		[Header("Rotation")]
		public bool RotationEnabled;

		// Token: 0x040013B8 RID: 5048
		[Token(Token = "0x40013B8")]
		[FieldOffset(Offset = "0x64")]
		public float TorqueMultiplier;

		// Token: 0x040013B9 RID: 5049
		[Token(Token = "0x40013B9")]
		[FieldOffset(Offset = "0x68")]
		public Draggable.ERotationAxis RotationAxis;

		// Token: 0x040013BA RID: 5050
		[Token(Token = "0x40013BA")]
		[FieldOffset(Offset = "0x6C")]
		[Header("Settings")]
		public Draggable.EDragProjectionMode DragProjectionMode;

		// Token: 0x040013BB RID: 5051
		[Token(Token = "0x40013BB")]
		[FieldOffset(Offset = "0x70")]
		public Transform CustomDragPlane;

		// Token: 0x040013BC RID: 5052
		[Token(Token = "0x40013BC")]
		[FieldOffset(Offset = "0x78")]
		public bool DisableGravityWhenDragged;

		// Token: 0x040013BD RID: 5053
		[Token(Token = "0x40013BD")]
		[FieldOffset(Offset = "0x7C")]
		public float NormalRBDrag;

		// Token: 0x040013BE RID: 5054
		[Token(Token = "0x40013BE")]
		[FieldOffset(Offset = "0x80")]
		public float HeldRBDrag;

		// Token: 0x040013BF RID: 5055
		[Token(Token = "0x40013BF")]
		[FieldOffset(Offset = "0x84")]
		public bool CanBeMultiDragged;

		// Token: 0x040013C2 RID: 5058
		[Token(Token = "0x40013C2")]
		[FieldOffset(Offset = "0x94")]
		[Header("Additional force")]
		public float idleUpForce;

		// Token: 0x040013C3 RID: 5059
		[Token(Token = "0x40013C3")]
		[FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool LocationRestrictionEnabled;

		// Token: 0x040013C4 RID: 5060
		[Token(Token = "0x40013C4")]
		[FieldOffset(Offset = "0x9C")]
		[HideInInspector]
		public Vector3 Origin;

		// Token: 0x040013C5 RID: 5061
		[Token(Token = "0x40013C5")]
		[FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public float MaxDistanceFromOrigin;

		// Token: 0x040013C6 RID: 5062
		[Token(Token = "0x40013C6")]
		[FieldOffset(Offset = "0xB0")]
		public UnityEvent<Collider> onTriggerExit;

		// Token: 0x040013C7 RID: 5063
		[Token(Token = "0x40013C7")]
		[FieldOffset(Offset = "0xB8")]
		protected DraggableConstraint constraint;

		// Token: 0x0200037F RID: 895
		[Token(Token = "0x200037F")]
		public enum EDragProjectionMode
		{
			// Token: 0x040013C9 RID: 5065
			[Token(Token = "0x40013C9")]
			CameraForward,
			// Token: 0x040013CA RID: 5066
			[Token(Token = "0x40013CA")]
			FlatCameraForward,
			// Token: 0x040013CB RID: 5067
			[Token(Token = "0x40013CB")]
			CustomPlane
		}

		// Token: 0x02000380 RID: 896
		[Token(Token = "0x2000380")]
		public enum ERotationAxis
		{
			// Token: 0x040013CD RID: 5069
			[Token(Token = "0x40013CD")]
			FlatCameraForward,
			// Token: 0x040013CE RID: 5070
			[Token(Token = "0x40013CE")]
			LocalX,
			// Token: 0x040013CF RID: 5071
			[Token(Token = "0x40013CF")]
			LocalY,
			// Token: 0x040013D0 RID: 5072
			[Token(Token = "0x40013D0")]
			LocalZ
		}
	}
}
