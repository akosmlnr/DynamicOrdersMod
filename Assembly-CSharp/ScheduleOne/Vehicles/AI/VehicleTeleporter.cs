using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002D5 RID: 725
	[Token(Token = "0x20002D5")]
	[RequireComponent(typeof(LandVehicle))]
	public class VehicleTeleporter : MonoBehaviour
	{
		// Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EC")]
		[Address(RVA = "0xB175A0", Offset = "0xB167A0", VA = "0x180B175A0")]
		public void MoveToGraph(bool resetRotation = true)
		{
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010ED")]
		[Address(RVA = "0xB17830", Offset = "0xB16A30", VA = "0x180B17830")]
		public void MoveToRoadNetwork(bool resetRotation = true)
		{
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VehicleTeleporter()
		{
		}
	}
}
