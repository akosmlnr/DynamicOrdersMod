using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000961 RID: 2401
	[Token(Token = "0x2000961")]
	public class Equippable_SprayBottle : Equippable_Viewmodel
	{
		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004042 RID: 16450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A04")]
		[SerializeField]
		private string InteractionLabel
		{
			[Token(Token = "0x6004041")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004042")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004043")]
		[Address(RVA = "0x858340", Offset = "0x857540", VA = "0x180858340", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x6004044")]
		[Address(RVA = "0x858160", Offset = "0x857360", VA = "0x180858160", Slot = "9")]
		protected virtual bool CanSpray(GrowContainer growContainer, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004045")]
		[Address(RVA = "0x8582D0", Offset = "0x8574D0", VA = "0x1808582D0")]
		protected void StartSprayTask(MushroomBed growContainer)
		{
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004046")]
		[Address(RVA = "0x858710", Offset = "0x857910", VA = "0x180858710")]
		public Equippable_SprayBottle()
		{
		}

		// Token: 0x04002EF6 RID: 12022
		[Token(Token = "0x4002EF6")]
		private const float InteractionRange = 2.5f;

		// Token: 0x04002EF8 RID: 12024
		[Token(Token = "0x4002EF8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _sprayablePrefab;

		// Token: 0x04002EF9 RID: 12025
		[Token(Token = "0x4002EF9")]
		[FieldOffset(Offset = "0x70")]
		private WaterContainerInstance _waterContainerInstance;
	}
}
