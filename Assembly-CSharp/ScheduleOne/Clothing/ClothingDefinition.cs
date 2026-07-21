using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x02000747 RID: 1863
	[Token(Token = "0x2000747")]
	[CreateAssetMenu(fileName = "ClothingDefinition", menuName = "ScriptableObjects/ClothingDefinition", order = 1)]
	[Serializable]
	public class ClothingDefinition : StorableItemDefinition
	{
		// Token: 0x060030C6 RID: 12486 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030C6")]
		[Address(RVA = "0x75DC20", Offset = "0x75CE20", VA = "0x18075DC20", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x75DCA0", Offset = "0x75CEA0", VA = "0x18075DCA0")]
		public ClothingDefinition()
		{
		}

		// Token: 0x040023D9 RID: 9177
		[Token(Token = "0x40023D9")]
		[FieldOffset(Offset = "0xB8")]
		public EClothingSlot Slot;

		// Token: 0x040023DA RID: 9178
		[Token(Token = "0x40023DA")]
		[FieldOffset(Offset = "0xBC")]
		public EClothingApplicationType ApplicationType;

		// Token: 0x040023DB RID: 9179
		[Token(Token = "0x40023DB")]
		[FieldOffset(Offset = "0xC0")]
		public string ClothingAssetPath;

		// Token: 0x040023DC RID: 9180
		[Token(Token = "0x40023DC")]
		[FieldOffset(Offset = "0xC8")]
		public bool Colorable;

		// Token: 0x040023DD RID: 9181
		[Token(Token = "0x40023DD")]
		[FieldOffset(Offset = "0xCC")]
		public EClothingColor DefaultColor;

		// Token: 0x040023DE RID: 9182
		[Token(Token = "0x40023DE")]
		[FieldOffset(Offset = "0xD0")]
		public List<EClothingSlot> SlotsToBlock;
	}
}
