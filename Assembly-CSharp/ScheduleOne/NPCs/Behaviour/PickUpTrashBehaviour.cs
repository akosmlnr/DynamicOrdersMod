using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AFC RID: 2812
	[Token(Token = "0x2000AFC")]
	public class PickUpTrashBehaviour : Behaviour
	{
		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600521D RID: 21021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C50")]
		public TrashItem TargetTrash
		{
			[Token(Token = "0x600521C")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600521D")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C51")]
		private Cleaner Cleaner
		{
			[Token(Token = "0x600521E")]
			[Address(RVA = "0x957420", Offset = "0x956620", VA = "0x180957420")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600521F")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void SetTargetTrash(TrashItem trash)
		{
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005220")]
		[Address(RVA = "0x9565B0", Offset = "0x9557B0", VA = "0x1809565B0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005221")]
		[Address(RVA = "0x956EC0", Offset = "0x9560C0", VA = "0x180956EC0", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005222")]
		[Address(RVA = "0x9571A0", Offset = "0x9563A0", VA = "0x1809571A0")]
		private void StartAction()
		{
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005223")]
		[Address(RVA = "0x956D80", Offset = "0x955F80", VA = "0x180956D80", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005224")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005225")]
		[Address(RVA = "0x956700", Offset = "0x955900", VA = "0x180956700", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005226")]
		[Address(RVA = "0x9572A0", Offset = "0x9564A0", VA = "0x1809572A0")]
		private void StopAllActions()
		{
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005227")]
		[Address(RVA = "0x9568C0", Offset = "0x955AC0", VA = "0x1809568C0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005228")]
		[Address(RVA = "0x956720", Offset = "0x955920", VA = "0x180956720")]
		private void GoToTarget()
		{
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005229")]
		[Address(RVA = "0x956DA0", Offset = "0x955FA0", VA = "0x180956DA0")]
		[ObserversRpc(RunLocally = true)]
		private void PerformAction()
		{
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x00015858 File Offset: 0x00013A58
		[Token(Token = "0x600522A")]
		[Address(RVA = "0x947680", Offset = "0x946880", VA = "0x180947680")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00015870 File Offset: 0x00013A70
		[Token(Token = "0x600522B")]
		[Address(RVA = "0x9565D0", Offset = "0x9557D0", VA = "0x1809565D0")]
		private bool AreActionConditionsMet(bool checkAccess)
		{
			return default(bool);
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600522C")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public PickUpTrashBehaviour()
		{
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600522D")]
		[Address(RVA = "0x9573B0", Offset = "0x9565B0", VA = "0x1809573B0")]
		[CompilerGenerated]
		private IEnumerator <PerformAction>g__Action|20_0()
		{
			return null;
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600522E")]
		[Address(RVA = "0x956830", Offset = "0x955A30", VA = "0x180956830", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600522F")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005230")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005231")]
		[Address(RVA = "0x957090", Offset = "0x956290", VA = "0x180957090")]
		private void RpcWriter___Observers_PerformAction_2166136261()
		{
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005232")]
		[Address(RVA = "0x956EE0", Offset = "0x9560E0", VA = "0x180956EE0")]
		private void RpcLogic___PerformAction_2166136261()
		{
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005233")]
		[Address(RVA = "0x957050", Offset = "0x956250", VA = "0x180957050")]
		private void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005234")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003819 RID: 14361
		[Token(Token = "0x4003819")]
		public const float ACTION_MAX_DISTANCE = 2f;

		// Token: 0x0400381A RID: 14362
		[Token(Token = "0x400381A")]
		public const string EQUIPPABLE_ASSET_PATH = "Tools/TrashGrabber/TrashGrabber_AvatarEquippable";

		// Token: 0x0400381C RID: 14364
		[Token(Token = "0x400381C")]
		[FieldOffset(Offset = "0x170")]
		private Coroutine actionCoroutine;

		// Token: 0x0400381D RID: 14365
		[Token(Token = "0x400381D")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onPerfomAction;

		// Token: 0x0400381E RID: 14366
		[Token(Token = "0x400381E")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400381F RID: 14367
		[Token(Token = "0x400381F")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted;
	}
}
