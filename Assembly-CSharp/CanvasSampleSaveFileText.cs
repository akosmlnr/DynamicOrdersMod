using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000043 RID: 67
[Token(Token = "0x2000043")]
[RequireComponent(typeof(Button))]
public class CanvasSampleSaveFileText : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x551280", Offset = "0x550480", VA = "0x180551280")]
	private void Start()
	{
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x5511B0", Offset = "0x5503B0", VA = "0x1805511B0")]
	public void OnClick()
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x551330", Offset = "0x550530", VA = "0x180551330")]
	public CanvasSampleSaveFileText()
	{
	}

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x20")]
	public Text output;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x28")]
	private string _data;
}
