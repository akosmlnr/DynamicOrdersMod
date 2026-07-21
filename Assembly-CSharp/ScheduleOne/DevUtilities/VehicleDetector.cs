using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A1D RID: 2589
	[Token(Token = "0x2000A1D")]
	[RequireComponent(typeof(Rigidbody))]
	public class VehicleDetector : MonoBehaviour
	{
		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060049C9 RID: 18889 RVA: 0x000140D0 File Offset: 0x000122D0
		// (set) Token: 0x060049CA RID: 18890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B84")]
		public bool IgnoreNewDetections
		{
			[Token(Token = "0x60049C9")]
			[Address(RVA = "0x496D60", Offset = "0x495F60", VA = "0x180496D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60049CA")]
			[Address(RVA = "0x4CD110", Offset = "0x4CC310", VA = "0x1804CD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CB")]
		[Address(RVA = "0x9178F0", Offset = "0x916AF0", VA = "0x1809178F0")]
		private void Awake()
		{
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CC")]
		[Address(RVA = "0x9182A0", Offset = "0x9174A0", VA = "0x1809182A0")]
		private void Start()
		{
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CD")]
		[Address(RVA = "0x917A50", Offset = "0x916C50", VA = "0x180917A50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CE")]
		[Address(RVA = "0x917DE0", Offset = "0x916FE0", VA = "0x180917DE0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x917B70", Offset = "0x916D70", VA = "0x180917B70")]
		private void OnTick()
		{
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D0")]
		[Address(RVA = "0x917F70", Offset = "0x917170", VA = "0x180917F70")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D1")]
		[Address(RVA = "0x918190", Offset = "0x917390", VA = "0x180918190")]
		private void SortVehicles()
		{
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D2")]
		[Address(RVA = "0x9180B0", Offset = "0x9172B0", VA = "0x1809180B0")]
		public void SetIgnoreNewCollisions(bool ignore)
		{
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x000140E8 File Offset: 0x000122E8
		[Token(Token = "0x60049D3")]
		[Address(RVA = "0x917850", Offset = "0x916A50", VA = "0x180917850")]
		public bool AreAnyVehiclesOccupied()
		{
			return default(bool);
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D4")]
		[Address(RVA = "0x9179E0", Offset = "0x916BE0", VA = "0x1809179E0")]
		public void Clear()
		{
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D5")]
		[Address(RVA = "0x9184E0", Offset = "0x9176E0", VA = "0x1809184E0")]
		public VehicleDetector()
		{
		}

		// Token: 0x04003420 RID: 13344
		[Token(Token = "0x4003420")]
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		// Token: 0x04003421 RID: 13345
		[Token(Token = "0x4003421")]
		[FieldOffset(Offset = "0x20")]
		public List<LandVehicle> vehicles;

		// Token: 0x04003422 RID: 13346
		[Token(Token = "0x4003422")]
		[FieldOffset(Offset = "0x28")]
		public LandVehicle closestVehicle;

		// Token: 0x04003424 RID: 13348
		[Token(Token = "0x4003424")]
		[FieldOffset(Offset = "0x31")]
		private bool ignoreExit;

		// Token: 0x04003425 RID: 13349
		[Token(Token = "0x4003425")]
		[FieldOffset(Offset = "0x38")]
		private Collider[] detectionColliders;

		// Token: 0x04003426 RID: 13350
		[Token(Token = "0x4003426")]
		[FieldOffset(Offset = "0x40")]
		private bool collidersEnabled;
	}
}
