using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x200049E")]
	public class NPCHealthData : SaveData
	{
		// Token: 0x06001AEF RID: 6895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0x613C50", Offset = "0x612E50", VA = "0x180613C50")]
		public NPCHealthData(float health, bool isDead, int daysPassedSinceDeath, int hoursSinceAttackedByPlayer)
		{
		}

		// Token: 0x040016C6 RID: 5830
		[Token(Token = "0x40016C6")]
		[FieldOffset(Offset = "0x28")]
		public float Health;

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsDead;

		// Token: 0x040016C8 RID: 5832
		[Token(Token = "0x40016C8")]
		[FieldOffset(Offset = "0x30")]
		public int DaysPassedSinceDeath;

		// Token: 0x040016C9 RID: 5833
		[Token(Token = "0x40016C9")]
		[FieldOffset(Offset = "0x34")]
		public int HoursSinceAttackedByPlayer;
	}
}
