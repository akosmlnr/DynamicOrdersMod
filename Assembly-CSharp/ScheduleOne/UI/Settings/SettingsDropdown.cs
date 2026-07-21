using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CFA RID: 3322
	[Token(Token = "0x2000CFA")]
	public class SettingsDropdown : MonoBehaviour
	{
		// Token: 0x060060BB RID: 24763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BB")]
		[Address(RVA = "0xA34890", Offset = "0xA33A90", VA = "0x180A34890", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BC")]
		[Address(RVA = "0xA34A90", Offset = "0xA33C90", VA = "0x180A34A90")]
		protected void SetValueWithoutNotify(int value)
		{
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BD")]
		[Address(RVA = "0xA34BA0", Offset = "0xA33DA0", VA = "0x180A34BA0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BE")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		protected virtual void OnValueChanged(int value)
		{
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060BF")]
		[Address(RVA = "0xA344E0", Offset = "0xA336E0", VA = "0x180A344E0")]
		protected void AddOption(string option)
		{
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C0")]
		[Address(RVA = "0xA34770", Offset = "0xA33970", VA = "0x180A34770")]
		protected void AddOptions(List<string> options)
		{
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C1")]
		[Address(RVA = "0xA349E0", Offset = "0xA33BE0", VA = "0x180A349E0")]
		protected void ClearOptions()
		{
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060C2")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SettingsDropdown()
		{
		}

		// Token: 0x040042CA RID: 17098
		[Token(Token = "0x40042CA")]
		[FieldOffset(Offset = "0x20")]
		public string[] DefaultOptions;

		// Token: 0x040042CB RID: 17099
		[Token(Token = "0x40042CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected UIPopupSelector _popupSelector;

		// Token: 0x040042CC RID: 17100
		[Token(Token = "0x40042CC")]
		[FieldOffset(Offset = "0x30")]
		private TMP_Dropdown _dropdown;
	}
}
