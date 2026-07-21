using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A0B RID: 2571
	[Token(Token = "0x2000A0B")]
	public static class PlayerLogExporter
	{
		// Token: 0x06004978 RID: 18808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004978")]
		[Address(RVA = "0x90A400", Offset = "0x909600", VA = "0x18090A400")]
		public static void ExportPlayerLog(bool previous, [Optional] Action onSuccess)
		{
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004979")]
		[Address(RVA = "0x90AA20", Offset = "0x909C20", VA = "0x18090AA20")]
		private static void SavePathSelected(string savePath, bool previous)
		{
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600497A")]
		[Address(RVA = "0x90A670", Offset = "0x909870", VA = "0x18090A670")]
		public static string FilterLog(string log)
		{
			return null;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600497B")]
		[Address(RVA = "0x90A860", Offset = "0x909A60", VA = "0x18090A860")]
		private static string ReadFileShared(string path)
		{
			return null;
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600497C")]
		[Address(RVA = "0x90A7A0", Offset = "0x9099A0", VA = "0x18090A7A0")]
		public static string GetLogPath(bool previous)
		{
			return null;
		}

		// Token: 0x040033EF RID: 13295
		[Token(Token = "0x40033EF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Action _onSuccess;

		// Token: 0x040033F0 RID: 13296
		[Token(Token = "0x40033F0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Regex[] ExcludedRegexes;
	}
}
