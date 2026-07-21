using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D78 RID: 3448
	[Token(Token = "0x2000D78")]
	public class MushroomBedConfigPanel : ConfigPanel
	{
		// Token: 0x060063A1 RID: 25505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A1")]
		[Address(RVA = "0xA66210", Offset = "0xA65410", VA = "0x180A66210", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A2")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public MushroomBedConfigPanel()
		{
		}

		// Token: 0x040045D1 RID: 17873
		[Token(Token = "0x40045D1")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ItemFieldUI SpawnUI;

		// Token: 0x040045D2 RID: 17874
		[Token(Token = "0x40045D2")]
		[FieldOffset(Offset = "0x28")]
		public ItemFieldUI Additive1UI;

		// Token: 0x040045D3 RID: 17875
		[Token(Token = "0x40045D3")]
		[FieldOffset(Offset = "0x30")]
		public ItemFieldUI Additive2UI;

		// Token: 0x040045D4 RID: 17876
		[Token(Token = "0x40045D4")]
		[FieldOffset(Offset = "0x38")]
		public ItemFieldUI Additive3UI;

		// Token: 0x040045D5 RID: 17877
		[Token(Token = "0x40045D5")]
		[FieldOffset(Offset = "0x40")]
		public ObjectFieldUI DestinationUI;
	}
}
