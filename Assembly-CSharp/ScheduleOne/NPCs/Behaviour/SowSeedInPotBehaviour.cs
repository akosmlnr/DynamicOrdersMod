using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Trash;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AFE RID: 2814
	[Token(Token = "0x2000AFE")]
	public class SowSeedInPotBehaviour : GrowContainerBehaviour
	{
		// Token: 0x0600523B RID: 21051 RVA: 0x000158A0 File Offset: 0x00013AA0
		[Token(Token = "0x600523B")]
		[Address(RVA = "0x9471B0", Offset = "0x9463B0", VA = "0x1809471B0", Slot = "44")]
		protected override float GetActionDuration()
		{
			return 0f;
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600523C")]
		[Address(RVA = "0x957550", Offset = "0x956750", VA = "0x180957550", Slot = "43")]
		protected override string GetAnimationBool()
		{
			return null;
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600523D")]
		[Address(RVA = "0x9577E0", Offset = "0x9569E0", VA = "0x1809577E0", Slot = "37")]
		protected override void OnStartPerformAction()
		{
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600523E")]
		[Address(RVA = "0x957820", Offset = "0x956A20", VA = "0x180957820", Slot = "38")]
		protected override void OnStopPerformAction()
		{
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600523F")]
		[Address(RVA = "0x957580", Offset = "0x956780", VA = "0x180957580", Slot = "46")]
		protected override string[] GetRequiredItemSuitableIDs(GrowContainer growContainer)
		{
			return null;
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005240")]
		[Address(RVA = "0x957740", Offset = "0x956940", VA = "0x180957740", Slot = "42")]
		protected override void OnActionSuccess(ItemInstance usedItem)
		{
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x000158B8 File Offset: 0x00013AB8
		[Token(Token = "0x6005241")]
		[Address(RVA = "0x9574A0", Offset = "0x9566A0", VA = "0x1809574A0", Slot = "36")]
		public override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			return default(bool);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005242")]
		[Address(RVA = "0x957660", Offset = "0x956860", VA = "0x180957660", Slot = "41")]
		protected override TrashItem GetTrashPrefab(ItemInstance usedItem)
		{
			return null;
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005243")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public SowSeedInPotBehaviour()
		{
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005244")]
		[Address(RVA = "0x9468C0", Offset = "0x945AC0", VA = "0x1809468C0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005245")]
		[Address(RVA = "0x946890", Offset = "0x945A90", VA = "0x180946890", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005246")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005247")]
		[Address(RVA = "0x9464E0", Offset = "0x9456E0", VA = "0x1809464E0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003823 RID: 14371
		[Token(Token = "0x4003823")]
		[FieldOffset(Offset = "0x1A0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SowSeedInPotBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003824 RID: 14372
		[Token(Token = "0x4003824")]
		[FieldOffset(Offset = "0x1A1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SowSeedInPotBehaviourAssembly-CSharp.dll_Excuted;
	}
}
