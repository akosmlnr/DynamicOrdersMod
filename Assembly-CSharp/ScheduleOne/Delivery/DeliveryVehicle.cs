using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Delivery
{
	// Token: 0x02000735 RID: 1845
	[Token(Token = "0x2000735")]
	[RequireComponent(typeof(LandVehicle))]
	public class DeliveryVehicle : MonoBehaviour
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003046 RID: 12358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E6")]
		public LandVehicle Vehicle
		{
			[Token(Token = "0x6003045")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003046")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E7")]
		public DeliveryInstance ActiveDelivery
		{
			[Token(Token = "0x6003047")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003048")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003049")]
		[Address(RVA = "0x7645D0", Offset = "0x7637D0", VA = "0x1807645D0")]
		private void Awake()
		{
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304A")]
		[Address(RVA = "0x764380", Offset = "0x763580", VA = "0x180764380")]
		public void Activate(DeliveryInstance instance)
		{
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304B")]
		[Address(RVA = "0x764670", Offset = "0x763870", VA = "0x180764670")]
		public void Deactivate()
		{
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304C")]
		[Address(RVA = "0x764830", Offset = "0x763A30", VA = "0x180764830")]
		public DeliveryVehicle()
		{
		}

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0x30")]
		public string GUID;
	}
}
