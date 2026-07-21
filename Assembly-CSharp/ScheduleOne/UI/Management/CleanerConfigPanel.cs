using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D74 RID: 3444
	[Token(Token = "0x2000D74")]
	public class CleanerConfigPanel : ConfigPanel
	{
		// Token: 0x06006399 RID: 25497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006399")]
		[Address(RVA = "0xA56C70", Offset = "0xA55E70", VA = "0x180A56C70", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600639A")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public CleanerConfigPanel()
		{
		}

		// Token: 0x040045C9 RID: 17865
		[Token(Token = "0x40045C9")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI BedUI;

		// Token: 0x040045CA RID: 17866
		[Token(Token = "0x40045CA")]
		[FieldOffset(Offset = "0x28")]
		public ObjectListFieldUI BinsUI;
	}
}
