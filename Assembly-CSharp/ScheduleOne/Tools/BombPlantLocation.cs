using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200084D RID: 2125
	[Token(Token = "0x200084D")]
	public class BombPlantLocation : MonoBehaviour
	{
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x00010B30 File Offset: 0x0000ED30
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FA")]
		public bool BombPlanted
		{
			[Token(Token = "0x60038CF")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60038D0")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x7F8010", Offset = "0x7F7210", VA = "0x1807F8010")]
		private void Awake()
		{
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x7F81D0", Offset = "0x7F73D0", VA = "0x1807F81D0")]
		private void Hovered()
		{
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D3")]
		[Address(RVA = "0x7F8250", Offset = "0x7F7450", VA = "0x1807F8250")]
		private void Interacted()
		{
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D4")]
		[Address(RVA = "0x7F8280", Offset = "0x7F7480", VA = "0x1807F8280")]
		public void PlantBomb()
		{
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x00010B48 File Offset: 0x0000ED48
		[Token(Token = "0x60038D5")]
		[Address(RVA = "0x7F8120", Offset = "0x7F7320", VA = "0x1807F8120")]
		private bool CanPlantBomb()
		{
			return default(bool);
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D6")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public BombPlantLocation()
		{
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60038D7")]
		[Address(RVA = "0x7F8420", Offset = "0x7F7620", VA = "0x1807F8420")]
		[CompilerGenerated]
		private IEnumerator <PlantBomb>g__Detonate|15_0()
		{
			return null;
		}

		// Token: 0x040029DD RID: 10717
		[Token(Token = "0x40029DD")]
		public const float COUNTDOWN_TIME = 45f;

		// Token: 0x040029DE RID: 10718
		[Token(Token = "0x40029DE")]
		public const float BEEP_INTERVAL_MAX = 1f;

		// Token: 0x040029DF RID: 10719
		[Token(Token = "0x40029DF")]
		public const float BEEP_INTERVAL_MIN = 0.125f;

		// Token: 0x040029E1 RID: 10721
		[Token(Token = "0x40029E1")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x040029E2 RID: 10722
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BombModel;

		// Token: 0x040029E3 RID: 10723
		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onPlantBomb;

		// Token: 0x040029E4 RID: 10724
		[Token(Token = "0x40029E4")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onBeep;

		// Token: 0x040029E5 RID: 10725
		[Token(Token = "0x40029E5")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onDetonate;
	}
}
