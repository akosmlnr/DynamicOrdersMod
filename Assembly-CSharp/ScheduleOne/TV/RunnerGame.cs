using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002EC RID: 748
	[Token(Token = "0x20002EC")]
	public class RunnerGame : TVApp
	{
		// Token: 0x06001155 RID: 4437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001155")]
		[Address(RVA = "0xB1FC70", Offset = "0xB1EE70", VA = "0x180B1FC70", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001156")]
		[Address(RVA = "0xB20170", Offset = "0xB1F370", VA = "0x180B20170", Slot = "5")]
		public override void Open()
		{
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001157")]
		[Address(RVA = "0xB206F0", Offset = "0xB1F8F0", VA = "0x180B206F0", Slot = "9")]
		protected override void TryPause()
		{
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001158")]
		[Address(RVA = "0xB20730", Offset = "0xB1F930", VA = "0x180B20730")]
		public void Update()
		{
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001159")]
		[Address(RVA = "0xB20050", Offset = "0xB1F250", VA = "0x180B20050")]
		private void Jump()
		{
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115A")]
		[Address(RVA = "0xB1FDD0", Offset = "0xB1EFD0", VA = "0x180B1FDD0")]
		private void CloudSpawned(GameObject cloud)
		{
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115B")]
		[Address(RVA = "0xB20090", Offset = "0xB1F290", VA = "0x180B20090")]
		private void ObstacleSpawned(GameObject obstacle)
		{
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115C")]
		[Address(RVA = "0xB201D0", Offset = "0xB1F3D0", VA = "0x180B201D0")]
		private void RefreshHighScore()
		{
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115D")]
		[Address(RVA = "0xB20190", Offset = "0xB1F390", VA = "0x180B20190")]
		public void PlayerCollided()
		{
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115E")]
		[Address(RVA = "0xB1FEB0", Offset = "0xB1F0B0", VA = "0x180B1FEB0")]
		private void EndGame()
		{
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115F")]
		[Address(RVA = "0xB206A0", Offset = "0xB1F8A0", VA = "0x180B206A0")]
		private void StartGame()
		{
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001160")]
		[Address(RVA = "0xB202D0", Offset = "0xB1F4D0", VA = "0x180B202D0")]
		private void ResetGame()
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001161")]
		[Address(RVA = "0xB20FA0", Offset = "0xB201A0", VA = "0x180B20FA0")]
		public RunnerGame()
		{
		}

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x68")]
		public float GameSpeed;

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x6C")]
		public float MinGameSpeed;

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x70")]
		public float MaxGameSpeed;

		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x74")]
		public float SpeedIncreaseRate;

		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x78")]
		public int ScoreRate;

		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x7C")]
		public float Gravity;

		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x80")]
		public float JumpForce;

		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0x84")]
		public float GlobalForceMultiplier;

		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0x88")]
		public float DropForce;

		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform Character;

		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x98")]
		public Flipboard CharacterFlipboard;

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0xA0")]
		public SlidingRect Ground;

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0xA8")]
		public UISpawner CloudSpawner;

		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		[FieldOffset(Offset = "0xB0")]
		public UISpawner ObstacleSpawner;

		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI ScoreLabel;

		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI HighScoreLabel;

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject StartScreen;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject GameOverScreen;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0xD8")]
		public Animation NewHighScoreAnimation;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0xE0")]
		public Sprite JumpSprite;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0xE8")]
		private bool isJumping;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0xE9")]
		private bool isGrounded;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0xEA")]
		private bool isReady;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0xEC")]
		private float score;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0xF0")]
		private float yVelocity;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0xF4")]
		private float defaultCharacterY;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0xF8")]
		private List<UIMover> clouds;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x100")]
		private List<UIMover> obstacles;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x108")]
		public UnityEvent onJump;

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x110")]
		public UnityEvent onHit;

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x118")]
		public UnityEvent onNewHighScore;
	}
}
