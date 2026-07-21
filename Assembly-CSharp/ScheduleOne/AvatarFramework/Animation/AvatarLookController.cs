using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000829 RID: 2089
	[Token(Token = "0x2000829")]
	public class AvatarLookController : MonoBehaviour
	{
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x000108A8 File Offset: 0x0000EAA8
		// (set) Token: 0x06003820 RID: 14368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E6")]
		public float BodyRotationSpeedMultiplier
		{
			[Token(Token = "0x600381F")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003820")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003821")]
		[Address(RVA = "0x7E8940", Offset = "0x7E7B40", VA = "0x1807E8940")]
		private void Awake()
		{
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003822")]
		[Address(RVA = "0x7EA010", Offset = "0x7E9210", VA = "0x1807EA010")]
		private void UpdateLook()
		{
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003823")]
		[Address(RVA = "0x7EAAF0", Offset = "0x7E9CF0", VA = "0x1807EAAF0")]
		private void UpdateNearestPlayer()
		{
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003824")]
		[Address(RVA = "0x7E9030", Offset = "0x7E8230", VA = "0x1807E9030")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003825")]
		[Address(RVA = "0x7E9C70", Offset = "0x7E8E70", VA = "0x1807E9C70")]
		public void OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = false)
		{
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003826")]
		[Address(RVA = "0x7E8CC0", Offset = "0x7E7EC0", VA = "0x1807E8CC0")]
		public void BlockLookTargetOverrides()
		{
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x7E9AF0", Offset = "0x7E8CF0", VA = "0x1807E9AF0")]
		private void LookForward()
		{
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x7E9770", Offset = "0x7E8970", VA = "0x1807E9770")]
		private void LerpTargetTransform()
		{
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x7E8F20", Offset = "0x7E8120", VA = "0x1807E8F20")]
		private Player GetNearestPlayer()
		{
			return null;
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x000108C0 File Offset: 0x0000EAC0
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x7E8CD0", Offset = "0x7E7ED0", VA = "0x1807E8CD0")]
		private bool CanLookAt(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		protected void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382C")]
		[Address(RVA = "0x7E9C40", Offset = "0x7E8E40", VA = "0x1807E9C40")]
		public void OverrideIKWeight(float weight)
		{
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x7E9E90", Offset = "0x7E9090", VA = "0x1807E9E90")]
		public void ResetIKWeight()
		{
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382E")]
		[Address(RVA = "0x7EAF40", Offset = "0x7EA140", VA = "0x1807EAF40")]
		public AvatarLookController()
		{
		}

		// Token: 0x0400290E RID: 10510
		[Token(Token = "0x400290E")]
		public const float LookAtPlayerRange = 4f;

		// Token: 0x0400290F RID: 10511
		[Token(Token = "0x400290F")]
		public const float EyeContractRange = 10f;

		// Token: 0x04002910 RID: 10512
		[Token(Token = "0x4002910")]
		[FieldOffset(Offset = "0x0")]
		public static Transform TempContainer;

		// Token: 0x04002911 RID: 10513
		[Token(Token = "0x4002911")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04002913 RID: 10515
		[Token(Token = "0x4002913")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public AimIK Aim;

		// Token: 0x04002914 RID: 10516
		[Token(Token = "0x4002914")]
		[FieldOffset(Offset = "0x30")]
		public Transform HeadBone;

		// Token: 0x04002915 RID: 10517
		[Token(Token = "0x4002915")]
		[FieldOffset(Offset = "0x38")]
		public Transform LookForwardTarget;

		// Token: 0x04002916 RID: 10518
		[Token(Token = "0x4002916")]
		[FieldOffset(Offset = "0x40")]
		public Transform LookOrigin;

		// Token: 0x04002917 RID: 10519
		[Token(Token = "0x4002917")]
		[FieldOffset(Offset = "0x48")]
		public EyeController Eyes;

		// Token: 0x04002918 RID: 10520
		[Token(Token = "0x4002918")]
		[FieldOffset(Offset = "0x50")]
		[Header("Optional NPC reference")]
		public NPC NPC;

		// Token: 0x04002919 RID: 10521
		[Token(Token = "0x4002919")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public bool AutoLookAtPlayer;

		// Token: 0x0400291A RID: 10522
		[Token(Token = "0x400291A")]
		[FieldOffset(Offset = "0x5C")]
		public float LookLerpSpeed;

		// Token: 0x0400291B RID: 10523
		[Token(Token = "0x400291B")]
		[FieldOffset(Offset = "0x60")]
		public float AimIKWeight;

		// Token: 0x0400291C RID: 10524
		[Token(Token = "0x400291C")]
		[FieldOffset(Offset = "0x64")]
		public float BodyRotationSpeed;

		// Token: 0x0400291D RID: 10525
		[Token(Token = "0x400291D")]
		[FieldOffset(Offset = "0x68")]
		private Avatar avatar;

		// Token: 0x0400291E RID: 10526
		[Token(Token = "0x400291E")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 lookAtPos;

		// Token: 0x0400291F RID: 10527
		[Token(Token = "0x400291F")]
		[FieldOffset(Offset = "0x80")]
		private Transform lookAtTarget;

		// Token: 0x04002920 RID: 10528
		[Token(Token = "0x4002920")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 lastFrameOffset;

		// Token: 0x04002921 RID: 10529
		[Token(Token = "0x4002921")]
		[FieldOffset(Offset = "0x94")]
		private bool overrideLookAt;

		// Token: 0x04002922 RID: 10530
		[Token(Token = "0x4002922")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 overriddenLookTarget;

		// Token: 0x04002923 RID: 10531
		[Token(Token = "0x4002923")]
		[FieldOffset(Offset = "0xA4")]
		private int overrideLookPriority;

		// Token: 0x04002924 RID: 10532
		[Token(Token = "0x4002924")]
		[FieldOffset(Offset = "0xA8")]
		private bool overrideRotateBody;

		// Token: 0x04002925 RID: 10533
		[Token(Token = "0x4002925")]
		[FieldOffset(Offset = "0xA9")]
		private bool blockLookOverrides;

		// Token: 0x04002926 RID: 10534
		[Token(Token = "0x4002926")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 lastFrameLookOriginPos;

		// Token: 0x04002927 RID: 10535
		[Token(Token = "0x4002927")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 lastFrameLookOriginForward;

		// Token: 0x04002928 RID: 10536
		[Token(Token = "0x4002928")]
		[FieldOffset(Offset = "0xC8")]
		public Transform ForceLookTarget;

		// Token: 0x04002929 RID: 10537
		[Token(Token = "0x4002929")]
		[FieldOffset(Offset = "0xD0")]
		public bool ForceLookRotateBody;

		// Token: 0x0400292A RID: 10538
		[Token(Token = "0x400292A")]
		[FieldOffset(Offset = "0xD4")]
		private float defaultIKWeight;

		// Token: 0x0400292B RID: 10539
		[Token(Token = "0x400292B")]
		[FieldOffset(Offset = "0xD8")]
		private Player nearestPlayer;

		// Token: 0x0400292C RID: 10540
		[Token(Token = "0x400292C")]
		[FieldOffset(Offset = "0xE0")]
		private float nearestPlayerDist;

		// Token: 0x0400292D RID: 10541
		[Token(Token = "0x400292D")]
		[FieldOffset(Offset = "0xE4")]
		private float localPlayerDist;

		// Token: 0x0400292E RID: 10542
		[Token(Token = "0x400292E")]
		[FieldOffset(Offset = "0xE8")]
		private float cullRange;
	}
}
