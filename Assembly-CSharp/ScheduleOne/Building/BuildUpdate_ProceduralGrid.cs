using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	public class BuildUpdate_ProceduralGrid : BuildUpdate_Base
	{
		// Token: 0x060034F8 RID: 13560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x7CD350", Offset = "0x7CC550", VA = "0x1807CD350", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x7CC4C0", Offset = "0x7CB6C0", VA = "0x1807CC4C0", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x7CC050", Offset = "0x7CB250", VA = "0x1807CC050")]
		protected void CheckRotation()
		{
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x7CB340", Offset = "0x7CA540", VA = "0x1807CB340")]
		protected void ApplyRotation()
		{
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x7CB7B0", Offset = "0x7CA9B0", VA = "0x1807CB7B0", Slot = "7")]
		protected virtual void CheckGridIntersections()
		{
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x7CD1B0", Offset = "0x7CC3B0", VA = "0x1807CD1B0")]
		protected void UpdateMaterials()
		{
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x7CC2A0", Offset = "0x7CB4A0", VA = "0x1807CC2A0")]
		private bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)
		{
			return default(bool);
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x7CCA00", Offset = "0x7CBC00", VA = "0x1807CCA00")]
		protected void Place()
		{
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x7CC140", Offset = "0x7CB340", VA = "0x1807CC140")]
		private ProceduralTile GetNearbyProcTile()
		{
			return null;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x7CD490", Offset = "0x7CC690", VA = "0x1807CD490")]
		public BuildUpdate_ProceduralGrid()
		{
		}

		// Token: 0x04002684 RID: 9860
		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GhostModel;

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0x28")]
		public ProceduralGridItem ItemClass;

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0x30")]
		public ItemInstance ItemInstance;

		// Token: 0x04002687 RID: 9863
		[Token(Token = "0x4002687")]
		[FieldOffset(Offset = "0x38")]
		[Header("Settings")]
		public float detectionRange;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0x3C")]
		public LayerMask detectionMask;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0x40")]
		public float rotation_Smoothing;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0x44")]
		protected float currentRotation;

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0x48")]
		protected bool validPosition;

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		[FieldOffset(Offset = "0x50")]
		protected Material currentGhostMaterial;

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		[FieldOffset(Offset = "0x58")]
		protected BuildUpdate_ProceduralGrid.Intersection bestIntersection;

		// Token: 0x020007BF RID: 1983
		[Token(Token = "0x20007BF")]
		public class Intersection
		{
			// Token: 0x06003502 RID: 13570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003502")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Intersection()
			{
			}

			// Token: 0x0400268E RID: 9870
			[Token(Token = "0x400268E")]
			[FieldOffset(Offset = "0x10")]
			public FootprintTile footprintTile;

			// Token: 0x0400268F RID: 9871
			[Token(Token = "0x400268F")]
			[FieldOffset(Offset = "0x18")]
			public ProceduralTile procTile;
		}
	}
}
