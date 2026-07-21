using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A15 RID: 2581
	[Token(Token = "0x2000A15")]
	public class StaggeredCallbackUtility : Singleton<StaggeredCallbackUtility>
	{
		// Token: 0x060049AF RID: 18863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AF")]
		[Address(RVA = "0x912730", Offset = "0x911930", VA = "0x180912730")]
		public void InvokeStaggered(int totalCalls, float totalTime, Action<int> callback, [Optional] Action onComplete)
		{
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B0")]
		[Address(RVA = "0x912880", Offset = "0x911A80", VA = "0x180912880")]
		public void InvokeStaggered(int totalCalls, int callsPerSecond, Action<int> callback, [Optional] Action onComplete)
		{
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B1")]
		[Address(RVA = "0x912990", Offset = "0x911B90", VA = "0x180912990")]
		public StaggeredCallbackUtility()
		{
		}
	}
}
