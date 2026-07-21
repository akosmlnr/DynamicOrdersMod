using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	[Serializable]
	public struct MinMaxRangeFloat : IEquatable<MinMaxRangeFloat>
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x170000E9")]
		public float minValue
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x4758E0", Offset = "0x474AE0", VA = "0x1804758E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x170000EA")]
		public float maxValue
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x4758D0", Offset = "0x474AD0", VA = "0x1804758D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x170000EB")]
		public float randomValue
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x4920E0", Offset = "0x4912E0", VA = "0x1804920E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x170000EC")]
		public Vector2 asVector2
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x49F1C0", Offset = "0x49E3C0", VA = "0x18049F1C0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x6980D0", Offset = "0x6972D0", VA = "0x1806980D0")]
		public float GetLerpedValue(float lerp01)
		{
			return 0f;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x698110", Offset = "0x697310", VA = "0x180698110")]
		public MinMaxRangeFloat(float min, float max)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x697F80", Offset = "0x697180", VA = "0x180697F80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x698020", Offset = "0x697220", VA = "0x180698020", Slot = "4")]
		public bool Equals(MinMaxRangeFloat other)
		{
			return default(bool);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x698050", Offset = "0x697250", VA = "0x180698050", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x698120", Offset = "0x697320", VA = "0x180698120")]
		public static bool operator ==(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			return default(bool);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x698160", Offset = "0x697360", VA = "0x180698160")]
		public static bool operator !=(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			return default(bool);
		}

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_MinValue;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float m_MaxValue;
	}
}
