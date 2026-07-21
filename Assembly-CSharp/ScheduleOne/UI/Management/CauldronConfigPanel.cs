using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D71 RID: 3441
	[Token(Token = "0x2000D71")]
	public class CauldronConfigPanel : ConfigPanel
	{
		// Token: 0x06006393 RID: 25491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006393")]
		[Address(RVA = "0xA562E0", Offset = "0xA554E0", VA = "0x180A562E0", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006394")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public CauldronConfigPanel()
		{
		}

		// Token: 0x040045C4 RID: 17860
		[Token(Token = "0x40045C4")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
