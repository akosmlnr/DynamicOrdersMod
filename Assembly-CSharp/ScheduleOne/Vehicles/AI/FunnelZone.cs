using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	[RequireComponent(typeof(BoxCollider))]
	public class FunnelZone : MonoBehaviour
	{
		// Token: 0x06001064 RID: 4196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001064")]
		[Address(RVA = "0xB00640", Offset = "0xAFF840", VA = "0x180B00640", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001065")]
		[Address(RVA = "0xB00710", Offset = "0xAFF910", VA = "0x180B00710")]
		public static FunnelZone GetFunnelZone(Vector3 point)
		{
			return null;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001066")]
		[Address(RVA = "0xB008B0", Offset = "0xAFFAB0", VA = "0x180B008B0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public FunnelZone()
		{
		}

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x0")]
		public static List<FunnelZone> funnelZones;

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider col;

		// Token: 0x04000EC8 RID: 3784
		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x28")]
		public Transform entryPoint;
	}
}
