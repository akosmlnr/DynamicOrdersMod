using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004E RID: 78
[Token(Token = "0x200004E")]
public class FlockController : MonoBehaviour
{
	// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x556A70", Offset = "0x555C70", VA = "0x180556A70")]
	public void Start()
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x555F30", Offset = "0x555130", VA = "0x180555F30")]
	public void AddChild(int amount)
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000143")]
	[Address(RVA = "0x555EC0", Offset = "0x5550C0", VA = "0x180555EC0")]
	public void AddChildToParent(Transform obj)
	{
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x5566E0", Offset = "0x5558E0", VA = "0x1805566E0")]
	public void RemoveChild(int amount)
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000145")]
	[Address(RVA = "0x556D20", Offset = "0x555F20", VA = "0x180556D20")]
	public void Update()
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000146")]
	[Address(RVA = "0x556220", Offset = "0x555420", VA = "0x180556220")]
	public void InstantiateGroup()
	{
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000147")]
	[Address(RVA = "0x556BA0", Offset = "0x555DA0", VA = "0x180556BA0")]
	public void UpdateChildAmount()
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x5563B0", Offset = "0x5555B0", VA = "0x1805563B0")]
	public void OnDrawGizmos()
	{
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x556800", Offset = "0x555A00", VA = "0x180556800")]
	public void SetFlockRandomPosition()
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x5570B0", Offset = "0x5562B0", VA = "0x1805570B0")]
	public void destroyBirds()
	{
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x556F00", Offset = "0x556100", VA = "0x180556F00")]
	public FlockController()
	{
	}

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x20")]
	public FlockChild _childPrefab;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x28")]
	public int _childAmount;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x2C")]
	public bool _slowSpawn;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x30")]
	public float _spawnSphere;

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x34")]
	public float _spawnSphereHeight;

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x38")]
	public float _spawnSphereDepth;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x3C")]
	public float _minSpeed;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x40")]
	public float _maxSpeed;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x44")]
	public float _minScale;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x48")]
	public float _maxScale;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x4C")]
	public float _soarFrequency;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x50")]
	public string _soarAnimation;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x58")]
	public string _flapAnimation;

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x60")]
	public string _idleAnimation;

	// Token: 0x04000127 RID: 295
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x68")]
	public float _diveValue;

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x6C")]
	public float _diveFrequency;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x70")]
	public float _minDamping;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x74")]
	public float _maxDamping;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x78")]
	public float _waypointDistance;

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x7C")]
	public float _minAnimationSpeed;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x80")]
	public float _maxAnimationSpeed;

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x84")]
	public float _randomPositionTimer;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x88")]
	public float _positionSphere;

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x8C")]
	public float _positionSphereHeight;

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x90")]
	public float _positionSphereDepth;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x94")]
	public bool _childTriggerPos;

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x95")]
	public bool _forceChildWaypoints;

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x98")]
	public float _forcedRandomDelay;

	// Token: 0x04000135 RID: 309
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x9C")]
	public bool _flatFly;

	// Token: 0x04000136 RID: 310
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x9D")]
	public bool _flatSoar;

	// Token: 0x04000137 RID: 311
	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x9E")]
	public bool _birdAvoid;

	// Token: 0x04000138 RID: 312
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0xA0")]
	public int _birdAvoidHorizontalForce;

	// Token: 0x04000139 RID: 313
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0xA4")]
	public bool _birdAvoidDown;

	// Token: 0x0400013A RID: 314
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0xA5")]
	public bool _birdAvoidUp;

	// Token: 0x0400013B RID: 315
	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0xA8")]
	public int _birdAvoidVerticalForce;

	// Token: 0x0400013C RID: 316
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0xAC")]
	public float _birdAvoidDistanceMax;

	// Token: 0x0400013D RID: 317
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0xB0")]
	public float _birdAvoidDistanceMin;

	// Token: 0x0400013E RID: 318
	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0xB4")]
	public float _soarMaxTime;

	// Token: 0x0400013F RID: 319
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0xB8")]
	public LayerMask _avoidanceMask;

	// Token: 0x04000140 RID: 320
	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0xC0")]
	public List<FlockChild> _roamers;

	// Token: 0x04000141 RID: 321
	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0xC8")]
	public Vector3 _posBuffer;

	// Token: 0x04000142 RID: 322
	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0xD4")]
	public int _updateDivisor;

	// Token: 0x04000143 RID: 323
	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0xD8")]
	public float _newDelta;

	// Token: 0x04000144 RID: 324
	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0xDC")]
	public int _updateCounter;

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0xE0")]
	public float _activeChildren;

	// Token: 0x04000146 RID: 326
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0xE4")]
	public bool _groupChildToNewTransform;

	// Token: 0x04000147 RID: 327
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0xE8")]
	public Transform _groupTransform;

	// Token: 0x04000148 RID: 328
	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0xF0")]
	public string _groupName;

	// Token: 0x04000149 RID: 329
	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0xF8")]
	public bool _groupChildToFlock;

	// Token: 0x0400014A RID: 330
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0xFC")]
	public Vector3 _startPosOffset;

	// Token: 0x0400014B RID: 331
	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x108")]
	public Transform _thisT;
}
