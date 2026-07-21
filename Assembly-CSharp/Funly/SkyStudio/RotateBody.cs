using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	public class RotateBody : MonoBehaviour
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00005910 File Offset: 0x00003B10
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A9")]
		public float SpinSpeed
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x8DBCC0", Offset = "0x8DAEC0", VA = "0x1808DBCC0")]
			set
			{
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00005928 File Offset: 0x00003B28
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AA")]
		public bool AllowSpinning
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x6466D0", Offset = "0x6458D0", VA = "0x1806466D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x8DBCB0", Offset = "0x8DAEB0", VA = "0x1808DBCB0")]
			set
			{
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x8DBB40", Offset = "0x8DAD40", VA = "0x1808DBB40")]
		public void UpdateOrbitBodyRotation()
		{
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RotateBody()
		{
		}

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		[FieldOffset(Offset = "0x20")]
		private float m_SpinSpeed;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		[FieldOffset(Offset = "0x24")]
		private bool m_AllowSpinning;
	}
}
