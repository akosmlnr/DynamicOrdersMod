using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x020008A8 RID: 2216
	[Token(Token = "0x20008A8")]
	public class FunctionalPackaging : Draggable
	{
		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06003A56 RID: 14934 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		// (set) Token: 0x06003A57 RID: 14935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091D")]
		public bool IsSealed
		{
			[Token(Token = "0x6003A56")]
			[Address(RVA = "0x4E7120", Offset = "0x4E6320", VA = "0x1804E7120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A57")]
			[Address(RVA = "0x4E73B0", Offset = "0x4E65B0", VA = "0x1804E73B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06003A58 RID: 14936 RVA: 0x00011010 File Offset: 0x0000F210
		// (set) Token: 0x06003A59 RID: 14937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091E")]
		public bool IsFull
		{
			[Token(Token = "0x6003A58")]
			[Address(RVA = "0x4E7280", Offset = "0x4E6480", VA = "0x1804E7280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A59")]
			[Address(RVA = "0x4E7440", Offset = "0x4E6640", VA = "0x1804E7440")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06003A5A RID: 14938 RVA: 0x00011028 File Offset: 0x0000F228
		// (set) Token: 0x06003A5B RID: 14939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091F")]
		public bool ReachedOutput
		{
			[Token(Token = "0x6003A5A")]
			[Address(RVA = "0x4E7290", Offset = "0x4E6490", VA = "0x1804E7290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A5B")]
			[Address(RVA = "0x4E7450", Offset = "0x4E6650", VA = "0x1804E7450")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A5C")]
		[Address(RVA = "0x7FD400", Offset = "0x7FC600", VA = "0x1807FD400", Slot = "14")]
		public virtual void Initialize(PackagingStation _station, Transform alignment, bool align = true)
		{
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A5D")]
		[Address(RVA = "0x7FCA30", Offset = "0x7FBC30", VA = "0x1807FCA30")]
		public void AlignTo(Transform alignment)
		{
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A5E")]
		[Address(RVA = "0x7FCF70", Offset = "0x7FC170", VA = "0x1807FCF70", Slot = "15")]
		public virtual void Destroy()
		{
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A5F")]
		[Address(RVA = "0x7FCFE0", Offset = "0x7FC1E0", VA = "0x1807FCFE0", Slot = "9")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x7FD990", Offset = "0x7FCB90", VA = "0x1807FD990", Slot = "16")]
		protected virtual void PackProduct(FunctionalProduct product)
		{
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A61")]
		[Address(RVA = "0x7FD240", Offset = "0x7FC440", VA = "0x1807FD240", Slot = "17")]
		protected virtual void FullyPacked()
		{
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A62")]
		[Address(RVA = "0x7FD520", Offset = "0x7FC720", VA = "0x1807FD520", Slot = "18")]
		protected virtual void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A63")]
		[Address(RVA = "0x7FCFD0", Offset = "0x7FC1D0", VA = "0x1807FCFD0", Slot = "19")]
		protected virtual void EnableSealing()
		{
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A64")]
		[Address(RVA = "0x7FDC30", Offset = "0x7FCE30", VA = "0x1807FDC30", Slot = "20")]
		public virtual void Seal()
		{
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A65")]
		[Address(RVA = "0x7FDEA0", Offset = "0x7FD0A0", VA = "0x1807FDEA0")]
		public FunctionalPackaging()
		{
		}

		// Token: 0x04002B2B RID: 11051
		[Token(Token = "0x4002B2B")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Settings")]
		public string SealInstruction;

		// Token: 0x04002B2C RID: 11052
		[Token(Token = "0x4002B2C")]
		[FieldOffset(Offset = "0xD0")]
		public bool AutoEnableSealing;

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[FieldOffset(Offset = "0xD4")]
		public float ProductContactTime;

		// Token: 0x04002B2E RID: 11054
		[Token(Token = "0x4002B2E")]
		[FieldOffset(Offset = "0xD8")]
		public float ProductContactMaxVelocity;

		// Token: 0x04002B2F RID: 11055
		[Token(Token = "0x4002B2F")]
		[FieldOffset(Offset = "0xE0")]
		[Header("References")]
		public PackagingDefinition Definition;

		// Token: 0x04002B30 RID: 11056
		[Token(Token = "0x4002B30")]
		[FieldOffset(Offset = "0xE8")]
		public Transform AlignmentPoint;

		// Token: 0x04002B31 RID: 11057
		[Token(Token = "0x4002B31")]
		[FieldOffset(Offset = "0xF0")]
		public Transform[] ProductAlignmentPoints;

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0xF8")]
		public AudioSourceController SealSound;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x100")]
		protected List<FunctionalProduct> PackedProducts;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x108")]
		public Action onFullyPacked;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x4002B35")]
		[FieldOffset(Offset = "0x110")]
		public Action onSealed;

		// Token: 0x04002B36 RID: 11062
		[Token(Token = "0x4002B36")]
		[FieldOffset(Offset = "0x118")]
		public Action onReachOutput;

		// Token: 0x04002B37 RID: 11063
		[Token(Token = "0x4002B37")]
		[FieldOffset(Offset = "0x120")]
		private PackagingStation station;

		// Token: 0x04002B38 RID: 11064
		[Token(Token = "0x4002B38")]
		[FieldOffset(Offset = "0x128")]
		private Dictionary<FunctionalProduct, float> productContactTime;

		// Token: 0x04002B39 RID: 11065
		[Token(Token = "0x4002B39")]
		[FieldOffset(Offset = "0x130")]
		private SmoothedVelocityCalculator VelocityCalculator;
	}
}
