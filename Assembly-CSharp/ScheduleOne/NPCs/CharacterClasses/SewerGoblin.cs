using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000ABE RID: 2750
	[Token(Token = "0x2000ABE")]
	public class SewerGoblin : NPC
	{
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004F00 RID: 20224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C06")]
		public Player TargetPlayer
		{
			[Token(Token = "0x6004EFF")]
			[Address(RVA = "0x8AB460", Offset = "0x8AA660", VA = "0x1808AB460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F00")]
			[Address(RVA = "0x944330", Offset = "0x943530", VA = "0x180944330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x00014E80 File Offset: 0x00013080
		// (set) Token: 0x06004F02 RID: 20226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C07")]
		public SewerGoblin.ESewerGoblinState CurrentState
		{
			[Token(Token = "0x6004F01")]
			[Address(RVA = "0x9442F0", Offset = "0x9434F0", VA = "0x1809442F0")]
			[CompilerGenerated]
			get
			{
				return SewerGoblin.ESewerGoblinState.Inactive;
			}
			[Token(Token = "0x6004F02")]
			[Address(RVA = "0x944310", Offset = "0x943510", VA = "0x180944310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06004F03 RID: 20227 RVA: 0x00014E98 File Offset: 0x00013098
		// (set) Token: 0x06004F04 RID: 20228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C08")]
		public int HoursSinceLastDeploy
		{
			[Token(Token = "0x6004F03")]
			[Address(RVA = "0x944300", Offset = "0x943500", VA = "0x180944300")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004F04")]
			[Address(RVA = "0x944320", Offset = "0x943520", VA = "0x180944320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F05")]
		[Address(RVA = "0x942DA0", Offset = "0x941FA0", VA = "0x180942DA0", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F06")]
		[Address(RVA = "0x943B00", Offset = "0x942D00", VA = "0x180943B00", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F07")]
		[Address(RVA = "0x943FE0", Offset = "0x9431E0", VA = "0x180943FE0")]
		private void Update()
		{
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F08")]
		[Address(RVA = "0x943570", Offset = "0x942770", VA = "0x180943570")]
		private void OnMinPass()
		{
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F09")]
		[Address(RVA = "0x943540", Offset = "0x942740", VA = "0x180943540")]
		private void OnHourPass()
		{
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0A")]
		[Address(RVA = "0x9430D0", Offset = "0x9422D0", VA = "0x1809430D0")]
		public void DeployToPlayer(Player player)
		{
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0B")]
		[Address(RVA = "0x9429A0", Offset = "0x941BA0", VA = "0x1809429A0")]
		private void AttackTarget()
		{
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0C")]
		[Address(RVA = "0x943850", Offset = "0x942A50", VA = "0x180943850")]
		public void Retreat()
		{
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0D")]
		[Address(RVA = "0x943350", Offset = "0x942550", VA = "0x180943350", Slot = "106")]
		protected override void EnterBuilding(string buildingGUID, int doorIndex)
		{
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0E")]
		[Address(RVA = "0x9433A0", Offset = "0x9425A0", VA = "0x1809433A0", Slot = "107")]
		protected override void ExitBuilding(NPCEnterableBuilding building)
		{
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0F")]
		[Address(RVA = "0x943070", Offset = "0x942270", VA = "0x180943070")]
		public void DeployToLocalPlayer()
		{
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F10")]
		[Address(RVA = "0x9437C0", Offset = "0x9429C0", VA = "0x1809437C0")]
		private void OnSuccesfulCombatHit()
		{
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x00014EB0 File Offset: 0x000130B0
		[Token(Token = "0x6004F11")]
		[Address(RVA = "0x942EB0", Offset = "0x9420B0", VA = "0x180942EB0")]
		private bool CanBeginRetieve()
		{
			return default(bool);
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F12")]
		[Address(RVA = "0x942DF0", Offset = "0x941FF0", VA = "0x180942DF0")]
		private void BeginRetrieve()
		{
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F13")]
		[Address(RVA = "0x943720", Offset = "0x942920", VA = "0x180943720")]
		private void OnRetrieveCancel()
		{
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F14")]
		[Address(RVA = "0x9437B0", Offset = "0x9429B0", VA = "0x1809437B0")]
		private void OnRetrieveSuccess()
		{
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x00014EC8 File Offset: 0x000130C8
		[Token(Token = "0x6004F15")]
		[Address(RVA = "0x943440", Offset = "0x942640", VA = "0x180943440")]
		public bool IsPlayerValidTarget(Player player)
		{
			return default(bool);
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x00014EE0 File Offset: 0x000130E0
		[Token(Token = "0x6004F16")]
		[Address(RVA = "0x9433E0", Offset = "0x9425E0", VA = "0x1809433E0")]
		public bool IsPlayerHoldingPacifyItem(Player player)
		{
			return default(bool);
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F17")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "101")]
		public override void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F18")]
		[Address(RVA = "0x943820", Offset = "0x942A20", VA = "0x180943820")]
		private void OnTakeDamage(float damageAmount)
		{
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F19")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public SewerGoblin()
		{
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1C")]
		[Address(RVA = "0x943520", Offset = "0x942720", VA = "0x180943520", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1D")]
		[Address(RVA = "0x943500", Offset = "0x942700", VA = "0x180943500", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1E")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F1F")]
		[Address(RVA = "0x942A10", Offset = "0x941C10", VA = "0x180942A10", Slot = "130")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.SewerGoblin_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040036EE RID: 14062
		[Token(Token = "0x40036EE")]
		public const int COOLDOWN_HOURS_BETWEEN_DEPLOYS = 12;

		// Token: 0x040036EF RID: 14063
		[Token(Token = "0x40036EF")]
		public const float HOURLY_DEPLOY_CHANCE = 0.1f;

		// Token: 0x040036F0 RID: 14064
		[Token(Token = "0x40036F0")]
		public const float NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT = 0.5f;

		// Token: 0x040036F1 RID: 14065
		[Token(Token = "0x40036F1")]
		public const float RETREAT_CHANCE_AFTER_HIT = 0.3f;

		// Token: 0x040036F2 RID: 14066
		[Token(Token = "0x40036F2")]
		public const int MAX_CANCELLED_RETRIEVE_ATTEMPTS = 3;

		// Token: 0x040036F6 RID: 14070
		[Token(Token = "0x40036F6")]
		[FieldOffset(Offset = "0x338")]
		[Header("References")]
		public NPCEnterableBuilding SewerHidingBuilding;

		// Token: 0x040036F7 RID: 14071
		[Token(Token = "0x40036F7")]
		[FieldOffset(Offset = "0x340")]
		public NPCEvent_StayInBuilding StayInBuildingEvent;

		// Token: 0x040036F8 RID: 14072
		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x348")]
		public ItemDefinition PacifyItem;

		// Token: 0x040036F9 RID: 14073
		[Token(Token = "0x40036F9")]
		[FieldOffset(Offset = "0x350")]
		public SewerGoblinRetrieveBehaviour RetrieveBehaviour;

		// Token: 0x040036FA RID: 14074
		[Token(Token = "0x40036FA")]
		[FieldOffset(Offset = "0x358")]
		public AudioSourceController ExitSound;

		// Token: 0x040036FB RID: 14075
		[Token(Token = "0x40036FB")]
		[FieldOffset(Offset = "0x360")]
		[HideInInspector]
		public int cancelledRetrieveAttempts;

		// Token: 0x040036FC RID: 14076
		[Token(Token = "0x40036FC")]
		[FieldOffset(Offset = "0x364")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SewerGoblinAssembly-CSharp.dll_Excuted;

		// Token: 0x040036FD RID: 14077
		[Token(Token = "0x40036FD")]
		[FieldOffset(Offset = "0x365")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SewerGoblinAssembly-CSharp.dll_Excuted;

		// Token: 0x02000ABF RID: 2751
		[Token(Token = "0x2000ABF")]
		public enum ESewerGoblinState
		{
			// Token: 0x040036FF RID: 14079
			[Token(Token = "0x40036FF")]
			Inactive,
			// Token: 0x04003700 RID: 14080
			[Token(Token = "0x4003700")]
			Attacking,
			// Token: 0x04003701 RID: 14081
			[Token(Token = "0x4003701")]
			Retrieving,
			// Token: 0x04003702 RID: 14082
			[Token(Token = "0x4003702")]
			Retreating
		}
	}
}
