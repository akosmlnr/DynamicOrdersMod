using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008F0 RID: 2288
	[Token(Token = "0x20008F0")]
	public class PourableModule : ItemModule
	{
		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x000119B8 File Offset: 0x0000FBB8
		// (set) Token: 0x06003D5B RID: 15707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A7")]
		public bool IsPouring
		{
			[Token(Token = "0x6003D5A")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003D5B")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x000119D0 File Offset: 0x0000FBD0
		// (set) Token: 0x06003D5D RID: 15709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A8")]
		public float NormalizedPourRate
		{
			[Token(Token = "0x6003D5C")]
			[Address(RVA = "0x495780", Offset = "0x494980", VA = "0x180495780")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003D5D")]
			[Address(RVA = "0x836F20", Offset = "0x836120", VA = "0x180836F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x000119E8 File Offset: 0x0000FBE8
		// (set) Token: 0x06003D5F RID: 15711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A9")]
		public float LiquidLevel
		{
			[Token(Token = "0x6003D5E")]
			[Address(RVA = "0x4CBFA0", Offset = "0x4CB1A0", VA = "0x1804CBFA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003D5F")]
			[Address(RVA = "0x4E12A0", Offset = "0x4E04A0", VA = "0x1804E12A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06003D60 RID: 15712 RVA: 0x00011A00 File Offset: 0x0000FC00
		[Token(Token = "0x170009AA")]
		public float NormalizedLiquidLevel
		{
			[Token(Token = "0x6003D60")]
			[Address(RVA = "0x836F10", Offset = "0x836110", VA = "0x180836F10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D61")]
		[Address(RVA = "0x8363E0", Offset = "0x8355E0", VA = "0x1808363E0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D62")]
		[Address(RVA = "0x835D10", Offset = "0x834F10", VA = "0x180835D10", Slot = "4")]
		public override void ActivateModule(StationItem item)
		{
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D63")]
		[Address(RVA = "0x835ED0", Offset = "0x8350D0", VA = "0x180835ED0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D64")]
		[Address(RVA = "0x8368B0", Offset = "0x835AB0", VA = "0x1808368B0", Slot = "7")]
		protected virtual void UpdatePouring()
		{
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D65")]
		[Address(RVA = "0x8367C0", Offset = "0x8359C0", VA = "0x1808367C0")]
		private void UpdatePourSound()
		{
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D66")]
		[Address(RVA = "0x835E10", Offset = "0x835010", VA = "0x180835E10", Slot = "8")]
		public virtual void ChangeLiquidLevel(float change)
		{
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D67")]
		[Address(RVA = "0x836320", Offset = "0x835520", VA = "0x180836320", Slot = "9")]
		public virtual void SetLiquidLevel(float level)
		{
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D68")]
		[Address(RVA = "0x8360F0", Offset = "0x8352F0", VA = "0x1808360F0", Slot = "10")]
		protected virtual void PourAmount(float amount)
		{
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D69")]
		[Address(RVA = "0x836030", Offset = "0x835230", VA = "0x180836030")]
		private void ParticleCollision(GameObject other)
		{
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x00011A18 File Offset: 0x0000FC18
		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "11")]
		protected virtual bool CanPour()
		{
			return default(bool);
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x836E70", Offset = "0x836070", VA = "0x180836E70")]
		public PourableModule()
		{
		}

		// Token: 0x04002CDE RID: 11486
		[Token(Token = "0x4002CDE")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public string LiquidType;

		// Token: 0x04002CDF RID: 11487
		[Token(Token = "0x4002CDF")]
		[FieldOffset(Offset = "0x48")]
		public float PourRate;

		// Token: 0x04002CE0 RID: 11488
		[Token(Token = "0x4002CE0")]
		[FieldOffset(Offset = "0x4C")]
		public float AngleFromUpToPour;

		// Token: 0x04002CE1 RID: 11489
		[Token(Token = "0x4002CE1")]
		[FieldOffset(Offset = "0x50")]
		public bool OnlyEmptyOverFillable;

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		[FieldOffset(Offset = "0x54")]
		public float LiquidCapacity_L;

		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x58")]
		public Color LiquidColor;

		// Token: 0x04002CE4 RID: 11492
		[Token(Token = "0x4002CE4")]
		[FieldOffset(Offset = "0x68")]
		public float DefaultLiquid_L;

		// Token: 0x04002CE5 RID: 11493
		[Token(Token = "0x4002CE5")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public ParticleSystem[] PourParticles;

		// Token: 0x04002CE6 RID: 11494
		[Token(Token = "0x4002CE6")]
		[FieldOffset(Offset = "0x78")]
		public Transform PourPoint;

		// Token: 0x04002CE7 RID: 11495
		[Token(Token = "0x4002CE7")]
		[FieldOffset(Offset = "0x80")]
		public LiquidContainer LiquidContainer;

		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x88")]
		public Draggable Draggable;

		// Token: 0x04002CE9 RID: 11497
		[Token(Token = "0x4002CE9")]
		[FieldOffset(Offset = "0x90")]
		public DraggableConstraint DraggableConstraint;

		// Token: 0x04002CEA RID: 11498
		[Token(Token = "0x4002CEA")]
		[FieldOffset(Offset = "0x98")]
		public AudioSourceController PourSound;

		// Token: 0x04002CEB RID: 11499
		[Token(Token = "0x4002CEB")]
		[FieldOffset(Offset = "0xA0")]
		[Header("Particles")]
		public Color PourParticlesColor;

		// Token: 0x04002CEC RID: 11500
		[Token(Token = "0x4002CEC")]
		[FieldOffset(Offset = "0xB0")]
		public float ParticleMinMultiplier;

		// Token: 0x04002CED RID: 11501
		[Token(Token = "0x4002CED")]
		[FieldOffset(Offset = "0xB4")]
		public float ParticleMaxMultiplier;

		// Token: 0x04002CEE RID: 11502
		[Token(Token = "0x4002CEE")]
		[FieldOffset(Offset = "0xB8")]
		private float[] particleMinSizes;

		// Token: 0x04002CEF RID: 11503
		[Token(Token = "0x4002CEF")]
		[FieldOffset(Offset = "0xC0")]
		private float[] particleMaxSizes;

		// Token: 0x04002CF0 RID: 11504
		[Token(Token = "0x4002CF0")]
		[FieldOffset(Offset = "0xC8")]
		private Fillable activeFillable;

		// Token: 0x04002CF1 RID: 11505
		[Token(Token = "0x4002CF1")]
		[FieldOffset(Offset = "0xD0")]
		private float timeSinceFillableHit;
	}
}
