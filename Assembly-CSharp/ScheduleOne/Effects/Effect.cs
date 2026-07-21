using System;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B89 RID: 2953
	[Token(Token = "0x2000B89")]
	public abstract class Effect : ScriptableObject
	{
		// Token: 0x060057EE RID: 22510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EE")]
		[Address(RVA = "0x995870", Offset = "0x994A70", VA = "0x180995870", Slot = "4")]
		public virtual void ApplyToNPC(NPC npc)
		{
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057EF")]
		[Address(RVA = "0x995910", Offset = "0x994B10", VA = "0x180995910", Slot = "5")]
		public virtual void ClearFromNPC(NPC npc)
		{
		}

		// Token: 0x060057F0 RID: 22512
		[Token(Token = "0x60057F0")]
		public abstract void ApplyToPlayer(Player player);

		// Token: 0x060057F1 RID: 22513
		[Token(Token = "0x60057F1")]
		public abstract void ClearFromPlayer(Player player);

		// Token: 0x060057F2 RID: 22514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F2")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "8")]
		protected virtual void ApplyToEmployee(Employee employee)
		{
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F3")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "9")]
		protected virtual void ClearFromEmployee(Employee employee)
		{
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F4")]
		[Address(RVA = "0x9959B0", Offset = "0x994BB0", VA = "0x1809959B0")]
		public void OnValidate()
		{
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F5")]
		[Address(RVA = "0x995A70", Offset = "0x994C70", VA = "0x180995A70")]
		protected Effect()
		{
		}

		// Token: 0x04003A52 RID: 14930
		[Token(Token = "0x4003A52")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04003A53 RID: 14931
		[Token(Token = "0x4003A53")]
		[FieldOffset(Offset = "0x20")]
		public string Description;

		// Token: 0x04003A54 RID: 14932
		[Token(Token = "0x4003A54")]
		[FieldOffset(Offset = "0x28")]
		public string ID;

		// Token: 0x04003A55 RID: 14933
		[Token(Token = "0x4003A55")]
		[FieldOffset(Offset = "0x30")]
		[Range(1f, 5f)]
		public int Tier;

		// Token: 0x04003A56 RID: 14934
		[Token(Token = "0x4003A56")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float Addictiveness;

		// Token: 0x04003A57 RID: 14935
		[Token(Token = "0x4003A57")]
		[FieldOffset(Offset = "0x38")]
		public Color ProductColor;

		// Token: 0x04003A58 RID: 14936
		[Token(Token = "0x4003A58")]
		[FieldOffset(Offset = "0x48")]
		public Color LabelColor;

		// Token: 0x04003A59 RID: 14937
		[Token(Token = "0x4003A59")]
		[FieldOffset(Offset = "0x58")]
		public bool ImplementedPriorMixingRework;

		// Token: 0x04003A5A RID: 14938
		[Token(Token = "0x4003A5A")]
		[FieldOffset(Offset = "0x5C")]
		[Range(-100f, 100f)]
		[Header("Value")]
		public int ValueChange;

		// Token: 0x04003A5B RID: 14939
		[Token(Token = "0x4003A5B")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 2f)]
		public float ValueMultiplier;

		// Token: 0x04003A5C RID: 14940
		[Token(Token = "0x4003A5C")]
		[FieldOffset(Offset = "0x64")]
		[Range(-1f, 1f)]
		public float AddBaseValueMultiple;

		// Token: 0x04003A5D RID: 14941
		[Token(Token = "0x4003A5D")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 MixDirection;

		// Token: 0x04003A5E RID: 14942
		[Token(Token = "0x4003A5E")]
		[FieldOffset(Offset = "0x70")]
		public float MixMagnitude;
	}
}
