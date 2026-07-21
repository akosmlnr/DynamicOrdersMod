using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.UI;
using ScheduleOne.Tools;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Management
{
	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	public class ManagementInterface : Singleton<ManagementInterface>
	{
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C9")]
		public ManagementClipboard_Equippable EquippedClipboard
		{
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x678DF0", Offset = "0x677FF0", VA = "0x180678DF0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x679750", Offset = "0x678950", VA = "0x180679750")]
		public void Open(List<IConfigurable> configurables, ManagementClipboard_Equippable _equippedClipboard)
		{
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x678FF0", Offset = "0x6781F0", VA = "0x180678FF0")]
		public void Close(bool preserveState = false)
		{
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x67A030", Offset = "0x679230", VA = "0x18067A030")]
		private void UpdateMainLabels()
		{
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x6793E0", Offset = "0x6785E0", VA = "0x1806793E0")]
		private void InitializeConfigPanel()
		{
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x679160", Offset = "0x678360", VA = "0x180679160")]
		private void DestroyConfigPanel()
		{
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002081")]
		[Address(RVA = "0x6792F0", Offset = "0x6784F0", VA = "0x1806792F0")]
		public ConfigPanel GetConfigPanelPrefab(EConfigurableType type)
		{
			return null;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002082")]
		[Address(RVA = "0x679AC0", Offset = "0x678CC0", VA = "0x180679AC0")]
		public void RenameButtonClicked()
		{
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002083")]
		[Address(RVA = "0x67A0C0", Offset = "0x6792C0", VA = "0x18067A0C0")]
		public ManagementInterface()
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002084")]
		[Address(RVA = "0x679DB0", Offset = "0x678FB0", VA = "0x180679DB0")]
		[CompilerGenerated]
		private void <RenameButtonClicked>g__CompleteRename|30_0(string newName)
		{
		}

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		public const float PANEL_SLIDE_TIME = 0f;

		// Token: 0x04001A5D RID: 6749
		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04001A5E RID: 6750
		[Token(Token = "0x4001A5E")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI NothingSelectedLabel;

		// Token: 0x04001A5F RID: 6751
		[Token(Token = "0x4001A5F")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI DifferentTypesSelectedLabel;

		// Token: 0x04001A60 RID: 6752
		[Token(Token = "0x4001A60")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform PanelContainer;

		// Token: 0x04001A61 RID: 6753
		[Token(Token = "0x4001A61")]
		[FieldOffset(Offset = "0x50")]
		public ClipboardScreen MainScreen;

		// Token: 0x04001A62 RID: 6754
		[Token(Token = "0x4001A62")]
		[FieldOffset(Offset = "0x58")]
		public ItemSelector ItemSelectorScreen;

		// Token: 0x04001A63 RID: 6755
		[Token(Token = "0x4001A63")]
		[FieldOffset(Offset = "0x60")]
		public NPCSelector NPCSelector;

		// Token: 0x04001A64 RID: 6756
		[Token(Token = "0x4001A64")]
		[FieldOffset(Offset = "0x68")]
		public ObjectSelector ObjectSelector;

		// Token: 0x04001A65 RID: 6757
		[Token(Token = "0x4001A65")]
		[FieldOffset(Offset = "0x70")]
		public RecipeSelector RecipeSelectorScreen;

		// Token: 0x04001A66 RID: 6758
		[Token(Token = "0x4001A66")]
		[FieldOffset(Offset = "0x78")]
		public TransitEntitySelector TransitEntitySelector;

		// Token: 0x04001A67 RID: 6759
		[Token(Token = "0x4001A67")]
		[FieldOffset(Offset = "0x80")]
		public StringSetter StringSetterScreen;

		// Token: 0x04001A68 RID: 6760
		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x88")]
		public Button RenameButton;

		// Token: 0x04001A69 RID: 6761
		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0x90")]
		[Header("Screen")]
		public UIScreen UIScreen;

		// Token: 0x04001A6A RID: 6762
		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected ManagementInterface.ConfigurableTypePanel[] ConfigPanelPrefabs;

		// Token: 0x04001A6B RID: 6763
		[Token(Token = "0x4001A6B")]
		[FieldOffset(Offset = "0xA0")]
		public List<IConfigurable> Configurables;

		// Token: 0x04001A6C RID: 6764
		[Token(Token = "0x4001A6C")]
		[FieldOffset(Offset = "0xA8")]
		private bool areConfigurablesUniform;

		// Token: 0x04001A6D RID: 6765
		[Token(Token = "0x4001A6D")]
		[FieldOffset(Offset = "0xB0")]
		private ConfigPanel loadedPanel;

		// Token: 0x0200058B RID: 1419
		[Token(Token = "0x200058B")]
		[Serializable]
		public class ConfigurableTypePanel
		{
			// Token: 0x06002085 RID: 8325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002085")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ConfigurableTypePanel()
			{
			}

			// Token: 0x04001A6E RID: 6766
			[Token(Token = "0x4001A6E")]
			[FieldOffset(Offset = "0x10")]
			public EConfigurableType Type;

			// Token: 0x04001A6F RID: 6767
			[Token(Token = "0x4001A6F")]
			[FieldOffset(Offset = "0x18")]
			public ConfigPanel Panel;
		}
	}
}
