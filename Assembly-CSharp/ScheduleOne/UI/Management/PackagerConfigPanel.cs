using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D79 RID: 3449
	[Token(Token = "0x2000D79")]
	public class PackagerConfigPanel : ConfigPanel
	{
		// Token: 0x060063A3 RID: 25507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A3")]
		[Address(RVA = "0xA69EE0", Offset = "0xA690E0", VA = "0x180A69EE0", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A4")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public PackagerConfigPanel()
		{
		}

		// Token: 0x040045D6 RID: 17878
		[Token(Token = "0x40045D6")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI BedUI;

		// Token: 0x040045D7 RID: 17879
		[Token(Token = "0x40045D7")]
		[FieldOffset(Offset = "0x28")]
		public ObjectListFieldUI StationsUI;

		// Token: 0x040045D8 RID: 17880
		[Token(Token = "0x40045D8")]
		[FieldOffset(Offset = "0x30")]
		public RouteListFieldUI RoutesUI;
	}
}
