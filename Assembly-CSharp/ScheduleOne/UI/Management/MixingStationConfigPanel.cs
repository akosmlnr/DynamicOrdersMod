using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D77 RID: 3447
	[Token(Token = "0x2000D77")]
	public class MixingStationConfigPanel : ConfigPanel
	{
		// Token: 0x0600639F RID: 25503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600639F")]
		[Address(RVA = "0xA65F20", Offset = "0xA65120", VA = "0x180A65F20", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A0")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public MixingStationConfigPanel()
		{
		}

		// Token: 0x040045CF RID: 17871
		[Token(Token = "0x40045CF")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI DestinationUI;

		// Token: 0x040045D0 RID: 17872
		[Token(Token = "0x40045D0")]
		[FieldOffset(Offset = "0x28")]
		public NumberFieldUI StartThresholdUI;
	}
}
