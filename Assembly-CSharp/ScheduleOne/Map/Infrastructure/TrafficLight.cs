using System;
using Il2CppDummyDll;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	// Token: 0x02000559 RID: 1369
	[Token(Token = "0x2000559")]
	public class TrafficLight : MonoBehaviour
	{
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x0000AE00 File Offset: 0x00009000
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057C")]
		public TrafficLight.State CurrentState
		{
			[Token(Token = "0x6001E88")]
			[Address(RVA = "0x494480", Offset = "0x493680", VA = "0x180494480")]
			get
			{
				return TrafficLight.State.Red;
			}
			[Token(Token = "0x6001E89")]
			[Address(RVA = "0x64CCA0", Offset = "0x64BEA0", VA = "0x18064CCA0")]
			set
			{
			}
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0x64CC40", Offset = "0x64BE40", VA = "0x18064CC40", Slot = "4")]
		protected virtual void ApplyState()
		{
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TrafficLight()
		{
		}

		// Token: 0x04001999 RID: 6553
		[Token(Token = "0x4001999")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ToggleableLight _redLight;

		// Token: 0x0400199A RID: 6554
		[Token(Token = "0x400199A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ToggleableLight _orangeLight;

		// Token: 0x0400199B RID: 6555
		[Token(Token = "0x400199B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ToggleableLight _greenLight;

		// Token: 0x0400199C RID: 6556
		[Token(Token = "0x400199C")]
		[FieldOffset(Offset = "0x38")]
		private TrafficLight.State _state;

		// Token: 0x0200055A RID: 1370
		[Token(Token = "0x200055A")]
		public enum State
		{
			// Token: 0x0400199E RID: 6558
			[Token(Token = "0x400199E")]
			Red,
			// Token: 0x0400199F RID: 6559
			[Token(Token = "0x400199F")]
			Orange,
			// Token: 0x040019A0 RID: 6560
			[Token(Token = "0x40019A0")]
			Green
		}
	}
}
