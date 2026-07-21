using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Effects;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Product.Packaging;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000912 RID: 2322
	[Token(Token = "0x2000912")]
	[CreateAssetMenu(fileName = "ProductDefinition", menuName = "ScriptableObjects/ProductDefinition", order = 1)]
	[Serializable]
	public class ProductDefinition : PropertyItemDefinition, ISaveable
	{
		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		[Token(Token = "0x170009B9")]
		public EDrugType DrugType
		{
			[Token(Token = "0x6003DFC")]
			[Address(RVA = "0x837D40", Offset = "0x836F40", VA = "0x180837D40")]
			get
			{
				return EDrugType.Marijuana;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x00011C10 File Offset: 0x0000FE10
		[Token(Token = "0x170009BA")]
		public float Price
		{
			[Token(Token = "0x6003DFD")]
			[Address(RVA = "0x837DA0", Offset = "0x836FA0", VA = "0x180837DA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003DFF RID: 15871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009BB")]
		public List<StationRecipe> Recipes
		{
			[Token(Token = "0x6003DFE")]
			[Address(RVA = "0x514940", Offset = "0x513B40", VA = "0x180514940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DFF")]
			[Address(RVA = "0x51C410", Offset = "0x51B610", VA = "0x18051C410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009BC")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003E00")]
			[Address(RVA = "0x837E30", Offset = "0x837030", VA = "0x180837E30", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06003E01 RID: 15873 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009BD")]
		public string SaveFileName
		{
			[Token(Token = "0x6003E01")]
			[Address(RVA = "0x837E30", Offset = "0x837030", VA = "0x180837E30", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06003E02 RID: 15874 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009BE")]
		public Loader Loader
		{
			[Token(Token = "0x6003E02")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x00011C28 File Offset: 0x0000FE28
		[Token(Token = "0x170009BF")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003E03")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003E05 RID: 15877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C0")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003E04")]
			[Address(RVA = "0x514950", Offset = "0x513B50", VA = "0x180514950", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E05")]
			[Address(RVA = "0x504620", Offset = "0x503820", VA = "0x180504620", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C1")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003E06")]
			[Address(RVA = "0x5218F0", Offset = "0x520AF0", VA = "0x1805218F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E07")]
			[Address(RVA = "0x837E40", Offset = "0x837040", VA = "0x180837E40", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x00011C40 File Offset: 0x0000FE40
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C2")]
		public bool HasChanged
		{
			[Token(Token = "0x6003E08")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003E09")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E0A")]
		[Address(RVA = "0x837690", Offset = "0x836890", VA = "0x180837690", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0x837B90", Offset = "0x836D90", VA = "0x180837B90")]
		public void OnValidate()
		{
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0C")]
		[Address(RVA = "0x837970", Offset = "0x836B70", VA = "0x180837970")]
		public void Initialize(List<Effect> properties, List<EDrugType> drugTypes)
		{
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x8378E0", Offset = "0x836AE0", VA = "0x1808378E0", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x6003E0E")]
		[Address(RVA = "0x8375C0", Offset = "0x8367C0", VA = "0x1808375C0")]
		public float GetAddictiveness()
		{
			return 0f;
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E0F")]
		[Address(RVA = "0x8374D0", Offset = "0x8366D0", VA = "0x1808374D0")]
		public void CleanRecipes()
		{
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E10")]
		[Address(RVA = "0x8373B0", Offset = "0x8365B0", VA = "0x1808373B0")]
		public void AddRecipe(StationRecipe recipe)
		{
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E11")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "32")]
		public virtual void GenerateAppearanceSettings()
		{
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E12")]
		[Address(RVA = "0x837710", Offset = "0x836910", VA = "0x180837710", Slot = "33")]
		public virtual ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E13")]
		[Address(RVA = "0x8378A0", Offset = "0x836AA0", VA = "0x1808378A0", Slot = "34")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E14")]
		[Address(RVA = "0x837C10", Offset = "0x836E10", VA = "0x180837C10")]
		public ProductDefinition()
		{
		}

		// Token: 0x04002D7A RID: 11642
		[Token(Token = "0x4002D7A")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Product Settings")]
		public List<DrugTypeContainer> DrugTypes;

		// Token: 0x04002D7B RID: 11643
		[Token(Token = "0x4002D7B")]
		[FieldOffset(Offset = "0xC8")]
		public float LawIntensityChange;

		// Token: 0x04002D7C RID: 11644
		[Token(Token = "0x4002D7C")]
		[FieldOffset(Offset = "0xCC")]
		public float BasePrice;

		// Token: 0x04002D7D RID: 11645
		[Token(Token = "0x4002D7D")]
		[FieldOffset(Offset = "0xD0")]
		public float MarketValue;

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0xD8")]
		public FunctionalProduct FunctionalProduct;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0xE0")]
		public int NPCEffectDuration;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0xE4")]
		public int PlayerEffectDuration;

		// Token: 0x04002D81 RID: 11649
		[Token(Token = "0x4002D81")]
		[FieldOffset(Offset = "0xE8")]
		[Range(0f, 1f)]
		public float BaseAddictiveness;

		// Token: 0x04002D82 RID: 11650
		[Token(Token = "0x4002D82")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Packaging that can be applied to this product. MUST BE ORDERED FROm LOWEST TO HIGHEST QUANTITY")]
		public PackagingDefinition[] ValidPackaging;

		// Token: 0x04002D83 RID: 11651
		[Token(Token = "0x4002D83")]
		[FieldOffset(Offset = "0xF8")]
		[Header("Product References")]
		public ProductConsumeAnimation ConsumeAnimation;
	}
}
