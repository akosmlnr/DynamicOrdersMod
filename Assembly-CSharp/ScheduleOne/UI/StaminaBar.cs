using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000C98 RID: 3224
	[Token(Token = "0x2000C98")]
	public class StaminaBar : MonoBehaviour
	{
		// Token: 0x06005E5A RID: 24154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0xA12D90", Offset = "0xA11F90", VA = "0x180A12D90")]
		private void Awake()
		{
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E5B")]
		[Address(RVA = "0xA12EE0", Offset = "0xA120E0", VA = "0x180A12EE0")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E5C")]
		[Address(RVA = "0xA130A0", Offset = "0xA122A0", VA = "0x180A130A0")]
		private void UpdateStaminaBar(float change)
		{
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E5D")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public StaminaBar()
		{
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005E5E")]
		[Address(RVA = "0xA13030", Offset = "0xA12230", VA = "0x180A13030")]
		[CompilerGenerated]
		private IEnumerator <UpdateStaminaBar>g__Routine|7_0()
		{
			return null;
		}

		// Token: 0x040040D6 RID: 16598
		[Token(Token = "0x40040D6")]
		public const float StaminaShowTime = 1.5f;

		// Token: 0x040040D7 RID: 16599
		[Token(Token = "0x40040D7")]
		public const float StaminaFadeTime = 0.5f;

		// Token: 0x040040D8 RID: 16600
		[Token(Token = "0x40040D8")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Slider[] Sliders;

		// Token: 0x040040D9 RID: 16601
		[Token(Token = "0x40040D9")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup Group;

		// Token: 0x040040DA RID: 16602
		[Token(Token = "0x40040DA")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine routine;
	}
}
