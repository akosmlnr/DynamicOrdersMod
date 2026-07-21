using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public class LightGenerator : MonoBehaviour
	{
		// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x7A6C80", Offset = "0x7A5E80", VA = "0x1807A6C80")]
		public void Generate()
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x7A74A0", Offset = "0x7A66A0", VA = "0x1807A74A0")]
		public LightGenerator()
		{
		}

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x20")]
		[Range(1f, 100f)]
		[SerializeField]
		private int CountX;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(1f, 100f)]
		private int CountY;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float OffsetUnits;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float PositionY;

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool NoiseEnabled;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool AddLight;
	}
}
