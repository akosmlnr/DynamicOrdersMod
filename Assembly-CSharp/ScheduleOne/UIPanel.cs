using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x200021C")]
	[RequireComponent(typeof(RectTransform))]
	public abstract class UIPanel : MonoBehaviour
	{
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x17000260")]
		public int Priority
		{
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x494480", Offset = "0x493680", VA = "0x180494480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000261")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00006E40 File Offset: 0x00005040
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000262")]
		public bool IsSelected
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0xAD6F20", Offset = "0xAD6120", VA = "0x180AD6F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x6E18A0", Offset = "0x6E0AA0", VA = "0x1806E18A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00006E58 File Offset: 0x00005058
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000263")]
		public bool IsLocked
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0xAD6ED0", Offset = "0xAD60D0", VA = "0x180AD6ED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0xAD6FC0", Offset = "0xAD61C0", VA = "0x180AD6FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000264")]
		public UIScreen ParentScreen
		{
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x4674F0", Offset = "0x4666F0", VA = "0x1804674F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000265")]
		public UISelectable CurrentSelectedSelectable
		{
			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0xAD6F80", Offset = "0xAD6180", VA = "0x180AD6F80")]
			set
			{
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000266")]
		public IReadOnlyList<UISelectable> Selectables
		{
			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0xAD6F30", Offset = "0xAD6130", VA = "0x180AD6F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x17000267")]
		public bool IsNavigablePanel
		{
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0xAD6EE0", Offset = "0xAD60E0", VA = "0x180AD6EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0xAD3E70", Offset = "0xAD3070", VA = "0x180AD3E70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0xAD6B10", Offset = "0xAD5D10", VA = "0x180AD6B10", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0xAD5450", Offset = "0xAD4650", VA = "0x180AD5450", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0xAD56A0", Offset = "0xAD48A0", VA = "0x180AD56A0", Slot = "7")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0xAD55A0", Offset = "0xAD47A0", VA = "0x180AD55A0", Slot = "8")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0xAD6D30", Offset = "0xAD5F30", VA = "0x180AD6D30", Slot = "9")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0xAD5220", Offset = "0xAD4420", VA = "0x180AD5220")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "10")]
		protected virtual void EarlyUpdate()
		{
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "11")]
		protected virtual void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "12")]
		protected virtual void DetectInput()
		{
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0xAD4450", Offset = "0xAD3650", VA = "0x180AD4450")]
		protected void DetectScreenInputDescriptors()
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0xAD4560", Offset = "0xAD3760", VA = "0x180AD4560")]
		private void DetectSelectableInput()
		{
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0xAD6940", Offset = "0xAD5B40", VA = "0x180AD6940")]
		protected void SendClickEventToCurrentSelectedSelectable()
		{
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
		public void SetParentScreen(UIScreen screen)
		{
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0xAD5100", Offset = "0xAD4300", VA = "0x180AD5100")]
		internal bool IsPanelVisible()
		{
			return default(bool);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0xAD4E80", Offset = "0xAD4080", VA = "0x180AD4E80")]
		internal bool IsAnySelectablesActive()
		{
			return default(bool);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0xAD4950", Offset = "0xAD3B50", VA = "0x180AD4950")]
		public UISelectable GetAValidCurrentSelectedSelectable(bool returnFirstFound = false)
		{
			return null;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0xAD62E0", Offset = "0xAD54E0", VA = "0x180AD62E0")]
		public void SelectSelectable(UISelectable selectable, bool scrollToSelectable = false)
		{
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0xAD65C0", Offset = "0xAD57C0", VA = "0x180AD65C0")]
		public void SelectSelectable(int index, bool scrollToSelectable = false)
		{
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0xAD6450", Offset = "0xAD5650", VA = "0x180AD6450")]
		public void SelectSelectable(bool returnFirstFound, bool scrollToSelectable = false)
		{
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0xAD3D40", Offset = "0xAD2F40", VA = "0x180AD3D40")]
		public bool AddSelectable(UISelectable selectable)
		{
			return default(bool);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0xAD5970", Offset = "0xAD4B70", VA = "0x180AD5970")]
		public void RemoveSelectable(UISelectable selectable, bool autoFallback = true)
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0xAD4360", Offset = "0xAD3560", VA = "0x180AD4360")]
		public void DeselectSelectable()
		{
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0xAD4270", Offset = "0xAD3470", VA = "0x180AD4270")]
		public void ClearAllSelectables()
		{
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0xAD4A00", Offset = "0xAD3C00", VA = "0x180AD4A00")]
		private UISelectable GetFallbackSelectable(bool returnFirstFound = false)
		{
			return null;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0xAD6740", Offset = "0xAD5940", VA = "0x180AD6740")]
		internal UISelectable Select([Optional] UISelectable overrideSelectable, bool scrollToChild = true)
		{
			return null;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0xAD4410", Offset = "0xAD3610", VA = "0x180AD4410")]
		internal void Deselect()
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0xAD5710", Offset = "0xAD4910", VA = "0x180AD5710")]
		internal void OnReset()
		{
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0xAD5B70", Offset = "0xAD4D70", VA = "0x180AD5B70")]
		private void ResetCurrentSelectedSelectable()
		{
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0xAD6220", Offset = "0xAD5420", VA = "0x180AD6220")]
		public void ScrollToCurrentSelectedSelectable()
		{
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0xAD5C50", Offset = "0xAD4E50", VA = "0x180AD5C50")]
		protected void ScrollToChild(RectTransform child, float duration = 0.25f)
		{
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C08")]
		[Address(RVA = "0xAD6A70", Offset = "0xAD5C70", VA = "0x180AD6A70")]
		private IEnumerator SmoothScrollContent(Vector3 targetLocalPosition, float duration)
		{
			return null;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0xAD4940", Offset = "0xAD3B40", VA = "0x180AD4940")]
		public void EnableSideNavigation(bool enabled)
		{
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "13")]
		protected virtual bool Navigate(Vector2 navDir)
		{
			return default(bool);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0xAD5BF0", Offset = "0xAD4DF0", VA = "0x180AD5BF0")]
		private void ResetNavigationData()
		{
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0xAD5240", Offset = "0xAD4440", VA = "0x180AD5240")]
		internal void LockNavigationTemporarily()
		{
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0xAD5260", Offset = "0xAD4460", VA = "0x180AD5260", Slot = "14")]
		protected virtual bool NavigateUsingCyclePanel(Vector2 dir)
		{
			return default(bool);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0xAD6E00", Offset = "0xAD6000", VA = "0x180AD6E00")]
		protected UIPanel()
		{
		}

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Manually assign the UIPanel attached to this screen in editor. Alternatively, you can use AddSelectable and RemoveSelectable to add/remove UISelectable.")]
		protected List<UISelectable> selectables;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Default selectable to focus when the panel is selected.")]
		protected UISelectable defaultSelectable;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("ScrollRect for scrolling Layout Group.")]
		[SerializeField]
		protected ScrollRect scrollRect;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Priority value to control which panel will be selected by default by the Screen.")]
		private int priority;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("When selected, the input action in the inputDescriptor list will be active")]
		[SerializeField]
		private List<InputDescriptor> inputDescriptors;

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Select this panel on Start")]
		private bool selectPanelOnStart;

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[Tooltip("Select this panel on OnEnable")]
		[SerializeField]
		private bool selectPanelOnEnable;

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[Tooltip("Deselect this panel on OnDisable")]
		private bool deselectPanelOnDisable;

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[Tooltip("Set to true if this panel is supporting UIOptions to prevent left/right navigation of UISelectable and UIPanel")]
		[SerializeField]
		protected bool preventSideNavigation;

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent OnPanelSelected;

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent OnPanelDeselected;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UISelectable currentSelectedSelectable;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected int currentIndex;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float navTimer;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected bool wasNavPressedLastFrame;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected float scrollSpeed;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine scrollCoroutine;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool isDisabled;

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool isQuitting;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector2 scrollMargin;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool lockInputThisFrame;

		// Token: 0x0200021D RID: 541
		[Token(Token = "0x200021D")]
		public enum UINavigationType
		{
			// Token: 0x04000C3B RID: 3131
			[Token(Token = "0x4000C3B")]
			ImmediateDirection,
			// Token: 0x04000C3C RID: 3132
			[Token(Token = "0x4000C3C")]
			NearestDirectionAndDistance
		}
	}
}
