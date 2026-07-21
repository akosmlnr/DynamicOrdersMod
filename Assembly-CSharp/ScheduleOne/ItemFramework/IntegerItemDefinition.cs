using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000626 RID: 1574
	[Token(Token = "0x2000626")]
	[CreateAssetMenu(fileName = "IntegerItemDefinition", menuName = "ScriptableObjects/IntegerItemDefinition", order = 1)]
	[Serializable]
	public class IntegerItemDefinition : StorableItemDefinition
	{
		// Token: 0x060026BF RID: 9919 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x6C0B10", Offset = "0x6BFD10", VA = "0x1806C0B10", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x6B99C0", Offset = "0x6B8BC0", VA = "0x1806B99C0")]
		public IntegerItemDefinition()
		{
		}

		// Token: 0x04001E46 RID: 7750
		[Token(Token = "0x4001E46")]
		[FieldOffset(Offset = "0xB8")]
		public int DefaultValue;
	}
}
