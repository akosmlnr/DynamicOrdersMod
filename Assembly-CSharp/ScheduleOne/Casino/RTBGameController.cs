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
	// Token: 0x0200076D RID: 1901
	[Token(Token = "0x200076D")]
	public class RTBGameController : CasinoGameController
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000816")]
		public RTBGameController.EStage CurrentStage
		{
			[Token(Token = "0x60031E1")]
			[Address(RVA = "0x77AE00", Offset = "0x77A000", VA = "0x18077AE00")]
			[CompilerGenerated]
			get
			{
				return RTBGameController.EStage.WaitingForPlayers;
			}
			[Token(Token = "0x60031E2")]
			[Address(RVA = "0x77AF00", Offset = "0x77A100", VA = "0x18077AF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000817")]
		public bool IsQuestionActive
		{
			[Token(Token = "0x60031E3")]
			[Address(RVA = "0x77AEA0", Offset = "0x77A0A0", VA = "0x18077AEA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031E4")]
			[Address(RVA = "0x77AF10", Offset = "0x77A110", VA = "0x18077AF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060031E5 RID: 12773 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		// (set) Token: 0x060031E6 RID: 12774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000818")]
		public float LocalPlayerBet
		{
			[Token(Token = "0x60031E5")]
			[Address(RVA = "0x77AEC0", Offset = "0x77A0C0", VA = "0x18077AEC0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60031E6")]
			[Address(RVA = "0x77AF20", Offset = "0x77A120", VA = "0x18077AF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x0000F510 File Offset: 0x0000D710
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000819")]
		public float LocalPlayerBetMultiplier
		{
			[Token(Token = "0x60031E7")]
			[Address(RVA = "0x77AEB0", Offset = "0x77A0B0", VA = "0x18077AEB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60031E8")]
			[Address(RVA = "0x779340", Offset = "0x778540", VA = "0x180779340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x1700081A")]
		public float MultipliedLocalPlayerBet
		{
			[Token(Token = "0x60031E9")]
			[Address(RVA = "0x77AED0", Offset = "0x77A0D0", VA = "0x18077AED0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x0000F540 File Offset: 0x0000D740
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081B")]
		public float RemainingAnswerTime
		{
			[Token(Token = "0x60031EA")]
			[Address(RVA = "0x77AEF0", Offset = "0x77A0F0", VA = "0x18077AEF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60031EB")]
			[Address(RVA = "0x77AF30", Offset = "0x77A130", VA = "0x18077AF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x0000F558 File Offset: 0x0000D758
		[Token(Token = "0x1700081C")]
		public bool IsLocalPlayerInCurrentRound
		{
			[Token(Token = "0x60031EC")]
			[Address(RVA = "0x77AE10", Offset = "0x77A010", VA = "0x18077AE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031ED")]
		[Address(RVA = "0x777230", Offset = "0x776430", VA = "0x180777230", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031EE")]
		[Address(RVA = "0x778290", Offset = "0x777490", VA = "0x180778290", Slot = "22")]
		protected override void Open()
		{
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x777280", Offset = "0x776480", VA = "0x180777280", Slot = "23")]
		protected override void Close()
		{
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F0")]
		[Address(RVA = "0x777480", Offset = "0x776680", VA = "0x180777480", Slot = "21")]
		protected override void Exit(ExitAction action)
		{
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F1")]
		[Address(RVA = "0x77A8E0", Offset = "0x779AE0", VA = "0x18077A8E0")]
		[ObserversRpc(RunLocally = true)]
		private void SetStage(RTBGameController.EStage stage)
		{
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F2")]
		[Address(RVA = "0x77A5B0", Offset = "0x7797B0", VA = "0x18077A5B0")]
		private void RunRound(RTBGameController.EStage stage)
		{
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F3")]
		[Address(RVA = "0x77A6E0", Offset = "0x7798E0", VA = "0x18077A6E0")]
		[ObserversRpc(RunLocally = true)]
		private void SetBetMultiplier(float multiplier)
		{
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F4")]
		[Address(RVA = "0x777330", Offset = "0x776530", VA = "0x180777330")]
		[ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F5")]
		[Address(RVA = "0x778560", Offset = "0x777760", VA = "0x180778560")]
		public void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)
		{
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0000F570 File Offset: 0x0000D770
		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x777E20", Offset = "0x777020", VA = "0x180777E20")]
		private bool IsCurrentRoundEmpty()
		{
			return default(bool);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0000F588 File Offset: 0x0000D788
		[Token(Token = "0x60031F7")]
		[Address(RVA = "0x777500", Offset = "0x776700", VA = "0x180777500")]
		private float GetAnswerIndex(RTBGameController.EStage stage, PlayingCard.CardData card)
		{
			return 0f;
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x778150", Offset = "0x777350", VA = "0x180778150")]
		[ObserversRpc(RunLocally = true)]
		private void NotifyAnswer(float answerIndex)
		{
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x778440", Offset = "0x777640", VA = "0x180778440")]
		[ObserversRpc(RunLocally = true)]
		private void QuestionDone()
		{
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x777AF0", Offset = "0x776CF0", VA = "0x180777AF0")]
		private void GetQuestionsAndAnswers(RTBGameController.EStage stage, out string question, out string[] answers)
		{
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x778AE0", Offset = "0x777CE0", VA = "0x180778AE0")]
		private void ResetCards()
		{
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x777060", Offset = "0x776260", VA = "0x180777060")]
		[ObserversRpc(RunLocally = true)]
		private void AddPlayerToCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x7789B0", Offset = "0x777BB0", VA = "0x1807789B0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x778870", Offset = "0x777A70", VA = "0x180778870")]
		[ObserversRpc(RunLocally = true)]
		private void RemovePlayerFromCurrentRound(NetworkObject player)
		{
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x778320", Offset = "0x777520", VA = "0x180778320")]
		private PlayingCard.CardData PullCardFromDeck()
		{
			return default(PlayingCard.CardData);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003200")]
		[Address(RVA = "0x77A8A0", Offset = "0x779AA0", VA = "0x18077A8A0")]
		public void SetLocalPlayerBet(float bet)
		{
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x6003201")]
		[Address(RVA = "0x7771A0", Offset = "0x7763A0", VA = "0x1807771A0")]
		public bool AreAllPlayersReady()
		{
			return default(bool);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x6003202")]
		[Address(RVA = "0x7779D0", Offset = "0x776BD0", VA = "0x1807779D0")]
		public int GetPlayersReadyCount()
		{
			return 0;
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003203")]
		[Address(RVA = "0x77A820", Offset = "0x779A20", VA = "0x18077A820")]
		public void SetLocalPlayerAnswer(float answer)
		{
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[Token(Token = "0x6003204")]
		[Address(RVA = "0x7777E0", Offset = "0x7769E0", VA = "0x1807777E0")]
		public int GetAnsweredPlayersCount()
		{
			return 0;
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003205")]
		[Address(RVA = "0x77AA10", Offset = "0x779C10", VA = "0x18077AA10")]
		public void ToggleLocalPlayerReady()
		{
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003206")]
		[Address(RVA = "0x77ABC0", Offset = "0x779DC0", VA = "0x18077ABC0")]
		[ObserversRpc(RunLocally = true)]
		private void TryNextStage()
		{
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x0000F600 File Offset: 0x0000D800
		[Token(Token = "0x6003207")]
		[Address(RVA = "0x777960", Offset = "0x776B60", VA = "0x180777960")]
		private int GetCardNumberValue(PlayingCard.CardData card)
		{
			return 0;
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x6003208")]
		[Address(RVA = "0x777980", Offset = "0x776B80", VA = "0x180777980")]
		public static float GetNetBetMultiplier(RTBGameController.EStage stage)
		{
			return 0f;
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003209")]
		[Address(RVA = "0x77ACE0", Offset = "0x779EE0", VA = "0x18077ACE0")]
		public RTBGameController()
		{
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320A")]
		[Address(RVA = "0x777E90", Offset = "0x777090", VA = "0x180777E90", Slot = "24")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320B")]
		[Address(RVA = "0x777E70", Offset = "0x777070", VA = "0x180777E70", Slot = "25")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320C")]
		[Address(RVA = "0x751DC0", Offset = "0x750FC0", VA = "0x180751DC0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320D")]
		[Address(RVA = "0x77A220", Offset = "0x779420", VA = "0x18077A220")]
		private void RpcWriter___Observers_SetStage_2502303021(RTBGameController.EStage stage)
		{
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320E")]
		[Address(RVA = "0x779350", Offset = "0x778550", VA = "0x180779350")]
		private void RpcLogic___SetStage_2502303021(RTBGameController.EStage stage)
		{
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320F")]
		[Address(RVA = "0x7799B0", Offset = "0x778BB0", VA = "0x1807799B0")]
		private void RpcReader___Observers_SetStage_2502303021(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003210")]
		[Address(RVA = "0x77A0D0", Offset = "0x7792D0", VA = "0x18077A0D0")]
		private void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier)
		{
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003211")]
		[Address(RVA = "0x779340", Offset = "0x778540", VA = "0x180779340")]
		private void RpcLogic___SetBetMultiplier_431000436(float multiplier)
		{
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x779950", Offset = "0x778B50", VA = "0x180779950")]
		private void RpcReader___Observers_SetBetMultiplier_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003213")]
		[Address(RVA = "0x779C00", Offset = "0x778E00", VA = "0x180779C00")]
		private void RpcWriter___Observers_EndGame_2166136261()
		{
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003214")]
		[Address(RVA = "0x778F60", Offset = "0x778160", VA = "0x180778F60")]
		private void RpcLogic___EndGame_2166136261()
		{
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003215")]
		[Address(RVA = "0x7797C0", Offset = "0x7789C0", VA = "0x1807797C0")]
		private void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003216")]
		[Address(RVA = "0x779D20", Offset = "0x778F20", VA = "0x180779D20")]
		private void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex)
		{
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003217")]
		[Address(RVA = "0x778FA0", Offset = "0x7781A0", VA = "0x180778FA0")]
		private void RpcLogic___NotifyAnswer_431000436(float answerIndex)
		{
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003218")]
		[Address(RVA = "0x779830", Offset = "0x778A30", VA = "0x180779830")]
		private void RpcReader___Observers_NotifyAnswer_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x779E70", Offset = "0x779070", VA = "0x180779E70")]
		private void RpcWriter___Observers_QuestionDone_2166136261()
		{
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321A")]
		[Address(RVA = "0x779170", Offset = "0x778370", VA = "0x180779170")]
		private void RpcLogic___QuestionDone_2166136261()
		{
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321B")]
		[Address(RVA = "0x7798A0", Offset = "0x778AA0", VA = "0x1807798A0")]
		private void RpcReader___Observers_QuestionDone_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321C")]
		[Address(RVA = "0x779AC0", Offset = "0x778CC0", VA = "0x180779AC0")]
		private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321D")]
		[Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20")]
		private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321E")]
		[Address(RVA = "0x779750", Offset = "0x778950", VA = "0x180779750")]
		private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321F")]
		[Address(RVA = "0x77A480", Offset = "0x779680", VA = "0x18077A480")]
		private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003220")]
		[Address(RVA = "0x778870", Offset = "0x777A70", VA = "0x180778870")]
		private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003221")]
		[Address(RVA = "0x779A40", Offset = "0x778C40", VA = "0x180779A40")]
		private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003222")]
		[Address(RVA = "0x779F90", Offset = "0x779190", VA = "0x180779F90")]
		private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003223")]
		[Address(RVA = "0x779240", Offset = "0x778440", VA = "0x180779240")]
		private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003224")]
		[Address(RVA = "0x7798E0", Offset = "0x778AE0", VA = "0x1807798E0")]
		private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003225")]
		[Address(RVA = "0x77A360", Offset = "0x779560", VA = "0x18077A360")]
		private void RpcWriter___Observers_TryNextStage_2166136261()
		{
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003226")]
		[Address(RVA = "0x779520", Offset = "0x778720", VA = "0x180779520")]
		private void RpcLogic___TryNextStage_2166136261()
		{
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003227")]
		[Address(RVA = "0x779A00", Offset = "0x778C00", VA = "0x180779A00")]
		private void RpcReader___Observers_TryNextStage_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003228")]
		[Address(RVA = "0x777210", Offset = "0x776410", VA = "0x180777210", Slot = "27")]
		protected virtual void Awake_UserLogic_ScheduleOne.Casino.RTBGameController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040024B4 RID: 9396
		[Token(Token = "0x40024B4")]
		public const int BET_MINIMUM = 10;

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		public const int BET_MAXIMUM = 500;

		// Token: 0x040024B6 RID: 9398
		[Token(Token = "0x40024B6")]
		public const float ANSWER_MAX_TIME = 6f;

		// Token: 0x040024B7 RID: 9399
		[Token(Token = "0x40024B7")]
		[FieldOffset(Offset = "0x148")]
		[Header("References")]
		public Transform PlayCameraTransform;

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x150")]
		public Transform FocusedCameraTransform;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x158")]
		public PlayingCard[] Cards;

		// Token: 0x040024BA RID: 9402
		[Token(Token = "0x40024BA")]
		[FieldOffset(Offset = "0x160")]
		public Transform[] CardDefaultPositions;

		// Token: 0x040024BB RID: 9403
		[Token(Token = "0x40024BB")]
		[FieldOffset(Offset = "0x168")]
		public Transform ActiveCardPosition;

		// Token: 0x040024BC RID: 9404
		[Token(Token = "0x40024BC")]
		[FieldOffset(Offset = "0x170")]
		public Transform[] DockedCardPositions;

		// Token: 0x040024BE RID: 9406
		[Token(Token = "0x40024BE")]
		[FieldOffset(Offset = "0x180")]
		public Action<RTBGameController.EStage> onStageChange;

		// Token: 0x040024BF RID: 9407
		[Token(Token = "0x40024BF")]
		[FieldOffset(Offset = "0x188")]
		public Action<string, string[]> onQuestionReady;

		// Token: 0x040024C0 RID: 9408
		[Token(Token = "0x40024C0")]
		[FieldOffset(Offset = "0x190")]
		public Action onQuestionDone;

		// Token: 0x040024C1 RID: 9409
		[Token(Token = "0x40024C1")]
		[FieldOffset(Offset = "0x198")]
		public Action onLocalPlayerCorrect;

		// Token: 0x040024C2 RID: 9410
		[Token(Token = "0x40024C2")]
		[FieldOffset(Offset = "0x1A0")]
		public Action onLocalPlayerIncorrect;

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x1A8")]
		public Action onLocalPlayerBetChange;

		// Token: 0x040024C4 RID: 9412
		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0x1B0")]
		public Action onLocalPlayerExitRound;

		// Token: 0x040024C9 RID: 9417
		[Token(Token = "0x40024C9")]
		[FieldOffset(Offset = "0x1C8")]
		private List<Player> playersInCurrentRound;

		// Token: 0x040024CA RID: 9418
		[Token(Token = "0x40024CA")]
		[FieldOffset(Offset = "0x1D0")]
		private List<PlayingCard.CardData> cardsInDeck;

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x1D8")]
		private List<PlayingCard.CardData> drawnCards;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x1E0")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x040024CD RID: 9421
		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x1E1")]
		private bool NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x0200076E RID: 1902
		[Token(Token = "0x200076E")]
		public enum EStage
		{
			// Token: 0x040024CF RID: 9423
			[Token(Token = "0x40024CF")]
			WaitingForPlayers,
			// Token: 0x040024D0 RID: 9424
			[Token(Token = "0x40024D0")]
			RedOrBlack,
			// Token: 0x040024D1 RID: 9425
			[Token(Token = "0x40024D1")]
			HigherOrLower,
			// Token: 0x040024D2 RID: 9426
			[Token(Token = "0x40024D2")]
			InsideOrOutside,
			// Token: 0x040024D3 RID: 9427
			[Token(Token = "0x40024D3")]
			Suit
		}
	}
}
