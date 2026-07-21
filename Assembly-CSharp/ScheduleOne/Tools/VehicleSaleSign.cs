using System;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000896 RID: 2198
	[Token(Token = "0x2000896")]
	public class VehicleSaleSign : MonoBehaviour
	{
		// Token: 0x060039FD RID: 14845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FD")]
		[Address(RVA = "0x8120E0", Offset = "0x8112E0", VA = "0x1808120E0")]
		private void Awake()
		{
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VehicleSaleSign()
		{
		}

		// Token: 0x04002ABF RID: 10943
		[Token(Token = "0x4002ABF")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshPro NameLabel;

		// Token: 0x04002AC0 RID: 10944
		[Token(Token = "0x4002AC0")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshPro PriceLabel;

		// Token: 0x04002AC1 RID: 10945
		[Token(Token = "0x4002AC1")]
		[FieldOffset(Offset = "0x30")]
		public LandVehicle VehiclePrefab;
	}
}
