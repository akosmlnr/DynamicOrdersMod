using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A32 RID: 2610
	[Token(Token = "0x2000A32")]
	public class RebindActionUI : MonoBehaviour
	{
		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060049EF RID: 18927 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060049F0 RID: 18928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B85")]
		public InputActionReference actionReference
		{
			[Token(Token = "0x60049EF")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049F0")]
			[Address(RVA = "0x90EE80", Offset = "0x90E080", VA = "0x18090EE80")]
			set
			{
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060049F2 RID: 18930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B86")]
		public string bindingId
		{
			[Token(Token = "0x60049F1")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049F2")]
			[Address(RVA = "0x90EEB0", Offset = "0x90E0B0", VA = "0x18090EEB0")]
			set
			{
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060049F3 RID: 18931 RVA: 0x000141A8 File Offset: 0x000123A8
		// (set) Token: 0x060049F4 RID: 18932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B87")]
		public InputBinding.DisplayStringOptions displayStringOptions
		{
			[Token(Token = "0x60049F3")]
			[Address(RVA = "0x494480", Offset = "0x493680", VA = "0x180494480")]
			get
			{
				return (InputBinding.DisplayStringOptions)0;
			}
			[Token(Token = "0x60049F4")]
			[Address(RVA = "0x90EF10", Offset = "0x90E110", VA = "0x18090EF10")]
			set
			{
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060049F6 RID: 18934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B88")]
		public TextMeshProUGUI actionLabel
		{
			[Token(Token = "0x60049F5")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049F6")]
			[Address(RVA = "0x90EE50", Offset = "0x90E050", VA = "0x18090EE50")]
			set
			{
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060049F8 RID: 18936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B89")]
		public TextMeshProUGUI bindingText
		{
			[Token(Token = "0x60049F7")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049F8")]
			[Address(RVA = "0x90EEE0", Offset = "0x90E0E0", VA = "0x18090EEE0")]
			set
			{
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060049F9 RID: 18937 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060049FA RID: 18938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B8A")]
		public TextMeshProUGUI rebindPrompt
		{
			[Token(Token = "0x60049F9")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049FA")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			set
			{
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060049FB RID: 18939 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060049FC RID: 18940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B8B")]
		public GameObject rebindOverlay
		{
			[Token(Token = "0x60049FB")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049FC")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			set
			{
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B8C")]
		public RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent
		{
			[Token(Token = "0x60049FD")]
			[Address(RVA = "0x90EDC0", Offset = "0x90DFC0", VA = "0x18090EDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B8D")]
		public RebindActionUI.InteractiveRebindEvent startRebindEvent
		{
			[Token(Token = "0x60049FE")]
			[Address(RVA = "0x90ECA0", Offset = "0x90DEA0", VA = "0x18090ECA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060049FF RID: 18943 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B8E")]
		public RebindActionUI.InteractiveRebindEvent stopRebindEvent
		{
			[Token(Token = "0x60049FF")]
			[Address(RVA = "0x90ED30", Offset = "0x90DF30", VA = "0x18090ED30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06004A00 RID: 18944 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B8F")]
		public InputActionRebindingExtensions.RebindingOperation ongoingRebind
		{
			[Token(Token = "0x6004A00")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x000141C0 File Offset: 0x000123C0
		[Token(Token = "0x6004A01")]
		[Address(RVA = "0x90E3B0", Offset = "0x90D5B0", VA = "0x18090E3B0")]
		public bool ResolveActionAndBinding(out InputAction action, out int bindingIndex)
		{
			return default(bool);
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x000141D8 File Offset: 0x000123D8
		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x90D4F0", Offset = "0x90C6F0", VA = "0x18090D4F0")]
		public bool IsRebinding()
		{
			return default(bool);
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A03")]
		[Address(RVA = "0x90EAA0", Offset = "0x90DCA0", VA = "0x18090EAA0")]
		public void UpdateBindingDisplay()
		{
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x90DFE0", Offset = "0x90D1E0", VA = "0x18090DFE0")]
		public void ResetToDefault()
		{
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A05")]
		[Address(RVA = "0x90E5B0", Offset = "0x90D7B0", VA = "0x18090E5B0")]
		public void StartInteractiveRebind()
		{
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x90DAF0", Offset = "0x90CCF0", VA = "0x18090DAF0")]
		private void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = false)
		{
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x90D8F0", Offset = "0x90CAF0", VA = "0x18090D8F0")]
		protected void OnEnable()
		{
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x90D7B0", Offset = "0x90C9B0", VA = "0x18090D7B0")]
		protected void OnDisable()
		{
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x90D540", Offset = "0x90C740", VA = "0x18090D540")]
		private static void OnActionChange(object obj, InputActionChange change)
		{
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x90E9E0", Offset = "0x90DBE0", VA = "0x18090E9E0")]
		private void UpdateActionLabel()
		{
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A0B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RebindActionUI()
		{
		}

		// Token: 0x04003463 RID: 13411
		[Token(Token = "0x4003463")]
		[FieldOffset(Offset = "0x20")]
		public Action onRebind;

		// Token: 0x04003464 RID: 13412
		[Token(Token = "0x4003464")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to action that is to be rebound from the UI.")]
		[SerializeField]
		private InputActionReference m_Action;

		// Token: 0x04003465 RID: 13413
		[Token(Token = "0x4003465")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_BindingId;

		// Token: 0x04003466 RID: 13414
		[Token(Token = "0x4003466")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputBinding.DisplayStringOptions m_DisplayStringOptions;

		// Token: 0x04003467 RID: 13415
		[Token(Token = "0x4003467")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Text label that will receive the name of the action. Optional. Set to None to have the rebind UI not show a label for the action.")]
		private TextMeshProUGUI m_ActionLabel;

		// Token: 0x04003468 RID: 13416
		[Token(Token = "0x4003468")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Text label that will receive the current, formatted binding string.")]
		[SerializeField]
		private TextMeshProUGUI m_BindingText;

		// Token: 0x04003469 RID: 13417
		[Token(Token = "0x4003469")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Optional UI that will be shown while a rebind is in progress.")]
		[SerializeField]
		private GameObject m_RebindOverlay;

		// Token: 0x0400346A RID: 13418
		[Token(Token = "0x400346A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Optional text label that will be updated with prompt for user input.")]
		private TextMeshProUGUI m_RebindText;

		// Token: 0x0400346B RID: 13419
		[Token(Token = "0x400346B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Event that is triggered when the way the binding is display should be updated. This allows displaying bindings in custom ways, e.g. using images instead of text.")]
		private RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent;

		// Token: 0x0400346C RID: 13420
		[Token(Token = "0x400346C")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Event that is triggered when an interactive rebind is being initiated. This can be used, for example, to implement custom UI behavior while a rebind is in progress. It can also be used to further customize the rebind.")]
		[SerializeField]
		private RebindActionUI.InteractiveRebindEvent m_RebindStartEvent;

		// Token: 0x0400346D RID: 13421
		[Token(Token = "0x400346D")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("Event that is triggered when an interactive rebind is complete or has been aborted.")]
		[SerializeField]
		private RebindActionUI.InteractiveRebindEvent m_RebindStopEvent;

		// Token: 0x0400346E RID: 13422
		[Token(Token = "0x400346E")]
		[FieldOffset(Offset = "0x78")]
		private InputActionRebindingExtensions.RebindingOperation m_RebindOperation;

		// Token: 0x0400346F RID: 13423
		[Token(Token = "0x400346F")]
		[FieldOffset(Offset = "0x0")]
		private static List<RebindActionUI> s_RebindActionUIs;

		// Token: 0x02000A33 RID: 2611
		[Token(Token = "0x2000A33")]
		[Serializable]
		public class UpdateBindingUIEvent : UnityEvent<RebindActionUI, string, string, string>
		{
			// Token: 0x06004A0D RID: 18957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004A0D")]
			[Address(RVA = "0x916E10", Offset = "0x916010", VA = "0x180916E10")]
			public UpdateBindingUIEvent()
			{
			}
		}

		// Token: 0x02000A34 RID: 2612
		[Token(Token = "0x2000A34")]
		[Serializable]
		public class InteractiveRebindEvent : UnityEvent<RebindActionUI, InputActionRebindingExtensions.RebindingOperation>
		{
			// Token: 0x06004A0E RID: 18958 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004A0E")]
			[Address(RVA = "0x8F7050", Offset = "0x8F6250", VA = "0x1808F7050")]
			public InteractiveRebindEvent()
			{
			}
		}
	}
}
