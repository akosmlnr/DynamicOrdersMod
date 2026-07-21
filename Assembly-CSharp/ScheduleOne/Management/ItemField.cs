using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200057B RID: 1403
	[Token(Token = "0x200057B")]
	public class ItemField : ConfigField
	{
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A5")]
		public ItemDefinition SelectedItem
		{
			[Token(Token = "0x6001FF4")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FF5")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x643F60", Offset = "0x643160", VA = "0x180643F60")]
		public ItemField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x643EC0", Offset = "0x6430C0", VA = "0x180643EC0")]
		public void SetItem(ItemDefinition item, bool network)
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x643DE0", Offset = "0x642FE0", VA = "0x180643DE0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x643D10", Offset = "0x642F10", VA = "0x180643D10")]
		public ItemFieldData GetData()
		{
			return null;
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x643E30", Offset = "0x643030", VA = "0x180643E30")]
		public void Load(ItemFieldData data)
		{
		}

		// Token: 0x04001A33 RID: 6707
		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0x20")]
		public bool CanSelectNone;

		// Token: 0x04001A34 RID: 6708
		[Token(Token = "0x4001A34")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemDefinition> Options;

		// Token: 0x04001A35 RID: 6709
		[Token(Token = "0x4001A35")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<ItemDefinition> onItemChanged;
	}
}
