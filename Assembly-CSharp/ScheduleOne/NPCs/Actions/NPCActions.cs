using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Law;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.NPCs.Other;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.NPCs.Actions
{
	// Token: 0x02000A76 RID: 2678
	[Token(Token = "0x2000A76")]
	public class NPCActions : NetworkBehaviour
	{
		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06004D56 RID: 19798 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BFD")]
		protected NPCBehaviour behaviour
		{
			[Token(Token = "0x6004D56")]
			[Address(RVA = "0x93E370", Offset = "0x93D570", VA = "0x18093E370")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D57")]
		[Address(RVA = "0x93D320", Offset = "0x93C520", VA = "0x18093D320", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D58")]
		[Address(RVA = "0x93DD30", Offset = "0x93CF30", VA = "0x18093DD30")]
		private void Start()
		{
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D59")]
		[Address(RVA = "0x93D6B0", Offset = "0x93C8B0", VA = "0x18093D6B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5A")]
		[Address(RVA = "0x93D4D0", Offset = "0x93C6D0", VA = "0x18093D4D0")]
		public void Cower()
		{
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5B")]
		[Address(RVA = "0x93D3A0", Offset = "0x93C5A0", VA = "0x18093D3A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CallPolice_Networked(NetworkObject playerObj)
		{
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0x93DC60", Offset = "0x93CE60", VA = "0x18093DC60")]
		public void SetCallPoliceBehaviourCrime(Crime crime)
		{
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void FacePlayer(Player player)
		{
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0x93DCB0", Offset = "0x93CEB0", VA = "0x18093DCB0")]
		public void SetCanUseUmbrella(bool canUseUmbrella)
		{
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0x93E0D0", Offset = "0x93D2D0", VA = "0x18093E0D0")]
		private void UpdateUmbrellaUse()
		{
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00014D00 File Offset: 0x00012F00
		[Token(Token = "0x6004D60")]
		[Address(RVA = "0x93D5E0", Offset = "0x93C7E0", VA = "0x18093D5E0")]
		private float GetRainAmount()
		{
			return 0f;
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D61")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public NPCActions()
		{
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004D62")]
		[Address(RVA = "0x93DFF0", Offset = "0x93D1F0", VA = "0x18093DFF0")]
		[CompilerGenerated]
		private IEnumerator <Cower>g__Wait|8_0()
		{
			return null;
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004D63")]
		[Address(RVA = "0x93E060", Offset = "0x93D260", VA = "0x18093E060")]
		[CompilerGenerated]
		private IEnumerator <SetCanUseUmbrella>g__Wait|12_0()
		{
			return null;
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D64")]
		[Address(RVA = "0x93D620", Offset = "0x93C820", VA = "0x18093D620", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D65")]
		[Address(RVA = "0x797060", Offset = "0x796260", VA = "0x180797060", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D66")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D67")]
		[Address(RVA = "0x93DB30", Offset = "0x93CD30", VA = "0x18093DB30")]
		private void RpcWriter___Server_CallPolice_Networked_3323014238(NetworkObject playerObj)
		{
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D68")]
		[Address(RVA = "0x93D830", Offset = "0x93CA30", VA = "0x18093D830")]
		public void RpcLogic___CallPolice_Networked_3323014238(NetworkObject playerObj)
		{
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D69")]
		[Address(RVA = "0x93DAB0", Offset = "0x93CCB0", VA = "0x18093DAB0")]
		private void RpcReader___Server_CallPolice_Networked_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x93D2D0", Offset = "0x93C4D0", VA = "0x18093D2D0", Slot = "22")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Actions.NPCActions_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003633 RID: 13875
		[Token(Token = "0x4003633")]
		[FieldOffset(Offset = "0x118")]
		private NPC npc;

		// Token: 0x04003634 RID: 13876
		[Token(Token = "0x4003634")]
		[FieldOffset(Offset = "0x120")]
		private bool _canUseUmbrella;

		// Token: 0x04003635 RID: 13877
		[Token(Token = "0x4003635")]
		[FieldOffset(Offset = "0x128")]
		private UseUmbrella _umbrellaAction;

		// Token: 0x04003636 RID: 13878
		[Token(Token = "0x4003636")]
		[FieldOffset(Offset = "0x130")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Actions.NPCActionsAssembly-CSharp.dll_Excuted;

		// Token: 0x04003637 RID: 13879
		[Token(Token = "0x4003637")]
		[FieldOffset(Offset = "0x131")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Actions.NPCActionsAssembly-CSharp.dll_Excuted;
	}
}
