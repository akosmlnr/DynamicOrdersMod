using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	[Serializable]
	public class EmployeeData : NPCData
	{
		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x604040", Offset = "0x603240", VA = "0x180604040")]
		public EmployeeData(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday)
		{
		}

		// Token: 0x040016D3 RID: 5843
		[Token(Token = "0x40016D3")]
		[FieldOffset(Offset = "0x30")]
		public string AssignedProperty;

		// Token: 0x040016D4 RID: 5844
		[Token(Token = "0x40016D4")]
		[FieldOffset(Offset = "0x38")]
		public string FirstName;

		// Token: 0x040016D5 RID: 5845
		[Token(Token = "0x40016D5")]
		[FieldOffset(Offset = "0x40")]
		public string LastName;

		// Token: 0x040016D6 RID: 5846
		[Token(Token = "0x40016D6")]
		[FieldOffset(Offset = "0x48")]
		public bool IsMale;

		// Token: 0x040016D7 RID: 5847
		[Token(Token = "0x40016D7")]
		[FieldOffset(Offset = "0x4C")]
		public int AppearanceIndex;

		// Token: 0x040016D8 RID: 5848
		[Token(Token = "0x40016D8")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 Position;

		// Token: 0x040016D9 RID: 5849
		[Token(Token = "0x40016D9")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion Rotation;

		// Token: 0x040016DA RID: 5850
		[Token(Token = "0x40016DA")]
		[FieldOffset(Offset = "0x70")]
		public string GUID;

		// Token: 0x040016DB RID: 5851
		[Token(Token = "0x40016DB")]
		[FieldOffset(Offset = "0x78")]
		public bool PaidForToday;
	}
}
