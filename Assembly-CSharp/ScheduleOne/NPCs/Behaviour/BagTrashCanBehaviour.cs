using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AE0 RID: 2784
	[Token(Token = "0x2000AE0")]
	public class BagTrashCanBehaviour : Behaviour
	{
		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C24")]
		public TrashContainerItem TargetTrashCan
		{
			[Token(Token = "0x60050AF")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60050B0")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C25")]
		private Cleaner Cleaner
		{
			[Token(Token = "0x60050B1")]
			[Address(RVA = "0x9482D0", Offset = "0x9474D0", VA = "0x1809482D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void SetTargetTrashCan(TrashContainerItem trashCan)
		{
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x947370", Offset = "0x946570", VA = "0x180947370", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B4")]
		[Address(RVA = "0x947DC0", Offset = "0x946FC0", VA = "0x180947DC0", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x948040", Offset = "0x947240", VA = "0x180948040")]
		private void StartAction()
		{
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x947C80", Offset = "0x946E80", VA = "0x180947C80", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x947530", Offset = "0x946730", VA = "0x180947530", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x948100", Offset = "0x947300", VA = "0x180948100")]
		private void StopAllActions()
		{
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x947890", Offset = "0x946A90", VA = "0x180947890", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x947590", Offset = "0x946790", VA = "0x180947590")]
		private void GoToTarget()
		{
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BC")]
		[Address(RVA = "0x947CA0", Offset = "0x946EA0", VA = "0x180947CA0")]
		[ObserversRpc(RunLocally = true)]
		private void PerformAction()
		{
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x00015228 File Offset: 0x00013428
		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x947680", Offset = "0x946880", VA = "0x180947680")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x947390", Offset = "0x946590", VA = "0x180947390")]
		private bool AreActionConditionsMet(bool checkAccess)
		{
			return default(bool);
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public BagTrashCanBehaviour()
		{
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60050C0")]
		[Address(RVA = "0x948260", Offset = "0x947460", VA = "0x180948260")]
		[CompilerGenerated]
		private IEnumerator <PerformAction>g__Action|21_0()
		{
			return null;
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x947800", Offset = "0x946A00", VA = "0x180947800", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C2")]
		[Address(RVA = "0x9477E0", Offset = "0x9469E0", VA = "0x1809477E0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C3")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C4")]
		[Address(RVA = "0x947F30", Offset = "0x947130", VA = "0x180947F30")]
		private void RpcWriter___Observers_PerformAction_2166136261()
		{
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C5")]
		[Address(RVA = "0x947DE0", Offset = "0x946FE0", VA = "0x180947DE0")]
		private void RpcLogic___PerformAction_2166136261()
		{
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C6")]
		[Address(RVA = "0x947EF0", Offset = "0x9470F0", VA = "0x180947EF0")]
		private void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C7")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003794 RID: 14228
		[Token(Token = "0x4003794")]
		public const float ACTION_MAX_DISTANCE = 2f;

		// Token: 0x04003795 RID: 14229
		[Token(Token = "0x4003795")]
		public const float BAG_TIME = 3f;

		// Token: 0x04003797 RID: 14231
		[Token(Token = "0x4003797")]
		[FieldOffset(Offset = "0x170")]
		private Coroutine actionCoroutine;

		// Token: 0x04003798 RID: 14232
		[Token(Token = "0x4003798")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onPerfomAction;

		// Token: 0x04003799 RID: 14233
		[Token(Token = "0x4003799")]
		[FieldOffset(Offset = "0x180")]
		public UnityEvent onPerfomDone;

		// Token: 0x0400379A RID: 14234
		[Token(Token = "0x400379A")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400379B RID: 14235
		[Token(Token = "0x400379B")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted;
	}
}
