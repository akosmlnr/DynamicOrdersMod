using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B0D RID: 2829
	[Token(Token = "0x2000B0D")]
	public class WaterPotBehaviour : GrowContainerBehaviour
	{
		// Token: 0x06005319 RID: 21273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005319")]
		[Address(RVA = "0x9464E0", Offset = "0x9456E0", VA = "0x1809464E0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x00015B70 File Offset: 0x00013D70
		[Token(Token = "0x600531A")]
		[Address(RVA = "0x946530", Offset = "0x945730", VA = "0x180946530", Slot = "44")]
		protected override float GetActionDuration()
		{
			return 0f;
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600531B")]
		[Address(RVA = "0x9780E0", Offset = "0x9772E0", VA = "0x1809780E0", Slot = "43")]
		protected override string GetAnimationBool()
		{
			return null;
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600531C")]
		[Address(RVA = "0x84CC40", Offset = "0x84BE40", VA = "0x18084CC40", Slot = "40")]
		protected override AvatarEquippable GetActionEquippable()
		{
			return null;
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600531D")]
		[Address(RVA = "0x978150", Offset = "0x977350", VA = "0x180978150", Slot = "42")]
		protected override void OnActionSuccess(ItemInstance usedItem)
		{
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x00015B88 File Offset: 0x00013D88
		[Token(Token = "0x600531E")]
		[Address(RVA = "0x978050", Offset = "0x977250", VA = "0x180978050", Slot = "36")]
		public override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x00015BA0 File Offset: 0x00013DA0
		[Token(Token = "0x600531F")]
		[Address(RVA = "0x977FE0", Offset = "0x9771E0", VA = "0x180977FE0", Slot = "48")]
		public virtual bool AreTaskConditionsMetForContainer(GrowContainer container, float wateringThreshold)
		{
			return default(bool);
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005320")]
		[Address(RVA = "0x9781C0", Offset = "0x9773C0", VA = "0x1809781C0")]
		public WaterPotBehaviour()
		{
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005321")]
		[Address(RVA = "0x978130", Offset = "0x977330", VA = "0x180978130", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005322")]
		[Address(RVA = "0x978110", Offset = "0x977310", VA = "0x180978110", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005323")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005324")]
		[Address(RVA = "0x951A10", Offset = "0x950C10", VA = "0x180951A10", Slot = "49")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.WaterPotBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003874 RID: 14452
		[Token(Token = "0x4003874")]
		[FieldOffset(Offset = "0x1A0")]
		public AvatarEquippable Equippable;

		// Token: 0x04003875 RID: 14453
		[Token(Token = "0x4003875")]
		[FieldOffset(Offset = "0x1A8")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.WaterPotBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003876 RID: 14454
		[Token(Token = "0x4003876")]
		[FieldOffset(Offset = "0x1A9")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.WaterPotBehaviourAssembly-CSharp.dll_Excuted;
	}
}
