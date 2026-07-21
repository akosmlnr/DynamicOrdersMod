using System;
using Il2CppDummyDll;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E27 RID: 3623
	[Token(Token = "0x2000E27")]
	public struct ExplosionData
	{
		// Token: 0x060067EE RID: 26606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067EE")]
		[Address(RVA = "0xAA9880", Offset = "0xAA8A80", VA = "0x180AA9880")]
		public ExplosionData(float damageRadius, float maxDamage, float maxPushForce, bool checkLoS, EExplosionType explosionType = EExplosionType.Default)
		{
		}

		// Token: 0x04004972 RID: 18802
		[Token(Token = "0x4004972")]
		[FieldOffset(Offset = "0x0")]
		public float DamageRadius;

		// Token: 0x04004973 RID: 18803
		[Token(Token = "0x4004973")]
		[FieldOffset(Offset = "0x4")]
		public float MaxDamage;

		// Token: 0x04004974 RID: 18804
		[Token(Token = "0x4004974")]
		[FieldOffset(Offset = "0x8")]
		public float PushForceRadius;

		// Token: 0x04004975 RID: 18805
		[Token(Token = "0x4004975")]
		[FieldOffset(Offset = "0xC")]
		public float MaxPushForce;

		// Token: 0x04004976 RID: 18806
		[Token(Token = "0x4004976")]
		[FieldOffset(Offset = "0x10")]
		public bool CheckLoS;

		// Token: 0x04004977 RID: 18807
		[Token(Token = "0x4004977")]
		[FieldOffset(Offset = "0x14")]
		public EExplosionType ExplosionType;

		// Token: 0x04004978 RID: 18808
		[Token(Token = "0x4004978")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ExplosionData DefaultSmall;

		// Token: 0x04004979 RID: 18809
		[Token(Token = "0x4004979")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ExplosionData LightningStrike;
	}
}
