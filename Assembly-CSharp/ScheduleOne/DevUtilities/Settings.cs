using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A39 RID: 2617
	[Token(Token = "0x2000A39")]
	public class Settings : PersistentSingleton<Settings>
	{
		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x00014238 File Offset: 0x00012438
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B91")]
		public static bool ChristmasEventActive
		{
			[Token(Token = "0x6004A19")]
			[Address(RVA = "0x912460", Offset = "0x911660", VA = "0x180912460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A1A")]
			[Address(RVA = "0x912570", Offset = "0x911770", VA = "0x180912570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x00014250 File Offset: 0x00012450
		[Token(Token = "0x17000B92")]
		public bool PausingFreezesTime
		{
			[Token(Token = "0x6004A1B")]
			[Address(RVA = "0x9124A0", Offset = "0x9116A0", VA = "0x1809124A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06004A1C RID: 18972 RVA: 0x00014268 File Offset: 0x00012468
		// (set) Token: 0x06004A1D RID: 18973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B93")]
		public Settings.EUnitType UnitType
		{
			[Token(Token = "0x6004A1C")]
			[Address(RVA = "0x4A63B0", Offset = "0x4A55B0", VA = "0x1804A63B0")]
			[CompilerGenerated]
			get
			{
				return Settings.EUnitType.Metric;
			}
			[Token(Token = "0x6004A1D")]
			[Address(RVA = "0x54A6A0", Offset = "0x5498A0", VA = "0x18054A6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x910AA0", Offset = "0x90FCA0", VA = "0x180910AA0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x911D20", Offset = "0x910F20", VA = "0x180911D20", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x910360", Offset = "0x90F560", VA = "0x180910360")]
		public void ApplyDisplaySettings(DisplaySettings settings)
		{
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A21")]
		[Address(RVA = "0x911520", Offset = "0x910720", VA = "0x180911520")]
		private void MoveMainWindowTo(DisplayInfo displayInfo)
		{
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A22")]
		[Address(RVA = "0x911CE0", Offset = "0x910EE0", VA = "0x180911CE0")]
		public void ReloadGraphicsSettings()
		{
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A23")]
		[Address(RVA = "0x910910", Offset = "0x90FB10", VA = "0x180910910")]
		public void ApplyGraphicsSettings(GraphicsSettings settings)
		{
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A24")]
		[Address(RVA = "0x911CD0", Offset = "0x910ED0", VA = "0x180911CD0")]
		public void ReloadAudioSettings()
		{
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A25")]
		[Address(RVA = "0x910040", Offset = "0x90F240", VA = "0x180910040")]
		public void ApplyAudioSettings(AudioSettings settings)
		{
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A26")]
		[Address(RVA = "0x911CF0", Offset = "0x910EF0", VA = "0x180911CF0")]
		public void ReloadInputSettings()
		{
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x9109C0", Offset = "0x90FBC0", VA = "0x1809109C0")]
		public void ApplyInputSettings(InputSettings settings)
		{
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x911D00", Offset = "0x910F00", VA = "0x180911D00")]
		public void ReloadOtherSettings()
		{
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x6747C0", Offset = "0x6739C0", VA = "0x1806747C0")]
		public void ApplyOtherSettings(OtherSettings settings)
		{
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x911F20", Offset = "0x911120", VA = "0x180911F20")]
		public void WriteDisplaySettings(DisplaySettings settings)
		{
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x00014280 File Offset: 0x00012480
		[Token(Token = "0x6004A2B")]
		[Address(RVA = "0x9116E0", Offset = "0x9108E0", VA = "0x1809116E0")]
		public DisplaySettings ReadDisplaySettings()
		{
			return default(DisplaySettings);
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A2C")]
		[Address(RVA = "0x912070", Offset = "0x911270", VA = "0x180912070")]
		public void WriteGraphicsSettings(GraphicsSettings settings)
		{
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004A2D")]
		[Address(RVA = "0x911A10", Offset = "0x910C10", VA = "0x180911A10")]
		public GraphicsSettings ReadGraphicsSettings()
		{
			return null;
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A2E")]
		[Address(RVA = "0x911DD0", Offset = "0x910FD0", VA = "0x180911DD0")]
		public void WriteAudioSettings(AudioSettings settings)
		{
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x911560", Offset = "0x910760", VA = "0x180911560")]
		public AudioSettings ReadAudioSettings()
		{
			return null;
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x912160", Offset = "0x911360", VA = "0x180912160")]
		public void WriteInputSettings(InputSettings settings)
		{
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x911B20", Offset = "0x910D20", VA = "0x180911B20")]
		public InputSettings ReadInputSettings()
		{
			return null;
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x912250", Offset = "0x911450", VA = "0x180912250")]
		public void WriteOtherSettings(OtherSettings settings)
		{
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x911C50", Offset = "0x910E50", VA = "0x180911C50")]
		public OtherSettings ReadOtherSettings()
		{
			return null;
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x911270", Offset = "0x910470", VA = "0x180911270")]
		public string GetActionControlPath(string actionName)
		{
			return null;
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00014298 File Offset: 0x00012498
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x9113A0", Offset = "0x9105A0", VA = "0x1809113A0")]
		private Settings.EUnitType GetDefaultUnitTypeForPlayer()
		{
			return Settings.EUnitType.Metric;
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x9122C0", Offset = "0x9114C0", VA = "0x1809122C0")]
		public Settings()
		{
		}

		// Token: 0x0400347A RID: 13434
		[Token(Token = "0x400347A")]
		public const float MinYPos = -20f;

		// Token: 0x0400347B RID: 13435
		[Token(Token = "0x400347B")]
		public const string BETA_ARG = "-beta";

		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		[FieldOffset(Offset = "0x28")]
		public List<string> LaunchArgs;

		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		[FieldOffset(Offset = "0x34")]
		public DisplaySettings DisplaySettings;

		// Token: 0x04003480 RID: 13440
		[Token(Token = "0x4003480")]
		[FieldOffset(Offset = "0x54")]
		public DisplaySettings UnappliedDisplaySettings;

		// Token: 0x04003481 RID: 13441
		[Token(Token = "0x4003481")]
		[FieldOffset(Offset = "0x78")]
		public GraphicsSettings GraphicsSettings;

		// Token: 0x04003482 RID: 13442
		[Token(Token = "0x4003482")]
		[FieldOffset(Offset = "0x80")]
		public AudioSettings AudioSettings;

		// Token: 0x04003483 RID: 13443
		[Token(Token = "0x4003483")]
		[FieldOffset(Offset = "0x88")]
		public InputSettings InputSettings;

		// Token: 0x04003484 RID: 13444
		[Token(Token = "0x4003484")]
		[FieldOffset(Offset = "0x90")]
		public OtherSettings OtherSettings;

		// Token: 0x04003485 RID: 13445
		[Token(Token = "0x4003485")]
		[FieldOffset(Offset = "0x98")]
		public InputActionAsset InputActions;

		// Token: 0x04003486 RID: 13446
		[Token(Token = "0x4003486")]
		[FieldOffset(Offset = "0xA0")]
		public GameInput GameInput;

		// Token: 0x04003487 RID: 13447
		[Token(Token = "0x4003487")]
		[FieldOffset(Offset = "0xA8")]
		public ScriptableRendererFeature SSAO;

		// Token: 0x04003488 RID: 13448
		[Token(Token = "0x4003488")]
		[FieldOffset(Offset = "0xB0")]
		public ScriptableRendererFeature GodRays;

		// Token: 0x04003489 RID: 13449
		[Token(Token = "0x4003489")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Camera")]
		public float LookSensitivity;

		// Token: 0x0400348A RID: 13450
		[Token(Token = "0x400348A")]
		[FieldOffset(Offset = "0xBC")]
		public bool InvertMouse;

		// Token: 0x0400348B RID: 13451
		[Token(Token = "0x400348B")]
		[FieldOffset(Offset = "0xC0")]
		public float CameraFOV;

		// Token: 0x0400348C RID: 13452
		[Token(Token = "0x400348C")]
		[FieldOffset(Offset = "0xC4")]
		public InputSettings.EActionMode SprintMode;

		// Token: 0x0400348D RID: 13453
		[Token(Token = "0x400348D")]
		[FieldOffset(Offset = "0xC8")]
		[Range(0f, 1f)]
		public float CameraBobIntensity;

		// Token: 0x0400348E RID: 13454
		[Token(Token = "0x400348E")]
		[FieldOffset(Offset = "0xD0")]
		private InputActionMap playerControls;

		// Token: 0x0400348F RID: 13455
		[Token(Token = "0x400348F")]
		[FieldOffset(Offset = "0xD8")]
		public Action onInputsApplied;

		// Token: 0x04003490 RID: 13456
		[Token(Token = "0x4003490")]
		[FieldOffset(Offset = "0xE0")]
		public Action onDisplaySettingsApplied;

		// Token: 0x04003491 RID: 13457
		[Token(Token = "0x4003491")]
		[FieldOffset(Offset = "0xE8")]
		public Action onUnappliedDisplayIndexChanged;

		// Token: 0x02000A3A RID: 2618
		[Token(Token = "0x2000A3A")]
		public enum EUnitType
		{
			// Token: 0x04003493 RID: 13459
			[Token(Token = "0x4003493")]
			Metric,
			// Token: 0x04003494 RID: 13460
			[Token(Token = "0x4003494")]
			Imperial
		}
	}
}
