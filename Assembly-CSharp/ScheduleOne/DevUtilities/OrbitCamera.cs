using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A08 RID: 2568
	[Token(Token = "0x2000A08")]
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06004966 RID: 18790 RVA: 0x00013F38 File Offset: 0x00012138
		// (set) Token: 0x06004967 RID: 18791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7B")]
		public bool isEnabled
		{
			[Token(Token = "0x6004966")]
			[Address(RVA = "0x4943C0", Offset = "0x4935C0", VA = "0x1804943C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004967")]
			[Address(RVA = "0x90A350", Offset = "0x909550", VA = "0x18090A350")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06004968 RID: 18792 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B7C")]
		protected Transform cam
		{
			[Token(Token = "0x6004968")]
			[Address(RVA = "0x90A2D0", Offset = "0x9094D0", VA = "0x18090A2D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004969")]
		[Address(RVA = "0x909760", Offset = "0x908960", VA = "0x180909760", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496A")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496B")]
		[Address(RVA = "0x90A200", Offset = "0x909400", VA = "0x18090A200", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496C")]
		[Address(RVA = "0x909DC0", Offset = "0x908FC0", VA = "0x180909DC0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496D")]
		[Address(RVA = "0x909920", Offset = "0x908B20", VA = "0x180909920")]
		[Button]
		public void Enable()
		{
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496E")]
		[Address(RVA = "0x909830", Offset = "0x908A30", VA = "0x180909830")]
		public void Disable()
		{
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496F")]
		[Address(RVA = "0x909DD0", Offset = "0x908FD0", VA = "0x180909DD0")]
		protected void UpdateRotation()
		{
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00013F50 File Offset: 0x00012150
		[Token(Token = "0x6004970")]
		[Address(RVA = "0x55FB70", Offset = "0x55ED70", VA = "0x18055FB70")]
		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004971")]
		[Address(RVA = "0x909BD0", Offset = "0x908DD0", VA = "0x180909BD0")]
		private void FinalizeCameraMovement()
		{
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004972")]
		[Address(RVA = "0x90A260", Offset = "0x909460", VA = "0x18090A260")]
		public OrbitCamera()
		{
		}

		// Token: 0x040033DC RID: 13276
		[Token(Token = "0x40033DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		protected Transform cameraStartPoint;

		// Token: 0x040033DD RID: 13277
		[Token(Token = "0x40033DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Transform centrePoint;

		// Token: 0x040033DE RID: 13278
		[Token(Token = "0x40033DE")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public float targetFollowSpeed;

		// Token: 0x040033DF RID: 13279
		[Token(Token = "0x40033DF")]
		[FieldOffset(Offset = "0x34")]
		public float yMinLimit;

		// Token: 0x040033E0 RID: 13280
		[Token(Token = "0x40033E0")]
		[FieldOffset(Offset = "0x38")]
		public float yMaxLimit;

		// Token: 0x040033E1 RID: 13281
		[Token(Token = "0x40033E1")]
		[FieldOffset(Offset = "0x0")]
		public static float xSpeed;

		// Token: 0x040033E2 RID: 13282
		[Token(Token = "0x40033E2")]
		[FieldOffset(Offset = "0x4")]
		public static float ySpeed;

		// Token: 0x040033E4 RID: 13284
		[Token(Token = "0x40033E4")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 rotationOriginPoint;

		// Token: 0x040033E5 RID: 13285
		[Token(Token = "0x40033E5")]
		[FieldOffset(Offset = "0x4C")]
		private float distance;

		// Token: 0x040033E6 RID: 13286
		[Token(Token = "0x40033E6")]
		[FieldOffset(Offset = "0x50")]
		private float prevDistance;

		// Token: 0x040033E7 RID: 13287
		[Token(Token = "0x40033E7")]
		[FieldOffset(Offset = "0x54")]
		private float x;

		// Token: 0x040033E8 RID: 13288
		[Token(Token = "0x40033E8")]
		[FieldOffset(Offset = "0x58")]
		private float y;

		// Token: 0x040033E9 RID: 13289
		[Token(Token = "0x40033E9")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;
	}
}
