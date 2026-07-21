using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Tools
{
	// Token: 0x02000868 RID: 2152
	[Token(Token = "0x2000868")]
	public class FloatStack
	{
		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000906")]
		public float Value
		{
			[Token(Token = "0x6003937")]
			[Address(RVA = "0x475910", Offset = "0x474B10", VA = "0x180475910")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003938")]
			[Address(RVA = "0x492A10", Offset = "0x491C10", VA = "0x180492A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06003939 RID: 14649 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600393A RID: 14650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000012")]
		public event Action<float> OnValueChanged
		{
			[Token(Token = "0x6003939")]
			[Address(RVA = "0x7FBD30", Offset = "0x7FAF30", VA = "0x1807FBD30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600393A")]
			[Address(RVA = "0x7FBDE0", Offset = "0x7FAFE0", VA = "0x1807FBDE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x7FBC90", Offset = "0x7FAE90", VA = "0x1807FBC90")]
		public FloatStack(float defaultValue)
		{
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393C")]
		[Address(RVA = "0x7FB630", Offset = "0x7FA830", VA = "0x1807FB630")]
		public void Add(FloatStack.StackEntry entry)
		{
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393D")]
		[Address(RVA = "0x7FBAA0", Offset = "0x7FACA0", VA = "0x1807FBAA0")]
		public void Remove(string label)
		{
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[Token(Token = "0x600393E")]
		[Address(RVA = "0x7FBB90", Offset = "0x7FAD90", VA = "0x1807FBB90")]
		public bool TryGetEntry(string label, out FloatStack.StackEntry entry)
		{
			return default(bool);
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393F")]
		[Address(RVA = "0x7FB7A0", Offset = "0x7FA9A0", VA = "0x1807FB7A0")]
		private void Recalculate()
		{
		}

		// Token: 0x04002A2F RID: 10799
		[Token(Token = "0x4002A2F")]
		[FieldOffset(Offset = "0x20")]
		private float _defaultValue;

		// Token: 0x04002A30 RID: 10800
		[Token(Token = "0x4002A30")]
		[FieldOffset(Offset = "0x28")]
		private List<FloatStack.StackEntry> _stack;

		// Token: 0x02000869 RID: 2153
		[Token(Token = "0x2000869")]
		public enum EStackMode
		{
			// Token: 0x04002A32 RID: 10802
			[Token(Token = "0x4002A32")]
			Additive,
			// Token: 0x04002A33 RID: 10803
			[Token(Token = "0x4002A33")]
			Override,
			// Token: 0x04002A34 RID: 10804
			[Token(Token = "0x4002A34")]
			Multiplicative
		}

		// Token: 0x0200086A RID: 2154
		[Token(Token = "0x200086A")]
		public class StackEntry
		{
			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x06003940 RID: 14656 RVA: 0x0000206A File Offset: 0x0000026A
			// (set) Token: 0x06003941 RID: 14657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000907")]
			public string Label
			{
				[Token(Token = "0x6003940")]
				[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003941")]
				[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x06003942 RID: 14658 RVA: 0x00010D10 File Offset: 0x0000EF10
			// (set) Token: 0x06003943 RID: 14659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000908")]
			public float Value
			{
				[Token(Token = "0x6003942")]
				[Address(RVA = "0x549260", Offset = "0x548460", VA = "0x180549260")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6003943")]
				[Address(RVA = "0x6466E0", Offset = "0x6458E0", VA = "0x1806466E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x06003944 RID: 14660 RVA: 0x00010D28 File Offset: 0x0000EF28
			// (set) Token: 0x06003945 RID: 14661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000909")]
			public FloatStack.EStackMode Mode
			{
				[Token(Token = "0x6003944")]
				[Address(RVA = "0x4A0500", Offset = "0x49F700", VA = "0x1804A0500")]
				[CompilerGenerated]
				get
				{
					return FloatStack.EStackMode.Additive;
				}
				[Token(Token = "0x6003945")]
				[Address(RVA = "0x4A0510", Offset = "0x49F710", VA = "0x1804A0510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x06003946 RID: 14662 RVA: 0x00010D40 File Offset: 0x0000EF40
			// (set) Token: 0x06003947 RID: 14663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700090A")]
			public int Order
			{
				[Token(Token = "0x6003946")]
				[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6003947")]
				[Address(RVA = "0x4929C0", Offset = "0x491BC0", VA = "0x1804929C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06003948 RID: 14664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x80EF70", Offset = "0x80E170", VA = "0x18080EF70")]
			public StackEntry(string label, float value, FloatStack.EStackMode mode, int order)
			{
			}
		}
	}
}
