using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000CD3 RID: 3283
	[Token(Token = "0x2000CD3")]
	public class WorldspacePopupCanvas : MonoBehaviour
	{
		// Token: 0x06005FAF RID: 24495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0xA39E80", Offset = "0xA39080", VA = "0x180A39E80")]
		private void Update()
		{
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0xA39140", Offset = "0xA38340", VA = "0x180A39140")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x00017E50 File Offset: 0x00016050
		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0xA39CB0", Offset = "0xA38EB0", VA = "0x180A39CB0")]
		private bool ShouldCreateUI(WorldspacePopup popup)
		{
			return default(bool);
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0xA38CD0", Offset = "0xA37ED0", VA = "0x180A38CD0")]
		private WorldspacePopupUI CreateWorldspaceIcon(WorldspacePopup popup)
		{
			return null;
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0xA38AE0", Offset = "0xA37CE0", VA = "0x180A38AE0")]
		private RectTransform CreateHUDIcon(WorldspacePopup popup)
		{
			return null;
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0xA38FF0", Offset = "0xA381F0", VA = "0x180A38FF0")]
		private void DestroyWorldspaceIcon(WorldspacePopup popup)
		{
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0xA38E30", Offset = "0xA38030", VA = "0x180A38E30")]
		private void DestroyHUDIcon(WorldspacePopup popup)
		{
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0xA3A620", Offset = "0xA39820", VA = "0x180A3A620")]
		public WorldspacePopupCanvas()
		{
		}

		// Token: 0x04004200 RID: 16896
		[Token(Token = "0x4004200")]
		public const float WORLDSPACE_ICON_SCALE_MULTIPLIER = 0.4f;

		// Token: 0x04004201 RID: 16897
		[Token(Token = "0x4004201")]
		private const float HUDIconMaxOpacityAngle = 50f;

		// Token: 0x04004202 RID: 16898
		[Token(Token = "0x4004202")]
		private const float HUDIconMinOpacityAngle = 30f;

		// Token: 0x04004203 RID: 16899
		[Token(Token = "0x4004203")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public RectTransform WorldspaceContainer;

		// Token: 0x04004204 RID: 16900
		[Token(Token = "0x4004204")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform HudContainer;

		// Token: 0x04004205 RID: 16901
		[Token(Token = "0x4004205")]
		[FieldOffset(Offset = "0x30")]
		[Header("Prefabs")]
		public GameObject HudIconContainerPrefab;

		// Token: 0x04004206 RID: 16902
		[Token(Token = "0x4004206")]
		[FieldOffset(Offset = "0x38")]
		private List<WorldspacePopupUI> activeWorldspaceUIs;

		// Token: 0x04004207 RID: 16903
		[Token(Token = "0x4004207")]
		[FieldOffset(Offset = "0x40")]
		private List<RectTransform> activeHUDUIs;

		// Token: 0x04004208 RID: 16904
		[Token(Token = "0x4004208")]
		[FieldOffset(Offset = "0x48")]
		private List<WorldspacePopup> popupsWithUI;
	}
}
