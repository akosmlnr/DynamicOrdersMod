using System;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B48 RID: 2888
	[Token(Token = "0x2000B48")]
	public class NPCSignal_WalkToLocation : NPCSignal
	{
		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060056A3 RID: 22179 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CAF")]
		public new string ActionName
		{
			[Token(Token = "0x60056A3")]
			[Address(RVA = "0x9A29B0", Offset = "0x9A1BB0", VA = "0x1809A29B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60056A4")]
		[Address(RVA = "0x9A21B0", Offset = "0x9A13B0", VA = "0x1809A21B0", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A5")]
		[Address(RVA = "0x9A2780", Offset = "0x9A1980", VA = "0x1809A2780", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A6")]
		[Address(RVA = "0x9A1FE0", Offset = "0x9A11E0", VA = "0x1809A1FE0", Slot = "30")]
		public override void ActiveUpdate()
		{
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A7")]
		[Address(RVA = "0x99EAC0", Offset = "0x99DCC0", VA = "0x18099EAC0", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A8")]
		[Address(RVA = "0x9A2250", Offset = "0x9A1450", VA = "0x1809A2250", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A9")]
		[Address(RVA = "0x99F050", Offset = "0x99E250", VA = "0x18099F050", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056AA")]
		[Address(RVA = "0x9A26F0", Offset = "0x9A18F0", VA = "0x1809A26F0", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00016308 File Offset: 0x00014508
		[Token(Token = "0x60056AB")]
		[Address(RVA = "0x9A22C0", Offset = "0x9A14C0", VA = "0x1809A22C0")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056AC")]
		[Address(RVA = "0x9A27E0", Offset = "0x9A19E0", VA = "0x1809A27E0", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056AD")]
		[Address(RVA = "0x9A24D0", Offset = "0x9A16D0", VA = "0x1809A24D0")]
		[ObserversRpc]
		private void ReachedDestination()
		{
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056AE")]
		[Address(RVA = "0x9A2990", Offset = "0x9A1B90", VA = "0x1809A2990")]
		public NPCSignal_WalkToLocation()
		{
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056AF")]
		[Address(RVA = "0x9A2440", Offset = "0x9A1640", VA = "0x1809A2440", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B0")]
		[Address(RVA = "0x9A2420", Offset = "0x9A1620", VA = "0x1809A2420", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B1")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B2")]
		[Address(RVA = "0x9A24D0", Offset = "0x9A16D0", VA = "0x1809A24D0")]
		private void RpcWriter___Observers_ReachedDestination_2166136261()
		{
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B3")]
		[Address(RVA = "0x9A25E0", Offset = "0x9A17E0", VA = "0x1809A25E0")]
		private void RpcLogic___ReachedDestination_2166136261()
		{
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B4")]
		[Address(RVA = "0x9A2660", Offset = "0x9A1860", VA = "0x1809A2660")]
		private void RpcReader___Observers_ReachedDestination_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B5")]
		[Address(RVA = "0x99E770", Offset = "0x99D970", VA = "0x18099E770", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040039EB RID: 14827
		[Token(Token = "0x40039EB")]
		[FieldOffset(Offset = "0x150")]
		public Transform Destination;

		// Token: 0x040039EC RID: 14828
		[Token(Token = "0x40039EC")]
		[FieldOffset(Offset = "0x158")]
		public bool FaceDestinationDir;

		// Token: 0x040039ED RID: 14829
		[Token(Token = "0x40039ED")]
		[FieldOffset(Offset = "0x15C")]
		public float DestinationThreshold;

		// Token: 0x040039EE RID: 14830
		[Token(Token = "0x40039EE")]
		[FieldOffset(Offset = "0x160")]
		public bool WarpIfSkipped;

		// Token: 0x040039EF RID: 14831
		[Token(Token = "0x40039EF")]
		[FieldOffset(Offset = "0x161")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted;

		// Token: 0x040039F0 RID: 14832
		[Token(Token = "0x40039F0")]
		[FieldOffset(Offset = "0x162")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WalkToLocationAssembly-CSharp.dll_Excuted;
	}
}
