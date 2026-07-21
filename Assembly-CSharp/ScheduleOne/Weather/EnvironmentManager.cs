using System;
using System.Collections.Generic;
using FishNet.Object.Synchronizing;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B98 RID: 2968
	[Token(Token = "0x2000B98")]
	public class EnvironmentManager : NetworkSingleton<EnvironmentManager>
	{
		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x0600583B RID: 22587 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CC4")]
		public WeatherConditions CurrentWeatherConditions
		{
			[Token(Token = "0x600583B")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600583C RID: 22588 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CC5")]
		public SkyState CurrentSkyState
		{
			[Token(Token = "0x600583C")]
			[Address(RVA = "0x5A44C0", Offset = "0x5A36C0", VA = "0x1805A44C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600583D RID: 22589 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CC6")]
		protected Transform Player
		{
			[Token(Token = "0x600583D")]
			[Address(RVA = "0x998940", Offset = "0x997B40", VA = "0x180998940")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583E")]
		[Address(RVA = "0x9971F0", Offset = "0x9963F0", VA = "0x1809971F0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583F")]
		[Address(RVA = "0x99B0C0", Offset = "0x99A2C0", VA = "0x18099B0C0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005840")]
		[Address(RVA = "0x99A260", Offset = "0x999460", VA = "0x18099A260", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005841")]
		[Address(RVA = "0x99C590", Offset = "0x99B790", VA = "0x18099C590")]
		private void Update()
		{
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005842")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void InitialiseControllers()
		{
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005843")]
		[Address(RVA = "0x999070", Offset = "0x998270", VA = "0x180999070")]
		private void InitialiseSky()
		{
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005844")]
		[Address(RVA = "0x999490", Offset = "0x998690", VA = "0x180999490")]
		private void InitialiseWeather()
		{
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005845")]
		[Address(RVA = "0x998F40", Offset = "0x998140", VA = "0x180998F40")]
		private void InitialiseGlobalVariables()
		{
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005846")]
		[Address(RVA = "0x997B90", Offset = "0x996D90", VA = "0x180997B90")]
		private void CreateWeatherVolumesAtStartIndex(int sequenceVolumeIndex)
		{
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005847")]
		[Address(RVA = "0x9978D0", Offset = "0x996AD0", VA = "0x1809978D0")]
		private void CreateVolume(WeatherVolume volume, Vector3 position, int insertIndex = -1)
		{
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005848")]
		[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0")]
		private WeatherProfile GetNextWeatherProfile(WeatherProfile currentProfile)
		{
			return null;
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005849")]
		[Address(RVA = "0x998340", Offset = "0x997540", VA = "0x180998340")]
		private void DetermineWeatherVolumeWithTarget()
		{
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584A")]
		[Address(RVA = "0x9973E0", Offset = "0x9965E0", VA = "0x1809973E0")]
		private void CalculateWeatherBlendsFromVolumes()
		{
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584B")]
		[Address(RVA = "0x997240", Offset = "0x996440", VA = "0x180997240")]
		private void BlendWeatherProfiles()
		{
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584C")]
		[Address(RVA = "0x997DB0", Offset = "0x996FB0", VA = "0x180997DB0")]
		private void CreateWeatherVolumes()
		{
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584D")]
		[Address(RVA = "0x999930", Offset = "0x998B30", VA = "0x180999930")]
		private void MoveWeatherVolumes()
		{
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x00016638 File Offset: 0x00014838
		[Token(Token = "0x600584E")]
		[Address(RVA = "0x9989E0", Offset = "0x997BE0", VA = "0x1809989E0")]
		public int GetSequenceStartTime(WeatherSequence sequence)
		{
			return 0;
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584F")]
		[Address(RVA = "0x99B4D0", Offset = "0x99A6D0", VA = "0x18099B4D0")]
		private void UpdateVolumes()
		{
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005850")]
		[Address(RVA = "0x99BE30", Offset = "0x99B030", VA = "0x18099BE30")]
		private void UpdateWeather()
		{
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005851")]
		[Address(RVA = "0x99BA00", Offset = "0x99AC00", VA = "0x18099BA00")]
		private void UpdateWeatherEntities()
		{
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005852")]
		[Address(RVA = "0x99AA40", Offset = "0x999C40", VA = "0x18099AA40")]
		private void SetRandomWeatherSequence()
		{
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005853")]
		[Address(RVA = "0x99A9C0", Offset = "0x999BC0", VA = "0x18099A9C0")]
		private void SetLensFlare(LensFlareDataSRP flare, float intensity)
		{
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005854")]
		[Address(RVA = "0x997780", Offset = "0x996980", VA = "0x180997780")]
		private void ClearWeather()
		{
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005855")]
		[Address(RVA = "0x99A4E0", Offset = "0x9996E0", VA = "0x18099A4E0")]
		public void RegisterEnclosure(WorldEnclosure enclosure)
		{
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005856")]
		[Address(RVA = "0x99A8A0", Offset = "0x999AA0", VA = "0x18099A8A0")]
		private void RegisterWeatherEnclosure(WeatherEnclosure enclosure)
		{
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005857")]
		[Address(RVA = "0x99A6E0", Offset = "0x9998E0", VA = "0x18099A6E0")]
		private void RegisterOverrideEnclosure(SkyOverrideEnclosure enclosure)
		{
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005858")]
		[Address(RVA = "0x99A7C0", Offset = "0x9999C0", VA = "0x18099A7C0")]
		public void RegisterPuddleVolume(PuddleVolume puddleVolume)
		{
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005859")]
		[Address(RVA = "0x5A4560", Offset = "0x5A3760", VA = "0x1805A4560")]
		private void SetWeatherConditions(WeatherConditions conditions)
		{
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600585A")]
		[Address(RVA = "0x998C40", Offset = "0x997E40", VA = "0x180998C40")]
		protected WeatherProfile GetWeatherProfileFromPosition(Vector3 position)
		{
			return null;
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600585B")]
		[Address(RVA = "0x9988A0", Offset = "0x997AA0", VA = "0x1809988A0")]
		public WeatherConditions GetActiveWeatherConditionsFromPosition(Vector3 position)
		{
			return null;
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x00016650 File Offset: 0x00014850
		[Token(Token = "0x600585C")]
		[Address(RVA = "0x998E60", Offset = "0x998060", VA = "0x180998E60")]
		private Vector3 GetWeatherVolumeBounds()
		{
			return default(Vector3);
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x00016668 File Offset: 0x00014868
		[Token(Token = "0x600585D")]
		[Address(RVA = "0x998EB0", Offset = "0x9980B0", VA = "0x180998EB0")]
		private Vector3 GetWeatherVolumeInitialPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x00016680 File Offset: 0x00014880
		[Token(Token = "0x600585E")]
		[Address(RVA = "0x998BC0", Offset = "0x997DC0", VA = "0x180998BC0")]
		private Vector3 GetWeatherBoundsCenter()
		{
			return default(Vector3);
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600585F")]
		[Address(RVA = "0x998B40", Offset = "0x997D40", VA = "0x180998B40")]
		private Transform GetWeatherAnchor()
		{
			return null;
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005860")]
		[Address(RVA = "0x99A240", Offset = "0x999440", VA = "0x18099A240")]
		private void OnMinutePass()
		{
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005861")]
		[Address(RVA = "0x99A280", Offset = "0x999480", VA = "0x18099A280")]
		private void OnTick()
		{
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005862")]
		[Address(RVA = "0x99A2B0", Offset = "0x9994B0", VA = "0x18099A2B0")]
		public void OnTimeSet()
		{
		}

		// Token: 0x06005863 RID: 22627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005863")]
		[Address(RVA = "0x99A250", Offset = "0x999450", VA = "0x18099A250")]
		public void OnSleepEnd()
		{
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005864")]
		[Address(RVA = "0x998940", Offset = "0x997B40", VA = "0x180998940")]
		private Transform GetPlayer()
		{
			return null;
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x00016698 File Offset: 0x00014898
		[Token(Token = "0x6005865")]
		[Address(RVA = "0x999790", Offset = "0x998990", VA = "0x180999790")]
		public bool IsPositionUnderCover(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005866")]
		[Address(RVA = "0x99A370", Offset = "0x999570", VA = "0x18099A370")]
		public void OnWeatherEntityRegistered(IWeatherEntity entity)
		{
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005867")]
		[Address(RVA = "0x99A450", Offset = "0x999650", VA = "0x18099A450")]
		public void OnWeatherEntityUnregistered(IWeatherEntity entity)
		{
		}

		// Token: 0x06005868 RID: 22632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005868")]
		[Address(RVA = "0x999F80", Offset = "0x999180", VA = "0x180999F80", Slot = "21")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005869")]
		[Address(RVA = "0x99A980", Offset = "0x999B80", VA = "0x18099A980")]
		[Button]
		public void SetDebugSequence()
		{
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586A")]
		[Address(RVA = "0x99B0A0", Offset = "0x99A2A0", VA = "0x18099B0A0")]
		[Button]
		public void SetWeather(string type)
		{
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586B")]
		[Address(RVA = "0x99AE90", Offset = "0x99A090", VA = "0x18099AE90")]
		private void SetWeatherSequence(string sequenceId)
		{
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586C")]
		[Address(RVA = "0x99B220", Offset = "0x99A420", VA = "0x18099B220")]
		public void StopVolumeMovement()
		{
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586D")]
		[Address(RVA = "0x99B0B0", Offset = "0x99A2B0", VA = "0x18099B0B0")]
		public void StartVolumeMovement()
		{
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586E")]
		[Address(RVA = "0x99AE80", Offset = "0x99A080", VA = "0x18099AE80")]
		public void SetVolumeMoveSpeed(float speed)
		{
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586F")]
		[Address(RVA = "0x99B2F0", Offset = "0x99A4F0", VA = "0x18099B2F0")]
		public void TriggerLightningEvent()
		{
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005870")]
		[Address(RVA = "0x99B440", Offset = "0x99A640", VA = "0x18099B440")]
		public void TriggerPlayerLightningEvent(Player player)
		{
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005871")]
		[Address(RVA = "0x99B3B0", Offset = "0x99A5B0", VA = "0x18099B3B0")]
		public void TriggerNpcLightningEvent(NPC npc)
		{
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005872")]
		[Address(RVA = "0x99B230", Offset = "0x99A430", VA = "0x18099B230")]
		public void TriggerDistantThunder()
		{
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6005873")]
		[Address(RVA = "0x9985F0", Offset = "0x9977F0", VA = "0x1809985F0")]
		private ThunderController GetActiveThunderController()
		{
			return null;
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005874")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void SetWeather_Client()
		{
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005875")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void SetWeatherSpeed_Client()
		{
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005876")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void TriggerThunder_Client()
		{
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005877")]
		[Address(RVA = "0x99C700", Offset = "0x99B900", VA = "0x18099C700")]
		public EnvironmentManager()
		{
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005878")]
		[Address(RVA = "0x999EF0", Offset = "0x9990F0", VA = "0x180999EF0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005879")]
		[Address(RVA = "0x999E70", Offset = "0x999070", VA = "0x180999E70", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600587A")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600587B")]
		[Address(RVA = "0x996C40", Offset = "0x995E40", VA = "0x180996C40", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.Weather.EnvironmentManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003A9C RID: 15004
		[Token(Token = "0x4003A9C")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Header("General Components")]
		private Transform _playerObj;

		// Token: 0x04003A9D RID: 15005
		[Token(Token = "0x4003A9D")]
		[FieldOffset(Offset = "0x128")]
		[Header("Controllers")]
		[SerializeField]
		private DayNightController _dayNightController;

		// Token: 0x04003A9E RID: 15006
		[Token(Token = "0x4003A9E")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private MaskController _maskController;

		// Token: 0x04003A9F RID: 15007
		[Token(Token = "0x4003A9F")]
		[FieldOffset(Offset = "0x138")]
		[Header("Weather Components")]
		[SerializeField]
		private Transform _weatherBoundsAnchor;

		// Token: 0x04003AA0 RID: 15008
		[Token(Token = "0x4003AA0")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Transform _weatherVolumeContainer;

		// Token: 0x04003AA1 RID: 15009
		[Token(Token = "0x4003AA1")]
		[FieldOffset(Offset = "0x148")]
		[Header("Weather Profiles")]
		[SerializeField]
		private List<WeatherSequence> _weatherSequences;

		// Token: 0x04003AA2 RID: 15010
		[Token(Token = "0x4003AA2")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private List<WeightedWeatherSequence> _dailyWeatherSequences;

		// Token: 0x04003AA3 RID: 15011
		[Token(Token = "0x4003AA3")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Header("Weather Settings")]
		private float _defaultWeatherVolumeMoveSpeed;

		// Token: 0x04003AA4 RID: 15012
		[Token(Token = "0x4003AA4")]
		[FieldOffset(Offset = "0x15C")]
		[Range(1f, 6f)]
		[SerializeField]
		private int _weatherVolumeCount;

		// Token: 0x04003AA5 RID: 15013
		[Token(Token = "0x4003AA5")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Vector3 _weatherBounds;

		// Token: 0x04003AA6 RID: 15014
		[Token(Token = "0x4003AA6")]
		[FieldOffset(Offset = "0x16C")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _weatherVolumeBlendSize;

		// Token: 0x04003AA7 RID: 15015
		[Token(Token = "0x4003AA7")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private AnimationCurve _blendCurve;

		// Token: 0x04003AA8 RID: 15016
		[Token(Token = "0x4003AA8")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Header("Lighting Settings")]
		private LensFlareSettings _lensFlareSettings;

		// Token: 0x04003AA9 RID: 15017
		[Token(Token = "0x4003AA9")]
		[FieldOffset(Offset = "0x180")]
		[Header("Debugging & Development")]
		[SerializeField]
		private UniversalRendererData _rendererData;

		// Token: 0x04003AAA RID: 15018
		[Token(Token = "0x4003AAA")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private bool _debugControlWeatherSpeedWithSlider;

		// Token: 0x04003AAB RID: 15019
		[Token(Token = "0x4003AAB")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _debugWeatherSliderValue;

		// Token: 0x04003AAC RID: 15020
		[Token(Token = "0x4003AAC")]
		[FieldOffset(Offset = "0x190")]
		private List<WeatherEnclosure> _weatherEnclosures;

		// Token: 0x04003AAD RID: 15021
		[Token(Token = "0x4003AAD")]
		[FieldOffset(Offset = "0x198")]
		private List<SkyOverrideEnclosure> _overrideEnclosures;

		// Token: 0x04003AAE RID: 15022
		[Token(Token = "0x4003AAE")]
		[FieldOffset(Offset = "0x1A0")]
		private List<PuddleVolume> _puddleVolumes;

		// Token: 0x04003AAF RID: 15023
		[Token(Token = "0x4003AAF")]
		[FieldOffset(Offset = "0x1A8")]
		[SyncObject]
		private readonly SyncList<WeatherVolume> _activeWeatherVolumes;

		// Token: 0x04003AB0 RID: 15024
		[Token(Token = "0x4003AB0")]
		[FieldOffset(Offset = "0x1B0")]
		private WeatherSequence _currentWeatherSequence;

		// Token: 0x04003AB1 RID: 15025
		[Token(Token = "0x4003AB1")]
		[FieldOffset(Offset = "0x1B8")]
		private WeatherVolume _targetWeatherVolume;

		// Token: 0x04003AB2 RID: 15026
		[Token(Token = "0x4003AB2")]
		[FieldOffset(Offset = "0x1C0")]
		private Vector3 _weatherVolumeBounds;

		// Token: 0x04003AB3 RID: 15027
		[Token(Token = "0x4003AB3")]
		[FieldOffset(Offset = "0x1CC")]
		private Vector3 _weatherBoundsCenter;

		// Token: 0x04003AB4 RID: 15028
		[Token(Token = "0x4003AB4")]
		[FieldOffset(Offset = "0x1D8")]
		private SkySettings _skyOverrideSettings;

		// Token: 0x04003AB5 RID: 15029
		[Token(Token = "0x4003AB5")]
		[FieldOffset(Offset = "0x1E0")]
		private float _skyOverrideBlendValue;

		// Token: 0x04003AB6 RID: 15030
		[Token(Token = "0x4003AB6")]
		[FieldOffset(Offset = "0x1E4")]
		private bool _doWeatherBlending;

		// Token: 0x04003AB7 RID: 15031
		[Token(Token = "0x4003AB7")]
		[FieldOffset(Offset = "0x1E5")]
		private bool _hasWeatherVolumeNeighbour;

		// Token: 0x04003AB8 RID: 15032
		[Token(Token = "0x4003AB8")]
		[FieldOffset(Offset = "0x1E6")]
		private bool _withinBounds;

		// Token: 0x04003AB9 RID: 15033
		[Token(Token = "0x4003AB9")]
		[FieldOffset(Offset = "0x1E8")]
		private int _targetWeatherVolumeIndex;

		// Token: 0x04003ABA RID: 15034
		[Token(Token = "0x4003ABA")]
		[FieldOffset(Offset = "0x1EC")]
		private int _neighbourWeatherVolumeIndex;

		// Token: 0x04003ABB RID: 15035
		[Token(Token = "0x4003ABB")]
		[FieldOffset(Offset = "0x1F0")]
		private float _targetWeatherBlendValue;

		// Token: 0x04003ABC RID: 15036
		[Token(Token = "0x4003ABC")]
		[FieldOffset(Offset = "0x1F4")]
		private float _weatherVolumeMoveSpeed;

		// Token: 0x04003ABD RID: 15037
		[Token(Token = "0x4003ABD")]
		[FieldOffset(Offset = "0x1F8")]
		private float _neighbourWeatherBlendValue;

		// Token: 0x04003ABE RID: 15038
		[Token(Token = "0x4003ABE")]
		[FieldOffset(Offset = "0x1FC")]
		private Vector2 _closestPointInTargetVolume;

		// Token: 0x04003ABF RID: 15039
		[Token(Token = "0x4003ABF")]
		[FieldOffset(Offset = "0x204")]
		private Vector2 _closestPointInNeighbourVolume;

		// Token: 0x04003AC0 RID: 15040
		[Token(Token = "0x4003AC0")]
		[FieldOffset(Offset = "0x20C")]
		private float _wetUpdateTimer;

		// Token: 0x04003AC1 RID: 15041
		[Token(Token = "0x4003AC1")]
		[FieldOffset(Offset = "0x210")]
		private int _sequenceVolumeStartIndex;

		// Token: 0x04003AC2 RID: 15042
		[Token(Token = "0x4003AC2")]
		[FieldOffset(Offset = "0x218")]
		private Vector3[] _weatherVolumePositions;

		// Token: 0x04003AC3 RID: 15043
		[Token(Token = "0x4003AC3")]
		[FieldOffset(Offset = "0x220")]
		private WeatherConditions _currentWeatherConditions;

		// Token: 0x04003AC4 RID: 15044
		[Token(Token = "0x4003AC4")]
		[FieldOffset(Offset = "0x228")]
		private SkyState _currentSkyState;

		// Token: 0x04003AC5 RID: 15045
		[Token(Token = "0x4003AC5")]
		[FieldOffset(Offset = "0x230")]
		protected ScheduleOneFogFeature _fogFeature;

		// Token: 0x04003AC6 RID: 15046
		[Token(Token = "0x4003AC6")]
		[FieldOffset(Offset = "0x238")]
		private List<IWeatherEntity> _registeredWeatherEntities;

		// Token: 0x04003AC7 RID: 15047
		[Token(Token = "0x4003AC7")]
		[FieldOffset(Offset = "0x240")]
		private bool NetworkInitialize___EarlyScheduleOne.Weather.EnvironmentManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04003AC8 RID: 15048
		[Token(Token = "0x4003AC8")]
		[FieldOffset(Offset = "0x241")]
		private bool NetworkInitialize__LateScheduleOne.Weather.EnvironmentManagerAssembly-CSharp.dll_Excuted;
	}
}
