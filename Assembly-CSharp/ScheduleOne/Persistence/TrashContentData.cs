using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Trash;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003DE RID: 990
	[Token(Token = "0x20003DE")]
	[Serializable]
	public class TrashContentData
	{
		// Token: 0x060018FD RID: 6397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x5FC9E0", Offset = "0x5FBBE0", VA = "0x1805FC9E0")]
		public TrashContentData()
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x5FCA60", Offset = "0x5FBC60", VA = "0x1805FCA60")]
		public TrashContentData(string[] trashIDs, int[] trashQuantities)
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x5FC5B0", Offset = "0x5FB7B0", VA = "0x1805FC5B0")]
		public TrashContentData(List<TrashItem> trashItems)
		{
		}

		// Token: 0x040015B0 RID: 5552
		[Token(Token = "0x40015B0")]
		[FieldOffset(Offset = "0x10")]
		public string[] TrashIDs;

		// Token: 0x040015B1 RID: 5553
		[Token(Token = "0x40015B1")]
		[FieldOffset(Offset = "0x18")]
		public int[] TrashQuantities;
	}
}
