using System;
using Il2CppDummyDll;
using ScheduleOne.Storage;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x020009E6 RID: 2534
	[Token(Token = "0x20009E6")]
	public class WaterContainerStored : StoredItem
	{
		// Token: 0x060048A6 RID: 18598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A6")]
		[Address(RVA = "0x9185E0", Offset = "0x9177E0", VA = "0x1809185E0", Slot = "5")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A7")]
		[Address(RVA = "0x918560", Offset = "0x917760", VA = "0x180918560", Slot = "6")]
		public override void Destroy()
		{
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A8")]
		[Address(RVA = "0x7FACA0", Offset = "0x7F9EA0", VA = "0x1807FACA0")]
		public WaterContainerStored()
		{
		}

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WaterContainerVisualizer _visuals;
	}
}
