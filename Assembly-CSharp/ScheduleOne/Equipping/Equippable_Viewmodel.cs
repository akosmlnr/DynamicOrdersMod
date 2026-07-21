using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000963 RID: 2403
	[Token(Token = "0x2000963")]
	public class Equippable_Viewmodel : Equippable
	{
		// Token: 0x0600404A RID: 16458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404A")]
		[Address(RVA = "0x85A1A0", Offset = "0x8593A0", VA = "0x18085A1A0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404B")]
		[Address(RVA = "0x85A5D0", Offset = "0x8597D0", VA = "0x18085A5D0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404C")]
		[Address(RVA = "0x85A450", Offset = "0x859650", VA = "0x18085A450", Slot = "7")]
		protected virtual void PlayEquipAnimation()
		{
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404D")]
		[Address(RVA = "0x85A510", Offset = "0x859710", VA = "0x18085A510", Slot = "8")]
		protected virtual void PlayUnequipAnimation()
		{
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x858100", Offset = "0x857300", VA = "0x180858100")]
		public Equippable_Viewmodel()
		{
		}

		// Token: 0x04002EFB RID: 12027
		[Token(Token = "0x4002EFB")]
		[FieldOffset(Offset = "0x30")]
		[Header("Viewmodel settings")]
		public Vector3 localPosition;

		// Token: 0x04002EFC RID: 12028
		[Token(Token = "0x4002EFC")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 localEulerAngles;

		// Token: 0x04002EFD RID: 12029
		[Token(Token = "0x4002EFD")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 localScale;

		// Token: 0x04002EFE RID: 12030
		[Token(Token = "0x4002EFE")]
		[FieldOffset(Offset = "0x58")]
		[Header("Third person animation settings")]
		public AvatarEquippable AvatarEquippable;
	}
}
