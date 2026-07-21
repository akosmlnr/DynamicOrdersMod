using System;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class VirtualMouseDebugger : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x563FC0", Offset = "0x5631C0", VA = "0x180563FC0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x5640F0", Offset = "0x5632F0", VA = "0x1805640F0")]
	private void Update()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x5645A0", Offset = "0x5637A0", VA = "0x1805645A0")]
	public VirtualMouseDebugger()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	private TMP_Text msg;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	private VirtualMouseInput vmi;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	private Mouse systemMouse;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x38")]
	private Mouse virtualMouse;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x40")]
	private StringBuilder sb;
}
