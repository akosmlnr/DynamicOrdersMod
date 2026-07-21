using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	public class BlackjackGameController : CasinoGameController
	{
		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060030E4 RID: 12516 RVA: 0x0000F210 File Offset: 0x0000D410
		// (set) Token: 0x060030E5 RID: 12517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FF")]
		public BlackjackGameController.EStage CurrentStage
		{
			[Token(Token = "0x60030E4")]
			[Address(RVA = "0x71D580", Offset = "0x71C780", VA = "0x18071D580")]
			[CompilerGenerated]
			get
			{
				return BlackjackGameController.EStage.WaitingForPlayers;
			}
			[Token(Token = "0x60030E5")]
			[Address(RVA = "0x71D760", Offset = "0x71C960", VA = "0x18071D760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000800")]
		public Player PlayerTurn
		{
			[Token(Token = "0x60030E6")]
			[Address(RVA = "0x5A44D0", Offset = "0x5A36D0", VA = "0x1805A44D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030E7")]
			[Address(RVA = "0x755980", Offset = "0x754B80", VA = "0x180755980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x0000F228 File Offset: 0x0000D428
		// (set) Token: 0x060030E9 RID: 12521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000801")]
		public float LocalPlayerBet
		{
			[Token(Token = "0x60030E8")]
			[Address(RVA = "0x755910", Offset = "0x754B10", VA = "0x180755910")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60030E9")]
			[Address(RVA = "0x755960", Offset = "0x754B60", VA = "0x180755960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x0000F240 File Offset: 0x0000D440
		// (set) Token: 0x060030EB RID: 12523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000802")]
		public int DealerScore
		{
			[Token(Token = "0x60030EA")]
			[Address(RVA = "0x755850", Offset = "0x754A50", VA = "0x180755850")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60030EB")]
			[Address(RVA = "0x755930", Offset = "0x754B30", VA = "0x180755930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x0000F258 File Offset: 0x0000D458
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000803")]
		public int LocalPlayerScore
		{
			[Token(Token = "0x60030EC")]
			[Address(RVA = "0x755920", Offset = "0x754B20", VA = "0x180755920")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60030ED")]
			[Address(RVA = "0x755970", Offset = "0x754B70", VA = "0x180755970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x0000F270 File Offset: 0x0000D470
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000804")]
		public bool IsLocalPlayerBlackjack
		{
			[Token(Token = "0x60030EE")]
			[Address(RVA = "0x755860", Offset = "0x754A60", VA = "0x180755860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60030EF")]
			[Address(RVA = "0x755940", Offset = "0x754B40", VA = "0x180755940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x0000F288 File Offset: 0x0000D488
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000805")]
		public bool IsLocalPlayerBust
		{
			[Token(Token = "0x60030F0")]
			[Address(RVA = "0x755870", Offset = "0x754A70", VA = "0x180755870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60030F1")]
			[Address(RVA = "0x755950", Offset = "0x754B50", VA = "0x180755950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[Token(Token = "0x17000806")]
		public bool IsLocalPlayerInCurrentRound
		{
			[Token(Token = "0x60030F2")]
			[Address(RVA = "0x755880", Offset = "0x754A80", VA = "0x180755880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F3")]
		[Address(RVA = "0x751070", Offset = "0x750270", VA = "0x180751070", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x7522E0", Offset = "0x7514E0", VA = "0x1807522E0", Slot = "22")]
		protected override void Open()
		{
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x751230", Offset = "0x750430", VA = "0x180751230", Slot = "23")]
		protected override void Close()
		{
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F6")]
		[Address(RVA = "0x7515C0", Offset = "0x7507C0", VA = "0x1807515C0", Slot = "21")]
		protected override void Exit(ExitAction action)
		{
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030F7")]
		[Address(RVA = "0x7516B0", Offset = "0x7508B0", VA = "0x1807516B0")]
		private List<Player> GetClockwisePlayers()
		{
			return null;
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F8")]
		[Address(RVA = "0x755140", Offset = "0x754340", VA = "0x180755140")]
		[ObserversRpc(RunLocally = true)]
		private void StartGame()
		{
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F9")]
		[Address(RVA = "0x752140", Offset = "0x751340", VA = "0x180752140")]
		[ObserversRpc(RunLocally = true)]
		private void NotifyPlayerScore(NetworkObject player, int score, bool blackjack)
		{
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030FA")]
		[Address(RVA = "0x751B90", Offset = "0x750D90", VA = "0x180751B90")]
		private Transform[] GetPlayerCardPositions(int playerIndex)
		{
			return null;
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030FB")]
		[Address(RVA = "0x755000", Offset = "0x754200", VA = "0x180755000")]
		[ObserversRpc(RunLocally = true)]
		private void SetRoundEnded(bool ended)
		{
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030FC")]
		[Address(RVA = "0x750920", Offset = "0x74FB20", VA = "0x180750920")]
		private void AddCardToPlayerHand(int playerIndex, PlayingCard card)
		{
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030FD")]
		[Address(RVA = "0x750A90", Offset = "0x74FC90", VA = "0x180750A90")]
		[ObserversRpc(RunLocally = true)]
		private void AddCardToPlayerHand(int playerindex, string cardID)
		{
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030FE")]
		[Address(RVA = "0x7507E0", Offset = "0x74F9E0", VA = "0x1807507E0")]
		[ObserversRpc(RunLocally = true)]
		private void AddCardToDealerHand(string cardID)
		{
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60030FF")]
		[Address(RVA = "0x751BD0", Offset = "0x750DD0", VA = "0x180751BD0")]
		private List<PlayingCard> GetPlayerCards(int playerIndex)
		{
			return null;
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x6003100")]
		[Address(RVA = "0x7518E0", Offset = "0x750AE0", VA = "0x1807518E0")]
		private int GetHandScore(List<PlayingCard> cards, bool countFaceDown = true)
		{
			return 0;
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x6003101")]
		[Address(RVA = "0x751660", Offset = "0x750860", VA = "0x180751660")]
		private int GetCardValue(PlayingCard card, bool aceAsEleven = true)
		{
			return 0;
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003102")]
		[Address(RVA = "0x7512E0", Offset = "0x7504E0", VA = "0x1807512E0")]
		private PlayingCard DrawCard()
		{
			return null;
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003103")]
		[Address(RVA = "0x752A80", Offset = "0x751C80", VA = "0x180752A80")]
		private void ResetCards()
		{
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003104")]
		[Address(RVA = "0x751480", Offset = "0x750680", VA = "0x180751480")]
		[ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003105")]
		[Address(RVA = "0x7524C0", Offset = "0x7516C0", VA = "0x1807524C0")]
		public void RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType payout, float cameraDelay = 0f)
		{
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x6003106")]
		[Address(RVA = "0x751B60", Offset = "0x750D60", VA = "0x180751B60")]
		public float GetPayout(float bet, BlackjackGameController.EPayoutType payout)
		{
			return 0f;
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x6003107")]
		[Address(RVA = "0x751D70", Offset = "0x750F70", VA = "0x180751D70")]
		private bool IsCurrentRoundEmpty()
		{
			return default(bool);
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003108")]
		[Address(RVA = "0x750C00", Offset = "0x74FE00", VA = "0x180750C00")]
		[ObserversRpc(RunLocally = true)]
		private void AddPlayerToCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003109")]
		[Address(RVA = "0x752950", Offset = "0x751B50", VA = "0x180752950")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310A")]
		[Address(RVA = "0x752810", Offset = "0x751A10", VA = "0x180752810")]
		[ObserversRpc(RunLocally = true)]
		private void RemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310B")]
		[Address(RVA = "0x754FC0", Offset = "0x7541C0", VA = "0x180754FC0")]
		public void SetLocalPlayerBet(float bet)
		{
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x0000F318 File Offset: 0x0000D518
		[Token(Token = "0x600310C")]
		[Address(RVA = "0x750D40", Offset = "0x74FF40", VA = "0x180750D40")]
		public bool AreAllPlayersReady()
		{
			return default(bool);
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x0000F330 File Offset: 0x0000D530
		[Token(Token = "0x600310D")]
		[Address(RVA = "0x751C10", Offset = "0x750E10", VA = "0x180751C10")]
		public int GetPlayersReadyCount()
		{
			return 0;
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310E")]
		[Address(RVA = "0x755260", Offset = "0x754460", VA = "0x180755260")]
		public void ToggleLocalPlayerReady()
		{
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310F")]
		[Address(RVA = "0x7554D0", Offset = "0x7546D0", VA = "0x1807554D0")]
		[ObserversRpc(RunLocally = true)]
		private void TryStartGame()
		{
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003110")]
		[Address(RVA = "0x7555F0", Offset = "0x7547F0", VA = "0x1807555F0")]
		public BlackjackGameController()
		{
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003111")]
		[Address(RVA = "0x751E30", Offset = "0x751030", VA = "0x180751E30", Slot = "24")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003112")]
		[Address(RVA = "0x751E00", Offset = "0x751000", VA = "0x180751E00", Slot = "25")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003113")]
		[Address(RVA = "0x751DC0", Offset = "0x750FC0", VA = "0x180751DC0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003114")]
		[Address(RVA = "0x754C60", Offset = "0x753E60", VA = "0x180754C60")]
		private void RpcWriter___Observers_StartGame_2166136261()
		{
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003115")]
		[Address(RVA = "0x7535F0", Offset = "0x7527F0", VA = "0x1807535F0")]
		private void RpcLogic___StartGame_2166136261()
		{
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003116")]
		[Address(RVA = "0x754240", Offset = "0x753440", VA = "0x180754240")]
		private void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003117")]
		[Address(RVA = "0x754860", Offset = "0x753A60", VA = "0x180754860")]
		private void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003118")]
		[Address(RVA = "0x7533C0", Offset = "0x7525C0", VA = "0x1807533C0")]
		private void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003119")]
		[Address(RVA = "0x754090", Offset = "0x753290", VA = "0x180754090")]
		private void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600311A")]
		[Address(RVA = "0x754B20", Offset = "0x753D20", VA = "0x180754B20")]
		private void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
		{
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600311B")]
		[Address(RVA = "0x7535E0", Offset = "0x7527E0", VA = "0x1807535E0")]
		private void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600311C")]
		[Address(RVA = "0x7541D0", Offset = "0x7533D0", VA = "0x1807541D0")]
		private void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600311D")]
		[Address(RVA = "0x754480", Offset = "0x753680", VA = "0x180754480")]
		private void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600311E")]
		[Address(RVA = "0x753010", Offset = "0x752210", VA = "0x180753010")]
		private void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600311F")]
		[Address(RVA = "0x753F30", Offset = "0x753130", VA = "0x180753F30")]
		private void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003120")]
		[Address(RVA = "0x754340", Offset = "0x753540", VA = "0x180754340")]
		private void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
		{
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003121")]
		[Address(RVA = "0x752EA0", Offset = "0x7520A0", VA = "0x180752EA0")]
		private void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003122")]
		[Address(RVA = "0x753ED0", Offset = "0x7530D0", VA = "0x180753ED0")]
		private void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003123")]
		[Address(RVA = "0x754740", Offset = "0x753940", VA = "0x180754740")]
		private void RpcWriter___Observers_EndGame_2166136261()
		{
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003124")]
		[Address(RVA = "0x753380", Offset = "0x752580", VA = "0x180753380")]
		private void RpcLogic___EndGame_2166136261()
		{
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x754030", Offset = "0x753230", VA = "0x180754030")]
		private void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x754600", Offset = "0x753800", VA = "0x180754600")]
		private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x753230", Offset = "0x752430", VA = "0x180753230")]
		private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x753FC0", Offset = "0x7531C0", VA = "0x180753FC0")]
		private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003129")]
		[Address(RVA = "0x754E90", Offset = "0x754090", VA = "0x180754E90")]
		private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x752810", Offset = "0x751A10", VA = "0x180752810")]
		private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312B")]
		[Address(RVA = "0x7542C0", Offset = "0x7534C0", VA = "0x1807542C0")]
		private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312C")]
		[Address(RVA = "0x7549E0", Offset = "0x753BE0", VA = "0x1807549E0")]
		private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312D")]
		[Address(RVA = "0x753490", Offset = "0x752690", VA = "0x180753490")]
		private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312E")]
		[Address(RVA = "0x754160", Offset = "0x753360", VA = "0x180754160")]
		private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312F")]
		[Address(RVA = "0x754D70", Offset = "0x753F70", VA = "0x180754D70")]
		private void RpcWriter___Observers_TryStartGame_2166136261()
		{
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003130")]
		[Address(RVA = "0x753A40", Offset = "0x752C40", VA = "0x180753A40")]
		private void RpcLogic___TryStartGame_2166136261()
		{
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003131")]
		[Address(RVA = "0x754280", Offset = "0x753480", VA = "0x180754280")]
		private void RpcReader___Observers_TryStartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003132")]
		[Address(RVA = "0x750ED0", Offset = "0x7500D0", VA = "0x180750ED0", Slot = "27")]
		protected virtual void Awake_UserLogic_ScheduleOne.Casino.BlackjackGameController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002418 RID: 9240
		[Token(Token = "0x4002418")]
		public const int BET_MINIMUM = 10;

		// Token: 0x04002419 RID: 9241
		[Token(Token = "0x4002419")]
		public const int BET_MAXIMUM = 1000;

		// Token: 0x0400241A RID: 9242
		[Token(Token = "0x400241A")]
		public const float PAYOUT_RATIO = 1f;

		// Token: 0x0400241B RID: 9243
		[Token(Token = "0x400241B")]
		public const float BLACKJACK_PAYOUT_RATIO = 1.5f;

		// Token: 0x04002423 RID: 9251
		[Token(Token = "0x4002423")]
		[FieldOffset(Offset = "0x168")]
		[Header("References")]
		public PlayingCard[] Cards;

		// Token: 0x04002424 RID: 9252
		[Token(Token = "0x4002424")]
		[FieldOffset(Offset = "0x170")]
		public Transform[] DefaultCardPositions;

		// Token: 0x04002425 RID: 9253
		[Token(Token = "0x4002425")]
		[FieldOffset(Offset = "0x178")]
		public Transform[] FocusedCameraTransforms;

		// Token: 0x04002426 RID: 9254
		[Token(Token = "0x4002426")]
		[FieldOffset(Offset = "0x180")]
		public Transform[] FinalCameraTransforms;

		// Token: 0x04002427 RID: 9255
		[Token(Token = "0x4002427")]
		[FieldOffset(Offset = "0x188")]
		public Transform[] Player1CardPositions;

		// Token: 0x04002428 RID: 9256
		[Token(Token = "0x4002428")]
		[FieldOffset(Offset = "0x190")]
		public Transform[] Player2CardPositions;

		// Token: 0x04002429 RID: 9257
		[Token(Token = "0x4002429")]
		[FieldOffset(Offset = "0x198")]
		public Transform[] Player3CardPositions;

		// Token: 0x0400242A RID: 9258
		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x1A0")]
		public Transform[] Player4CardPositions;

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x1A8")]
		public Transform[] DealerCardPositions;

		// Token: 0x0400242C RID: 9260
		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x1B0")]
		private List<Player> playersInCurrentRound;

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x1B8")]
		private List<PlayingCard> playStack;

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x1C0")]
		private List<PlayingCard> player1Hand;

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x1C8")]
		private List<PlayingCard> player2Hand;

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x1D0")]
		private List<PlayingCard> player3Hand;

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x1D8")]
		private List<PlayingCard> player4Hand;

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x1E0")]
		private List<PlayingCard> dealerHand;

		// Token: 0x04002433 RID: 9267
		[Token(Token = "0x4002433")]
		[FieldOffset(Offset = "0x1E8")]
		private List<PlayingCard.CardData> cardValuesInDeck;

		// Token: 0x04002434 RID: 9268
		[Token(Token = "0x4002434")]
		[FieldOffset(Offset = "0x1F0")]
		private List<PlayingCard.CardData> drawnCardsValues;

		// Token: 0x04002435 RID: 9269
		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0x1F8")]
		protected Transform localFocusCameraTransform;

		// Token: 0x04002436 RID: 9270
		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0x200")]
		protected Transform localFinalCameraTransform;

		// Token: 0x04002437 RID: 9271
		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0x208")]
		public Action onLocalPlayerBetChange;

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0x210")]
		public Action onLocalPlayerExitRound;

		// Token: 0x04002439 RID: 9273
		[Token(Token = "0x4002439")]
		[FieldOffset(Offset = "0x218")]
		public Action onInitialCardsDealt;

		// Token: 0x0400243A RID: 9274
		[Token(Token = "0x400243A")]
		[FieldOffset(Offset = "0x220")]
		public Action onLocalPlayerReadyForInput;

		// Token: 0x0400243B RID: 9275
		[Token(Token = "0x400243B")]
		[FieldOffset(Offset = "0x228")]
		public Action onLocalPlayerBust;

		// Token: 0x0400243C RID: 9276
		[Token(Token = "0x400243C")]
		[FieldOffset(Offset = "0x230")]
		public Action<BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted;

		// Token: 0x0400243D RID: 9277
		[Token(Token = "0x400243D")]
		[FieldOffset(Offset = "0x238")]
		private bool roundEnded;

		// Token: 0x0400243E RID: 9278
		[Token(Token = "0x400243E")]
		[FieldOffset(Offset = "0x240")]
		private Coroutine gameRoutine;

		// Token: 0x0400243F RID: 9279
		[Token(Token = "0x400243F")]
		[FieldOffset(Offset = "0x248")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002440 RID: 9280
		[Token(Token = "0x4002440")]
		[FieldOffset(Offset = "0x249")]
		private bool NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x02000756 RID: 1878
		[Token(Token = "0x2000756")]
		public enum EStage
		{
			// Token: 0x04002442 RID: 9282
			[Token(Token = "0x4002442")]
			WaitingForPlayers,
			// Token: 0x04002443 RID: 9283
			[Token(Token = "0x4002443")]
			Dealing,
			// Token: 0x04002444 RID: 9284
			[Token(Token = "0x4002444")]
			PlayerTurn,
			// Token: 0x04002445 RID: 9285
			[Token(Token = "0x4002445")]
			DealerTurn,
			// Token: 0x04002446 RID: 9286
			[Token(Token = "0x4002446")]
			Ending
		}

		// Token: 0x02000757 RID: 1879
		[Token(Token = "0x2000757")]
		public enum EPayoutType
		{
			// Token: 0x04002448 RID: 9288
			[Token(Token = "0x4002448")]
			None,
			// Token: 0x04002449 RID: 9289
			[Token(Token = "0x4002449")]
			Blackjack,
			// Token: 0x0400244A RID: 9290
			[Token(Token = "0x400244A")]
			Win,
			// Token: 0x0400244B RID: 9291
			[Token(Token = "0x400244B")]
			Push
		}
	}
}
