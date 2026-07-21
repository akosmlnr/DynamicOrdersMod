using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E2B RID: 3627
	[Token(Token = "0x2000E2B")]
	[Serializable]
	public class Impact
	{
		// Token: 0x060067FF RID: 26623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FF")]
		[Address(RVA = "0xAB11D0", Offset = "0xAB03D0", VA = "0x180AB11D0")]
		public Impact(Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, NetworkObject impactSource, int impactID)
		{
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006800")]
		[Address(RVA = "0xAB12C0", Offset = "0xAB04C0", VA = "0x180AB12C0")]
		public Impact(Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, NetworkObject impactSource)
		{
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006801")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public Impact()
		{
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x00019500 File Offset: 0x00017700
		[Token(Token = "0x6006802")]
		[Address(RVA = "0xAB10C0", Offset = "0xAB02C0", VA = "0x180AB10C0")]
		public static bool IsLethal(EImpactType impactType)
		{
			return default(bool);
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x00019518 File Offset: 0x00017718
		[Token(Token = "0x6006803")]
		[Address(RVA = "0xAB10E0", Offset = "0xAB02E0", VA = "0x180AB10E0")]
		public bool IsPlayerImpact(out Player player)
		{
			return default(bool);
		}

		// Token: 0x04004981 RID: 18817
		[Token(Token = "0x4004981")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 HitPoint;

		// Token: 0x04004982 RID: 18818
		[Token(Token = "0x4004982")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 ImpactForceDirection;

		// Token: 0x04004983 RID: 18819
		[Token(Token = "0x4004983")]
		[FieldOffset(Offset = "0x28")]
		public float ImpactForce;

		// Token: 0x04004984 RID: 18820
		[Token(Token = "0x4004984")]
		[FieldOffset(Offset = "0x2C")]
		public float ImpactDamage;

		// Token: 0x04004985 RID: 18821
		[Token(Token = "0x4004985")]
		[FieldOffset(Offset = "0x30")]
		public EImpactType ImpactType;

		// Token: 0x04004986 RID: 18822
		[Token(Token = "0x4004986")]
		[FieldOffset(Offset = "0x38")]
		public NetworkObject ImpactSource;

		// Token: 0x04004987 RID: 18823
		[Token(Token = "0x4004987")]
		[FieldOffset(Offset = "0x40")]
		public int ImpactID;

		// Token: 0x04004988 RID: 18824
		[Token(Token = "0x4004988")]
		[FieldOffset(Offset = "0x44")]
		public EExplosionType ExplosionType;
	}
}
