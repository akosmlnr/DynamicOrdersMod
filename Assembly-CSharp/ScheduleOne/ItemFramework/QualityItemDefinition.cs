using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	[CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/QualityItemDefinition", order = 1)]
	[Serializable]
	public class QualityItemDefinition : StorableItemDefinition
	{
		// Token: 0x06002745 RID: 10053 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x6CC1D0", Offset = "0x6CB3D0", VA = "0x1806CC1D0", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x6CC250", Offset = "0x6CB450", VA = "0x1806CC250")]
		public QualityItemDefinition()
		{
		}

		// Token: 0x04001E8F RID: 7823
		[Token(Token = "0x4001E8F")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Quality")]
		public EQuality DefaultQuality;
	}
}
