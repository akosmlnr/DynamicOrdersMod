using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000CC8 RID: 3272
	[Token(Token = "0x2000CC8")]
	public class VehicleCanvas : Singleton<VehicleCanvas>
	{
		// Token: 0x06005F66 RID: 24422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F66")]
		[Address(RVA = "0xA1D830", Offset = "0xA1CA30", VA = "0x180A1D830", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F67")]
		[Address(RVA = "0xA1D980", Offset = "0xA1CB80", VA = "0x180A1D980")]
		private void Subscribe()
		{
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F68")]
		[Address(RVA = "0xA1DD00", Offset = "0xA1CF00", VA = "0x180A1DD00")]
		private void Update()
		{
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F69")]
		[Address(RVA = "0xA1D7C0", Offset = "0xA1C9C0", VA = "0x180A1D7C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F6A")]
		[Address(RVA = "0xA1DE70", Offset = "0xA1D070", VA = "0x180A1DE70")]
		private void VehicleEntered(LandVehicle veh)
		{
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F6B")]
		[Address(RVA = "0xA1DED0", Offset = "0xA1D0D0", VA = "0x180A1DED0")]
		private void VehicleExited(LandVehicle veh, Transform exitPoint)
		{
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F6C")]
		[Address(RVA = "0xA1DBA0", Offset = "0xA1CDA0", VA = "0x180A1DBA0")]
		private void UpdateSpeedText()
		{
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0xA1DF10", Offset = "0xA1D110", VA = "0x180A1DF10")]
		public VehicleCanvas()
		{
		}

		// Token: 0x040041BB RID: 16827
		[Token(Token = "0x40041BB")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040041BC RID: 16828
		[Token(Token = "0x40041BC")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI SpeedText;

		// Token: 0x040041BD RID: 16829
		[Token(Token = "0x40041BD")]
		[FieldOffset(Offset = "0x38")]
		public GameObject DriverPromptsContainer;

		// Token: 0x040041BE RID: 16830
		[Token(Token = "0x40041BE")]
		[FieldOffset(Offset = "0x40")]
		private LandVehicle currentVehicle;
	}
}
