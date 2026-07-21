using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	public class LoadEventTransmitter : MonoBehaviour
	{
		// Token: 0x06001883 RID: 6275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001883")]
		[Address(RVA = "0x5D1E50", Offset = "0x5D1050", VA = "0x1805D1E50")]
		private void Start()
		{
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001884")]
		[Address(RVA = "0x5D1E30", Offset = "0x5D1030", VA = "0x1805D1E30")]
		private void OnLoadComplete()
		{
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001885")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public LoadEventTransmitter()
		{
		}

		// Token: 0x04001553 RID: 5459
		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onLoadComplete;
	}
}
