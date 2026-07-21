using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020006AC RID: 1708
	[Token(Token = "0x20006AC")]
	[Serializable]
	public class CustomerAffinityData
	{
		// Token: 0x06002CB2 RID: 11442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x71EC50", Offset = "0x71DE50", VA = "0x18071EC50")]
		public void CopyTo(CustomerAffinityData data)
		{
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x0000E040 File Offset: 0x0000C240
		[Token(Token = "0x6002CB3")]
		[Address(RVA = "0x71EF60", Offset = "0x71E160", VA = "0x18071EF60")]
		public float GetAffinity(EDrugType type)
		{
			return 0f;
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CB4")]
		[Address(RVA = "0x71F0D0", Offset = "0x71E2D0", VA = "0x18071F0D0")]
		public CustomerAffinityData()
		{
		}

		// Token: 0x04002151 RID: 8529
		[Token(Token = "0x4002151")]
		[FieldOffset(Offset = "0x10")]
		[Header("Product Affinities - How much the customer likes each product type. -1 = hates, 0 = neutral, 1 = loves.")]
		public List<ProductTypeAffinity> ProductAffinities;
	}
}
