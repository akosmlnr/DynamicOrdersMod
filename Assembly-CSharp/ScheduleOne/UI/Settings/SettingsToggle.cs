using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CFD RID: 3325
	[Token(Token = "0x2000CFD")]
	public class SettingsToggle : MonoBehaviour
	{
		// Token: 0x060060CE RID: 24782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CE")]
		[Address(RVA = "0xA35030", Offset = "0xA34230", VA = "0x180A35030", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060CF")]
		[Address(RVA = "0xA351B0", Offset = "0xA343B0", VA = "0x180A351B0")]
		protected void SetIsOnWithoutNotify(bool value)
		{
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060D0")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		protected virtual void OnValueChanged(bool value)
		{
		}

		// Token: 0x060060D1 RID: 24785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060D1")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SettingsToggle()
		{
		}

		// Token: 0x040042D4 RID: 17108
		[Token(Token = "0x40042D4")]
		[FieldOffset(Offset = "0x20")]
		protected Toggle toggle;

		// Token: 0x040042D5 RID: 17109
		[Token(Token = "0x40042D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected UIToggle uiToggle;
	}
}
