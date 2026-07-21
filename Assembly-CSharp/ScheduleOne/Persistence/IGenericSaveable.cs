using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	public interface IGenericSaveable
	{
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001867 RID: 6247
		[Token(Token = "0x170004AB")]
		Guid GUID
		{
			[Token(Token = "0x6001867")]
			get;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x5CEF10", Offset = "0x5CE110", VA = "0x1805CEF10", Slot = "1")]
		void InitializeSaveable()
		{
		}

		// Token: 0x06001869 RID: 6249
		[Token(Token = "0x6001869")]
		void Load(GenericSaveData data);

		// Token: 0x0600186A RID: 6250
		[Token(Token = "0x600186A")]
		GenericSaveData GetSaveData();
	}
}
