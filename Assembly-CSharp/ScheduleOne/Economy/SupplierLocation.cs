using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020006C9 RID: 1737
	[Token(Token = "0x20006C9")]
	public class SupplierLocation : MonoBehaviour
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x170007B1")]
		public bool IsOccupied
		{
			[Token(Token = "0x6002DEF")]
			[Address(RVA = "0x74E0E0", Offset = "0x74D2E0", VA = "0x18074E0E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002DF1 RID: 11761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B2")]
		public Supplier ActiveSupplier
		{
			[Token(Token = "0x6002DF0")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DF1")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF2")]
		[Address(RVA = "0x74D940", Offset = "0x74CB40", VA = "0x18074D940")]
		public void Awake()
		{
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF3")]
		[Address(RVA = "0x74DF00", Offset = "0x74D100", VA = "0x18074DF00")]
		private void Start()
		{
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF4")]
		[Address(RVA = "0x74DBF0", Offset = "0x74CDF0", VA = "0x18074DBF0")]
		private void OnSleep()
		{
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF5")]
		[Address(RVA = "0x74DB70", Offset = "0x74CD70", VA = "0x18074DB70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF6")]
		[Address(RVA = "0x74DC00", Offset = "0x74CE00", VA = "0x18074DC00")]
		public void SetActiveSupplier(Supplier supplier)
		{
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF7")]
		[Address(RVA = "0x74DE30", Offset = "0x74D030", VA = "0x18074DE30")]
		private void SetDeliveryBaysVisible(bool visible)
		{
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF8")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SupplierLocation()
		{
		}

		// Token: 0x04002206 RID: 8710
		[Token(Token = "0x4002206")]
		[FieldOffset(Offset = "0x0")]
		public static List<SupplierLocation> AllLocations;

		// Token: 0x04002208 RID: 8712
		[Token(Token = "0x4002208")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public string LocationName;

		// Token: 0x04002209 RID: 8713
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x30")]
		public string LocationDescription;

		// Token: 0x0400220A RID: 8714
		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform GenericContainer;

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x40")]
		public Transform SupplierStandPoint;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x48")]
		public WorldStorageEntity[] DeliveryBays;

		// Token: 0x0400220D RID: 8717
		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x50")]
		public POI PoI;

		// Token: 0x0400220E RID: 8718
		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x58")]
		private SupplierLocationConfiguration[] configs;
	}
}
