using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000631 RID: 1585
	[Token(Token = "0x2000631")]
	public class ItemRemover : MonoBehaviour
	{
		// Token: 0x060026EC RID: 9964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EC")]
		[Address(RVA = "0x6C5940", Offset = "0x6C4B40", VA = "0x1806C5940")]
		public void Remove()
		{
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026ED")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ItemRemover()
		{
		}

		// Token: 0x04001E6C RID: 7788
		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x20")]
		public ItemDefinition Item;

		// Token: 0x04001E6D RID: 7789
		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x28")]
		public int Quantity;
	}
}
