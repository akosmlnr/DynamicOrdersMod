using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	[Serializable]
	public class BaseKeyframe : IComparable, IBaseKeyframe
	{
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BE")]
		public string id
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			set
			{
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00005BC8 File Offset: 0x00003DC8
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BF")]
		public float time
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x549260", Offset = "0x548460", VA = "0x180549260", Slot = "6")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x6466E0", Offset = "0x6458E0", VA = "0x1806466E0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00005BE0 File Offset: 0x00003DE0
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C0")]
		public InterpolationCurve interpolationCurve
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x4A0500", Offset = "0x49F700", VA = "0x1804A0500", Slot = "8")]
			get
			{
				return InterpolationCurve.Linear;
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x4A0510", Offset = "0x49F710", VA = "0x1804A0510", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00005BF8 File Offset: 0x00003DF8
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C1")]
		public InterpolationDirection interpolationDirection
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x492970", Offset = "0x491B70", VA = "0x180492970", Slot = "10")]
			get
			{
				return InterpolationDirection.Auto;
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x4929C0", Offset = "0x491BC0", VA = "0x1804929C0", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x8D0740", Offset = "0x8CF940", VA = "0x1808D0740")]
		public BaseKeyframe(float time)
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x8D0680", Offset = "0x8CF880", VA = "0x1808D0680", Slot = "4")]
		public int CompareTo(object other)
		{
			return 0;
		}

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string m_Id;

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_Time;

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private InterpolationCurve m_InterpolationCurve;

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InterpolationDirection m_InterpolationDirection;
	}
}
