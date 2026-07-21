using System;
using Il2CppDummyDll;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x20007AB")]
	[CreateAssetMenu(fileName = "PhoneCallData", menuName = "ScriptableObjects/PhoneCallData", order = 1)]
	[Serializable]
	public class PhoneCallData : ScriptableObject
	{
		// Token: 0x06003495 RID: 13461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003495")]
		[Address(RVA = "0x5FAF90", Offset = "0x5FA190", VA = "0x1805FAF90")]
		public void Completed()
		{
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003496")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public PhoneCallData()
		{
		}

		// Token: 0x0400265B RID: 9819
		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x18")]
		public CallerID CallerID;

		// Token: 0x0400265C RID: 9820
		[Token(Token = "0x400265C")]
		[FieldOffset(Offset = "0x20")]
		public PhoneCallData.Stage[] Stages;

		// Token: 0x0400265D RID: 9821
		[Token(Token = "0x400265D")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onCallCompleted;

		// Token: 0x020007AC RID: 1964
		[Token(Token = "0x20007AC")]
		[Serializable]
		public class Stage
		{
			// Token: 0x06003497 RID: 13463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003497")]
			[Address(RVA = "0x79E1E0", Offset = "0x79D3E0", VA = "0x18079E1E0")]
			public void OnStageStart()
			{
			}

			// Token: 0x06003498 RID: 13464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003498")]
			[Address(RVA = "0x79E150", Offset = "0x79D350", VA = "0x18079E150")]
			public void OnStageEnd()
			{
			}

			// Token: 0x06003499 RID: 13465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003499")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Stage()
			{
			}

			// Token: 0x0400265E RID: 9822
			[Token(Token = "0x400265E")]
			[FieldOffset(Offset = "0x10")]
			[TextArea(3, 10)]
			public string Text;

			// Token: 0x0400265F RID: 9823
			[Token(Token = "0x400265F")]
			[FieldOffset(Offset = "0x18")]
			public SystemTrigger[] OnStartTriggers;

			// Token: 0x04002660 RID: 9824
			[Token(Token = "0x4002660")]
			[FieldOffset(Offset = "0x20")]
			public SystemTrigger[] OnDoneTriggers;
		}
	}
}
