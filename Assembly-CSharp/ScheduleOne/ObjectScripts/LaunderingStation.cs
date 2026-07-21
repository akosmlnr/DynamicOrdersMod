using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009AD RID: 2477
	[Token(Token = "0x20009AD")]
	public class LaunderingStation : GridItem
	{
		// Token: 0x060044BF RID: 17599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044BF")]
		[Address(RVA = "0x8A1F70", Offset = "0x8A1170", VA = "0x1808A1F70", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C0")]
		[Address(RVA = "0x8A20B0", Offset = "0x8A12B0", VA = "0x1808A20B0")]
		private void Update()
		{
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00013110 File Offset: 0x00011310
		[Token(Token = "0x60044C1")]
		[Address(RVA = "0x8A1F20", Offset = "0x8A1120", VA = "0x1808A1F20", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C2")]
		[Address(RVA = "0x85DD20", Offset = "0x85CF20", VA = "0x18085DD20")]
		public LaunderingStation()
		{
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C3")]
		[Address(RVA = "0x8A2090", Offset = "0x8A1290", VA = "0x1808A2090", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C4")]
		[Address(RVA = "0x8A2070", Offset = "0x8A1270", VA = "0x1808A2070", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C5")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044C6")]
		[Address(RVA = "0x82F570", Offset = "0x82E770", VA = "0x18082F570", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04003167 RID: 12647
		[Token(Token = "0x4003167")]
		[FieldOffset(Offset = "0x210")]
		[Header("References")]
		public LaunderingInterface Interface;

		// Token: 0x04003168 RID: 12648
		[Token(Token = "0x4003168")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		protected CashCounter CashCounter;

		// Token: 0x04003169 RID: 12649
		[Token(Token = "0x4003169")]
		[FieldOffset(Offset = "0x220")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted;

		// Token: 0x0400316A RID: 12650
		[Token(Token = "0x400316A")]
		[FieldOffset(Offset = "0x221")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.LaunderingStationAssembly-CSharp.dll_Excuted;
	}
}
