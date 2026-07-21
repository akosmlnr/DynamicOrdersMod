using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Effects;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200092A RID: 2346
	[Token(Token = "0x200092A")]
	public class PropertyUtility : Singleton<PropertyUtility>
	{
		// Token: 0x06003F30 RID: 16176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x864300", Offset = "0x863500", VA = "0x180864300", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x864FB0", Offset = "0x8641B0", VA = "0x180864FB0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F32")]
		[Address(RVA = "0x864D50", Offset = "0x863F50", VA = "0x180864D50")]
		public List<Effect> GetProperties(int tier)
		{
			return null;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F33")]
		[Address(RVA = "0x864990", Offset = "0x863B90", VA = "0x180864990")]
		public List<Effect> GetProperties(List<string> ids)
		{
			return null;
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x864E90", Offset = "0x864090", VA = "0x180864E90")]
		public static PropertyUtility.PropertyData GetPropertyData(EProperty property)
		{
			return null;
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x864460", Offset = "0x863660", VA = "0x180864460")]
		public static PropertyUtility.DrugTypeData GetDrugTypeData(EDrugType drugType)
		{
			return null;
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x864580", Offset = "0x863780", VA = "0x180864580")]
		public static List<Color32> GetOrderedPropertyColors(List<Effect> properties)
		{
			return null;
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x864FF0", Offset = "0x8641F0", VA = "0x180864FF0")]
		public PropertyUtility()
		{
		}

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0x28")]
		public List<PropertyUtility.PropertyData> PropertyDatas;

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x30")]
		public List<PropertyUtility.DrugTypeData> DrugTypeDatas;

		// Token: 0x04002DF8 RID: 11768
		[Token(Token = "0x4002DF8")]
		[FieldOffset(Offset = "0x38")]
		public List<Effect> AllProperties;

		// Token: 0x04002DF9 RID: 11769
		[Token(Token = "0x4002DF9")]
		[FieldOffset(Offset = "0x40")]
		[Header("Test Mixing")]
		public List<ProductDefinition> Products;

		// Token: 0x04002DFA RID: 11770
		[Token(Token = "0x4002DFA")]
		[FieldOffset(Offset = "0x48")]
		public List<PropertyItemDefinition> Properties;

		// Token: 0x04002DFB RID: 11771
		[Token(Token = "0x4002DFB")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, Effect> PropertiesDict;

		// Token: 0x0200092B RID: 2347
		[Token(Token = "0x200092B")]
		[Serializable]
		public class PropertyData
		{
			// Token: 0x06003F38 RID: 16184 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003F38")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public PropertyData()
			{
			}

			// Token: 0x04002DFC RID: 11772
			[Token(Token = "0x4002DFC")]
			[FieldOffset(Offset = "0x10")]
			public EProperty Property;

			// Token: 0x04002DFD RID: 11773
			[Token(Token = "0x4002DFD")]
			[FieldOffset(Offset = "0x18")]
			public string Name;

			// Token: 0x04002DFE RID: 11774
			[Token(Token = "0x4002DFE")]
			[FieldOffset(Offset = "0x20")]
			public string Description;

			// Token: 0x04002DFF RID: 11775
			[Token(Token = "0x4002DFF")]
			[FieldOffset(Offset = "0x28")]
			public Color Color;
		}

		// Token: 0x0200092C RID: 2348
		[Token(Token = "0x200092C")]
		[Serializable]
		public class DrugTypeData
		{
			// Token: 0x06003F39 RID: 16185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003F39")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public DrugTypeData()
			{
			}

			// Token: 0x04002E00 RID: 11776
			[Token(Token = "0x4002E00")]
			[FieldOffset(Offset = "0x10")]
			public EDrugType DrugType;

			// Token: 0x04002E01 RID: 11777
			[Token(Token = "0x4002E01")]
			[FieldOffset(Offset = "0x18")]
			public string Name;

			// Token: 0x04002E02 RID: 11778
			[Token(Token = "0x4002E02")]
			[FieldOffset(Offset = "0x20")]
			public Color Color;
		}
	}
}
