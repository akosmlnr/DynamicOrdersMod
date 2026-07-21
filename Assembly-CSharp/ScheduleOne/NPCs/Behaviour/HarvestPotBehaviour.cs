using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AF2 RID: 2802
	[Token(Token = "0x2000AF2")]
	public class HarvestPotBehaviour : GrowContainerBehaviour
	{
		// Token: 0x060051A3 RID: 20899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A3")]
		[Address(RVA = "0x9464E0", Offset = "0x9456E0", VA = "0x1809464E0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A4")]
		[Address(RVA = "0x952300", Offset = "0x951500", VA = "0x180952300", Slot = "35")]
		public override void AssignAndEnable(GrowContainer growContainer)
		{
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x60051A5")]
		[Address(RVA = "0x9524C0", Offset = "0x9516C0", VA = "0x1809524C0", Slot = "44")]
		protected override float GetActionDuration()
		{
			return 0f;
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051A6")]
		[Address(RVA = "0x9524E0", Offset = "0x9516E0", VA = "0x1809524E0", Slot = "43")]
		protected override string GetAnimationBool()
		{
			return null;
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60051A7")]
		[Address(RVA = "0x84CC40", Offset = "0x84BE40", VA = "0x18084CC40", Slot = "40")]
		protected override AvatarEquippable GetActionEquippable()
		{
			return null;
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A8")]
		[Address(RVA = "0x952840", Offset = "0x951A40", VA = "0x180952840", Slot = "42")]
		protected override void OnActionSuccess(ItemInstance usedItem)
		{
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x000155D0 File Offset: 0x000137D0
		[Token(Token = "0x60051A9")]
		[Address(RVA = "0x952670", Offset = "0x951870", VA = "0x180952670")]
		private int GetQuantityToHarvest()
		{
			return 0;
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x60051AA")]
		[Address(RVA = "0x952140", Offset = "0x951340", VA = "0x180952140", Slot = "36")]
		public override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x00015600 File Offset: 0x00013800
		[Token(Token = "0x60051AB")]
		[Address(RVA = "0x9523F0", Offset = "0x9515F0", VA = "0x1809523F0", Slot = "45")]
		protected override bool CheckSuccess(ItemInstance usedItem)
		{
			return default(bool);
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x60051AC")]
		[Address(RVA = "0x952460", Offset = "0x951660", VA = "0x180952460")]
		public bool DoesPotHaveValidDestination(Pot pot)
		{
			return default(bool);
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x00015630 File Offset: 0x00013830
		[Token(Token = "0x60051AD")]
		[Address(RVA = "0x952510", Offset = "0x951710", VA = "0x180952510")]
		private int GetDestinationCapacityForItem(Pot pot, ItemInstance item)
		{
			return 0;
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AE")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public HarvestPotBehaviour()
		{
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AF")]
		[Address(RVA = "0x951E70", Offset = "0x951070", VA = "0x180951E70", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B0")]
		[Address(RVA = "0x951E40", Offset = "0x951040", VA = "0x180951E40", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B1")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B2")]
		[Address(RVA = "0x951A10", Offset = "0x950C10", VA = "0x180951A10", Slot = "48")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.HarvestPotBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040037E9 RID: 14313
		[Token(Token = "0x40037E9")]
		[FieldOffset(Offset = "0x1A0")]
		public AvatarEquippable TrimmersEquippable;

		// Token: 0x040037EA RID: 14314
		[Token(Token = "0x40037EA")]
		[FieldOffset(Offset = "0x1A8")]
		private Pot _pot;

		// Token: 0x040037EB RID: 14315
		[Token(Token = "0x40037EB")]
		[FieldOffset(Offset = "0x1B0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HarvestPotBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040037EC RID: 14316
		[Token(Token = "0x40037EC")]
		[FieldOffset(Offset = "0x1B1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HarvestPotBehaviourAssembly-CSharp.dll_Excuted;
	}
}
