using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB_Samples
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	public class Rotater : MonoBehaviour
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x7B5B50", Offset = "0x7B4D50", VA = "0x1807B5B50")]
		private void Update()
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x491C00", Offset = "0x490E00", VA = "0x180491C00")]
		public Rotater()
		{
		}

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;
	}
}
