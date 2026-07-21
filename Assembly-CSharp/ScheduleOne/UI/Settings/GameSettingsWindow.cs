using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CEF RID: 3311
	[Token(Token = "0x2000CEF")]
	public class GameSettingsWindow : MonoBehaviour
	{
		// Token: 0x06006085 RID: 24709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006085")]
		[Address(RVA = "0xA275F0", Offset = "0xA267F0", VA = "0x180A275F0")]
		private void Awake()
		{
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006086")]
		[Address(RVA = "0xA27810", Offset = "0xA26A10", VA = "0x180A27810")]
		public void Start()
		{
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006087")]
		[Address(RVA = "0xA275A0", Offset = "0xA267A0", VA = "0x180A275A0")]
		public void ApplySettings(GameSettings settings)
		{
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006088")]
		[Address(RVA = "0xA276F0", Offset = "0xA268F0", VA = "0x180A276F0")]
		private void ConsoleToggled(bool value)
		{
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006089")]
		[Address(RVA = "0xA27780", Offset = "0xA26980", VA = "0x180A27780")]
		private void RandomMixMapsToggled(bool value)
		{
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600608A")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public GameSettingsWindow()
		{
		}

		// Token: 0x040042BC RID: 17084
		[Token(Token = "0x40042BC")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle ConsoleToggle;

		// Token: 0x040042BD RID: 17085
		[Token(Token = "0x40042BD")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle RandomMixMapsToggle;

		// Token: 0x040042BE RID: 17086
		[Token(Token = "0x40042BE")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Blocker;

		// Token: 0x040042BF RID: 17087
		[Token(Token = "0x40042BF")]
		[FieldOffset(Offset = "0x38")]
		public UIPanel uiPanel;
	}
}
