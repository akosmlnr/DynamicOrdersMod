using System;
using Il2CppDummyDll;
using ScheduleOne.Clothing;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C60 RID: 3168
	[Token(Token = "0x2000C60")]
	public class ClothingSlotUI : ItemSlotUI
	{
		// Token: 0x06005CAB RID: 23723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0x9D9130", Offset = "0x9D8330", VA = "0x1809D9130")]
		private void Start()
		{
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0x9D9100", Offset = "0x9D8300", VA = "0x1809D9100")]
		public ClothingSlotUI()
		{
		}

		// Token: 0x04003F16 RID: 16150
		[Token(Token = "0x4003F16")]
		[FieldOffset(Offset = "0xA8")]
		public EClothingSlot SlotType;

		// Token: 0x04003F17 RID: 16151
		[Token(Token = "0x4003F17")]
		[FieldOffset(Offset = "0xB0")]
		public Image SlotTypeImage;
	}
}
