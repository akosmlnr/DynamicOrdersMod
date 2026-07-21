using System;
using FishNet.Managing;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Networking
{
	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x20004F5")]
	[RequireComponent(typeof(NetworkManager))]
	public class AutoNetworkStart : MonoBehaviour
	{
		// Token: 0x06001B73 RID: 7027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public AutoNetworkStart()
		{
		}

		// Token: 0x040017A4 RID: 6052
		[Token(Token = "0x40017A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoNetworkStart.EAutoStartType _autoStartType;

		// Token: 0x020004F6 RID: 1270
		[Token(Token = "0x20004F6")]
		private enum EAutoStartType
		{
			// Token: 0x040017A6 RID: 6054
			[Token(Token = "0x40017A6")]
			Disabled,
			// Token: 0x040017A7 RID: 6055
			[Token(Token = "0x40017A7")]
			Host,
			// Token: 0x040017A8 RID: 6056
			[Token(Token = "0x40017A8")]
			Server,
			// Token: 0x040017A9 RID: 6057
			[Token(Token = "0x40017A9")]
			Client
		}
	}
}
