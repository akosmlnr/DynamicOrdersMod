using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Lighting;
using ScheduleOne.Misc;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009BC RID: 2492
	[Token(Token = "0x20009BC")]
	public class GrowLight : ProceduralGridItem
	{
		// Token: 0x0600467A RID: 18042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600467A")]
		[Address(RVA = "0x8B9F20", Offset = "0x8B9120", VA = "0x1808B9F20", Slot = "67")]
		public override void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600467B")]
		[Address(RVA = "0x8BA1F0", Offset = "0x8B93F0", VA = "0x1808BA1F0")]
		public void SetIsOn(bool isOn)
		{
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600467C")]
		[Address(RVA = "0x8B9D10", Offset = "0x8B8F10", VA = "0x1808B9D10", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600467D")]
		[Address(RVA = "0x8BA230", Offset = "0x8B9430", VA = "0x1808BA230")]
		public GrowLight()
		{
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600467E")]
		[Address(RVA = "0x8BA1D0", Offset = "0x8B93D0", VA = "0x1808BA1D0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600467F")]
		[Address(RVA = "0x8BA1B0", Offset = "0x8B93B0", VA = "0x1808BA1B0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004680")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004681")]
		[Address(RVA = "0x8B9CC0", Offset = "0x8B8EC0", VA = "0x1808B9CC0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04003224 RID: 12836
		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x200")]
		[Header("References")]
		public ToggleableLight Light;

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x208")]
		public UsableLightSource usableLightSource;

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x210")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted;

		// Token: 0x04003227 RID: 12839
		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x211")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted;
	}
}
