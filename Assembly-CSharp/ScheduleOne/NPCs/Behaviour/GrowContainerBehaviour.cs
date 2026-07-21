using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Employees;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AEB RID: 2795
	[Token(Token = "0x2000AEB")]
	public abstract class GrowContainerBehaviour : Behaviour
	{
		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005153 RID: 20819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C39")]
		private protected GrowContainer _growContainer
		{
			[Token(Token = "0x6005152")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6005153")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x000153D8 File Offset: 0x000135D8
		// (set) Token: 0x06005155 RID: 20821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3A")]
		private protected GrowContainerBehaviour.EState _currentState
		{
			[Token(Token = "0x6005154")]
			[Address(RVA = "0x745880", Offset = "0x744A80", VA = "0x180745880")]
			[CompilerGenerated]
			protected get
			{
				return GrowContainerBehaviour.EState.Idle;
			}
			[Token(Token = "0x6005155")]
			[Address(RVA = "0x7458E0", Offset = "0x744AE0", VA = "0x1807458E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005157 RID: 20823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3B")]
		private protected Botanist _botanist
		{
			[Token(Token = "0x6005156")]
			[Address(RVA = "0x630310", Offset = "0x62F510", VA = "0x180630310")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6005157")]
			[Address(RVA = "0x6303C0", Offset = "0x62F5C0", VA = "0x1806303C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06005158 RID: 20824 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C3C")]
		protected BotanistConfiguration _botanistConfiguration
		{
			[Token(Token = "0x6005158")]
			[Address(RVA = "0x9516E0", Offset = "0x9508E0", VA = "0x1809516E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005159")]
		[Address(RVA = "0x950120", Offset = "0x94F320", VA = "0x180950120", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515A")]
		[Address(RVA = "0x950050", Offset = "0x94F250", VA = "0x180950050", Slot = "35")]
		public virtual void AssignAndEnable(GrowContainer growContainer)
		{
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515B")]
		[Address(RVA = "0x94FF00", Offset = "0x94F100", VA = "0x18094FF00", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515C")]
		[Address(RVA = "0x9513B0", Offset = "0x9505B0", VA = "0x1809513B0", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515D")]
		[Address(RVA = "0x9512C0", Offset = "0x9504C0", VA = "0x1809512C0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515E")]
		[Address(RVA = "0x9501E0", Offset = "0x94F3E0", VA = "0x1809501E0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x000153F0 File Offset: 0x000135F0
		[Token(Token = "0x600515F")]
		[Address(RVA = "0x94FF20", Offset = "0x94F120", VA = "0x18094FF20", Slot = "36")]
		public virtual bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x6005160")]
		[Address(RVA = "0x9504C0", Offset = "0x94F6C0", VA = "0x1809504C0")]
		public bool DoesBotanistHaveAccessToRequiredSupplies(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005161")]
		[Address(RVA = "0x950BA0", Offset = "0x94FDA0", VA = "0x180950BA0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005162")]
		[Address(RVA = "0x950FC0", Offset = "0x9501C0", VA = "0x180950FC0", Slot = "37")]
		protected virtual void OnStartPerformAction()
		{
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005163")]
		[Address(RVA = "0x951180", Offset = "0x950380", VA = "0x180951180", Slot = "38")]
		protected virtual void OnStopPerformAction()
		{
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x00015420 File Offset: 0x00013620
		[Token(Token = "0x6005164")]
		[Address(RVA = "0x950550", Offset = "0x94F750", VA = "0x180950550", Slot = "39")]
		protected virtual Vector3 GetGrowContainerLookPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005165")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "40")]
		protected virtual AvatarEquippable GetActionEquippable()
		{
			return null;
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005166")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "41")]
		protected virtual TrashItem GetTrashPrefab(ItemInstance usedItem)
		{
			return null;
		}

		// Token: 0x06005167 RID: 20839
		[Token(Token = "0x6005167")]
		protected abstract void OnActionSuccess(ItemInstance usedItem);

		// Token: 0x06005168 RID: 20840
		[Token(Token = "0x6005168")]
		protected abstract string GetAnimationBool();

		// Token: 0x06005169 RID: 20841
		[Token(Token = "0x6005169")]
		protected abstract float GetActionDuration();

		// Token: 0x0600516A RID: 20842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516A")]
		[Address(RVA = "0x951580", Offset = "0x950780", VA = "0x180951580")]
		private void WalkTo(ITransitEntity entity)
		{
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516B")]
		[Address(RVA = "0x9507F0", Offset = "0x94F9F0", VA = "0x1809507F0")]
		private void GrabRequiredItemFromSupplies()
		{
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x9512E0", Offset = "0x9504E0", VA = "0x1809512E0")]
		private void PerformAction()
		{
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00015438 File Offset: 0x00013638
		[Token(Token = "0x600516D")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "45")]
		protected virtual bool CheckSuccess(ItemInstance usedItem)
		{
			return default(bool);
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516E")]
		[Address(RVA = "0x9513D0", Offset = "0x9505D0", VA = "0x1809513D0")]
		private void StopAllRoutines()
		{
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600516F")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "46")]
		protected virtual string[] GetRequiredItemSuitableIDs(GrowContainer growContainer)
		{
			return null;
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00015450 File Offset: 0x00013650
		[Token(Token = "0x6005170")]
		[Address(RVA = "0x950510", Offset = "0x94F710", VA = "0x180950510")]
		private bool DoesTaskRequireItem(GrowContainer growContainer, out string[] suitableItemIDs)
		{
			return default(bool);
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x6005171")]
		[Address(RVA = "0x9509E0", Offset = "0x94FBE0", VA = "0x1809509E0")]
		private bool IsRequiredItemInInventory(GrowContainer growContainer)
		{
			return default(bool);
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x6005172")]
		[Address(RVA = "0x950200", Offset = "0x94F400", VA = "0x180950200")]
		private bool DoSuppliesContainRequiredItem(GrowContainer growContainer)
		{
			return default(bool);
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005173")]
		[Address(RVA = "0x9506C0", Offset = "0x94F8C0", VA = "0x1809506C0")]
		private ItemSlot GetSuppliesSlotContainingRequiredItem(string[] suitableItemIDs)
		{
			return null;
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005174")]
		[Address(RVA = "0x9505A0", Offset = "0x94F7A0", VA = "0x1809505A0")]
		protected ItemSlot GetItemSlotContainingRequiredItem(IItemSlotOwner itemSlotOwner, string[] suitableItemIDs)
		{
			return null;
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x6005175")]
		[Address(RVA = "0x950950", Offset = "0x94FB50", VA = "0x180950950")]
		private bool IsAtSupplies()
		{
			return default(bool);
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x000154B0 File Offset: 0x000136B0
		[Token(Token = "0x6005176")]
		[Address(RVA = "0x950890", Offset = "0x94FA90", VA = "0x180950890")]
		private bool IsAtGrowContainer()
		{
			return default(bool);
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005177")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		protected GrowContainerBehaviour()
		{
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005178")]
		[Address(RVA = "0x9514A0", Offset = "0x9506A0", VA = "0x1809514A0")]
		[CompilerGenerated]
		private IEnumerator <GrabRequiredItemFromSupplies>g__Routine|36_0()
		{
			return null;
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005179")]
		[Address(RVA = "0x951510", Offset = "0x950710", VA = "0x180951510")]
		[CompilerGenerated]
		private IEnumerator <PerformAction>g__Routine|37_0()
		{
			return null;
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517A")]
		[Address(RVA = "0x950B80", Offset = "0x94FD80", VA = "0x180950B80", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517B")]
		[Address(RVA = "0x950B60", Offset = "0x94FD60", VA = "0x180950B60", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517C")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517D")]
		[Address(RVA = "0x950080", Offset = "0x94F280", VA = "0x180950080", Slot = "47")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040037CE RID: 14286
		[Token(Token = "0x40037CE")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine _walkRoutine;

		// Token: 0x040037CF RID: 14287
		[Token(Token = "0x40037CF")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine _grabRoutine;

		// Token: 0x040037D0 RID: 14288
		[Token(Token = "0x40037D0")]
		[FieldOffset(Offset = "0x190")]
		private Coroutine _performActionRoutine;

		// Token: 0x040037D1 RID: 14289
		[Token(Token = "0x40037D1")]
		[FieldOffset(Offset = "0x198")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GrowContainerBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040037D2 RID: 14290
		[Token(Token = "0x40037D2")]
		[FieldOffset(Offset = "0x199")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GrowContainerBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x02000AEC RID: 2796
		[Token(Token = "0x2000AEC")]
		protected enum EState
		{
			// Token: 0x040037D4 RID: 14292
			[Token(Token = "0x40037D4")]
			Idle,
			// Token: 0x040037D5 RID: 14293
			[Token(Token = "0x40037D5")]
			Walking,
			// Token: 0x040037D6 RID: 14294
			[Token(Token = "0x40037D6")]
			GrabbingSupplies,
			// Token: 0x040037D7 RID: 14295
			[Token(Token = "0x40037D7")]
			PerformingAction
		}
	}
}
