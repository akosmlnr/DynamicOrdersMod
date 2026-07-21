using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x2000494")]
	[Serializable]
	public class RouteListData
	{
		// Token: 0x06001AE4 RID: 6884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x471360", Offset = "0x470560", VA = "0x180471360")]
		public RouteListData(List<AdvancedTransitRouteData> routes)
		{
		}

		// Token: 0x040016AF RID: 5807
		[Token(Token = "0x40016AF")]
		[FieldOffset(Offset = "0x10")]
		public List<AdvancedTransitRouteData> Routes;
	}
}
