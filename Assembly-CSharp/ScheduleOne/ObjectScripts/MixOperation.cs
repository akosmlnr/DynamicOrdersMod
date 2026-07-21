using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Effects;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009B2 RID: 2482
	[Token(Token = "0x20009B2")]
	[Serializable]
	public class MixOperation
	{
		// Token: 0x06004579 RID: 17785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x8A2520", Offset = "0x8A1720", VA = "0x1808A2520")]
		public MixOperation(string productID, EQuality productQuality, string ingredientID, int quantity)
		{
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public MixOperation()
		{
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x600457B")]
		[Address(RVA = "0x8A2190", Offset = "0x8A1390", VA = "0x1808A2190")]
		public EDrugType GetOutput(out List<Effect> properties)
		{
			return EDrugType.Marijuana;
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x000132F0 File Offset: 0x000114F0
		[Token(Token = "0x600457C")]
		[Address(RVA = "0x8A2430", Offset = "0x8A1630", VA = "0x1808A2430")]
		public bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			return default(bool);
		}

		// Token: 0x040031B0 RID: 12720
		[Token(Token = "0x40031B0")]
		[FieldOffset(Offset = "0x10")]
		public string ProductID;

		// Token: 0x040031B1 RID: 12721
		[Token(Token = "0x40031B1")]
		[FieldOffset(Offset = "0x18")]
		public EQuality ProductQuality;

		// Token: 0x040031B2 RID: 12722
		[Token(Token = "0x40031B2")]
		[FieldOffset(Offset = "0x20")]
		public string IngredientID;

		// Token: 0x040031B3 RID: 12723
		[Token(Token = "0x40031B3")]
		[FieldOffset(Offset = "0x28")]
		public int Quantity;
	}
}
