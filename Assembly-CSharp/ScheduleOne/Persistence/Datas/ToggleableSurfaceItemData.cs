using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004BD RID: 1213
	[Token(Token = "0x20004BD")]
	public class ToggleableSurfaceItemData : SurfaceItemData
	{
		// Token: 0x06001B0F RID: 6927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x61A3C0", Offset = "0x6195C0", VA = "0x18061A3C0")]
		public ToggleableSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, bool isOn)
		{
		}

		// Token: 0x0400171E RID: 5918
		[Token(Token = "0x400171E")]
		[FieldOffset(Offset = "0x68")]
		public bool IsOn;
	}
}
