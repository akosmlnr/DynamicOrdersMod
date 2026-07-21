using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Vehicles.Modification
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	public class VehicleColors : Singleton<VehicleColors>
	{
		// Token: 0x06001053 RID: 4179 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001053")]
		[Address(RVA = "0xB12C90", Offset = "0xB11E90", VA = "0x180B12C90")]
		public string GetColorName(EVehicleColor c)
		{
			return null;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00007B48 File Offset: 0x00005D48
		[Token(Token = "0x6001054")]
		[Address(RVA = "0xB12D70", Offset = "0xB11F70", VA = "0x180B12D70")]
		public Color32 GetColorUIColor(EVehicleColor c)
		{
			return default(Color32);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001055")]
		[Address(RVA = "0xB12E50", Offset = "0xB12050", VA = "0x180B12E50")]
		public VehicleColors()
		{
		}

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x28")]
		public List<VehicleColors.VehicleColorData> colorLibrary;

		// Token: 0x020002B2 RID: 690
		[Token(Token = "0x20002B2")]
		[Serializable]
		public class VehicleColorData
		{
			// Token: 0x06001056 RID: 4182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001056")]
			[Address(RVA = "0xB128E0", Offset = "0xB11AE0", VA = "0x180B128E0")]
			public VehicleColorData()
			{
			}

			// Token: 0x04000EAF RID: 3759
			[Token(Token = "0x4000EAF")]
			[FieldOffset(Offset = "0x10")]
			public EVehicleColor color;

			// Token: 0x04000EB0 RID: 3760
			[Token(Token = "0x4000EB0")]
			[FieldOffset(Offset = "0x18")]
			public string colorName;

			// Token: 0x04000EB1 RID: 3761
			[Token(Token = "0x4000EB1")]
			[FieldOffset(Offset = "0x20")]
			public Color MaterialColor;

			// Token: 0x04000EB2 RID: 3762
			[Token(Token = "0x4000EB2")]
			[FieldOffset(Offset = "0x30")]
			public Color32 UIColor;
		}
	}
}
