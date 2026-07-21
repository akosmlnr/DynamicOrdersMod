using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Trash;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000ADD RID: 2781
	[Token(Token = "0x2000ADD")]
	public class AddSoilToGrowContainerBehaviour : GrowContainerBehaviour
	{
		// Token: 0x0600508D RID: 20621 RVA: 0x00015198 File Offset: 0x00013398
		[Token(Token = "0x600508D")]
		[Address(RVA = "0x946530", Offset = "0x945730", VA = "0x180946530", Slot = "44")]
		protected override float GetActionDuration()
		{
			return 0f;
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600508E")]
		[Address(RVA = "0x946630", Offset = "0x945830", VA = "0x180946630", Slot = "43")]
		protected override string GetAnimationBool()
		{
			return null;
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600508F")]
		[Address(RVA = "0x946540", Offset = "0x945740", VA = "0x180946540", Slot = "40")]
		protected override AvatarEquippable GetActionEquippable()
		{
			return null;
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005090")]
		[Address(RVA = "0x946660", Offset = "0x945860", VA = "0x180946660", Slot = "46")]
		protected override string[] GetRequiredItemSuitableIDs(GrowContainer growContainer)
		{
			return null;
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005091")]
		[Address(RVA = "0x9468F0", Offset = "0x945AF0", VA = "0x1809468F0", Slot = "42")]
		protected override void OnActionSuccess(ItemInstance usedItem)
		{
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x000151B0 File Offset: 0x000133B0
		[Token(Token = "0x6005092")]
		[Address(RVA = "0x946490", Offset = "0x945690", VA = "0x180946490", Slot = "36")]
		public override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005093")]
		[Address(RVA = "0x946740", Offset = "0x945940", VA = "0x180946740", Slot = "41")]
		protected override TrashItem GetTrashPrefab(ItemInstance usedItem)
		{
			return null;
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005094")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public AddSoilToGrowContainerBehaviour()
		{
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005095")]
		[Address(RVA = "0x9468C0", Offset = "0x945AC0", VA = "0x1809468C0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005096")]
		[Address(RVA = "0x946890", Offset = "0x945A90", VA = "0x180946890", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005097")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005098")]
		[Address(RVA = "0x9464E0", Offset = "0x9456E0", VA = "0x1809464E0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400378E RID: 14222
		[Token(Token = "0x400378E")]
		[FieldOffset(Offset = "0x1A0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.AddSoilToGrowContainerBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400378F RID: 14223
		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0x1A1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.AddSoilToGrowContainerBehaviourAssembly-CSharp.dll_Excuted;
	}
}
