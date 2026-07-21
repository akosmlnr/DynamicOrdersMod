using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E23 RID: 3619
	[Token(Token = "0x2000E23")]
	public class CombatManager : NetworkSingleton<CombatManager>
	{
		// Token: 0x060067DD RID: 26589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067DD")]
		[Address(RVA = "0xAA8870", Offset = "0xAA7A70", VA = "0x180AA8870")]
		[Button]
		public void CreateTestExplosion()
		{
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067DE")]
		[Address(RVA = "0xAA8660", Offset = "0xAA7860", VA = "0x180AA8660")]
		public void CreateExplosion(Vector3 origin, ExplosionData data)
		{
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067DF")]
		[Address(RVA = "0xAA8770", Offset = "0xAA7970", VA = "0x180AA8770")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void CreateExplosion(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E0")]
		[Address(RVA = "0xAA8BF0", Offset = "0xAA7DF0", VA = "0x180AA8BF0")]
		[ObserversRpc(RunLocally = true)]
		private void Explosion(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E1")]
		[Address(RVA = "0xAA9750", Offset = "0xAA8950", VA = "0x180AA9750")]
		public CombatManager()
		{
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E2")]
		[Address(RVA = "0xAA8D00", Offset = "0xAA7F00", VA = "0x180AA8D00", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E3")]
		[Address(RVA = "0xAA8CB0", Offset = "0xAA7EB0", VA = "0x180AA8CB0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E4")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E5")]
		[Address(RVA = "0xAA9500", Offset = "0xAA8700", VA = "0x180AA9500")]
		private void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E6")]
		[Address(RVA = "0xAA8BF0", Offset = "0xAA7DF0", VA = "0x180AA8BF0")]
		private void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E7")]
		[Address(RVA = "0xAA90E0", Offset = "0xAA82E0", VA = "0x180AA90E0")]
		private void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E8")]
		[Address(RVA = "0xAA9290", Offset = "0xAA8490", VA = "0x180AA9290")]
		private void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E9")]
		[Address(RVA = "0xAA8E00", Offset = "0xAA8000", VA = "0x180AA8E00")]
		private void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067EA")]
		[Address(RVA = "0xAA8F90", Offset = "0xAA8190", VA = "0x180AA8F90")]
		private void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067EB")]
		[Address(RVA = "0xAA85F0", Offset = "0xAA77F0", VA = "0x180AA85F0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04004962 RID: 18786
		[Token(Token = "0x4004962")]
		[FieldOffset(Offset = "0x120")]
		public LayerMask MeleeLayerMask;

		// Token: 0x04004963 RID: 18787
		[Token(Token = "0x4004963")]
		[FieldOffset(Offset = "0x124")]
		public LayerMask ExplosionLayerMask;

		// Token: 0x04004964 RID: 18788
		[Token(Token = "0x4004964")]
		[FieldOffset(Offset = "0x128")]
		public LayerMask RangedWeaponLayerMask;

		// Token: 0x04004965 RID: 18789
		[Token(Token = "0x4004965")]
		[FieldOffset(Offset = "0x130")]
		public Explosion ExplosionPrefab;

		// Token: 0x04004966 RID: 18790
		[Token(Token = "0x4004966")]
		[FieldOffset(Offset = "0x138")]
		private List<int> explosionIDs;

		// Token: 0x04004967 RID: 18791
		[Token(Token = "0x4004967")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04004968 RID: 18792
		[Token(Token = "0x4004968")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted;
	}
}
