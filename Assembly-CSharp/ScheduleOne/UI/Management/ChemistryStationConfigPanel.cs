using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D73 RID: 3443
	[Token(Token = "0x2000D73")]
	public class ChemistryStationConfigPanel : ConfigPanel
	{
		// Token: 0x06006397 RID: 25495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006397")]
		[Address(RVA = "0xA56830", Offset = "0xA55A30", VA = "0x180A56830", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006398")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public ChemistryStationConfigPanel()
		{
		}

		// Token: 0x040045C7 RID: 17863
		[Token(Token = "0x40045C7")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public StationRecipeFieldUI RecipeUI;

		// Token: 0x040045C8 RID: 17864
		[Token(Token = "0x40045C8")]
		[FieldOffset(Offset = "0x28")]
		public ObjectFieldUI DestinationUI;
	}
}
