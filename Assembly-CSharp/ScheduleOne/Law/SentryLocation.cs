using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x20005CD")]
	public class SentryLocation : MonoBehaviour
	{
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000609")]
		public List<PoliceOfficer> AssignedOfficers
		{
			[Token(Token = "0x600220E")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600220F")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002210")]
		[Address(RVA = "0x685FD0", Offset = "0x6851D0", VA = "0x180685FD0")]
		public SentryLocation()
		{
		}

		// Token: 0x04001B97 RID: 7063
		[Token(Token = "0x4001B97")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public List<SentryLocation.SentryRoute> Routes;

		// Token: 0x020005CE RID: 1486
		[Token(Token = "0x20005CE")]
		[Serializable]
		public class SentryRoute
		{
			// Token: 0x06002211 RID: 8721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002211")]
			[Address(RVA = "0x686090", Offset = "0x685290", VA = "0x180686090")]
			public SentryRoute()
			{
			}

			// Token: 0x04001B99 RID: 7065
			[Token(Token = "0x4001B99")]
			[FieldOffset(Offset = "0x10")]
			public Transform[] RoutePoints;

			// Token: 0x04001B9A RID: 7066
			[Token(Token = "0x4001B9A")]
			[FieldOffset(Offset = "0x18")]
			public int MinutesPerPoint;
		}
	}
}
