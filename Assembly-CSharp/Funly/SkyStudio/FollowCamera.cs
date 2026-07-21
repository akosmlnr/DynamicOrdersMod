using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	[ExecuteInEditMode]
	public class FollowCamera : MonoBehaviour
	{
		// Token: 0x06000A40 RID: 2624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x9F7090", Offset = "0x9F6290", VA = "0x1809F7090")]
		private void Update()
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x9F71B0", Offset = "0x9F63B0", VA = "0x1809F71B0")]
		public FollowCamera()
		{
		}

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x20")]
		public Camera followCamera;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 offset;
	}
}
