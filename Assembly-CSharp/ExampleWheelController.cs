using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000068 RID: 104
[Token(Token = "0x2000068")]
public class ExampleWheelController : MonoBehaviour
{
	// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x56B4E0", Offset = "0x56A6E0", VA = "0x18056B4E0")]
	private void Start()
	{
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x56B550", Offset = "0x56A750", VA = "0x18056B550")]
	private void Update()
	{
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public ExampleWheelController()
	{
	}

	// Token: 0x04000209 RID: 521
	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x20")]
	public float acceleration;

	// Token: 0x0400020A RID: 522
	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x28")]
	public Renderer motionVectorRenderer;

	// Token: 0x0400020B RID: 523
	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody m_Rigidbody;

	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	private static class Uniforms
	{
		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int _MotionAmount;
	}
}
