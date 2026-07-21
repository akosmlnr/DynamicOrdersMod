using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200062A RID: 1578
	[Token(Token = "0x200062A")]
	public class ItemGiver : MonoBehaviour
	{
		// Token: 0x060026CA RID: 9930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x6C4590", Offset = "0x6C3790", VA = "0x1806C4590")]
		public void Give()
		{
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ItemGiver()
		{
		}

		// Token: 0x04001E50 RID: 7760
		[Token(Token = "0x4001E50")]
		[FieldOffset(Offset = "0x20")]
		public ItemDefinition Item;

		// Token: 0x04001E51 RID: 7761
		[Token(Token = "0x4001E51")]
		[FieldOffset(Offset = "0x28")]
		public int Quantity;
	}
}
