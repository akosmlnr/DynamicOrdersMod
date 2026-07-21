using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000040")]
[RequireComponent(typeof(Button))]
public class CanvasSampleOpenFileTextMultiple : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x550B90", Offset = "0x54FD90", VA = "0x180550B90")]
	private void Start()
	{
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x550870", Offset = "0x54FA70", VA = "0x180550870")]
	private void OnClick()
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x550B00", Offset = "0x54FD00", VA = "0x180550B00")]
	private IEnumerator OutputRoutine(string[] urlArr)
	{
		return null;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public CanvasSampleOpenFileTextMultiple()
	{
	}

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x20")]
	public Text output;
}
