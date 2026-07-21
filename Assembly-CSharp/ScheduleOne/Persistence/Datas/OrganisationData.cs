using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004BF RID: 1215
	[Token(Token = "0x20004BF")]
	[Serializable]
	public class OrganisationData : SaveData
	{
		// Token: 0x06001B11 RID: 6929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x6144A0", Offset = "0x6136A0", VA = "0x1806144A0")]
		public OrganisationData(string name, float netWorth)
		{
		}

		// Token: 0x04001720 RID: 5920
		[Token(Token = "0x4001720")]
		[FieldOffset(Offset = "0x28")]
		public string Name;

		// Token: 0x04001721 RID: 5921
		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x30")]
		public float NetWorth;
	}
}
