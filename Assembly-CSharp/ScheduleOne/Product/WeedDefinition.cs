using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Effects;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000944 RID: 2372
	[Token(Token = "0x2000944")]
	[CreateAssetMenu(fileName = "WeedDefinition", menuName = "ScriptableObjects/Item Definitions/WeedDefinition", order = 1)]
	[Serializable]
	public class WeedDefinition : ProductDefinition
	{
		// Token: 0x06003F91 RID: 16273 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F91")]
		[Address(RVA = "0x86B720", Offset = "0x86A920", VA = "0x18086B720", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x86B950", Offset = "0x86AB50", VA = "0x18086B950")]
		public void Initialize(List<Effect> properties, List<EDrugType> drugTypes, WeedAppearanceSettings _appearance)
		{
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x86B7A0", Offset = "0x86A9A0", VA = "0x18086B7A0", Slot = "33")]
		public override ProductData GetSaveData()
		{
			return null;
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F94")]
		[Address(RVA = "0x86B0B0", Offset = "0x86A2B0", VA = "0x18086B0B0", Slot = "32")]
		public override void GenerateAppearanceSettings()
		{
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F95")]
		[Address(RVA = "0x86AC20", Offset = "0x869E20", VA = "0x18086AC20")]
		private void ApplyAppearanceSettings()
		{
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F96")]
		[Address(RVA = "0x86B100", Offset = "0x86A300", VA = "0x18086B100")]
		public static WeedAppearanceSettings GetAppearanceSettings(List<Effect> properties)
		{
			return null;
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003F97")]
		[Address(RVA = "0x66D790", Offset = "0x66C990", VA = "0x18066D790")]
		public Material GetMaterial(WeedAppearanceSettings.EWeedAppearanceType type)
		{
			return null;
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F98")]
		[Address(RVA = "0x82B740", Offset = "0x82A940", VA = "0x18082B740")]
		public WeedDefinition()
		{
		}

		// Token: 0x04002E3D RID: 11837
		[Token(Token = "0x4002E3D")]
		[FieldOffset(Offset = "0x120")]
		[Header("Weed Materials")]
		public Material MainMat;

		// Token: 0x04002E3E RID: 11838
		[Token(Token = "0x4002E3E")]
		[FieldOffset(Offset = "0x128")]
		public Material SecondaryMat;

		// Token: 0x04002E3F RID: 11839
		[Token(Token = "0x4002E3F")]
		[FieldOffset(Offset = "0x130")]
		public Material LeafMat;

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x138")]
		public Material StemMat;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x140")]
		private WeedAppearanceSettings appearance;
	}
}
