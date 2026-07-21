using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E29 RID: 3625
	[Token(Token = "0x2000E29")]
	public interface IDamageable
	{
		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060067FC RID: 26620
		[Token(Token = "0x17000EC2")]
		GameObject gameObject
		{
			[Token(Token = "0x60067FC")]
			get;
		}

		// Token: 0x060067FD RID: 26621
		[Token(Token = "0x60067FD")]
		void SendImpact(Impact impact);

		// Token: 0x060067FE RID: 26622
		[Token(Token = "0x60067FE")]
		void ReceiveImpact(Impact impact);
	}
}
