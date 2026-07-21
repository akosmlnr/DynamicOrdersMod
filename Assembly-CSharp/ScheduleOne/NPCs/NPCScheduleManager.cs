using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.GameTime;
using ScheduleOne.NPCs.Other;
using ScheduleOne.NPCs.Schedules;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A66 RID: 2662
	[Token(Token = "0x2000A66")]
	public class NPCScheduleManager : MonoBehaviour
	{
		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x00014AD8 File Offset: 0x00012CD8
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEB")]
		public bool ScheduleEnabled
		{
			[Token(Token = "0x6004CD7")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CD8")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x00014AF0 File Offset: 0x00012CF0
		// (set) Token: 0x06004CDA RID: 19674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEC")]
		public bool CurfewModeEnabled
		{
			[Token(Token = "0x6004CD9")]
			[Address(RVA = "0x68A2D0", Offset = "0x6894D0", VA = "0x18068A2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CDA")]
			[Address(RVA = "0x570D90", Offset = "0x56FF90", VA = "0x180570D90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004CDC RID: 19676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BED")]
		public NPCAction ActiveAction
		{
			[Token(Token = "0x6004CDB")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CDC")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06004CDD RID: 19677 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004CDE RID: 19678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEE")]
		public List<NPCAction> PendingActions
		{
			[Token(Token = "0x6004CDD")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CDE")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06004CDF RID: 19679 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004CE0 RID: 19680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEF")]
		public NPC Npc
		{
			[Token(Token = "0x6004CDF")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CE0")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BF0")]
		public List<NPCDiscreteAction> DiscreteActions
		{
			[Token(Token = "0x6004CE1")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004CE3 RID: 19683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF1")]
		protected List<NPCAction> ActionsAwaitingStart
		{
			[Token(Token = "0x6004CE2")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CE3")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BF2")]
		protected TimeManager Time
		{
			[Token(Token = "0x6004CE4")]
			[Address(RVA = "0x92E240", Offset = "0x92D440", VA = "0x18092E240")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE5")]
		[Address(RVA = "0x92B630", Offset = "0x92A830", VA = "0x18092B630", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x92D010", Offset = "0x92C210", VA = "0x18092D010", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x92CAD0", Offset = "0x92BCD0", VA = "0x18092CAD0")]
		private void LocalPlayerSpawned()
		{
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x92CC20", Offset = "0x92BE20", VA = "0x18092CC20")]
		private void OnValidate()
		{
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE9")]
		[Address(RVA = "0x92E020", Offset = "0x92D220", VA = "0x18092E020", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CEA")]
		[Address(RVA = "0x92B8A0", Offset = "0x92AAA0", VA = "0x18092B8A0")]
		public void EnableSchedule()
		{
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x92B6B0", Offset = "0x92A8B0", VA = "0x18092B6B0")]
		public void DisableSchedule()
		{
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x92C750", Offset = "0x92B950", VA = "0x18092C750")]
		[Button]
		public void InitializeActions()
		{
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x92CB00", Offset = "0x92BD00", VA = "0x18092CB00", Slot = "7")]
		protected virtual void OnMinPass()
		{
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0x92D6E0", Offset = "0x92C8E0", VA = "0x18092D6E0")]
		private void UpdateActions()
		{
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CEF")]
		[Address(RVA = "0x92CC10", Offset = "0x92BE10", VA = "0x18092CC10", Slot = "8")]
		protected virtual void OnTick()
		{
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004CF0")]
		[Address(RVA = "0x92C1B0", Offset = "0x92B3B0", VA = "0x18092C1B0")]
		private List<NPCAction> GetActionsOccurringAt(int time)
		{
			return null;
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004CF1")]
		[Address(RVA = "0x92C480", Offset = "0x92B680", VA = "0x18092C480")]
		private List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			return null;
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x92CE40", Offset = "0x92C040", VA = "0x18092CE40")]
		private void StartAction(NPCAction action)
		{
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0x92B8E0", Offset = "0x92AAE0", VA = "0x18092B8E0")]
		private void EnforceState()
		{
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x92B970", Offset = "0x92AB70", VA = "0x18092B970")]
		public void EnforceState(bool initial = false)
		{
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF5")]
		[Address(RVA = "0x92B6A0", Offset = "0x92A8A0", VA = "0x18092B6A0", Slot = "9")]
		protected virtual void CurfewEnabled()
		{
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x92B690", Offset = "0x92A890", VA = "0x18092B690", Slot = "10")]
		protected virtual void CurfewDisabled()
		{
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0x92CC60", Offset = "0x92BE60", VA = "0x18092CC60")]
		public void SetCurfewModeEnabled(bool enabled)
		{
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0x92E120", Offset = "0x92D320", VA = "0x18092E120")]
		public NPCScheduleManager()
		{
		}

		// Token: 0x040035E6 RID: 13798
		[Token(Token = "0x40035E6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly NPCActionOrderByDescending orderByDescending;

		// Token: 0x040035E9 RID: 13801
		[Token(Token = "0x40035E9")]
		[FieldOffset(Offset = "0x22")]
		public bool DEBUG_MODE;

		// Token: 0x040035ED RID: 13805
		[Token(Token = "0x40035ED")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public GameObject[] EnabledDuringCurfew;

		// Token: 0x040035EE RID: 13806
		[Token(Token = "0x40035EE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject[] EnabledDuringNoCurfew;

		// Token: 0x040035EF RID: 13807
		[Token(Token = "0x40035EF")]
		[FieldOffset(Offset = "0x50")]
		public List<NPCAction> ActionList;

		// Token: 0x040035F0 RID: 13808
		[Token(Token = "0x40035F0")]
		[FieldOffset(Offset = "0x58")]
		[Header("Discrete Actions")]
		[SerializeField]
		private List<NPCDiscreteAction> discreteActions;

		// Token: 0x040035F2 RID: 13810
		[Token(Token = "0x40035F2")]
		[FieldOffset(Offset = "0x68")]
		protected int lastProcessedTime;
	}
}
