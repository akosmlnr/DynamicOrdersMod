using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020004C1 RID: 1217
	[Token(Token = "0x20004C1")]
	[Serializable]
	public class PlayerData : SaveData
	{
		// Token: 0x06001B13 RID: 6931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x615330", Offset = "0x614530", VA = "0x180615330")]
		public PlayerData(string playerCode, Vector3 playerPos, float playerRot, bool introCompleted)
		{
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x6152D0", Offset = "0x6144D0", VA = "0x1806152D0")]
		public PlayerData()
		{
		}

		// Token: 0x04001725 RID: 5925
		[Token(Token = "0x4001725")]
		[FieldOffset(Offset = "0x28")]
		public string PlayerCode;

		// Token: 0x04001726 RID: 5926
		[Token(Token = "0x4001726")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 Position;

		// Token: 0x04001727 RID: 5927
		[Token(Token = "0x4001727")]
		[FieldOffset(Offset = "0x3C")]
		public float Rotation;

		// Token: 0x04001728 RID: 5928
		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x40")]
		public bool IntroCompleted;
	}
}
