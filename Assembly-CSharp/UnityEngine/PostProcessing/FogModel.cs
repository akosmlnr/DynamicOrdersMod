using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002F40 File Offset: 0x00001140
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public FogModel.Settings settings
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x4956E0", Offset = "0x4948E0", VA = "0x1804956E0")]
			get
			{
				return default(FogModel.Settings);
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x693AE0", Offset = "0x692CE0", VA = "0x180693AE0")]
			set
			{
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x4C4130", Offset = "0x4C3330", VA = "0x1804C4130", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x694FA0", Offset = "0x6941A0", VA = "0x180694FA0")]
		public FogModel()
		{
		}

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FogModel.Settings m_Settings;

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000063 RID: 99
			// (get) Token: 0x060002EF RID: 751 RVA: 0x00002F58 File Offset: 0x00001158
			[Token(Token = "0x17000063")]
			public static FogModel.Settings defaultSettings
			{
				[Token(Token = "0x60002EF")]
				[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0")]
				get
				{
					return default(FogModel.Settings);
				}
			}

			// Token: 0x040003B1 RID: 945
			[Token(Token = "0x40003B1")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Should the fog affect the skybox?")]
			public bool excludeSkybox;
		}
	}
}
