using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	public class ScheduledMaterialChange : MonoBehaviour
	{
		// Token: 0x06001DD5 RID: 7637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0x62BBF0", Offset = "0x62ADF0", VA = "0x18062BBF0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x62BA40", Offset = "0x62AC40", VA = "0x18062BA40")]
		private void Reset()
		{
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0x62B790", Offset = "0x62A990", VA = "0x18062B790", Slot = "5")]
		protected virtual void OnUncappedMinPass()
		{
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0x62BA40", Offset = "0x62AC40", VA = "0x18062BA40")]
		private void SetOnOffStatus()
		{
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0x62BAB0", Offset = "0x62ACB0", VA = "0x18062BAB0")]
		private void SetMaterial(bool insideTimeRange)
		{
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0x62BEE0", Offset = "0x62B0E0", VA = "0x18062BEE0")]
		public ScheduledMaterialChange()
		{
		}

		// Token: 0x04001923 RID: 6435
		[Token(Token = "0x4001923")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer[] Renderers;

		// Token: 0x04001924 RID: 6436
		[Token(Token = "0x4001924")]
		[FieldOffset(Offset = "0x28")]
		public int MaterialIndex;

		// Token: 0x04001925 RID: 6437
		[Token(Token = "0x4001925")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public bool Enabled;

		// Token: 0x04001926 RID: 6438
		[Token(Token = "0x4001926")]
		[FieldOffset(Offset = "0x2D")]
		public bool LogState;

		// Token: 0x04001927 RID: 6439
		[Token(Token = "0x4001927")]
		[FieldOffset(Offset = "0x30")]
		public Material OutsideTimeRangeMaterial;

		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x38")]
		public Material InsideTimeRangeMaterial;

		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x40")]
		public int TimeRangeMin;

		// Token: 0x0400192A RID: 6442
		[Token(Token = "0x400192A")]
		[FieldOffset(Offset = "0x44")]
		public int TimeRangeMax;

		// Token: 0x0400192B RID: 6443
		[Token(Token = "0x400192B")]
		[FieldOffset(Offset = "0x48")]
		public int TimeRangeShift;

		// Token: 0x0400192C RID: 6444
		[Token(Token = "0x400192C")]
		[FieldOffset(Offset = "0x4C")]
		public int TimeRangeRandomization;

		// Token: 0x0400192D RID: 6445
		[Token(Token = "0x400192D")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float TurnOnChance;

		// Token: 0x0400192E RID: 6446
		[Token(Token = "0x400192E")]
		[FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float TurnOffChance;

		// Token: 0x0400192F RID: 6447
		[Token(Token = "0x400192F")]
		[FieldOffset(Offset = "0x58")]
		private bool appliedInsideTimeRange;

		// Token: 0x04001930 RID: 6448
		[Token(Token = "0x4001930")]
		[FieldOffset(Offset = "0x5C")]
		private ScheduledMaterialChange.EOnState onState;

		// Token: 0x04001931 RID: 6449
		[Token(Token = "0x4001931")]
		[FieldOffset(Offset = "0x60")]
		private int randomShift;

		// Token: 0x04001932 RID: 6450
		[Token(Token = "0x4001932")]
		[FieldOffset(Offset = "0x64")]
		private bool _shouldTurnOn;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x65")]
		private bool _shouldTurnOff;

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x68")]
		private ScheduledMaterialChange.EOnState _lastOnState;

		// Token: 0x02000546 RID: 1350
		[Token(Token = "0x2000546")]
		private enum EOnState
		{
			// Token: 0x04001936 RID: 6454
			[Token(Token = "0x4001936")]
			Undecided,
			// Token: 0x04001937 RID: 6455
			[Token(Token = "0x4001937")]
			On,
			// Token: 0x04001938 RID: 6456
			[Token(Token = "0x4001938")]
			Off
		}
	}
}
