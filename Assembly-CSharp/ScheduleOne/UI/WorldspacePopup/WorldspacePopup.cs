using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x2000CD0")]
	public class WorldspacePopup : MonoBehaviour
	{
		// Token: 0x06005F9F RID: 24479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0xA3ABA0", Offset = "0xA39DA0", VA = "0x180A3ABA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0xA3AAF0", Offset = "0xA39CF0", VA = "0x180A3AAF0")]
		private void OnDisable()
		{
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0xA3A7C0", Offset = "0xA399C0", VA = "0x180A3A7C0")]
		public WorldspacePopupUI CreateUI(RectTransform parent)
		{
			return null;
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0xA3A9C0", Offset = "0xA39BC0", VA = "0x180A3A9C0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0xA3ACA0", Offset = "0xA39EA0", VA = "0x180A3ACA0")]
		public void Popup()
		{
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0xA3AE40", Offset = "0xA3A040", VA = "0x180A3AE40")]
		public WorldspacePopup()
		{
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0xA3AD40", Offset = "0xA39F40", VA = "0x180A3AD40")]
		[CompilerGenerated]
		private IEnumerator <Popup>g__PopupCoroutine|18_0()
		{
			return null;
		}

		// Token: 0x040041EB RID: 16875
		[Token(Token = "0x40041EB")]
		[FieldOffset(Offset = "0x0")]
		public static List<WorldspacePopup> ActivePopups;

		// Token: 0x040041EC RID: 16876
		[Token(Token = "0x40041EC")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float CurrentFillLevel;

		// Token: 0x040041ED RID: 16877
		[Token(Token = "0x40041ED")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public WorldspacePopupUI UIPrefab;

		// Token: 0x040041EE RID: 16878
		[Token(Token = "0x40041EE")]
		[FieldOffset(Offset = "0x30")]
		public bool DisplayOnHUD;

		// Token: 0x040041EF RID: 16879
		[Token(Token = "0x40041EF")]
		[FieldOffset(Offset = "0x31")]
		public bool ScaleWithDistance;

		// Token: 0x040041F0 RID: 16880
		[Token(Token = "0x40041F0")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 WorldspaceOffset;

		// Token: 0x040041F1 RID: 16881
		[Token(Token = "0x40041F1")]
		[FieldOffset(Offset = "0x40")]
		public float Range;

		// Token: 0x040041F2 RID: 16882
		[Token(Token = "0x40041F2")]
		[FieldOffset(Offset = "0x44")]
		public float SizeMultiplier;

		// Token: 0x040041F3 RID: 16883
		[Token(Token = "0x40041F3")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public WorldspacePopupUI WorldspaceUI;

		// Token: 0x040041F4 RID: 16884
		[Token(Token = "0x40041F4")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public RectTransform HUDUI;

		// Token: 0x040041F5 RID: 16885
		[Token(Token = "0x40041F5")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public WorldspacePopupUI HUDUIIcon;

		// Token: 0x040041F6 RID: 16886
		[Token(Token = "0x40041F6")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public CanvasGroup HUDUICanvasGroup;

		// Token: 0x040041F7 RID: 16887
		[Token(Token = "0x40041F7")]
		[FieldOffset(Offset = "0x68")]
		private List<WorldspacePopupUI> UIs;

		// Token: 0x040041F8 RID: 16888
		[Token(Token = "0x40041F8")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine popupCoroutine;
	}
}
