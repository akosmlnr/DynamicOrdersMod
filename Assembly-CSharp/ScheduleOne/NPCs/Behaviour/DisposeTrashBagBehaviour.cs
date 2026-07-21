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

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AE4 RID: 2788
	[Token(Token = "0x2000AE4")]
	public class DisposeTrashBagBehaviour : Behaviour
	{
		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060050EF RID: 20719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2C")]
		public TrashBag TargetBag
		{
			[Token(Token = "0x60050EE")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60050EF")]
			[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C2D")]
		private Cleaner Cleaner
		{
			[Token(Token = "0x60050F0")]
			[Address(RVA = "0x94DFD0", Offset = "0x94D1D0", VA = "0x18094DFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F1")]
		[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
		public void SetTargetBag(TrashBag bag)
		{
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F2")]
		[Address(RVA = "0x94CB50", Offset = "0x94BD50", VA = "0x18094CB50", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F3")]
		[Address(RVA = "0x94D750", Offset = "0x94C950", VA = "0x18094D750", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F4")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void StartAction()
		{
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F5")]
		[Address(RVA = "0x94D730", Offset = "0x94C930", VA = "0x18094D730", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F6")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F7")]
		[Address(RVA = "0x94CD00", Offset = "0x94BF00", VA = "0x18094CD00", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F8")]
		[Address(RVA = "0x94DC30", Offset = "0x94CE30", VA = "0x18094DC30")]
		private void StopAllActions()
		{
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F9")]
		[Address(RVA = "0x94D390", Offset = "0x94C590", VA = "0x18094D390", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FA")]
		[Address(RVA = "0x94CE40", Offset = "0x94C040", VA = "0x18094CE40")]
		private void GoToTarget()
		{
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FB")]
		[Address(RVA = "0x94CF30", Offset = "0x94C130", VA = "0x18094CF30")]
		[ObserversRpc(RunLocally = true)]
		private void GrabTrash()
		{
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FC")]
		[Address(RVA = "0x94CD20", Offset = "0x94BF20", VA = "0x18094CD20")]
		[ObserversRpc(RunLocally = true)]
		private void DropTrash()
		{
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x000152D0 File Offset: 0x000134D0
		[Token(Token = "0x60050FD")]
		[Address(RVA = "0x94D050", Offset = "0x94C250", VA = "0x18094D050")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x94CB60", Offset = "0x94BD60", VA = "0x18094CB60")]
		private bool AreActionConditionsMet(bool checkAccess)
		{
			return default(bool);
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x94DF70", Offset = "0x94D170", VA = "0x18094DF70")]
		public DisposeTrashBagBehaviour()
		{
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005100")]
		[Address(RVA = "0x94DF00", Offset = "0x94D100", VA = "0x18094DF00")]
		[CompilerGenerated]
		private IEnumerator <GrabTrash>g__Action|21_0()
		{
			return null;
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005101")]
		[Address(RVA = "0x94DE90", Offset = "0x94D090", VA = "0x18094DE90")]
		[CompilerGenerated]
		private IEnumerator <DropTrash>g__Action|22_0()
		{
			return null;
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005102")]
		[Address(RVA = "0x94D2B0", Offset = "0x94C4B0", VA = "0x18094D2B0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005103")]
		[Address(RVA = "0x94D290", Offset = "0x94C490", VA = "0x18094D290", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005104")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005105")]
		[Address(RVA = "0x94DB20", Offset = "0x94CD20", VA = "0x18094DB20")]
		private void RpcWriter___Observers_GrabTrash_2166136261()
		{
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005106")]
		[Address(RVA = "0x94D870", Offset = "0x94CA70", VA = "0x18094D870")]
		private void RpcLogic___GrabTrash_2166136261()
		{
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005107")]
		[Address(RVA = "0x94D9C0", Offset = "0x94CBC0", VA = "0x18094D9C0")]
		private void RpcReader___Observers_GrabTrash_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005108")]
		[Address(RVA = "0x94DA00", Offset = "0x94CC00", VA = "0x18094DA00")]
		private void RpcWriter___Observers_DropTrash_2166136261()
		{
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005109")]
		[Address(RVA = "0x94D760", Offset = "0x94C960", VA = "0x18094D760")]
		private void RpcLogic___DropTrash_2166136261()
		{
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510A")]
		[Address(RVA = "0x94D980", Offset = "0x94CB80", VA = "0x18094D980")]
		private void RpcReader___Observers_DropTrash_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510B")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x040037AA RID: 14250
		[Token(Token = "0x40037AA")]
		[FieldOffset(Offset = "0x168")]
		public string TRASH_BAG_ASSET_PATH;

		// Token: 0x040037AB RID: 14251
		[Token(Token = "0x40037AB")]
		public const float GRAB_MAX_DISTANCE = 2f;

		// Token: 0x040037AD RID: 14253
		[Token(Token = "0x40037AD")]
		[FieldOffset(Offset = "0x178")]
		private TrashContent heldTrash;

		// Token: 0x040037AE RID: 14254
		[Token(Token = "0x40037AE")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine grabRoutine;

		// Token: 0x040037AF RID: 14255
		[Token(Token = "0x40037AF")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine dropRoutine;

		// Token: 0x040037B0 RID: 14256
		[Token(Token = "0x40037B0")]
		[FieldOffset(Offset = "0x190")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040037B1 RID: 14257
		[Token(Token = "0x40037B1")]
		[FieldOffset(Offset = "0x191")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviourAssembly-CSharp.dll_Excuted;
	}
}
