using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Networking;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Multiplayer
{
	// Token: 0x02000D6A RID: 3434
	[Token(Token = "0x2000D6A")]
	public class LobbyInterface : PersistentSingleton<LobbyInterface>
	{
		// Token: 0x0600636F RID: 25455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600636F")]
		[Address(RVA = "0xA5F4F0", Offset = "0xA5E6F0", VA = "0x180A5F4F0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006370")]
		[Address(RVA = "0xA5FDF0", Offset = "0xA5EFF0", VA = "0x180A5FDF0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006371")]
		[Address(RVA = "0xA5FB00", Offset = "0xA5ED00", VA = "0x180A5FB00")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006372")]
		[Address(RVA = "0xA5FDD0", Offset = "0xA5EFD0", VA = "0x180A5FDD0")]
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006373")]
		[Address(RVA = "0xA5FC80", Offset = "0xA5EE80", VA = "0x180A5FC80")]
		public void LeaveClicked()
		{
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006374")]
		[Address(RVA = "0xA5FA90", Offset = "0xA5EC90", VA = "0x180A5FA90")]
		public void InviteClicked()
		{
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006375")]
		[Address(RVA = "0xA60120", Offset = "0xA5F320", VA = "0x180A60120")]
		private void UpdateButtons()
		{
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006376")]
		[Address(RVA = "0xA601D0", Offset = "0xA5F3D0", VA = "0x180A601D0")]
		private void UpdatePlayers()
		{
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006377")]
		[Address(RVA = "0xA5FCA0", Offset = "0xA5EEA0", VA = "0x180A5FCA0")]
		public void SetPlayer(int index, CSteamID player)
		{
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006378")]
		[Address(RVA = "0xA5F7C0", Offset = "0xA5E9C0", VA = "0x180A5F7C0")]
		public void ClearPlayer(int index)
		{
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006379")]
		[Address(RVA = "0xA5F890", Offset = "0xA5EA90", VA = "0x180A5F890")]
		private Texture2D GetAvatar(CSteamID user)
		{
			return null;
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600637A")]
		[Address(RVA = "0xA60420", Offset = "0xA5F620", VA = "0x180A60420")]
		public LobbyInterface()
		{
		}

		// Token: 0x040045A7 RID: 17831
		[Token(Token = "0x40045A7")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Lobby Lobby;

		// Token: 0x040045A8 RID: 17832
		[Token(Token = "0x40045A8")]
		[FieldOffset(Offset = "0x30")]
		public Canvas Canvas;

		// Token: 0x040045A9 RID: 17833
		[Token(Token = "0x40045A9")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI LobbyTitle;

		// Token: 0x040045AA RID: 17834
		[Token(Token = "0x40045AA")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform[] PlayerSlots;

		// Token: 0x040045AB RID: 17835
		[Token(Token = "0x40045AB")]
		[FieldOffset(Offset = "0x48")]
		public Button InviteButton;

		// Token: 0x040045AC RID: 17836
		[Token(Token = "0x40045AC")]
		[FieldOffset(Offset = "0x50")]
		public Button LeaveButton;

		// Token: 0x040045AD RID: 17837
		[Token(Token = "0x40045AD")]
		[FieldOffset(Offset = "0x58")]
		public GameObject InviteHint;
	}
}
