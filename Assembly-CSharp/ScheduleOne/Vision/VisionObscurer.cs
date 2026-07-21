using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x020003C1 RID: 961
	[Token(Token = "0x20003C1")]
	public class VisionObscurer : MonoBehaviour
	{
		// Token: 0x06001841 RID: 6209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x55E340", Offset = "0x55D540", VA = "0x18055E340")]
		public VisionObscurer()
		{
		}

		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x4001546")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float ObscuranceAmount;
	}
}
