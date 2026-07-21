using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200099C RID: 2460
	[Token(Token = "0x200099C")]
	public class StirringRod : MonoBehaviour
	{
		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x00012CC0 File Offset: 0x00010EC0
		// (set) Token: 0x0600433F RID: 17215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7C")]
		public bool Interactable
		{
			[Token(Token = "0x600433E")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600433F")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x00012CD8 File Offset: 0x00010ED8
		// (set) Token: 0x06004341 RID: 17217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7D")]
		public float CurrentStirringSpeed
		{
			[Token(Token = "0x6004340")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004341")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004342")]
		[Address(RVA = "0x8A0050", Offset = "0x89F250", VA = "0x1808A0050")]
		private void Start()
		{
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x8A0170", Offset = "0x89F370", VA = "0x1808A0170")]
		private void Update()
		{
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004344")]
		[Address(RVA = "0x89F9F0", Offset = "0x89EBF0", VA = "0x18089F9F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004345")]
		[Address(RVA = "0x8A0030", Offset = "0x89F230", VA = "0x1808A0030")]
		public void SetInteractable(bool e)
		{
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x89F620", Offset = "0x89E820", VA = "0x18089F620")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00012CF0 File Offset: 0x00010EF0
		[Token(Token = "0x6004347")]
		[Address(RVA = "0x89F720", Offset = "0x89E920", VA = "0x18089F720")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004348")]
		[Address(RVA = "0x89F610", Offset = "0x89E810", VA = "0x18089F610")]
		public void ClickEnd()
		{
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004349")]
		[Address(RVA = "0x89F6C0", Offset = "0x89E8C0", VA = "0x18089F6C0")]
		public void Destroy()
		{
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x8A02A0", Offset = "0x89F4A0", VA = "0x1808A02A0")]
		public StirringRod()
		{
		}

		// Token: 0x04003090 RID: 12432
		[Token(Token = "0x4003090")]
		public const float MAX_STIR_RATE = 20f;

		// Token: 0x04003091 RID: 12433
		[Token(Token = "0x4003091")]
		public const float MAX_PIVOT_ANGLE = 7f;

		// Token: 0x04003094 RID: 12436
		[Token(Token = "0x4003094")]
		[FieldOffset(Offset = "0x28")]
		public float LerpSpeed;

		// Token: 0x04003095 RID: 12437
		[Token(Token = "0x4003095")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Clickable Clickable;

		// Token: 0x04003096 RID: 12438
		[Token(Token = "0x4003096")]
		[FieldOffset(Offset = "0x38")]
		public Transform PlaneNormal;

		// Token: 0x04003097 RID: 12439
		[Token(Token = "0x4003097")]
		[FieldOffset(Offset = "0x40")]
		public Transform Container;

		// Token: 0x04003098 RID: 12440
		[Token(Token = "0x4003098")]
		[FieldOffset(Offset = "0x48")]
		public Transform RodPivot;

		// Token: 0x04003099 RID: 12441
		[Token(Token = "0x4003099")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController StirSound;

		// Token: 0x0400309A RID: 12442
		[Token(Token = "0x400309A")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 clickOffset;

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0x64")]
		private bool isMoving;
	}
}
