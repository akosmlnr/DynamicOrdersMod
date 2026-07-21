using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200084A RID: 2122
	[Token(Token = "0x200084A")]
	public class ActiveOnMeshVisible : MonoBehaviour
	{
		// Token: 0x060038C8 RID: 14536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C8")]
		[Address(RVA = "0x7F6CB0", Offset = "0x7F5EB0", VA = "0x1807F6CB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C9")]
		[Address(RVA = "0x7F6DA0", Offset = "0x7F5FA0", VA = "0x1807F6DA0")]
		public ActiveOnMeshVisible()
		{
		}

		// Token: 0x040029D6 RID: 10710
		[Token(Token = "0x40029D6")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer Mesh;

		// Token: 0x040029D7 RID: 10711
		[Token(Token = "0x40029D7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] ObjectsToActivate;

		// Token: 0x040029D8 RID: 10712
		[Token(Token = "0x40029D8")]
		[FieldOffset(Offset = "0x30")]
		public bool Reverse;

		// Token: 0x040029D9 RID: 10713
		[Token(Token = "0x40029D9")]
		[FieldOffset(Offset = "0x31")]
		private bool isVisible;
	}
}
