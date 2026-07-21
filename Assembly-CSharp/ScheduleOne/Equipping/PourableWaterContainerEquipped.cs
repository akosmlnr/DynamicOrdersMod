using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000968 RID: 2408
	[Token(Token = "0x2000968")]
	public class PourableWaterContainerEquipped : Equippable_Pourable
	{
		// Token: 0x06004077 RID: 16503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004077")]
		[Address(RVA = "0x861870", Offset = "0x860A70", VA = "0x180861870", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004078")]
		[Address(RVA = "0x861A20", Offset = "0x860C20", VA = "0x180861A20", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x00012540 File Offset: 0x00010740
		[Token(Token = "0x6004079")]
		[Address(RVA = "0x861690", Offset = "0x860890", VA = "0x180861690", Slot = "11")]
		protected override bool CanPour(GrowContainer growContainer, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407A")]
		[Address(RVA = "0x8619B0", Offset = "0x860BB0", VA = "0x1808619B0", Slot = "10")]
		protected override void StartPourTask(GrowContainer growContainer)
		{
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407B")]
		[Address(RVA = "0x851620", Offset = "0x850820", VA = "0x180851620")]
		public PourableWaterContainerEquipped()
		{
		}

		// Token: 0x04002F0D RID: 12045
		[Token(Token = "0x4002F0D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private WaterContainerVisualizer _visuals;

		// Token: 0x04002F0E RID: 12046
		[Token(Token = "0x4002F0E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private WaterContainerPourable _pourablePrefab;

		// Token: 0x04002F0F RID: 12047
		[Token(Token = "0x4002F0F")]
		[FieldOffset(Offset = "0x80")]
		private WaterContainerInstance _waterContainerInstance;
	}
}
