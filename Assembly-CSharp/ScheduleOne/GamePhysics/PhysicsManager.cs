using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.GamePhysics
{
	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	public class PhysicsManager : NetworkSingleton<PhysicsManager>
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00009BA0 File Offset: 0x00007DA0
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A0")]
		public float GravityMultiplier
		{
			[Token(Token = "0x6001842")]
			[Address(RVA = "0x5D6EB0", Offset = "0x5D60B0", VA = "0x1805D6EB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001843")]
			[Address(RVA = "0x5D6ED0", Offset = "0x5D60D0", VA = "0x1805D6ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x00009BB8 File Offset: 0x00007DB8
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A1")]
		public LayerMask GroundDetectionLayerMask
		{
			[Token(Token = "0x6001844")]
			[Address(RVA = "0x5D6EC0", Offset = "0x5D60C0", VA = "0x1805D6EC0")]
			[CompilerGenerated]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6001845")]
			[Address(RVA = "0x5D6EE0", Offset = "0x5D60E0", VA = "0x1805D6EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x5D64C0", Offset = "0x5D56C0", VA = "0x1805D64C0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x5D6720", Offset = "0x5D5920", VA = "0x1805D6720", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x5D6BF0", Offset = "0x5D5DF0", VA = "0x1805D6BF0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetGravityMultiplier(NetworkConnection conn, float gravity)
		{
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x5D6E60", Offset = "0x5D6060", VA = "0x1805D6E60")]
		public PhysicsManager()
		{
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x5D6630", Offset = "0x5D5830", VA = "0x1805D6630", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x5D65E0", Offset = "0x5D57E0", VA = "0x1805D65E0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184D")]
		[Address(RVA = "0x5D6950", Offset = "0x5D5B50", VA = "0x1805D6950")]
		private void RpcWriter___Observers_SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x5D6780", Offset = "0x5D5980", VA = "0x1805D6780")]
		public void RpcLogic___SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184F")]
		[Address(RVA = "0x5D6880", Offset = "0x5D5A80", VA = "0x1805D6880")]
		private void RpcReader___Observers_SetGravityMultiplier_530160725(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x5D6A90", Offset = "0x5D5C90", VA = "0x1805D6A90")]
		private void RpcWriter___Target_SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001851")]
		[Address(RVA = "0x5D68F0", Offset = "0x5D5AF0", VA = "0x1805D68F0")]
		private void RpcReader___Target_SetGravityMultiplier_530160725(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001852")]
		[Address(RVA = "0x5D63D0", Offset = "0x5D55D0", VA = "0x1805D63D0", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.GamePhysics.PhysicsManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001547 RID: 5447
		[Token(Token = "0x4001547")]
		public const bool AutoSyncTransforms = true;

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		[FieldOffset(Offset = "0x128")]
		private bool NetworkInitialize___EarlyScheduleOne.GamePhysics.PhysicsManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400154B RID: 5451
		[Token(Token = "0x400154B")]
		[FieldOffset(Offset = "0x129")]
		private bool NetworkInitialize__LateScheduleOne.GamePhysics.PhysicsManagerAssembly-CSharp.dll_Excuted;
	}
}
