using System;
using Il2CppDummyDll;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200098A RID: 2442
	[Token(Token = "0x200098A")]
	public class BrickPressContainer : MonoBehaviour
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x86DE20", Offset = "0x86D020", VA = "0x18086DE20")]
		public void SetContents(ProductItemInstance product, float fillLevel)
		{
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BrickPressContainer()
		{
		}

		// Token: 0x04002FBD RID: 12221
		[Token(Token = "0x4002FBD")]
		[FieldOffset(Offset = "0x20")]
		public MultiTypeVisualsSetter Visuals;

		// Token: 0x04002FBE RID: 12222
		[Token(Token = "0x4002FBE")]
		[FieldOffset(Offset = "0x28")]
		public Transform ContentsContainer;

		// Token: 0x04002FBF RID: 12223
		[Token(Token = "0x4002FBF")]
		[FieldOffset(Offset = "0x30")]
		public Transform Contents_Min;

		// Token: 0x04002FC0 RID: 12224
		[Token(Token = "0x4002FC0")]
		[FieldOffset(Offset = "0x38")]
		public Transform Contents_Max;
	}
}
