using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D75 RID: 3445
	[Token(Token = "0x2000D75")]
	public class DryingRackConfigPanel : ConfigPanel
	{
		// Token: 0x0600639B RID: 25499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600639B")]
		[Address(RVA = "0xA5CE40", Offset = "0xA5C040", VA = "0x180A5CE40", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600639C")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public DryingRackConfigPanel()
		{
		}

		// Token: 0x040045CB RID: 17867
		[Token(Token = "0x40045CB")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public QualityFieldUI QualityUI;

		// Token: 0x040045CC RID: 17868
		[Token(Token = "0x40045CC")]
		[FieldOffset(Offset = "0x28")]
		public ObjectFieldUI DestinationUI;

		// Token: 0x040045CD RID: 17869
		[Token(Token = "0x40045CD")]
		[FieldOffset(Offset = "0x30")]
		public NumberFieldUI StartThresholdUI;
	}
}
