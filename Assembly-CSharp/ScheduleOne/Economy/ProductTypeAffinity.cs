using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020006AB RID: 1707
	[Token(Token = "0x20006AB")]
	[Serializable]
	public class ProductTypeAffinity
	{
		// Token: 0x06002CB1 RID: 11441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public ProductTypeAffinity()
		{
		}

		// Token: 0x0400214F RID: 8527
		[Token(Token = "0x400214F")]
		[FieldOffset(Offset = "0x10")]
		public EDrugType DrugType;

		// Token: 0x04002150 RID: 8528
		[Token(Token = "0x4002150")]
		[FieldOffset(Offset = "0x14")]
		[Range(-1f, 1f)]
		public float Affinity;
	}
}
