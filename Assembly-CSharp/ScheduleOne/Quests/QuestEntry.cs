using System;
using System.Runtime.CompilerServices;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI;
using ScheduleOne.UI.Compass;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x02000330 RID: 816
	[Token(Token = "0x2000330")]
	[Serializable]
	public class QuestEntry : MonoBehaviour
	{
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040B")]
		[CodegenExclude]
		public Quest ParentQuest
		{
			[Token(Token = "0x60013DF")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013E0")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700040C")]
		[CodegenExclude]
		public string Title
		{
			[Token(Token = "0x60013E1")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x1700040D")]
		[CodegenExclude]
		public EQuestState State
		{
			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x4A63B0", Offset = "0x4A55B0", VA = "0x1804A63B0")]
			get
			{
				return EQuestState.Inactive;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x1700040E")]
		public int QuestEntryIndex
		{
			[Token(Token = "0x60013E3")]
			[Address(RVA = "0x5824A0", Offset = "0x5816A0", VA = "0x1805824A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x5803F0", Offset = "0x57F5F0", VA = "0x1805803F0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x5818E0", Offset = "0x580AE0", VA = "0x1805818E0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x580FB0", Offset = "0x5801B0", VA = "0x180580FB0")]
		private void OnValidate()
		{
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E7")]
		[Address(RVA = "0x580ED0", Offset = "0x5800D0", VA = "0x180580ED0", Slot = "6")]
		public virtual void MinPass()
		{
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E8")]
		[Address(RVA = "0x5810A0", Offset = "0x5802A0", VA = "0x1805810A0")]
		public void SetData(QuestEntryData data)
		{
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E9")]
		[Address(RVA = "0x580640", Offset = "0x57F840", VA = "0x180580640")]
		public void Begin()
		{
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x580660", Offset = "0x57F860", VA = "0x180580660")]
		public void Complete()
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x581080", Offset = "0x580280", VA = "0x180581080")]
		public void SetActive(bool network = true)
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x581340", Offset = "0x580540", VA = "0x180581340", Slot = "7")]
		public virtual void SetState(EQuestState newState, bool network = true)
		{
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x5818B0", Offset = "0x580AB0", VA = "0x1805818B0", Slot = "8")]
		protected virtual bool ShouldShowPoI()
		{
			return default(bool);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x5822A0", Offset = "0x5814A0", VA = "0x1805822A0", Slot = "9")]
		protected virtual void UpdatePoI()
		{
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x5811B0", Offset = "0x5803B0", VA = "0x1805811B0", Slot = "10")]
		public virtual void SetPoIColor(string componentName, string colourName)
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x581250", Offset = "0x580450", VA = "0x180581250")]
		public void SetPoILocation(Vector3 location)
		{
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x5809F0", Offset = "0x57FBF0", VA = "0x1805809F0")]
		public void CreatePoI()
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x580D50", Offset = "0x57FF50", VA = "0x180580D50")]
		public void DestroyPoI()
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x580680", Offset = "0x57F880", VA = "0x180580680")]
		public void CreateCompassElement()
		{
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x581F70", Offset = "0x581170", VA = "0x180581F70")]
		public void UpdateCompassElement()
		{
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x580E60", Offset = "0x580060", VA = "0x180580E60")]
		public QuestEntryData GetSaveData()
		{
			return null;
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x582060", Offset = "0x581260", VA = "0x180582060")]
		private void UpdateName()
		{
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x580E00", Offset = "0x580000", VA = "0x180580E00")]
		private void EvaluateConditions()
		{
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x581100", Offset = "0x580300", VA = "0x180581100")]
		public void SetEntryTitle(string newTitle)
		{
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x5807B0", Offset = "0x57F9B0", VA = "0x1805807B0", Slot = "11")]
		protected virtual void CreateEntryUI()
		{
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x582030", Offset = "0x581230", VA = "0x180582030", Slot = "12")]
		public virtual void UpdateEntryUI()
		{
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x582350", Offset = "0x581550", VA = "0x180582350")]
		public QuestEntry()
		{
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x581D50", Offset = "0x580F50", VA = "0x180581D50")]
		[CompilerGenerated]
		private void <CreatePoI>g__CreateUI|40_0()
		{
		}

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x28")]
		[Header("Naming")]
		[SerializeField]
		protected string EntryTitle;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected EQuestState state;

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x34")]
		[Header("Settings")]
		public bool AutoComplete;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x38")]
		public Conditions AutoCompleteConditions;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x40")]
		public bool CompleteParentQuest;

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x48")]
		public string EntryAddedIn;

		// Token: 0x04001248 RID: 4680
		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x50")]
		[Header("PoI Settings")]
		public bool AutoCreatePoI;

		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x58")]
		public Transform PoILocation;

		// Token: 0x0400124A RID: 4682
		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0x60")]
		public bool AutoUpdatePoILocation;

		// Token: 0x0400124B RID: 4683
		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0x68")]
		public POI PoI;

		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent onStart;

		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onEnd;

		// Token: 0x0400124E RID: 4686
		[Token(Token = "0x400124E")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onComplete;

		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent onInitialComplete;

		// Token: 0x04001250 RID: 4688
		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0x90")]
		private CompassManager.Element compassElement;

		// Token: 0x04001251 RID: 4689
		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0x98")]
		private QuestEntryHUDUI entryUI;

		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform PoIIcon;
	}
}
