using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000967 RID: 2407
	[Token(Token = "0x2000967")]
	public class MushroomSpawnEquipped : Equippable_Viewmodel
	{
		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004072 RID: 16498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0A")]
		[SerializeField]
		private string InteractionLabel
		{
			[Token(Token = "0x6004071")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004072")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004073")]
		[Address(RVA = "0x85E750", Offset = "0x85D950", VA = "0x18085E750", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x6004074")]
		[Address(RVA = "0x85E520", Offset = "0x85D720", VA = "0x18085E520", Slot = "9")]
		protected virtual bool CanApplyToMushroomBed(MushroomBed bed, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004075")]
		[Address(RVA = "0x85E690", Offset = "0x85D890", VA = "0x18085E690")]
		protected void StartTask(MushroomBed growContainer)
		{
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004076")]
		[Address(RVA = "0x85EAF0", Offset = "0x85DCF0", VA = "0x18085EAF0")]
		public MushroomSpawnEquipped()
		{
		}

		// Token: 0x04002F0A RID: 12042
		[Token(Token = "0x4002F0A")]
		private const float InteractionRange = 2.5f;

		// Token: 0x04002F0C RID: 12044
		[Token(Token = "0x4002F0C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _taskPrefab;
	}
}
