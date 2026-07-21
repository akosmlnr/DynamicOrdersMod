using System;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product.Packaging
{
	// Token: 0x02000949 RID: 2377
	[Token(Token = "0x2000949")]
	[CreateAssetMenu(fileName = "PackagingDefinition", menuName = "ScriptableObjects/Item Definitions/PackagingDefinition", order = 1)]
	[Serializable]
	public class PackagingDefinition : StorableItemDefinition
	{
		// Token: 0x06003FB1 RID: 16305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB1")]
		[Address(RVA = "0x8615A0", Offset = "0x8607A0", VA = "0x1808615A0")]
		public PackagingDefinition()
		{
		}

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0xB8")]
		public int Quantity;

		// Token: 0x04002E58 RID: 11864
		[Token(Token = "0x4002E58")]
		[FieldOffset(Offset = "0xBC")]
		public EStealthLevel StealthLevel;

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0xC0")]
		public FunctionalPackaging FunctionalPackaging;

		// Token: 0x04002E5A RID: 11866
		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0xC8")]
		public Equippable Equippable_Filled;

		// Token: 0x04002E5B RID: 11867
		[Token(Token = "0x4002E5B")]
		[FieldOffset(Offset = "0xD0")]
		public StoredItem StoredItem_Filled;
	}
}
