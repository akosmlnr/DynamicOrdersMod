using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000886 RID: 2182
	[Token(Token = "0x2000886")]
	[RequireComponent(typeof(Rigidbody))]
	public class PlayerDetector : MonoBehaviour
	{
		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000910")]
		public bool IgnoreNewDetections
		{
			[Token(Token = "0x60039C2")]
			[Address(RVA = "0x49B030", Offset = "0x49A230", VA = "0x18049B030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039C3")]
			[Address(RVA = "0x49B240", Offset = "0x49A440", VA = "0x18049B240")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C4")]
		[Address(RVA = "0x80BF30", Offset = "0x80B130", VA = "0x18080BF30")]
		private void Awake()
		{
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C5")]
		[Address(RVA = "0x80CC40", Offset = "0x80BE40", VA = "0x18080CC40")]
		private void Start()
		{
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x80C130", Offset = "0x80B330", VA = "0x18080C130")]
		private void OnDestroy()
		{
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x80C250", Offset = "0x80B450", VA = "0x18080C250")]
		private void OnTick()
		{
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x80C460", Offset = "0x80B660", VA = "0x18080C460")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x80C020", Offset = "0x80B220", VA = "0x18080C020")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039CA")]
		[Address(RVA = "0x80C7E0", Offset = "0x80B9E0", VA = "0x18080C7E0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x80CB60", Offset = "0x80BD60", VA = "0x18080CB60")]
		public void SetIgnoreNewCollisions(bool ignore)
		{
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039CC")]
		[Address(RVA = "0x80CDE0", Offset = "0x80BFE0", VA = "0x18080CDE0")]
		public PlayerDetector()
		{
		}

		// Token: 0x04002A80 RID: 10880
		[Token(Token = "0x4002A80")]
		public const float ACTIVATION_DISTANCE_SQ = 400f;

		// Token: 0x04002A81 RID: 10881
		[Token(Token = "0x4002A81")]
		[FieldOffset(Offset = "0x20")]
		public bool DetectPlayerInVehicle;

		// Token: 0x04002A82 RID: 10882
		[Token(Token = "0x4002A82")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<Player> onPlayerEnter;

		// Token: 0x04002A83 RID: 10883
		[Token(Token = "0x4002A83")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<Player> onPlayerExit;

		// Token: 0x04002A84 RID: 10884
		[Token(Token = "0x4002A84")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onLocalPlayerEnter;

		// Token: 0x04002A85 RID: 10885
		[Token(Token = "0x4002A85")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onLocalPlayerExit;

		// Token: 0x04002A86 RID: 10886
		[Token(Token = "0x4002A86")]
		[FieldOffset(Offset = "0x48")]
		public List<Player> DetectedPlayers;

		// Token: 0x04002A88 RID: 10888
		[Token(Token = "0x4002A88")]
		[FieldOffset(Offset = "0x51")]
		private bool ignoreExit;

		// Token: 0x04002A89 RID: 10889
		[Token(Token = "0x4002A89")]
		[FieldOffset(Offset = "0x52")]
		private bool collidersEnabled;

		// Token: 0x04002A8A RID: 10890
		[Token(Token = "0x4002A8A")]
		[FieldOffset(Offset = "0x58")]
		private Collider[] detectionColliders;
	}
}
