using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Items.Framework;
using ScheduleOne.Equipping;
using ScheduleOne.UI.Items;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000628 RID: 1576
	[Token(Token = "0x2000628")]
	[CreateAssetMenu(fileName = "ItemDefinition", menuName = "ScriptableObjects/ItemDefinition", order = 1)]
	[Serializable]
	public abstract class ItemDefinition : BaseItemDefinition
	{
		// Token: 0x060026C8 RID: 9928
		[Token(Token = "0x60026C8")]
		public abstract ItemInstance GetDefaultInstance(int quantity = 1);

		// Token: 0x060026C9 RID: 9929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x6C3AA0", Offset = "0x6C2CA0", VA = "0x1806C3AA0")]
		protected ItemDefinition()
		{
		}

		// Token: 0x04001E48 RID: 7752
		[Token(Token = "0x4001E48")]
		[FieldOffset(Offset = "0x58")]
		public bool AvailableInDemo;

		// Token: 0x04001E49 RID: 7753
		[Token(Token = "0x4001E49")]
		[FieldOffset(Offset = "0x5C")]
		[Header("Legacy Equipping Settings")]
		public ItemDefinition.EEquipMode EquipMode;

		// Token: 0x04001E4A RID: 7754
		[Token(Token = "0x4001E4A")]
		[FieldOffset(Offset = "0x60")]
		public Equippable Equippable;

		// Token: 0x04001E4B RID: 7755
		[Token(Token = "0x4001E4B")]
		[FieldOffset(Offset = "0x68")]
		[Header("UI Settings")]
		public ItemUI CustomItemUI;

		// Token: 0x04001E4C RID: 7756
		[Token(Token = "0x4001E4C")]
		[FieldOffset(Offset = "0x70")]
		public ItemInfoContent CustomInfoContent;

		// Token: 0x02000629 RID: 1577
		[Token(Token = "0x2000629")]
		public enum EEquipMode
		{
			// Token: 0x04001E4E RID: 7758
			[Token(Token = "0x4001E4E")]
			Legacy,
			// Token: 0x04001E4F RID: 7759
			[Token(Token = "0x4001E4F")]
			New
		}
	}
}
