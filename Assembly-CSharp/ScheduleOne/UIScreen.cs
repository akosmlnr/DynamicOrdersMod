using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x0200022F RID: 559
	[Token(Token = "0x200022F")]
	public class UIScreen : MonoBehaviour
	{
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00006FD8 File Offset: 0x000051D8
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		public bool IsSelected
		{
			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x4D4690", Offset = "0x4D3890", VA = "0x1804D4690")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C76")]
			[Address(RVA = "0xADEBC0", Offset = "0xADDDC0", VA = "0x180ADEBC0")]
			set
			{
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000273")]
		public UIPanel CurrentSelectedPanel
		{
			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000274")]
		public IReadOnlyList<UIPanel> Panels
		{
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0xADEB70", Offset = "0xADDD70", VA = "0x180ADEB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0xADD3E0", Offset = "0xADC5E0", VA = "0x180ADD3E0")]
		private void Awake()
		{
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		protected virtual void OnAwake()
		{
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0xADE610", Offset = "0xADD810", VA = "0x180ADE610")]
		private void Start()
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		protected virtual void OnStarted()
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0xADE0E0", Offset = "0xADD2E0", VA = "0x180ADE0E0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0xADE050", Offset = "0xADD250", VA = "0x180ADE050")]
		private void OnDisable()
		{
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0xADDFB0", Offset = "0xADD1B0", VA = "0x180ADDFB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		protected virtual void OnDestroyed()
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0xADE820", Offset = "0xADDA20", VA = "0x180ADE820", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0xADDA00", Offset = "0xADCC00", VA = "0x180ADDA00")]
		private void InitScreen()
		{
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0xADD2B0", Offset = "0xADC4B0", VA = "0x180ADD2B0")]
		public void AddPanel(UIPanel panel)
		{
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0xADE0F0", Offset = "0xADD2F0", VA = "0x180ADE0F0")]
		public void RemovePanel(UIPanel panel)
		{
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0xADD550", Offset = "0xADC750", VA = "0x180ADD550")]
		public void ClearPanels()
		{
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0xADE200", Offset = "0xADD400", VA = "0x180ADE200")]
		public void SetCurrentSelectedPanel([Optional] UISelectable overrideSelectable, bool scrollToChild = true)
		{
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C87")]
		[Address(RVA = "0xADE520", Offset = "0xADD720", VA = "0x180ADE520")]
		public void SetCurrentSelectedPanel(UIPanel panel, [Optional] UISelectable overrideSelectable, bool scrollToChild = true)
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0xADE650", Offset = "0xADD850", VA = "0x180ADE650")]
		private void UpdateScrollbar()
		{
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0xADD6D0", Offset = "0xADC8D0", VA = "0x180ADD6D0")]
		private void DetectInput()
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0xADD8A0", Offset = "0xADCAA0", VA = "0x180ADD8A0")]
		private void DetectScreenInputDescriptors()
		{
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0xADD9B0", Offset = "0xADCBB0", VA = "0x180ADD9B0")]
		internal bool ForceNavigate(Vector2 navDir, Vector2 fromPos)
		{
			return default(bool);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0xADDBF0", Offset = "0xADCDF0", VA = "0x180ADDBF0")]
		private bool Navigate(Vector2 navDir, Vector2 fromPos)
		{
			return default(bool);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
		public void ChangeActiveScrollRect(ScrollRect newScrollRect)
		{
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0xADEAB0", Offset = "0xADDCB0", VA = "0x180ADEAB0")]
		public UIScreen()
		{
		}

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Manually assign the UIPanel attached to this screen in editor.")]
		private List<UIPanel> panels;

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("When selected, the input action in the inputDescriptor list will be active")]
		[SerializeField]
		private List<InputDescriptor> inputDescriptors;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Each screen support 1 active scroll rect to scroll. You can use uiScreen.ChangeActiveScrollRect(newScrollRect) to change the active scroll rect via script at runtime.")]
		[SerializeField]
		private ScrollRect activeScrollRect;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Add this screen to UIScreenManger on Start")]
		private bool addScreenOnStart;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[Tooltip("Add this screen to UIScreenManger on OnEnable")]
		[SerializeField]
		private bool addScreenOnEnable;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[Tooltip("Remove this screen from UIScreenManger on OnDisable")]
		[SerializeField]
		private bool removeScreenOnDisable;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UIPanel currentSelectedPanel;

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isSelected;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool wasNavPressedLastFrame;
	}
}
