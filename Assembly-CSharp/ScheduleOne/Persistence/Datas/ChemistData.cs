using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	[Serializable]
	public class ChemistData : EmployeeData
	{
		// Token: 0x06001AF1 RID: 6897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x602240", Offset = "0x601440", VA = "0x180602240")]
		public ChemistData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData)
		{
		}

		// Token: 0x040016CB RID: 5835
		[Token(Token = "0x40016CB")]
		[FieldOffset(Offset = "0x80")]
		public MoveItemData MoveItemData;
	}
}
