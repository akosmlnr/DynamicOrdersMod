using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Employees
{
	// Token: 0x0200067A RID: 1658
	[Token(Token = "0x200067A")]
	public class EmployeeHome : MonoBehaviour
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000762")]
		public Employee AssignedEmployee
		{
			[Token(Token = "0x6002ACF")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AD0")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x6F87D0", Offset = "0x6F79D0", VA = "0x1806F87D0")]
		private void Awake()
		{
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x6F9050", Offset = "0x6F8250", VA = "0x1806F9050")]
		private void Start()
		{
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0x6F8DD0", Offset = "0x6F7FD0", VA = "0x1806F8DD0")]
		public void SetAssignedEmployee(Employee employee)
		{
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x6F9190", Offset = "0x6F8390", VA = "0x1806F9190")]
		private void UpdateStorageText()
		{
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x6F9060", Offset = "0x6F8260", VA = "0x1806F9060")]
		private void UpdateMaterial()
		{
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x6F8860", Offset = "0x6F7A60", VA = "0x1806F8860")]
		public float GetCashSum()
		{
			return 0f;
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x6F8BA0", Offset = "0x6F7DA0", VA = "0x1806F8BA0")]
		public void RemoveCash(float amount)
		{
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x6F8A40", Offset = "0x6F7C40", VA = "0x1806F8A40")]
		public static bool IsBuildableEntityAValidEmployeeHome(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD9")]
		[Address(RVA = "0x6F94B0", Offset = "0x6F86B0", VA = "0x1806F94B0")]
		public EmployeeHome()
		{
		}

		// Token: 0x0400201C RID: 8220
		[Token(Token = "0x400201C")]
		[FieldOffset(Offset = "0x28")]
		public string HomeType;

		// Token: 0x0400201D RID: 8221
		[Token(Token = "0x400201D")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public GameObject Clipboard;

		// Token: 0x0400201E RID: 8222
		[Token(Token = "0x400201E")]
		[FieldOffset(Offset = "0x38")]
		public SpriteRenderer MugshotSprite;

		// Token: 0x0400201F RID: 8223
		[Token(Token = "0x400201F")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshPro NameLabel;

		// Token: 0x04002020 RID: 8224
		[Token(Token = "0x4002020")]
		[FieldOffset(Offset = "0x48")]
		public StorageEntity Storage;

		// Token: 0x04002021 RID: 8225
		[Token(Token = "0x4002021")]
		[FieldOffset(Offset = "0x50")]
		public MeshRenderer[] EmployeeSpecificMeshes;

		// Token: 0x04002022 RID: 8226
		[Token(Token = "0x4002022")]
		[FieldOffset(Offset = "0x58")]
		public Material SpecificMat_Default;

		// Token: 0x04002023 RID: 8227
		[Token(Token = "0x4002023")]
		[FieldOffset(Offset = "0x60")]
		public Material SpecificMat_Botanist;

		// Token: 0x04002024 RID: 8228
		[Token(Token = "0x4002024")]
		[FieldOffset(Offset = "0x68")]
		public Material SpecificMat_Chemist;

		// Token: 0x04002025 RID: 8229
		[Token(Token = "0x4002025")]
		[FieldOffset(Offset = "0x70")]
		public Material SpecificMat_Packager;

		// Token: 0x04002026 RID: 8230
		[Token(Token = "0x4002026")]
		[FieldOffset(Offset = "0x78")]
		public Material SpecificMat_Cleaner;

		// Token: 0x04002027 RID: 8231
		[Token(Token = "0x4002027")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onAssignedEmployeeChanged;
	}
}
