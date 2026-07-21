using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000994 RID: 2452
	[Token(Token = "0x2000994")]
	public class Beaker : StationItem
	{
		// Token: 0x06004283 RID: 17027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004283")]
		[Address(RVA = "0x86CA10", Offset = "0x86BC10", VA = "0x18086CA10")]
		private void Start()
		{
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004284")]
		[Address(RVA = "0x86CAE0", Offset = "0x86BCE0", VA = "0x18086CAE0")]
		private void Update()
		{
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004285")]
		[Address(RVA = "0x86C990", Offset = "0x86BB90", VA = "0x18086C990")]
		public void SetStatic(bool stat)
		{
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004286")]
		[Address(RVA = "0x86CC10", Offset = "0x86BE10", VA = "0x18086CC10")]
		public Beaker()
		{
		}

		// Token: 0x04003019 RID: 12313
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0x38")]
		public float ClampAngle_MaxLiquid;

		// Token: 0x0400301A RID: 12314
		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0x3C")]
		public float ClampAngle_MinLiquid;

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x40")]
		public float AngleToPour_MaxLiquid;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x44")]
		public float AngleToPour_MinLiquid;

		// Token: 0x0400301D RID: 12317
		[Token(Token = "0x400301D")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Draggable Draggable;

		// Token: 0x0400301E RID: 12318
		[Token(Token = "0x400301E")]
		[FieldOffset(Offset = "0x50")]
		public DraggableConstraint Constraint;

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x58")]
		public Collider ConcaveCollider;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0x60")]
		public Collider ConvexCollider;

		// Token: 0x04003021 RID: 12321
		[Token(Token = "0x4003021")]
		[FieldOffset(Offset = "0x68")]
		public Transform CenterOfMass;

		// Token: 0x04003022 RID: 12322
		[Token(Token = "0x4003022")]
		[FieldOffset(Offset = "0x70")]
		public ConfigurableJoint Joint;

		// Token: 0x04003023 RID: 12323
		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0x78")]
		public Rigidbody Anchor;

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x80")]
		public LiquidContainer Container;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x88")]
		public Fillable Fillable;

		// Token: 0x04003026 RID: 12326
		[Token(Token = "0x4003026")]
		[FieldOffset(Offset = "0x90")]
		public PourableModule Pourable;

		// Token: 0x04003027 RID: 12327
		[Token(Token = "0x4003027")]
		[FieldOffset(Offset = "0x98")]
		public GameObject FilterPaper;
	}
}
