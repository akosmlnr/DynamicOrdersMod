using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Trash;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000ADE RID: 2782
	[Token(Token = "0x2000ADE")]
	public class ApplyAdditiveToGrowContainerBehaviour : GrowContainerBehaviour
	{
		// Token: 0x06005099 RID: 20633 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x6005099")]
		[Address(RVA = "0x946530", Offset = "0x945730", VA = "0x180946530", Slot = "44")]
		protected override float GetActionDuration()
		{
			return 0f;
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600509A")]
		[Address(RVA = "0x946C30", Offset = "0x945E30", VA = "0x180946C30", Slot = "43")]
		protected override string GetAnimationBool()
		{
			return null;
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600509B")]
		[Address(RVA = "0x946B40", Offset = "0x945D40", VA = "0x180946B40", Slot = "40")]
		protected override AvatarEquippable GetActionEquippable()
		{
			return null;
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600509C")]
		[Address(RVA = "0x946C60", Offset = "0x945E60", VA = "0x180946C60", Slot = "46")]
		protected override string[] GetRequiredItemSuitableIDs(GrowContainer growContainer)
		{
			return null;
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509D")]
		[Address(RVA = "0x9470C0", Offset = "0x9462C0", VA = "0x1809470C0", Slot = "42")]
		protected override void OnActionSuccess(ItemInstance usedItem)
		{
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x000151E0 File Offset: 0x000133E0
		[Token(Token = "0x600509E")]
		[Address(RVA = "0x946A00", Offset = "0x945C00", VA = "0x180946A00", Slot = "36")]
		public override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600509F")]
		[Address(RVA = "0x946F70", Offset = "0x946170", VA = "0x180946F70", Slot = "41")]
		protected override TrashItem GetTrashPrefab(ItemInstance usedItem)
		{
			return null;
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public ApplyAdditiveToGrowContainerBehaviour()
		{
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A1")]
		[Address(RVA = "0x9468C0", Offset = "0x945AC0", VA = "0x1809468C0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A2")]
		[Address(RVA = "0x946890", Offset = "0x945A90", VA = "0x180946890", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A3")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A4")]
		[Address(RVA = "0x9464E0", Offset = "0x9456E0", VA = "0x1809464E0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003790 RID: 14224
		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x1A0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ApplyAdditiveToGrowContainerBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003791 RID: 14225
		[Token(Token = "0x4003791")]
		[FieldOffset(Offset = "0x1A1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ApplyAdditiveToGrowContainerBehaviourAssembly-CSharp.dll_Excuted;
	}
}
