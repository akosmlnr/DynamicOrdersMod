using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	[Serializable]
	public class PackagerData : EmployeeData
	{
		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x602240", Offset = "0x601440", VA = "0x180602240")]
		public PackagerData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData)
		{
		}

		// Token: 0x040016E0 RID: 5856
		[Token(Token = "0x40016E0")]
		[FieldOffset(Offset = "0x80")]
		public MoveItemData MoveItemData;
	}
}
