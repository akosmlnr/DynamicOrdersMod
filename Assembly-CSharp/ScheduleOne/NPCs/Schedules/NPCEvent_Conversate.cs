using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2000B36")]
	public class NPCEvent_Conversate : NPCEvent
	{
		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x0600554C RID: 21836 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C8F")]
		public new string ActionName
		{
			[Token(Token = "0x600554C")]
			[Address(RVA = "0x97C310", Offset = "0x97B510", VA = "0x18097C310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C90")]
		private Transform StandPoint
		{
			[Token(Token = "0x600554D")]
			[Address(RVA = "0x97C340", Offset = "0x97B540", VA = "0x18097C340")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600554E")]
		[Address(RVA = "0x97AC90", Offset = "0x979E90", VA = "0x18097AC90", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600554F")]
		[Address(RVA = "0x97BF20", Offset = "0x97B120", VA = "0x18097BF20", Slot = "21")]
		protected override void Start()
		{
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005550")]
		[Address(RVA = "0x97BFE0", Offset = "0x97B1E0", VA = "0x18097BFE0", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005551")]
		[Address(RVA = "0x97A690", Offset = "0x979890", VA = "0x18097A690", Slot = "30")]
		public override void ActiveUpdate()
		{
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005552")]
		[Address(RVA = "0x97B1D0", Offset = "0x97A3D0", VA = "0x18097B1D0", Slot = "34")]
		public override void MinPassed()
		{
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005553")]
		[Address(RVA = "0x97B140", Offset = "0x97A340", VA = "0x18097B140", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005554")]
		[Address(RVA = "0x97AFE0", Offset = "0x97A1E0", VA = "0x18097AFE0", Slot = "24")]
		public override void JumpTo()
		{
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005555")]
		[Address(RVA = "0x97AC10", Offset = "0x979E10", VA = "0x18097AC10", Slot = "25")]
		public override void End()
		{
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005556")]
		[Address(RVA = "0x97ADC0", Offset = "0x979FC0", VA = "0x18097ADC0", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005557")]
		[Address(RVA = "0x97B470", Offset = "0x97A670", VA = "0x18097B470", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x00016068 File Offset: 0x00014268
		[Token(Token = "0x6005558")]
		[Address(RVA = "0x97AE90", Offset = "0x97A090", VA = "0x18097AE90")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x00016080 File Offset: 0x00014280
		[Token(Token = "0x6005559")]
		[Address(RVA = "0x97A860", Offset = "0x979A60", VA = "0x18097A860")]
		private bool CanConversationStart()
		{
			return default(bool);
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555A")]
		[Address(RVA = "0x97C0E0", Offset = "0x97B2E0", VA = "0x18097C0E0", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555B")]
		[Address(RVA = "0x97BDE0", Offset = "0x97AFE0", VA = "0x18097BDE0", Slot = "45")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void StartWait()
		{
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555C")]
		[Address(RVA = "0x97AAD0", Offset = "0x979CD0", VA = "0x18097AAD0", Slot = "46")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndWait()
		{
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555D")]
		[Address(RVA = "0x97BCC0", Offset = "0x97AEC0", VA = "0x18097BCC0", Slot = "47")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void StartConversate()
		{
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555E")]
		[Address(RVA = "0x97A9B0", Offset = "0x979BB0", VA = "0x18097A9B0", Slot = "48")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndConversate()
		{
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555F")]
		[Address(RVA = "0x97C180", Offset = "0x97B380", VA = "0x18097C180")]
		public NPCEvent_Conversate()
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x97C070", Offset = "0x97B270", VA = "0x18097C070")]
		[CompilerGenerated]
		private IEnumerator <StartConversate>g__Routine|30_0()
		{
			return null;
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005561")]
		[Address(RVA = "0x97B2F0", Offset = "0x97A4F0", VA = "0x18097B2F0", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005562")]
		[Address(RVA = "0x97B2B0", Offset = "0x97A4B0", VA = "0x18097B2B0", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005563")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005564")]
		[Address(RVA = "0x97BBB0", Offset = "0x97ADB0", VA = "0x18097BBB0")]
		private void RpcWriter___Observers_StartWait_2166136261()
		{
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005565")]
		[Address(RVA = "0x97B6E0", Offset = "0x97A8E0", VA = "0x18097B6E0", Slot = "49")]
		protected virtual void RpcLogic___StartWait_2166136261()
		{
		}

		// Token: 0x06005566 RID: 21862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005566")]
		[Address(RVA = "0x97B7F0", Offset = "0x97A9F0", VA = "0x18097B7F0")]
		private void RpcReader___Observers_StartWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005567")]
		[Address(RVA = "0x97B970", Offset = "0x97AB70", VA = "0x18097B970")]
		private void RpcWriter___Observers_EndWait_2166136261()
		{
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005568")]
		[Address(RVA = "0x97B580", Offset = "0x97A780", VA = "0x18097B580", Slot = "50")]
		protected virtual void RpcLogic___EndWait_2166136261()
		{
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005569")]
		[Address(RVA = "0x97B750", Offset = "0x97A950", VA = "0x18097B750")]
		private void RpcReader___Observers_EndWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556A")]
		[Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90")]
		private void RpcWriter___Observers_StartConversate_2166136261()
		{
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556B")]
		[Address(RVA = "0x97B5B0", Offset = "0x97A7B0", VA = "0x18097B5B0", Slot = "51")]
		protected virtual void RpcLogic___StartConversate_2166136261()
		{
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556C")]
		[Address(RVA = "0x97B7B0", Offset = "0x97A9B0", VA = "0x18097B7B0")]
		private void RpcReader___Observers_StartConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556D")]
		[Address(RVA = "0x97B850", Offset = "0x97AA50", VA = "0x18097B850")]
		private void RpcWriter___Observers_EndConversate_2166136261()
		{
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556E")]
		[Address(RVA = "0x97B500", Offset = "0x97A700", VA = "0x18097B500", Slot = "52")]
		protected virtual void RpcLogic___EndConversate_2166136261()
		{
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556F")]
		[Address(RVA = "0x97B710", Offset = "0x97A910", VA = "0x18097B710")]
		private void RpcReader___Observers_EndConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005570")]
		[Address(RVA = "0x97A7C0", Offset = "0x9799C0", VA = "0x18097A7C0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04003979 RID: 14713
		[Token(Token = "0x4003979")]
		[FieldOffset(Offset = "0x158")]
		private EVOLineType[] ConversationLines;

		// Token: 0x0400397A RID: 14714
		[Token(Token = "0x400397A")]
		[FieldOffset(Offset = "0x160")]
		private string[] AnimationTriggers;

		// Token: 0x0400397B RID: 14715
		[Token(Token = "0x400397B")]
		public const float DESTINATION_THRESHOLD = 1f;

		// Token: 0x0400397C RID: 14716
		[Token(Token = "0x400397C")]
		public const float TIME_BEFORE_WAIT_START = 3f;

		// Token: 0x0400397D RID: 14717
		[Token(Token = "0x400397D")]
		[FieldOffset(Offset = "0x168")]
		public ConversationLocation Location;

		// Token: 0x0400397E RID: 14718
		[Token(Token = "0x400397E")]
		[FieldOffset(Offset = "0x170")]
		private bool IsConversating;

		// Token: 0x0400397F RID: 14719
		[Token(Token = "0x400397F")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine conversateRoutine;

		// Token: 0x04003980 RID: 14720
		[Token(Token = "0x4003980")]
		[FieldOffset(Offset = "0x180")]
		private bool IsWaiting;

		// Token: 0x04003981 RID: 14721
		[Token(Token = "0x4003981")]
		[FieldOffset(Offset = "0x188")]
		public UnityEvent OnWaitStart;

		// Token: 0x04003982 RID: 14722
		[Token(Token = "0x4003982")]
		[FieldOffset(Offset = "0x190")]
		public UnityEvent OnWaitEnd;

		// Token: 0x04003983 RID: 14723
		[Token(Token = "0x4003983")]
		[FieldOffset(Offset = "0x198")]
		private float timeAtDestination;

		// Token: 0x04003984 RID: 14724
		[Token(Token = "0x4003984")]
		[FieldOffset(Offset = "0x19C")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted;

		// Token: 0x04003985 RID: 14725
		[Token(Token = "0x4003985")]
		[FieldOffset(Offset = "0x19D")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted;
	}
}
