using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020009F0 RID: 2544
	[Token(Token = "0x20009F0")]
	public class CameraOrbit : MonoBehaviour
	{
		// Token: 0x060048D0 RID: 18640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D0")]
		[Address(RVA = "0x8F3920", Offset = "0x8F2B20", VA = "0x1808F3920")]
		private void Start()
		{
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D1")]
		[Address(RVA = "0x8F3A00", Offset = "0x8F2C00", VA = "0x1808F3A00")]
		private void Update()
		{
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D2")]
		[Address(RVA = "0x8F3190", Offset = "0x8F2390", VA = "0x1808F3190")]
		private void LateUpdate()
		{
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00013B00 File Offset: 0x00011D00
		[Token(Token = "0x60048D3")]
		[Address(RVA = "0x55FB70", Offset = "0x55ED70", VA = "0x18055FB70")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D4")]
		[Address(RVA = "0x8F3BB0", Offset = "0x8F2DB0", VA = "0x1808F3BB0")]
		public CameraOrbit()
		{
		}

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[FieldOffset(Offset = "0x20")]
		[Header("Required")]
		public Transform target;

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[FieldOffset(Offset = "0x28")]
		public Transform cam;

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[FieldOffset(Offset = "0x30")]
		public GraphicRaycaster raycaster;

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[FieldOffset(Offset = "0x38")]
		public AvatarLookController LookAt;

		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		[FieldOffset(Offset = "0x40")]
		[Header("Config")]
		public float targetdistance;

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[FieldOffset(Offset = "0x44")]
		public float xSpeed;

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[FieldOffset(Offset = "0x48")]
		public float ySpeed;

		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		[FieldOffset(Offset = "0x4C")]
		public float sideOffset;

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[FieldOffset(Offset = "0x50")]
		public float yMinLimit;

		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		[FieldOffset(Offset = "0x54")]
		public float yMaxLimit;

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[FieldOffset(Offset = "0x58")]
		public float distanceMin;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[FieldOffset(Offset = "0x5C")]
		public float distanceMax;

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[FieldOffset(Offset = "0x60")]
		public float ScrollSensativity;

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody rb;

		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		[FieldOffset(Offset = "0x70")]
		private float x;

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		[FieldOffset(Offset = "0x74")]
		private float y;

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x78")]
		private float targetx;

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x7C")]
		private float targety;

		// Token: 0x04003392 RID: 13202
		[Token(Token = "0x4003392")]
		[FieldOffset(Offset = "0x80")]
		private float distance;

		// Token: 0x04003393 RID: 13203
		[Token(Token = "0x4003393")]
		[FieldOffset(Offset = "0x84")]
		private bool hoveringUI;
	}
}
