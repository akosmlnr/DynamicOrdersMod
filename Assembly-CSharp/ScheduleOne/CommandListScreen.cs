using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.UI.MainMenu;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	public class CommandListScreen : MainMenuScreen
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0xAE3000", Offset = "0xAE2200", VA = "0x180AE3000")]
		private void Start()
		{
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0xAE3480", Offset = "0xAE2680", VA = "0x180AE3480")]
		public CommandListScreen()
		{
		}

		// Token: 0x04000D65 RID: 3429
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform CommandEntryContainer;

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform CommandEntryPrefab;

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0x70")]
		private List<RectTransform> commandEntries;
	}
}
