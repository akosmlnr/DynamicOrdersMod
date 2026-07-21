using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A09 RID: 2569
	[Token(Token = "0x2000A09")]
	public abstract class PersistentSingleton<T> : Singleton<T> where T : Singleton<T>
	{
		// Token: 0x06004974 RID: 18804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004974")]
		protected override void Awake()
		{
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004975")]
		protected PersistentSingleton()
		{
		}
	}
}
