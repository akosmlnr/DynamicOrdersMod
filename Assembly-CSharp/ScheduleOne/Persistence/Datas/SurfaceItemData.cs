using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x20004BB")]
	[Serializable]
	public class SurfaceItemData : BuildableItemData
	{
		// Token: 0x06001B0D RID: 6925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x6194E0", Offset = "0x6186E0", VA = "0x1806194E0")]
		public SurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x0400171A RID: 5914
		[Token(Token = "0x400171A")]
		[FieldOffset(Offset = "0x40")]
		public string ParentSurfaceGUID;

		// Token: 0x0400171B RID: 5915
		[Token(Token = "0x400171B")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 RelativePosition;

		// Token: 0x0400171C RID: 5916
		[Token(Token = "0x400171C")]
		[FieldOffset(Offset = "0x54")]
		public Quaternion RelativeRotation;
	}
}
