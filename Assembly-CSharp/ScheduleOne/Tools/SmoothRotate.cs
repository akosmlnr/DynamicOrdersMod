using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000894 RID: 2196
	[Token(Token = "0x2000894")]
	public class SmoothRotate : MonoBehaviour
	{
		// Token: 0x060039F8 RID: 14840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F8")]
		[Address(RVA = "0x80E3B0", Offset = "0x80D5B0", VA = "0x18080E3B0")]
		private void Update()
		{
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FA")]
		[Address(RVA = "0x80E500", Offset = "0x80D700", VA = "0x18080E500")]
		public SmoothRotate()
		{
		}

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x20")]
		public bool Active;

		// Token: 0x04002AB3 RID: 10931
		[Token(Token = "0x4002AB3")]
		[FieldOffset(Offset = "0x24")]
		public float Speed;

		// Token: 0x04002AB4 RID: 10932
		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0x28")]
		public float Aceleration;

		// Token: 0x04002AB5 RID: 10933
		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 Axis;

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0x38")]
		private float currentSpeed;
	}
}
