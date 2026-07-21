using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	public class HotbarSlot : ItemSlot
	{
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x0000B898 File Offset: 0x00009A98
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700060B")]
		public bool IsSelected
		{
			[Token(Token = "0x6002217")]
			[Address(RVA = "0x4E09C0", Offset = "0x4DFBC0", VA = "0x1804E09C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x4E0EB0", Offset = "0x4E00B0", VA = "0x1804E0EB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002219")]
		[Address(RVA = "0x6715A0", Offset = "0x6707A0", VA = "0x1806715A0", Slot = "4")]
		public override void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221A")]
		[Address(RVA = "0x671180", Offset = "0x670380", VA = "0x180671180", Slot = "7")]
		public override void ClearStoredInstance(bool _internal = false)
		{
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221B")]
		[Address(RVA = "0x6714E0", Offset = "0x6706E0", VA = "0x1806714E0", Slot = "14")]
		public virtual void Select()
		{
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221C")]
		[Address(RVA = "0x671280", Offset = "0x670480", VA = "0x180671280")]
		private void Equip()
		{
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221D")]
		[Address(RVA = "0x671650", Offset = "0x670850", VA = "0x180671650")]
		private void Unequip()
		{
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221E")]
		[Address(RVA = "0x6711C0", Offset = "0x6703C0", VA = "0x1806711C0", Slot = "15")]
		public virtual void Deselect()
		{
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x600221F")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "13")]
		public override bool CanSlotAcceptCash()
		{
			return default(bool);
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002220")]
		[Address(RVA = "0x671760", Offset = "0x670960", VA = "0x180671760")]
		public HotbarSlot()
		{
		}

		// Token: 0x04001BA3 RID: 7075
		[Token(Token = "0x4001BA3")]
		[FieldOffset(Offset = "0x80")]
		public HotbarSlot.EquipEvent onEquipChanged;

		// Token: 0x04001BA4 RID: 7076
		[Token(Token = "0x4001BA4")]
		[FieldOffset(Offset = "0x88")]
		private Equippable _equippable;

		// Token: 0x04001BA5 RID: 7077
		[Token(Token = "0x4001BA5")]
		[FieldOffset(Offset = "0x90")]
		private IEquippedItemHandler _equippedItem;

		// Token: 0x020005D1 RID: 1489
		// (Invoke) Token: 0x06002222 RID: 8738
		[Token(Token = "0x20005D1")]
		public delegate void EquipEvent(bool equipped);
	}
}
