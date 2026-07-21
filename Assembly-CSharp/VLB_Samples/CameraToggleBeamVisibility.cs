using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	[RequireComponent(typeof(Camera))]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x79FC80", Offset = "0x79EE80", VA = "0x18079FC80")]
		private void Update()
		{
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x79FD40", Offset = "0x79EF40", VA = "0x18079FD40")]
		public CameraToggleBeamVisibility()
		{
		}

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private KeyCode m_KeyCode;
	}
}
