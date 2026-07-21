using System;
using Il2CppDummyDll;
using ScheduleOne.Configuration;
using ScheduleOne.Core.Deliveries;
using UnityEngine;

namespace ScheduleOne.Delivery
{
	// Token: 0x0200072B RID: 1835
	[Token(Token = "0x200072B")]
	[CreateAssetMenu(fileName = "DeliveryConfiguration", menuName = "ScheduleOne/Configurations/Delivery Configuration")]
	public class DeliveryConfiguration : Configuration<DeliverySettings>
	{
		// Token: 0x06002FF9 RID: 12281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x760D10", Offset = "0x75FF10", VA = "0x180760D10")]
		public DeliveryConfiguration()
		{
		}
	}
}
