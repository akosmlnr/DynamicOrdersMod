using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x020009E4 RID: 2532
	[Token(Token = "0x20009E4")]
	[CreateAssetMenu(fileName = "TrashGrabberDefinition", menuName = "ScriptableObjects/Item Definitions/TrashGrabberDefinition", order = 1)]
	[Serializable]
	public class TrashGrabberDefinition : StorableItemDefinition
	{
		// Token: 0x06004897 RID: 18583 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004897")]
		[Address(RVA = "0x914B80", Offset = "0x913D80", VA = "0x180914B80", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004898")]
		[Address(RVA = "0x6B99C0", Offset = "0x6B8BC0", VA = "0x1806B99C0")]
		public TrashGrabberDefinition()
		{
		}
	}
}
