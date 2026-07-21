using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200089A RID: 2202
	[Token(Token = "0x200089A")]
	[ExecuteInEditMode]
	public class WheelRotator : MonoBehaviour
	{
		// Token: 0x06003A09 RID: 14857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A09")]
		[Address(RVA = "0x812FB0", Offset = "0x8121B0", VA = "0x180812FB0")]
		private void Start()
		{
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A0A")]
		[Address(RVA = "0x812D80", Offset = "0x811F80", VA = "0x180812D80")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A0B")]
		[Address(RVA = "0x813060", Offset = "0x812260", VA = "0x180813060")]
		public WheelRotator()
		{
		}

		// Token: 0x04002ACB RID: 10955
		[Token(Token = "0x4002ACB")]
		[FieldOffset(Offset = "0x20")]
		public float Radius;

		// Token: 0x04002ACC RID: 10956
		[Token(Token = "0x4002ACC")]
		[FieldOffset(Offset = "0x28")]
		public Transform Wheel;

		// Token: 0x04002ACD RID: 10957
		[Token(Token = "0x4002ACD")]
		[FieldOffset(Offset = "0x30")]
		public bool Flip;

		// Token: 0x04002ACE RID: 10958
		[Token(Token = "0x4002ACE")]
		[FieldOffset(Offset = "0x38")]
		public AudioSourceController Controller;

		// Token: 0x04002ACF RID: 10959
		[Token(Token = "0x4002ACF")]
		[FieldOffset(Offset = "0x40")]
		public float AudioVolumeDivisor;

		// Token: 0x04002AD0 RID: 10960
		[Token(Token = "0x4002AD0")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 RotationAxis;

		// Token: 0x04002AD1 RID: 10961
		[Token(Token = "0x4002AD1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 lastFramePosition;
	}
}
