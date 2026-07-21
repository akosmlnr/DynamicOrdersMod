using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000356 RID: 854
	[Token(Token = "0x2000356")]
	public class SystemTriggerObject : MonoBehaviour
	{
		// Token: 0x060014DB RID: 5339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x5ACF90", Offset = "0x5AC190", VA = "0x1805ACF90")]
		[Button]
		public void Trigger()
		{
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SystemTriggerObject()
		{
		}

		// Token: 0x040012D4 RID: 4820
		[Token(Token = "0x40012D4")]
		[FieldOffset(Offset = "0x20")]
		public SystemTrigger SystemTrigger;
	}
}
