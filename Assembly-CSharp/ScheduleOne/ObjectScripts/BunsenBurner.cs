using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000995 RID: 2453
	[Token(Token = "0x2000995")]
	public class BunsenBurner : MonoBehaviour
	{
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x00012AE0 File Offset: 0x00010CE0
		// (set) Token: 0x06004288 RID: 17032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5A")]
		public bool Interactable
		{
			[Token(Token = "0x6004287")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004288")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x00012AF8 File Offset: 0x00010CF8
		// (set) Token: 0x0600428A RID: 17034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5B")]
		public bool IsDialHeld
		{
			[Token(Token = "0x6004289")]
			[Address(RVA = "0x68A2D0", Offset = "0x6894D0", VA = "0x18068A2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600428A")]
			[Address(RVA = "0x570D90", Offset = "0x56FF90", VA = "0x180570D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x00012B10 File Offset: 0x00010D10
		// (set) Token: 0x0600428C RID: 17036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5C")]
		public float CurrentDialValue
		{
			[Token(Token = "0x600428B")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600428C")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x00012B28 File Offset: 0x00010D28
		// (set) Token: 0x0600428E RID: 17038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5D")]
		public float CurrentHeat
		{
			[Token(Token = "0x600428D")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600428E")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428F")]
		[Address(RVA = "0x876480", Offset = "0x875680", VA = "0x180876480")]
		private void Start()
		{
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004290")]
		[Address(RVA = "0x876750", Offset = "0x875950", VA = "0x180876750")]
		private void Update()
		{
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004291")]
		[Address(RVA = "0x8765D0", Offset = "0x8757D0", VA = "0x1808765D0")]
		private void UpdateEffects()
		{
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004292")]
		[Address(RVA = "0x876350", Offset = "0x875550", VA = "0x180876350")]
		public void SetDialPosition(float pos)
		{
		}

		// Token: 0x06004293 RID: 17043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004293")]
		[Address(RVA = "0x876430", Offset = "0x875630", VA = "0x180876430")]
		public void SetInteractable(bool e)
		{
		}

		// Token: 0x06004294 RID: 17044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004294")]
		[Address(RVA = "0x876340", Offset = "0x875540", VA = "0x180876340")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004295")]
		[Address(RVA = "0x81E560", Offset = "0x81D760", VA = "0x18081E560")]
		public void ClickEnd()
		{
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004296")]
		[Address(RVA = "0x876990", Offset = "0x875B90", VA = "0x180876990")]
		public BunsenBurner()
		{
		}

		// Token: 0x0400302C RID: 12332
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x2C")]
		public bool LockDial;

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public Gradient FlameColor;

		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve LightIntensity;

		// Token: 0x0400302F RID: 12335
		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0x40")]
		public float HandleRotationSpeed;

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve FlamePitch;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public ParticleSystem Flame;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x58")]
		public Light Light;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x60")]
		public Transform Handle;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x68")]
		public Clickable HandleClickable;

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x70")]
		public Transform Handle_Min;

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x78")]
		public Transform Handle_Max;

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x80")]
		public Transform Highlight;

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x88")]
		public Animation Anim;

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x90")]
		public AudioSourceController FlameSound;
	}
}
