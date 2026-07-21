using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x20005CC")]
	[Serializable]
	public class SentryInstance
	{
		// Token: 0x06002208 RID: 8712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002208")]
		[Address(RVA = "0x685960", Offset = "0x684B60", VA = "0x180685960")]
		public void Evaluate()
		{
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002209")]
		[Address(RVA = "0x685C90", Offset = "0x684E90", VA = "0x180685C90")]
		public void StartEntry()
		{
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600220A")]
		[Address(RVA = "0x685BF0", Offset = "0x684DF0", VA = "0x180685BF0")]
		private void MinPass()
		{
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600220B")]
		[Address(RVA = "0x6857B0", Offset = "0x6849B0", VA = "0x1806857B0")]
		public void EndSentry()
		{
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600220C")]
		[Address(RVA = "0x685A90", Offset = "0x684C90", VA = "0x180685A90")]
		private SentryLocation GetRandomUnoccupiedLocation()
		{
			return null;
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600220D")]
		[Address(RVA = "0x685F30", Offset = "0x685130", VA = "0x180685F30")]
		public SentryInstance()
		{
		}

		// Token: 0x04001B8F RID: 7055
		[Token(Token = "0x4001B8F")]
		[FieldOffset(Offset = "0x10")]
		public SentryLocation[] _potentialLocations;

		// Token: 0x04001B90 RID: 7056
		[Token(Token = "0x4001B90")]
		[FieldOffset(Offset = "0x18")]
		public int Members;

		// Token: 0x04001B91 RID: 7057
		[Token(Token = "0x4001B91")]
		[FieldOffset(Offset = "0x1C")]
		[Header("Timing")]
		public int StartTime;

		// Token: 0x04001B92 RID: 7058
		[Token(Token = "0x4001B92")]
		[FieldOffset(Offset = "0x20")]
		public int EndTime;

		// Token: 0x04001B93 RID: 7059
		[Token(Token = "0x4001B93")]
		[FieldOffset(Offset = "0x24")]
		[Range(1f, 10f)]
		public int IntensityRequirement;

		// Token: 0x04001B94 RID: 7060
		[Token(Token = "0x4001B94")]
		[FieldOffset(Offset = "0x28")]
		public bool OnlyIfCurfewEnabled;

		// Token: 0x04001B95 RID: 7061
		[Token(Token = "0x4001B95")]
		[FieldOffset(Offset = "0x30")]
		private List<PoliceOfficer> _activeOfficers;

		// Token: 0x04001B96 RID: 7062
		[Token(Token = "0x4001B96")]
		[FieldOffset(Offset = "0x38")]
		private SentryLocation _activeLocation;
	}
}
