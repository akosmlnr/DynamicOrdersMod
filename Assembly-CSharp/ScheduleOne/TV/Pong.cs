using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x20002E6")]
	public class Pong : TVApp
	{
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00008118 File Offset: 0x00006318
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039A")]
		public Pong.EGameMode GameMode
		{
			[Token(Token = "0x6001137")]
			[Address(RVA = "0x54A4F0", Offset = "0x5496F0", VA = "0x18054A4F0")]
			[CompilerGenerated]
			get
			{
				return Pong.EGameMode.SinglePlayer;
			}
			[Token(Token = "0x6001138")]
			[Address(RVA = "0x54A5C0", Offset = "0x5497C0", VA = "0x18054A5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00008130 File Offset: 0x00006330
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039B")]
		public Pong.EState State
		{
			[Token(Token = "0x6001139")]
			[Address(RVA = "0xB1F7A0", Offset = "0xB1E9A0", VA = "0x180B1F7A0")]
			[CompilerGenerated]
			get
			{
				return Pong.EState.Ready;
			}
			[Token(Token = "0x600113A")]
			[Address(RVA = "0xB1F7D0", Offset = "0xB1E9D0", VA = "0x180B1F7D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x00008148 File Offset: 0x00006348
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039C")]
		public int LeftScore
		{
			[Token(Token = "0x600113B")]
			[Address(RVA = "0x4FF8E0", Offset = "0x4FEAE0", VA = "0x1804FF8E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600113C")]
			[Address(RVA = "0xB1F7B0", Offset = "0xB1E9B0", VA = "0x180B1F7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x00008160 File Offset: 0x00006360
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039D")]
		public int RightScore
		{
			[Token(Token = "0x600113D")]
			[Address(RVA = "0xB1F790", Offset = "0xB1E990", VA = "0x180B1F790")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600113E")]
			[Address(RVA = "0xB1F7C0", Offset = "0xB1E9C0", VA = "0x180B1F7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113F")]
		[Address(RVA = "0xB1F4D0", Offset = "0xB1E6D0", VA = "0x180B1F4D0")]
		private void Update()
		{
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001140")]
		[Address(RVA = "0xB1E5A0", Offset = "0xB1D7A0", VA = "0x180B1E5A0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001141")]
		[Address(RVA = "0xB1EED0", Offset = "0xB1E0D0", VA = "0x180B1EED0", Slot = "9")]
		protected override void TryPause()
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001142")]
		[Address(RVA = "0xB1F0F0", Offset = "0xB1E2F0", VA = "0x180B1F0F0")]
		public void UpdateInputs()
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001143")]
		[Address(RVA = "0xB1EF40", Offset = "0xB1E140", VA = "0x180B1EF40")]
		private void UpdateAI()
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001144")]
		[Address(RVA = "0xB1E850", Offset = "0xB1DA50", VA = "0x180B1E850")]
		public void GoalHit(Pong.ESide side)
		{
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001145")]
		[Address(RVA = "0xB1F510", Offset = "0xB1E710", VA = "0x180B1F510")]
		private void Win(Pong.ESide winner)
		{
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001146")]
		[Address(RVA = "0xB1EA00", Offset = "0xB1DC00", VA = "0x180B1EA00")]
		private void ResetBall()
		{
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001147")]
		[Address(RVA = "0xB1ED80", Offset = "0xB1DF80", VA = "0x180B1ED80")]
		private void ServeBall()
		{
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001148")]
		[Address(RVA = "0xB1EC00", Offset = "0xB1DE00", VA = "0x180B1EC00")]
		private void ResetGame()
		{
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001149")]
		[Address(RVA = "0xB1EEA0", Offset = "0xB1E0A0", VA = "0x180B1EEA0")]
		public void SetPaddleTargetY(Pong.ESide player, float y)
		{
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114A")]
		[Address(RVA = "0xB1ED10", Offset = "0xB1DF10", VA = "0x180B1ED10", Slot = "7")]
		public override void Resume()
		{
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114B")]
		[Address(RVA = "0xB1F6E0", Offset = "0xB1E8E0", VA = "0x180B1F6E0")]
		public Pong()
		{
		}

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform Rect;

		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x80")]
		public PongPaddle LeftPaddle;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x88")]
		public PongPaddle RightPaddle;

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x90")]
		public PongBall Ball;

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI LeftScoreLabel;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI RightScoreLabel;

		// Token: 0x04000FCF RID: 4047
		[Token(Token = "0x4000FCF")]
		[FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI WinnerLabel;

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0xB0")]
		[Header("Settings")]
		public float InitialVelocity;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0xB4")]
		public float VelocityGainPerSecond;

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0xB8")]
		public float MaxVelocity;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0xBC")]
		public int GoalsToWin;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0xC0")]
		[Header("AI")]
		public float ReactionTime;

		// Token: 0x04000FD5 RID: 4053
		[Token(Token = "0x4000FD5")]
		[FieldOffset(Offset = "0xC4")]
		public float TargetRandomization;

		// Token: 0x04000FD6 RID: 4054
		[Token(Token = "0x4000FD6")]
		[FieldOffset(Offset = "0xC8")]
		public float SpeedMultiplier;

		// Token: 0x04000FD7 RID: 4055
		[Token(Token = "0x4000FD7")]
		[FieldOffset(Offset = "0xD0")]
		public UnityEvent onServe;

		// Token: 0x04000FD8 RID: 4056
		[Token(Token = "0x4000FD8")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent onLeftScore;

		// Token: 0x04000FD9 RID: 4057
		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent onRightScore;

		// Token: 0x04000FDA RID: 4058
		[Token(Token = "0x4000FDA")]
		[FieldOffset(Offset = "0xE8")]
		public UnityEvent onGameOver;

		// Token: 0x04000FDB RID: 4059
		[Token(Token = "0x4000FDB")]
		[FieldOffset(Offset = "0xF0")]
		public UnityEvent onLocalPlayerWin;

		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0xF8")]
		public UnityEvent onReset;

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x100")]
		private Pong.ESide nextBallSide;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x104")]
		private Vector3 ballVelocity;

		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x110")]
		private float reactionTimer;

		// Token: 0x020002E7 RID: 743
		[Token(Token = "0x20002E7")]
		public enum EGameMode
		{
			// Token: 0x04000FE1 RID: 4065
			[Token(Token = "0x4000FE1")]
			SinglePlayer,
			// Token: 0x04000FE2 RID: 4066
			[Token(Token = "0x4000FE2")]
			MultiPlayer
		}

		// Token: 0x020002E8 RID: 744
		[Token(Token = "0x20002E8")]
		public enum ESide
		{
			// Token: 0x04000FE4 RID: 4068
			[Token(Token = "0x4000FE4")]
			Left,
			// Token: 0x04000FE5 RID: 4069
			[Token(Token = "0x4000FE5")]
			Right
		}

		// Token: 0x020002E9 RID: 745
		[Token(Token = "0x20002E9")]
		public enum EState
		{
			// Token: 0x04000FE7 RID: 4071
			[Token(Token = "0x4000FE7")]
			Ready,
			// Token: 0x04000FE8 RID: 4072
			[Token(Token = "0x4000FE8")]
			Playing,
			// Token: 0x04000FE9 RID: 4073
			[Token(Token = "0x4000FE9")]
			GameOver
		}
	}
}
