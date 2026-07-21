using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Quests;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020006BE RID: 1726
	[Token(Token = "0x20006BE")]
	public class DeliveryLocation : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x0000E358 File Offset: 0x0000C558
		// (set) Token: 0x06002D8A RID: 11658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A6")]
		public Guid GUID
		{
			[Token(Token = "0x6002D89")]
			[Address(RVA = "0x72F480", Offset = "0x72E680", VA = "0x18072F480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6002D8A")]
			[Address(RVA = "0x72F490", Offset = "0x72E690", VA = "0x18072F490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D8B")]
		[Address(RVA = "0x72F340", Offset = "0x72E540", VA = "0x18072F340", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D8C")]
		[Address(RVA = "0x72F1C0", Offset = "0x72E3C0", VA = "0x18072F1C0")]
		private void Awake()
		{
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D8D")]
		[Address(RVA = "0x7200C0", Offset = "0x71F2C0", VA = "0x1807200C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002D8E")]
		[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450", Slot = "7")]
		public virtual string GetDescription()
		{
			return null;
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D8F")]
		[Address(RVA = "0x72F3A0", Offset = "0x72E5A0", VA = "0x18072F3A0")]
		public DeliveryLocation()
		{
		}

		// Token: 0x040021C0 RID: 8640
		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0x20")]
		public string LocationName;

		// Token: 0x040021C1 RID: 8641
		[Token(Token = "0x40021C1")]
		[FieldOffset(Offset = "0x28")]
		public string LocationDescription;

		// Token: 0x040021C2 RID: 8642
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0x30")]
		public Transform CustomerStandPoint;

		// Token: 0x040021C3 RID: 8643
		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0x38")]
		public Transform TeleportPoint;

		// Token: 0x040021C4 RID: 8644
		[Token(Token = "0x40021C4")]
		[FieldOffset(Offset = "0x40")]
		public string StaticGUID;

		// Token: 0x040021C5 RID: 8645
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0x48")]
		public List<Contract> ScheduledContracts;
	}
}
