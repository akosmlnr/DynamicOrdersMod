using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D5 RID: 469
	[Token(Token = "0x20001D5")]
	[Serializable]
	public abstract class BaseShaderDefinition : IProfileDefinition
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C6")]
		public string shaderName
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001C7")]
		public ProfileGroupSection[] groups
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x8D0AA0", Offset = "0x8CFCA0", VA = "0x1808D0AA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001C8")]
		public ProfileFeatureSection[] features
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x8D0A50", Offset = "0x8CFC50", VA = "0x1808D0A50", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x8D07A0", Offset = "0x8CF9A0", VA = "0x1808D07A0", Slot = "7")]
		public ProfileFeatureDefinition GetFeatureDefinition(string featureKey)
		{
			return null;
		}

		// Token: 0x060008F8 RID: 2296
		[Token(Token = "0x60008F8")]
		protected abstract ProfileFeatureSection[] ProfileFeatureSection();

		// Token: 0x060008F9 RID: 2297
		[Token(Token = "0x60008F9")]
		protected abstract ProfileGroupSection[] ProfileDefinitionTable();

		// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		protected BaseShaderDefinition()
		{
		}

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x18")]
		private ProfileGroupSection[] m_ProfileDefinitions;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProfileFeatureSection[] m_ProfileFeatures;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, ProfileFeatureDefinition> m_KeyToFeature;
	}
}
