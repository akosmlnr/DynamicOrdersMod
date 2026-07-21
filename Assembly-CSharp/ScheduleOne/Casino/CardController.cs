using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	public class CardController : NetworkBehaviour
	{
		// Token: 0x0600314A RID: 12618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x755C20", Offset = "0x754E20", VA = "0x180755C20", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314B")]
		[Address(RVA = "0x757860", Offset = "0x756A60", VA = "0x180757860")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314C")]
		[Address(RVA = "0x756110", Offset = "0x755310", VA = "0x180756110")]
		[ObserversRpc(RunLocally = true)]
		private void SetCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314D")]
		[Address(RVA = "0x757610", Offset = "0x756810", VA = "0x180757610")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardFaceUp(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314E")]
		[Address(RVA = "0x755EE0", Offset = "0x7550E0", VA = "0x180755EE0")]
		[ObserversRpc(RunLocally = true)]
		private void SetCardFaceUp(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314F")]
		[Address(RVA = "0x757760", Offset = "0x756960", VA = "0x180757760")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003150")]
		[Address(RVA = "0x756040", Offset = "0x755240", VA = "0x180756040")]
		[ObserversRpc(RunLocally = true)]
		private void SetCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003151")]
		[Address(RVA = "0x755C70", Offset = "0x754E70", VA = "0x180755C70")]
		private PlayingCard GetCard(string cardId)
		{
			return null;
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003152")]
		[Address(RVA = "0x7579D0", Offset = "0x756BD0", VA = "0x1807579D0")]
		public CardController()
		{
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003153")]
		[Address(RVA = "0x755CF0", Offset = "0x754EF0", VA = "0x180755CF0", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003154")]
		[Address(RVA = "0x755CD0", Offset = "0x754ED0", VA = "0x180755CD0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003155")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003156")]
		[Address(RVA = "0x7574B0", Offset = "0x7566B0", VA = "0x1807574B0")]
		private void RpcWriter___Server_SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003157")]
		[Address(RVA = "0x756110", Offset = "0x755310", VA = "0x180756110")]
		public void RpcLogic___SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003158")]
		[Address(RVA = "0x756A50", Offset = "0x755C50", VA = "0x180756A50")]
		private void RpcReader___Server_SendCardValue_3709737967(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003159")]
		[Address(RVA = "0x756F30", Offset = "0x756130", VA = "0x180756F30")]
		private void RpcWriter___Observers_SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315A")]
		[Address(RVA = "0x756480", Offset = "0x755680", VA = "0x180756480")]
		private void RpcLogic___SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315B")]
		[Address(RVA = "0x756750", Offset = "0x755950", VA = "0x180756750")]
		private void RpcReader___Observers_SetCardValue_3709737967(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315C")]
		[Address(RVA = "0x7570A0", Offset = "0x7562A0", VA = "0x1807570A0")]
		private void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315D")]
		[Address(RVA = "0x755EE0", Offset = "0x7550E0", VA = "0x180755EE0")]
		public void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315E")]
		[Address(RVA = "0x7567F0", Offset = "0x7559F0", VA = "0x1807567F0")]
		private void RpcReader___Server_SendCardFaceUp_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315F")]
		[Address(RVA = "0x756B00", Offset = "0x755D00", VA = "0x180756B00")]
		private void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x7562A0", Offset = "0x7554A0", VA = "0x1807562A0")]
		private void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x756560", Offset = "0x755760", VA = "0x180756560")]
		private void RpcReader___Observers_SetCardFaceUp_310431262(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x757200", Offset = "0x756400", VA = "0x180757200")]
		private void RpcWriter___Server_SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003163")]
		[Address(RVA = "0x756040", Offset = "0x755240", VA = "0x180756040")]
		public void RpcLogic___SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003164")]
		[Address(RVA = "0x7568A0", Offset = "0x755AA0", VA = "0x1807568A0")]
		private void RpcReader___Server_SendCardGlide_2833372058(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003165")]
		[Address(RVA = "0x756C70", Offset = "0x755E70", VA = "0x180756C70")]
		private void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003166")]
		[Address(RVA = "0x756370", Offset = "0x755570", VA = "0x180756370")]
		private void RpcLogic___SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003167")]
		[Address(RVA = "0x756600", Offset = "0x755800", VA = "0x180756600")]
		private void RpcReader___Observers_SetCardGlide_2833372058(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003168")]
		[Address(RVA = "0x7559A0", Offset = "0x754BA0", VA = "0x1807559A0")]
		private void Awake_UserLogic_ScheduleOne.Casino.CardController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002461 RID: 9313
		[Token(Token = "0x4002461")]
		[FieldOffset(Offset = "0x118")]
		private List<PlayingCard> cards;

		// Token: 0x04002462 RID: 9314
		[Token(Token = "0x4002462")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<string, PlayingCard> cardDictionary;

		// Token: 0x04002463 RID: 9315
		[Token(Token = "0x4002463")]
		[FieldOffset(Offset = "0x128")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002464 RID: 9316
		[Token(Token = "0x4002464")]
		[FieldOffset(Offset = "0x129")]
		private bool NetworkInitialize__LateScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted;
	}
}
