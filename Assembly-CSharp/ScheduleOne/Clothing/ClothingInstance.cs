using System;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.Clothing
{
	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	[Serializable]
	public class ClothingInstance : StorableItemInstance
	{
		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007FE")]
		public override string Name
		{
			[Token(Token = "0x60030C8")]
			[Address(RVA = "0x75DF40", Offset = "0x75D140", VA = "0x18075DF40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C9")]
		[Address(RVA = "0x6C0DE0", Offset = "0x6BFFE0", VA = "0x1806C0DE0")]
		public ClothingInstance(ItemDefinition definition, int quantity, EClothingColor color)
		{
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030CA")]
		[Address(RVA = "0x75DD60", Offset = "0x75CF60", VA = "0x18075DD60", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030CB")]
		[Address(RVA = "0x75DDF0", Offset = "0x75CFF0", VA = "0x18075DDF0", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CC")]
		[Address(RVA = "0x75DF00", Offset = "0x75D100", VA = "0x18075DF00", Slot = "18")]
		public override void Write(Writer writer)
		{
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CD")]
		[Address(RVA = "0x75DE80", Offset = "0x75D080", VA = "0x18075DE80", Slot = "19")]
		public override void Read(Reader reader)
		{
		}

		// Token: 0x040023DF RID: 9183
		[Token(Token = "0x40023DF")]
		[FieldOffset(Offset = "0x30")]
		public EClothingColor Color;
	}
}
