using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004B0 RID: 1200
	[Token(Token = "0x20004B0")]
	public class LabelledSurfaceItemData : SurfaceItemData
	{
		// Token: 0x06001B02 RID: 6914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x606710", Offset = "0x605910", VA = "0x180606710")]
		public LabelledSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, string message)
		{
		}

		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		[FieldOffset(Offset = "0x68")]
		public string Message;
	}
}
