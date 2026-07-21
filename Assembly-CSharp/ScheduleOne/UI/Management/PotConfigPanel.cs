using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D7B RID: 3451
	[Token(Token = "0x2000D7B")]
	public class PotConfigPanel : ConfigPanel
	{
		// Token: 0x060063A7 RID: 25511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A7")]
		[Address(RVA = "0xA6A4B0", Offset = "0xA696B0", VA = "0x180A6A4B0", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063A8")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public PotConfigPanel()
		{
		}

		// Token: 0x040045DA RID: 17882
		[Token(Token = "0x40045DA")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ItemFieldUI SeedUI;

		// Token: 0x040045DB RID: 17883
		[Token(Token = "0x40045DB")]
		[FieldOffset(Offset = "0x28")]
		public ItemFieldUI Additive1UI;

		// Token: 0x040045DC RID: 17884
		[Token(Token = "0x40045DC")]
		[FieldOffset(Offset = "0x30")]
		public ItemFieldUI Additive2UI;

		// Token: 0x040045DD RID: 17885
		[Token(Token = "0x40045DD")]
		[FieldOffset(Offset = "0x38")]
		public ItemFieldUI Additive3UI;

		// Token: 0x040045DE RID: 17886
		[Token(Token = "0x40045DE")]
		[FieldOffset(Offset = "0x40")]
		public ObjectFieldUI DestinationUI;
	}
}
