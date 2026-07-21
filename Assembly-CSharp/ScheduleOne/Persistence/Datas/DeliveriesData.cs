using System;
using Il2CppDummyDll;
using ScheduleOne.Delivery;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200045E RID: 1118
	[Token(Token = "0x200045E")]
	public class DeliveriesData : SaveData
	{
		// Token: 0x06001A97 RID: 6807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x6036F0", Offset = "0x6028F0", VA = "0x1806036F0")]
		public DeliveriesData(DeliveryInstance[] deliveries, VehicleData[] deliveryVehicles, DeliveryReceipt[] deliveryHistory, DeliveryReceipt[] displayedDeliveryHistory)
		{
		}

		// Token: 0x04001653 RID: 5715
		[Token(Token = "0x4001653")]
		[FieldOffset(Offset = "0x28")]
		public DeliveryInstance[] ActiveDeliveries;

		// Token: 0x04001654 RID: 5716
		[Token(Token = "0x4001654")]
		[FieldOffset(Offset = "0x30")]
		public VehicleData[] DeliveryVehicles;

		// Token: 0x04001655 RID: 5717
		[Token(Token = "0x4001655")]
		[FieldOffset(Offset = "0x38")]
		public DeliveryReceipt[] DeliveryHistory;

		// Token: 0x04001656 RID: 5718
		[Token(Token = "0x4001656")]
		[FieldOffset(Offset = "0x40")]
		public DeliveryReceipt[] DisplayedDeliveryHistory;
	}
}
