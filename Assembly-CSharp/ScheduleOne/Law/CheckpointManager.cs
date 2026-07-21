using System;
using FishNet.Connection;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	public class CheckpointManager : NetworkSingleton<CheckpointManager>
	{
		// Token: 0x06002174 RID: 8564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002174")]
		[Address(RVA = "0x66D870", Offset = "0x66CA70", VA = "0x18066D870", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002175")]
		[Address(RVA = "0x66D930", Offset = "0x66CB30", VA = "0x18066D930")]
		public void SetCheckpointEnabled(CheckpointManager.ECheckpointLocation checkpoint, bool enabled, int requestedOfficers)
		{
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002176")]
		[Address(RVA = "0x66D790", Offset = "0x66C990", VA = "0x18066D790")]
		public RoadCheckpoint GetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			return null;
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002177")]
		[Address(RVA = "0x66DB00", Offset = "0x66CD00", VA = "0x18066DB00")]
		public CheckpointManager()
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002178")]
		[Address(RVA = "0x66D820", Offset = "0x66CA20", VA = "0x18066D820", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002179")]
		[Address(RVA = "0x66D7D0", Offset = "0x66C9D0", VA = "0x18066D7D0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217A")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217B")]
		[Address(RVA = "0x66D720", Offset = "0x66C920", VA = "0x18066D720", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04001B26 RID: 6950
		[Token(Token = "0x4001B26")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		public RoadCheckpoint WesternCheckpoint;

		// Token: 0x04001B27 RID: 6951
		[Token(Token = "0x4001B27")]
		[FieldOffset(Offset = "0x128")]
		public RoadCheckpoint DocksCheckpoint;

		// Token: 0x04001B28 RID: 6952
		[Token(Token = "0x4001B28")]
		[FieldOffset(Offset = "0x130")]
		public RoadCheckpoint NorthResidentialCheckpoint;

		// Token: 0x04001B29 RID: 6953
		[Token(Token = "0x4001B29")]
		[FieldOffset(Offset = "0x138")]
		public RoadCheckpoint WestResidentialCheckpoint;

		// Token: 0x04001B2A RID: 6954
		[Token(Token = "0x4001B2A")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B2B RID: 6955
		[Token(Token = "0x4001B2B")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x020005B1 RID: 1457
		[Token(Token = "0x20005B1")]
		public enum ECheckpointLocation
		{
			// Token: 0x04001B2D RID: 6957
			[Token(Token = "0x4001B2D")]
			Western,
			// Token: 0x04001B2E RID: 6958
			[Token(Token = "0x4001B2E")]
			Docks,
			// Token: 0x04001B2F RID: 6959
			[Token(Token = "0x4001B2F")]
			NorthResidential,
			// Token: 0x04001B30 RID: 6960
			[Token(Token = "0x4001B30")]
			WestResidential
		}
	}
}
