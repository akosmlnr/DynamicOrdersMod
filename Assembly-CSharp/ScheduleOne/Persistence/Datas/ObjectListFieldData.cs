using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	[Serializable]
	public class ObjectListFieldData
	{
		// Token: 0x06001ADE RID: 6878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x471360", Offset = "0x470560", VA = "0x180471360")]
		public ObjectListFieldData(List<string> objectGUIDs)
		{
		}

		// Token: 0x040016A3 RID: 5795
		[Token(Token = "0x40016A3")]
		[FieldOffset(Offset = "0x10")]
		public List<string> ObjectGUIDs;
	}
}
