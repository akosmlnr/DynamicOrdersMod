using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x0200082F RID: 2095
	[Token(Token = "0x200082F")]
	public class AvatarEquippable : MonoBehaviour
	{
		// Token: 0x06003841 RID: 14401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003841")]
		[Address(RVA = "0x7E6E60", Offset = "0x7E6060", VA = "0x1807E6E60")]
		[Button]
		public void RecalculateAssetPath()
		{
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x7E66A0", Offset = "0x7E58A0", VA = "0x1807E66A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x7E6760", Offset = "0x7E5960", VA = "0x1807E6760", Slot = "5")]
		public virtual void Equip(Avatar _avatar)
		{
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x7E6950", Offset = "0x7E5B50", VA = "0x1807E6950", Slot = "6")]
		public virtual void InitializeAnimation()
		{
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x7E73B0", Offset = "0x7E65B0", VA = "0x1807E73B0", Slot = "7")]
		public virtual void Unequip()
		{
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003846")]
		[Address(RVA = "0x7E6A40", Offset = "0x7E5C40", VA = "0x1807E6A40")]
		private void PositionAnimationModel()
		{
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003847")]
		[Address(RVA = "0x7E7200", Offset = "0x7E6400", VA = "0x1807E7200")]
		protected void SetTrigger(string anim)
		{
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x7E70B0", Offset = "0x7E62B0", VA = "0x1807E70B0")]
		protected void SetBool(string anim, bool val)
		{
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x7E6F70", Offset = "0x7E6170", VA = "0x1807E6F70")]
		protected void ResetTrigger(string anim)
		{
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "8")]
		public virtual void ReceiveMessage(string message, object parameter)
		{
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x7E7440", Offset = "0x7E6640", VA = "0x1807E7440")]
		public AvatarEquippable()
		{
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x7E7340", Offset = "0x7E6540", VA = "0x1807E7340")]
		[CompilerGenerated]
		private IEnumerator <InitializeAnimation>g__Wait|13_0()
		{
			return null;
		}

		// Token: 0x0400293A RID: 10554
		[Token(Token = "0x400293A")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public Transform AlignmentPoint;

		// Token: 0x0400293B RID: 10555
		[Token(Token = "0x400293B")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float Suspiciousness;

		// Token: 0x0400293C RID: 10556
		[Token(Token = "0x400293C")]
		[FieldOffset(Offset = "0x2C")]
		public AvatarEquippable.EHand Hand;

		// Token: 0x0400293D RID: 10557
		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x30")]
		public AvatarEquippable.ETriggerType TriggerType;

		// Token: 0x0400293E RID: 10558
		[Token(Token = "0x400293E")]
		[FieldOffset(Offset = "0x38")]
		public string AnimationTrigger;

		// Token: 0x0400293F RID: 10559
		[Token(Token = "0x400293F")]
		[FieldOffset(Offset = "0x40")]
		private bool _equipped;

		// Token: 0x04002940 RID: 10560
		[Token(Token = "0x4002940")]
		[FieldOffset(Offset = "0x48")]
		public string AssetPath;

		// Token: 0x04002941 RID: 10561
		[Token(Token = "0x4002941")]
		[FieldOffset(Offset = "0x50")]
		protected Avatar avatar;

		// Token: 0x02000830 RID: 2096
		[Token(Token = "0x2000830")]
		public enum ETriggerType
		{
			// Token: 0x04002943 RID: 10563
			[Token(Token = "0x4002943")]
			Trigger,
			// Token: 0x04002944 RID: 10564
			[Token(Token = "0x4002944")]
			Bool
		}

		// Token: 0x02000831 RID: 2097
		[Token(Token = "0x2000831")]
		public enum EHand
		{
			// Token: 0x04002946 RID: 10566
			[Token(Token = "0x4002946")]
			Left,
			// Token: 0x04002947 RID: 10567
			[Token(Token = "0x4002947")]
			Right
		}
	}
}
