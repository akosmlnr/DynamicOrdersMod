using System;
using System.Collections.Generic;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Trash;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x020009E5 RID: 2533
	[Token(Token = "0x20009E5")]
	[Serializable]
	public class TrashGrabberInstance : StorableItemInstance
	{
		// Token: 0x06004899 RID: 18585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004899")]
		[Address(RVA = "0x915780", Offset = "0x914980", VA = "0x180915780")]
		public TrashGrabberInstance(ItemDefinition definition, int quantity)
		{
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600489A")]
		[Address(RVA = "0x914C50", Offset = "0x913E50", VA = "0x180914C50", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600489B")]
		[Address(RVA = "0x915380", Offset = "0x914580", VA = "0x180915380")]
		public void LoadContentData(TrashContentData content)
		{
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600489C")]
		[Address(RVA = "0x914D10", Offset = "0x913F10", VA = "0x180914D10", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600489D")]
		[Address(RVA = "0x914BF0", Offset = "0x913DF0", VA = "0x180914BF0")]
		public void AddTrash(string id, int quantity)
		{
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600489E")]
		[Address(RVA = "0x915510", Offset = "0x914710", VA = "0x180915510")]
		public void RemoveTrash(string id, int quantity)
		{
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600489F")]
		[Address(RVA = "0x914C20", Offset = "0x913E20", VA = "0x180914C20")]
		public void ClearTrash()
		{
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x00013A70 File Offset: 0x00011C70
		[Token(Token = "0x60048A0")]
		[Address(RVA = "0x914DB0", Offset = "0x913FB0", VA = "0x180914DB0")]
		public int GetTotalSize()
		{
			return 0;
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60048A1")]
		[Address(RVA = "0x914DD0", Offset = "0x913FD0", VA = "0x180914DD0")]
		public List<string> GetTrashIDs()
		{
			return null;
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x914FC0", Offset = "0x9141C0", VA = "0x180914FC0")]
		public List<int> GetTrashQuantities()
		{
			return null;
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60048A3")]
		[Address(RVA = "0x9151A0", Offset = "0x9143A0", VA = "0x1809151A0")]
		public List<ushort> GetTrashUshortQuantities()
		{
			return null;
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A4")]
		[Address(RVA = "0x915540", Offset = "0x914740", VA = "0x180915540", Slot = "18")]
		public override void Write(Writer writer)
		{
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x9153A0", Offset = "0x9145A0", VA = "0x1809153A0", Slot = "19")]
		public override void Read(Reader reader)
		{
		}

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		public const int TRASH_CAPACITY = 20;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		[FieldOffset(Offset = "0x30")]
		private TrashContent Content;
	}
}
