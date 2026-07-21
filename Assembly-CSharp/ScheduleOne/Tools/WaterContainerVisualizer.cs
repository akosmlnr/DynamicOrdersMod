using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000899 RID: 2201
	[Token(Token = "0x2000899")]
	public class WaterContainerVisualizer : MonoBehaviour
	{
		// Token: 0x06003A04 RID: 14852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A04")]
		[Address(RVA = "0x8127F0", Offset = "0x8119F0", VA = "0x1808127F0")]
		public void AssignWaterContainer(WaterContainerInstance waterContainer)
		{
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A05")]
		[Address(RVA = "0x812CA0", Offset = "0x811EA0", VA = "0x180812CA0")]
		public void UnassignWaterContainer()
		{
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x812D40", Offset = "0x811F40", VA = "0x180812D40")]
		private void WaterContainerChanged()
		{
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A07")]
		[Address(RVA = "0x812940", Offset = "0x811B40", VA = "0x180812940")]
		private void SetFillLevel(float normalizedFillLevel)
		{
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public WaterContainerVisualizer()
		{
		}

		// Token: 0x04002AC9 RID: 10953
		[Token(Token = "0x4002AC9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TransformLerp[] _waterTransformLerps;

		// Token: 0x04002ACA RID: 10954
		[Token(Token = "0x4002ACA")]
		[FieldOffset(Offset = "0x28")]
		private WaterContainerInstance _assignedWaterContainer;
	}
}
