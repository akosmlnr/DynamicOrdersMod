using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B29 RID: 2857
	[Token(Token = "0x2000B29")]
	public class SewerGoblinRetrieveBehaviour : Behaviour
	{
		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C84")]
		public Player Target
		{
			[Token(Token = "0x60054B6")]
			[Address(RVA = "0x988EF0", Offset = "0x9880F0", VA = "0x180988EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x9880B0", Offset = "0x9872B0", VA = "0x1809880B0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x987FA0", Offset = "0x9871A0", VA = "0x180987FA0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B9")]
		[Address(RVA = "0x988B40", Offset = "0x987D40", VA = "0x180988B40", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x9886C0", Offset = "0x9878C0", VA = "0x1809886C0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x988B20", Offset = "0x987D20", VA = "0x180988B20", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x988B60", Offset = "0x987D60", VA = "0x180988B60")]
		private void StartBehaviour()
		{
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x988C60", Offset = "0x987E60", VA = "0x180988C60")]
		private void StopBehaviour()
		{
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x988560", Offset = "0x987760", VA = "0x180988560")]
		public void CancelRetrieve()
		{
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x9885F0", Offset = "0x9877F0", VA = "0x1809885F0")]
		private void CompleteRetrieve()
		{
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C0")]
		[Address(RVA = "0x9881C0", Offset = "0x9873C0", VA = "0x1809881C0", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x00015EB8 File Offset: 0x000140B8
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0x9888F0", Offset = "0x987AF0", VA = "0x1809888F0")]
		private bool IsTargetDestinationValid()
		{
			return default(bool);
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x00015ED0 File Offset: 0x000140D0
		[Token(Token = "0x60054C2")]
		[Address(RVA = "0x9886E0", Offset = "0x9878E0", VA = "0x1809886E0")]
		private bool GetNewDestination(out Vector3 dest)
		{
			return default(bool);
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x00015EE8 File Offset: 0x000140E8
		[Token(Token = "0x60054C3")]
		[Address(RVA = "0x988D80", Offset = "0x987F80", VA = "0x180988D80")]
		private bool WithinRangeOfTarget()
		{
			return default(bool);
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C4")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public SewerGoblinRetrieveBehaviour()
		{
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60054C5")]
		[Address(RVA = "0x988D10", Offset = "0x987F10", VA = "0x180988D10")]
		[CompilerGenerated]
		private IEnumerator <CompleteRetrieve>g__Routine|17_0()
		{
			return null;
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C6")]
		[Address(RVA = "0x988B00", Offset = "0x987D00", VA = "0x180988B00", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x988AE0", Offset = "0x987CE0", VA = "0x180988AE0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C8")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C9")]
		[Address(RVA = "0x987FC0", Offset = "0x9871C0", VA = "0x180987FC0", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400392A RID: 14634
		[Token(Token = "0x400392A")]
		public const float PROXIMITY_THRESHOLD = 2f;

		// Token: 0x0400392B RID: 14635
		[Token(Token = "0x400392B")]
		public const float TIMEOUT = 20f;

		// Token: 0x0400392C RID: 14636
		[Token(Token = "0x400392C")]
		[FieldOffset(Offset = "0x168")]
		private SewerGoblin sewerGoblin;

		// Token: 0x0400392D RID: 14637
		[Token(Token = "0x400392D")]
		[FieldOffset(Offset = "0x170")]
		public Action onRetrieveComplete;

		// Token: 0x0400392E RID: 14638
		[Token(Token = "0x400392E")]
		[FieldOffset(Offset = "0x178")]
		public Action onRetrieveCancelled;

		// Token: 0x0400392F RID: 14639
		[Token(Token = "0x400392F")]
		[FieldOffset(Offset = "0x180")]
		private float timeSinceStart;

		// Token: 0x04003930 RID: 14640
		[Token(Token = "0x4003930")]
		[FieldOffset(Offset = "0x184")]
		private bool grabbing;

		// Token: 0x04003931 RID: 14641
		[Token(Token = "0x4003931")]
		[FieldOffset(Offset = "0x185")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003932 RID: 14642
		[Token(Token = "0x4003932")]
		[FieldOffset(Offset = "0x186")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviourAssembly-CSharp.dll_Excuted;
	}
}
