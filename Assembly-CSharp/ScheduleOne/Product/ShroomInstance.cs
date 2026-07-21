using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.FX;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000936 RID: 2358
	[Token(Token = "0x2000936")]
	[Serializable]
	public class ShroomInstance : ProductItemInstance
	{
		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009E6")]
		public override string Name
		{
			[Token(Token = "0x6003F66")]
			[Address(RVA = "0x8674B0", Offset = "0x8666B0", VA = "0x1808674B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06003F67 RID: 16231 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170009E7")]
		private ShroomDefinition _shroomDefinition
		{
			[Token(Token = "0x6003F67")]
			[Address(RVA = "0x867530", Offset = "0x866730", VA = "0x180867530")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F68")]
		[Address(RVA = "0x82C480", Offset = "0x82B680", VA = "0x18082C480")]
		public ShroomInstance(ItemDefinition definition, int quantity, EQuality quality, [Optional] PackagingDefinition packaging)
		{
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F69")]
		[Address(RVA = "0x867320", Offset = "0x866520", VA = "0x180867320", Slot = "16")]
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x8673D0", Offset = "0x8665D0", VA = "0x1808673D0", Slot = "17")]
		public override ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x8667B0", Offset = "0x8659B0", VA = "0x1808667B0", Slot = "23")]
		public override void ApplyEffectsToNPC(NPC npc)
		{
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x866D10", Offset = "0x865F10", VA = "0x180866D10", Slot = "24")]
		public override void ClearEffectsFromNPC(NPC npc)
		{
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x866800", Offset = "0x865A00", VA = "0x180866800", Slot = "25")]
		public override void ApplyEffectsToPlayer(Player player)
		{
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x866DD0", Offset = "0x865FD0", VA = "0x180866DD0", Slot = "26")]
		public override void ClearEffectsFromPlayer(Player player)
		{
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x866660", Offset = "0x865860", VA = "0x180866660")]
		private void ApplyEffectsToAvatar(ScheduleOne.AvatarFramework.Avatar avatar)
		{
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x866C90", Offset = "0x865E90", VA = "0x180866C90")]
		private void ClearEffectsFromAvatar(ScheduleOne.AvatarFramework.Avatar avatar)
		{
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x867290", Offset = "0x866490", VA = "0x180867290")]
		private IEnumerator DoPsychedlicEffectBlend(PsychedelicFullScreenFeature.MaterialProperties targetMaterialProperties, float targetValuePercentage, float duration)
		{
			return null;
		}

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Coroutine _psychedelicEffectCoroutine;
	}
}
