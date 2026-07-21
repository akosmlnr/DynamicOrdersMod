using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020009FB RID: 2555
	[Token(Token = "0x20009FB")]
	public static class JsonHelper
	{
		// Token: 0x0600490C RID: 18700 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600490C")]
		public static T[] FromJson<T>(string json)
		{
			return null;
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600490D")]
		public static string ToJson<T>(T[] array)
		{
			return null;
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600490E")]
		public static string ToJson<T>(T[] array, bool prettyPrint)
		{
			return null;
		}

		// Token: 0x020009FC RID: 2556
		[Token(Token = "0x20009FC")]
		[Serializable]
		private class Wrapper<T>
		{
			// Token: 0x0600490F RID: 18703 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600490F")]
			public Wrapper()
			{
			}

			// Token: 0x040033B8 RID: 13240
			[Token(Token = "0x40033B8")]
			[FieldOffset(Offset = "0x0")]
			public T[] Items;
		}
	}
}
