using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.NPCs.Other;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B2B RID: 2859
	[Token(Token = "0x2000B2B")]
	public class SmokeBreakBehaviour : Behaviour
	{
		// Token: 0x060054D0 RID: 21712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D0")]
		[Address(RVA = "0x989E40", Offset = "0x989040", VA = "0x180989E40")]
		private void SetupEvents()
		{
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D1")]
		[Address(RVA = "0x989840", Offset = "0x988A40", VA = "0x180989840")]
		private void CleanUp()
		{
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D2")]
		[Address(RVA = "0x989B90", Offset = "0x988D90", VA = "0x180989B90", Slot = "20")]
		public override void Enable()
		{
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D3")]
		[Address(RVA = "0x988F40", Offset = "0x988140", VA = "0x180988F40", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D4")]
		[Address(RVA = "0x989AB0", Offset = "0x988CB0", VA = "0x180989AB0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D5")]
		[Address(RVA = "0x989520", Offset = "0x988720", VA = "0x180989520")]
		private void BeginSmokeBreak()
		{
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0x989C60", Offset = "0x988E60", VA = "0x180989C60")]
		private void EndSmokeBreak()
		{
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D7")]
		[Address(RVA = "0x989820", Offset = "0x988A20", VA = "0x180989820")]
		private void CheckSmokeBreakEnd()
		{
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D8")]
		[Address(RVA = "0x98A200", Offset = "0x989400", VA = "0x18098A200")]
		private void UpdateSmokeBreakDuration(int amount)
		{
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D9")]
		[Address(RVA = "0x98A230", Offset = "0x989430", VA = "0x18098A230", Slot = "31")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DA")]
		[Address(RVA = "0x989D90", Offset = "0x988F90", VA = "0x180989D90")]
		private void OnTimeSkipped(int skippedTimeInMintues)
		{
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DB")]
		[Address(RVA = "0x989D60", Offset = "0x988F60", VA = "0x180989D60")]
		private void OnHourPass()
		{
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DC")]
		[Address(RVA = "0x989720", Offset = "0x988920", VA = "0x180989720")]
		[Button]
		public void ChangeLocation()
		{
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DD")]
		[Address(RVA = "0x988F20", Offset = "0x988120", VA = "0x180988F20")]
		[Button]
		public void ActivateSmokeBreak()
		{
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DE")]
		[Address(RVA = "0x98A270", Offset = "0x989470", VA = "0x18098A270")]
		public SmokeBreakBehaviour()
		{
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E0")]
		[Address(RVA = "0x989D40", Offset = "0x988F40", VA = "0x180989D40", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E1")]
		[Address(RVA = "0x989D20", Offset = "0x988F20", VA = "0x180989D20", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E2")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E3")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003936 RID: 14646
		[Token(Token = "0x4003936")]
		[FieldOffset(Offset = "0x168")]
		[Header("Components")]
		public SmokeCigarette SmokeCigarette;

		// Token: 0x04003937 RID: 14647
		[Token(Token = "0x4003937")]
		[FieldOffset(Offset = "0x170")]
		[Header("Smoke Break Settings")]
		public Vector2Int MinMaxSmokeBreak;

		// Token: 0x04003938 RID: 14648
		[Token(Token = "0x4003938")]
		[FieldOffset(Offset = "0x178")]
		public float maxDistanceToSmokeLocation;

		// Token: 0x04003939 RID: 14649
		[Token(Token = "0x4003939")]
		[FieldOffset(Offset = "0x180")]
		[Header("Smoking Locations")]
		public List<Transform> SmokeBreakLocations;

		// Token: 0x0400393A RID: 14650
		[Token(Token = "0x400393A")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Header("Debug")]
		private bool _debugMode;

		// Token: 0x0400393B RID: 14651
		[Token(Token = "0x400393B")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private int _ocationOverride;

		// Token: 0x0400393C RID: 14652
		[Token(Token = "0x400393C")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private bool _showMaxDistance;

		// Token: 0x0400393D RID: 14653
		[Token(Token = "0x400393D")]
		[FieldOffset(Offset = "0x191")]
		[SerializeField]
		private bool _showLocationGizmos;

		// Token: 0x0400393E RID: 14654
		[Token(Token = "0x400393E")]
		[FieldOffset(Offset = "0x192")]
		[SerializeField]
		private bool _showLookAtGizmos;

		// Token: 0x0400393F RID: 14655
		[Token(Token = "0x400393F")]
		[FieldOffset(Offset = "0x194")]
		private int _smokeBreakDuration;

		// Token: 0x04003940 RID: 14656
		[Token(Token = "0x4003940")]
		[FieldOffset(Offset = "0x198")]
		private Transform _currentSmokeLocation;

		// Token: 0x04003941 RID: 14657
		[Token(Token = "0x4003941")]
		[FieldOffset(Offset = "0x1A0")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SmokeBreakBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003942 RID: 14658
		[Token(Token = "0x4003942")]
		[FieldOffset(Offset = "0x1A1")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SmokeBreakBehaviourAssembly-CSharp.dll_Excuted;
	}
}
