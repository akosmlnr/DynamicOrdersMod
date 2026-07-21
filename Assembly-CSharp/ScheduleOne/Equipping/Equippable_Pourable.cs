using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Growing;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000958 RID: 2392
	[Token(Token = "0x2000958")]
	public class Equippable_Pourable : Equippable_Viewmodel
	{
		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06003FFE RID: 16382 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003FFF RID: 16383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F7")]
		public string InteractionLabel
		{
			[Token(Token = "0x6003FFE")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FFF")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004000")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "9")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004001")]
		[Address(RVA = "0x853C50", Offset = "0x852E50", VA = "0x180853C50", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004002")]
		[Address(RVA = "0x853BE0", Offset = "0x852DE0", VA = "0x180853BE0", Slot = "10")]
		protected virtual void StartPourTask(GrowContainer growContainer)
		{
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x6004003")]
		[Address(RVA = "0x853B90", Offset = "0x852D90", VA = "0x180853B90", Slot = "11")]
		protected virtual bool CanPour(GrowContainer growContainer, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004004")]
		[Address(RVA = "0x854000", Offset = "0x853200", VA = "0x180854000")]
		public Equippable_Pourable()
		{
		}

		// Token: 0x04002EAD RID: 11949
		[Token(Token = "0x4002EAD")]
		private const float InteractionRange = 2.5f;

		// Token: 0x04002EAF RID: 11951
		[Token(Token = "0x4002EAF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public Pourable PourablePrefab;
	}
}
