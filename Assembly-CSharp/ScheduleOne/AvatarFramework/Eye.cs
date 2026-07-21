using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007E8 RID: 2024
	[Token(Token = "0x20007E8")]
	public class Eye : MonoBehaviour
	{
		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x000104A0 File Offset: 0x0000E6A0
		// (set) Token: 0x060036C4 RID: 14020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008BF")]
		public Eye.EyeLidConfiguration CurrentConfiguration
		{
			[Token(Token = "0x60036C3")]
			[Address(RVA = "0x4F3E80", Offset = "0x4F3080", VA = "0x1804F3E80")]
			[CompilerGenerated]
			get
			{
				return default(Eye.EyeLidConfiguration);
			}
			[Token(Token = "0x60036C4")]
			[Address(RVA = "0x4F3EF0", Offset = "0x4F30F0", VA = "0x1804F3EF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[Token(Token = "0x170008C0")]
		public bool IsBlinking
		{
			[Token(Token = "0x60036C5")]
			[Address(RVA = "0x7F2D40", Offset = "0x7F1F40", VA = "0x1807F2D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x7F1810", Offset = "0x7F0A10", VA = "0x1807F1810")]
		private void Awake()
		{
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x7F2A40", Offset = "0x7F1C40", VA = "0x1807F2A40")]
		public void SetSize(float size)
		{
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x7F29C0", Offset = "0x7F1BC0", VA = "0x1807F29C0")]
		public void SetLidColor(Color color)
		{
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x7F29A0", Offset = "0x7F1BA0", VA = "0x1807F29A0")]
		public void SetEyeballMaterial(Material mat)
		{
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0x7F2880", Offset = "0x7F1A80", VA = "0x1807F2880")]
		public void SetEyeballColor(Color col, float emission = 0.115f, bool writeDefault = true)
		{
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x7F22C0", Offset = "0x7F14C0", VA = "0x1807F22C0")]
		public void ResetEyeballColor()
		{
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x7F1A70", Offset = "0x7F0C70", VA = "0x1807F1A70")]
		public void ConfigureEyeLight(Color color, float intensity)
		{
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x7F23C0", Offset = "0x7F15C0", VA = "0x1807F23C0")]
		public void SetDilation(float dil)
		{
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x7F23F0", Offset = "0x7F15F0", VA = "0x1807F23F0")]
		public void SetEyeLidState(Eye.EyeLidConfiguration config, float time)
		{
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		private void StopExistingRoutines()
		{
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x7F25A0", Offset = "0x7F17A0", VA = "0x1807F25A0")]
		public void SetEyeLidState(Eye.EyeLidConfiguration config, bool debug = false)
		{
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x7F1B90", Offset = "0x7F0D90", VA = "0x1807F1B90")]
		public void LookAt(Vector3 position, bool instant = false)
		{
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x7F1880", Offset = "0x7F0A80", VA = "0x1807F1880")]
		public void Blink(float blinkDuration, Eye.EyeLidConfiguration endState, bool debug = false)
		{
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x7F2CD0", Offset = "0x7F1ED0", VA = "0x1807F2CD0")]
		public Eye()
		{
		}

		// Token: 0x040027A7 RID: 10151
		[Token(Token = "0x40027A7")]
		public const float PupilLookSpeed = 10f;

		// Token: 0x040027A8 RID: 10152
		[Token(Token = "0x40027A8")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 defaultScale;

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x40027A9")]
		[FieldOffset(Offset = "0xC")]
		private static Vector3 maxRotation;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x18")]
		private static Vector3 minRotation;

		// Token: 0x040027AC RID: 10156
		[Token(Token = "0x40027AC")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform Container;

		// Token: 0x040027AD RID: 10157
		[Token(Token = "0x40027AD")]
		[FieldOffset(Offset = "0x30")]
		public Transform TopLidContainer;

		// Token: 0x040027AE RID: 10158
		[Token(Token = "0x40027AE")]
		[FieldOffset(Offset = "0x38")]
		public Transform BottomLidContainer;

		// Token: 0x040027AF RID: 10159
		[Token(Token = "0x40027AF")]
		[FieldOffset(Offset = "0x40")]
		public Transform PupilContainer;

		// Token: 0x040027B0 RID: 10160
		[Token(Token = "0x40027B0")]
		[FieldOffset(Offset = "0x48")]
		public MeshRenderer TopLidRend;

		// Token: 0x040027B1 RID: 10161
		[Token(Token = "0x40027B1")]
		[FieldOffset(Offset = "0x50")]
		public MeshRenderer BottomLidRend;

		// Token: 0x040027B2 RID: 10162
		[Token(Token = "0x40027B2")]
		[FieldOffset(Offset = "0x58")]
		public MeshRenderer EyeBallRend;

		// Token: 0x040027B3 RID: 10163
		[Token(Token = "0x40027B3")]
		[FieldOffset(Offset = "0x60")]
		public Transform EyeLookOrigin;

		// Token: 0x040027B4 RID: 10164
		[Token(Token = "0x40027B4")]
		[FieldOffset(Offset = "0x68")]
		public OptimizedLight EyeLight;

		// Token: 0x040027B5 RID: 10165
		[Token(Token = "0x40027B5")]
		[FieldOffset(Offset = "0x70")]
		public SkinnedMeshRenderer PupilRend;

		// Token: 0x040027B6 RID: 10166
		[Token(Token = "0x40027B6")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine blinkRoutine;

		// Token: 0x040027B7 RID: 10167
		[Token(Token = "0x40027B7")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine stateRoutine;

		// Token: 0x040027B8 RID: 10168
		[Token(Token = "0x40027B8")]
		[FieldOffset(Offset = "0x88")]
		private Avatar avatar;

		// Token: 0x040027B9 RID: 10169
		[Token(Token = "0x40027B9")]
		[FieldOffset(Offset = "0x90")]
		private Color defaultEyeColor;

		// Token: 0x040027BA RID: 10170
		[Token(Token = "0x40027BA")]
		[FieldOffset(Offset = "0xA0")]
		public Vector2 AngleOffset;

		// Token: 0x020007E9 RID: 2025
		[Token(Token = "0x20007E9")]
		[Serializable]
		public struct EyeLidConfiguration
		{
			// Token: 0x060036D5 RID: 14037 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x60036D5")]
			[Address(RVA = "0x7F1790", Offset = "0x7F0990", VA = "0x1807F1790", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x060036D6 RID: 14038 RVA: 0x000104D0 File Offset: 0x0000E6D0
			[Token(Token = "0x60036D6")]
			[Address(RVA = "0x7F1720", Offset = "0x7F0920", VA = "0x1807F1720")]
			public static Eye.EyeLidConfiguration Lerp(Eye.EyeLidConfiguration start, Eye.EyeLidConfiguration end, float lerp)
			{
				return default(Eye.EyeLidConfiguration);
			}

			// Token: 0x040027BB RID: 10171
			[Token(Token = "0x40027BB")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			public float topLidOpen;

			// Token: 0x040027BC RID: 10172
			[Token(Token = "0x40027BC")]
			[FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			public float bottomLidOpen;
		}
	}
}
