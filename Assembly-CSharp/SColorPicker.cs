using System;
using HSVPicker;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
public class SColorPicker : ColorPicker
{
	// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x55ED70", Offset = "0x55DF70", VA = "0x18055ED70")]
	private void Start()
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x55EE10", Offset = "0x55E010", VA = "0x18055EE10")]
	private void ValueChanged(Color col)
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x55EE80", Offset = "0x55E080", VA = "0x18055EE80")]
	public SColorPicker()
	{
	}

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x58")]
	public int PropertyIndex;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x60")]
	public UnityEvent<Color, int> onValueChangeWithIndex;
}
