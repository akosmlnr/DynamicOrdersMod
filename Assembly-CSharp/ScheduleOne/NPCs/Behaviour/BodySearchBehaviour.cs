using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Product.Packaging;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AD0 RID: 2768
	[Token(Token = "0x2000AD0")]
	public class BodySearchBehaviour : Behaviour
	{
		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Token(Token = "0x17000C0E")]
		public static float BODY_SEARCH_TIME
		{
			[Token(Token = "0x6004FB0")]
			[Address(RVA = "0x935C40", Offset = "0x934E40", VA = "0x180935C40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004FB2 RID: 20402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0F")]
		public Player TargetPlayer
		{
			[Token(Token = "0x6004FB1")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FB2")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C10")]
		private DialogueDatabase dialogueDatabase
		{
			[Token(Token = "0x6004FB3")]
			[Address(RVA = "0x935CE0", Offset = "0x934EE0", VA = "0x180935CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x932E10", Offset = "0x932010", VA = "0x180932E10", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x9329A0", Offset = "0x931BA0", VA = "0x1809329A0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x934250", Offset = "0x933450", VA = "0x180934250", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x933700", Offset = "0x932900", VA = "0x180933700", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x934190", Offset = "0x933390", VA = "0x180934190", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x932F30", Offset = "0x932130", VA = "0x180932F30", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x935870", Offset = "0x934A70", VA = "0x180935870")]
		private void UpdateSearch()
		{
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0x935490", Offset = "0x934690", VA = "0x180935490", Slot = "35")]
		protected virtual void UpdateMovement()
		{
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0x934910", Offset = "0x933B10", VA = "0x180934910")]
		private void SearchClean()
		{
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBD")]
		[Address(RVA = "0x934AB0", Offset = "0x933CB0", VA = "0x180934AB0")]
		private void SearchFail()
		{
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x935080", Offset = "0x934280", VA = "0x180935080")]
		private void UpdateEscalation()
		{
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x935390", Offset = "0x934590", VA = "0x180935390", Slot = "36")]
		protected virtual void UpdateLookAt()
		{
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x934CC0", Offset = "0x933EC0", VA = "0x180934CC0", Slot = "37")]
		protected virtual void UpdateCircle()
		{
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x934C50", Offset = "0x933E50", VA = "0x180934C50")]
		private void SetArrestCircleAlpha(float alpha)
		{
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x934C80", Offset = "0x933E80", VA = "0x180934C80")]
		private void SetArrestCircleColor(Color col)
		{
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00014FB8 File Offset: 0x000131B8
		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x933D00", Offset = "0x932F00", VA = "0x180933D00")]
		private Vector3 GetNewDestination()
		{
			return default(Vector3);
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x933110", Offset = "0x932310", VA = "0x180933110")]
		private void ClearSpeedControls()
		{
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x00014FD0 File Offset: 0x000131D0
		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x933F40", Offset = "0x933140", VA = "0x180933F40")]
		private bool IsTargetValid(Player player)
		{
			return default(bool);
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x932CD0", Offset = "0x931ED0", VA = "0x180932CD0", Slot = "38")]
		[ObserversRpc(RunLocally = true)]
		public virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00014FE8 File Offset: 0x000131E8
		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x933830", Offset = "0x932A30", VA = "0x180933830", Slot = "39")]
		public virtual bool DoesPlayerContainItemsOfInterest()
		{
			return default(bool);
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x9331D0", Offset = "0x9323D0", VA = "0x1809331D0", Slot = "40")]
		public virtual void ConcludeSearch(bool clear)
		{
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x933AF0", Offset = "0x932CF0", VA = "0x180933AF0", Slot = "41")]
		public virtual void Escalate()
		{
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCA")]
		[Address(RVA = "0x9340C0", Offset = "0x9332C0", VA = "0x1809340C0", Slot = "42")]
		public virtual void NoItemsOfInterestFound()
		{
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCB")]
		[Address(RVA = "0x935C10", Offset = "0x934E10", VA = "0x180935C10")]
		public BodySearchBehaviour()
		{
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCC")]
		[Address(RVA = "0x934020", Offset = "0x933220", VA = "0x180934020", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCD")]
		[Address(RVA = "0x933FF0", Offset = "0x9331F0", VA = "0x180933FF0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCE")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FCF")]
		[Address(RVA = "0x9346A0", Offset = "0x9338A0", VA = "0x1809346A0")]
		private void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD0")]
		[Address(RVA = "0x934420", Offset = "0x933620", VA = "0x180934420", Slot = "43")]
		public virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD1")]
		[Address(RVA = "0x934610", Offset = "0x933810", VA = "0x180934610")]
		private void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD2")]
		[Address(RVA = "0x932D10", Offset = "0x931F10", VA = "0x180932D10", Slot = "44")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.BodySearchBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003739 RID: 14137
		[Token(Token = "0x4003739")]
		public const EStealthLevel MAX_STEALTH_LEVEL = EStealthLevel.None;

		// Token: 0x0400373A RID: 14138
		[Token(Token = "0x400373A")]
		public const float BODY_SEARCH_RANGE = 2f;

		// Token: 0x0400373B RID: 14139
		[Token(Token = "0x400373B")]
		public const float MAX_SEARCH_TIME = 15f;

		// Token: 0x0400373C RID: 14140
		[Token(Token = "0x400373C")]
		public const float MAX_TIME_OUTSIDE_RANGE = 4f;

		// Token: 0x0400373D RID: 14141
		[Token(Token = "0x400373D")]
		public const float RANGE_TO_ESCALATE = 15f;

		// Token: 0x0400373E RID: 14142
		[Token(Token = "0x400373E")]
		public const float MOVE_SPEED = 0.15f;

		// Token: 0x0400373F RID: 14143
		[Token(Token = "0x400373F")]
		public const float BODY_SEARCH_COOLDOWN = 30f;

		// Token: 0x04003741 RID: 14145
		[Token(Token = "0x4003741")]
		[FieldOffset(Offset = "0x170")]
		[Header("Settings")]
		public float ArrestCircle_MaxVisibleDistance;

		// Token: 0x04003742 RID: 14146
		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x174")]
		public float ArrestCircle_MaxOpacity;

		// Token: 0x04003743 RID: 14147
		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x178")]
		public bool ShowPostSearchDialogue;

		// Token: 0x04003744 RID: 14148
		[Token(Token = "0x4003744")]
		[FieldOffset(Offset = "0x17C")]
		[Header("Item of interest settings")]
		public EStealthLevel MaxStealthLevel;

		// Token: 0x04003745 RID: 14149
		[Token(Token = "0x4003745")]
		[FieldOffset(Offset = "0x180")]
		private PoliceOfficer officer;

		// Token: 0x04003746 RID: 14150
		[Token(Token = "0x4003746")]
		[FieldOffset(Offset = "0x188")]
		private float targetDistanceOnStart;

		// Token: 0x04003747 RID: 14151
		[Token(Token = "0x4003747")]
		[FieldOffset(Offset = "0x18C")]
		private float searchTime;

		// Token: 0x04003748 RID: 14152
		[Token(Token = "0x4003748")]
		[FieldOffset(Offset = "0x190")]
		private bool hasBeenInRange;

		// Token: 0x04003749 RID: 14153
		[Token(Token = "0x4003749")]
		[FieldOffset(Offset = "0x194")]
		private float timeOutsideRange;

		// Token: 0x0400374A RID: 14154
		[Token(Token = "0x400374A")]
		[FieldOffset(Offset = "0x198")]
		private float timeWithinSearchRange;

		// Token: 0x0400374B RID: 14155
		[Token(Token = "0x400374B")]
		[FieldOffset(Offset = "0x19C")]
		private float timeSinceCantReach;

		// Token: 0x0400374C RID: 14156
		[Token(Token = "0x400374C")]
		[FieldOffset(Offset = "0x1A0")]
		[Header("Events")]
		public UnityEvent onSearchComplete_Clear;

		// Token: 0x0400374D RID: 14157
		[Token(Token = "0x400374D")]
		[FieldOffset(Offset = "0x1A8")]
		public UnityEvent onSearchComplete_ItemsFound;

		// Token: 0x0400374E RID: 14158
		[Token(Token = "0x400374E")]
		[FieldOffset(Offset = "0x1B0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400374F RID: 14159
		[Token(Token = "0x400374F")]
		[FieldOffset(Offset = "0x1B1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted;
	}
}
