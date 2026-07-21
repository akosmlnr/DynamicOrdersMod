using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	[Serializable]
	public class CleanerData : EmployeeData
	{
		// Token: 0x06001AF2 RID: 6898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x602240", Offset = "0x601440", VA = "0x180602240")]
		public CleanerData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData)
		{
		}

		// Token: 0x040016CC RID: 5836
		[Token(Token = "0x40016CC")]
		[FieldOffset(Offset = "0x80")]
		public MoveItemData MoveItemData;
	}
}
