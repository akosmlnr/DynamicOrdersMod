using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.FX
{
	// Token: 0x02000682 RID: 1666
	[Token(Token = "0x2000682")]
	[CreateAssetMenu(fileName = "PsychedelicFullScreenData", menuName = "ScriptableObjects/FX/Psychedelic FullScreen Data", order = 1)]
	public class PsychedelicFullScreenData : ScriptableObject
	{
		// Token: 0x06002B33 RID: 11059 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B33")]
		[Address(RVA = "0x706060", Offset = "0x705260", VA = "0x180706060")]
		public PsychedelicFullScreenFeature.MaterialProperties ConvertToMaterialProperties()
		{
			return null;
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B34")]
		[Address(RVA = "0x7060F0", Offset = "0x7052F0", VA = "0x1807060F0")]
		public PsychedelicFullScreenData()
		{
		}

		// Token: 0x04002051 RID: 8273
		[Token(Token = "0x4002051")]
		[FieldOffset(Offset = "0x18")]
		[Header("Properties")]
		public float NoiseScale;

		// Token: 0x04002052 RID: 8274
		[Token(Token = "0x4002052")]
		[FieldOffset(Offset = "0x1C")]
		public float Blend;

		// Token: 0x04002053 RID: 8275
		[Token(Token = "0x4002053")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 PanSpeed;

		// Token: 0x04002054 RID: 8276
		[Token(Token = "0x4002054")]
		[FieldOffset(Offset = "0x28")]
		public bool DoesBounce;

		// Token: 0x04002055 RID: 8277
		[Token(Token = "0x4002055")]
		[FieldOffset(Offset = "0x2C")]
		public float Amplitude;
	}
}
