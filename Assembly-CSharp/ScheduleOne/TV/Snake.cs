using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002EE RID: 750
	[Token(Token = "0x20002EE")]
	public class Snake : TVApp
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00008190 File Offset: 0x00006390
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039F")]
		public Vector2 HeadPosition
		{
			[Token(Token = "0x6001164")]
			[Address(RVA = "0x6A03B0", Offset = "0x69F5B0", VA = "0x1806A03B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6001165")]
			[Address(RVA = "0xB27600", Offset = "0xB26800", VA = "0x180B27600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A0")]
		public List<Vector2> Tail
		{
			[Token(Token = "0x6001166")]
			[Address(RVA = "0x9B5D90", Offset = "0x9B4F90", VA = "0x1809B5D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001167")]
			[Address(RVA = "0x9DF130", Offset = "0x9DE330", VA = "0x1809DF130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x000081A8 File Offset: 0x000063A8
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A1")]
		public Vector2 LastTailPosition
		{
			[Token(Token = "0x6001168")]
			[Address(RVA = "0xB27590", Offset = "0xB26790", VA = "0x180B27590")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6001169")]
			[Address(RVA = "0xB27610", Offset = "0xB26810", VA = "0x180B27610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x000081C0 File Offset: 0x000063C0
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		public Vector2 Direction
		{
			[Token(Token = "0x600116A")]
			[Address(RVA = "0xB27570", Offset = "0xB26770", VA = "0x180B27570")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600116B")]
			[Address(RVA = "0xB275F0", Offset = "0xB267F0", VA = "0x180B275F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x000081D8 File Offset: 0x000063D8
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		public Vector2 QueuedDirection
		{
			[Token(Token = "0x600116C")]
			[Address(RVA = "0xB275D0", Offset = "0xB267D0", VA = "0x180B275D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600116D")]
			[Address(RVA = "0xB27630", Offset = "0xB26830", VA = "0x180B27630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x000081F0 File Offset: 0x000063F0
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A4")]
		public Vector2 NextDirection
		{
			[Token(Token = "0x600116E")]
			[Address(RVA = "0xB275B0", Offset = "0xB267B0", VA = "0x180B275B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600116F")]
			[Address(RVA = "0xB27620", Offset = "0xB26820", VA = "0x180B27620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00008208 File Offset: 0x00006408
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A5")]
		public Snake.EGameState GameState
		{
			[Token(Token = "0x6001170")]
			[Address(RVA = "0x4F0940", Offset = "0x4EFB40", VA = "0x1804F0940")]
			[CompilerGenerated]
			get
			{
				return Snake.EGameState.Ready;
			}
			[Token(Token = "0x6001171")]
			[Address(RVA = "0x4F0AF0", Offset = "0x4EFCF0", VA = "0x1804F0AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001172")]
		[Address(RVA = "0xB25D80", Offset = "0xB24F80", VA = "0x180B25D80", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001173")]
		[Address(RVA = "0xB27220", Offset = "0xB26420", VA = "0x180B27220")]
		private void Update()
		{
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001174")]
		[Address(RVA = "0xB26D20", Offset = "0xB25F20", VA = "0x180B26D20")]
		private void UpdateInput()
		{
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001175")]
		[Address(RVA = "0xB271C0", Offset = "0xB263C0", VA = "0x180B271C0")]
		private void UpdateMovement()
		{
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001176")]
		[Address(RVA = "0xB26190", Offset = "0xB25390", VA = "0x180B26190")]
		private void MoveSnake()
		{
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001177")]
		[Address(RVA = "0xB26110", Offset = "0xB25310", VA = "0x180B26110")]
		private SnakeTile GetTile(Vector2 position)
		{
			return null;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001178")]
		[Address(RVA = "0xB269C0", Offset = "0xB25BC0", VA = "0x180B269C0")]
		private void StartGame(Vector2 initialDir)
		{
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001179")]
		[Address(RVA = "0xB26010", Offset = "0xB25210", VA = "0x180B26010")]
		private void Eat()
		{
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117A")]
		[Address(RVA = "0xB267E0", Offset = "0xB259E0", VA = "0x180B267E0")]
		private void SpawnFood()
		{
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117B")]
		[Address(RVA = "0xB260E0", Offset = "0xB252E0", VA = "0x180B260E0")]
		private void GameOver()
		{
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117C")]
		[Address(RVA = "0xB27340", Offset = "0xB26540", VA = "0x180B27340")]
		private void Win()
		{
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117D")]
		[Address(RVA = "0xB26CE0", Offset = "0xB25EE0", VA = "0x180B26CE0", Slot = "9")]
		protected override void TryPause()
		{
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117E")]
		[Address(RVA = "0xB25D90", Offset = "0xB24F90", VA = "0x180B25D90")]
		[Button]
		public void CreateTiles()
		{
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600117F")]
		[Address(RVA = "0xB27370", Offset = "0xB26570", VA = "0x180B27370")]
		public Snake()
		{
		}

		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		public const int SIZE_X = 20;

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		public const int SIZE_Y = 12;

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		public SnakeTile TilePrefab;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x70")]
		public float TimePerTile;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x78")]
		[Header("References")]
		public RectTransform PlaySpace;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x80")]
		public SnakeTile[] Tiles;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI ScoreText;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0xC0")]
		private Vector2 lastFoodPosition;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0xCC")]
		private float _timeSinceLastMove;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0xD0")]
		private float _timeOnGameOver;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent onStart;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent onEat;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0xE8")]
		public UnityEvent onGameOver;

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0xF0")]
		public UnityEvent onWin;

		// Token: 0x020002EF RID: 751
		[Token(Token = "0x20002EF")]
		public enum EGameState
		{
			// Token: 0x0400102B RID: 4139
			[Token(Token = "0x400102B")]
			Ready,
			// Token: 0x0400102C RID: 4140
			[Token(Token = "0x400102C")]
			Playing
		}
	}
}
