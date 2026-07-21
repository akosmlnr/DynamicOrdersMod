using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000852 RID: 2130
	[Token(Token = "0x2000852")]
	[Serializable]
	public class ColorSmoother
	{
		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x00010B78 File Offset: 0x0000ED78
		// (set) Token: 0x060038E6 RID: 14566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FD")]
		public Color CurrentValue
		{
			[Token(Token = "0x60038E5")]
			[Address(RVA = "0x49B280", Offset = "0x49A480", VA = "0x18049B280")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60038E6")]
			[Address(RVA = "0x49B2A0", Offset = "0x49A4A0", VA = "0x18049B2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x00010B90 File Offset: 0x0000ED90
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FE")]
		public float Multiplier
		{
			[Token(Token = "0x60038E7")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60038E8")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		[Token(Token = "0x170008FF")]
		public Color Default
		{
			[Token(Token = "0x60038E9")]
			[Address(RVA = "0x58D070", Offset = "0x58C270", VA = "0x18058D070")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EA")]
		[Address(RVA = "0x7F8F20", Offset = "0x7F8120", VA = "0x1807F8F20")]
		public void Initialize()
		{
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EB")]
		[Address(RVA = "0x7F9300", Offset = "0x7F8500", VA = "0x1807F9300")]
		public void SetDefault(Color value)
		{
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EC")]
		[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
		public void SetMultiplier(float value)
		{
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0x7F8B00", Offset = "0x7F7D00", VA = "0x1807F8B00")]
		public void AddOverride(Color value, int priority, string label)
		{
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EE")]
		[Address(RVA = "0x7F8F90", Offset = "0x7F8190", VA = "0x1807F8F90")]
		public void RemoveOverride(string label)
		{
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EF")]
		[Address(RVA = "0x7F9370", Offset = "0x7F8570", VA = "0x1807F9370")]
		public void Update()
		{
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F0")]
		[Address(RVA = "0x7F9480", Offset = "0x7F8680", VA = "0x1807F9480")]
		public ColorSmoother()
		{
		}

		// Token: 0x040029F2 RID: 10738
		[Token(Token = "0x40029F2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color DefaultValue;

		// Token: 0x040029F3 RID: 10739
		[Token(Token = "0x40029F3")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float SmoothingSpeed;

		// Token: 0x040029F4 RID: 10740
		[Token(Token = "0x40029F4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<ColorSmoother.Override> overrides;

		// Token: 0x040029F5 RID: 10741
		[Token(Token = "0x40029F5")]
		[FieldOffset(Offset = "0x40")]
		private ColorSmoother.Override activeOverride;

		// Token: 0x02000853 RID: 2131
		[Token(Token = "0x2000853")]
		[Serializable]
		public class Override
		{
			// Token: 0x060038F1 RID: 14577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60038F1")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Override()
			{
			}

			// Token: 0x040029F6 RID: 10742
			[Token(Token = "0x40029F6")]
			[FieldOffset(Offset = "0x10")]
			public Color Value;

			// Token: 0x040029F7 RID: 10743
			[Token(Token = "0x40029F7")]
			[FieldOffset(Offset = "0x20")]
			public int Priority;

			// Token: 0x040029F8 RID: 10744
			[Token(Token = "0x40029F8")]
			[FieldOffset(Offset = "0x28")]
			public string Label;
		}
	}
}
