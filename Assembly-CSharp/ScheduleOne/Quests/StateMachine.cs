using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000354 RID: 852
	[Token(Token = "0x2000354")]
	public class StateMachine : MonoBehaviour
	{
		// Token: 0x060014D4 RID: 5332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x5AC600", Offset = "0x5AB800", VA = "0x1805AC600")]
		private void Start()
		{
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x5AC6E0", Offset = "0x5AB8E0", VA = "0x1805AC6E0")]
		private void Update()
		{
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x5AC570", Offset = "0x5AB770", VA = "0x1805AC570")]
		private void Clean()
		{
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x5AC530", Offset = "0x5AB730", VA = "0x1805AC530")]
		public static void ChangeState()
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public StateMachine()
		{
		}

		// Token: 0x040012CB RID: 4811
		[Token(Token = "0x40012CB")]
		[FieldOffset(Offset = "0x0")]
		public static Action OnStateChange;

		// Token: 0x040012CC RID: 4812
		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0x8")]
		private static bool stateChanged;
	}
}
