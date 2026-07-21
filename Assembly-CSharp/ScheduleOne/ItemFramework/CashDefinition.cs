using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	[CreateAssetMenu(fileName = "CashDefinition", menuName = "ScriptableObjects/CashDefinition", order = 1)]
	[Serializable]
	public class CashDefinition : StorableItemDefinition
	{
		// Token: 0x06002772 RID: 10098 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x6B99D0", Offset = "0x6B8BD0", VA = "0x1806B99D0", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x6B99C0", Offset = "0x6B8BC0", VA = "0x1806B99C0")]
		public CashDefinition()
		{
		}
	}
}
