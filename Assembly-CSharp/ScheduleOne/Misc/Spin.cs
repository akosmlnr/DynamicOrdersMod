using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	public class Spin : MonoBehaviour
	{
		// Token: 0x060020E1 RID: 8417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x6860A0", Offset = "0x6852A0", VA = "0x1806860A0")]
		private void Update()
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public Spin()
		{
		}

		// Token: 0x04001AB8 RID: 6840
		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 Axis;

		// Token: 0x04001AB9 RID: 6841
		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x2C")]
		public float Speed;
	}
}
