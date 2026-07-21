using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000D0A RID: 3338
	[Token(Token = "0x2000D0A")]
	public class CustomerSelector : MonoBehaviour
	{
		// Token: 0x06006115 RID: 24853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006115")]
		[Address(RVA = "0xA3FD30", Offset = "0xA3EF30", VA = "0x180A3FD30")]
		public void Awake()
		{
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006116")]
		[Address(RVA = "0xA40960", Offset = "0xA3FB60", VA = "0x180A40960")]
		public void Start()
		{
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006117")]
		[Address(RVA = "0xA406A0", Offset = "0xA3F8A0", VA = "0x180A406A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006118")]
		[Address(RVA = "0xA40570", Offset = "0xA3F770", VA = "0x180A40570")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006119")]
		[Address(RVA = "0xA407E0", Offset = "0xA3F9E0", VA = "0x180A407E0")]
		public void Open()
		{
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600611A")]
		[Address(RVA = "0x74D910", Offset = "0x74CB10", VA = "0x18074D910")]
		public void Close()
		{
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600611B")]
		[Address(RVA = "0xA3FF40", Offset = "0xA3F140", VA = "0x180A3FF40")]
		private void CreateEntry(Customer customer)
		{
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600611C")]
		[Address(RVA = "0xA404B0", Offset = "0xA3F6B0", VA = "0x180A404B0")]
		private void CustomerSelected(Customer customer)
		{
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600611D")]
		[Address(RVA = "0xA40A00", Offset = "0xA3FC00", VA = "0x180A40A00")]
		public CustomerSelector()
		{
		}

		// Token: 0x04004309 RID: 17161
		[Token(Token = "0x4004309")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ButtonPrefab;

		// Token: 0x0400430A RID: 17162
		[Token(Token = "0x400430A")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform EntriesContainer;

		// Token: 0x0400430B RID: 17163
		[Token(Token = "0x400430B")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<Customer> onCustomerSelected;

		// Token: 0x0400430C RID: 17164
		[Token(Token = "0x400430C")]
		[FieldOffset(Offset = "0x38")]
		private List<RectTransform> customerEntries;

		// Token: 0x0400430D RID: 17165
		[Token(Token = "0x400430D")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<RectTransform, Customer> entryToCustomer;
	}
}
