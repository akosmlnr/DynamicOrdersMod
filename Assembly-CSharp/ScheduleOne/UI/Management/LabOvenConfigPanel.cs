using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D76 RID: 3446
	[Token(Token = "0x2000D76")]
	public class LabOvenConfigPanel : ConfigPanel
	{
		// Token: 0x0600639D RID: 25501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600639D")]
		[Address(RVA = "0xA5F290", Offset = "0xA5E490", VA = "0x180A5F290", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600639E")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public LabOvenConfigPanel()
		{
		}

		// Token: 0x040045CE RID: 17870
		[Token(Token = "0x40045CE")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
