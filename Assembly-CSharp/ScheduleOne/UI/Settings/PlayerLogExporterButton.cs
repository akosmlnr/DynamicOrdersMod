using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000CF6 RID: 3318
	[Token(Token = "0x2000CF6")]
	[RequireComponent(typeof(Button))]
	public class PlayerLogExporterButton : MonoBehaviour
	{
		// Token: 0x060060A9 RID: 24745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060A9")]
		[Address(RVA = "0xA300F0", Offset = "0xA2F2F0", VA = "0x180A300F0")]
		private void Awake()
		{
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AA")]
		[Address(RVA = "0xA302D0", Offset = "0xA2F4D0", VA = "0x180A302D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AB")]
		[Address(RVA = "0xA30220", Offset = "0xA2F420", VA = "0x180A30220")]
		private void OnButtonClick()
		{
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AC")]
		[Address(RVA = "0x5FAF90", Offset = "0x5FA190", VA = "0x1805FAF90")]
		private void Success()
		{
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00018138 File Offset: 0x00016338
		[Token(Token = "0x60060AD")]
		[Address(RVA = "0xA301C0", Offset = "0xA2F3C0", VA = "0x180A301C0")]
		private bool DoesLogExist()
		{
			return default(bool);
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PlayerLogExporterButton()
		{
		}

		// Token: 0x040042C6 RID: 17094
		[Token(Token = "0x40042C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _exportPreviousLog;

		// Token: 0x040042C7 RID: 17095
		[Token(Token = "0x40042C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent OnSuccess;

		// Token: 0x040042C8 RID: 17096
		[Token(Token = "0x40042C8")]
		[FieldOffset(Offset = "0x30")]
		private Button _button;
	}
}
