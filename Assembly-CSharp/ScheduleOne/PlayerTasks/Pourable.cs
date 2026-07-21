using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Growing;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	[RequireComponent(typeof(Accelerometer))]
	public class Pourable : Draggable
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x000096D8 File Offset: 0x000078D8
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000461")]
		public bool IsPouring
		{
			[Token(Token = "0x6001694")]
			[Address(RVA = "0x4E7120", Offset = "0x4E6320", VA = "0x1804E7120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001695")]
			[Address(RVA = "0x4E73B0", Offset = "0x4E65B0", VA = "0x1804E73B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x000096F0 File Offset: 0x000078F0
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000462")]
		public float NormalizedPourRate
		{
			[Token(Token = "0x6001696")]
			[Address(RVA = "0x5C0FA0", Offset = "0x5C01A0", VA = "0x1805C0FA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001697")]
			[Address(RVA = "0x5C0FC0", Offset = "0x5C01C0", VA = "0x1805C0FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x00009708 File Offset: 0x00007908
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000463")]
		public float CurrentQuantity
		{
			[Token(Token = "0x6001698")]
			[Address(RVA = "0x5C0F90", Offset = "0x5C0190", VA = "0x1805C0F90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001699")]
			[Address(RVA = "0x5C0FB0", Offset = "0x5C01B0", VA = "0x1805C0FB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x5C0600", Offset = "0x5BF800", VA = "0x1805C0600", Slot = "14")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0", Slot = "10")]
		protected override void Update()
		{
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x5C0320", Offset = "0x5BF520", VA = "0x1805C0320", Slot = "9")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169D")]
		[Address(RVA = "0x5C08E0", Offset = "0x5BFAE0", VA = "0x1805C08E0", Slot = "15")]
		protected virtual void UpdatePouring()
		{
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x5C0350", Offset = "0x5BF550", VA = "0x1805C0350")]
		private float GetShakeBoost()
		{
			return 0f;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x5C0440", Offset = "0x5BF640", VA = "0x1805C0440", Slot = "16")]
		protected virtual void PourAmount(float amount)
		{
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x5C03D0", Offset = "0x5BF5D0", VA = "0x1805C03D0")]
		protected bool IsPourPointOverPot()
		{
			return default(bool);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "17")]
		protected virtual bool CanPour()
		{
			return default(bool);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x5C0F40", Offset = "0x5C0140", VA = "0x1805C0F40")]
		public Pourable()
		{
		}

		// Token: 0x040013DF RID: 5087
		[Token(Token = "0x40013DF")]
		[FieldOffset(Offset = "0xC8")]
		public Action onInitialPour;

		// Token: 0x040013E0 RID: 5088
		[Token(Token = "0x40013E0")]
		[FieldOffset(Offset = "0xD0")]
		[Header("Pourable settings")]
		public bool Unlimited;

		// Token: 0x040013E1 RID: 5089
		[Token(Token = "0x40013E1")]
		[FieldOffset(Offset = "0xD4")]
		public float StartQuantity;

		// Token: 0x040013E2 RID: 5090
		[Token(Token = "0x40013E2")]
		[FieldOffset(Offset = "0xD8")]
		public float PourRate_L;

		// Token: 0x040013E3 RID: 5091
		[Token(Token = "0x40013E3")]
		[FieldOffset(Offset = "0xDC")]
		public float AngleFromUpToPour;

		// Token: 0x040013E4 RID: 5092
		[Token(Token = "0x40013E4")]
		[FieldOffset(Offset = "0xE0")]
		[Tooltip("Multiplier for pour rate when pourable is shaken up and down")]
		public float ShakeBoostRate;

		// Token: 0x040013E5 RID: 5093
		[Token(Token = "0x40013E5")]
		[FieldOffset(Offset = "0xE4")]
		public bool AffectsCoverage;

		// Token: 0x040013E6 RID: 5094
		[Token(Token = "0x40013E6")]
		[FieldOffset(Offset = "0xE8")]
		[Header("Particles")]
		public float ParticleMinMultiplier;

		// Token: 0x040013E7 RID: 5095
		[Token(Token = "0x40013E7")]
		[FieldOffset(Offset = "0xEC")]
		public float ParticleMaxMultiplier;

		// Token: 0x040013E8 RID: 5096
		[Token(Token = "0x40013E8")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Pourable References")]
		public ParticleSystem[] PourParticles;

		// Token: 0x040013E9 RID: 5097
		[Token(Token = "0x40013E9")]
		[FieldOffset(Offset = "0xF8")]
		public Transform PourPoint;

		// Token: 0x040013EA RID: 5098
		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0x100")]
		public AudioSourceController PourLoop;

		// Token: 0x040013EB RID: 5099
		[Token(Token = "0x40013EB")]
		[FieldOffset(Offset = "0x108")]
		[Header("Trash")]
		public TrashItem TrashItem;

		// Token: 0x040013EC RID: 5100
		[Token(Token = "0x40013EC")]
		[FieldOffset(Offset = "0x110")]
		[HideInInspector]
		public GrowContainer TargetGrowContainer;

		// Token: 0x040013EF RID: 5103
		[Token(Token = "0x40013EF")]
		[FieldOffset(Offset = "0x120")]
		protected bool hasPoured;

		// Token: 0x040013F0 RID: 5104
		[Token(Token = "0x40013F0")]
		[FieldOffset(Offset = "0x121")]
		protected bool autoSetCurrentQuantity;

		// Token: 0x040013F1 RID: 5105
		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x128")]
		private float[] particleMinSizes;

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x130")]
		private float[] particleMaxSizes;

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x138")]
		private AverageAcceleration accelerometer;
	}
}
