using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x0200096A RID: 2410
	[Token(Token = "0x200096A")]
	[CreateAssetMenu(fileName = "Equippable (Custom Handler)", menuName = "ScheduleOne/Equipping/Equippable (Custom Handler)")]
	public class CustomHandlerEquippableData : EquippableData
	{
		// Token: 0x0600407E RID: 16510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x84FC30", Offset = "0x84EE30", VA = "0x18084FC30")]
		private void OnValidate()
		{
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600407F")]
		[Address(RVA = "0x84FCF0", Offset = "0x84EEF0", VA = "0x18084FCF0")]
		public CustomHandlerEquippableData()
		{
		}

		// Token: 0x04002F13 RID: 12051
		[Token(Token = "0x4002F13")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("If not assigned, the handler will be looked up in the EquippableHandlerService as normal.")]
		[Header("Custom Handler")]
		public EquippedItemHandler Handler;
	}
}
