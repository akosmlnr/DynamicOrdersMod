using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.FX
{
	// Token: 0x0200068D RID: 1677
	[Token(Token = "0x200068D")]
	public class PsychedelicFullScreenFeature : ScriptableRendererFeature
	{
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000777")]
		public PsychedelicFullScreenFeature.Settings FeatureSettings
		{
			[Token(Token = "0x6002B78")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000778")]
		public PsychedelicFullScreenFeature.MaterialProperties ActiveMaterialProperties
		{
			[Token(Token = "0x6002B79")]
			[Address(RVA = "0x71E240", Offset = "0x71D440", VA = "0x18071E240")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x71DCC0", Offset = "0x71CEC0", VA = "0x18071DCC0", Slot = "5")]
		public override void Create()
		{
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x71DBD0", Offset = "0x71CDD0", VA = "0x18071DBD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x71DFE0", Offset = "0x71D1E0", VA = "0x18071DFE0")]
		public void SetActiveMaterialProperties(PsychedelicFullScreenFeature.MaterialProperties properties)
		{
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x71DF10", Offset = "0x71D110", VA = "0x18071DF10")]
		public void PrintMaterialValue()
		{
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002B7E")]
		[Address(RVA = "0x71DDA0", Offset = "0x71CFA0", VA = "0x18071DDA0")]
		public PsychedelicFullScreenData GetMaterialPreset(string presetName)
		{
			return null;
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7F")]
		[Address(RVA = "0x71E190", Offset = "0x71D390", VA = "0x18071E190")]
		public PsychedelicFullScreenFeature()
		{
		}

		// Token: 0x040020B0 RID: 8368
		[Token(Token = "0x40020B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Settings")]
		private PsychedelicFullScreenFeature.Settings _settings;

		// Token: 0x040020B1 RID: 8369
		[Token(Token = "0x40020B1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BLEND_ID;

		// Token: 0x040020B2 RID: 8370
		[Token(Token = "0x40020B2")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int NOISE_SCALE_ID;

		// Token: 0x040020B3 RID: 8371
		[Token(Token = "0x40020B3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int PAN_SPEED_ID;

		// Token: 0x040020B4 RID: 8372
		[Token(Token = "0x40020B4")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int DOES_BOUNCE_ID;

		// Token: 0x040020B5 RID: 8373
		[Token(Token = "0x40020B5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int AMPLITUDE_ID;

		// Token: 0x040020B6 RID: 8374
		[Token(Token = "0x40020B6")]
		[FieldOffset(Offset = "0x28")]
		private PsychedelicFullScreenPass _psychedelicPass;

		// Token: 0x0200068E RID: 1678
		[Token(Token = "0x200068E")]
		[Serializable]
		public class Settings
		{
			// Token: 0x06002B81 RID: 11137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B81")]
			[Address(RVA = "0x71E8B0", Offset = "0x71DAB0", VA = "0x18071E8B0")]
			public Settings()
			{
			}

			// Token: 0x040020B7 RID: 8375
			[Token(Token = "0x40020B7")]
			[FieldOffset(Offset = "0x10")]
			public string profilerTag;

			// Token: 0x040020B8 RID: 8376
			[Token(Token = "0x40020B8")]
			[FieldOffset(Offset = "0x18")]
			public RenderPassEvent renderPassEvent;

			// Token: 0x040020B9 RID: 8377
			[Token(Token = "0x40020B9")]
			[FieldOffset(Offset = "0x20")]
			public Material passMaterial;

			// Token: 0x040020BA RID: 8378
			[Token(Token = "0x40020BA")]
			[FieldOffset(Offset = "0x28")]
			[Header("Active Properties")]
			public PsychedelicFullScreenFeature.MaterialProperties ActiveProperties;

			// Token: 0x040020BB RID: 8379
			[Token(Token = "0x40020BB")]
			[FieldOffset(Offset = "0x30")]
			[Header("Presets")]
			public List<PsychedelicFullScreenFeature.MaterialPropertyPreset> MaterialPresets;
		}

		// Token: 0x0200068F RID: 1679
		[Token(Token = "0x200068F")]
		[Serializable]
		public class MaterialPropertyPreset
		{
			// Token: 0x06002B82 RID: 11138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B82")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public MaterialPropertyPreset()
			{
			}

			// Token: 0x040020BC RID: 8380
			[Token(Token = "0x40020BC")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x040020BD RID: 8381
			[Token(Token = "0x40020BD")]
			[FieldOffset(Offset = "0x18")]
			public PsychedelicFullScreenData Data;
		}

		// Token: 0x02000690 RID: 1680
		[Token(Token = "0x2000690")]
		[Serializable]
		public class MaterialProperties
		{
			// Token: 0x06002B83 RID: 11139 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6002B83")]
			[Address(RVA = "0x71D940", Offset = "0x71CB40", VA = "0x18071D940")]
			public PsychedelicFullScreenFeature.MaterialProperties Clone()
			{
				return null;
			}

			// Token: 0x06002B84 RID: 11140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B84")]
			[Address(RVA = "0x71D9E0", Offset = "0x71CBE0", VA = "0x18071D9E0")]
			public MaterialProperties()
			{
			}

			// Token: 0x040020BE RID: 8382
			[Token(Token = "0x40020BE")]
			[FieldOffset(Offset = "0x10")]
			public float NoiseScale;

			// Token: 0x040020BF RID: 8383
			[Token(Token = "0x40020BF")]
			[FieldOffset(Offset = "0x14")]
			public float Blend;

			// Token: 0x040020C0 RID: 8384
			[Token(Token = "0x40020C0")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 PanSpeed;

			// Token: 0x040020C1 RID: 8385
			[Token(Token = "0x40020C1")]
			[FieldOffset(Offset = "0x20")]
			public bool DoesBounce;

			// Token: 0x040020C2 RID: 8386
			[Token(Token = "0x40020C2")]
			[FieldOffset(Offset = "0x24")]
			public float Amplitude;
		}
	}
}
