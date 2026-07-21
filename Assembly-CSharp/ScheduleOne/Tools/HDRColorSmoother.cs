using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000872 RID: 2162
	[Token(Token = "0x2000872")]
	[Serializable]
	public class HDRColorSmoother
	{
		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x00010E00 File Offset: 0x0000F000
		// (set) Token: 0x06003960 RID: 14688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700090C")]
		public Color CurrentValue
		{
			[Token(Token = "0x600395F")]
			[Address(RVA = "0x49B280", Offset = "0x49A480", VA = "0x18049B280")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6003960")]
			[Address(RVA = "0x49B2A0", Offset = "0x49A4A0", VA = "0x18049B2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x00010E18 File Offset: 0x0000F018
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700090D")]
		public float Multiplier
		{
			[Token(Token = "0x6003961")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003962")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003963")]
		[Address(RVA = "0x803F10", Offset = "0x803110", VA = "0x180803F10")]
		public void Initialize()
		{
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003964")]
		[Address(RVA = "0x8042F0", Offset = "0x8034F0", VA = "0x1808042F0")]
		public void SetDefault(Color value)
		{
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003965")]
		[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
		public void SetMultiplier(float value)
		{
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003966")]
		[Address(RVA = "0x803AF0", Offset = "0x802CF0", VA = "0x180803AF0")]
		public void AddOverride(Color value, int priority, string label)
		{
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003967")]
		[Address(RVA = "0x803F80", Offset = "0x803180", VA = "0x180803F80")]
		public void RemoveOverride(string label)
		{
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003968")]
		[Address(RVA = "0x7F9370", Offset = "0x7F8570", VA = "0x1807F9370")]
		public void Update()
		{
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003969")]
		[Address(RVA = "0x804360", Offset = "0x803560", VA = "0x180804360")]
		public HDRColorSmoother()
		{
		}

		// Token: 0x04002A4A RID: 10826
		[Token(Token = "0x4002A4A")]
		[FieldOffset(Offset = "0x24")]
		[ColorUsage(true, true)]
		[SerializeField]
		private Color DefaultValue;

		// Token: 0x04002A4B RID: 10827
		[Token(Token = "0x4002A4B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float SmoothingSpeed;

		// Token: 0x04002A4C RID: 10828
		[Token(Token = "0x4002A4C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<HDRColorSmoother.Override> overrides;

		// Token: 0x04002A4D RID: 10829
		[Token(Token = "0x4002A4D")]
		[FieldOffset(Offset = "0x40")]
		private HDRColorSmoother.Override activeOverride;

		// Token: 0x04002A4E RID: 10830
		[Token(Token = "0x4002A4E")]
		[FieldOffset(Offset = "0x48")]
		private bool isBeingUpdated;

		// Token: 0x02000873 RID: 2163
		[Token(Token = "0x2000873")]
		[Serializable]
		public class Override
		{
			// Token: 0x0600396A RID: 14698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600396A")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Override()
			{
			}

			// Token: 0x04002A4F RID: 10831
			[Token(Token = "0x4002A4F")]
			[FieldOffset(Offset = "0x10")]
			public Color Value;

			// Token: 0x04002A50 RID: 10832
			[Token(Token = "0x4002A50")]
			[FieldOffset(Offset = "0x20")]
			public int Priority;

			// Token: 0x04002A51 RID: 10833
			[Token(Token = "0x4002A51")]
			[FieldOffset(Offset = "0x28")]
			public string Label;
		}
	}
}
