using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Effects;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000934 RID: 2356
	[Token(Token = "0x2000934")]
	[CreateAssetMenu(fileName = "ShroomDefinition", menuName = "ScriptableObjects/Item Definitions/ShroomDefinition", order = 1)]
	[Serializable]
	public class ShroomDefinition : ProductDefinition
	{
		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E2")]
		public Material ShroomMaterial
		{
			[Token(Token = "0x6003F53")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F54")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003F56 RID: 16214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E3")]
		public Material BulkMaterial
		{
			[Token(Token = "0x6003F55")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F56")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06003F57 RID: 16215 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003F58 RID: 16216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E4")]
		public Material EyeballMaterial
		{
			[Token(Token = "0x6003F57")]
			[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F58")]
			[Address(RVA = "0x5A45A0", Offset = "0x5A37A0", VA = "0x1805A45A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06003F59 RID: 16217 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003F5A RID: 16218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E5")]
		public ShroomAppearanceSettings AppearanceSettings
		{
			[Token(Token = "0x6003F59")]
			[Address(RVA = "0x57F810", Offset = "0x57EA10", VA = "0x18057F810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F5A")]
			[Address(RVA = "0x57F850", Offset = "0x57EA50", VA = "0x18057F850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5B")]
		[Address(RVA = "0x6B9960", Offset = "0x6B8B60", VA = "0x1806B9960", Slot = "4")]
		public override void ValidateDefinition()
		{
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5C")]
		[Address(RVA = "0x866550", Offset = "0x865750", VA = "0x180866550")]
		public void Initialize(List<Effect> properties, List<EDrugType> drugTypes, ShroomAppearanceSettings _appearance)
		{
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F5D")]
		[Address(RVA = "0x866320", Offset = "0x865520", VA = "0x180866320", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F5E")]
		[Address(RVA = "0x8663A0", Offset = "0x8655A0", VA = "0x1808663A0", Slot = "33")]
		public override ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F5F")]
		[Address(RVA = "0x8652C0", Offset = "0x8644C0", VA = "0x1808652C0", Slot = "32")]
		public override void GenerateAppearanceSettings()
		{
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F60")]
		[Address(RVA = "0x865310", Offset = "0x864510", VA = "0x180865310")]
		private void GenerateMaterials()
		{
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F61")]
		[Address(RVA = "0x865B40", Offset = "0x864D40", VA = "0x180865B40")]
		public static ShroomAppearanceSettings GetAppearanceSettings(List<Effect> properties)
		{
			return null;
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F62")]
		[Address(RVA = "0x82B740", Offset = "0x82A940", VA = "0x18082B740")]
		public ShroomDefinition()
		{
		}
	}
}
