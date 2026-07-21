using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D7A RID: 3450
	[Token(Token = "0x2000D7A")]
	public class PackagingStationConfigPanel : ConfigPanel
	{
		// Token: 0x060063A5 RID: 25509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A5")]
		[Address(RVA = "0xA6A250", Offset = "0xA69450", VA = "0x180A6A250", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A6")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public PackagingStationConfigPanel()
		{
		}

		// Token: 0x040045D9 RID: 17881
		[Token(Token = "0x40045D9")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
