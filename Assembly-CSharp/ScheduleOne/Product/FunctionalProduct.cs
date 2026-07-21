using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000909 RID: 2313
	[Token(Token = "0x2000909")]
	public class FunctionalProduct : Draggable
	{
		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003DC9 RID: 15817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B4")]
		public SmoothedVelocityCalculator VelocityCalculator
		{
			[Token(Token = "0x6003DC8")]
			[Address(RVA = "0x4E7270", Offset = "0x4E6470", VA = "0x1804E7270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DC9")]
			[Address(RVA = "0x4E7420", Offset = "0x4E6620", VA = "0x1804E7420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCA")]
		[Address(RVA = "0x82CD70", Offset = "0x82BF70", VA = "0x18082CD70", Slot = "14")]
		public virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = true)
		{
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCB")]
		[Address(RVA = "0x82CC00", Offset = "0x82BE00", VA = "0x18082CC00", Slot = "15")]
		public virtual void Initialize(ItemInstance item)
		{
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCC")]
		[Address(RVA = "0x82CB30", Offset = "0x82BD30", VA = "0x18082CB30", Slot = "16")]
		public virtual void InitializeVisuals(ItemInstance item)
		{
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0x82C5B0", Offset = "0x82B7B0", VA = "0x18082C5B0")]
		public void AlignTo(Transform alignment)
		{
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x82CB20", Offset = "0x82BD20", VA = "0x18082CB20", Slot = "9")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x82CF00", Offset = "0x82C100", VA = "0x18082CF00", Slot = "12")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD0")]
		[Address(RVA = "0x82C9A0", Offset = "0x82BBA0", VA = "0x18082C9A0")]
		private void Clamp()
		{
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD1")]
		[Address(RVA = "0x82D0A0", Offset = "0x82C2A0", VA = "0x18082D0A0")]
		public FunctionalProduct()
		{
		}

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		[FieldOffset(Offset = "0xC0")]
		public bool ClampZ;

		// Token: 0x04002D56 RID: 11606
		[Token(Token = "0x4002D56")]
		[FieldOffset(Offset = "0xC8")]
		[Header("References")]
		public Transform AlignmentPoint;

		// Token: 0x04002D57 RID: 11607
		[Token(Token = "0x4002D57")]
		[FieldOffset(Offset = "0xD0")]
		public ProductVisualsSetter Visuals;

		// Token: 0x04002D58 RID: 11608
		[Token(Token = "0x4002D58")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3 startLocalPos;

		// Token: 0x04002D59 RID: 11609
		[Token(Token = "0x4002D59")]
		[FieldOffset(Offset = "0xE4")]
		private float lowestMaxZ;
	}
}
