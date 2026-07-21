using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2000AF1")]
	public class HarvestMushroomBedBehaviour : GrowContainerBehaviour
	{
		// Token: 0x06005193 RID: 20883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005193")]
		[Address(RVA = "0x9464E0", Offset = "0x9456E0", VA = "0x1809464E0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005194")]
		[Address(RVA = "0x951920", Offset = "0x950B20", VA = "0x180951920", Slot = "35")]
		public override void AssignAndEnable(GrowContainer growContainer)
		{
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x6005195")]
		[Address(RVA = "0x951AE0", Offset = "0x950CE0", VA = "0x180951AE0", Slot = "44")]
		protected override float GetActionDuration()
		{
			return 0f;
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005196")]
		[Address(RVA = "0x951B00", Offset = "0x950D00", VA = "0x180951B00", Slot = "43")]
		protected override string GetAnimationBool()
		{
			return null;
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005197")]
		[Address(RVA = "0x84CC40", Offset = "0x84BE40", VA = "0x18084CC40", Slot = "40")]
		protected override AvatarEquippable GetActionEquippable()
		{
			return null;
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005198")]
		[Address(RVA = "0x951EA0", Offset = "0x9510A0", VA = "0x180951EA0", Slot = "42")]
		protected override void OnActionSuccess(ItemInstance usedItem)
		{
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x6005199")]
		[Address(RVA = "0x951C90", Offset = "0x950E90", VA = "0x180951C90")]
		private int GetQuantityToHarvest()
		{
			return 0;
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x00015558 File Offset: 0x00013758
		[Token(Token = "0x600519A")]
		[Address(RVA = "0x951770", Offset = "0x950970", VA = "0x180951770", Slot = "36")]
		public override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x600519B")]
		[Address(RVA = "0x951A20", Offset = "0x950C20", VA = "0x180951A20", Slot = "45")]
		protected override bool CheckSuccess(ItemInstance usedItem)
		{
			return default(bool);
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x600519C")]
		[Address(RVA = "0x951A80", Offset = "0x950C80", VA = "0x180951A80")]
		public bool DoesMushroomBedHaveValidDestination(MushroomBed bed)
		{
			return default(bool);
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x600519D")]
		[Address(RVA = "0x951B30", Offset = "0x950D30", VA = "0x180951B30")]
		private int GetDestinationCapacityForItem(MushroomBed bed, ItemInstance item)
		{
			return 0;
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519E")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public HarvestMushroomBedBehaviour()
		{
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600519F")]
		[Address(RVA = "0x951E70", Offset = "0x951070", VA = "0x180951E70", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A0")]
		[Address(RVA = "0x951E40", Offset = "0x951040", VA = "0x180951E40", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A1")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A2")]
		[Address(RVA = "0x951A10", Offset = "0x950C10", VA = "0x180951A10", Slot = "48")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040037E5 RID: 14309
		[Token(Token = "0x40037E5")]
		[FieldOffset(Offset = "0x1A0")]
		public AvatarEquippable TrimmersEquippable;

		// Token: 0x040037E6 RID: 14310
		[Token(Token = "0x40037E6")]
		[FieldOffset(Offset = "0x1A8")]
		private MushroomBed _bed;

		// Token: 0x040037E7 RID: 14311
		[Token(Token = "0x40037E7")]
		[FieldOffset(Offset = "0x1B0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040037E8 RID: 14312
		[Token(Token = "0x40037E8")]
		[FieldOffset(Offset = "0x1B1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviourAssembly-CSharp.dll_Excuted;
	}
}
