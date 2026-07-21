using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	[Serializable]
	public class MoveItemData
	{
		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x6135B0", Offset = "0x6127B0", VA = "0x1806135B0")]
		public MoveItemData(string templateItemJson, int grabbedItemQuantity, Guid sourceGUID, Guid destinationGUID)
		{
		}

		// Token: 0x040016DC RID: 5852
		[Token(Token = "0x40016DC")]
		[FieldOffset(Offset = "0x10")]
		public string TemplateItemJSON;

		// Token: 0x040016DD RID: 5853
		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0x18")]
		public int GrabbedItemQuantity;

		// Token: 0x040016DE RID: 5854
		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0x20")]
		public string SourceGUID;

		// Token: 0x040016DF RID: 5855
		[Token(Token = "0x40016DF")]
		[FieldOffset(Offset = "0x28")]
		public string DestinationGUID;
	}
}
