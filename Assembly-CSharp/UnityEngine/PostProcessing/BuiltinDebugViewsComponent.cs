using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x1700002B")]
		public override bool active
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x567710", Offset = "0x566910", VA = "0x180567710", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x5669E0", Offset = "0x565BE0", VA = "0x1805669E0", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x566980", Offset = "0x565B80", VA = "0x180566980", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeDepthTexture;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x566A50", Offset = "0x565C50", VA = "0x180566A50", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5672D0", Offset = "0x5664D0", VA = "0x1805672D0", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x566820", Offset = "0x565A20", VA = "0x180566820")]
		private void DepthPass(CommandBuffer cb)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x566750", Offset = "0x565950", VA = "0x180566750")]
		private void DepthNormalsPass(CommandBuffer cb)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x566A80", Offset = "0x565C80", VA = "0x180566A80")]
		private void MotionVectorsPass(CommandBuffer cb)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x5675B0", Offset = "0x5667B0", VA = "0x1805675B0")]
		private void PrepareArrows()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x567270", Offset = "0x566470", VA = "0x180567270", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x5676D0", Offset = "0x5668D0", VA = "0x1805676D0")]
		public BuiltinDebugViewsComponent()
		{
		}

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x20")]
		private BuiltinDebugViewsComponent.ArrowArray m_Arrows;

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		private static class Uniforms
		{
			// Token: 0x04000241 RID: 577
			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _DepthScale;

			// Token: 0x04000242 RID: 578
			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _TempRT;

			// Token: 0x04000243 RID: 579
			[Token(Token = "0x4000243")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _Opacity;

			// Token: 0x04000244 RID: 580
			[Token(Token = "0x4000244")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _MainTex;

			// Token: 0x04000245 RID: 581
			[Token(Token = "0x4000245")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _TempRT2;

			// Token: 0x04000246 RID: 582
			[Token(Token = "0x4000246")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _Amplitude;

			// Token: 0x04000247 RID: 583
			[Token(Token = "0x4000247")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _Scale;
		}

		// Token: 0x02000079 RID: 121
		[Token(Token = "0x2000079")]
		private enum Pass
		{
			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			Depth,
			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			Normals,
			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			MovecOpacity,
			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			MovecImaging,
			// Token: 0x0400024D RID: 589
			[Token(Token = "0x400024D")]
			MovecArrows
		}

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		private class ArrowArray
		{
			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600021D RID: 541 RVA: 0x0000206A File Offset: 0x0000026A
			// (set) Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700002C")]
			public Mesh mesh
			{
				[Token(Token = "0x600021D")]
				[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x0600021F RID: 543 RVA: 0x00002718 File Offset: 0x00000918
			// (set) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700002D")]
			public int columnCount
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x457F70", Offset = "0x457170", VA = "0x180457F70")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000220")]
				[Address(RVA = "0x49BD70", Offset = "0x49AF70", VA = "0x18049BD70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000221 RID: 545 RVA: 0x00002730 File Offset: 0x00000930
			// (set) Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700002E")]
			public int rowCount
			{
				[Token(Token = "0x6000221")]
				[Address(RVA = "0x4A0500", Offset = "0x49F700", VA = "0x1804A0500")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000222")]
				[Address(RVA = "0x4A0510", Offset = "0x49F710", VA = "0x1804A0510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x5655F0", Offset = "0x5647F0", VA = "0x1805655F0")]
			public void BuildMesh(int columns, int rows)
			{
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x565A50", Offset = "0x564C50", VA = "0x180565A50")]
			public void Release()
			{
			}

			// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ArrowArray()
			{
			}
		}
	}
}
