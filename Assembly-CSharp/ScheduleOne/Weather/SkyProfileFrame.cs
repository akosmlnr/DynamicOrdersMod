using System;
using Funly.SkyStudio;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BAB RID: 2987
	[Token(Token = "0x2000BAB")]
	public class SkyProfileFrame
	{
		// Token: 0x060058D3 RID: 22739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058D3")]
		[Address(RVA = "0x9B5660", Offset = "0x9B4860", VA = "0x1809B5660")]
		public SkyProfileFrame(SkyProfile skyProfile, float timeOfDay)
		{
		}

		// Token: 0x04003B0D RID: 15117
		[Token(Token = "0x4003B0D")]
		[FieldOffset(Offset = "0x10")]
		public Color AmbientLightSkyColor;

		// Token: 0x04003B0E RID: 15118
		[Token(Token = "0x4003B0E")]
		[FieldOffset(Offset = "0x20")]
		public Color AmbientLightEquatorColor;

		// Token: 0x04003B0F RID: 15119
		[Token(Token = "0x4003B0F")]
		[FieldOffset(Offset = "0x30")]
		public Color AmbientLightGroundColor;

		// Token: 0x04003B10 RID: 15120
		[Token(Token = "0x4003B10")]
		[FieldOffset(Offset = "0x40")]
		public Color SkyUpperColor;

		// Token: 0x04003B11 RID: 15121
		[Token(Token = "0x4003B11")]
		[FieldOffset(Offset = "0x50")]
		public Color SkyMiddleColor;

		// Token: 0x04003B12 RID: 15122
		[Token(Token = "0x4003B12")]
		[FieldOffset(Offset = "0x60")]
		public Color SkyLowerColor;

		// Token: 0x04003B13 RID: 15123
		[Token(Token = "0x4003B13")]
		[FieldOffset(Offset = "0x70")]
		public float SkyMiddleColorPosition;

		// Token: 0x04003B14 RID: 15124
		[Token(Token = "0x4003B14")]
		[FieldOffset(Offset = "0x74")]
		public float HorizonTrasitionStart;

		// Token: 0x04003B15 RID: 15125
		[Token(Token = "0x4003B15")]
		[FieldOffset(Offset = "0x78")]
		public float HorizonTransitionLength;

		// Token: 0x04003B16 RID: 15126
		[Token(Token = "0x4003B16")]
		[FieldOffset(Offset = "0x7C")]
		public float StarTransitionStart;

		// Token: 0x04003B17 RID: 15127
		[Token(Token = "0x4003B17")]
		[FieldOffset(Offset = "0x80")]
		public float StarTransitionLength;

		// Token: 0x04003B18 RID: 15128
		[Token(Token = "0x4003B18")]
		[FieldOffset(Offset = "0x84")]
		public float HorizonStarScale;
	}
}
