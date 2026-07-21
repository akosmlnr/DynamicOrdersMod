using System;
using Il2CppDummyDll;
using ScheduleOne.UI.Settings;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000DC3 RID: 3523
	[Token(Token = "0x2000DC3")]
	public class SettingsScreen : MainMenuScreen
	{
		// Token: 0x06006547 RID: 25927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006547")]
		[Address(RVA = "0xA82210", Offset = "0xA81410", VA = "0x180A82210", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006548")]
		[Address(RVA = "0xA823E0", Offset = "0xA815E0", VA = "0x180A823E0")]
		protected void Start()
		{
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006549")]
		[Address(RVA = "0xA82310", Offset = "0xA81510", VA = "0x180A82310")]
		public void ShowCategory(int index)
		{
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654A")]
		[Address(RVA = "0xA822E0", Offset = "0xA814E0", VA = "0x180A822E0")]
		public void DisplayChanged()
		{
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654B")]
		[Address(RVA = "0xA82040", Offset = "0xA81240", VA = "0x180A82040")]
		private void ApplyDisplaySettings()
		{
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600654C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SettingsScreen()
		{
		}

		// Token: 0x0400470D RID: 18189
		[Token(Token = "0x400470D")]
		[FieldOffset(Offset = "0x60")]
		public SettingsScreen.SettingsCategory[] Categories;

		// Token: 0x0400470E RID: 18190
		[Token(Token = "0x400470E")]
		[FieldOffset(Offset = "0x68")]
		public Button ApplyDisplayButton;

		// Token: 0x0400470F RID: 18191
		[Token(Token = "0x400470F")]
		[FieldOffset(Offset = "0x70")]
		public ConfirmDisplaySettings ConfirmDisplaySettings;

		// Token: 0x02000DC4 RID: 3524
		[Token(Token = "0x2000DC4")]
		[Serializable]
		public class SettingsCategory
		{
			// Token: 0x0600654D RID: 25933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600654D")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SettingsCategory()
			{
			}

			// Token: 0x04004710 RID: 18192
			[Token(Token = "0x4004710")]
			[FieldOffset(Offset = "0x10")]
			public Toggle Toggle;

			// Token: 0x04004711 RID: 18193
			[Token(Token = "0x4004711")]
			[FieldOffset(Offset = "0x18")]
			public GameObject Panel;
		}
	}
}
