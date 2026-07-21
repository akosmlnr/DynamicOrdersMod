using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A13 RID: 2579
	[Token(Token = "0x2000A13")]
	public class SetTransform : MonoBehaviour
	{
		// Token: 0x060049A3 RID: 18851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A3")]
		[Address(RVA = "0x90FDC0", Offset = "0x90EFC0", VA = "0x18090FDC0")]
		private void Awake()
		{
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A4")]
		[Address(RVA = "0x90FF60", Offset = "0x90F160", VA = "0x18090FF60")]
		private void Update()
		{
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x90FDD0", Offset = "0x90EFD0", VA = "0x18090FDD0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A6")]
		[Address(RVA = "0x90FDE0", Offset = "0x90EFE0", VA = "0x18090FDE0")]
		private void Set()
		{
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A7")]
		[Address(RVA = "0x90FF70", Offset = "0x90F170", VA = "0x18090FF70")]
		public SetTransform()
		{
		}

		// Token: 0x04003403 RID: 13315
		[Token(Token = "0x4003403")]
		[FieldOffset(Offset = "0x20")]
		[Header("Frequency Settings")]
		public bool SetOnAwake;

		// Token: 0x04003404 RID: 13316
		[Token(Token = "0x4003404")]
		[FieldOffset(Offset = "0x21")]
		public bool SetOnUpdate;

		// Token: 0x04003405 RID: 13317
		[Token(Token = "0x4003405")]
		[FieldOffset(Offset = "0x22")]
		public bool SetOnLateUpdate;

		// Token: 0x04003406 RID: 13318
		[Token(Token = "0x4003406")]
		[FieldOffset(Offset = "0x23")]
		[Header("Transform Settings")]
		public bool SetPosition;

		// Token: 0x04003407 RID: 13319
		[Token(Token = "0x4003407")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 LocalPosition;

		// Token: 0x04003408 RID: 13320
		[Token(Token = "0x4003408")]
		[FieldOffset(Offset = "0x30")]
		public bool SetRotation;

		// Token: 0x04003409 RID: 13321
		[Token(Token = "0x4003409")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 LocalRotation;

		// Token: 0x0400340A RID: 13322
		[Token(Token = "0x400340A")]
		[FieldOffset(Offset = "0x40")]
		public bool SetScale;

		// Token: 0x0400340B RID: 13323
		[Token(Token = "0x400340B")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 LocalScale;
	}
}
