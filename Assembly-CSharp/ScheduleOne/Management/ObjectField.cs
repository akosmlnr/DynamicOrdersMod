using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Management;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x200057E")]
	public class ObjectField : ConfigField
	{
		// Token: 0x06002011 RID: 8209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x646B30", Offset = "0x645D30", VA = "0x180646B30")]
		public ObjectField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x646930", Offset = "0x645B30", VA = "0x180646930")]
		public void SetObject(BuildableItem obj, bool network)
		{
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x6467E0", Offset = "0x6459E0", VA = "0x1806467E0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x646920", Offset = "0x645B20", VA = "0x180646920")]
		private void SelectedObjectDestroyed()
		{
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x646830", Offset = "0x645A30", VA = "0x180646830")]
		public void Load(ObjectFieldData data)
		{
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x646700", Offset = "0x645900", VA = "0x180646700")]
		public ObjectFieldData GetData()
		{
			return null;
		}

		// Token: 0x04001A3E RID: 6718
		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x18")]
		public BuildableItem SelectedObject;

		// Token: 0x04001A3F RID: 6719
		[Token(Token = "0x4001A3F")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<BuildableItem> onObjectChanged;

		// Token: 0x04001A40 RID: 6720
		[Token(Token = "0x4001A40")]
		[FieldOffset(Offset = "0x28")]
		public ObjectSelector.ObjectFilter objectFilter;

		// Token: 0x04001A41 RID: 6721
		[Token(Token = "0x4001A41")]
		[FieldOffset(Offset = "0x30")]
		public List<Type> TypeRequirements;

		// Token: 0x04001A42 RID: 6722
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x38")]
		public bool DrawTransitLine;
	}
}
