using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007B3 RID: 1971
	[Token(Token = "0x20007B3")]
	public abstract class BuildStart_Base : MonoBehaviour
	{
		// Token: 0x060034B9 RID: 13497
		[Token(Token = "0x60034B9")]
		public abstract void StartBuilding(ItemInstance item);

		// Token: 0x060034BA RID: 13498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		protected BuildStart_Base()
		{
		}
	}
}
