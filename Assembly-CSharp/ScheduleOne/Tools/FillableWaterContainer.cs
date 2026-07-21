using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000862 RID: 2146
	[Token(Token = "0x2000862")]
	public class FillableWaterContainer : MonoBehaviour
	{
		// Token: 0x06003921 RID: 14625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003921")]
		[Address(RVA = "0x557960", Offset = "0x556B60", VA = "0x180557960")]
		public FillableWaterContainer()
		{
		}

		// Token: 0x04002A1C RID: 10780
		[Token(Token = "0x4002A1C")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float MaxTapOpenValue;

		// Token: 0x04002A1D RID: 10781
		[Token(Token = "0x4002A1D")]
		[FieldOffset(Offset = "0x28")]
		public WaterContainerVisualizer Visuals;

		// Token: 0x04002A1E RID: 10782
		[Token(Token = "0x4002A1E")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController FillSound;
	}
}
