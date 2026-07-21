using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x2000737")]
	[RequireComponent(typeof(Animation))]
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x0000F018 File Offset: 0x0000D218
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F4")]
		public bool IsPlaying
		{
			[Token(Token = "0x600306A")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600306B")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x7603F0", Offset = "0x75F5F0", VA = "0x1807603F0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306D")]
		[Address(RVA = "0x7607B0", Offset = "0x75F9B0", VA = "0x1807607B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306E")]
		[Address(RVA = "0x7608C0", Offset = "0x75FAC0", VA = "0x1807608C0", Slot = "5")]
		public virtual void Play()
		{
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306F")]
		[Address(RVA = "0x760440", Offset = "0x75F640", VA = "0x180760440")]
		public void InvokeEnd()
		{
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003070")]
		[Address(RVA = "0x760CB0", Offset = "0x75FEB0", VA = "0x180760CB0")]
		public Cutscene()
		{
		}

		// Token: 0x040023A1 RID: 9121
		[Token(Token = "0x40023A1")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public string Name;

		// Token: 0x040023A2 RID: 9122
		[Token(Token = "0x40023A2")]
		[FieldOffset(Offset = "0x30")]
		public bool DisablePlayerControl;

		// Token: 0x040023A3 RID: 9123
		[Token(Token = "0x40023A3")]
		[FieldOffset(Offset = "0x31")]
		public bool OverrideFOV;

		// Token: 0x040023A4 RID: 9124
		[Token(Token = "0x40023A4")]
		[FieldOffset(Offset = "0x34")]
		public float CameraFOV;

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform CameraControl;

		// Token: 0x040023A6 RID: 9126
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x40")]
		[Header("Events")]
		public UnityEvent onPlay;

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onEnd;

		// Token: 0x040023A8 RID: 9128
		[Token(Token = "0x40023A8")]
		[FieldOffset(Offset = "0x50")]
		private Animation animation;
	}
}
