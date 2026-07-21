using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Decoration
{
	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	public class RockerSwitch : MonoBehaviour
	{
		// Token: 0x060011B3 RID: 4531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0xB1FAB0", Offset = "0xB1ECB0", VA = "0x180B1FAB0")]
		private void Awake()
		{
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B4")]
		[Address(RVA = "0xB1FB30", Offset = "0xB1ED30", VA = "0x180B1FB30")]
		public void SetIsOn(bool on)
		{
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public RockerSwitch()
		{
		}

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer ButtonMesh;

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0x28")]
		public Transform ButtonTransform;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x30")]
		public Light Light;

		// Token: 0x04001066 RID: 4198
		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x38")]
		public bool isOn;
	}
}
