using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008BD RID: 2237
	[Token(Token = "0x20008BD")]
	public class PlantHarvestable : MonoBehaviour
	{
		// Token: 0x06003B4B RID: 15179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B4B")]
		[Address(RVA = "0x818270", Offset = "0x817470", VA = "0x180818270")]
		private void Awake()
		{
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B4C")]
		[Address(RVA = "0x8182D0", Offset = "0x8174D0", VA = "0x1808182D0", Slot = "4")]
		public virtual void Harvest(bool giveProduct = true)
		{
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x818920", Offset = "0x817B20", VA = "0x180818920")]
		public PlantHarvestable()
		{
		}

		// Token: 0x04002BD5 RID: 11221
		[Token(Token = "0x4002BD5")]
		[FieldOffset(Offset = "0x20")]
		public StorableItemDefinition Product;

		// Token: 0x04002BD6 RID: 11222
		[Token(Token = "0x4002BD6")]
		[FieldOffset(Offset = "0x28")]
		public int ProductQuantity;
	}
}
