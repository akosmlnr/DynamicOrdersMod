using System;
using System.Runtime.CompilerServices;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using UnityEngine.Events;

namespace ScheduleOne.Delivery
{
	// Token: 0x0200072D RID: 1837
	[Token(Token = "0x200072D")]
	[Serializable]
	public class DeliveryInstance
	{
		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007DA")]
		[CodegenExclude]
		public DeliveryVehicle ActiveVehicle
		{
			[Token(Token = "0x6002FFA")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002FFB")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007DB")]
		[CodegenExclude]
		public Property Destination
		{
			[Token(Token = "0x6002FFC")]
			[Address(RVA = "0x761390", Offset = "0x760590", VA = "0x180761390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007DC")]
		[CodegenExclude]
		public LoadingDock LoadingDock
		{
			[Token(Token = "0x6002FFD")]
			[Address(RVA = "0x761420", Offset = "0x760620", VA = "0x180761420")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x7612F0", Offset = "0x7604F0", VA = "0x1807612F0")]
		public DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, StringIntPair[] items, EDeliveryStatus status, int timeUntilArrival)
		{
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public DeliveryInstance()
		{
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x6003000")]
		[Address(RVA = "0x760FF0", Offset = "0x7601F0", VA = "0x180760FF0")]
		public int GetTimeStatus()
		{
			return 0;
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003001")]
		[Address(RVA = "0x761030", Offset = "0x760230", VA = "0x180761030")]
		public void SetStatus(EDeliveryStatus status)
		{
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003002")]
		[Address(RVA = "0x760D50", Offset = "0x75FF50", VA = "0x180760D50")]
		public void AddItemsToDeliveryVehicle()
		{
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003003")]
		[Address(RVA = "0x760F20", Offset = "0x760120", VA = "0x180760F20")]
		public DeliveryReceipt GetReceipt()
		{
			return null;
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003004")]
		[Address(RVA = "0x761010", Offset = "0x760210", VA = "0x180761010")]
		public void OnTimePass(int minutes)
		{
		}

		// Token: 0x0400236B RID: 9067
		[Token(Token = "0x400236B")]
		[FieldOffset(Offset = "0x10")]
		public string DeliveryID;

		// Token: 0x0400236C RID: 9068
		[Token(Token = "0x400236C")]
		[FieldOffset(Offset = "0x18")]
		public string StoreName;

		// Token: 0x0400236D RID: 9069
		[Token(Token = "0x400236D")]
		[FieldOffset(Offset = "0x20")]
		public string DestinationCode;

		// Token: 0x0400236E RID: 9070
		[Token(Token = "0x400236E")]
		[FieldOffset(Offset = "0x28")]
		public int LoadingDockIndex;

		// Token: 0x0400236F RID: 9071
		[Token(Token = "0x400236F")]
		[FieldOffset(Offset = "0x30")]
		public StringIntPair[] Items;

		// Token: 0x04002370 RID: 9072
		[Token(Token = "0x4002370")]
		[FieldOffset(Offset = "0x38")]
		public EDeliveryStatus Status;

		// Token: 0x04002371 RID: 9073
		[Token(Token = "0x4002371")]
		[FieldOffset(Offset = "0x3C")]
		public int TimeUntilArrival;

		// Token: 0x04002373 RID: 9075
		[Token(Token = "0x4002373")]
		[FieldOffset(Offset = "0x48")]
		[CodegenExclude]
		[NonSerialized]
		public UnityEvent onDeliveryCompleted;
	}
}
