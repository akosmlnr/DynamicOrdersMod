using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000913 RID: 2323
	[Token(Token = "0x2000913")]
	public class ProductIconManager : Singleton<ProductIconManager>
	{
		// Token: 0x06003E15 RID: 15893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x837E60", Offset = "0x837060", VA = "0x180837E60", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E16")]
		[Address(RVA = "0x8385A0", Offset = "0x8377A0", VA = "0x1808385A0")]
		public Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			return null;
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E17")]
		[Address(RVA = "0x837FB0", Offset = "0x8371B0", VA = "0x180837FB0")]
		public Sprite GenerateIcons(string productID)
		{
			return null;
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003E18")]
		[Address(RVA = "0x838570", Offset = "0x837770", VA = "0x180838570")]
		private Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			return null;
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E19")]
		[Address(RVA = "0x8387E0", Offset = "0x8379E0", VA = "0x1808387E0")]
		public ProductIconManager()
		{
		}

		// Token: 0x04002D88 RID: 11656
		[Token(Token = "0x4002D88")]
		public const string ProductIconPath = "Textures/ProductIcons";

		// Token: 0x04002D89 RID: 11657
		[Token(Token = "0x4002D89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ProductIconManager.ProductIcon> icons;

		// Token: 0x04002D8A RID: 11658
		[Token(Token = "0x4002D8A")]
		[FieldOffset(Offset = "0x30")]
		[Header("Product and packaging")]
		public IconGenerator IconGenerator;

		// Token: 0x04002D8B RID: 11659
		[Token(Token = "0x4002D8B")]
		[FieldOffset(Offset = "0x38")]
		public ProductDefinition[] Products;

		// Token: 0x04002D8C RID: 11660
		[Token(Token = "0x4002D8C")]
		[FieldOffset(Offset = "0x40")]
		public PackagingDefinition[] Packaging;

		// Token: 0x02000914 RID: 2324
		[Token(Token = "0x2000914")]
		[Serializable]
		public class ProductIcon
		{
			// Token: 0x06003E1A RID: 15898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003E1A")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ProductIcon()
			{
			}

			// Token: 0x04002D8D RID: 11661
			[Token(Token = "0x4002D8D")]
			[FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			// Token: 0x04002D8E RID: 11662
			[Token(Token = "0x4002D8E")]
			[FieldOffset(Offset = "0x18")]
			public string ProductID;

			// Token: 0x04002D8F RID: 11663
			[Token(Token = "0x4002D8F")]
			[FieldOffset(Offset = "0x20")]
			public string PackagingID;

			// Token: 0x04002D90 RID: 11664
			[Token(Token = "0x4002D90")]
			[FieldOffset(Offset = "0x28")]
			public Sprite Icon;
		}
	}
}
