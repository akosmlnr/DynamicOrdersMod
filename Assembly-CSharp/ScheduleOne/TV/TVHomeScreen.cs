using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x20002F4")]
	public class TVHomeScreen : TVApp
	{
		// Token: 0x06001199 RID: 4505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001199")]
		[Address(RVA = "0xB27F60", Offset = "0xB27160", VA = "0x180B27F60", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119A")]
		[Address(RVA = "0xB283B0", Offset = "0xB275B0", VA = "0x180B283B0", Slot = "5")]
		public override void Open()
		{
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119B")]
		[Address(RVA = "0xB28360", Offset = "0xB27560", VA = "0x180B28360", Slot = "6")]
		public override void Close()
		{
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119C")]
		[Address(RVA = "0xB27F00", Offset = "0xB27100", VA = "0x180B27F00", Slot = "8")]
		protected override void ActiveMinPass()
		{
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119D")]
		[Address(RVA = "0xB285C0", Offset = "0xB277C0", VA = "0x180B285C0")]
		private void UpdateTimeLabel()
		{
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119E")]
		[Address(RVA = "0xB27F10", Offset = "0xB27110", VA = "0x180B27F10")]
		private void AppSelected(TVApp app)
		{
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119F")]
		[Address(RVA = "0xB283D0", Offset = "0xB275D0", VA = "0x180B283D0")]
		private void PlayerChange(Player player)
		{
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0xB27E70", Offset = "0xB27070", VA = "0x180B27E70")]
		public TVHomeScreen()
		{
		}

		// Token: 0x0400104D RID: 4173
		[Token(Token = "0x400104D")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public TVInterface Interface;

		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		[FieldOffset(Offset = "0x70")]
		public TVApp[] Apps;

		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform AppButtonContainer;

		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform[] PlayerDisplays;

		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI TimeLabel;

		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		[FieldOffset(Offset = "0x90")]
		[Header("Prefabs")]
		public GameObject AppButtonPrefab;

		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		[FieldOffset(Offset = "0x98")]
		private bool skipExit;
	}
}
