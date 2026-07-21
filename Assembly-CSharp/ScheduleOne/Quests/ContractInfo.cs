using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Economy;
using ScheduleOne.Product;

namespace ScheduleOne.Quests
{
	// Token: 0x0200032A RID: 810
	[Token(Token = "0x200032A")]
	[Serializable]
	public class ContractInfo
	{
		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FA")]
		public DeliveryLocation DeliveryLocation
		{
			[Token(Token = "0x600138C")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600138D")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138E")]
		[Address(RVA = "0x57CA50", Offset = "0x57BC50", VA = "0x18057CA50")]
		public ContractInfo(float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, int expiresAfter, int pickupScheduleIndex, bool isCounterOffer)
		{
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public ContractInfo()
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x57C590", Offset = "0x57B790", VA = "0x18057C590")]
		public DialogueChain ProcessMessage(DialogueChain messageChain)
		{
			return null;
		}

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		[FieldOffset(Offset = "0x10")]
		public float Payment;

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		[FieldOffset(Offset = "0x18")]
		public ProductList Products;

		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		[FieldOffset(Offset = "0x20")]
		public string DeliveryLocationGUID;

		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x40011FF")]
		[FieldOffset(Offset = "0x28")]
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x4001200")]
		[FieldOffset(Offset = "0x30")]
		public bool Expires;

		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001201")]
		[FieldOffset(Offset = "0x34")]
		public int ExpiresAfter;

		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001202")]
		[FieldOffset(Offset = "0x38")]
		public int PickupScheduleIndex;

		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001203")]
		[FieldOffset(Offset = "0x3C")]
		public bool IsCounterOffer;
	}
}
