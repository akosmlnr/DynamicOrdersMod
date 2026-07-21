using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000042")]
[RequireComponent(typeof(Button))]
public class CanvasSampleSaveFileImage : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x550F00", Offset = "0x550100", VA = "0x180550F00")]
	private void Awake()
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x551100", Offset = "0x550300", VA = "0x180551100")]
	private void Start()
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x551030", Offset = "0x550230", VA = "0x180551030")]
	public void OnClick()
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public CanvasSampleSaveFileImage()
	{
	}

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x20")]
	public Text output;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x28")]
	private byte[] _textureBytes;
}
