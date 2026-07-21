using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B01 RID: 2817
	[Token(Token = "0x2000B01")]
	public class StartChemistryStationBehaviour : Behaviour
	{
		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06005268 RID: 21096 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005269 RID: 21097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C58")]
		public ChemistryStation targetStation
		{
			[Token(Token = "0x6005268")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005269")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600526A")]
		[Address(RVA = "0x958AD0", Offset = "0x957CD0", VA = "0x180958AD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600526B")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void SetTargetStation(ChemistryStation station)
		{
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600526C")]
		[Address(RVA = "0x958E70", Offset = "0x958070", VA = "0x180958E70", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600526D")]
		[Address(RVA = "0x959840", Offset = "0x958A40", VA = "0x180959840", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600526E")]
		[Address(RVA = "0x958BE0", Offset = "0x957DE0", VA = "0x180958BE0", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600526F")]
		[Address(RVA = "0x959F00", Offset = "0x959100", VA = "0x180959F00")]
		[ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005270")]
		[Address(RVA = "0x959DF0", Offset = "0x958FF0", VA = "0x180959DF0")]
		private void SetupBeaker()
		{
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005271")]
		[Address(RVA = "0x959040", Offset = "0x958240", VA = "0x180959040")]
		private void FillBeaker(StationRecipe recipe, Beaker beaker)
		{
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x00015930 File Offset: 0x00013B30
		[Token(Token = "0x6005272")]
		[Address(RVA = "0x958C90", Offset = "0x957E90", VA = "0x180958C90")]
		private bool CanCookStart()
		{
			return default(bool);
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005273")]
		[Address(RVA = "0x95A020", Offset = "0x959220", VA = "0x18095A020")]
		private void StopCook()
		{
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x00015948 File Offset: 0x00013B48
		[Token(Token = "0x6005274")]
		[Address(RVA = "0x959500", Offset = "0x958700", VA = "0x180959500")]
		private Vector3 GetStationAccessPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x00015960 File Offset: 0x00013B60
		[Token(Token = "0x6005275")]
		[Address(RVA = "0x959600", Offset = "0x958800", VA = "0x180959600")]
		private bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005276")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public StartChemistryStationBehaviour()
		{
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005277")]
		[Address(RVA = "0x95A0D0", Offset = "0x9592D0", VA = "0x18095A0D0")]
		[CompilerGenerated]
		private IEnumerator <StartCook>g__CookRoutine|15_0()
		{
			return null;
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005278")]
		[Address(RVA = "0x9597B0", Offset = "0x9589B0", VA = "0x1809597B0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005279")]
		[Address(RVA = "0x9477E0", Offset = "0x9469E0", VA = "0x1809477E0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600527A")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600527B")]
		[Address(RVA = "0x959CE0", Offset = "0x958EE0", VA = "0x180959CE0")]
		private void RpcWriter___Observers_StartCook_2166136261()
		{
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600527C")]
		[Address(RVA = "0x959BB0", Offset = "0x958DB0", VA = "0x180959BB0")]
		private void RpcLogic___StartCook_2166136261()
		{
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600527D")]
		[Address(RVA = "0x959CA0", Offset = "0x958EA0", VA = "0x180959CA0")]
		private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600527E")]
		[Address(RVA = "0x9589E0", Offset = "0x957BE0", VA = "0x1809589E0", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003830 RID: 14384
		[Token(Token = "0x4003830")]
		public const float PLACE_INGREDIENTS_TIME = 8f;

		// Token: 0x04003831 RID: 14385
		[Token(Token = "0x4003831")]
		public const float STIR_TIME = 6f;

		// Token: 0x04003832 RID: 14386
		[Token(Token = "0x4003832")]
		public const float BURNER_TIME = 6f;

		// Token: 0x04003834 RID: 14388
		[Token(Token = "0x4003834")]
		[FieldOffset(Offset = "0x170")]
		private Chemist chemist;

		// Token: 0x04003835 RID: 14389
		[Token(Token = "0x4003835")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine cookRoutine;

		// Token: 0x04003836 RID: 14390
		[Token(Token = "0x4003836")]
		[FieldOffset(Offset = "0x180")]
		private Beaker beaker;

		// Token: 0x04003837 RID: 14391
		[Token(Token = "0x4003837")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003838 RID: 14392
		[Token(Token = "0x4003838")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted;
	}
}
