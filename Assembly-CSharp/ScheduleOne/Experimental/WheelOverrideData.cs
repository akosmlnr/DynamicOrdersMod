using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Experimental
{
	// Token: 0x02000C05 RID: 3077
	[Token(Token = "0x2000C05")]
	[CreateAssetMenu(fileName = "WheelOverrideData", menuName = "ScriptableObjects/Vehicle/Wheel override Data")]
	public class WheelOverrideData : ScriptableObject
	{
		// Token: 0x06005A8B RID: 23179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public WheelOverrideData()
		{
		}

		// Token: 0x04003CF1 RID: 15601
		[Token(Token = "0x4003CF1")]
		[FieldOffset(Offset = "0x18")]
		public VehicleSettings Settings;

		// Token: 0x04003CF2 RID: 15602
		[Token(Token = "0x4003CF2")]
		[FieldOffset(Offset = "0x20")]
		public WheelOverrideData.OverrideCategory Categories;

		// Token: 0x04003CF3 RID: 15603
		[Token(Token = "0x4003CF3")]
		[FieldOffset(Offset = "0x24")]
		public WheelOverrideData.WheelOverrides WheelFlags;

		// Token: 0x04003CF4 RID: 15604
		[Token(Token = "0x4003CF4")]
		[FieldOffset(Offset = "0x28")]
		public WheelOverrideData.WheelFrictionOverrides ForwardFrictionFlags;

		// Token: 0x04003CF5 RID: 15605
		[Token(Token = "0x4003CF5")]
		[FieldOffset(Offset = "0x2C")]
		public WheelOverrideData.WheelFrictionOverrides SidewaysFrictionFlags;

		// Token: 0x02000C06 RID: 3078
		[Token(Token = "0x2000C06")]
		[Flags]
		public enum OverrideCategory
		{
			// Token: 0x04003CF7 RID: 15607
			[Token(Token = "0x4003CF7")]
			None = 0,
			// Token: 0x04003CF8 RID: 15608
			[Token(Token = "0x4003CF8")]
			Wheels = 1
		}

		// Token: 0x02000C07 RID: 3079
		[Token(Token = "0x2000C07")]
		[Flags]
		public enum WheelOverrides
		{
			// Token: 0x04003CFA RID: 15610
			[Token(Token = "0x4003CFA")]
			None = 0,
			// Token: 0x04003CFB RID: 15611
			[Token(Token = "0x4003CFB")]
			ForwardFriction = 1,
			// Token: 0x04003CFC RID: 15612
			[Token(Token = "0x4003CFC")]
			SidewaysFriction = 2
		}

		// Token: 0x02000C08 RID: 3080
		[Token(Token = "0x2000C08")]
		[Flags]
		public enum WheelFrictionOverrides
		{
			// Token: 0x04003CFE RID: 15614
			[Token(Token = "0x4003CFE")]
			None = 0,
			// Token: 0x04003CFF RID: 15615
			[Token(Token = "0x4003CFF")]
			ExtremumSlip = 1,
			// Token: 0x04003D00 RID: 15616
			[Token(Token = "0x4003D00")]
			ExtremumValue = 2,
			// Token: 0x04003D01 RID: 15617
			[Token(Token = "0x4003D01")]
			AsymptoteSlip = 4,
			// Token: 0x04003D02 RID: 15618
			[Token(Token = "0x4003D02")]
			AsymptoteValue = 8,
			// Token: 0x04003D03 RID: 15619
			[Token(Token = "0x4003D03")]
			Stiffness = 16
		}
	}
}
