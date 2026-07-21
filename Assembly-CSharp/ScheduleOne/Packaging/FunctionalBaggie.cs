using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x020008A5 RID: 2213
	[Token(Token = "0x20008A5")]
	public class FunctionalBaggie : FunctionalPackaging
	{
		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		// (set) Token: 0x06003A3F RID: 14911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000919")]
		public override CursorManager.ECursorType HoveredCursor
		{
			[Token(Token = "0x6003A3E")]
			[Address(RVA = "0x7FC290", Offset = "0x7FB490", VA = "0x1807FC290", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return CursorManager.ECursorType.Default;
			}
			[Token(Token = "0x6003A3F")]
			[Address(RVA = "0x7FC2A0", Offset = "0x7FB4A0", VA = "0x1807FC2A0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x7FC0D0", Offset = "0x7FB2D0", VA = "0x1807FC0D0")]
		public void SetClosed(float closedDelta)
		{
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A41")]
		[Address(RVA = "0x7FC170", Offset = "0x7FB370", VA = "0x1807FC170", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A42")]
		[Address(RVA = "0x7FC000", Offset = "0x7FB200", VA = "0x1807FC000", Slot = "20")]
		public override void Seal()
		{
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A43")]
		[Address(RVA = "0x7FBFC0", Offset = "0x7FB1C0", VA = "0x1807FBFC0", Slot = "17")]
		protected override void FullyPacked()
		{
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A44")]
		[Address(RVA = "0x7FC270", Offset = "0x7FB470", VA = "0x1807FC270")]
		public FunctionalBaggie()
		{
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003A45")]
		[Address(RVA = "0x7FC200", Offset = "0x7FB400", VA = "0x1807FC200")]
		[CompilerGenerated]
		private IEnumerator <Seal>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		[FieldOffset(Offset = "0x138")]
		public SkinnedMeshRenderer[] BagMeshes;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		[FieldOffset(Offset = "0x140")]
		public GameObject FunnelCollidersContainer;

		// Token: 0x04002B17 RID: 11031
		[Token(Token = "0x4002B17")]
		[FieldOffset(Offset = "0x148")]
		public GameObject FullyPackedBlocker;

		// Token: 0x04002B18 RID: 11032
		[Token(Token = "0x4002B18")]
		[FieldOffset(Offset = "0x150")]
		public Collider DynamicCollider;

		// Token: 0x04002B1A RID: 11034
		[Token(Token = "0x4002B1A")]
		[FieldOffset(Offset = "0x15C")]
		private float ClosedDelta;
	}
}
