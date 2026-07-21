using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	public class ObjectListField : ConfigField
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x6477C0", Offset = "0x6469C0", VA = "0x1806477C0")]
		public ObjectListField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x647390", Offset = "0x646590", VA = "0x180647390")]
		public void SetList(List<BuildableItem> list, bool network)
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x646C00", Offset = "0x645E00", VA = "0x180646C00")]
		public void AddItem(BuildableItem item)
		{
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x6471B0", Offset = "0x6463B0", VA = "0x1806471B0")]
		public void RemoveItem(BuildableItem item)
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x647290", Offset = "0x646490", VA = "0x180647290")]
		private void SelectedObjectDestroyed(BuildableItem item)
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x646F80", Offset = "0x646180", VA = "0x180646F80", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x646DE0", Offset = "0x645FE0", VA = "0x180646DE0")]
		public ObjectListFieldData GetData()
		{
			return null;
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x646FD0", Offset = "0x6461D0", VA = "0x180646FD0")]
		public void Load(ObjectListFieldData data)
		{
		}

		// Token: 0x04001A43 RID: 6723
		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x18")]
		public List<BuildableItem> SelectedObjects;

		// Token: 0x04001A44 RID: 6724
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x20")]
		public int MaxItems;

		// Token: 0x04001A45 RID: 6725
		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x28")]
		public ObjectSelector.ObjectFilter objectFilter;

		// Token: 0x04001A46 RID: 6726
		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x30")]
		public List<Type> TypeRequirements;

		// Token: 0x04001A47 RID: 6727
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent<List<BuildableItem>> onListChanged;
	}
}
