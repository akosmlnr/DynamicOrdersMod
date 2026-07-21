using System;
using System.Runtime.InteropServices;
using FishNet.Serializing;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000917 RID: 2327
	[Token(Token = "0x2000917")]
	[Serializable]
	public class ProductItemInstance : QualityItemInstance
	{
		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06003E1F RID: 15903 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009C3")]
		[CodegenExclude]
		public PackagingDefinition AppliedPackaging
		{
			[Token(Token = "0x6003E1F")]
			[Address(RVA = "0x83A160", Offset = "0x839360", VA = "0x18083A160")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06003E20 RID: 15904 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		[Token(Token = "0x170009C4")]
		[CodegenExclude]
		public int Amount
		{
			[Token(Token = "0x6003E20")]
			[Address(RVA = "0x83A0C0", Offset = "0x8392C0", VA = "0x18083A0C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009C5")]
		public override string Name
		{
			[Token(Token = "0x6003E21")]
			[Address(RVA = "0x83A450", Offset = "0x839650", VA = "0x18083A450", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009C6")]
		[CodegenExclude]
		public override Equippable Equippable
		{
			[Token(Token = "0x6003E22")]
			[Address(RVA = "0x839680", Offset = "0x838880", VA = "0x180839680", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009C7")]
		[CodegenExclude]
		public override StoredItem StoredItem
		{
			[Token(Token = "0x6003E23")]
			[Address(RVA = "0x839D80", Offset = "0x838F80", VA = "0x180839D80", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009C8")]
		[CodegenExclude]
		public override Sprite Icon
		{
			[Token(Token = "0x6003E24")]
			[Address(RVA = "0x83A330", Offset = "0x839530", VA = "0x18083A330", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E25")]
		[Address(RVA = "0x839FB0", Offset = "0x8391B0", VA = "0x180839FB0")]
		public ProductItemInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition _packaging)
		{
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		[Token(Token = "0x6003E26")]
		[Address(RVA = "0x838D70", Offset = "0x837F70", VA = "0x180838D70", Slot = "15")]
		public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return default(bool);
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E27")]
		[Address(RVA = "0x8395D0", Offset = "0x8387D0", VA = "0x1808395D0", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E28")]
		[Address(RVA = "0x839EB0", Offset = "0x8390B0", VA = "0x180839EB0", Slot = "21")]
		public virtual void SetPackaging(PackagingDefinition def)
		{
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E29")]
		[Address(RVA = "0x839680", Offset = "0x838880", VA = "0x180839680")]
		private Equippable GetEquippable()
		{
			return null;
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E2A")]
		[Address(RVA = "0x839D80", Offset = "0x838F80", VA = "0x180839D80")]
		private StoredItem GetStoredItem()
		{
			return null;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E2B")]
		[Address(RVA = "0x839720", Offset = "0x838920", VA = "0x180839720")]
		private Sprite GetIcon()
		{
			return null;
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x839840", Offset = "0x838A40", VA = "0x180839840", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x00011CD0 File Offset: 0x0000FED0
		[Token(Token = "0x6003E2D")]
		[Address(RVA = "0x839480", Offset = "0x838680", VA = "0x180839480", Slot = "22")]
		public virtual float GetAddictiveness()
		{
			return 0f;
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		[Token(Token = "0x6003E2E")]
		[Address(RVA = "0x839A80", Offset = "0x838C80", VA = "0x180839A80")]
		public float GetSimilarity(ProductDefinition other, EQuality otherQuality)
		{
			return 0f;
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E2F")]
		[Address(RVA = "0x838870", Offset = "0x837A70", VA = "0x180838870", Slot = "23")]
		public virtual void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x838F80", Offset = "0x838180", VA = "0x180838F80", Slot = "24")]
		public virtual void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x838AF0", Offset = "0x837CF0", VA = "0x180838AF0", Slot = "25")]
		public virtual void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x839200", Offset = "0x838400", VA = "0x180839200", Slot = "26")]
		public virtual void ClearEffectsFromPlayer(Player Player)
		{
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00011D00 File Offset: 0x0000FF00
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x839910", Offset = "0x838B10", VA = "0x180839910", Slot = "12")]
		public override float GetMonetaryValue()
		{
			return 0f;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00011D18 File Offset: 0x0000FF18
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x839E20", Offset = "0x839020", VA = "0x180839E20", Slot = "13")]
		public override int GetTotalAmount()
		{
			return 0;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E35")]
		[Address(RVA = "0x839F70", Offset = "0x839170", VA = "0x180839F70", Slot = "18")]
		public override void Write(Writer writer)
		{
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E36")]
		[Address(RVA = "0x839E50", Offset = "0x839050", VA = "0x180839E50", Slot = "19")]
		public override void Read(Reader reader)
		{
		}

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string PackagingID;

		// Token: 0x04002D95 RID: 11669
		[Token(Token = "0x4002D95")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[CodegenExclude]
		private PackagingDefinition packaging;
	}
}
