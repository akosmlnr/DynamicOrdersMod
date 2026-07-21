using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008E9 RID: 2281
	[Token(Token = "0x20008E9")]
	public class LiquidLevelVisuals : MonoBehaviour
	{
		// Token: 0x06003CCA RID: 15562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CCA")]
		[Address(RVA = "0x82D190", Offset = "0x82C390", VA = "0x18082D190")]
		private void Update()
		{
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CCB")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public LiquidLevelVisuals()
		{
		}

		// Token: 0x04002CA4 RID: 11428
		[Token(Token = "0x4002CA4")]
		[FieldOffset(Offset = "0x20")]
		public LiquidContainer Container;

		// Token: 0x04002CA5 RID: 11429
		[Token(Token = "0x4002CA5")]
		[FieldOffset(Offset = "0x28")]
		public Transform LiquidSurface;

		// Token: 0x04002CA6 RID: 11430
		[Token(Token = "0x4002CA6")]
		[FieldOffset(Offset = "0x30")]
		public Transform LiquidSurface_Min;

		// Token: 0x04002CA7 RID: 11431
		[Token(Token = "0x4002CA7")]
		[FieldOffset(Offset = "0x38")]
		public Transform LiquidSurface_Max;
	}
}
