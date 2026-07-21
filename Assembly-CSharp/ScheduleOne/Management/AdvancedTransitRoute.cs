using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Management
{
	// Token: 0x0200055B RID: 1371
	[Token(Token = "0x200055B")]
	public class AdvancedTransitRoute : TransitRoute
	{
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057D")]
		public ManagementItemFilter Filter
		{
			[Token(Token = "0x6001E8C")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E8D")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x636560", Offset = "0x635760", VA = "0x180636560")]
		public AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination)
		{
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x6365F0", Offset = "0x6357F0", VA = "0x1806365F0")]
		public AdvancedTransitRoute(AdvancedTransitRouteData data)
		{
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x6362D0", Offset = "0x6354D0", VA = "0x1806362D0")]
		public ItemInstance GetItemReadyToMove()
		{
			return null;
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0x635EF0", Offset = "0x6350F0", VA = "0x180635EF0")]
		public AdvancedTransitRouteData GetData()
		{
			return null;
		}
	}
}
