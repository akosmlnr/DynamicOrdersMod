using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008AB RID: 2219
	[Token(Token = "0x20008AB")]
	public class Additive : MonoBehaviour
	{
		// Token: 0x06003A6D RID: 14957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A6D")]
		[Address(RVA = "0x7F6DB0", Offset = "0x7F5FB0", VA = "0x1807F6DB0")]
		public Additive()
		{
		}

		// Token: 0x04002B44 RID: 11076
		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x20")]
		public string AdditiveName;

		// Token: 0x04002B45 RID: 11077
		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x28")]
		public AdditiveDefinition Definition;

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x30")]
		[Header("Plant effector settings")]
		public float QualityChange;

		// Token: 0x04002B47 RID: 11079
		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x34")]
		public float YieldChange;

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x4002B48")]
		[FieldOffset(Offset = "0x38")]
		public float GrowSpeedMultiplier;

		// Token: 0x04002B49 RID: 11081
		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x3C")]
		public float InstantGrowth;
	}
}
