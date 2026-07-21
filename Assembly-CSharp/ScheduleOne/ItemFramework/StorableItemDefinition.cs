using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Levelling;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x0200063F RID: 1599
	[Token(Token = "0x200063F")]
	[CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/StorableItemDefinition", order = 1)]
	[Serializable]
	public class StorableItemDefinition : ItemDefinition
	{
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x170006D8")]
		public bool IsUnlocked
		{
			[Token(Token = "0x600275F")]
			[Address(RVA = "0x62A7B0", Offset = "0x6299B0", VA = "0x18062A7B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002760")]
		[Address(RVA = "0x6CE750", Offset = "0x6CD950", VA = "0x1806CE750", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x6CE7C0", Offset = "0x6CD9C0", VA = "0x1806CE7C0", Slot = "6")]
		protected virtual bool GetIsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x6CE870", Offset = "0x6CDA70", VA = "0x1806CE870")]
		public StorableItemDefinition()
		{
		}

		// Token: 0x04001E9D RID: 7837
		[Token(Token = "0x4001E9D")]
		[FieldOffset(Offset = "0x78")]
		[Header("Purchasing")]
		public float BasePurchasePrice;

		// Token: 0x04001E9E RID: 7838
		[Token(Token = "0x4001E9E")]
		[FieldOffset(Offset = "0x80")]
		public List<ShopListing.CategoryInstance> ShopCategories;

		// Token: 0x04001E9F RID: 7839
		[Token(Token = "0x4001E9F")]
		[FieldOffset(Offset = "0x88")]
		[Header("Unlocking")]
		public bool RequiresLevelToPurchase;

		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0x8C")]
		public FullRank RequiredRank;

		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x4001EA1")]
		[FieldOffset(Offset = "0x94")]
		[Header("Reselling")]
		[Range(0f, 1f)]
		public float ResellMultiplier;

		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x4001EA2")]
		[FieldOffset(Offset = "0x98")]
		[Header("Storable Item")]
		public StoredItem StoredItem;

		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x4001EA3")]
		[FieldOffset(Offset = "0xA0")]
		[Range(0.1f, 5f)]
		public float PickpocketDifficultyMultiplier;

		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x4001EA4")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("Optional station item if this item can be used at a station.")]
		public StationItem StationItem;

		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x4001EA5")]
		[FieldOffset(Offset = "0xB0")]
		[FormerlySerializedAs("CombatUtilityForNPCs")]
		[Range(0f, 1f)]
		[Header("Other Settings")]
		public float CombatUtility;
	}
}
