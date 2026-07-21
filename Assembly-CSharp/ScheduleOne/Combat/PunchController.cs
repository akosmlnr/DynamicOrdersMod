using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E2D RID: 3629
	[Token(Token = "0x2000E2D")]
	public class PunchController : MonoBehaviour
	{
		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x0600680B RID: 26635 RVA: 0x00019548 File Offset: 0x00017748
		// (set) Token: 0x0600680C RID: 26636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EC4")]
		public bool PunchingEnabled
		{
			[Token(Token = "0x600680B")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600680C")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x0600680D RID: 26637 RVA: 0x00019560 File Offset: 0x00017760
		[Token(Token = "0x17000EC5")]
		public bool IsLoading
		{
			[Token(Token = "0x600680D")]
			[Address(RVA = "0xAB3E20", Offset = "0xAB3020", VA = "0x180AB3E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x0600680E RID: 26638 RVA: 0x00019578 File Offset: 0x00017778
		// (set) Token: 0x0600680F RID: 26639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EC6")]
		public bool IsPunching
		{
			[Token(Token = "0x600680E")]
			[Address(RVA = "0x68A2D0", Offset = "0x6894D0", VA = "0x18068A2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600680F")]
			[Address(RVA = "0x570D90", Offset = "0x56FF90", VA = "0x180570D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006810")]
		[Address(RVA = "0xAB2570", Offset = "0xAB1770", VA = "0x180AB2570")]
		private void Awake()
		{
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006811")]
		[Address(RVA = "0xAB38E0", Offset = "0xAB2AE0", VA = "0x180AB38E0")]
		private void Start()
		{
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006812")]
		[Address(RVA = "0xAB3CE0", Offset = "0xAB2EE0", VA = "0x180AB3CE0")]
		private void Update()
		{
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006813")]
		[Address(RVA = "0xAB2CD0", Offset = "0xAB1ED0", VA = "0x180AB2CD0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006814")]
		[Address(RVA = "0xAB39E0", Offset = "0xAB2BE0", VA = "0x180AB39E0")]
		private void UpdateCooldown()
		{
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006815")]
		[Address(RVA = "0xAB3A50", Offset = "0xAB2C50", VA = "0x180AB3A50")]
		private void UpdateInput()
		{
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x00019590 File Offset: 0x00017790
		[Token(Token = "0x6006816")]
		[Address(RVA = "0xAB25C0", Offset = "0xAB17C0", VA = "0x180AB25C0")]
		private bool CanStartLoading()
		{
			return default(bool);
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006817")]
		[Address(RVA = "0xAB3640", Offset = "0xAB2840", VA = "0x180AB3640")]
		private void StartLoad()
		{
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006818")]
		[Address(RVA = "0xAB2EE0", Offset = "0xAB20E0", VA = "0x180AB2EE0")]
		private void Release()
		{
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006819")]
		[Address(RVA = "0xAB2D20", Offset = "0xAB1F20", VA = "0x180AB2D20")]
		private void Punch(float power)
		{
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600681A")]
		[Address(RVA = "0xAB2640", Offset = "0xAB1840", VA = "0x180AB2640")]
		private void ExecuteHit(float power)
		{
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600681B")]
		[Address(RVA = "0xAB3230", Offset = "0xAB2430", VA = "0x180AB3230")]
		private void SetPunchingEnabled(bool enabled)
		{
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x000195A8 File Offset: 0x000177A8
		[Token(Token = "0x600681C")]
		[Address(RVA = "0xAB3360", Offset = "0xAB2560", VA = "0x180AB3360")]
		private bool ShouldBeEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600681D")]
		[Address(RVA = "0xAB3DD0", Offset = "0xAB2FD0", VA = "0x180AB3DD0")]
		public PunchController()
		{
		}

		// Token: 0x04004990 RID: 18832
		[Token(Token = "0x4004990")]
		public const float MAX_PUNCH_LOAD = 1f;

		// Token: 0x04004991 RID: 18833
		[Token(Token = "0x4004991")]
		public const float MIN_COOLDOWN = 0.1f;

		// Token: 0x04004992 RID: 18834
		[Token(Token = "0x4004992")]
		public const float MAX_COOLDOWN = 0.2f;

		// Token: 0x04004993 RID: 18835
		[Token(Token = "0x4004993")]
		public const float PUNCH_RANGE = 1.25f;

		// Token: 0x04004994 RID: 18836
		[Token(Token = "0x4004994")]
		public const float PUNCH_DEBOUNCE = 0.1f;

		// Token: 0x04004997 RID: 18839
		[Token(Token = "0x4004997")]
		[FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public Vector3 ViewmodelAvatarOffset;

		// Token: 0x04004998 RID: 18840
		[Token(Token = "0x4004998")]
		[FieldOffset(Offset = "0x30")]
		public float MinPunchDamage;

		// Token: 0x04004999 RID: 18841
		[Token(Token = "0x4004999")]
		[FieldOffset(Offset = "0x34")]
		public float MaxPunchDamage;

		// Token: 0x0400499A RID: 18842
		[Token(Token = "0x400499A")]
		[FieldOffset(Offset = "0x38")]
		public float MinPunchForce;

		// Token: 0x0400499B RID: 18843
		[Token(Token = "0x400499B")]
		[FieldOffset(Offset = "0x3C")]
		public float MaxPunchForce;

		// Token: 0x0400499C RID: 18844
		[Token(Token = "0x400499C")]
		[FieldOffset(Offset = "0x40")]
		[Header("Stamina Settings")]
		public float MinStaminaCost;

		// Token: 0x0400499D RID: 18845
		[Token(Token = "0x400499D")]
		[FieldOffset(Offset = "0x44")]
		public float MaxStaminaCost;

		// Token: 0x0400499E RID: 18846
		[Token(Token = "0x400499E")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public AudioSourceController PunchSound;

		// Token: 0x0400499F RID: 18847
		[Token(Token = "0x400499F")]
		[FieldOffset(Offset = "0x50")]
		public RuntimeAnimatorController PunchAnimator;

		// Token: 0x040049A0 RID: 18848
		[Token(Token = "0x40049A0")]
		[FieldOffset(Offset = "0x58")]
		private float punchLoad;

		// Token: 0x040049A1 RID: 18849
		[Token(Token = "0x40049A1")]
		[FieldOffset(Offset = "0x5C")]
		private float remainingCooldown;

		// Token: 0x040049A2 RID: 18850
		[Token(Token = "0x40049A2")]
		[FieldOffset(Offset = "0x60")]
		private Player player;

		// Token: 0x040049A3 RID: 18851
		[Token(Token = "0x40049A3")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine punchRoutine;

		// Token: 0x040049A4 RID: 18852
		[Token(Token = "0x40049A4")]
		[FieldOffset(Offset = "0x70")]
		private bool itemEquippedLastFrame;

		// Token: 0x040049A5 RID: 18853
		[Token(Token = "0x40049A5")]
		[FieldOffset(Offset = "0x74")]
		private float timeSincePunchingEnabled;
	}
}
