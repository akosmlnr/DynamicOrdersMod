using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000063 RID: 99
[Token(Token = "0x2000063")]
public class MeleeWeaponTrail : MonoBehaviour
{
	// Token: 0x17000025 RID: 37
	// (set) Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000025")]
	public bool Emit
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
		set
		{
		}
	}

	// Token: 0x17000026 RID: 38
	// (set) Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000026")]
	public bool Use
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x570D90", Offset = "0x56FF90", VA = "0x180570D90")]
		set
		{
		}
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x56F390", Offset = "0x56E590", VA = "0x18056F390")]
	private void Start()
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x56F0C0", Offset = "0x56E2C0", VA = "0x18056F0C0")]
	private void OnDisable()
	{
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x56F770", Offset = "0x56E970", VA = "0x18056F770")]
	private void Update()
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x56F110", Offset = "0x56E310", VA = "0x18056F110")]
	private void RemoveOldPoints(List<MeleeWeaponTrail.Point> pointList)
	{
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x570CB0", Offset = "0x56FEB0", VA = "0x180570CB0")]
	public MeleeWeaponTrail()
	{
	}

	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _emit;

	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x21")]
	private bool _use;

	// Token: 0x040001E3 RID: 483
	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _emitTime;

	// Token: 0x040001E4 RID: 484
	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material _material;

	// Token: 0x040001E5 RID: 485
	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _lifeTime;

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color[] _colors;

	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float[] _sizes;

	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _minVertexDistance;

	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _maxVertexDistance;

	// Token: 0x040001EA RID: 490
	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x50")]
	private float _minVertexDistanceSqr;

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x54")]
	private float _maxVertexDistanceSqr;

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _maxAngle;

	// Token: 0x040001ED RID: 493
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private bool _autoDestruct;

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private int subdivisions;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform _base;

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform _tip;

	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x78")]
	private List<MeleeWeaponTrail.Point> _points;

	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x80")]
	private List<MeleeWeaponTrail.Point> _smoothedPoints;

	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x88")]
	private GameObject _trailObject;

	// Token: 0x040001F4 RID: 500
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x90")]
	private Mesh _trailMesh;

	// Token: 0x040001F5 RID: 501
	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 _lastPosition;

	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[Serializable]
	public class Point
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
		public Point()
		{
		}

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x10")]
		public float timeCreated;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 basePosition;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 tipPosition;
	}
}
