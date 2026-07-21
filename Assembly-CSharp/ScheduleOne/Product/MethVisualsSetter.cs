using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000939 RID: 2361
	[Token(Token = "0x2000939")]
	public class MethVisualsSetter : ProductVisualsSetter
	{
		// Token: 0x06003F7A RID: 16250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x85DFC0", Offset = "0x85D1C0", VA = "0x18085DFC0", Slot = "4")]
		public override void ApplyVisuals(ProductDefinition definition)
		{
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F7B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MethVisualsSetter()
		{
		}

		// Token: 0x04002E23 RID: 11811
		[Token(Token = "0x4002E23")]
		[FieldOffset(Offset = "0x28")]
		public MeshRenderer[] CrystalMaterials;
	}
}
