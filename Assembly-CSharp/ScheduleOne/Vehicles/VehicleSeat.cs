using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	public class VehicleSeat : MonoBehaviour
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x17000376")]
		public bool isOccupied
		{
			[Token(Token = "0x600102A")]
			[Address(RVA = "0xB168F0", Offset = "0xB15AF0", VA = "0x180B168F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VehicleSeat()
		{
		}

		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0x20")]
		public bool isDriverSeat;

		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x28")]
		public Player Occupant;
	}
}
