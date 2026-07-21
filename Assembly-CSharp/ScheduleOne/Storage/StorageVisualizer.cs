using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008D2 RID: 2258
	[Token(Token = "0x20008D2")]
	public class StorageVisualizer : MonoBehaviour
	{
		// Token: 0x06003C30 RID: 15408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x826370", Offset = "0x825570", VA = "0x180826370", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x826190", Offset = "0x825390", VA = "0x180826190")]
		public void AddSlot(ItemSlot slot, bool update = false)
		{
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x826CA0", Offset = "0x825EA0", VA = "0x180826CA0")]
		public Dictionary<StorableItemInstance, int> GetVisualRepresentation()
		{
			return null;
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x826CF0", Offset = "0x825EF0", VA = "0x180826CF0", Slot = "5")]
		public virtual void RefreshVisuals()
		{
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x826620", Offset = "0x825820", VA = "0x180826620")]
		private List<StoredItem> EnsureSufficientStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			return null;
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x826450", Offset = "0x825650", VA = "0x180826450")]
		private void DestroyExcessStoredItems(StorableItemInstance item, int quantityRequirement)
		{
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x8269B0", Offset = "0x825BB0", VA = "0x1808269B0")]
		public Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			return null;
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x826CD0", Offset = "0x825ED0", VA = "0x180826CD0")]
		protected void QueueRefresh()
		{
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x81EE50", Offset = "0x81E050", VA = "0x18081EE50")]
		public StorageVisualizer()
		{
		}

		// Token: 0x04002C2E RID: 11310
		[Token(Token = "0x4002C2E")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public StorageGrid[] StorageGrids;

		// Token: 0x04002C2F RID: 11311
		[Token(Token = "0x4002C2F")]
		[FieldOffset(Offset = "0x28")]
		public Transform ItemContainer;

		// Token: 0x04002C30 RID: 11312
		[Token(Token = "0x4002C30")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Should storage visuals be fully recalculated when item(s) are removed?")]
		[Header("Settings")]
		public bool FullRefreshOnItemRemoved;

		// Token: 0x04002C31 RID: 11313
		[Token(Token = "0x4002C31")]
		[FieldOffset(Offset = "0x38")]
		protected List<ItemSlot> itemSlots;

		// Token: 0x04002C32 RID: 11314
		[Token(Token = "0x4002C32")]
		[FieldOffset(Offset = "0x40")]
		protected int totalFootprintCapacity;

		// Token: 0x04002C33 RID: 11315
		[Token(Token = "0x4002C33")]
		[FieldOffset(Offset = "0x48")]
		protected Dictionary<StorableItemInstance, List<StoredItem>> activeStoredItems;

		// Token: 0x04002C34 RID: 11316
		[Token(Token = "0x4002C34")]
		[FieldOffset(Offset = "0x50")]
		public bool BlockRefreshes;
	}
}
