using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts.Health
{
	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	public class PlayerHealth : NetworkBehaviour
	{
		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x0000C600 File Offset: 0x0000A800
		// (set) Token: 0x060025EE RID: 9710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A8")]
		public bool IsAlive
		{
			[Token(Token = "0x60025ED")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025EE")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x0000C618 File Offset: 0x0000A818
		// (set) Token: 0x060025F0 RID: 9712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A9")]
		public float CurrentHealth
		{
			[Token(Token = "0x60025EF")]
			[Address(RVA = "0x5C0F90", Offset = "0x5C0190", VA = "0x1805C0F90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025F0")]
			[Address(RVA = "0x5C0FB0", Offset = "0x5C01B0", VA = "0x1805C0FB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x0000C630 File Offset: 0x0000A830
		// (set) Token: 0x060025F2 RID: 9714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AA")]
		public float TimeSinceLastDamage
		{
			[Token(Token = "0x60025F1")]
			[Address(RVA = "0x5D6EB0", Offset = "0x5D60B0", VA = "0x1805D6EB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025F2")]
			[Address(RVA = "0x5D6ED0", Offset = "0x5D60D0", VA = "0x1805D6ED0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x0000C648 File Offset: 0x0000A848
		[Token(Token = "0x170006AB")]
		public bool CanTakeDamage
		{
			[Token(Token = "0x60025F3")]
			[Address(RVA = "0x6CC120", Offset = "0x6CB320", VA = "0x1806CC120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x6C9E00", Offset = "0x6C9000", VA = "0x1806C9E00", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x6CBD30", Offset = "0x6CAF30", VA = "0x1806CBD30")]
		private void Start()
		{
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x6CB5A0", Offset = "0x6CA7A0", VA = "0x1806CB5A0")]
		[ObserversRpc]
		public void TakeDamage(float damage, bool flinch = true, bool playBloodMist = true)
		{
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x6CBF50", Offset = "0x6CB150", VA = "0x1806CBF50")]
		private void Update()
		{
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x6CA030", Offset = "0x6C9230", VA = "0x1806CA030")]
		private void MinPass()
		{
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x6CBC80", Offset = "0x6CAE80", VA = "0x1806CBC80")]
		public void SetAfflictedWithLethalEffect(bool value)
		{
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FA")]
		[Address(RVA = "0x6CA470", Offset = "0x6C9670", VA = "0x1806CA470")]
		public void RecoverHealth(float recovery)
		{
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FB")]
		[Address(RVA = "0x6CBC90", Offset = "0x6CAE90", VA = "0x1806CBC90")]
		public void SetHealth(float health)
		{
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FC")]
		[Address(RVA = "0x6CBAC0", Offset = "0x6CACC0", VA = "0x1806CBAC0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendDie()
		{
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FD")]
		[Address(RVA = "0x6C9F10", Offset = "0x6C9110", VA = "0x1806C9F10")]
		[ObserversRpc(RunLocally = true)]
		public void Die()
		{
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FE")]
		[Address(RVA = "0x6CBBD0", Offset = "0x6CADD0", VA = "0x1806CBBD0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendRevive(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x6CA550", Offset = "0x6C9750", VA = "0x1806CA550")]
		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void Revive(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002600")]
		[Address(RVA = "0x6CA350", Offset = "0x6C9550", VA = "0x1806CA350")]
		[ObserversRpc]
		public void PlayBloodMist()
		{
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002601")]
		[Address(RVA = "0x6CC100", Offset = "0x6CB300", VA = "0x1806CC100")]
		public PlayerHealth()
		{
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002603")]
		[Address(RVA = "0x6CA160", Offset = "0x6C9360", VA = "0x1806CA160", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002604")]
		[Address(RVA = "0x6CA140", Offset = "0x6C9340", VA = "0x1806CA140", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002605")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002606")]
		[Address(RVA = "0x6CB5A0", Offset = "0x6CA7A0", VA = "0x1806CB5A0")]
		private void RpcWriter___Observers_TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002607")]
		[Address(RVA = "0x6CA9E0", Offset = "0x6C9BE0", VA = "0x1806CA9E0")]
		public void RpcLogic___TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002608")]
		[Address(RVA = "0x6CAF30", Offset = "0x6CA130", VA = "0x1806CAF30")]
		private void RpcReader___Observers_TakeDamage_3505310624(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002609")]
		[Address(RVA = "0x6CB710", Offset = "0x6CA910", VA = "0x1806CB710")]
		private void RpcWriter___Server_SendDie_2166136261()
		{
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260A")]
		[Address(RVA = "0x6C9F10", Offset = "0x6C9110", VA = "0x1806C9F10")]
		public void RpcLogic___SendDie_2166136261()
		{
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260B")]
		[Address(RVA = "0x6CB010", Offset = "0x6CA210", VA = "0x1806CB010")]
		private void RpcReader___Server_SendDie_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260C")]
		[Address(RVA = "0x6CB1C0", Offset = "0x6CA3C0", VA = "0x1806CB1C0")]
		private void RpcWriter___Observers_Die_2166136261()
		{
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x6CA5E0", Offset = "0x6C97E0", VA = "0x1806CA5E0")]
		public void RpcLogic___Die_2166136261()
		{
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00")]
		private void RpcReader___Observers_Die_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x6CB820", Offset = "0x6CAA20", VA = "0x1806CB820")]
		private void RpcWriter___Server_SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x6CA550", Offset = "0x6C9750", VA = "0x1806CA550")]
		public void RpcLogic___SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x6CB060", Offset = "0x6CA260", VA = "0x1806CB060")]
		private void RpcReader___Server_SendRevive_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x6CB2E0", Offset = "0x6CA4E0", VA = "0x1806CB2E0")]
		private void RpcWriter___Observers_Revive_3848837105(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x6CA7A0", Offset = "0x6C99A0", VA = "0x1806CA7A0")]
		public void RpcLogic___Revive_3848837105(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x6CAE10", Offset = "0x6CA010", VA = "0x1806CAE10")]
		private void RpcReader___Observers_Revive_3848837105(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x6CA350", Offset = "0x6C9550", VA = "0x1806CA350")]
		private void RpcWriter___Observers_PlayBloodMist_2166136261()
		{
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x6CA6F0", Offset = "0x6C98F0", VA = "0x1806CA6F0")]
		public void RpcLogic___PlayBloodMist_2166136261()
		{
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x6CAD40", Offset = "0x6C9F40", VA = "0x1806CAD40")]
		private void RpcReader___Observers_PlayBloodMist_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x6C9D10", Offset = "0x6C8F10", VA = "0x1806C9D10")]
		private void Awake_UserLogic_ScheduleOne.PlayerScripts.Health.PlayerHealth_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001DB2 RID: 7602
		[Token(Token = "0x4001DB2")]
		public const float MAX_HEALTH = 100f;

		// Token: 0x04001DB3 RID: 7603
		[Token(Token = "0x4001DB3")]
		public const float HEALTH_RECOVERY_PER_MINUTE = 0.5f;

		// Token: 0x04001DB7 RID: 7607
		[Token(Token = "0x4001DB7")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public Player Player;

		// Token: 0x04001DB8 RID: 7608
		[Token(Token = "0x4001DB8")]
		[FieldOffset(Offset = "0x130")]
		public UnityEvent<float> onHealthChanged;

		// Token: 0x04001DB9 RID: 7609
		[Token(Token = "0x4001DB9")]
		[FieldOffset(Offset = "0x138")]
		public UnityEvent onDie;

		// Token: 0x04001DBA RID: 7610
		[Token(Token = "0x4001DBA")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onRevive;

		// Token: 0x04001DBB RID: 7611
		[Token(Token = "0x4001DBB")]
		[FieldOffset(Offset = "0x148")]
		private bool AfflictedWithLethalEffect;

		// Token: 0x04001DBC RID: 7612
		[Token(Token = "0x4001DBC")]
		[FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted;

		// Token: 0x04001DBD RID: 7613
		[Token(Token = "0x4001DBD")]
		[FieldOffset(Offset = "0x14A")]
		private bool NetworkInitialize__LateScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted;
	}
}
