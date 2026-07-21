using System;
using Il2CppDummyDll;
using ScheduleOne;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
[RequireComponent(typeof(UISelectable))]
public class EventTriggerColor : MonoBehaviour
{
	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x552AE0", Offset = "0x551CE0", VA = "0x180552AE0")]
	private void Awake()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x552D10", Offset = "0x551F10", VA = "0x180552D10")]
	public void OnSelected()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x552C80", Offset = "0x551E80", VA = "0x180552C80")]
	public void OnDeselected()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x552DD0", Offset = "0x551FD0", VA = "0x180552DD0")]
	public EventTriggerColor()
	{
	}

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x20")]
	public Image image;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x28")]
	public Color SelectedColor;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x38")]
	public Color DeselectedColor;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x48")]
	private UISelectable selectable;
}
