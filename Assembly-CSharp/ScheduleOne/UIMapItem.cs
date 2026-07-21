using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	public class UIMapItem : MonoBehaviour
	{
		// Token: 0x06000BBC RID: 3004 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
		public RectTransform GetRectTransform()
		{
			return null;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0xAD21E0", Offset = "0xAD13E0", VA = "0x180AD21E0")]
		private void Awake()
		{
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
		public void SetMapPanel(UIMapPanel panel)
		{
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0xAD2340", Offset = "0xAD1540", VA = "0x180AD2340")]
		public Vector2 GetMapPosition()
		{
			return default(Vector2);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0xAD23A0", Offset = "0xAD15A0", VA = "0x180AD23A0")]
		public void OnClick()
		{
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0xAD2500", Offset = "0xAD1700", VA = "0x180AD2500")]
		public void OnPointerEnter()
		{
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0xAD2660", Offset = "0xAD1860", VA = "0x180AD2660")]
		public void OnPointerExit()
		{
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public UIMapItem()
		{
		}

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIMapPanel mapPanel;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button button;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform rectTransform;
	}
}
