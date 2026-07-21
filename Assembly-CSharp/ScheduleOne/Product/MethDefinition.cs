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
	// Token: 0x0200090B RID: 2315
	[Token(Token = "0x200090B")]
	[CreateAssetMenu(fileName = "MethDefinition", menuName = "ScriptableObjects/Item Definitions/MethDefinition", order = 1)]
	[Serializable]
	public class MethDefinition : ProductDefinition
	{
		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003DD6 RID: 15830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B5")]
		public MethAppearanceSettings AppearanceSettings
		{
			[Token(Token = "0x6003DD5")]
			[Address(RVA = "0x57F810", Offset = "0x57EA10", VA = "0x18057F810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DD6")]
			[Address(RVA = "0x57F850", Offset = "0x57EA50", VA = "0x18057F850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x82DDF0", Offset = "0x82CFF0", VA = "0x18082DDF0", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x82E020", Offset = "0x82D220", VA = "0x18082E020")]
		public void Initialize(List<Effect> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance)
		{
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x82DE70", Offset = "0x82D070", VA = "0x18082DE70", Slot = "33")]
		public override ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDA")]
		[Address(RVA = "0x82D7D0", Offset = "0x82C9D0", VA = "0x18082D7D0", Slot = "32")]
		public override void GenerateAppearanceSettings()
		{
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x82D670", Offset = "0x82C870", VA = "0x18082D670")]
		private void ApplyAppearanceSettings()
		{
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x82D810", Offset = "0x82CA10", VA = "0x18082D810")]
		public static MethAppearanceSettings GetAppearanceSettings(List<Effect> properties)
		{
			return null;
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x82E130", Offset = "0x82D330", VA = "0x18082E130")]
		public MethDefinition()
		{
		}

		// Token: 0x04002D5D RID: 11613
		[Token(Token = "0x4002D5D")]
		[FieldOffset(Offset = "0x120")]
		public Material CrystalMaterial;

		// Token: 0x04002D5E RID: 11614
		[Token(Token = "0x4002D5E")]
		[FieldOffset(Offset = "0x128")]
		[ColorUsage(true, true)]
		[SerializeField]
		public Color TintColor;
	}
}
