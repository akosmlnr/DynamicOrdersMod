using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	public class PostProcessingContext
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public bool interrupted
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x570E40", Offset = "0x570040", VA = "0x180570E40")]
		public void Interrupt()
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x69B240", Offset = "0x69A440", VA = "0x18069B240")]
		public PostProcessingContext Reset()
		{
			return null;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600032F RID: 815 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x17000071")]
		public bool isGBufferAvailable
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x69B2C0", Offset = "0x69A4C0", VA = "0x18069B2C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000330 RID: 816 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x17000072")]
		public bool isHdr
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x69B2F0", Offset = "0x69A4F0", VA = "0x18069B2F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000331 RID: 817 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x17000073")]
		public int width
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x69B350", Offset = "0x69A550", VA = "0x18069B350")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000332 RID: 818 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x17000074")]
		public int height
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x69B2A0", Offset = "0x69A4A0", VA = "0x18069B2A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x17000075")]
		public Rect viewport
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x69B310", Offset = "0x69A510", VA = "0x18069B310")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public PostProcessingContext()
		{
		}

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x10")]
		public PostProcessingProfile profile;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x18")]
		public Camera camera;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x20")]
		public MaterialFactory materialFactory;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x28")]
		public RenderTextureFactory renderTextureFactory;
	}
}
