using System;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks.Tasks;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	public class ApplyAdditiveToPot : GrowContainerPourTask
	{
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x17000468")]
		protected override bool UseCoverage
		{
			[Token(Token = "0x60016D4")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x17000469")]
		protected override GrowContainerCameraHandler.ECameraPosition CameraPosition
		{
			[Token(Token = "0x60016D5")]
			[Address(RVA = "0x5B1DD0", Offset = "0x5B0FD0", VA = "0x1805B1DD0", Slot = "16")]
			get
			{
				return GrowContainerCameraHandler.ECameraPosition.Closeup;
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x5B1BA0", Offset = "0x5B0DA0", VA = "0x1805B1BA0")]
		public ApplyAdditiveToPot(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab)
		{
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x5B1980", Offset = "0x5B0B80", VA = "0x1805B1980", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x5B1920", Offset = "0x5B0B20", VA = "0x1805B1920", Slot = "18")]
		protected override void FullyCovered()
		{
		}

		// Token: 0x04001423 RID: 5155
		[Token(Token = "0x4001423")]
		[FieldOffset(Offset = "0xD0")]
		private AdditiveDefinition def;
	}
}
