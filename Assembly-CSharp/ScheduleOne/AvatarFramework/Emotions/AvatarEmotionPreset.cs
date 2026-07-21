using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000805 RID: 2053
	[Token(Token = "0x2000805")]
	[Serializable]
	public class AvatarEmotionPreset
	{
		// Token: 0x06003763 RID: 14179 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003763")]
		[Address(RVA = "0x7E6120", Offset = "0x7E5320", VA = "0x1807E6120")]
		public static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)
		{
			return null;
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x7E64C0", Offset = "0x7E56C0", VA = "0x1807E64C0")]
		public AvatarEmotionPreset()
		{
		}

		// Token: 0x0400284C RID: 10316
		[Token(Token = "0x400284C")]
		[FieldOffset(Offset = "0x10")]
		public string PresetName;

		// Token: 0x0400284D RID: 10317
		[Token(Token = "0x400284D")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D FaceTexture;

		// Token: 0x0400284E RID: 10318
		[Token(Token = "0x400284E")]
		[FieldOffset(Offset = "0x20")]
		public Eye.EyeLidConfiguration LeftEyeRestingState;

		// Token: 0x0400284F RID: 10319
		[Token(Token = "0x400284F")]
		[FieldOffset(Offset = "0x28")]
		public Eye.EyeLidConfiguration RightEyeRestingState;

		// Token: 0x04002850 RID: 10320
		[Token(Token = "0x4002850")]
		[FieldOffset(Offset = "0x30")]
		[Range(-30f, 30f)]
		public float BrowAngleChange_L;

		// Token: 0x04002851 RID: 10321
		[Token(Token = "0x4002851")]
		[FieldOffset(Offset = "0x34")]
		[Range(-30f, 30f)]
		public float BrowAngleChange_R;

		// Token: 0x04002852 RID: 10322
		[Token(Token = "0x4002852")]
		[FieldOffset(Offset = "0x38")]
		[Range(-1f, 1f)]
		public float BrowHeightChange_L;

		// Token: 0x04002853 RID: 10323
		[Token(Token = "0x4002853")]
		[FieldOffset(Offset = "0x3C")]
		[Range(-1f, 1f)]
		public float BrowHeightChange_R;
	}
}
