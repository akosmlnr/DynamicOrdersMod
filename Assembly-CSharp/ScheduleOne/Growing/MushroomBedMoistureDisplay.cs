using System;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008BA RID: 2234
	[Token(Token = "0x20008BA")]
	public class MushroomBedMoistureDisplay : GrowContainerMoistureDisplay
	{
		// Token: 0x06003B2D RID: 15149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2D")]
		[Address(RVA = "0x818080", Offset = "0x817280", VA = "0x180818080", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2E")]
		[Address(RVA = "0x818180", Offset = "0x817380", VA = "0x180818180", Slot = "5")]
		protected override void UpdateCanvasContents()
		{
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2F")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MushroomBedMoistureDisplay()
		{
		}

		// Token: 0x04002BBD RID: 11197
		[Token(Token = "0x4002BBD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _tooHotIndicator;

		// Token: 0x04002BBE RID: 11198
		[Token(Token = "0x4002BBE")]
		[FieldOffset(Offset = "0x60")]
		private MushroomBed _bed;
	}
}
