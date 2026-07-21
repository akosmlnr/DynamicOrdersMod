using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000860 RID: 2144
	[Token(Token = "0x2000860")]
	public class EquipUtility : MonoBehaviour
	{
		// Token: 0x0600391B RID: 14619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391B")]
		[Address(RVA = "0x7FA6D0", Offset = "0x7F98D0", VA = "0x1807FA6D0")]
		public void Update()
		{
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391C")]
		[Address(RVA = "0x7FA5E0", Offset = "0x7F97E0", VA = "0x1807FA5E0")]
		[Button]
		public void Equip()
		{
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391D")]
		[Address(RVA = "0x7FA650", Offset = "0x7F9850", VA = "0x1807FA650")]
		[Button]
		public void Unequip()
		{
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391E")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public EquipUtility()
		{
		}

		// Token: 0x04002A1B RID: 10779
		[Token(Token = "0x4002A1B")]
		[FieldOffset(Offset = "0x20")]
		public AvatarEquippable Equippable;
	}
}
