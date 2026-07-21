using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	public class Skateboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00008BE0 File Offset: 0x00006DE0
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F3")]
		public bool IsRiding
		{
			[Token(Token = "0x6001357")]
			[Address(RVA = "0x4C0320", Offset = "0x4BF520", VA = "0x1804C0320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001358")]
			[Address(RVA = "0x594500", Offset = "0x593700", VA = "0x180594500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F4")]
		public Skateboard ActiveSkateboard
		{
			[Token(Token = "0x6001359")]
			[Address(RVA = "0x467500", Offset = "0x466700", VA = "0x180467500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600135A")]
			[Address(RVA = "0x5944F0", Offset = "0x5936F0", VA = "0x1805944F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x592EF0", Offset = "0x5920F0", VA = "0x180592EF0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x593010", Offset = "0x592210", VA = "0x180593010")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x594030", Offset = "0x593230", VA = "0x180594030", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x593F10", Offset = "0x593110", VA = "0x180593F10")]
		private void UpdateModel()
		{
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x593E00", Offset = "0x593000", VA = "0x180593E00", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x593AE0", Offset = "0x592CE0", VA = "0x180593AE0")]
		public void Mount()
		{
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x592AC0", Offset = "0x591CC0", VA = "0x180592AC0")]
		public void Dismount()
		{
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00008BF8 File Offset: 0x00006DF8
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x5929D0", Offset = "0x591BD0", VA = "0x1805929D0")]
		private bool CanMountHere()
		{
			return default(bool);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x593060", Offset = "0x592260", VA = "0x180593060")]
		private Pose GetSkateboardSpawnPose()
		{
			return default(Pose);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x5944E0", Offset = "0x5936E0", VA = "0x1805944E0")]
		public Skateboard_Equippable()
		{
		}

		// Token: 0x040011DC RID: 4572
		[Token(Token = "0x40011DC")]
		public const float ModelLerpSpeed = 8f;

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		public const float SurfaceSampleDistance = 0.4f;

		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x40011DE")]
		public const float SurfaceSampleRayLength = 0.7f;

		// Token: 0x040011DF RID: 4575
		[Token(Token = "0x40011DF")]
		public const float BoardSpawnUpwardsShift = 0.05f;

		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x40011E0")]
		public const float BoardSpawnAngleLimit = 30f;

		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x40011E1")]
		public const float MountTime = 0.33f;

		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x40011E2")]
		public const float BoardMomentumTransfer = 1.2f;

		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x40011E3")]
		public const float DismountAngle = 80f;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x70")]
		public Skateboard SkateboardPrefab;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x78")]
		public bool blockDismount;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x80")]
		[Header("References")]
		public Transform ModelContainer;

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		[FieldOffset(Offset = "0x88")]
		public Transform ModelPosition_Raised;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0x90")]
		public Transform ModelPosition_Lowered;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x98")]
		private float mountTime;
	}
}
