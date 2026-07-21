using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x20007F1")]
	[ExecuteInEditMode]
	public class EyeController : MonoBehaviour
	{
		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060036F1 RID: 14065 RVA: 0x00010518 File Offset: 0x0000E718
		// (set) Token: 0x060036F2 RID: 14066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C5")]
		public bool EyesOpen
		{
			[Token(Token = "0x60036F1")]
			[Address(RVA = "0x68A2D0", Offset = "0x6894D0", VA = "0x18068A2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60036F2")]
			[Address(RVA = "0x570D90", Offset = "0x56FF90", VA = "0x180570D90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x7F0A70", Offset = "0x7EFC70", VA = "0x1807F0A70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x7F1540", Offset = "0x7F0740", VA = "0x1807F1540")]
		protected void Update()
		{
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x7F0A10", Offset = "0x7EFC10", VA = "0x1807F0A10")]
		private void OnEnable()
		{
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x7F1230", Offset = "0x7F0430", VA = "0x1807F1230")]
		public void SetEyeballTint(Color col, bool overrideDefault = false)
		{
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x7F1050", Offset = "0x7F0250", VA = "0x1807F1050")]
		public void ResetEyeballTint()
		{
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x7F0E90", Offset = "0x7F0090", VA = "0x1807F0E90")]
		public void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration)
		{
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x7F0FE0", Offset = "0x7F01E0", VA = "0x1807F0FE0")]
		public void ResetEyeLids()
		{
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x7F0EC0", Offset = "0x7F00C0", VA = "0x1807F0EC0")]
		private void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim)
		{
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x7F12D0", Offset = "0x7F04D0", VA = "0x1807F12D0")]
		public void SetEyesOpen(bool open)
		{
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FC")]
		[Address(RVA = "0x7F09A0", Offset = "0x7EFBA0", VA = "0x1807F09A0")]
		private void ApplyDilation()
		{
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FD")]
		[Address(RVA = "0x7F1460", Offset = "0x7F0660", VA = "0x1807F1460")]
		public void SetPupilDilation(float dilation, bool writeDefault = true)
		{
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x7F1160", Offset = "0x7F0360", VA = "0x1807F1160")]
		public void SetEyeballMaterial(Material material)
		{
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x7F1000", Offset = "0x7F0200", VA = "0x1807F1000")]
		public void ResetEyeballMaterial()
		{
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003700")]
		[Address(RVA = "0x7F10E0", Offset = "0x7F02E0", VA = "0x1807F10E0")]
		public void ResetPupilDilation()
		{
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x7F0A10", Offset = "0x7EFC10", VA = "0x1807F0A10")]
		private void ApplyRestingEyeLidState()
		{
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x7F0D40", Offset = "0x7EFF40", VA = "0x1807F0D40")]
		public void ForceBlink()
		{
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x7F1420", Offset = "0x7F0620", VA = "0x1807F1420")]
		public void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x7F14F0", Offset = "0x7F06F0", VA = "0x1807F14F0")]
		public void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x7F0CD0", Offset = "0x7EFED0", VA = "0x1807F0CD0")]
		private IEnumerator BlinkRoutine()
		{
			return null;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x7F0F90", Offset = "0x7F0190", VA = "0x1807F0F90")]
		private void ResetBlinkCounter()
		{
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x7F0E00", Offset = "0x7F0000", VA = "0x1807F0E00")]
		public void LookAt(Vector3 position, bool instant = false)
		{
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x7F16C0", Offset = "0x7F08C0", VA = "0x1807F16C0")]
		public EyeController()
		{
		}

		// Token: 0x040027E0 RID: 10208
		[Token(Token = "0x40027E0")]
		[FieldOffset(Offset = "0x0")]
		private static float eyeHeightMultiplier;

		// Token: 0x040027E1 RID: 10209
		[Token(Token = "0x40027E1")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x040027E3 RID: 10211
		[Token(Token = "0x40027E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		public Eye leftEye;

		// Token: 0x040027E4 RID: 10212
		[Token(Token = "0x40027E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Eye rightEye;

		// Token: 0x040027E5 RID: 10213
		[Token(Token = "0x40027E5")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 45f)]
		[SerializeField]
		[Header("Location Settings")]
		protected float eyeSpacing;

		// Token: 0x040027E6 RID: 10214
		[Token(Token = "0x40027E6")]
		[FieldOffset(Offset = "0x3C")]
		[Range(-1f, 1f)]
		[SerializeField]
		protected float eyeHeight;

		// Token: 0x040027E7 RID: 10215
		[Token(Token = "0x40027E7")]
		[FieldOffset(Offset = "0x40")]
		[Range(0.5f, 1.5f)]
		[SerializeField]
		protected float eyeSize;

		// Token: 0x040027E8 RID: 10216
		[Token(Token = "0x40027E8")]
		[FieldOffset(Offset = "0x44")]
		[Header("Eyelid Settings")]
		public Eye.EyeLidConfiguration LeftRestingEyeState;

		// Token: 0x040027E9 RID: 10217
		[Token(Token = "0x40027E9")]
		[FieldOffset(Offset = "0x4C")]
		public Eye.EyeLidConfiguration RightRestingEyeState;

		// Token: 0x040027EA RID: 10218
		[Token(Token = "0x40027EA")]
		[FieldOffset(Offset = "0x58")]
		[Header("Eyeball Settings")]
		[SerializeField]
		protected Material eyeBallMaterial;

		// Token: 0x040027EB RID: 10219
		[Token(Token = "0x40027EB")]
		[FieldOffset(Offset = "0x60")]
		[Header("Pupil State")]
		[Range(0f, 1f)]
		public float PupilDilation;

		// Token: 0x040027EC RID: 10220
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x64")]
		[Header("Blinking Settings")]
		public bool BlinkingEnabled;

		// Token: 0x040027ED RID: 10221
		[Token(Token = "0x40027ED")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Range(0f, 10f)]
		protected float blinkInterval;

		// Token: 0x040027EE RID: 10222
		[Token(Token = "0x40027EE")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Range(0f, 2f)]
		protected float blinkIntervalSpread;

		// Token: 0x040027EF RID: 10223
		[Token(Token = "0x40027EF")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		[SerializeField]
		protected float blinkDuration;

		// Token: 0x040027F0 RID: 10224
		[Token(Token = "0x40027F0")]
		[FieldOffset(Offset = "0x78")]
		private Avatar avatar;

		// Token: 0x040027F1 RID: 10225
		[Token(Token = "0x40027F1")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine blinkRoutine;

		// Token: 0x040027F2 RID: 10226
		[Token(Token = "0x40027F2")]
		[FieldOffset(Offset = "0x88")]
		private float timeUntilNextBlink;

		// Token: 0x040027F3 RID: 10227
		[Token(Token = "0x40027F3")]
		[FieldOffset(Offset = "0x8C")]
		private bool eyeBallTintOverridden;

		// Token: 0x040027F4 RID: 10228
		[Token(Token = "0x40027F4")]
		[FieldOffset(Offset = "0x8D")]
		private bool eyeLidOverridden;

		// Token: 0x040027F5 RID: 10229
		[Token(Token = "0x40027F5")]
		[FieldOffset(Offset = "0x90")]
		private Eye.EyeLidConfiguration defaultLeftEyeRestingState;

		// Token: 0x040027F6 RID: 10230
		[Token(Token = "0x40027F6")]
		[FieldOffset(Offset = "0x98")]
		private Eye.EyeLidConfiguration defaultRightEyeRestingState;

		// Token: 0x040027F7 RID: 10231
		[Token(Token = "0x40027F7")]
		[FieldOffset(Offset = "0xA0")]
		private float defaultDilation;

		// Token: 0x040027F8 RID: 10232
		[Token(Token = "0x40027F8")]
		[FieldOffset(Offset = "0xA4")]
		private Color defaultEyeballColor;

		// Token: 0x040027F9 RID: 10233
		[Token(Token = "0x40027F9")]
		[FieldOffset(Offset = "0xB4")]
		private Color currentEyeballColor;
	}
}
