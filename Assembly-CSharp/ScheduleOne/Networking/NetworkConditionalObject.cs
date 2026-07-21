using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Networking
{
	// Token: 0x020004FB RID: 1275
	[Token(Token = "0x20004FB")]
	public class NetworkConditionalObject : MonoBehaviour
	{
		// Token: 0x06001B94 RID: 7060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x613CB0", Offset = "0x612EB0", VA = "0x180613CB0")]
		private void Awake()
		{
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x613EC0", Offset = "0x6130C0", VA = "0x180613EC0")]
		public void Check()
		{
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B96")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public NetworkConditionalObject()
		{
		}

		// Token: 0x040017BA RID: 6074
		[Token(Token = "0x40017BA")]
		[FieldOffset(Offset = "0x20")]
		public NetworkConditionalObject.ECondition condition;

		// Token: 0x020004FC RID: 1276
		[Token(Token = "0x20004FC")]
		public enum ECondition
		{
			// Token: 0x040017BC RID: 6076
			[Token(Token = "0x40017BC")]
			All,
			// Token: 0x040017BD RID: 6077
			[Token(Token = "0x40017BD")]
			HostOnly
		}
	}
}
