using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
[RequireComponent(typeof(Button))]
public class CanvasSampleOpenFileText : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x550E50", Offset = "0x550050", VA = "0x180550E50")]
	private void Start()
	{
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x550C40", Offset = "0x54FE40", VA = "0x180550C40")]
	private void OnClick()
	{
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x550DC0", Offset = "0x54FFC0", VA = "0x180550DC0")]
	private IEnumerator OutputRoutine(string url)
	{
		return null;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public CanvasSampleOpenFileText()
	{
	}

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x20")]
	public Text output;
}
