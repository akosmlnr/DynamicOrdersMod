using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dragging
{
	// Token: 0x020006CC RID: 1740
	[Token(Token = "0x20006CC")]
	[RequireComponent(typeof(InteractableObject))]
	[RequireComponent(typeof(Rigidbody))]
	public class Draggable : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x170007B4")]
		public bool IsBeingDragged
		{
			[Token(Token = "0x6002E08")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B5")]
		public Player CurrentDragger
		{
			[Token(Token = "0x6002E09")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E0A")]
			[Address(RVA = "0x74BBB0", Offset = "0x74ADB0", VA = "0x18074BBB0")]
			protected set
			{
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x0000E550 File Offset: 0x0000C750
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B6")]
		public Guid GUID
		{
			[Token(Token = "0x6002E0B")]
			[Address(RVA = "0x74BBA0", Offset = "0x74ADA0", VA = "0x18074BBA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6002E0C")]
			[Address(RVA = "0x74BC30", Offset = "0x74AE30", VA = "0x18074BC30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0D")]
		[Address(RVA = "0x74B760", Offset = "0x74A960", VA = "0x18074B760")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x0000E568 File Offset: 0x0000C768
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B7")]
		public Vector3 initialPosition
		{
			[Token(Token = "0x6002E0E")]
			[Address(RVA = "0x6B6EF0", Offset = "0x6B60F0", VA = "0x1806B6EF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6002E0F")]
			[Address(RVA = "0x74BC40", Offset = "0x74AE40", VA = "0x18074BC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E10")]
		[Address(RVA = "0x74AF60", Offset = "0x74A160", VA = "0x18074AF60", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E11")]
		[Address(RVA = "0x74B870", Offset = "0x74AA70", VA = "0x18074B870", Slot = "8")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E12")]
		[Address(RVA = "0x74B7B0", Offset = "0x74A9B0", VA = "0x18074B7B0", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E13")]
		[Address(RVA = "0x74B680", Offset = "0x74A880", VA = "0x18074B680")]
		protected void OnValidate()
		{
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E14")]
		[Address(RVA = "0x74B4C0", Offset = "0x74A6C0", VA = "0x18074B4C0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E15")]
		[Address(RVA = "0x74B9C0", Offset = "0x74ABC0", VA = "0x18074B9C0")]
		public void UpdateDraggable()
		{
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E16")]
		[Address(RVA = "0x74A940", Offset = "0x749B40", VA = "0x18074A940")]
		public void ApplyDragForces(Vector3 targetPosition)
		{
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x74B380", Offset = "0x74A580", VA = "0x18074B380", Slot = "9")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x74B430", Offset = "0x74A630", VA = "0x18074B430", Slot = "10")]
		protected virtual void Interacted()
		{
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x0000E580 File Offset: 0x0000C780
		[Token(Token = "0x6002E19")]
		[Address(RVA = "0x74B2A0", Offset = "0x74A4A0", VA = "0x18074B2A0")]
		private bool CanInteract()
		{
			return default(bool);
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1A")]
		[Address(RVA = "0x74B820", Offset = "0x74AA20", VA = "0x18074B820")]
		public void StartDragging(Player dragger)
		{
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1B")]
		[Address(RVA = "0x74B960", Offset = "0x74AB60", VA = "0x18074B960")]
		public void StopDragging()
		{
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1C")]
		[Address(RVA = "0x74BB30", Offset = "0x74AD30", VA = "0x18074BB30")]
		public Draggable()
		{
		}

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		public const float INITIAL_REPLICATION_DISTANCE = 1f;

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		public const float MAX_DRAG_START_RANGE = 2.5f;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		public const float MAX_TARGET_OFFSET = 1.5f;

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x20")]
		private bool isBeingDragged;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x28")]
		private Player currentDragger;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x40")]
		public string BakedGUID;

		// Token: 0x0400221E RID: 8734
		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Rigidbody Rigidbody;

		// Token: 0x0400221F RID: 8735
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x50")]
		public InteractableObject IntObj;

		// Token: 0x04002220 RID: 8736
		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x58")]
		public Transform DragOrigin;

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x60")]
		[Header("Settings")]
		public bool CreateCoM;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x64")]
		[Range(0.5f, 2f)]
		public float HoldDistanceMultiplier;

		// Token: 0x04002223 RID: 8739
		[Token(Token = "0x4002223")]
		[FieldOffset(Offset = "0x68")]
		[Range(0f, 5f)]
		public float DragForceMultiplier;

		// Token: 0x04002224 RID: 8740
		[Token(Token = "0x4002224")]
		[FieldOffset(Offset = "0x6C")]
		public Draggable.EInitialReplicationMode InitialReplicationMode;

		// Token: 0x04002225 RID: 8741
		[Token(Token = "0x4002225")]
		[FieldOffset(Offset = "0x70")]
		private float timeSinceLastDrag;

		// Token: 0x04002226 RID: 8742
		[Token(Token = "0x4002226")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onDragStart;

		// Token: 0x04002227 RID: 8743
		[Token(Token = "0x4002227")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onDragEnd;

		// Token: 0x04002228 RID: 8744
		[Token(Token = "0x4002228")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent onHovered;

		// Token: 0x04002229 RID: 8745
		[Token(Token = "0x4002229")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent onInteracted;

		// Token: 0x020006CD RID: 1741
		[Token(Token = "0x20006CD")]
		public enum EInitialReplicationMode
		{
			// Token: 0x0400222C RID: 8748
			[Token(Token = "0x400222C")]
			Off,
			// Token: 0x0400222D RID: 8749
			[Token(Token = "0x400222D")]
			OnlyIfMoved,
			// Token: 0x0400222E RID: 8750
			[Token(Token = "0x400222E")]
			Full
		}
	}
}
