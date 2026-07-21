using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace VolumetricFogAndMist2.Demos
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	public class DemoSceneControls : MonoBehaviour
	{
		// Token: 0x06000686 RID: 1670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x7A0F80", Offset = "0x7A0180", VA = "0x1807A0F80")]
		private void Start()
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x7A0F90", Offset = "0x7A0190", VA = "0x1807A0F90")]
		private void Update()
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x7A0DB0", Offset = "0x79FFB0", VA = "0x1807A0DB0")]
		private void SetProfile(int profileIndex)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public DemoSceneControls()
		{
		}

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x20")]
		public VolumetricFogProfile[] profiles;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x28")]
		public VolumetricFog fogVolume;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x30")]
		public Text presetNameDisplay;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x38")]
		private int index;
	}
}
