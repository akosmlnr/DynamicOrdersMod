using System;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000ABD RID: 2749
	[Token(Token = "0x2000ABD")]
	public class SchizoGoblin : NPC
	{
		// Token: 0x06004EF5 RID: 20213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EF5")]
		[Address(RVA = "0x942860", Offset = "0x941A60", VA = "0x180942860")]
		[ObserversRpc]
		public void SetTargetPlayer(NetworkObject player)
		{
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EF6")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void Activate()
		{
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EF7")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public SchizoGoblin()
		{
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EF8")]
		[Address(RVA = "0x9425E0", Offset = "0x9417E0", VA = "0x1809425E0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EF9")]
		[Address(RVA = "0x93D240", Offset = "0x93C440", VA = "0x18093D240", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EFA")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EFB")]
		[Address(RVA = "0x942860", Offset = "0x941A60", VA = "0x180942860")]
		private void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EFC")]
		[Address(RVA = "0x942680", Offset = "0x941880", VA = "0x180942680")]
		public void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EFD")]
		[Address(RVA = "0x942750", Offset = "0x941950", VA = "0x180942750")]
		private void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EFE")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x040036EB RID: 14059
		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0x328")]
		private Player targetPlayer;

		// Token: 0x040036EC RID: 14060
		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x330")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted;

		// Token: 0x040036ED RID: 14061
		[Token(Token = "0x40036ED")]
		[FieldOffset(Offset = "0x331")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted;
	}
}
