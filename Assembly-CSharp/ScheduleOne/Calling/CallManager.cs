using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;

namespace ScheduleOne.Calling
{
	// Token: 0x020007A7 RID: 1959
	[Token(Token = "0x20007A7")]
	public class CallManager : Singleton<CallManager>
	{
		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600347A RID: 13434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000855")]
		private PhoneCallData QueuedCallData
		{
			[Token(Token = "0x6003479")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600347A")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600347B RID: 13435 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600347C RID: 13436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000011")]
		public event Action<PhoneCallData> OnCallQueued
		{
			[Token(Token = "0x600347B")]
			[Address(RVA = "0x78DC70", Offset = "0x78CE70", VA = "0x18078DC70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600347C")]
			[Address(RVA = "0x78DD20", Offset = "0x78CF20", VA = "0x18078DD20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x78DA00", Offset = "0x78CC00", VA = "0x18078DA00", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x78D7C0", Offset = "0x78C9C0", VA = "0x18078D7C0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347F")]
		[Address(RVA = "0x78D9B0", Offset = "0x78CBB0", VA = "0x18078D9B0")]
		public void QueueCall(PhoneCallData data)
		{
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x78D770", Offset = "0x78C970", VA = "0x18078D770")]
		public void ClearQueuedCall()
		{
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x78D6D0", Offset = "0x78C8D0", VA = "0x18078D6D0")]
		private void CallCompleted(PhoneCallData call)
		{
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x78DC30", Offset = "0x78CE30", VA = "0x18078DC30")]
		public CallManager()
		{
		}
	}
}
