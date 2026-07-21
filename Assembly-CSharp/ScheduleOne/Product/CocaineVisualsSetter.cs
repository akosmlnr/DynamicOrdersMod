using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000938 RID: 2360
	[Token(Token = "0x2000938")]
	public class CocaineVisualsSetter : ProductVisualsSetter
	{
		// Token: 0x06003F78 RID: 16248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F78")]
		[Address(RVA = "0x84FAE0", Offset = "0x84ECE0", VA = "0x18084FAE0", Slot = "4")]
		public override void ApplyVisuals(ProductDefinition definition)
		{
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F79")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CocaineVisualsSetter()
		{
		}

		// Token: 0x04002E22 RID: 11810
		[Token(Token = "0x4002E22")]
		[FieldOffset(Offset = "0x28")]
		public MeshRenderer[] RockMeshes;
	}
}
