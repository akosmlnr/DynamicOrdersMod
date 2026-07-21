using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace RadiantGI.Universal
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	public class ToggleEffect : MonoBehaviour
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x7B9B80", Offset = "0x7B8D80", VA = "0x1807B9B80")]
		private void Start()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x7B9BD0", Offset = "0x7B8DD0", VA = "0x1807B9BD0")]
		private void Update()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ToggleEffect()
		{
		}

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x20")]
		public VolumeProfile profile;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x28")]
		private RadiantGlobalIllumination radiant;
	}
}
