using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x02000749 RID: 1865
	[Token(Token = "0x2000749")]
	public class ClothingUtility : Singleton<ClothingUtility>
	{
		// Token: 0x060030CE RID: 12494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CE")]
		[Address(RVA = "0x75E020", Offset = "0x75D220", VA = "0x18075E020", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030CF")]
		[Address(RVA = "0x75E590", Offset = "0x75D790", VA = "0x18075E590")]
		private void OnValidate()
		{
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030D0")]
		[Address(RVA = "0x75E3F0", Offset = "0x75D5F0", VA = "0x18075E3F0")]
		public ClothingUtility.ColorData GetColorData(EClothingColor color)
		{
			return null;
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030D1")]
		[Address(RVA = "0x75E4C0", Offset = "0x75D6C0", VA = "0x18075E4C0")]
		public ClothingUtility.ClothingSlotData GetSlotData(EClothingSlot slot)
		{
			return null;
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D2")]
		[Address(RVA = "0x75ECF0", Offset = "0x75DEF0", VA = "0x18075ECF0")]
		public ClothingUtility()
		{
		}

		// Token: 0x040023E0 RID: 9184
		[Token(Token = "0x40023E0")]
		[FieldOffset(Offset = "0x28")]
		public List<ClothingUtility.ColorData> ColorDataList;

		// Token: 0x040023E1 RID: 9185
		[Token(Token = "0x40023E1")]
		[FieldOffset(Offset = "0x30")]
		public List<ClothingUtility.ClothingSlotData> ClothingSlotDataList;

		// Token: 0x0200074A RID: 1866
		[Token(Token = "0x200074A")]
		[Serializable]
		public class ColorData
		{
			// Token: 0x060030D3 RID: 12499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030D3")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ColorData()
			{
			}

			// Token: 0x040023E2 RID: 9186
			[Token(Token = "0x40023E2")]
			[FieldOffset(Offset = "0x10")]
			public EClothingColor ColorType;

			// Token: 0x040023E3 RID: 9187
			[Token(Token = "0x40023E3")]
			[FieldOffset(Offset = "0x14")]
			public Color ActualColor;

			// Token: 0x040023E4 RID: 9188
			[Token(Token = "0x40023E4")]
			[FieldOffset(Offset = "0x24")]
			public Color LabelColor;
		}

		// Token: 0x0200074B RID: 1867
		[Token(Token = "0x200074B")]
		[Serializable]
		public class ClothingSlotData
		{
			// Token: 0x060030D4 RID: 12500 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030D4")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ClothingSlotData()
			{
			}

			// Token: 0x040023E5 RID: 9189
			[Token(Token = "0x40023E5")]
			[FieldOffset(Offset = "0x10")]
			public EClothingSlot Slot;

			// Token: 0x040023E6 RID: 9190
			[Token(Token = "0x40023E6")]
			[FieldOffset(Offset = "0x18")]
			public string Name;

			// Token: 0x040023E7 RID: 9191
			[Token(Token = "0x40023E7")]
			[FieldOffset(Offset = "0x20")]
			public Sprite Icon;
		}
	}
}
