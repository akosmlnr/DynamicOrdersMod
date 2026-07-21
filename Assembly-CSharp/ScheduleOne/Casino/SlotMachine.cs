using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.Interaction;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	public class SlotMachine : NetworkBehaviour
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x0000F678 File Offset: 0x0000D878
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000821")]
		public bool IsSpinning
		{
			[Token(Token = "0x600323A")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600323B")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x0000F690 File Offset: 0x0000D890
		[Token(Token = "0x17000822")]
		private int currentBetAmount
		{
			[Token(Token = "0x600323C")]
			[Address(RVA = "0x781640", Offset = "0x780840", VA = "0x180781640")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600323D")]
		[Address(RVA = "0x77EFC0", Offset = "0x77E1C0", VA = "0x18077EFC0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600323E")]
		[Address(RVA = "0x77FBB0", Offset = "0x77EDB0", VA = "0x18077FBB0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600323F")]
		[Address(RVA = "0x77F230", Offset = "0x77E430", VA = "0x18077F230")]
		private void DownHovered()
		{
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003240")]
		[Address(RVA = "0x77F2B0", Offset = "0x77E4B0", VA = "0x18077F2B0")]
		private void DownInteracted()
		{
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003241")]
		[Address(RVA = "0x7814D0", Offset = "0x7806D0", VA = "0x1807814D0")]
		private void UpHovered()
		{
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003242")]
		[Address(RVA = "0x781550", Offset = "0x780750", VA = "0x180781550")]
		private void UpInteracted()
		{
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003243")]
		[Address(RVA = "0x77F500", Offset = "0x77E700", VA = "0x18077F500")]
		private void HandleHovered()
		{
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003244")]
		[Address(RVA = "0x77F640", Offset = "0x77E840", VA = "0x18077F640")]
		[Button]
		public void HandleInteracted()
		{
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003245")]
		[Address(RVA = "0x780A50", Offset = "0x77FC50", VA = "0x180780A50")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBetIndex(int index)
		{
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003246")]
		[Address(RVA = "0x780CF0", Offset = "0x77FEF0", VA = "0x180780CF0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetBetIndex(NetworkConnection conn, int index)
		{
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003247")]
		[Address(RVA = "0x780B90", Offset = "0x77FD90", VA = "0x180780B90")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendStartSpin(NetworkConnection spinner, int betAmount)
		{
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003248")]
		[Address(RVA = "0x781330", Offset = "0x780530", VA = "0x180781330")]
		[ObserversRpc(RunLocally = true)]
		public void StartSpin(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		[Token(Token = "0x6003249")]
		[Address(RVA = "0x77F2F0", Offset = "0x77E4F0", VA = "0x18077F2F0")]
		private SlotMachine.EOutcome EvaluateOutcome(SlotMachine.ESymbol[] outcome)
		{
			return SlotMachine.EOutcome.Jackpot;
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[Token(Token = "0x600324A")]
		[Address(RVA = "0x77F4D0", Offset = "0x77E6D0", VA = "0x18077F4D0")]
		private int GetWinAmount(SlotMachine.EOutcome outcome, int betAmount)
		{
			return 0;
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324B")]
		[Address(RVA = "0x77F010", Offset = "0x77E210", VA = "0x18077F010")]
		private void DisplayOutcome(SlotMachine.EOutcome outcome, int winAmount)
		{
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[Token(Token = "0x600324C")]
		[Address(RVA = "0x77F3E0", Offset = "0x77E5E0", VA = "0x18077F3E0")]
		public static SlotMachine.ESymbol GetRandomSymbol()
		{
			return SlotMachine.ESymbol.Cherry;
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[Token(Token = "0x600324D")]
		[Address(RVA = "0x77F970", Offset = "0x77EB70", VA = "0x18077F970")]
		private bool IsFruit(SlotMachine.ESymbol symbol)
		{
			return default(bool);
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x600324E")]
		[Address(RVA = "0x77F910", Offset = "0x77EB10", VA = "0x18077F910")]
		private bool IsAllFruit(SlotMachine.ESymbol[] symbols)
		{
			return default(bool);
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x600324F")]
		[Address(RVA = "0x77F980", Offset = "0x77EB80", VA = "0x18077F980")]
		private bool IsUniform(SlotMachine.ESymbol[] symbols)
		{
			return default(bool);
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003250")]
		[Address(RVA = "0x780F70", Offset = "0x780170", VA = "0x180780F70")]
		[Button]
		public void SimulateMany()
		{
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003251")]
		[Address(RVA = "0x781620", Offset = "0x780820", VA = "0x180781620")]
		public SlotMachine()
		{
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003253")]
		[Address(RVA = "0x77FA00", Offset = "0x77EC00", VA = "0x18077FA00", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003254")]
		[Address(RVA = "0x77F9E0", Offset = "0x77EBE0", VA = "0x18077F9E0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003255")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003256")]
		[Address(RVA = "0x780630", Offset = "0x77F830", VA = "0x180780630")]
		private void RpcWriter___Server_SendBetIndex_3316948804(int index)
		{
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003257")]
		[Address(RVA = "0x77FC00", Offset = "0x77EE00", VA = "0x18077FC00")]
		private void RpcLogic___SendBetIndex_3316948804(int index)
		{
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003258")]
		[Address(RVA = "0x7801D0", Offset = "0x77F3D0", VA = "0x1807801D0")]
		private void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003259")]
		[Address(RVA = "0x780360", Offset = "0x77F560", VA = "0x180780360")]
		private void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325A")]
		[Address(RVA = "0x77FE60", Offset = "0x77F060", VA = "0x18077FE60")]
		public void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325B")]
		[Address(RVA = "0x7800B0", Offset = "0x77F2B0", VA = "0x1807800B0")]
		private void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325C")]
		[Address(RVA = "0x7808E0", Offset = "0x77FAE0", VA = "0x1807808E0")]
		private void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325D")]
		[Address(RVA = "0x7802F0", Offset = "0x77F4F0", VA = "0x1807802F0")]
		private void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325E")]
		[Address(RVA = "0x780770", Offset = "0x77F970", VA = "0x180780770")]
		private void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325F")]
		[Address(RVA = "0x77FC10", Offset = "0x77EE10", VA = "0x18077FC10")]
		public void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003260")]
		[Address(RVA = "0x780250", Offset = "0x77F450", VA = "0x180780250")]
		private void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003261")]
		[Address(RVA = "0x7804B0", Offset = "0x77F6B0", VA = "0x1807804B0")]
		private void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003262")]
		[Address(RVA = "0x77FF30", Offset = "0x77F130", VA = "0x18077FF30")]
		public void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, SlotMachine.ESymbol[] symbols, int betAmount)
		{
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003263")]
		[Address(RVA = "0x780120", Offset = "0x77F320", VA = "0x180780120")]
		private void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003264")]
		[Address(RVA = "0x77ED50", Offset = "0x77DF50", VA = "0x18077ED50")]
		private void Awake_UserLogic_ScheduleOne.Casino.SlotMachine_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		[FieldOffset(Offset = "0x0")]
		public static int[] BetAmounts;

		// Token: 0x040024E1 RID: 9441
		[Token(Token = "0x40024E1")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		public InteractableObject DownButton;

		// Token: 0x040024E2 RID: 9442
		[Token(Token = "0x40024E2")]
		[FieldOffset(Offset = "0x128")]
		public InteractableObject UpButton;

		// Token: 0x040024E3 RID: 9443
		[Token(Token = "0x40024E3")]
		[FieldOffset(Offset = "0x130")]
		public InteractableObject HandleIntObj;

		// Token: 0x040024E4 RID: 9444
		[Token(Token = "0x40024E4")]
		[FieldOffset(Offset = "0x138")]
		public TextMeshPro BetAmountLabel;

		// Token: 0x040024E5 RID: 9445
		[Token(Token = "0x40024E5")]
		[FieldOffset(Offset = "0x140")]
		public SlotReel[] Reels;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x148")]
		public AudioSourceController SpinLoop;

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40024E7")]
		[FieldOffset(Offset = "0x150")]
		public Animation ScreenAnimation;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x158")]
		public ParticleSystem[] JackpotParticles;

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40024E9")]
		[FieldOffset(Offset = "0x160")]
		[Header("Win Animations")]
		public TextMeshProUGUI[] WinAmountLabels;

		// Token: 0x040024EA RID: 9450
		[Token(Token = "0x40024EA")]
		[FieldOffset(Offset = "0x168")]
		public AnimationClip MiniWinAnimation;

		// Token: 0x040024EB RID: 9451
		[Token(Token = "0x40024EB")]
		[FieldOffset(Offset = "0x170")]
		public AnimationClip SmallWinAnimation;

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0x178")]
		public AnimationClip BigWinAnimation;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x180")]
		public AnimationClip JackpotAnimation;

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x188")]
		public AudioSourceController MiniWinSound;

		// Token: 0x040024EF RID: 9455
		[Token(Token = "0x40024EF")]
		[FieldOffset(Offset = "0x190")]
		public AudioSourceController SmallWinSound;

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[FieldOffset(Offset = "0x198")]
		public AudioSourceController BigWinSound;

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[FieldOffset(Offset = "0x1A0")]
		public AudioSourceController JackpotSound;

		// Token: 0x040024F2 RID: 9458
		[Token(Token = "0x40024F2")]
		[FieldOffset(Offset = "0x1A8")]
		public UnityEvent onDownPressed;

		// Token: 0x040024F3 RID: 9459
		[Token(Token = "0x40024F3")]
		[FieldOffset(Offset = "0x1B0")]
		public UnityEvent onUpPressed;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[FieldOffset(Offset = "0x1B8")]
		public UnityEvent onHandlePulled;

		// Token: 0x040024F5 RID: 9461
		[Token(Token = "0x40024F5")]
		[FieldOffset(Offset = "0x1C0")]
		private int currentBetIndex;

		// Token: 0x040024F6 RID: 9462
		[Token(Token = "0x40024F6")]
		[FieldOffset(Offset = "0x1C4")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted;

		// Token: 0x040024F7 RID: 9463
		[Token(Token = "0x40024F7")]
		[FieldOffset(Offset = "0x1C5")]
		private bool NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted;

		// Token: 0x02000774 RID: 1908
		[Token(Token = "0x2000774")]
		public enum ESymbol
		{
			// Token: 0x040024F9 RID: 9465
			[Token(Token = "0x40024F9")]
			Cherry,
			// Token: 0x040024FA RID: 9466
			[Token(Token = "0x40024FA")]
			Lemon,
			// Token: 0x040024FB RID: 9467
			[Token(Token = "0x40024FB")]
			Grape,
			// Token: 0x040024FC RID: 9468
			[Token(Token = "0x40024FC")]
			Watermelon,
			// Token: 0x040024FD RID: 9469
			[Token(Token = "0x40024FD")]
			Bell,
			// Token: 0x040024FE RID: 9470
			[Token(Token = "0x40024FE")]
			Seven
		}

		// Token: 0x02000775 RID: 1909
		[Token(Token = "0x2000775")]
		public enum EOutcome
		{
			// Token: 0x04002500 RID: 9472
			[Token(Token = "0x4002500")]
			Jackpot,
			// Token: 0x04002501 RID: 9473
			[Token(Token = "0x4002501")]
			BigWin,
			// Token: 0x04002502 RID: 9474
			[Token(Token = "0x4002502")]
			SmallWin,
			// Token: 0x04002503 RID: 9475
			[Token(Token = "0x4002503")]
			MiniWin,
			// Token: 0x04002504 RID: 9476
			[Token(Token = "0x4002504")]
			NoWin
		}
	}
}
