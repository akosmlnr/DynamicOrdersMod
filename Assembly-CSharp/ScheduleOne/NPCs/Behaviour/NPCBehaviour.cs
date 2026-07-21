using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B1A RID: 2842
	[Token(Token = "0x2000B1A")]
	public class NPCBehaviour : NetworkBehaviour
	{
		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060053C7 RID: 21447 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060053C8 RID: 21448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C77")]
		public Behaviour activeBehaviour
		{
			[Token(Token = "0x60053C7")]
			[Address(RVA = "0x84CC40", Offset = "0x84BE40", VA = "0x18084CC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053C8")]
			[Address(RVA = "0x84CFE0", Offset = "0x84C1E0", VA = "0x18084CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060053C9 RID: 21449 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060053CA RID: 21450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C78")]
		public NPC Npc
		{
			[Token(Token = "0x60053C9")]
			[Address(RVA = "0x96D8C0", Offset = "0x96CAC0", VA = "0x18096D8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053CA")]
			[Address(RVA = "0x96D8D0", Offset = "0x96CAD0", VA = "0x18096D8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CB")]
		[Address(RVA = "0x9678D0", Offset = "0x966AD0", VA = "0x1809678D0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CC")]
		[Address(RVA = "0x96CE00", Offset = "0x96C000", VA = "0x18096CE00", Slot = "20")]
		protected virtual void Start()
		{
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CD")]
		[Address(RVA = "0x968E20", Offset = "0x968020", VA = "0x180968E20")]
		private void OnDestroy()
		{
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CE")]
		[Address(RVA = "0x969550", Offset = "0x968750", VA = "0x180969550", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CF")]
		[Address(RVA = "0x969320", Offset = "0x968520", VA = "0x180969320", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D0")]
		[Address(RVA = "0x96D310", Offset = "0x96C510", VA = "0x18096D310")]
		[ServerRpc(RequireOwnership = false)]
		public void Summon(string buildingGUID, int doorIndex, float duration)
		{
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D1")]
		[Address(RVA = "0x967920", Offset = "0x966B20", VA = "0x180967920")]
		[ServerRpc(RequireOwnership = false)]
		public void ConsumeProduct(ProductItemInstance product, bool removeFromInventory = false)
		{
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D2")]
		[Address(RVA = "0x969020", Offset = "0x968220", VA = "0x180969020")]
		private void OnKnockOut()
		{
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D3")]
		[Address(RVA = "0x9691F0", Offset = "0x9683F0", VA = "0x1809691F0")]
		private void OnRevive()
		{
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D4")]
		[Address(RVA = "0x968FE0", Offset = "0x9681E0", VA = "0x180968FE0", Slot = "21")]
		protected virtual void OnDie()
		{
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60053D5")]
		[Address(RVA = "0x9685C0", Offset = "0x9677C0", VA = "0x1809685C0")]
		public Behaviour GetBehaviour(string BehaviourName)
		{
			return null;
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60053D6")]
		public T GetBehaviour<T>() where T : Behaviour
		{
			return null;
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D7")]
		[Address(RVA = "0x96D440", Offset = "0x96C640", VA = "0x18096D440", Slot = "22")]
		public virtual void Update()
		{
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D8")]
		[Address(RVA = "0x968780", Offset = "0x967980", VA = "0x180968780", Slot = "23")]
		public virtual void LateUpdate()
		{
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D9")]
		[Address(RVA = "0x969410", Offset = "0x968610", VA = "0x180969410", Slot = "24")]
		protected virtual void OnTick()
		{
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053DA")]
		[Address(RVA = "0x9694B0", Offset = "0x9686B0", VA = "0x1809694B0", Slot = "25")]
		protected virtual void OnUncappedMinutePass()
		{
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053DB")]
		[Address(RVA = "0x96CC40", Offset = "0x96BE40", VA = "0x18096CC40")]
		public void SortBehaviourStack()
		{
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60053DC")]
		[Address(RVA = "0x968740", Offset = "0x967940", VA = "0x180968740")]
		private Behaviour GetEnabledBehaviour()
		{
			return null;
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053DD")]
		[Address(RVA = "0x9674F0", Offset = "0x9666F0", VA = "0x1809674F0")]
		private void AddEnabledBehaviour(Behaviour b)
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053DE")]
		[Address(RVA = "0x969B40", Offset = "0x968D40", VA = "0x180969B40")]
		private void RemoveEnabledBehaviour(Behaviour b)
		{
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053DF")]
		[Address(RVA = "0x968480", Offset = "0x967680", VA = "0x180968480")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void EnableBehaviour_Server(int behaviourIndex)
		{
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E0")]
		[Address(RVA = "0x968200", Offset = "0x967400", VA = "0x180968200")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void EnableBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E1")]
		[Address(RVA = "0x9680C0", Offset = "0x9672C0", VA = "0x1809680C0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DisableBehaviour_Server(int behaviourIndex)
		{
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E2")]
		[Address(RVA = "0x967E40", Offset = "0x967040", VA = "0x180967E40")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void DisableBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E3")]
		[Address(RVA = "0x9673B0", Offset = "0x9665B0", VA = "0x1809673B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ActivateBehaviour_Server(int behaviourIndex)
		{
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E4")]
		[Address(RVA = "0x967130", Offset = "0x966330", VA = "0x180967130")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void ActivateBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E5")]
		[Address(RVA = "0x967D00", Offset = "0x966F00", VA = "0x180967D00")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DeactivateBehaviour_Server(int behaviourIndex)
		{
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E6")]
		[Address(RVA = "0x967A80", Offset = "0x966C80", VA = "0x180967A80")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void DeactivateBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E7")]
		[Address(RVA = "0x969A00", Offset = "0x968C00", VA = "0x180969A00")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void PauseBehaviour_Server(int behaviourIndex)
		{
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E8")]
		[Address(RVA = "0x969780", Offset = "0x968980", VA = "0x180969780")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void PauseBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E9")]
		[Address(RVA = "0x969F80", Offset = "0x969180", VA = "0x180969F80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ResumeBehaviour_Server(int behaviourIndex)
		{
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EA")]
		[Address(RVA = "0x969D00", Offset = "0x968F00", VA = "0x180969D00")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void ResumeBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EB")]
		[Address(RVA = "0x96D800", Offset = "0x96CA00", VA = "0x18096D800")]
		public NPCBehaviour()
		{
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EC")]
		[Address(RVA = "0x96D320", Offset = "0x96C520", VA = "0x18096D320")]
		[CompilerGenerated]
		private void <OnSpawnServer>g__Replicate|31_0(NetworkConnection conn)
		{
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053ED")]
		[Address(RVA = "0x968880", Offset = "0x967A80", VA = "0x180968880", Slot = "26")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EE")]
		[Address(RVA = "0x968860", Offset = "0x967A60", VA = "0x180968860", Slot = "27")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EF")]
		[Address(RVA = "0x968820", Offset = "0x967A20", VA = "0x180968820", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F0")]
		[Address(RVA = "0x96C180", Offset = "0x96B380", VA = "0x18096C180")]
		private void RpcWriter___Server_Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x96A4E0", Offset = "0x9696E0", VA = "0x18096A4E0")]
		public void RpcLogic___Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F2")]
		[Address(RVA = "0x96AEE0", Offset = "0x96A0E0", VA = "0x18096AEE0")]
		private void RpcReader___Server_Summon_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F3")]
		[Address(RVA = "0x967920", Offset = "0x966B20", VA = "0x180967920")]
		private void RpcWriter___Server_ConsumeProduct_3964170259(ProductItemInstance product, bool removeFromInventory = false)
		{
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F4")]
		[Address(RVA = "0x96A150", Offset = "0x969350", VA = "0x18096A150")]
		public void RpcLogic___ConsumeProduct_3964170259(ProductItemInstance product, bool removeFromInventory = false)
		{
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F5")]
		[Address(RVA = "0x96AB50", Offset = "0x969D50", VA = "0x18096AB50")]
		private void RpcReader___Server_ConsumeProduct_3964170259(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F6")]
		[Address(RVA = "0x96BDC0", Offset = "0x96AFC0", VA = "0x18096BDC0")]
		private void RpcWriter___Server_EnableBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F7")]
		[Address(RVA = "0x96A3B0", Offset = "0x9695B0", VA = "0x18096A3B0")]
		public void RpcLogic___EnableBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F8")]
		[Address(RVA = "0x96AD60", Offset = "0x969F60", VA = "0x18096AD60")]
		private void RpcReader___Server_EnableBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F9")]
		[Address(RVA = "0x96B610", Offset = "0x96A810", VA = "0x18096B610")]
		private void RpcWriter___Observers_EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053FA")]
		[Address(RVA = "0x96A330", Offset = "0x969530", VA = "0x18096A330")]
		public void RpcLogic___EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053FB")]
		[Address(RVA = "0x96A980", Offset = "0x969B80", VA = "0x18096A980")]
		private void RpcReader___Observers_EnableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060053FC RID: 21500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053FC")]
		[Address(RVA = "0x96C7F0", Offset = "0x96B9F0", VA = "0x18096C7F0")]
		private void RpcWriter___Target_EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053FD")]
		[Address(RVA = "0x96B0D0", Offset = "0x96A2D0", VA = "0x18096B0D0")]
		private void RpcReader___Target_EnableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053FE")]
		[Address(RVA = "0x96BC80", Offset = "0x96AE80", VA = "0x18096BC80")]
		private void RpcWriter___Server_DisableBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053FF")]
		[Address(RVA = "0x96A320", Offset = "0x969520", VA = "0x18096A320")]
		public void RpcLogic___DisableBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005400")]
		[Address(RVA = "0x96ACE0", Offset = "0x969EE0", VA = "0x18096ACE0")]
		private void RpcReader___Server_DisableBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005401")]
		[Address(RVA = "0x96B4C0", Offset = "0x96A6C0", VA = "0x18096B4C0")]
		private void RpcWriter___Observers_DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005402")]
		[Address(RVA = "0x96A2A0", Offset = "0x9694A0", VA = "0x18096A2A0")]
		public void RpcLogic___DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005403")]
		[Address(RVA = "0x96A910", Offset = "0x969B10", VA = "0x18096A910")]
		private void RpcReader___Observers_DisableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005404")]
		[Address(RVA = "0x96C680", Offset = "0x96B880", VA = "0x18096C680")]
		private void RpcWriter___Target_DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005405")]
		[Address(RVA = "0x96B060", Offset = "0x96A260", VA = "0x18096B060")]
		private void RpcReader___Target_DisableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005406")]
		[Address(RVA = "0x96BA00", Offset = "0x96AC00", VA = "0x18096BA00")]
		private void RpcWriter___Server_ActivateBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005407")]
		[Address(RVA = "0x96A140", Offset = "0x969340", VA = "0x18096A140")]
		public void RpcLogic___ActivateBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005408")]
		[Address(RVA = "0x96AAD0", Offset = "0x969CD0", VA = "0x18096AAD0")]
		private void RpcReader___Server_ActivateBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005409")]
		[Address(RVA = "0x96B220", Offset = "0x96A420", VA = "0x18096B220")]
		private void RpcWriter___Observers_ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540A")]
		[Address(RVA = "0x96A0C0", Offset = "0x9692C0", VA = "0x18096A0C0")]
		public void RpcLogic___ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540B")]
		[Address(RVA = "0x96A830", Offset = "0x969A30", VA = "0x18096A830")]
		private void RpcReader___Observers_ActivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540C")]
		[Address(RVA = "0x96C3A0", Offset = "0x96B5A0", VA = "0x18096C3A0")]
		private void RpcWriter___Target_ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x0600540D RID: 21517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540D")]
		[Address(RVA = "0x96AF80", Offset = "0x96A180", VA = "0x18096AF80")]
		private void RpcReader___Target_ActivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600540E RID: 21518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540E")]
		[Address(RVA = "0x96BB40", Offset = "0x96AD40", VA = "0x18096BB40")]
		private void RpcWriter___Server_DeactivateBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540F")]
		[Address(RVA = "0x96A290", Offset = "0x969490", VA = "0x18096A290")]
		public void RpcLogic___DeactivateBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005410")]
		[Address(RVA = "0x96AC60", Offset = "0x969E60", VA = "0x18096AC60")]
		private void RpcReader___Server_DeactivateBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005411")]
		[Address(RVA = "0x96B370", Offset = "0x96A570", VA = "0x18096B370")]
		private void RpcWriter___Observers_DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005412")]
		[Address(RVA = "0x96A210", Offset = "0x969410", VA = "0x18096A210")]
		public void RpcLogic___DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005413")]
		[Address(RVA = "0x96A8A0", Offset = "0x969AA0", VA = "0x18096A8A0")]
		private void RpcReader___Observers_DeactivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005414")]
		[Address(RVA = "0x96C510", Offset = "0x96B710", VA = "0x18096C510")]
		private void RpcWriter___Target_DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005415")]
		[Address(RVA = "0x96AFF0", Offset = "0x96A1F0", VA = "0x18096AFF0")]
		private void RpcReader___Target_DeactivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005416")]
		[Address(RVA = "0x96BF00", Offset = "0x96B100", VA = "0x18096BF00")]
		private void RpcWriter___Server_PauseBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005417")]
		[Address(RVA = "0x96A440", Offset = "0x969640", VA = "0x18096A440")]
		public void RpcLogic___PauseBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005418")]
		[Address(RVA = "0x96ADE0", Offset = "0x969FE0", VA = "0x18096ADE0")]
		private void RpcReader___Server_PauseBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005419")]
		[Address(RVA = "0x96B760", Offset = "0x96A960", VA = "0x18096B760")]
		private void RpcWriter___Observers_PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600541A")]
		[Address(RVA = "0x96A3C0", Offset = "0x9695C0", VA = "0x18096A3C0")]
		public void RpcLogic___PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600541B")]
		[Address(RVA = "0x96A9F0", Offset = "0x969BF0", VA = "0x18096A9F0")]
		private void RpcReader___Observers_PauseBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600541C")]
		[Address(RVA = "0x96C960", Offset = "0x96BB60", VA = "0x18096C960")]
		private void RpcWriter___Target_PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600541D")]
		[Address(RVA = "0x96B140", Offset = "0x96A340", VA = "0x18096B140")]
		private void RpcReader___Target_PauseBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600541E")]
		[Address(RVA = "0x96C040", Offset = "0x96B240", VA = "0x18096C040")]
		private void RpcWriter___Server_ResumeBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600541F")]
		[Address(RVA = "0x96A4D0", Offset = "0x9696D0", VA = "0x18096A4D0")]
		public void RpcLogic___ResumeBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005420")]
		[Address(RVA = "0x96AE60", Offset = "0x96A060", VA = "0x18096AE60")]
		private void RpcReader___Server_ResumeBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005421")]
		[Address(RVA = "0x96B8B0", Offset = "0x96AAB0", VA = "0x18096B8B0")]
		private void RpcWriter___Observers_ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005422")]
		[Address(RVA = "0x96A450", Offset = "0x969650", VA = "0x18096A450")]
		public void RpcLogic___ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005423")]
		[Address(RVA = "0x96AA60", Offset = "0x969C60", VA = "0x18096AA60")]
		private void RpcReader___Observers_ResumeBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005424")]
		[Address(RVA = "0x96CAD0", Offset = "0x96BCD0", VA = "0x18096CAD0")]
		private void RpcWriter___Target_ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005425")]
		[Address(RVA = "0x96B1B0", Offset = "0x96A3B0", VA = "0x18096B1B0")]
		private void RpcReader___Target_ResumeBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005426")]
		[Address(RVA = "0x9676B0", Offset = "0x9668B0", VA = "0x1809676B0", Slot = "28")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.NPCBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040038BD RID: 14525
		[Token(Token = "0x40038BD")]
		[FieldOffset(Offset = "0x118")]
		public bool DEBUG_MODE;

		// Token: 0x040038BE RID: 14526
		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		public NPCScheduleManager ScheduleManager;

		// Token: 0x040038BF RID: 14527
		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0x128")]
		[Header("Default Behaviours")]
		public CoweringBehaviour CoweringBehaviour;

		// Token: 0x040038C0 RID: 14528
		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0x130")]
		public RagdollBehaviour RagdollBehaviour;

		// Token: 0x040038C1 RID: 14529
		[Token(Token = "0x40038C1")]
		[FieldOffset(Offset = "0x138")]
		public CallPoliceBehaviour CallPoliceBehaviour;

		// Token: 0x040038C2 RID: 14530
		[Token(Token = "0x40038C2")]
		[FieldOffset(Offset = "0x140")]
		public GenericDialogueBehaviour GenericDialogueBehaviour;

		// Token: 0x040038C3 RID: 14531
		[Token(Token = "0x40038C3")]
		[FieldOffset(Offset = "0x148")]
		public HeavyFlinchBehaviour HeavyFlinchBehaviour;

		// Token: 0x040038C4 RID: 14532
		[Token(Token = "0x40038C4")]
		[FieldOffset(Offset = "0x150")]
		public FaceTargetBehaviour FaceTargetBehaviour;

		// Token: 0x040038C5 RID: 14533
		[Token(Token = "0x40038C5")]
		[FieldOffset(Offset = "0x158")]
		public DeadBehaviour DeadBehaviour;

		// Token: 0x040038C6 RID: 14534
		[Token(Token = "0x40038C6")]
		[FieldOffset(Offset = "0x160")]
		public UnconsciousBehaviour UnconsciousBehaviour;

		// Token: 0x040038C7 RID: 14535
		[Token(Token = "0x40038C7")]
		[FieldOffset(Offset = "0x168")]
		public Behaviour SummonBehaviour;

		// Token: 0x040038C8 RID: 14536
		[Token(Token = "0x40038C8")]
		[FieldOffset(Offset = "0x170")]
		public ConsumeProductBehaviour ConsumeProductBehaviour;

		// Token: 0x040038C9 RID: 14537
		[Token(Token = "0x40038C9")]
		[FieldOffset(Offset = "0x178")]
		public CombatBehaviour CombatBehaviour;

		// Token: 0x040038CA RID: 14538
		[Token(Token = "0x40038CA")]
		[FieldOffset(Offset = "0x180")]
		public FleeBehaviour FleeBehaviour;

		// Token: 0x040038CB RID: 14539
		[Token(Token = "0x40038CB")]
		[FieldOffset(Offset = "0x188")]
		public StationaryBehaviour StationaryBehaviour;

		// Token: 0x040038CC RID: 14540
		[Token(Token = "0x40038CC")]
		[FieldOffset(Offset = "0x190")]
		public RequestProductBehaviour RequestProductBehaviour;

		// Token: 0x040038CD RID: 14541
		[Token(Token = "0x40038CD")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		protected List<Behaviour> behaviourStack;

		// Token: 0x040038D0 RID: 14544
		[Token(Token = "0x40038D0")]
		[FieldOffset(Offset = "0x1B0")]
		private Coroutine summonRoutine;

		// Token: 0x040038D1 RID: 14545
		[Token(Token = "0x40038D1")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private List<Behaviour> enabledBehaviours;

		// Token: 0x040038D2 RID: 14546
		[Token(Token = "0x40038D2")]
		[FieldOffset(Offset = "0x1C0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040038D3 RID: 14547
		[Token(Token = "0x40038D3")]
		[FieldOffset(Offset = "0x1C1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted;
	}
}
