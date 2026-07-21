using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x20007C3")]
	public class Surface : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x0000FE88 File Offset: 0x0000E088
		// (set) Token: 0x06003512 RID: 13586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000860")]
		public Guid GUID
		{
			[Token(Token = "0x6003511")]
			[Address(RVA = "0x495C00", Offset = "0x494E00", VA = "0x180495C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6003512")]
			[Address(RVA = "0x495C10", Offset = "0x494E10", VA = "0x180495C10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000861")]
		public Transform Container
		{
			[Token(Token = "0x6003513")]
			[Address(RVA = "0x7D10A0", Offset = "0x7D02A0", VA = "0x1807D10A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000862")]
		public Property ParentProperty
		{
			[Token(Token = "0x6003514")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003515")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003516")]
		[Address(RVA = "0x7D0EE0", Offset = "0x7D00E0", VA = "0x1807D0EE0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003517")]
		[Address(RVA = "0x7D0A20", Offset = "0x7CFC20", VA = "0x1807D0A20")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003518")]
		[Address(RVA = "0x7D0190", Offset = "0x7CF390", VA = "0x1807D0190", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003519")]
		[Address(RVA = "0x7D0F30", Offset = "0x7D0130", VA = "0x1807D0F30", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[Token(Token = "0x600351A")]
		[Address(RVA = "0x7D0350", Offset = "0x7CF550", VA = "0x1807D0350")]
		public Vector3 GetRelativePosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[Token(Token = "0x600351B")]
		[Address(RVA = "0x7D03C0", Offset = "0x7CF5C0", VA = "0x1807D03C0")]
		public Quaternion GetRelativeRotation(Quaternion worldRotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[Token(Token = "0x600351C")]
		[Address(RVA = "0x7D05A0", Offset = "0x7CF7A0", VA = "0x1807D05A0")]
		public bool IsFrontFace(Vector3 point, Collider collider)
		{
			return default(bool);
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x600351D")]
		[Address(RVA = "0x7D0600", Offset = "0x7CF800", VA = "0x1807D0600")]
		public bool IsPointValid(Vector3 point, Collider hitCollider)
		{
			return default(bool);
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600351E")]
		[Address(RVA = "0x7D0F90", Offset = "0x7D0190", VA = "0x1807D0F90")]
		public Surface()
		{
		}

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[FieldOffset(Offset = "0x38")]
		[Header("Settings")]
		public Surface.ESurfaceType SurfaceType;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		[FieldOffset(Offset = "0x40")]
		public List<Surface.EFace> ValidFaces;

		// Token: 0x0400269F RID: 9887
		[Token(Token = "0x400269F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x020007C4 RID: 1988
		[Token(Token = "0x20007C4")]
		public enum ESurfaceType
		{
			// Token: 0x040026A1 RID: 9889
			[Token(Token = "0x40026A1")]
			Wall,
			// Token: 0x040026A2 RID: 9890
			[Token(Token = "0x40026A2")]
			Roof
		}

		// Token: 0x020007C5 RID: 1989
		[Token(Token = "0x20007C5")]
		public enum EFace
		{
			// Token: 0x040026A4 RID: 9892
			[Token(Token = "0x40026A4")]
			Front,
			// Token: 0x040026A5 RID: 9893
			[Token(Token = "0x40026A5")]
			Back,
			// Token: 0x040026A6 RID: 9894
			[Token(Token = "0x40026A6")]
			Top,
			// Token: 0x040026A7 RID: 9895
			[Token(Token = "0x40026A7")]
			Bottom,
			// Token: 0x040026A8 RID: 9896
			[Token(Token = "0x40026A8")]
			Left,
			// Token: 0x040026A9 RID: 9897
			[Token(Token = "0x40026A9")]
			Right
		}
	}
}
