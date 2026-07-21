using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CEC RID: 3308
	[Token(Token = "0x2000CEC")]
	public class ConfirmDisplaySettings : MonoBehaviour
	{
		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06006077 RID: 24695 RVA: 0x000180F0 File Offset: 0x000162F0
		[Token(Token = "0x17000DF2")]
		public bool IsOpen
		{
			[Token(Token = "0x6006077")]
			[Address(RVA = "0xA24F60", Offset = "0xA24160", VA = "0x180A24F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006078")]
		[Address(RVA = "0xA24980", Offset = "0xA23B80", VA = "0x180A24980")]
		public void Awake()
		{
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006079")]
		[Address(RVA = "0xA24D70", Offset = "0xA23F70", VA = "0x180A24D70")]
		public void Open(DisplaySettings _oldSettings, DisplaySettings _newSettings)
		{
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607A")]
		[Address(RVA = "0xA24C80", Offset = "0xA23E80", VA = "0x180A24C80")]
		public void Exit(ExitAction action)
		{
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607B")]
		[Address(RVA = "0xA24E90", Offset = "0xA24090", VA = "0x180A24E90")]
		public void Update()
		{
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607C")]
		[Address(RVA = "0xA24A20", Offset = "0xA23C20", VA = "0x180A24A20")]
		public void Close(bool revert)
		{
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600607D")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ConfirmDisplaySettings()
		{
		}

		// Token: 0x040042B7 RID: 17079
		[Token(Token = "0x40042B7")]
		public const float RevertTime = 15f;

		// Token: 0x040042B8 RID: 17080
		[Token(Token = "0x40042B8")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI SubtitleLabel;

		// Token: 0x040042B9 RID: 17081
		[Token(Token = "0x40042B9")]
		[FieldOffset(Offset = "0x28")]
		private float timeUntilRevert;

		// Token: 0x040042BA RID: 17082
		[Token(Token = "0x40042BA")]
		[FieldOffset(Offset = "0x2C")]
		private DisplaySettings oldSettings;

		// Token: 0x040042BB RID: 17083
		[Token(Token = "0x40042BB")]
		[FieldOffset(Offset = "0x4C")]
		private DisplaySettings newSettings;
	}
}
