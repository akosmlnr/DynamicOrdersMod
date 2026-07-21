using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000870 RID: 2160
	[Token(Token = "0x2000870")]
	public class GameVersionEvents : MonoBehaviour
	{
		// Token: 0x06003954 RID: 14676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003954")]
		[Address(RVA = "0x5D1E30", Offset = "0x5D1030", VA = "0x1805D1E30")]
		private void Start()
		{
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003955")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public GameVersionEvents()
		{
		}

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onFullGame;

		// Token: 0x04002A3F RID: 10815
		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onDemoGame;
	}
}
