using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005C7 RID: 1479
	[Token(Token = "0x20005C7")]
	public class LawController : Singleton<LawController>, IBaseSaveable, ISaveable
	{
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x0000B838 File Offset: 0x00009A38
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FD")]
		public bool OverrideSettings
		{
			[Token(Token = "0x60021D6")]
			[Address(RVA = "0x674740", Offset = "0x673940", VA = "0x180674740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021D7")]
			[Address(RVA = "0x6747E0", Offset = "0x6739E0", VA = "0x1806747E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FE")]
		public LawActivitySettings OverriddenSettings
		{
			[Token(Token = "0x60021D8")]
			[Address(RVA = "0x4674F0", Offset = "0x4666F0", VA = "0x1804674F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021D9")]
			[Address(RVA = "0x6380C0", Offset = "0x6372C0", VA = "0x1806380C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FF")]
		public LawActivitySettings CurrentSettings
		{
			[Token(Token = "0x60021DA")]
			[Address(RVA = "0x4CB7C0", Offset = "0x4CA9C0", VA = "0x1804CB7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021DB")]
			[Address(RVA = "0x6380A0", Offset = "0x6372A0", VA = "0x1806380A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000600")]
		public string SaveFolderName
		{
			[Token(Token = "0x60021DC")]
			[Address(RVA = "0x674780", Offset = "0x673980", VA = "0x180674780", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000601")]
		public string SaveFileName
		{
			[Token(Token = "0x60021DD")]
			[Address(RVA = "0x674750", Offset = "0x673950", VA = "0x180674750", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000602")]
		public Loader Loader
		{
			[Token(Token = "0x60021DE")]
			[Address(RVA = "0x4E09D0", Offset = "0x4DFBD0", VA = "0x1804E09D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x0000B850 File Offset: 0x00009A50
		[Token(Token = "0x17000603")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60021DF")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000604")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60021E0")]
			[Address(RVA = "0x4CB630", Offset = "0x4CA830", VA = "0x1804CB630", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021E1")]
			[Address(RVA = "0x59B0A0", Offset = "0x59A2A0", VA = "0x18059B0A0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000605")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60021E2")]
			[Address(RVA = "0x674730", Offset = "0x673930", VA = "0x180674730", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021E3")]
			[Address(RVA = "0x6747C0", Offset = "0x6739C0", VA = "0x1806747C0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x0000B868 File Offset: 0x00009A68
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000606")]
		public bool HasChanged
		{
			[Token(Token = "0x60021E4")]
			[Address(RVA = "0x674710", Offset = "0x673910", VA = "0x180674710", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60021E5")]
			[Address(RVA = "0x6747B0", Offset = "0x6739B0", VA = "0x1806747B0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x17000607")]
		public int LoadOrder
		{
			[Token(Token = "0x60021E6")]
			[Address(RVA = "0x674720", Offset = "0x673920", VA = "0x180674720", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x673A70", Offset = "0x672C70", VA = "0x180673A70", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x673DD0", Offset = "0x672FD0", VA = "0x180673DD0", Slot = "31")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x674340", Offset = "0x673540", VA = "0x180674340", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EA")]
		[Address(RVA = "0x673ED0", Offset = "0x6730D0", VA = "0x180673ED0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x674100", Offset = "0x673300", VA = "0x180674100")]
		private void OnLoadComplete()
		{
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EC")]
		[Address(RVA = "0x6741E0", Offset = "0x6733E0", VA = "0x1806741E0")]
		private void OnUncappedMinPass()
		{
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x673B30", Offset = "0x672D30", VA = "0x180673B30")]
		private void DayPass()
		{
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60021EE")]
		[Address(RVA = "0x673CB0", Offset = "0x672EB0", VA = "0x180673CB0")]
		public LawActivitySettings GetSettings()
		{
			return null;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60021EF")]
		[Address(RVA = "0x673C50", Offset = "0x672E50", VA = "0x180673C50")]
		public LawActivitySettings GetSettings(EDay day)
		{
			return null;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F0")]
		[Address(RVA = "0x6742B0", Offset = "0x6734B0", VA = "0x1806742B0")]
		public void OverrideSetings(LawActivitySettings settings)
		{
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F1")]
		[Address(RVA = "0x673BB0", Offset = "0x672DB0", VA = "0x180673BB0")]
		public void EndOverride()
		{
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x673AC0", Offset = "0x672CC0", VA = "0x180673AC0")]
		public void ChangeInternalIntensity(float change)
		{
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x6742D0", Offset = "0x6734D0", VA = "0x1806742D0")]
		public void SetInternalIntensity(float intensity)
		{
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x673BD0", Offset = "0x672DD0", VA = "0x180673BD0", Slot = "32")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x673E60", Offset = "0x673060", VA = "0x180673E60")]
		public void Load(LawData data)
		{
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x674600", Offset = "0x673800", VA = "0x180674600")]
		public LawController()
		{
		}

		// Token: 0x04001B63 RID: 7011
		[Token(Token = "0x4001B63")]
		public const float DAILY_INTENSITY_DRAIN = 0.05f;

		// Token: 0x04001B64 RID: 7012
		[Token(Token = "0x4001B64")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 10f)]
		public int LE_Intensity;

		// Token: 0x04001B65 RID: 7013
		[Token(Token = "0x4001B65")]
		[FieldOffset(Offset = "0x2C")]
		private float internalLawIntensity;

		// Token: 0x04001B66 RID: 7014
		[Token(Token = "0x4001B66")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public LawActivitySettings MondaySettings;

		// Token: 0x04001B67 RID: 7015
		[Token(Token = "0x4001B67")]
		[FieldOffset(Offset = "0x38")]
		public LawActivitySettings TuesdaySettings;

		// Token: 0x04001B68 RID: 7016
		[Token(Token = "0x4001B68")]
		[FieldOffset(Offset = "0x40")]
		public LawActivitySettings WednesdaySettings;

		// Token: 0x04001B69 RID: 7017
		[Token(Token = "0x4001B69")]
		[FieldOffset(Offset = "0x48")]
		public LawActivitySettings ThursdaySettings;

		// Token: 0x04001B6A RID: 7018
		[Token(Token = "0x4001B6A")]
		[FieldOffset(Offset = "0x50")]
		public LawActivitySettings FridaySettings;

		// Token: 0x04001B6B RID: 7019
		[Token(Token = "0x4001B6B")]
		[FieldOffset(Offset = "0x58")]
		public LawActivitySettings SaturdaySettings;

		// Token: 0x04001B6C RID: 7020
		[Token(Token = "0x4001B6C")]
		[FieldOffset(Offset = "0x60")]
		public LawActivitySettings SundaySettings;

		// Token: 0x04001B6D RID: 7021
		[Token(Token = "0x4001B6D")]
		[FieldOffset(Offset = "0x68")]
		[Header("Demo Settings")]
		public float IntensityIncreasePerDay;

		// Token: 0x04001B71 RID: 7025
		[Token(Token = "0x4001B71")]
		[FieldOffset(Offset = "0x80")]
		private LawLoader loader;
	}
}
