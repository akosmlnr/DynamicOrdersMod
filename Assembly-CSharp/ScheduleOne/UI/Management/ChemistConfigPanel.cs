using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D72 RID: 3442
	[Token(Token = "0x2000D72")]
	public class ChemistConfigPanel : ConfigPanel
	{
		// Token: 0x06006395 RID: 25493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006395")]
		[Address(RVA = "0xA56540", Offset = "0xA55740", VA = "0x180A56540", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006396")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public ChemistConfigPanel()
		{
		}

		// Token: 0x040045C5 RID: 17861
		[Token(Token = "0x40045C5")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI BedUI;

		// Token: 0x040045C6 RID: 17862
		[Token(Token = "0x40045C6")]
		[FieldOffset(Offset = "0x28")]
		public ObjectListFieldUI StationsUI;
	}
}
