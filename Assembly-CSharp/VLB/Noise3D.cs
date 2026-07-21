using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	public static class Noise3D
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x170000EF")]
		public static bool isSupported
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x698490", Offset = "0x697690", VA = "0x180698490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x170000F0")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x698420", Offset = "0x697620", VA = "0x180698420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000F1")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x698390", Offset = "0x697590", VA = "0x180698390")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x698380", Offset = "0x697580", VA = "0x180698380")]
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x698240", Offset = "0x697440", VA = "0x180698240")]
		public static void LoadIfNeeded()
		{
		}

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		private const int kMinShaderLevel = 35;
	}
}
