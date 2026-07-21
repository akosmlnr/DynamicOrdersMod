using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000CD4 RID: 3284
	[Token(Token = "0x2000CD4")]
	public class WorldspacePopupUI : MonoBehaviour
	{
		// Token: 0x06005FB7 RID: 24503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0xA3A7A0", Offset = "0xA399A0", VA = "0x180A3A7A0")]
		public void SetFill(float fill)
		{
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0xA3A730", Offset = "0xA39930", VA = "0x180A3A730")]
		public void Destroy()
		{
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public WorldspacePopupUI()
		{
		}

		// Token: 0x04004209 RID: 16905
		[Token(Token = "0x4004209")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public WorldspacePopup Popup;

		// Token: 0x0400420A RID: 16906
		[Token(Token = "0x400420A")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x0400420B RID: 16907
		[Token(Token = "0x400420B")]
		[FieldOffset(Offset = "0x30")]
		public Image FillImage;

		// Token: 0x0400420C RID: 16908
		[Token(Token = "0x400420C")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onDestroyed;
	}
}
