using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	[Serializable]
	public class BotanistData : EmployeeData
	{
		// Token: 0x06001AF0 RID: 6896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0x602240", Offset = "0x601440", VA = "0x180602240")]
		public BotanistData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData)
		{
		}

		// Token: 0x040016CA RID: 5834
		[Token(Token = "0x40016CA")]
		[FieldOffset(Offset = "0x80")]
		public MoveItemData MoveItemData;
	}
}
