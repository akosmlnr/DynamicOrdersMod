using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	public class VehicleAxle : MonoBehaviour
	{
		// Token: 0x06000FCA RID: 4042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0xAFCA40", Offset = "0xAFBC40", VA = "0x180AFCA40", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0xAFCAB0", Offset = "0xAFBCB0", VA = "0x180AFCAB0", Slot = "5")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public VehicleAxle()
		{
		}

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000E16")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		protected Wheel wheel;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x28")]
		private Transform model;
	}
}
