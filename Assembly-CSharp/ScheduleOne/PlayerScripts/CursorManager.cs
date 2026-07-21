using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	public class CursorManager : Singleton<CursorManager>
	{
		// Token: 0x06002225 RID: 8741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002225")]
		[Address(RVA = "0x66F7B0", Offset = "0x66E9B0", VA = "0x18066F7B0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002226")]
		[Address(RVA = "0x66FB90", Offset = "0x66ED90", VA = "0x18066FB90")]
		public void SetCursorAppearance(CursorManager.ECursorType type)
		{
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002227")]
		[Address(RVA = "0x66FDD0", Offset = "0x66EFD0", VA = "0x18066FDD0")]
		public CursorManager()
		{
		}

		// Token: 0x04001BA6 RID: 7078
		[Token(Token = "0x4001BA6")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public List<CursorManager.CursorConfig> Cursors;

		// Token: 0x020005D3 RID: 1491
		[Token(Token = "0x20005D3")]
		public enum ECursorType
		{
			// Token: 0x04001BA8 RID: 7080
			[Token(Token = "0x4001BA8")]
			Default,
			// Token: 0x04001BA9 RID: 7081
			[Token(Token = "0x4001BA9")]
			Finger,
			// Token: 0x04001BAA RID: 7082
			[Token(Token = "0x4001BAA")]
			OpenHand,
			// Token: 0x04001BAB RID: 7083
			[Token(Token = "0x4001BAB")]
			Grab,
			// Token: 0x04001BAC RID: 7084
			[Token(Token = "0x4001BAC")]
			Scissors,
			// Token: 0x04001BAD RID: 7085
			[Token(Token = "0x4001BAD")]
			Spray
		}

		// Token: 0x020005D4 RID: 1492
		[Token(Token = "0x20005D4")]
		[Serializable]
		public class CursorConfig
		{
			// Token: 0x06002228 RID: 8744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002228")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public CursorConfig()
			{
			}

			// Token: 0x04001BAE RID: 7086
			[Token(Token = "0x4001BAE")]
			[FieldOffset(Offset = "0x10")]
			public CursorManager.ECursorType CursorType;

			// Token: 0x04001BAF RID: 7087
			[Token(Token = "0x4001BAF")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D Texture;

			// Token: 0x04001BB0 RID: 7088
			[Token(Token = "0x4001BB0")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 HotSpot;
		}
	}
}
