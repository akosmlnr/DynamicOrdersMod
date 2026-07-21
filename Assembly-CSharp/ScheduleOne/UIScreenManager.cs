using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace ScheduleOne
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	public class UIScreenManager : PersistentSingleton<UIScreenManager>
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000275")]
		public InputActionReference SubmitInputAction
		{
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000276")]
		public static GameObject LastSelectedObject
		{
			[Token(Token = "0x6000C90")]
			[Address(RVA = "0xADD1B0", Offset = "0xADC3B0", VA = "0x180ADD1B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0xADD250", Offset = "0xADC450", VA = "0x180ADD250")]
			set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x17000277")]
		public static bool IsBackTriggeredThisFrame
		{
			[Token(Token = "0x6000C92")]
			[Address(RVA = "0xADD170", Offset = "0xADC370", VA = "0x180ADD170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0xADCE30", Offset = "0xADC030", VA = "0x180ADCE30", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0xADC580", Offset = "0xADB780", VA = "0x180ADC580", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0xADD090", Offset = "0xADC290", VA = "0x180ADD090")]
		private void Update()
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0xADC540", Offset = "0xADB740", VA = "0x180ADC540")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0xADB850", Offset = "0xADAA50", VA = "0x180ADB850")]
		private void BackToCloseCurrentScreen()
		{
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x6000C98")]
		[Address(RVA = "0xADC1A0", Offset = "0xADB3A0", VA = "0x180ADC1A0")]
		public bool IsActiveScreenRegisteredForBack()
		{
			return default(bool);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C99")]
		[Address(RVA = "0xADBF30", Offset = "0xADB130", VA = "0x180ADBF30")]
		private void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0xADBA80", Offset = "0xADAC80", VA = "0x180ADBA80")]
		private void CheckInputDeviceMode()
		{
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0xADC750", Offset = "0xADB950", VA = "0x180ADC750")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000278")]
		public UIScreen TopScreen
		{
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0xADD1F0", Offset = "0xADC3F0", VA = "0x180ADD1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0xADB570", Offset = "0xADA770", VA = "0x180ADB570")]
		public void AddScreen(UIScreen screen, [Optional] Action onCloseCallback)
		{
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0xADC980", Offset = "0xADBB80", VA = "0x180ADC980")]
		public void RemoveScreen(UIScreen screen)
		{
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0xADC3C0", Offset = "0xADB5C0", VA = "0x180ADC3C0")]
		private bool IsScreenInStack(UIScreen screen)
		{
			return default(bool);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0xADC370", Offset = "0xADB570", VA = "0x180ADC370")]
		public bool IsAnyScreenActive()
		{
			return default(bool);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0xADC250", Offset = "0xADB450", VA = "0x180ADC250")]
		public bool IsAnyPopupScreenActive()
		{
			return default(bool);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0xADC7E0", Offset = "0xADB9E0", VA = "0x180ADC7E0")]
		public void OpenPopupScreen(string popupID)
		{
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0xADC8E0", Offset = "0xADBAE0", VA = "0x180ADC8E0")]
		public void OpenPopupScreen(string popupID, params object[] args)
		{
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0xADBB20", Offset = "0xADAD20", VA = "0x180ADBB20")]
		public void ClosePopupScreen(string popupID)
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0xADBC50", Offset = "0xADAE50", VA = "0x180ADBC50")]
		private UIPopupScreen FindPopupScreen(string popupID)
		{
			return null;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0xADD0A0", Offset = "0xADC2A0", VA = "0x180ADD0A0")]
		public UIScreenManager()
		{
		}

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		public const float NavigationRepeatDelay = 0.5f;

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		public const float NavigationRepeatRate = 0.125f;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		public const float DefaultScrollSpeed = 0.15f;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		public const float ScrollbarScrollSpeed = 25f;

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIPopupScreen[] popupScreenPrefabs;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Default 'A' button on controller for basic selectable interaction. Used in UITrigger")]
		[SerializeField]
		private InputActionReference submitInputAction;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Default 'B' button on controller, RightMouseButton for back interaction. Used in UIScreenManager")]
		[SerializeField]
		private InputActionReference backInputAction;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Default 'Start' button on controller, Escape key for back interaction. Used in UIScreenManager")]
		[SerializeField]
		private InputActionReference escapeInputAction;

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<UIPopupScreen> popupScreenInstances;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Stack<UIScreenManager.UIScreenInfo> screenStack;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject lastSelectedObject;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool isBackTriggeredThisFrame;

		// Token: 0x02000231 RID: 561
		[Token(Token = "0x2000231")]
		public struct UIScreenInfo
		{
			// Token: 0x04000CB3 RID: 3251
			[Token(Token = "0x4000CB3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UIScreen screen;

			// Token: 0x04000CB4 RID: 3252
			[Token(Token = "0x4000CB4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Action onCloseCallback;
		}
	}
}
