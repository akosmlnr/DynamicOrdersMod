using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace VLB
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	public class MinMaxRangeAttribute : Attribute
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00003FA8 File Offset: 0x000021A8
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000ED")]
		public float minValue
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x475910", Offset = "0x474B10", VA = "0x180475910")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x492A10", Offset = "0x491C10", VA = "0x180492A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00003FC0 File Offset: 0x000021C0
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EE")]
		public float maxValue
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x475920", Offset = "0x474B20", VA = "0x180475920")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x475A80", Offset = "0x474C80", VA = "0x180475A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x697F40", Offset = "0x697140", VA = "0x180697F40")]
		public MinMaxRangeAttribute(float min, float max)
		{
		}
	}
}
