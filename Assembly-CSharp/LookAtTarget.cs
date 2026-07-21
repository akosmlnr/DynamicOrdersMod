using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000057 RID: 87
[Token(Token = "0x2000057")]
public class LookAtTarget : MonoBehaviour
{
	// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x55DF10", Offset = "0x55D110", VA = "0x18055DF10")]
	private void Update()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x55E020", Offset = "0x55D220", VA = "0x18055E020")]
	public LookAtTarget()
	{
	}

	// Token: 0x0400017F RID: 383
	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform _target;

	// Token: 0x04000180 RID: 384
	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _speed;

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 _lookAtTarget;
}
