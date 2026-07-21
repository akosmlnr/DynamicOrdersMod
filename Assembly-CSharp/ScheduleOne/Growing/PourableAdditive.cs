using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008C0 RID: 2240
	[Token(Token = "0x20008C0")]
	public class PourableAdditive : Pourable
	{
		// Token: 0x06003B54 RID: 15188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B54")]
		[Address(RVA = "0x81A300", Offset = "0x819500", VA = "0x18081A300", Slot = "16")]
		protected override void PourAmount(float amount)
		{
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x6D2000", Offset = "0x6D1200", VA = "0x1806D2000")]
		public PourableAdditive()
		{
		}

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		public const float NormalizedAmountForSuccess = 0.8f;

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x140")]
		public AdditiveDefinition AdditiveDefinition;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0x148")]
		public Color LiquidColor;

		// Token: 0x04002BDD RID: 11229
		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0x158")]
		private float pouredAmount;
	}
}
