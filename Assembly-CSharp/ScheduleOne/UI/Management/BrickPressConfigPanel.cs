using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.Management.UI;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D70 RID: 3440
	[Token(Token = "0x2000D70")]
	public class BrickPressConfigPanel : ConfigPanel
	{
		// Token: 0x06006391 RID: 25489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006391")]
		[Address(RVA = "0xA56080", Offset = "0xA55280", VA = "0x180A56080", Slot = "4")]
		protected override void BindInternal(List<EntityConfiguration> configs)
		{
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006392")]
		[Address(RVA = "0x44C380", Offset = "0x44B580", VA = "0x18044C380")]
		public BrickPressConfigPanel()
		{
		}

		// Token: 0x040045C3 RID: 17859
		[Token(Token = "0x40045C3")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public ObjectFieldUI DestinationUI;
	}
}
