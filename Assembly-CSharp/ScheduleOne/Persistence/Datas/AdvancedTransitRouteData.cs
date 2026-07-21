using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200047F RID: 1151
	[Token(Token = "0x200047F")]
	[Serializable]
	public class AdvancedTransitRouteData
	{
		// Token: 0x06001ACE RID: 6862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x602010", Offset = "0x601210", VA = "0x180602010")]
		public AdvancedTransitRouteData(string sourceGUID, string destinationGUID, ManagementItemFilter.EMode filtermode, List<string> filterGUIDs)
		{
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public AdvancedTransitRouteData()
		{
		}

		// Token: 0x04001685 RID: 5765
		[Token(Token = "0x4001685")]
		[FieldOffset(Offset = "0x10")]
		public string SourceGUID;

		// Token: 0x04001686 RID: 5766
		[Token(Token = "0x4001686")]
		[FieldOffset(Offset = "0x18")]
		public string DestinationGUID;

		// Token: 0x04001687 RID: 5767
		[Token(Token = "0x4001687")]
		[FieldOffset(Offset = "0x20")]
		public ManagementItemFilter.EMode FilterMode;

		// Token: 0x04001688 RID: 5768
		[Token(Token = "0x4001688")]
		[FieldOffset(Offset = "0x28")]
		public List<string> FilterItemIDs;
	}
}
