using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000065 RID: 101
[Token(Token = "0x2000065")]
[ExecuteAlways]
public class MaterialChanger : MonoBehaviour
{
	// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x56ED70", Offset = "0x56DF70", VA = "0x18056ED70")]
	private void OnEnable()
	{
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x56EEF0", Offset = "0x56E0F0", VA = "0x18056EEF0")]
	private void Update()
	{
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x56ED70", Offset = "0x56DF70", VA = "0x18056ED70")]
	private void FindAllMaterialInChild()
	{
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x56EDD0", Offset = "0x56DFD0", VA = "0x18056EDD0")]
	private void SetNewValueForAllMaterial(float value)
	{
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x56F060", Offset = "0x56E260", VA = "0x18056F060")]
	public MaterialChanger()
	{
	}

	// Token: 0x040001F9 RID: 505
	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Range(0f, 5f)]
	private float _value;

	// Token: 0x040001FA RID: 506
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string _changeMaterialSetting;

	// Token: 0x040001FB RID: 507
	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x30")]
	private Renderer[] _renderers;

	// Token: 0x040001FC RID: 508
	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x38")]
	private MaterialPropertyBlock _propBlock;
}
