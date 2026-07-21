using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.StationFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000CE5 RID: 3301
	[Token(Token = "0x2000CE5")]
	public class MushroomSpawnStationInterface : Singleton<MushroomSpawnStationInterface>
	{
		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x0600603F RID: 24639 RVA: 0x000180A8 File Offset: 0x000162A8
		// (set) Token: 0x06006040 RID: 24640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DEC")]
		public bool IsOpen
		{
			[Token(Token = "0x600603F")]
			[Address(RVA = "0x4C0320", Offset = "0x4BF520", VA = "0x1804C0320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006040")]
			[Address(RVA = "0x594500", Offset = "0x593700", VA = "0x180594500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06006041 RID: 24641 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006042 RID: 24642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DED")]
		public MushroomSpawnStation Station
		{
			[Token(Token = "0x6006041")]
			[Address(RVA = "0x467500", Offset = "0x466700", VA = "0x180467500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006042")]
			[Address(RVA = "0x5944F0", Offset = "0x5936F0", VA = "0x1805944F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006043")]
		[Address(RVA = "0xA2D830", Offset = "0xA2CA30", VA = "0x180A2D830", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006044")]
		[Address(RVA = "0xA2E850", Offset = "0xA2DA50", VA = "0x180A2E850", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006045")]
		[Address(RVA = "0xA2E190", Offset = "0xA2D390", VA = "0x180A2E190")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006046")]
		[Address(RVA = "0xA2EA50", Offset = "0xA2DC50", VA = "0x180A2EA50")]
		private void Update()
		{
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006047")]
		[Address(RVA = "0xA2E1E0", Offset = "0xA2D3E0", VA = "0x180A2E1E0")]
		public void Open(MushroomSpawnStation station)
		{
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006048")]
		[Address(RVA = "0xA2DD70", Offset = "0xA2CF70", VA = "0x180A2DD70")]
		public void Close(bool exitStation)
		{
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006049")]
		[Address(RVA = "0xA2E920", Offset = "0xA2DB20", VA = "0x180A2E920")]
		private void StationContentsChanged()
		{
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604A")]
		[Address(RVA = "0xA2E9D0", Offset = "0xA2DBD0", VA = "0x180A2E9D0")]
		private void UpdateInstruction()
		{
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x000180C0 File Offset: 0x000162C0
		[Token(Token = "0x600604B")]
		[Address(RVA = "0xA2DC90", Offset = "0xA2CE90", VA = "0x180A2DC90")]
		private bool CanBeginTask(out string instruction)
		{
			return default(bool);
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604C")]
		[Address(RVA = "0xA2E990", Offset = "0xA2DB90", VA = "0x180A2E990")]
		private void UpdateBeginButton()
		{
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604D")]
		[Address(RVA = "0xA2D990", Offset = "0xA2CB90", VA = "0x180A2D990")]
		private void BeginTask()
		{
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604E")]
		[Address(RVA = "0xA2EAD0", Offset = "0xA2DCD0", VA = "0x180A2EAD0")]
		public MushroomSpawnStationInterface()
		{
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600604F")]
		[Address(RVA = "0xA2E980", Offset = "0xA2DB80", VA = "0x180A2E980")]
		[CompilerGenerated]
		private void <BeginTask>g__TaskStopped|27_0()
		{
		}

		// Token: 0x04004290 RID: 17040
		[Token(Token = "0x4004290")]
		private const float CameraLerpTime = 0.2f;

		// Token: 0x04004291 RID: 17041
		[Token(Token = "0x4004291")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		private Canvas _canvas;

		// Token: 0x04004292 RID: 17042
		[Token(Token = "0x4004292")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04004293 RID: 17043
		[Token(Token = "0x4004293")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ItemSlotUI _grainBagSlotUI;

		// Token: 0x04004294 RID: 17044
		[Token(Token = "0x4004294")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ItemSlotUI _syringeSlotUI;

		// Token: 0x04004295 RID: 17045
		[Token(Token = "0x4004295")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ItemSlotUI _outputSlotUI;

		// Token: 0x04004296 RID: 17046
		[Token(Token = "0x4004296")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _beginButton;

		// Token: 0x04004297 RID: 17047
		[Token(Token = "0x4004297")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _instructionLabel;

		// Token: 0x0400429A RID: 17050
		[Token(Token = "0x400429A")]
		[FieldOffset(Offset = "0x70")]
		public Action OnExitStation;
	}
}
