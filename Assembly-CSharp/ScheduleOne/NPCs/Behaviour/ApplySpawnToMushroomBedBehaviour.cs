using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000ADF RID: 2783
	[Token(Token = "0x2000ADF")]
	public class ApplySpawnToMushroomBedBehaviour : GrowContainerBehaviour
	{
		// Token: 0x060050A5 RID: 20645 RVA: 0x000151F8 File Offset: 0x000133F8
		[Token(Token = "0x60050A5")]
		[Address(RVA = "0x9471B0", Offset = "0x9463B0", VA = "0x1809471B0", Slot = "44")]
		protected override float GetActionDuration()
		{
			return 0f;
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60050A6")]
		[Address(RVA = "0x9471C0", Offset = "0x9463C0", VA = "0x1809471C0", Slot = "43")]
		protected override string GetAnimationBool()
		{
			return null;
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x9471F0", Offset = "0x9463F0", VA = "0x1809471F0", Slot = "46")]
		protected override string[] GetRequiredItemSuitableIDs(GrowContainer growContainer)
		{
			return null;
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A8")]
		[Address(RVA = "0x9472D0", Offset = "0x9464D0", VA = "0x1809472D0", Slot = "42")]
		protected override void OnActionSuccess(ItemInstance usedItem)
		{
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x00015210 File Offset: 0x00013410
		[Token(Token = "0x60050A9")]
		[Address(RVA = "0x947100", Offset = "0x946300", VA = "0x180947100", Slot = "36")]
		public override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public ApplySpawnToMushroomBedBehaviour()
		{
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x9468C0", Offset = "0x945AC0", VA = "0x1809468C0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050AC")]
		[Address(RVA = "0x946890", Offset = "0x945A90", VA = "0x180946890", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050AE")]
		[Address(RVA = "0x9464E0", Offset = "0x9456E0", VA = "0x1809464E0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003792 RID: 14226
		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0x1A0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ApplySpawnToMushroomBedBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003793 RID: 14227
		[Token(Token = "0x4003793")]
		[FieldOffset(Offset = "0x1A1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ApplySpawnToMushroomBedBehaviourAssembly-CSharp.dll_Excuted;
	}
}
