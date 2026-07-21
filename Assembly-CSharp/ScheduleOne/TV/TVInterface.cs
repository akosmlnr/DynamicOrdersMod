using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x20002F7")]
	public class TVInterface : MonoBehaviour
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00008280 File Offset: 0x00006480
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AB")]
		public bool IsOpen
		{
			[Token(Token = "0x60011A7")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011A8")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A9")]
		[Address(RVA = "0xB28940", Offset = "0xB27B40", VA = "0x180B28940")]
		public void Awake()
		{
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0xB29120", Offset = "0xB28320", VA = "0x180B29120")]
		private void OnDestroy()
		{
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0xB28F70", Offset = "0xB28170", VA = "0x180B28F70")]
		private void MinPass()
		{
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0xB29240", Offset = "0xB28440", VA = "0x180B29240")]
		public void Open()
		{
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0xB28AE0", Offset = "0xB27CE0", VA = "0x180B28AE0")]
		public void Close()
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0xB28F20", Offset = "0xB28120", VA = "0x180B28F20")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0xB28AD0", Offset = "0xB27CD0", VA = "0x180B28AD0")]
		public bool CanOpen()
		{
			return default(bool);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B0")]
		[Address(RVA = "0xB28840", Offset = "0xB27A40", VA = "0x180B28840")]
		public void AddPlayer(Player player)
		{
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0xB297C0", Offset = "0xB289C0", VA = "0x180B297C0")]
		public void RemovePlayer(Player player)
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0xB29870", Offset = "0xB28A70", VA = "0x180B29870")]
		public TVInterface()
		{
		}

		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		public const float OPEN_TIME = 0.15f;

		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		public const float FOV = 60f;

		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		[FieldOffset(Offset = "0x28")]
		public List<Player> Players;

		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		[FieldOffset(Offset = "0x38")]
		public Transform CameraPosition;

		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		[FieldOffset(Offset = "0x40")]
		public TVHomeScreen HomeScreen;

		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshPro TimeLabel;

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshPro Daylabel;

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent<Player> onPlayerAdded;

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent<Player> onPlayerRemoved;
	}
}
