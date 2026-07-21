using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000462 RID: 1122
	[Token(Token = "0x2000462")]
	public class GameData : SaveData
	{
		// Token: 0x06001AA3 RID: 6819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x604180", Offset = "0x603380", VA = "0x180604180")]
		public GameData(string organisationName, int seed, GameSettings settings)
		{
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x6041E0", Offset = "0x6033E0", VA = "0x1806041E0")]
		public GameData()
		{
		}

		// Token: 0x0400165E RID: 5726
		[Token(Token = "0x400165E")]
		[FieldOffset(Offset = "0x28")]
		public string OrganisationName;

		// Token: 0x0400165F RID: 5727
		[Token(Token = "0x400165F")]
		[FieldOffset(Offset = "0x30")]
		public int Seed;

		// Token: 0x04001660 RID: 5728
		[Token(Token = "0x4001660")]
		[FieldOffset(Offset = "0x38")]
		public GameSettings Settings;
	}
}
