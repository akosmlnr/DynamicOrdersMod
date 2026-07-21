using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001F6 RID: 502
	[Token(Token = "0x20001F6")]
	[RequireComponent(typeof(MeshRenderer))]
	public class WeatherEnclosure : MonoBehaviour
	{
		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0xA07AA0", Offset = "0xA06CA0", VA = "0x180A07AA0")]
		public WeatherEnclosure()
		{
		}

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 nearTextureTiling;

		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4000B87")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 farTextureTiling;
	}
}
