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
	// Token: 0x02000AE7 RID: 2791
	[Token(Token = "0x2000AE7")]
	public class EmptyTrashGrabberBehaviour : Behaviour
	{
		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005119 RID: 20761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C32")]
		public TrashContainerItem TargetTrashCan
		{
			[Token(Token = "0x6005118")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005119")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C33")]
		private Cleaner Cleaner
		{
			[Token(Token = "0x600511A")]
			[Address(RVA = "0x94EE20", Offset = "0x94E020", VA = "0x18094EE20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511B")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void SetTargetTrashCan(TrashContainerItem trashCan)
		{
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511C")]
		[Address(RVA = "0x94E050", Offset = "0x94D250", VA = "0x18094E050", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511D")]
		[Address(RVA = "0x94E920", Offset = "0x94DB20", VA = "0x18094E920", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511E")]
		[Address(RVA = "0x94EBA0", Offset = "0x94DDA0", VA = "0x18094EBA0")]
		private void StartAction()
		{
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511F")]
		[Address(RVA = "0x94E7E0", Offset = "0x94D9E0", VA = "0x18094E7E0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005120")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005121")]
		[Address(RVA = "0x94E1E0", Offset = "0x94D3E0", VA = "0x18094E1E0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005122")]
		[Address(RVA = "0x94ECA0", Offset = "0x94DEA0", VA = "0x18094ECA0")]
		private void StopAllActions()
		{
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005123")]
		[Address(RVA = "0x94E3C0", Offset = "0x94D5C0", VA = "0x18094E3C0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005124")]
		[Address(RVA = "0x94E200", Offset = "0x94D400", VA = "0x18094E200")]
		private void GoToTarget()
		{
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005125")]
		[Address(RVA = "0x94E800", Offset = "0x94DA00", VA = "0x18094E800")]
		[ObserversRpc(RunLocally = true)]
		private void PerformAction()
		{
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x6005126")]
		[Address(RVA = "0x947680", Offset = "0x946880", VA = "0x180947680")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x6005127")]
		[Address(RVA = "0x94E070", Offset = "0x94D270", VA = "0x18094E070")]
		private bool AreActionConditionsMet(bool checkAccess)
		{
			return default(bool);
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005128")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public EmptyTrashGrabberBehaviour()
		{
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005129")]
		[Address(RVA = "0x94EDB0", Offset = "0x94DFB0", VA = "0x18094EDB0")]
		[CompilerGenerated]
		private IEnumerator <PerformAction>g__Action|20_0()
		{
			return null;
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512A")]
		[Address(RVA = "0x94E330", Offset = "0x94D530", VA = "0x18094E330", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512B")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512C")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512D")]
		[Address(RVA = "0x94EA90", Offset = "0x94DC90", VA = "0x18094EA90")]
		private void RpcWriter___Observers_PerformAction_2166136261()
		{
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512E")]
		[Address(RVA = "0x94E940", Offset = "0x94DB40", VA = "0x18094E940")]
		private void RpcLogic___PerformAction_2166136261()
		{
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600512F")]
		[Address(RVA = "0x94EA50", Offset = "0x94DC50", VA = "0x18094EA50")]
		private void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005130")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x040037B8 RID: 14264
		[Token(Token = "0x40037B8")]
		public const float ACTION_MAX_DISTANCE = 2f;

		// Token: 0x040037B9 RID: 14265
		[Token(Token = "0x40037B9")]
		public const string EQUIPPABLE_ASSET_PATH = "Tools/TrashGrabber/Bin_AvatarEquippable";

		// Token: 0x040037BB RID: 14267
		[Token(Token = "0x40037BB")]
		[FieldOffset(Offset = "0x170")]
		private Coroutine actionCoroutine;

		// Token: 0x040037BC RID: 14268
		[Token(Token = "0x40037BC")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onPerfomAction;

		// Token: 0x040037BD RID: 14269
		[Token(Token = "0x40037BD")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040037BE RID: 14270
		[Token(Token = "0x40037BE")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted;
	}
}
