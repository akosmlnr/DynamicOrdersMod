using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000DF8 RID: 3576
	[Token(Token = "0x2000DF8")]
	public class ItemEntryUI : MonoBehaviour
	{
		// Token: 0x0600667E RID: 26238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667E")]
		[Address(RVA = "0xA94C20", Offset = "0xA93E20", VA = "0x180A94C20")]
		public void Set(string name, int quantity, Sprite icon)
		{
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667F")]
		[Address(RVA = "0xA94BA0", Offset = "0xA93DA0", VA = "0x180A94BA0")]
		public void SetLabelOnly(string name)
		{
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006680")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ItemEntryUI()
		{
		}

		// Token: 0x0400484C RID: 18508
		[Token(Token = "0x400484C")]
		[FieldOffset(Offset = "0x20")]
		[Header("Components")]
		[SerializeField]
		private Text _nameLabel;

		// Token: 0x0400484D RID: 18509
		[Token(Token = "0x400484D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _quantityLabel;

		// Token: 0x0400484E RID: 18510
		[Token(Token = "0x400484E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;
	}
}
