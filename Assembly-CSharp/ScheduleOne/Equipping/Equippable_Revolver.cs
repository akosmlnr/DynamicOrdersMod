using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000960 RID: 2400
	[Token(Token = "0x2000960")]
	public class Equippable_Revolver : Equippable_RangedWeapon
	{
		// Token: 0x0600403B RID: 16443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403B")]
		[Address(RVA = "0x857AB0", Offset = "0x856CB0", VA = "0x180857AB0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403C")]
		[Address(RVA = "0x857AF0", Offset = "0x856CF0", VA = "0x180857AF0", Slot = "9")]
		public override void Fire()
		{
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x857B60", Offset = "0x856D60", VA = "0x180857B60", Slot = "11")]
		public override void Reload()
		{
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x857B30", Offset = "0x856D30", VA = "0x180857B30", Slot = "12")]
		protected override void NotifyIncrementalReload()
		{
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403F")]
		[Address(RVA = "0x857C80", Offset = "0x856E80", VA = "0x180857C80")]
		private void SetDisplayedBullets(int count)
		{
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004040")]
		[Address(RVA = "0x857D30", Offset = "0x856F30", VA = "0x180857D30")]
		public Equippable_Revolver()
		{
		}

		// Token: 0x04002EF5 RID: 12021
		[Token(Token = "0x4002EF5")]
		[FieldOffset(Offset = "0x1B0")]
		public Transform[] Bullets;
	}
}
