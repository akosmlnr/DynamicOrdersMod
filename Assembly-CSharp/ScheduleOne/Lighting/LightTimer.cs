using System;
using Il2CppDummyDll;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A2 RID: 1442
	[Token(Token = "0x20005A2")]
	[RequireComponent(typeof(ToggleableLight))]
	public class LightTimer : MonoBehaviour
	{
		// Token: 0x060020F6 RID: 8438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x678880", Offset = "0x677A80", VA = "0x180678880", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x6789E0", Offset = "0x677BE0", VA = "0x1806789E0")]
		private void Start()
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x678A00", Offset = "0x677C00", VA = "0x180678A00", Slot = "5")]
		protected virtual void UpdateState()
		{
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x6789B0", Offset = "0x677BB0", VA = "0x1806789B0")]
		private void SetState(bool on)
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x678AB0", Offset = "0x677CB0", VA = "0x180678AB0")]
		public LightTimer()
		{
		}

		// Token: 0x04001ACD RID: 6861
		[Token(Token = "0x4001ACD")]
		[FieldOffset(Offset = "0x20")]
		[Header("Timing")]
		public int StartTime;

		// Token: 0x04001ACE RID: 6862
		[Token(Token = "0x4001ACE")]
		[FieldOffset(Offset = "0x24")]
		public int EndTime;

		// Token: 0x04001ACF RID: 6863
		[Token(Token = "0x4001ACF")]
		[FieldOffset(Offset = "0x28")]
		public int StartTimeOffset;

		// Token: 0x04001AD0 RID: 6864
		[Token(Token = "0x4001AD0")]
		[FieldOffset(Offset = "0x30")]
		private ToggleableLight toggleableLight;
	}
}
