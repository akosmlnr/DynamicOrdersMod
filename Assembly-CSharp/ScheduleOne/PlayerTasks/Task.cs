using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000387 RID: 903
	[Token(Token = "0x2000387")]
	public class Task
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000465")]
		public virtual string TaskName
		{
			[Token(Token = "0x60016B7")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60016B8")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000466")]
		public string CurrentInstruction
		{
			[Token(Token = "0x60016B9")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x000097B0 File Offset: 0x000079B0
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000467")]
		public bool TaskActive
		{
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x5C7B80", Offset = "0x5C6D80", VA = "0x1805C7B80")]
		public Task()
		{
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x5C68F0", Offset = "0x5C5AF0", VA = "0x1805C68F0", Slot = "6")]
		public virtual void StopTask()
		{
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x5C6B40", Offset = "0x5C5D40", VA = "0x1805C6B40", Slot = "7")]
		public virtual void Success()
		{
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C0")]
		[Address(RVA = "0x5C5390", Offset = "0x5C4590", VA = "0x1805C5390", Slot = "8")]
		public virtual void Fail()
		{
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x5C77F0", Offset = "0x5C69F0", VA = "0x1805C77F0", Slot = "9")]
		public virtual void Update()
		{
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x5C6C10", Offset = "0x5C5E10", VA = "0x1805C6C10", Slot = "10")]
		protected virtual void UpdateCursor()
		{
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x5C63D0", Offset = "0x5C55D0", VA = "0x1805C63D0", Slot = "11")]
		public virtual void LateUpdate()
		{
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x5C6030", Offset = "0x5C5230", VA = "0x1805C6030")]
		private Vector3 GetMultiDragOrigin()
		{
			return default(Vector3);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x5C53E0", Offset = "0x5C45E0", VA = "0x1805C53E0", Slot = "12")]
		public virtual void FixedUpdate()
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x5C5C10", Offset = "0x5C4E10", VA = "0x1805C5C10")]
		public void ForceStartClick(Clickable _clickable)
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x5C5B60", Offset = "0x5C4D60", VA = "0x1805C5B60")]
		public void ForceEndClick(Clickable _clickable)
		{
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x5C6DC0", Offset = "0x5C5FC0", VA = "0x1805C6DC0")]
		private void UpdateDraggablePhysics()
		{
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x5C5D40", Offset = "0x5C4F40", VA = "0x1805C5D40", Slot = "13")]
		protected virtual Clickable GetClickable(out RaycastHit hit)
		{
			return null;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x5C5350", Offset = "0x5C4550", VA = "0x1805C5350")]
		protected void EnableMultiDragging(Transform projectionPlane, float radius = 0.08f)
		{
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x5C5330", Offset = "0x5C4530", VA = "0x1805C5330")]
		protected void DisableMultiDragging()
		{
		}

		// Token: 0x04001405 RID: 5125
		[Token(Token = "0x4001405")]
		public const float ClickDetectionRange = 3f;

		// Token: 0x04001406 RID: 5126
		[Token(Token = "0x4001406")]
		[FieldOffset(Offset = "0x10")]
		public float ClickDetectionRadius;

		// Token: 0x04001407 RID: 5127
		[Token(Token = "0x4001407")]
		[FieldOffset(Offset = "0x14")]
		protected float MultiGrabRadius;

		// Token: 0x04001408 RID: 5128
		[Token(Token = "0x4001408")]
		public const float MultiGrabForceMultiplier = 1.25f;

		// Token: 0x0400140C RID: 5132
		[Token(Token = "0x400140C")]
		[FieldOffset(Offset = "0x29")]
		public bool ClickDetectionEnabled;

		// Token: 0x0400140D RID: 5133
		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x2C")]
		public Task.EOutcome Outcome;

		// Token: 0x0400140E RID: 5134
		[Token(Token = "0x400140E")]
		[FieldOffset(Offset = "0x30")]
		public Action onTaskSuccess;

		// Token: 0x0400140F RID: 5135
		[Token(Token = "0x400140F")]
		[FieldOffset(Offset = "0x38")]
		public Action onTaskFail;

		// Token: 0x04001410 RID: 5136
		[Token(Token = "0x4001410")]
		[FieldOffset(Offset = "0x40")]
		public Action onTaskStop;

		// Token: 0x04001411 RID: 5137
		[Token(Token = "0x4001411")]
		[FieldOffset(Offset = "0x48")]
		protected Clickable clickable;

		// Token: 0x04001412 RID: 5138
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0x50")]
		protected Draggable draggable;

		// Token: 0x04001413 RID: 5139
		[Token(Token = "0x4001413")]
		[FieldOffset(Offset = "0x58")]
		protected DraggableConstraint constraint;

		// Token: 0x04001414 RID: 5140
		[Token(Token = "0x4001414")]
		[FieldOffset(Offset = "0x60")]
		protected float hitDistance;

		// Token: 0x04001415 RID: 5141
		[Token(Token = "0x4001415")]
		[FieldOffset(Offset = "0x64")]
		protected Vector3 relativeHitOffset;

		// Token: 0x04001416 RID: 5142
		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0x70")]
		private bool multiDraggingEnabled;

		// Token: 0x04001417 RID: 5143
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0x78")]
		private Transform multiGrabProjectionPlane;

		// Token: 0x04001418 RID: 5144
		[Token(Token = "0x4001418")]
		[FieldOffset(Offset = "0x80")]
		private List<Draggable> multiDragTargets;

		// Token: 0x04001419 RID: 5145
		[Token(Token = "0x4001419")]
		[FieldOffset(Offset = "0x88")]
		private bool isMultiDragging;

		// Token: 0x0400141A RID: 5146
		[Token(Token = "0x400141A")]
		[FieldOffset(Offset = "0x90")]
		private List<Clickable> forcedClickables;

		// Token: 0x0400141B RID: 5147
		[Token(Token = "0x400141B")]
		[FieldOffset(Offset = "0x98")]
		protected LayerMask clickablesLayerMask;

		// Token: 0x02000388 RID: 904
		[Token(Token = "0x2000388")]
		public enum EOutcome
		{
			// Token: 0x0400141D RID: 5149
			[Token(Token = "0x400141D")]
			Cancelled,
			// Token: 0x0400141E RID: 5150
			[Token(Token = "0x400141E")]
			Success,
			// Token: 0x0400141F RID: 5151
			[Token(Token = "0x400141F")]
			Fail
		}
	}
}
