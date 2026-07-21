using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000953 RID: 2387
	[Token(Token = "0x2000953")]
	public class Equippable_AvatarViewmodel : Equippable_Viewmodel
	{
		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06003FDF RID: 16351 RVA: 0x000122A0 File Offset: 0x000104A0
		[Token(Token = "0x170009F2")]
		protected bool equipAnimDone
		{
			[Token(Token = "0x6003FDF")]
			[Address(RVA = "0x851C30", Offset = "0x850E30", VA = "0x180851C30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x851630", Offset = "0x850830", VA = "0x180851630", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE1")]
		[Address(RVA = "0x851A20", Offset = "0x850C20", VA = "0x180851A20", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE2")]
		[Address(RVA = "0x8518B0", Offset = "0x850AB0", VA = "0x1808518B0", Slot = "7")]
		protected override void PlayEquipAnimation()
		{
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0x851AD0", Offset = "0x850CD0", VA = "0x180851AD0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x851B10", Offset = "0x850D10", VA = "0x180851B10")]
		public Equippable_AvatarViewmodel()
		{
		}

		// Token: 0x04002E89 RID: 11913
		[Token(Token = "0x4002E89")]
		[FieldOffset(Offset = "0x60")]
		public RuntimeAnimatorController AnimatorController;

		// Token: 0x04002E8A RID: 11914
		[Token(Token = "0x4002E8A")]
		[FieldOffset(Offset = "0x68")]
		public Vector3 ViewmodelAvatarOffset;

		// Token: 0x04002E8B RID: 11915
		[Token(Token = "0x4002E8B")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 ViewmodelAvatarRotationOffset;

		// Token: 0x04002E8C RID: 11916
		[Token(Token = "0x4002E8C")]
		[FieldOffset(Offset = "0x80")]
		[Header("Equipping")]
		public float EquipTime;

		// Token: 0x04002E8D RID: 11917
		[Token(Token = "0x4002E8D")]
		[FieldOffset(Offset = "0x88")]
		public string EquipTrigger;

		// Token: 0x04002E8E RID: 11918
		[Token(Token = "0x4002E8E")]
		[FieldOffset(Offset = "0x90")]
		protected float timeEquipped;
	}
}
