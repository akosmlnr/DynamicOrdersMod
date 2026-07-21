using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	public static class GraphicsUtils
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x17000077")]
		public static bool isLinearColorSpace
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x6956A0", Offset = "0x6948A0", VA = "0x1806956A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x17000078")]
		public static bool supportsDX11
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x6959A0", Offset = "0x694BA0", VA = "0x1806959A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000079")]
		public static Texture2D whiteTexture
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x6959D0", Offset = "0x694BD0", VA = "0x1806959D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700007A")]
		public static Mesh quad
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x6956C0", Offset = "0x6948C0", VA = "0x1806956C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x695340", Offset = "0x694540", VA = "0x180695340")]
		public static void Blit(Material material, int pass)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x695440", Offset = "0x694640", VA = "0x180695440")]
		public static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = true, bool clearDepth = false)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x6955E0", Offset = "0x6947E0", VA = "0x1806955E0")]
		public static void Destroy(Object obj)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x695660", Offset = "0x694860", VA = "0x180695660")]
		public static void Dispose()
		{
		}

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x0")]
		private static Texture2D s_WhiteTexture;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x8")]
		private static Mesh s_Quad;
	}
}
