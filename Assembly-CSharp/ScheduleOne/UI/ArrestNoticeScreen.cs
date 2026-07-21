using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Law;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C7F RID: 3199
	[Token(Token = "0x2000C7F")]
	public class ArrestNoticeScreen : Singleton<ArrestNoticeScreen>
	{
		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06005DAE RID: 23982 RVA: 0x00017928 File Offset: 0x00015B28
		// (set) Token: 0x06005DAF RID: 23983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8C")]
		public bool isOpen
		{
			[Token(Token = "0x6005DAE")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DAF")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB0")]
		[Address(RVA = "0x9D7510", Offset = "0x9D6710", VA = "0x1809D7510", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0x9D83D0", Offset = "0x9D75D0", VA = "0x1809D83D0")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB2")]
		[Address(RVA = "0x9D7D60", Offset = "0x9D6F60", VA = "0x1809D7D60")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB3")]
		[Address(RVA = "0x9D7E50", Offset = "0x9D7050", VA = "0x1809D7E50")]
		public void Open()
		{
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB4")]
		[Address(RVA = "0x9D7850", Offset = "0x9D6A50", VA = "0x1809D7850")]
		public void Close()
		{
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB5")]
		[Address(RVA = "0x9D84A0", Offset = "0x9D76A0", VA = "0x1809D84A0")]
		public void RecordCrimes()
		{
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB6")]
		[Address(RVA = "0x9D8930", Offset = "0x9D7B30", VA = "0x1809D8930")]
		private void RecordPossession(EStealthLevel maxStealthLevel)
		{
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB7")]
		[Address(RVA = "0x9D7900", Offset = "0x9D6B00", VA = "0x1809D7900")]
		private void ConfiscateItems(EStealthLevel maxStealthLevel)
		{
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB8")]
		[Address(RVA = "0x9D7710", Offset = "0x9D6910", VA = "0x1809D7710")]
		private void ClearEntries()
		{
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB9")]
		[Address(RVA = "0x9D9070", Offset = "0x9D8270", VA = "0x1809D9070")]
		public ArrestNoticeScreen()
		{
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005DBA")]
		[Address(RVA = "0x9D9000", Offset = "0x9D8200", VA = "0x1809D9000")]
		[CompilerGenerated]
		private IEnumerator <Close>g__CloseRoutine|17_0()
		{
			return null;
		}

		// Token: 0x04004032 RID: 16434
		[Token(Token = "0x4004032")]
		public const float VEHICLE_POSSESSION_TIMEOUT = 30f;

		// Token: 0x04004034 RID: 16436
		[Token(Token = "0x4004034")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04004035 RID: 16437
		[Token(Token = "0x4004035")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup CanvasGroup;

		// Token: 0x04004036 RID: 16438
		[Token(Token = "0x4004036")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform CrimeEntryContainer;

		// Token: 0x04004037 RID: 16439
		[Token(Token = "0x4004037")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform PenaltyEntryContainer;

		// Token: 0x04004038 RID: 16440
		[Token(Token = "0x4004038")]
		[FieldOffset(Offset = "0x50")]
		[Header("Prefabs")]
		public RectTransform CrimeEntryPrefab;

		// Token: 0x04004039 RID: 16441
		[Token(Token = "0x4004039")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform PenaltyEntryPrefab;

		// Token: 0x0400403A RID: 16442
		[Token(Token = "0x400403A")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<Crime, int> recordedCrimes;

		// Token: 0x0400403B RID: 16443
		[Token(Token = "0x400403B")]
		[FieldOffset(Offset = "0x68")]
		private LandVehicle vehicle;
	}
}
