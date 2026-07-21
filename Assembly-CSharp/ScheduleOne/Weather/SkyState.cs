using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BAD RID: 2989
	[Token(Token = "0x2000BAD")]
	public class SkyState
	{
		// Token: 0x060058E9 RID: 22761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058E9")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public SkyState()
		{
		}

		// Token: 0x04003B2D RID: 15149
		[Token(Token = "0x4003B2D")]
		[FieldOffset(Offset = "0x10")]
		public Color SkyUpperColor;

		// Token: 0x04003B2E RID: 15150
		[Token(Token = "0x4003B2E")]
		[FieldOffset(Offset = "0x20")]
		public Color SkyMiddleColor;

		// Token: 0x04003B2F RID: 15151
		[Token(Token = "0x4003B2F")]
		[FieldOffset(Offset = "0x30")]
		public Color SkyLowerColor;

		// Token: 0x04003B30 RID: 15152
		[Token(Token = "0x4003B30")]
		[FieldOffset(Offset = "0x40")]
		public Color SunLightColor;

		// Token: 0x04003B31 RID: 15153
		[Token(Token = "0x4003B31")]
		[FieldOffset(Offset = "0x50")]
		public Color SunColor;

		// Token: 0x04003B32 RID: 15154
		[Token(Token = "0x4003B32")]
		[FieldOffset(Offset = "0x60")]
		public Color MoonLightColor;

		// Token: 0x04003B33 RID: 15155
		[Token(Token = "0x4003B33")]
		[FieldOffset(Offset = "0x70")]
		public Color MoonColor;

		// Token: 0x04003B34 RID: 15156
		[Token(Token = "0x4003B34")]
		[FieldOffset(Offset = "0x80")]
		public Color AmbientSkyColor;

		// Token: 0x04003B35 RID: 15157
		[Token(Token = "0x4003B35")]
		[FieldOffset(Offset = "0x90")]
		public Color AmbientEquatorColor;

		// Token: 0x04003B36 RID: 15158
		[Token(Token = "0x4003B36")]
		[FieldOffset(Offset = "0xA0")]
		public Color AmbientGroundColor;

		// Token: 0x04003B37 RID: 15159
		[Token(Token = "0x4003B37")]
		[FieldOffset(Offset = "0xB0")]
		public float SunIntensity;

		// Token: 0x04003B38 RID: 15160
		[Token(Token = "0x4003B38")]
		[FieldOffset(Offset = "0xB4")]
		public float SunShadowStrength;

		// Token: 0x04003B39 RID: 15161
		[Token(Token = "0x4003B39")]
		[FieldOffset(Offset = "0xB8")]
		public float SunSize;

		// Token: 0x04003B3A RID: 15162
		[Token(Token = "0x4003B3A")]
		[FieldOffset(Offset = "0xBC")]
		public float MoonIntensity;

		// Token: 0x04003B3B RID: 15163
		[Token(Token = "0x4003B3B")]
		[FieldOffset(Offset = "0xC0")]
		public float MoonShadowStrength;

		// Token: 0x04003B3C RID: 15164
		[Token(Token = "0x4003B3C")]
		[FieldOffset(Offset = "0xC4")]
		public float MoonSize;

		// Token: 0x04003B3D RID: 15165
		[Token(Token = "0x4003B3D")]
		[FieldOffset(Offset = "0xC8")]
		public Color FogColor;

		// Token: 0x04003B3E RID: 15166
		[Token(Token = "0x4003B3E")]
		[FieldOffset(Offset = "0xD8")]
		public float FogDensity;

		// Token: 0x04003B3F RID: 15167
		[Token(Token = "0x4003B3F")]
		[FieldOffset(Offset = "0xDC")]
		public Vector2 FogHeightFade;

		// Token: 0x04003B40 RID: 15168
		[Token(Token = "0x4003B40")]
		[FieldOffset(Offset = "0xE4")]
		public float WindIntensity;
	}
}
