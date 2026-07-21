using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000600 RID: 1536
	[Token(Token = "0x2000600")]
	public class ViewmodelAvatar : Singleton<ViewmodelAvatar>
	{
		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A6")]
		public bool IsVisible
		{
			[Token(Token = "0x60025CE")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60025CF")]
			[Address(RVA = "0x491660", Offset = "0x490860", VA = "0x180491660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x6CF1B0", Offset = "0x6CE3B0", VA = "0x1806CF1B0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x6CF9D0", Offset = "0x6CEBD0", VA = "0x1806CF9D0")]
		public void SetVisibility(bool isVisible)
		{
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x6CF3D0", Offset = "0x6CE5D0", VA = "0x1806CF3D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x6CF600", Offset = "0x6CE800", VA = "0x1806CF600")]
		private void SetBoneTransforms()
		{
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x6CF400", Offset = "0x6CE600", VA = "0x1806CF400")]
		public void SetAppearance(AvatarSettings settings)
		{
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x6CF3E0", Offset = "0x6CE5E0", VA = "0x1806CF3E0")]
		public void SetAnimatorController(RuntimeAnimatorController controller)
		{
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x6CF8E0", Offset = "0x6CEAE0", VA = "0x1806CF8E0")]
		public void SetOffset(Vector3 offset)
		{
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x6CF930", Offset = "0x6CEB30", VA = "0x1806CF930")]
		public void SetRotationOffset(Vector3 eulerAngles)
		{
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x6CFAD0", Offset = "0x6CECD0", VA = "0x1806CFAD0")]
		public ViewmodelAvatar()
		{
		}

		// Token: 0x04001D7A RID: 7546
		[Token(Token = "0x4001D7A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float ArmShift;

		// Token: 0x04001D7B RID: 7547
		[Token(Token = "0x4001D7B")]
		[FieldOffset(Offset = "0x30")]
		public ScheduleOne.AvatarFramework.Avatar ParentAvatar;

		// Token: 0x04001D7C RID: 7548
		[Token(Token = "0x4001D7C")]
		[FieldOffset(Offset = "0x38")]
		public Animator Animator;

		// Token: 0x04001D7D RID: 7549
		[Token(Token = "0x4001D7D")]
		[FieldOffset(Offset = "0x40")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x04001D7E RID: 7550
		[Token(Token = "0x4001D7E")]
		[FieldOffset(Offset = "0x48")]
		public Transform RightHandContainer;

		// Token: 0x04001D7F RID: 7551
		[Token(Token = "0x4001D7F")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _leftShoulderDefaultLocalPos;

		// Token: 0x04001D80 RID: 7552
		[Token(Token = "0x4001D80")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _rightShoulderDefaultLocalPos;
	}
}
