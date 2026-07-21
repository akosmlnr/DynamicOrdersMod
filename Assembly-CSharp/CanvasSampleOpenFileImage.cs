using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
[RequireComponent(typeof(Button))]
public class CanvasSampleOpenFileImage : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x5507C0", Offset = "0x54F9C0", VA = "0x1805507C0")]
	private void Start()
	{
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x5505B0", Offset = "0x54F7B0", VA = "0x1805505B0")]
	private void OnClick()
	{
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x550730", Offset = "0x54F930", VA = "0x180550730")]
	private IEnumerator OutputRoutine(string url)
	{
		return null;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public CanvasSampleOpenFileImage()
	{
	}

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x20")]
	public RawImage output;
}
