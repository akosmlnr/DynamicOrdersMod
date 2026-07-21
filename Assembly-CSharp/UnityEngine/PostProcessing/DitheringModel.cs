using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[Serializable]
	public class DitheringModel : PostProcessingModel
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00002EE0 File Offset: 0x000010E0
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public DitheringModel.Settings settings
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x4956E0", Offset = "0x4948E0", VA = "0x1804956E0")]
			get
			{
				return default(DitheringModel.Settings);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x693AE0", Offset = "0x692CE0", VA = "0x180693AE0")]
			set
			{
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x4C3B90", Offset = "0x4C2D90", VA = "0x1804C3B90", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x693AD0", Offset = "0x692CD0", VA = "0x180693AD0")]
		public DitheringModel()
		{
		}

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DitheringModel.Settings m_Settings;

		// Token: 0x020000BF RID: 191
		[Token(Token = "0x20000BF")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060002E5 RID: 741 RVA: 0x00002EF8 File Offset: 0x000010F8
			[Token(Token = "0x1700005F")]
			public static DitheringModel.Settings defaultSettings
			{
				[Token(Token = "0x60002E5")]
				[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0")]
				get
				{
					return default(DitheringModel.Settings);
				}
			}
		}
	}
}
