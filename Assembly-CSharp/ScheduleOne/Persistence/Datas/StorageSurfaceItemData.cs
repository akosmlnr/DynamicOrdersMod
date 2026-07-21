using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004BA RID: 1210
	[Token(Token = "0x20004BA")]
	public class StorageSurfaceItemData : SurfaceItemData
	{
		// Token: 0x06001B0C RID: 6924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x606710", Offset = "0x605910", VA = "0x180606710")]
		public StorageSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, ItemSet contents)
		{
		}

		// Token: 0x04001719 RID: 5913
		[Token(Token = "0x4001719")]
		[FieldOffset(Offset = "0x68")]
		public ItemSet Contents;
	}
}
