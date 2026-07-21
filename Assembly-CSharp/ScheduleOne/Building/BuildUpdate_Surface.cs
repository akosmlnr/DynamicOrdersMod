using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007C0 RID: 1984
	[Token(Token = "0x20007C0")]
	public class BuildUpdate_Surface : BuildUpdate_Base
	{
		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06003503 RID: 13571 RVA: 0x0000FE40 File Offset: 0x0000E040
		[Token(Token = "0x1700085F")]
		private float detectionRange
		{
			[Token(Token = "0x6003503")]
			[Address(RVA = "0x7CF1A0", Offset = "0x7CE3A0", VA = "0x1807CF1A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003504")]
		[Address(RVA = "0x491630", Offset = "0x490830", VA = "0x180491630", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003505")]
		[Address(RVA = "0x7CF010", Offset = "0x7CE210", VA = "0x1807CF010", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003506")]
		[Address(RVA = "0x7CD720", Offset = "0x7CC920", VA = "0x1807CD720", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x7CE580", Offset = "0x7CD780", VA = "0x1807CE580")]
		protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)
		{
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x0000FE58 File Offset: 0x0000E058
		[Token(Token = "0x6003508")]
		[Address(RVA = "0x7CD5F0", Offset = "0x7CC7F0", VA = "0x1807CD5F0")]
		private bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint)
		{
			return default(bool);
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x7CD4B0", Offset = "0x7CC6B0", VA = "0x1807CD4B0")]
		protected void CheckRotation()
		{
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350A")]
		[Address(RVA = "0x7CEE70", Offset = "0x7CE070", VA = "0x1807CEE70")]
		protected void UpdateMaterials()
		{
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350B")]
		[Address(RVA = "0x7CE1F0", Offset = "0x7CD3F0", VA = "0x1807CE1F0", Slot = "8")]
		protected virtual void Place()
		{
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350C")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public BuildUpdate_Surface()
		{
		}

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GhostModel;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[FieldOffset(Offset = "0x28")]
		public SurfaceItem BuildableItemClass;

		// Token: 0x04002692 RID: 9874
		[Token(Token = "0x4002692")]
		[FieldOffset(Offset = "0x30")]
		public ItemInstance ItemInstance;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0x38")]
		public float CurrentRotation;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[FieldOffset(Offset = "0x40")]
		protected bool validPosition;

		// Token: 0x04002696 RID: 9878
		[Token(Token = "0x4002696")]
		[FieldOffset(Offset = "0x48")]
		protected Material currentGhostMaterial;

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[FieldOffset(Offset = "0x50")]
		protected Surface hoveredValidSurface;
	}
}
