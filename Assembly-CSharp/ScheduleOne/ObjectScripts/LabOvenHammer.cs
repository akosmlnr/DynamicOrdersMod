using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009AA RID: 2474
	[Token(Token = "0x20009AA")]
	public class LabOvenHammer : MonoBehaviour
	{
		// Token: 0x060044A0 RID: 17568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A0")]
		[Address(RVA = "0x8A1520", Offset = "0x8A0720", VA = "0x1808A1520")]
		private void Start()
		{
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A1")]
		[Address(RVA = "0x8A1580", Offset = "0x8A0780", VA = "0x1808A1580")]
		private void Update()
		{
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A2")]
		[Address(RVA = "0x8A14C0", Offset = "0x8A06C0", VA = "0x1808A14C0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A3")]
		[Address(RVA = "0x8A16D0", Offset = "0x8A08D0", VA = "0x1808A16D0")]
		public LabOvenHammer()
		{
		}

		// Token: 0x04003145 RID: 12613
		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0x20")]
		public Draggable Draggable;

		// Token: 0x04003146 RID: 12614
		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x28")]
		public DraggableConstraint Constraint;

		// Token: 0x04003147 RID: 12615
		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x30")]
		public RotateRigidbodyToTarget Rotator;

		// Token: 0x04003148 RID: 12616
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x38")]
		public Transform CoM;

		// Token: 0x04003149 RID: 12617
		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x40")]
		public Transform ImpactPoint;

		// Token: 0x0400314A RID: 12618
		[Token(Token = "0x400314A")]
		[FieldOffset(Offset = "0x48")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x0400314B RID: 12619
		[Token(Token = "0x400314B")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public float MinHeight;

		// Token: 0x0400314C RID: 12620
		[Token(Token = "0x400314C")]
		[FieldOffset(Offset = "0x54")]
		public float MaxHeight;

		// Token: 0x0400314D RID: 12621
		[Token(Token = "0x400314D")]
		[FieldOffset(Offset = "0x58")]
		public float MinAngle;

		// Token: 0x0400314E RID: 12622
		[Token(Token = "0x400314E")]
		[FieldOffset(Offset = "0x5C")]
		public float MaxAngle;

		// Token: 0x0400314F RID: 12623
		[Token(Token = "0x400314F")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent<Collision> onCollision;
	}
}
