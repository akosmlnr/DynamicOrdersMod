using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	public class Employee : NPC
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000757")]
		public Property AssignedProperty
		{
			[Token(Token = "0x6002A6E")]
			[Address(RVA = "0x6F2D00", Offset = "0x6F1F00", VA = "0x1806F2D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A6F")]
			[Address(RVA = "0x700530", Offset = "0x6FF730", VA = "0x180700530")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000758")]
		public int EmployeeIndex
		{
			[Token(Token = "0x6002A70")]
			[Address(RVA = "0x700490", Offset = "0x6FF690", VA = "0x180700490")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002A71")]
			[Address(RVA = "0x700550", Offset = "0x6FF750", VA = "0x180700550")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000759")]
		public bool PaidForToday
		{
			[Token(Token = "0x6002A72")]
			[Address(RVA = "0x700500", Offset = "0x6FF700", VA = "0x180700500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A73")]
			[Address(RVA = "0x700580", Offset = "0x6FF780", VA = "0x180700580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700075A")]
		public bool Fired
		{
			[Token(Token = "0x6002A74")]
			[Address(RVA = "0x7004B0", Offset = "0x6FF6B0", VA = "0x1807004B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A75")]
			[Address(RVA = "0x700560", Offset = "0x6FF760", VA = "0x180700560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x0000D800 File Offset: 0x0000BA00
		[Token(Token = "0x1700075B")]
		public bool IsWaitingOutside
		{
			[Token(Token = "0x6002A76")]
			[Address(RVA = "0x7004D0", Offset = "0x6FF6D0", VA = "0x1807004D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x0000D818 File Offset: 0x0000BA18
		// (set) Token: 0x06002A78 RID: 10872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700075C")]
		public bool IsMale
		{
			[Token(Token = "0x6002A77")]
			[Address(RVA = "0x7004C0", Offset = "0x6FF6C0", VA = "0x1807004C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A78")]
			[Address(RVA = "0x700570", Offset = "0x6FF770", VA = "0x180700570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x0000D830 File Offset: 0x0000BA30
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700075D")]
		private protected int AppearanceIndex
		{
			[Token(Token = "0x6002A79")]
			[Address(RVA = "0x700460", Offset = "0x6FF660", VA = "0x180700460")]
			[CompilerGenerated]
			protected get
			{
				return 0;
			}
			[Token(Token = "0x6002A7A")]
			[Address(RVA = "0x700520", Offset = "0x6FF720", VA = "0x180700520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x0000D848 File Offset: 0x0000BA48
		[Token(Token = "0x1700075E")]
		public EEmployeeType EmployeeType
		{
			[Token(Token = "0x6002A7B")]
			[Address(RVA = "0x7004A0", Offset = "0x6FF6A0", VA = "0x1807004A0")]
			get
			{
				return EEmployeeType.Botanist;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x0000D860 File Offset: 0x0000BA60
		[Token(Token = "0x1700075F")]
		public float CurrentWorkSpeed
		{
			[Token(Token = "0x6002A7C")]
			[Address(RVA = "0x700470", Offset = "0x6FF670", VA = "0x180700470")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x0000D878 File Offset: 0x0000BA78
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000760")]
		public int TicksSinceLastWork
		{
			[Token(Token = "0x6002A7D")]
			[Address(RVA = "0x700510", Offset = "0x6FF710", VA = "0x180700510")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002A7E")]
			[Address(RVA = "0x700610", Offset = "0x6FF810", VA = "0x180700610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x6FB390", Offset = "0x6FA590", VA = "0x1806FB390", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A80")]
		[Address(RVA = "0x6FF1B0", Offset = "0x6FE3B0", VA = "0x1806FF1B0", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A81")]
		[Address(RVA = "0x6FD2A0", Offset = "0x6FC4A0", VA = "0x1806FD2A0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A82")]
		[Address(RVA = "0x6FD1B0", Offset = "0x6FC3B0", VA = "0x1806FD1B0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x6FC620", Offset = "0x6FB820", VA = "0x1806FC620", Slot = "130")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x6FB1C0", Offset = "0x6FA3C0", VA = "0x1806FB1C0", Slot = "131")]
		protected virtual void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A85")]
		[Address(RVA = "0x6FFCF0", Offset = "0x6FEEF0", VA = "0x1806FFCF0", Slot = "132")]
		protected virtual void UnassignProperty()
		{
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A86")]
		[Address(RVA = "0x6FEB00", Offset = "0x6FDD00", VA = "0x1806FEB00")]
		[ServerRpc(RequireOwnership = false)]
		public void SendTransfer(string propertyCode)
		{
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x6FDAE0", Offset = "0x6FCCE0", VA = "0x1806FDAE0")]
		[ObserversRpc]
		private void TransferToProperty(string code)
		{
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x6FFA80", Offset = "0x6FEC80", VA = "0x1806FFA80", Slot = "133")]
		protected virtual void TransferToProperty(Property prop)
		{
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A89")]
		[Address(RVA = "0x6FC410", Offset = "0x6FB610", VA = "0x1806FC410", Slot = "134")]
		protected virtual void InitializeInfo(string firstName, string lastName, string id)
		{
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x6FBF60", Offset = "0x6FB160", VA = "0x1806FBF60", Slot = "135")]
		protected virtual void InitializeAppearance(bool male, int index)
		{
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8B")]
		[Address(RVA = "0x6FB6A0", Offset = "0x6FA8A0", VA = "0x1806FB6A0", Slot = "136")]
		protected virtual void CheckDialogueChoice(string choiceLabel)
		{
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x6FE9F0", Offset = "0x6FDBF0", VA = "0x1806FE9F0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendFire()
		{
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x6FD520", Offset = "0x6FC720", VA = "0x1806FD520")]
		[ObserversRpc]
		private void ReceiveFire()
		{
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "137")]
		protected virtual void ResetConfiguration()
		{
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x6FB7F0", Offset = "0x6FA9F0", VA = "0x1806FB7F0", Slot = "138")]
		protected virtual void Fire()
		{
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x0000D890 File Offset: 0x0000BA90
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x6FB5C0", Offset = "0x6FA7C0", VA = "0x1806FB5C0")]
		protected bool CanWork()
		{
			return default(bool);
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x6FB460", Offset = "0x6FA660", VA = "0x1806FB460", Slot = "139")]
		protected virtual bool CanConsumeProduct()
		{
			return default(bool);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x6FB940", Offset = "0x6FAB40", VA = "0x1806FB940")]
		protected ItemSlot GetFirstInventorySlotContainingProduct()
		{
			return null;
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x6FCF30", Offset = "0x6FC130", VA = "0x1806FCF30", Slot = "89")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x6FFDA0", Offset = "0x6FEFA0", VA = "0x1806FFDA0", Slot = "140")]
		protected virtual void UpdateBehaviour()
		{
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A95")]
		[Address(RVA = "0x7000B0", Offset = "0x6FF2B0", VA = "0x1807000B0")]
		private void UpdateConsumeProduct()
		{
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A96")]
		[Address(RVA = "0x6FCB70", Offset = "0x6FBD70", VA = "0x1806FCB70")]
		protected void MarkIsWorking()
		{
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[Token(Token = "0x6002A97")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "141")]
		protected virtual bool IsAnyWorkInProgress()
		{
			return default(bool);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A98")]
		[Address(RVA = "0x6FF0C0", Offset = "0x6FE2C0", VA = "0x1806FF0C0")]
		private void SetWaitOutside(bool wait)
		{
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		[Token(Token = "0x6002A99")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "142")]
		protected virtual bool ShouldIdle()
		{
			return default(bool);
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0x6FD350", Offset = "0x6FC550", VA = "0x1806FD350", Slot = "92")]
		protected override void OnTick()
		{
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0x6FD1A0", Offset = "0x6FC3A0", VA = "0x1806FD1A0")]
		private void OnSleepEnd()
		{
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x6FF0B0", Offset = "0x6FE2B0", VA = "0x1806FF0B0")]
		public void SetIsPaid()
		{
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "112")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x6FBAD0", Offset = "0x6FACD0", VA = "0x1806FBAD0", Slot = "116")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x6FBA70", Offset = "0x6FAC70", VA = "0x1806FBA70", Slot = "143")]
		public virtual EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0000D908 File Offset: 0x0000BB08
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x6FC9D0", Offset = "0x6FBBD0", VA = "0x1806FC9D0")]
		public bool IsPayAvailable()
		{
			return default(bool);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x6FD640", Offset = "0x6FC840", VA = "0x1806FD640")]
		public void RemoveDailyWage()
		{
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0000D920 File Offset: 0x0000BB20
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x6FBCC0", Offset = "0x6FAEC0", VA = "0x1806FBCC0", Slot = "144")]
		public virtual bool GetWorkIssue(out DialogueContainer notWorkingReason)
		{
			return default(bool);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x6FF0A0", Offset = "0x6FE2A0", VA = "0x1806FF0A0", Slot = "145")]
		public virtual void SetIdle(bool idle)
		{
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x6FCA70", Offset = "0x6FBC70", VA = "0x1806FCA70")]
		protected void LeavePropertyAndDespawn()
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x6FF620", Offset = "0x6FE820", VA = "0x1806FF620")]
		[ObserversRpc(RunLocally = true)]
		public void SubmitNoWorkReason(string reason, string fix, int priority = 0)
		{
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x0000D938 File Offset: 0x0000BB38
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x6FF150", Offset = "0x6FE350", VA = "0x1806FF150")]
		private bool ShouldShowNoWorkDialogue(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x6FD140", Offset = "0x6FC340", VA = "0x1806FD140")]
		private void OnNotWorkingDialogue()
		{
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0000D950 File Offset: 0x0000BB50
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x6FF140", Offset = "0x6FE340", VA = "0x1806FF140")]
		private bool ShouldShowFireDialogue(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x6FF8C0", Offset = "0x6FEAC0", VA = "0x1806FF8C0")]
		private void TradeItems()
		{
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x6FF7C0", Offset = "0x6FE9C0", VA = "0x1806FF7C0")]
		private void TradeItemsDone()
		{
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x6FEE00", Offset = "0x6FE000", VA = "0x1806FEE00")]
		protected void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x6FEEB0", Offset = "0x6FE0B0", VA = "0x1806FEEB0")]
		protected void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x700330", Offset = "0x6FF530", VA = "0x180700330", Slot = "146")]
		protected virtual void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x700380", Offset = "0x6FF580", VA = "0x180700380")]
		public Employee()
		{
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB0")]
		[Address(RVA = "0x6FCBE0", Offset = "0x6FBDE0", VA = "0x1806FCBE0", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0x6FCB80", Offset = "0x6FBD80", VA = "0x1806FCB80", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x6FE6A0", Offset = "0x6FD8A0", VA = "0x1806FE6A0")]
		private void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x6FD6F0", Offset = "0x6FC8F0", VA = "0x1806FD6F0", Slot = "147")]
		public virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x6FDF30", Offset = "0x6FD130", VA = "0x1806FDF30")]
		private void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x6FEC30", Offset = "0x6FDE30", VA = "0x1806FEC30")]
		private void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0x6FE570", Offset = "0x6FD770", VA = "0x1806FE570")]
		private void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0x6FEB00", Offset = "0x6FDD00", VA = "0x1806FEB00")]
		private void RpcWriter___Server_SendTransfer_3615296227(string propertyCode)
		{
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0x6FDAE0", Offset = "0x6FCCE0", VA = "0x1806FDAE0")]
		public void RpcLogic___SendTransfer_3615296227(string propertyCode)
		{
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0x6FE400", Offset = "0x6FD600", VA = "0x1806FE400")]
		private void RpcReader___Server_SendTransfer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0x6FDAE0", Offset = "0x6FCCE0", VA = "0x1806FDAE0")]
		private void RpcWriter___Observers_TransferToProperty_3615296227(string code)
		{
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABC")]
		[Address(RVA = "0x6FDDE0", Offset = "0x6FCFE0", VA = "0x1806FDDE0")]
		private void RpcLogic___TransferToProperty_3615296227(string code)
		{
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABD")]
		[Address(RVA = "0x6FE150", Offset = "0x6FD350", VA = "0x1806FE150")]
		private void RpcReader___Observers_TransferToProperty_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0x6FE9F0", Offset = "0x6FDBF0", VA = "0x1806FE9F0")]
		private void RpcWriter___Server_SendFire_2166136261()
		{
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x6FD520", Offset = "0x6FC720", VA = "0x1806FD520")]
		public void RpcLogic___SendFire_2166136261()
		{
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x6FE2D0", Offset = "0x6FD4D0", VA = "0x1806FE2D0")]
		private void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x6FD520", Offset = "0x6FC720", VA = "0x1806FD520")]
		private void RpcWriter___Observers_ReceiveFire_2166136261()
		{
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x6FDAC0", Offset = "0x6FCCC0", VA = "0x1806FDAC0")]
		private void RpcLogic___ReceiveFire_2166136261()
		{
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x6FE060", Offset = "0x6FD260", VA = "0x1806FE060")]
		private void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x6FE870", Offset = "0x6FDA70", VA = "0x1806FE870")]
		private void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0x6FDC20", Offset = "0x6FCE20", VA = "0x1806FDC20")]
		public void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0x6FE0A0", Offset = "0x6FD2A0", VA = "0x1806FE0A0")]
		private void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0000D968 File Offset: 0x0000BB68
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000761")]
		public bool SyncAccessor_<PaidForToday>k__BackingField
		{
			[Token(Token = "0x6002AC7")]
			[Address(RVA = "0x700500", Offset = "0x6FF700", VA = "0x180700500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002AC8")]
			[Address(RVA = "0x700620", Offset = "0x6FF820", VA = "0x180700620")]
			set
			{
			}
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x0000D980 File Offset: 0x0000BB80
		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x6FD3E0", Offset = "0x6FC5E0", VA = "0x1806FD3E0", Slot = "148")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Employee(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x6FB2F0", Offset = "0x6FA4F0", VA = "0x1806FB2F0", Slot = "149")]
		protected virtual void Awake_UserLogic_ScheduleOne.Employees.Employee_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001FFA RID: 8186
		[Token(Token = "0x4001FFA")]
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		// Token: 0x04001FFB RID: 8187
		[Token(Token = "0x4001FFB")]
		[FieldOffset(Offset = "0x328")]
		public bool DEBUG;

		// Token: 0x04002002 RID: 8194
		[Token(Token = "0x4002002")]
		[FieldOffset(Offset = "0x344")]
		[SerializeField]
		protected EEmployeeType Type;

		// Token: 0x04002003 RID: 8195
		[Token(Token = "0x4002003")]
		[FieldOffset(Offset = "0x348")]
		public FloatStack WorkSpeedController;

		// Token: 0x04002004 RID: 8196
		[Token(Token = "0x4002004")]
		[FieldOffset(Offset = "0x350")]
		[Header("Payment")]
		public float SigningFee;

		// Token: 0x04002005 RID: 8197
		[Token(Token = "0x4002005")]
		[FieldOffset(Offset = "0x354")]
		public float DailyWage;

		// Token: 0x04002006 RID: 8198
		[Token(Token = "0x4002006")]
		[FieldOffset(Offset = "0x358")]
		[Header("References")]
		public IdleBehaviour WaitOutside;

		// Token: 0x04002007 RID: 8199
		[Token(Token = "0x4002007")]
		[FieldOffset(Offset = "0x360")]
		public MoveItemBehaviour MoveItemBehaviour;

		// Token: 0x04002008 RID: 8200
		[Token(Token = "0x4002008")]
		[FieldOffset(Offset = "0x368")]
		public DialogueContainer BedNotAssignedDialogue;

		// Token: 0x04002009 RID: 8201
		[Token(Token = "0x4002009")]
		[FieldOffset(Offset = "0x370")]
		public DialogueContainer NotPaidDialogue;

		// Token: 0x0400200A RID: 8202
		[Token(Token = "0x400200A")]
		[FieldOffset(Offset = "0x378")]
		public DialogueContainer WorkIssueDialogueTemplate;

		// Token: 0x0400200B RID: 8203
		[Token(Token = "0x400200B")]
		[FieldOffset(Offset = "0x380")]
		public DialogueContainer FireDialogue;

		// Token: 0x0400200C RID: 8204
		[Token(Token = "0x400200C")]
		[FieldOffset(Offset = "0x388")]
		public DialogueContainer TransferDialogue;

		// Token: 0x0400200D RID: 8205
		[Token(Token = "0x400200D")]
		[FieldOffset(Offset = "0x390")]
		private List<Employee.NoWorkReason> WorkIssues;

		// Token: 0x0400200F RID: 8207
		[Token(Token = "0x400200F")]
		[FieldOffset(Offset = "0x39C")]
		protected bool initialized;

		// Token: 0x04002010 RID: 8208
		[Token(Token = "0x4002010")]
		[FieldOffset(Offset = "0x3A0")]
		protected int consecutivePathingFailures;

		// Token: 0x04002011 RID: 8209
		[Token(Token = "0x4002011")]
		[FieldOffset(Offset = "0x3A4")]
		private float timeOnLastPathingFailure;

		// Token: 0x04002012 RID: 8210
		[Token(Token = "0x4002012")]
		[FieldOffset(Offset = "0x3A8")]
		private Transform cachedNPCSpawnPoint;

		// Token: 0x04002013 RID: 8211
		[Token(Token = "0x4002013")]
		[FieldOffset(Offset = "0x3B0")]
		public SyncVar<bool> syncVar___<PaidForToday>k__BackingField;

		// Token: 0x04002014 RID: 8212
		[Token(Token = "0x4002014")]
		[FieldOffset(Offset = "0x3B8")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted;

		// Token: 0x04002015 RID: 8213
		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0x3B9")]
		private bool NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted;

		// Token: 0x02000678 RID: 1656
		[Token(Token = "0x2000678")]
		public class NoWorkReason
		{
			// Token: 0x06002ACB RID: 10955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002ACB")]
			[Address(RVA = "0x702140", Offset = "0x701340", VA = "0x180702140")]
			public NoWorkReason(string reason, string fix, int priority)
			{
			}

			// Token: 0x04002016 RID: 8214
			[Token(Token = "0x4002016")]
			[FieldOffset(Offset = "0x10")]
			public string Reason;

			// Token: 0x04002017 RID: 8215
			[Token(Token = "0x4002017")]
			[FieldOffset(Offset = "0x18")]
			public string Fix;

			// Token: 0x04002018 RID: 8216
			[Token(Token = "0x4002018")]
			[FieldOffset(Offset = "0x20")]
			public int Priority;
		}
	}
}
