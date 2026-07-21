using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000863 RID: 2147
	[Token(Token = "0x2000863")]
	[Serializable]
	public class FloatSmoother
	{
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x00010C50 File Offset: 0x0000EE50
		// (set) Token: 0x06003923 RID: 14627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000904")]
		public float CurrentValue
		{
			[Token(Token = "0x6003922")]
			[Address(RVA = "0x475910", Offset = "0x474B10", VA = "0x180475910")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003923")]
			[Address(RVA = "0x492A10", Offset = "0x491C10", VA = "0x180492A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06003924 RID: 14628 RVA: 0x00010C68 File Offset: 0x0000EE68
		// (set) Token: 0x06003925 RID: 14629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000905")]
		public float Multiplier
		{
			[Token(Token = "0x6003924")]
			[Address(RVA = "0x475920", Offset = "0x474B20", VA = "0x180475920")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003925")]
			[Address(RVA = "0x475A80", Offset = "0x474C80", VA = "0x180475A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003926")]
		[Address(RVA = "0x7FB0D0", Offset = "0x7FA2D0", VA = "0x1807FB0D0")]
		public void Initialize()
		{
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003927")]
		[Address(RVA = "0x7FB4A0", Offset = "0x7FA6A0", VA = "0x1807FB4A0")]
		public void SetDefault(float value, bool apply = true)
		{
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003928")]
		[Address(RVA = "0x475A80", Offset = "0x474C80", VA = "0x180475A80")]
		public void SetMultiplier(float value)
		{
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003929")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80")]
		public void SetSmoothingSpeed(float value)
		{
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600392A")]
		[Address(RVA = "0x7FACB0", Offset = "0x7F9EB0", VA = "0x1807FACB0")]
		public void AddOverride(float value, int priority, string label)
		{
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600392B")]
		[Address(RVA = "0x7FB130", Offset = "0x7FA330", VA = "0x1807FB130")]
		public void RemoveOverride(string label)
		{
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600392C")]
		[Address(RVA = "0x7FB510", Offset = "0x7FA710", VA = "0x1807FB510")]
		public void Update()
		{
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600392D")]
		[Address(RVA = "0x7FB5A0", Offset = "0x7FA7A0", VA = "0x1807FB5A0")]
		public FloatSmoother()
		{
		}

		// Token: 0x04002A21 RID: 10785
		[Token(Token = "0x4002A21")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float DefaultValue;

		// Token: 0x04002A22 RID: 10786
		[Token(Token = "0x4002A22")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float SmoothingSpeed;

		// Token: 0x04002A23 RID: 10787
		[Token(Token = "0x4002A23")]
		[FieldOffset(Offset = "0x20")]
		private List<FloatSmoother.Override> overrides;

		// Token: 0x04002A24 RID: 10788
		[Token(Token = "0x4002A24")]
		[FieldOffset(Offset = "0x28")]
		private FloatSmoother.Override activeOverride;

		// Token: 0x02000864 RID: 2148
		[Token(Token = "0x2000864")]
		public class Override
		{
			// Token: 0x0600392E RID: 14638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600392E")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Override()
			{
			}

			// Token: 0x04002A25 RID: 10789
			[Token(Token = "0x4002A25")]
			[FieldOffset(Offset = "0x10")]
			public float Value;

			// Token: 0x04002A26 RID: 10790
			[Token(Token = "0x4002A26")]
			[FieldOffset(Offset = "0x14")]
			public int Priority;

			// Token: 0x04002A27 RID: 10791
			[Token(Token = "0x4002A27")]
			[FieldOffset(Offset = "0x18")]
			public string Label;
		}
	}
}
