using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
public class NavMeshCleaner : MonoBehaviour
{
	// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x55E350", Offset = "0x55D550", VA = "0x18055E350")]
	public NavMeshCleaner()
	{
	}

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x20")]
	public List<Vector3> m_WalkablePoint;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x28")]
	public float m_Height;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Offset;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x30")]
	public int m_MidLayerCount;
}
