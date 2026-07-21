using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	// Token: 0x020009DF RID: 2527
	[Token(Token = "0x20009DF")]
	public class StoredItem_Cash : StoredItem
	{
		// Token: 0x0600487D RID: 18557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487D")]
		[Address(RVA = "0x9131E0", Offset = "0x9123E0", VA = "0x1809131E0", Slot = "5")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487E")]
		[Address(RVA = "0x913140", Offset = "0x912340", VA = "0x180913140", Slot = "6")]
		public override void Destroy()
		{
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487F")]
		[Address(RVA = "0x913380", Offset = "0x912580", VA = "0x180913380")]
		private void RefreshShownBills()
		{
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004880")]
		[Address(RVA = "0x7FACA0", Offset = "0x7F9EA0", VA = "0x1807FACA0")]
		public StoredItem_Cash()
		{
		}

		// Token: 0x04003342 RID: 13122
		[Token(Token = "0x4003342")]
		[FieldOffset(Offset = "0x68")]
		protected CashInstance cashInstance;

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		public CashStackVisuals Visuals;
	}
}
