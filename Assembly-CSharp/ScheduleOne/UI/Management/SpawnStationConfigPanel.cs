using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D7C RID: 3452
	[Token(Token = "0x2000D7C")]
	public class SpawnStationConfigPanel : ConfigPanel
	{
		// Token: 0x060063A9 RID: 25513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A9")]
		[Address(RVA = "0xA6C920", Offset = "0xA6BB20", VA = "0x180A6C920", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063AA")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public SpawnStationConfigPanel()
		{
		}

		// Token: 0x040045DF RID: 17887
		[Token(Token = "0x40045DF")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
