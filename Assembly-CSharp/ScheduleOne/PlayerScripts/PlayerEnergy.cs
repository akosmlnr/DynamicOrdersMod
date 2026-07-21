using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x20005F2")]
	public class PlayerEnergy : MonoBehaviour
	{
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x0000C228 File Offset: 0x0000A428
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067A")]
		public float CurrentEnergy
		{
			[Token(Token = "0x6002519")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600251A")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x0000C240 File Offset: 0x0000A440
		// (set) Token: 0x0600251C RID: 9500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067B")]
		public int EnergyDrinksConsumed
		{
			[Token(Token = "0x600251B")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600251C")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x6AB350", Offset = "0x6AA550", VA = "0x1806AB350", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x6AB230", Offset = "0x6AA430", VA = "0x1806AB230")]
		private void MinPass()
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void ChangeEnergy(float change)
		{
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void SetEnergy(float newEnergy)
		{
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002521")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void RestoreEnergy()
		{
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002522")]
		[Address(RVA = "0x6AB340", Offset = "0x6AA540", VA = "0x1806AB340")]
		private void SleepEnd()
		{
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002523")]
		[Address(RVA = "0x6AB220", Offset = "0x6AA420", VA = "0x1806AB220")]
		public void IncrementEnergyDrinks()
		{
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002524")]
		[Address(RVA = "0x6AB340", Offset = "0x6AA540", VA = "0x1806AB340")]
		private void ResetEnergyDrinks()
		{
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002525")]
		[Address(RVA = "0x6AB570", Offset = "0x6AA770", VA = "0x1806AB570")]
		public PlayerEnergy()
		{
		}

		// Token: 0x04001CE3 RID: 7395
		[Token(Token = "0x4001CE3")]
		public const float CRITICAL_THRESHOLD = 20f;

		// Token: 0x04001CE4 RID: 7396
		[Token(Token = "0x4001CE4")]
		public const float MAX_ENERGY = 100f;

		// Token: 0x04001CE5 RID: 7397
		[Token(Token = "0x4001CE5")]
		public const float SPRINT_DRAIN_MULTIPLIER = 1.3f;

		// Token: 0x04001CE8 RID: 7400
		[Token(Token = "0x4001CE8")]
		[FieldOffset(Offset = "0x28")]
		public bool DEBUG_DISABLE_ENERGY;

		// Token: 0x04001CE9 RID: 7401
		[Token(Token = "0x4001CE9")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public float EnergyDuration_Hours;

		// Token: 0x04001CEA RID: 7402
		[Token(Token = "0x4001CEA")]
		[FieldOffset(Offset = "0x30")]
		public float EnergyRechargeTime_Hours;

		// Token: 0x04001CEB RID: 7403
		[Token(Token = "0x4001CEB")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onEnergyChanged;

		// Token: 0x04001CEC RID: 7404
		[Token(Token = "0x4001CEC")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onEnergyDepleted;
	}
}
