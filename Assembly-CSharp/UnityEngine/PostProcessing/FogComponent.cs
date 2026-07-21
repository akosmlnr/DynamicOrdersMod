using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x17000034")]
		public override bool active
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x56CDF0", Offset = "0x56BFF0", VA = "0x18056CDF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x56C8A0", Offset = "0x56BAA0", VA = "0x18056C8A0", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x56A480", Offset = "0x569680", VA = "0x18056A480", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x56C890", Offset = "0x56BA90", VA = "0x18056C890", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x56C8D0", Offset = "0x56BAD0", VA = "0x18056C8D0", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x56CDB0", Offset = "0x56BFB0", VA = "0x18056CDB0")]
		public FogComponent()
		{
		}

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		private const string k_ShaderString = "Hidden/Post FX/Fog";

		// Token: 0x02000086 RID: 134
		[Token(Token = "0x2000086")]
		private static class Uniforms
		{
			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _FogColor;

			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _Density;

			// Token: 0x04000294 RID: 660
			[Token(Token = "0x4000294")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Start;

			// Token: 0x04000295 RID: 661
			[Token(Token = "0x4000295")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _End;

			// Token: 0x04000296 RID: 662
			[Token(Token = "0x4000296")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _TempRT;
		}
	}
}
