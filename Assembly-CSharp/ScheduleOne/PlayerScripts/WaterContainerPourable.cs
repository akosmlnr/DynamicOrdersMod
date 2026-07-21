using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000602 RID: 1538
	[Token(Token = "0x2000602")]
	public class WaterContainerPourable : Pourable
	{
		// Token: 0x060025E9 RID: 9705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E9")]
		[Address(RVA = "0x6D1F30", Offset = "0x6D1130", VA = "0x1806D1F30")]
		public void SetupWaterContainerPourable(WaterContainerInstance waterContainer)
		{
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EA")]
		[Address(RVA = "0x6D1E10", Offset = "0x6D1010", VA = "0x1806D1E10")]
		private void OnDestroy()
		{
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x6D1E90", Offset = "0x6D1090", VA = "0x1806D1E90", Slot = "16")]
		protected override void PourAmount(float amount)
		{
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x6D2000", Offset = "0x6D1200", VA = "0x1806D2000")]
		public WaterContainerPourable()
		{
		}

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private WaterContainerVisualizer _visuals;

		// Token: 0x04001DB1 RID: 7601
		[Token(Token = "0x4001DB1")]
		[FieldOffset(Offset = "0x148")]
		private WaterContainerInstance _waterContainerItem;
	}
}
