using System;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class CustomSelectable : Selectable
{
	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x552300", Offset = "0x551500", VA = "0x180552300", Slot = "36")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x5522D0", Offset = "0x5514D0", VA = "0x1805522D0", Slot = "37")]
	public override void OnDeselect(BaseEventData eventData)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x552330", Offset = "0x551530", VA = "0x180552330")]
	public CustomSelectable()
	{
	}

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x100")]
	public UnityEvent OnSelectionEnter;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x108")]
	public UnityEvent OnSelectionExit;
}
