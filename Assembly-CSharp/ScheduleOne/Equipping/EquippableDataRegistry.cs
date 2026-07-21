using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000965 RID: 2405
	[Token(Token = "0x2000965")]
	public class EquippableDataRegistry : PersistentSingleton<EquippableDataRegistry>
	{
		// Token: 0x06004054 RID: 16468 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004054")]
		[Address(RVA = "0x8501B0", Offset = "0x84F3B0", VA = "0x1808501B0")]
		public EquippableData GetEquippableData(Guid guid)
		{
			return null;
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004055")]
		[Address(RVA = "0x8503B0", Offset = "0x84F5B0", VA = "0x1808503B0")]
		private void RegisterEquippableData(EquippableData data)
		{
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004056")]
		[Address(RVA = "0x850530", Offset = "0x84F730", VA = "0x180850530")]
		public EquippableDataRegistry()
		{
		}

		// Token: 0x04002F01 RID: 12033
		[Token(Token = "0x4002F01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ReadOnly]
		private List<EquippableData> _equippableDataList;
	}
}
