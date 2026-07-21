using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200097E RID: 2430
	[Token(Token = "0x200097E")]
	public class Toilet : GridItem
	{
		// Token: 0x06004116 RID: 16662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004116")]
		[Address(RVA = "0x882470", Offset = "0x881670", VA = "0x180882470")]
		public void Hovered()
		{
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x8824F0", Offset = "0x8816F0", VA = "0x1808824F0")]
		public void Interacted()
		{
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004118")]
		[Address(RVA = "0x882970", Offset = "0x881B70", VA = "0x180882970")]
		[ServerRpc(RequireOwnership = false)]
		private void SendFlush()
		{
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004119")]
		[Address(RVA = "0x882350", Offset = "0x881550", VA = "0x180882350")]
		[ObserversRpc]
		private void Flush()
		{
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x882AF0", Offset = "0x881CF0", VA = "0x180882AF0")]
		public Toilet()
		{
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x882A80", Offset = "0x881C80", VA = "0x180882A80")]
		[CompilerGenerated]
		private IEnumerator <Flush>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x882620", Offset = "0x881820", VA = "0x180882620", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x882600", Offset = "0x881800", VA = "0x180882600", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411E")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411F")]
		[Address(RVA = "0x882970", Offset = "0x881B70", VA = "0x180882970")]
		private void RpcWriter___Server_SendFlush_2166136261()
		{
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004120")]
		[Address(RVA = "0x882350", Offset = "0x881550", VA = "0x180882350")]
		private void RpcLogic___SendFlush_2166136261()
		{
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004121")]
		[Address(RVA = "0x882840", Offset = "0x881A40", VA = "0x180882840")]
		private void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004122")]
		[Address(RVA = "0x882350", Offset = "0x881550", VA = "0x180882350")]
		private void RpcWriter___Observers_Flush_2166136261()
		{
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004123")]
		[Address(RVA = "0x882710", Offset = "0x881910", VA = "0x180882710")]
		private void RpcLogic___Flush_2166136261()
		{
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004124")]
		[Address(RVA = "0x8827A0", Offset = "0x8819A0", VA = "0x1808827A0")]
		private void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004125")]
		[Address(RVA = "0x82F570", Offset = "0x82E770", VA = "0x18082F570", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04002F5A RID: 12122
		[Token(Token = "0x4002F5A")]
		[FieldOffset(Offset = "0x210")]
		public float InitialDelay;

		// Token: 0x04002F5B RID: 12123
		[Token(Token = "0x4002F5B")]
		[FieldOffset(Offset = "0x214")]
		public float FlushTime;

		// Token: 0x04002F5C RID: 12124
		[Token(Token = "0x4002F5C")]
		[FieldOffset(Offset = "0x218")]
		public InteractableObject IntObj;

		// Token: 0x04002F5D RID: 12125
		[Token(Token = "0x4002F5D")]
		[FieldOffset(Offset = "0x220")]
		public LayerMask ItemLayerMask;

		// Token: 0x04002F5E RID: 12126
		[Token(Token = "0x4002F5E")]
		[FieldOffset(Offset = "0x228")]
		public SphereCollider ItemDetectionCollider;

		// Token: 0x04002F5F RID: 12127
		[Token(Token = "0x4002F5F")]
		[FieldOffset(Offset = "0x230")]
		public UnityEvent OnFlush;

		// Token: 0x04002F60 RID: 12128
		[Token(Token = "0x4002F60")]
		[FieldOffset(Offset = "0x238")]
		private Coroutine _flushCoroutine;

		// Token: 0x04002F61 RID: 12129
		[Token(Token = "0x4002F61")]
		[FieldOffset(Offset = "0x240")]
		private bool isFlushing;

		// Token: 0x04002F62 RID: 12130
		[Token(Token = "0x4002F62")]
		[FieldOffset(Offset = "0x241")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F63 RID: 12131
		[Token(Token = "0x4002F63")]
		[FieldOffset(Offset = "0x242")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted;
	}
}
