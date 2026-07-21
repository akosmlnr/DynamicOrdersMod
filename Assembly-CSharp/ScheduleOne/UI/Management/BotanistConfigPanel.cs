using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D6F RID: 3439
	[Token(Token = "0x2000D6F")]
	public class BotanistConfigPanel : ConfigPanel
	{
		// Token: 0x0600638F RID: 25487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600638F")]
		[Address(RVA = "0xA55D30", Offset = "0xA54F30", VA = "0x180A55D30", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006390")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public BotanistConfigPanel()
		{
		}

		// Token: 0x040045C0 RID: 17856
		[Token(Token = "0x40045C0")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI BedUI;

		// Token: 0x040045C1 RID: 17857
		[Token(Token = "0x40045C1")]
		[FieldOffset(Offset = "0x28")]
		public ObjectFieldUI SuppliesUI;

		// Token: 0x040045C2 RID: 17858
		[Token(Token = "0x40045C2")]
		[FieldOffset(Offset = "0x30")]
		public ObjectListFieldUI PotsUI;
	}
}
