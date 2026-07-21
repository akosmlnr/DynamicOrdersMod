using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200048D RID: 1165
	[Token(Token = "0x200048D")]
	[Serializable]
	public class ObjectFieldData
	{
		// Token: 0x06001ADD RID: 6877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x471360", Offset = "0x470560", VA = "0x180471360")]
		public ObjectFieldData(string objectGUID)
		{
		}

		// Token: 0x040016A2 RID: 5794
		[Token(Token = "0x40016A2")]
		[FieldOffset(Offset = "0x10")]
		public string ObjectGUID;
	}
}
