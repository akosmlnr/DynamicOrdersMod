using System;
using Il2CppDummyDll;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	public class CylinderManager : MonoBehaviour
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x7A0670", Offset = "0x79F870", VA = "0x1807A0670")]
		private void Update()
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x7A0D80", Offset = "0x79FF80", VA = "0x1807A0D80")]
		public CylinderManager()
		{
		}

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x20")]
		public float startingDelay;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x24")]
		public int numCylinders;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x28")]
		public float scale;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x2C")]
		public float heightMultiplier;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x30")]
		public float circleRadius;
	}
}
