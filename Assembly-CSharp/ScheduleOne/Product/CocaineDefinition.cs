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
	// Token: 0x02000900 RID: 2304
	[Token(Token = "0x2000900")]
	[CreateAssetMenu(fileName = "CocaineDefinition", menuName = "ScriptableObjects/Item Definitions/CocaineDefinition", order = 1)]
	[Serializable]
	public class CocaineDefinition : ProductDefinition
	{
		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003DAF RID: 15791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B3")]
		public CocaineAppearanceSettings AppearanceSettings
		{
			[Token(Token = "0x6003DAE")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DAF")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DB0")]
		[Address(RVA = "0x82B400", Offset = "0x82A600", VA = "0x18082B400", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB1")]
		[Address(RVA = "0x82B630", Offset = "0x82A830", VA = "0x18082B630")]
		public void Initialize(List<Effect> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance)
		{
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DB2")]
		[Address(RVA = "0x82B480", Offset = "0x82A680", VA = "0x18082B480", Slot = "33")]
		public override ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB3")]
		[Address(RVA = "0x82ADE0", Offset = "0x829FE0", VA = "0x18082ADE0", Slot = "32")]
		public override void GenerateAppearanceSettings()
		{
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB4")]
		[Address(RVA = "0x82AC80", Offset = "0x829E80", VA = "0x18082AC80")]
		private void ApplyAppearanceSettings()
		{
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DB5")]
		[Address(RVA = "0x82AE20", Offset = "0x82A020", VA = "0x18082AE20")]
		public static CocaineAppearanceSettings GetAppearanceSettings(List<Effect> properties)
		{
			return null;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB6")]
		[Address(RVA = "0x82B740", Offset = "0x82A940", VA = "0x18082B740")]
		public CocaineDefinition()
		{
		}

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[FieldOffset(Offset = "0x120")]
		[Header("Materials")]
		public Material RockMaterial;
	}
}
