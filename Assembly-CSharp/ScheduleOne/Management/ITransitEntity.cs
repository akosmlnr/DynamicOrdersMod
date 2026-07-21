using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000586 RID: 1414
	[Token(Token = "0x2000586")]
	public interface ITransitEntity
	{
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002057 RID: 8279
		[Token(Token = "0x170005BB")]
		string Name
		{
			[Token(Token = "0x6002057")]
			get;
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002058 RID: 8280
		// (set) Token: 0x06002059 RID: 8281
		[Token(Token = "0x170005BC")]
		List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6002058")]
			get;
			[Token(Token = "0x6002059")]
			set;
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600205A RID: 8282
		// (set) Token: 0x0600205B RID: 8283
		[Token(Token = "0x170005BD")]
		List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x600205A")]
			get;
			[Token(Token = "0x600205B")]
			set;
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600205C RID: 8284
		[Token(Token = "0x170005BE")]
		Transform LinkOrigin
		{
			[Token(Token = "0x600205C")]
			get;
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600205D RID: 8285
		[Token(Token = "0x170005BF")]
		Transform[] AccessPoints
		{
			[Token(Token = "0x600205D")]
			get;
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600205E RID: 8286
		[Token(Token = "0x170005C0")]
		bool Selectable
		{
			[Token(Token = "0x600205E")]
			get;
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600205F RID: 8287
		[Token(Token = "0x170005C1")]
		bool IsAcceptingItems
		{
			[Token(Token = "0x600205F")]
			get;
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002060 RID: 8288
		[Token(Token = "0x170005C2")]
		bool IsDestroyed
		{
			[Token(Token = "0x6002060")]
			get;
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002061 RID: 8289
		[Token(Token = "0x170005C3")]
		Guid GUID
		{
			[Token(Token = "0x6002061")]
			get;
		}

		// Token: 0x06002062 RID: 8290
		[Token(Token = "0x6002062")]
		void ShowOutline(Color color);

		// Token: 0x06002063 RID: 8291
		[Token(Token = "0x6002063")]
		void HideOutline();

		// Token: 0x06002064 RID: 8292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x672750", Offset = "0x671950", VA = "0x180672750", Slot = "13")]
		void InsertItemIntoInput(ItemInstance item, [Optional] NPC inserter)
		{
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002065")]
		[Address(RVA = "0x672A50", Offset = "0x671C50", VA = "0x180672A50", Slot = "14")]
		void InsertItemIntoOutput(ItemInstance item, [Optional] NPC inserter)
		{
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x6002066")]
		[Address(RVA = "0x671F10", Offset = "0x671110", VA = "0x180671F10", Slot = "15")]
		int GetInputCapacityForItem(ItemInstance item, [Optional] NPC asker, bool checkPlayerFilters = true)
		{
			return 0;
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x6002067")]
		[Address(RVA = "0x6722B0", Offset = "0x6714B0", VA = "0x1806722B0", Slot = "16")]
		int GetOutputCapacityForItem(ItemInstance item, [Optional] NPC asker)
		{
			return 0;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002068")]
		[Address(RVA = "0x672650", Offset = "0x671850", VA = "0x180672650", Slot = "17")]
		ItemSlot GetOutputItemContainer(ItemInstance item)
		{
			return null;
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002069")]
		[Address(RVA = "0x673030", Offset = "0x672230", VA = "0x180673030", Slot = "18")]
		List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker)
		{
			return null;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600206A")]
		[Address(RVA = "0x672DA0", Offset = "0x671FA0", VA = "0x180672DA0", Slot = "19")]
		void RemoveSlotLocks(NetworkObject locker)
		{
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600206B")]
		[Address(RVA = "0x671970", Offset = "0x670B70", VA = "0x180671970", Slot = "20")]
		ItemSlot GetFirstSlotContainingItem(string id, ITransitEntity.ESlotType searchType)
		{
			return null;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600206C")]
		[Address(RVA = "0x671C40", Offset = "0x670E40", VA = "0x180671C40", Slot = "21")]
		ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ITransitEntity.ESlotType searchType)
		{
			return null;
		}

		// Token: 0x02000587 RID: 1415
		[Token(Token = "0x2000587")]
		public enum ESlotType
		{
			// Token: 0x04001A57 RID: 6743
			[Token(Token = "0x4001A57")]
			Input,
			// Token: 0x04001A58 RID: 6744
			[Token(Token = "0x4001A58")]
			Output,
			// Token: 0x04001A59 RID: 6745
			[Token(Token = "0x4001A59")]
			Both
		}
	}
}
