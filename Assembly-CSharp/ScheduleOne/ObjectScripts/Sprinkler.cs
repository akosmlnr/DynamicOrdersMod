using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Tiles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009CB RID: 2507
	[Token(Token = "0x20009CB")]
	public class Sprinkler : GridItem
	{
		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x00013788 File Offset: 0x00011988
		// (set) Token: 0x06004762 RID: 18274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B28")]
		public bool IsSprinkling
		{
			[Token(Token = "0x6004761")]
			[Address(RVA = "0x6E9280", Offset = "0x6E8480", VA = "0x1806E9280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004762")]
			[Address(RVA = "0x6E9290", Offset = "0x6E8490", VA = "0x1806E9290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004763")]
		[Address(RVA = "0x8C91C0", Offset = "0x8C83C0", VA = "0x1808C91C0")]
		public void Hovered()
		{
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004764")]
		[Address(RVA = "0x8C9250", Offset = "0x8C8450", VA = "0x1808C9250")]
		public void Interacted()
		{
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x6004765")]
		[Address(RVA = "0x8C8BC0", Offset = "0x8C7DC0", VA = "0x1808C8BC0")]
		private bool CanWater()
		{
			return default(bool);
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004766")]
		[Address(RVA = "0x8C9920", Offset = "0x8C8B20", VA = "0x1808C9920")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendWater()
		{
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004767")]
		[Address(RVA = "0x8C9490", Offset = "0x8C8690", VA = "0x1808C9490")]
		[ObserversRpc(RunLocally = true)]
		private void Water()
		{
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004768")]
		[Address(RVA = "0x8C8AB0", Offset = "0x8C7CB0", VA = "0x1808C8AB0")]
		public void AddWater(float normalizedAmount)
		{
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004769")]
		[Address(RVA = "0x8C8BD0", Offset = "0x8C7DD0", VA = "0x1808C8BD0", Slot = "71")]
		protected virtual List<Pot> GetPots()
		{
			return null;
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600476A")]
		[Address(RVA = "0x8C9AA0", Offset = "0x8C8CA0", VA = "0x1808C9AA0")]
		public Sprinkler()
		{
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600476B")]
		[Address(RVA = "0x8C9A30", Offset = "0x8C8C30", VA = "0x1808C9A30")]
		[CompilerGenerated]
		private IEnumerator <Water>g__Routine|18_0()
		{
			return null;
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600476C")]
		[Address(RVA = "0x8C93A0", Offset = "0x8C85A0", VA = "0x1808C93A0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600476D")]
		[Address(RVA = "0x8C9380", Offset = "0x8C8580", VA = "0x1808C9380", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600476E")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600476F")]
		[Address(RVA = "0x8C9810", Offset = "0x8C8A10", VA = "0x1808C9810")]
		private void RpcWriter___Server_SendWater_2166136261()
		{
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004770")]
		[Address(RVA = "0x8C9490", Offset = "0x8C8690", VA = "0x1808C9490")]
		private void RpcLogic___SendWater_2166136261()
		{
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004771")]
		[Address(RVA = "0x8C96A0", Offset = "0x8C88A0", VA = "0x1808C96A0")]
		private void RpcReader___Server_SendWater_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004772")]
		[Address(RVA = "0x8C96F0", Offset = "0x8C88F0", VA = "0x1808C96F0")]
		private void RpcWriter___Observers_Water_2166136261()
		{
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004773")]
		[Address(RVA = "0x8C95B0", Offset = "0x8C87B0", VA = "0x1808C95B0")]
		private void RpcLogic___Water_2166136261()
		{
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004774")]
		[Address(RVA = "0x8C9660", Offset = "0x8C8860", VA = "0x1808C9660")]
		private void RpcReader___Observers_Water_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004775")]
		[Address(RVA = "0x82F570", Offset = "0x82E770", VA = "0x18082F570", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0400328B RID: 12939
		[Token(Token = "0x400328B")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x0400328C RID: 12940
		[Token(Token = "0x400328C")]
		[FieldOffset(Offset = "0x220")]
		public ParticleSystem[] WaterParticles;

		// Token: 0x0400328D RID: 12941
		[Token(Token = "0x400328D")]
		[FieldOffset(Offset = "0x228")]
		public AudioSourceController ClickSound;

		// Token: 0x0400328E RID: 12942
		[Token(Token = "0x400328E")]
		[FieldOffset(Offset = "0x230")]
		public AudioSourceController WaterSound;

		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		[FieldOffset(Offset = "0x238")]
		[Header("Settings")]
		public float ApplyWaterDelay;

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x23C")]
		public float ParticleStopDelay;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x240")]
		public float Cooldown;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x248")]
		public List<Coordinate> TilesToWater;

		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		[FieldOffset(Offset = "0x250")]
		public int MinTilesToWater;

		// Token: 0x04003294 RID: 12948
		[Token(Token = "0x4003294")]
		[FieldOffset(Offset = "0x258")]
		public UnityEvent onSprinklerStart;

		// Token: 0x04003295 RID: 12949
		[Token(Token = "0x4003295")]
		[FieldOffset(Offset = "0x260")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted;

		// Token: 0x04003296 RID: 12950
		[Token(Token = "0x4003296")]
		[FieldOffset(Offset = "0x261")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted;
	}
}
