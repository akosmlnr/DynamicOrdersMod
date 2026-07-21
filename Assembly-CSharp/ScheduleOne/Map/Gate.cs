using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200052E RID: 1326
	[Token(Token = "0x200052E")]
	public class Gate : NetworkBehaviour
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000553")]
		public bool IsOpen
		{
			[Token(Token = "0x6001D4B")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D4C")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0x6226B0", Offset = "0x6218B0", VA = "0x1806226B0")]
		private void Update()
		{
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0x6221C0", Offset = "0x6213C0", VA = "0x1806221C0")]
		[ObserversRpc(RunLocally = true)]
		[Button]
		public void Open()
		{
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0x621FD0", Offset = "0x6211D0", VA = "0x180621FD0")]
		[Button]
		[ObserversRpc]
		public void Close()
		{
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D50")]
		[Address(RVA = "0x622B40", Offset = "0x621D40", VA = "0x180622B40")]
		public Gate()
		{
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D51")]
		[Address(RVA = "0x6220F0", Offset = "0x6212F0", VA = "0x1806220F0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D52")]
		[Address(RVA = "0x61EBB0", Offset = "0x61DDB0", VA = "0x18061EBB0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D53")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D54")]
		[Address(RVA = "0x6225A0", Offset = "0x6217A0", VA = "0x1806225A0")]
		private void RpcWriter___Observers_Open_2166136261()
		{
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x6223B0", Offset = "0x6215B0", VA = "0x1806223B0")]
		public void RpcLogic___Open_2166136261()
		{
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x622560", Offset = "0x621760", VA = "0x180622560")]
		private void RpcReader___Observers_Open_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x621FD0", Offset = "0x6211D0", VA = "0x180621FD0")]
		private void RpcWriter___Observers_Close_2166136261()
		{
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x6222E0", Offset = "0x6214E0", VA = "0x1806222E0")]
		public void RpcLogic___Close_2166136261()
		{
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D59")]
		[Address(RVA = "0x622480", Offset = "0x621680", VA = "0x180622480")]
		private void RpcReader___Observers_Close_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x040018B5 RID: 6325
		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x120")]
		public Transform Gate1;

		// Token: 0x040018B6 RID: 6326
		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x128")]
		public Vector3 Gate1Open;

		// Token: 0x040018B7 RID: 6327
		[Token(Token = "0x40018B7")]
		[FieldOffset(Offset = "0x134")]
		public Vector3 Gate1Closed;

		// Token: 0x040018B8 RID: 6328
		[Token(Token = "0x40018B8")]
		[FieldOffset(Offset = "0x140")]
		public Transform Gate2;

		// Token: 0x040018B9 RID: 6329
		[Token(Token = "0x40018B9")]
		[FieldOffset(Offset = "0x148")]
		public Vector3 Gate2Open;

		// Token: 0x040018BA RID: 6330
		[Token(Token = "0x40018BA")]
		[FieldOffset(Offset = "0x154")]
		public Vector3 Gate2Closed;

		// Token: 0x040018BB RID: 6331
		[Token(Token = "0x40018BB")]
		[FieldOffset(Offset = "0x160")]
		public float OpenSpeed;

		// Token: 0x040018BC RID: 6332
		[Token(Token = "0x40018BC")]
		[FieldOffset(Offset = "0x164")]
		public float Acceleration;

		// Token: 0x040018BD RID: 6333
		[Token(Token = "0x40018BD")]
		[FieldOffset(Offset = "0x168")]
		[Header("Sound")]
		public AudioSourceController[] StartSounds;

		// Token: 0x040018BE RID: 6334
		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0x170")]
		public AudioSourceController[] LoopSounds;

		// Token: 0x040018BF RID: 6335
		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x178")]
		public AudioSourceController[] StopSounds;

		// Token: 0x040018C0 RID: 6336
		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x180")]
		private float Momentum;

		// Token: 0x040018C1 RID: 6337
		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0x184")]
		private float openDelta;

		// Token: 0x040018C2 RID: 6338
		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.Map.GateAssembly-CSharp.dll_Excuted;

		// Token: 0x040018C3 RID: 6339
		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.Map.GateAssembly-CSharp.dll_Excuted;
	}
}
