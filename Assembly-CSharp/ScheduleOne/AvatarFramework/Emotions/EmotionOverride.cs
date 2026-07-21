using System;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x020007FC RID: 2044
	[Token(Token = "0x20007FC")]
	public class EmotionOverride
	{
		// Token: 0x06003736 RID: 14134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x702140", Offset = "0x701340", VA = "0x180702140")]
		public EmotionOverride(string emotion, string label, int priority)
		{
		}

		// Token: 0x04002827 RID: 10279
		[Token(Token = "0x4002827")]
		[FieldOffset(Offset = "0x10")]
		public string Emotion;

		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		[FieldOffset(Offset = "0x18")]
		public string Label;

		// Token: 0x04002829 RID: 10281
		[Token(Token = "0x4002829")]
		[FieldOffset(Offset = "0x20")]
		public int Priority;
	}
}
