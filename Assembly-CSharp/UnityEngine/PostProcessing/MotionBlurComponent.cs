using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000037")]
		public MotionBlurComponent.ReconstructionFilter reconstructionFilter
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x5717F0", Offset = "0x5709F0", VA = "0x1805717F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000038")]
		public MotionBlurComponent.FrameBlendingFilter frameBlendingFilter
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x571660", Offset = "0x570860", VA = "0x180571660")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x17000039")]
		public override bool active
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x571590", Offset = "0x570790", VA = "0x180571590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x570DF0", Offset = "0x56FFF0", VA = "0x180570DF0", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x571510", Offset = "0x570710", VA = "0x180571510")]
		public void ResetHistory()
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x570DE0", Offset = "0x56FFE0", VA = "0x180570DE0", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x570DD0", Offset = "0x56FFD0", VA = "0x180570DD0", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x570E40", Offset = "0x570040", VA = "0x180570E40", Slot = "6")]
		public override void OnEnable()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x570E50", Offset = "0x570050", VA = "0x180570E50", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x570E20", Offset = "0x570020", VA = "0x180570E20", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x571550", Offset = "0x570750", VA = "0x180571550")]
		public MotionBlurComponent()
		{
		}

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x20")]
		private MotionBlurComponent.ReconstructionFilter m_ReconstructionFilter;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x28")]
		private MotionBlurComponent.FrameBlendingFilter m_FrameBlendingFilter;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x30")]
		private bool m_FirstFrame;

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x200008C")]
		private static class Uniforms
		{
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _VelocityScale;

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _MaxBlurRadius;

			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _RcpMaxBlurRadius;

			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _VelocityTex;

			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _MainTex;

			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _Tile2RT;

			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _Tile4RT;

			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _Tile8RT;

			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _TileMaxOffs;

			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _TileMaxLoop;

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x28")]
			internal static readonly int _TileVRT;

			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x2C")]
			internal static readonly int _NeighborMaxTex;

			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			[FieldOffset(Offset = "0x30")]
			internal static readonly int _LoopCount;

			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			[FieldOffset(Offset = "0x34")]
			internal static readonly int _TempRT;

			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			[FieldOffset(Offset = "0x38")]
			internal static readonly int _History1LumaTex;

			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			[FieldOffset(Offset = "0x3C")]
			internal static readonly int _History2LumaTex;

			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x40")]
			internal static readonly int _History3LumaTex;

			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x44")]
			internal static readonly int _History4LumaTex;

			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0x48")]
			internal static readonly int _History1ChromaTex;

			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x4C")]
			internal static readonly int _History2ChromaTex;

			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x40002B5")]
			[FieldOffset(Offset = "0x50")]
			internal static readonly int _History3ChromaTex;

			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			[FieldOffset(Offset = "0x54")]
			internal static readonly int _History4ChromaTex;

			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			[FieldOffset(Offset = "0x58")]
			internal static readonly int _History1Weight;

			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x5C")]
			internal static readonly int _History2Weight;

			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			[FieldOffset(Offset = "0x60")]
			internal static readonly int _History3Weight;

			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			[FieldOffset(Offset = "0x64")]
			internal static readonly int _History4Weight;
		}

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		private enum Pass
		{
			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			VelocitySetup,
			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			TileMax1,
			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			TileMax2,
			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			TileMaxV,
			// Token: 0x040002C0 RID: 704
			[Token(Token = "0x40002C0")]
			NeighborMax,
			// Token: 0x040002C1 RID: 705
			[Token(Token = "0x40002C1")]
			Reconstruction,
			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			FrameCompression,
			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			FrameBlendingChroma,
			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			FrameBlendingRaw
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		public class ReconstructionFilter
		{
			// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x572360", Offset = "0x571560", VA = "0x180572360")]
			public ReconstructionFilter()
			{
			}

			// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x571910", Offset = "0x570B10", VA = "0x180571910")]
			private void CheckTextureFormatSupport()
			{
			}

			// Token: 0x0600027A RID: 634 RVA: 0x00002A60 File Offset: 0x00000C60
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x571940", Offset = "0x570B40", VA = "0x180571940")]
			public bool IsSupported()
			{
				return default(bool);
			}

			// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x571950", Offset = "0x570B50", VA = "0x180571950")]
			public void ProcessImage(PostProcessingContext context, CommandBuffer cb, ref MotionBlurModel.Settings settings, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
			}

			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x10")]
			private RenderTextureFormat m_VectorRTFormat;

			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0x14")]
			private RenderTextureFormat m_PackedRTFormat;
		}

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		public class FrameBlendingFilter
		{
			// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x56D9A0", Offset = "0x56CBA0", VA = "0x18056D9A0")]
			public FrameBlendingFilter()
			{
			}

			// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x56D5F0", Offset = "0x56C7F0", VA = "0x18056D5F0")]
			public void Dispose()
			{
			}

			// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x56D880", Offset = "0x56CA80", VA = "0x18056D880")]
			public void PushFrame(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
			{
			}

			// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x56CE70", Offset = "0x56C070", VA = "0x18056CE70")]
			public void BlendFrames(CommandBuffer cb, float strength, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
			}

			// Token: 0x06000280 RID: 640 RVA: 0x00002A78 File Offset: 0x00000C78
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x56D5C0", Offset = "0x56C7C0", VA = "0x18056D5C0")]
			private static bool CheckSupportCompression()
			{
				return default(bool);
			}

			// Token: 0x06000281 RID: 641 RVA: 0x00002A90 File Offset: 0x00000C90
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x56D7C0", Offset = "0x56C9C0", VA = "0x18056D7C0")]
			private static RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				return RenderTextureFormat.ARGB32;
			}

			// Token: 0x06000282 RID: 642 RVA: 0x00002AA8 File Offset: 0x00000CA8
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x56D740", Offset = "0x56C940", VA = "0x18056D740")]
			private MotionBlurComponent.FrameBlendingFilter.Frame GetFrameRelative(int offset)
			{
				return default(MotionBlurComponent.FrameBlendingFilter.Frame);
			}

			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x10")]
			private bool m_UseCompression;

			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x14")]
			private RenderTextureFormat m_RawTextureFormat;

			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x18")]
			private MotionBlurComponent.FrameBlendingFilter.Frame[] m_FrameList;

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x20")]
			private int m_LastFrameCount;

			// Token: 0x02000090 RID: 144
			[Token(Token = "0x2000090")]
			private struct Frame
			{
				// Token: 0x06000283 RID: 643 RVA: 0x00002AC0 File Offset: 0x00000CC0
				[Token(Token = "0x6000283")]
				[Address(RVA = "0x56DAE0", Offset = "0x56CCE0", VA = "0x18056DAE0")]
				public float CalculateWeight(float strength, float currentTime)
				{
					return 0f;
				}

				// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000284")]
				[Address(RVA = "0x56E000", Offset = "0x56D200", VA = "0x18056E000")]
				public void Release()
				{
				}

				// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x56DD00", Offset = "0x56CF00", VA = "0x18056DD00")]
				public void MakeRecord(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
				{
				}

				// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x56DB80", Offset = "0x56CD80", VA = "0x18056DB80")]
				public void MakeRecordRaw(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, RenderTextureFormat format)
				{
				}

				// Token: 0x040002CB RID: 715
				[Token(Token = "0x40002CB")]
				[FieldOffset(Offset = "0x0")]
				public RenderTexture lumaTexture;

				// Token: 0x040002CC RID: 716
				[Token(Token = "0x40002CC")]
				[FieldOffset(Offset = "0x8")]
				public RenderTexture chromaTexture;

				// Token: 0x040002CD RID: 717
				[Token(Token = "0x40002CD")]
				[FieldOffset(Offset = "0x10")]
				private float m_Time;

				// Token: 0x040002CE RID: 718
				[Token(Token = "0x40002CE")]
				[FieldOffset(Offset = "0x18")]
				private RenderTargetIdentifier[] m_MRT;
			}
		}
	}
}
