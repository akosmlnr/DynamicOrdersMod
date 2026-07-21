using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020006CB RID: 1739
	[Token(Token = "0x20006CB")]
	public class SupplierStash : MonoBehaviour
	{
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x0000E520 File Offset: 0x0000C720
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B3")]
		public float CashAmount
		{
			[Token(Token = "0x6002DFD")]
			[Address(RVA = "0x4C20F0", Offset = "0x4C12F0", VA = "0x1804C20F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002DFE")]
			[Address(RVA = "0x6B6F20", Offset = "0x6B6120", VA = "0x1806B6F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x74E130", Offset = "0x74D330", VA = "0x18074E130", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E00")]
		[Address(RVA = "0x74EBD0", Offset = "0x74DDD0", VA = "0x18074EBD0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x74ED70", Offset = "0x74DF70", VA = "0x18074ED70")]
		private void SupplierUnlocked()
		{
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E02")]
		[Address(RVA = "0x74E740", Offset = "0x74D940", VA = "0x18074E740")]
		private void RecalculateCash()
		{
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x74E5D0", Offset = "0x74D7D0", VA = "0x18074E5D0")]
		private void Interacted()
		{
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E04")]
		[Address(RVA = "0x74E970", Offset = "0x74DB70", VA = "0x18074E970")]
		public void RemoveCash(float amount)
		{
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x74EDB0", Offset = "0x74DFB0", VA = "0x18074EDB0")]
		private void UpdateDeadDrop()
		{
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E06")]
		[Address(RVA = "0x74EDF0", Offset = "0x74DFF0", VA = "0x18074EDF0")]
		public SupplierStash()
		{
		}

		// Token: 0x04002210 RID: 8720
		[Token(Token = "0x4002210")]
		[FieldOffset(Offset = "0x20")]
		public string locationDescription;

		// Token: 0x04002211 RID: 8721
		[Token(Token = "0x4002211")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Supplier Supplier;

		// Token: 0x04002212 RID: 8722
		[Token(Token = "0x4002212")]
		[FieldOffset(Offset = "0x30")]
		public StorageEntity Storage;

		// Token: 0x04002213 RID: 8723
		[Token(Token = "0x4002213")]
		[FieldOffset(Offset = "0x38")]
		public InteractableObject IntObj;

		// Token: 0x04002214 RID: 8724
		[Token(Token = "0x4002214")]
		[FieldOffset(Offset = "0x40")]
		public OptimizedLight Light;

		// Token: 0x04002215 RID: 8725
		[Token(Token = "0x4002215")]
		[FieldOffset(Offset = "0x48")]
		public POI StashPoI;
	}
}
