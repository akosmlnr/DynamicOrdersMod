using System;
using Il2CppDummyDll;
using ScheduleOne.UI;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class DevTesting : MonoBehaviour
{
	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x5527B0", Offset = "0x5519B0", VA = "0x1805527B0")]
	private void Update()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x5529A0", Offset = "0x551BA0", VA = "0x1805529A0")]
	public DevTesting()
	{
	}

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	[Header("Spread Testing")]
	[SerializeField]
	private float _spreadAngle;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ReticleUI _reticleUI;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _sphere;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _testDistance;
}
