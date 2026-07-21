using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000458 RID: 1112
	[Token(Token = "0x2000458")]
	[Serializable]
	public class AvatarAppearanceData : SaveData
	{
		// Token: 0x06001A8F RID: 6799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x602190", Offset = "0x601390", VA = "0x180602190")]
		public AvatarAppearanceData(AvatarSettings avatarSettings)
		{
		}

		// Token: 0x04001638 RID: 5688
		[Token(Token = "0x4001638")]
		[FieldOffset(Offset = "0x28")]
		public AvatarSettings AvatarSettings;
	}
}
