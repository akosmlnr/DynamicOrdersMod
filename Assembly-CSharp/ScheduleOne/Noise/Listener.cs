using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Noise
{
	// Token: 0x020004F0 RID: 1264
	[Token(Token = "0x20004F0")]
	public class Listener : MonoBehaviour
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0000A350 File Offset: 0x00008550
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050C")]
		public float SquaredHearingRange
		{
			[Token(Token = "0x6001B63")]
			[Address(RVA = "0x495790", Offset = "0x494990", VA = "0x180495790")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001B64")]
			[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x606870", Offset = "0x605A70", VA = "0x180606870")]
		public void Awake()
		{
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x6069A0", Offset = "0x605BA0", VA = "0x1806069A0")]
		public void OnEnable()
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x606920", Offset = "0x605B20", VA = "0x180606920")]
		public void OnDisable()
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x606900", Offset = "0x605B00", VA = "0x180606900")]
		public void Notify(NoiseEvent nEvent)
		{
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x557960", Offset = "0x556B60", VA = "0x180557960")]
		public Listener()
		{
		}

		// Token: 0x04001796 RID: 6038
		[Token(Token = "0x4001796")]
		[FieldOffset(Offset = "0x0")]
		public static List<Listener> listeners;

		// Token: 0x04001797 RID: 6039
		[Token(Token = "0x4001797")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.1f, 5f)]
		[Header("Settings")]
		public float Sensitivity;

		// Token: 0x04001798 RID: 6040
		[Token(Token = "0x4001798")]
		[FieldOffset(Offset = "0x28")]
		public Transform HearingOrigin;

		// Token: 0x0400179A RID: 6042
		[Token(Token = "0x400179A")]
		[FieldOffset(Offset = "0x38")]
		public Listener.HearingEvent onNoiseHeard;

		// Token: 0x020004F1 RID: 1265
		// (Invoke) Token: 0x06001B6C RID: 7020
		[Token(Token = "0x20004F1")]
		public delegate void HearingEvent(NoiseEvent nEvent);
	}
}
