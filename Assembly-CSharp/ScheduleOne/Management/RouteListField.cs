using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000581 RID: 1409
	[Token(Token = "0x2000581")]
	public class RouteListField : ConfigField
	{
		// Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002026")]
		[Address(RVA = "0x6856D0", Offset = "0x6848D0", VA = "0x1806856D0")]
		public RouteListField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002027")]
		[Address(RVA = "0x6855B0", Offset = "0x6847B0", VA = "0x1806855B0")]
		public void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002028")]
		[Address(RVA = "0x685580", Offset = "0x684780", VA = "0x180685580")]
		public void Replicate()
		{
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002029")]
		[Address(RVA = "0x684B00", Offset = "0x683D00", VA = "0x180684B00")]
		public void AddItem(AdvancedTransitRoute item)
		{
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202A")]
		[Address(RVA = "0x685490", Offset = "0x684690", VA = "0x180685490")]
		public void RemoveItem(AdvancedTransitRoute item)
		{
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x600202B")]
		[Address(RVA = "0x684E40", Offset = "0x684040", VA = "0x180684E40", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600202C")]
		[Address(RVA = "0x684CB0", Offset = "0x683EB0", VA = "0x180684CB0")]
		public RouteListData GetData()
		{
			return null;
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600202D")]
		[Address(RVA = "0x684E90", Offset = "0x684090", VA = "0x180684E90")]
		public void Load(RouteListData data)
		{
		}

		// Token: 0x04001A4A RID: 6730
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x18")]
		public List<AdvancedTransitRoute> Routes;

		// Token: 0x04001A4B RID: 6731
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x20")]
		public int MaxRoutes;

		// Token: 0x04001A4C RID: 6732
		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<List<AdvancedTransitRoute>> onListChanged;
	}
}
