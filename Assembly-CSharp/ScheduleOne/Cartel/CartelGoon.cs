using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	public class CartelGoon : NPC
	{
		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x0000FC78 File Offset: 0x0000DE78
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000850")]
		public bool IsGoonSpawned
		{
			[Token(Token = "0x6003412")]
			[Address(RVA = "0x72EFB0", Offset = "0x72E1B0", VA = "0x18072EFB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003413")]
			[Address(RVA = "0x72F0D0", Offset = "0x72E2D0", VA = "0x18072F0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000851")]
		public GoonPool GoonPool
		{
			[Token(Token = "0x6003414")]
			[Address(RVA = "0x796980", Offset = "0x795B80", VA = "0x180796980")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003415")]
		[Address(RVA = "0x796850", Offset = "0x795A50", VA = "0x180796850", Slot = "88")]
		protected override void Start()
		{
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003416")]
		[Address(RVA = "0x7955D0", Offset = "0x7947D0", VA = "0x1807955D0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003417")]
		[Address(RVA = "0x795520", Offset = "0x794720", VA = "0x180795520", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003418")]
		[Address(RVA = "0x796640", Offset = "0x795840", VA = "0x180796640")]
		public void Spawn(GoonPool pool, Vector3 spawnPoint)
		{
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003419")]
		[Address(RVA = "0x7963F0", Offset = "0x7955F0", VA = "0x1807963F0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void Spawn_Client(NetworkConnection conn)
		{
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341A")]
		[Address(RVA = "0x794B90", Offset = "0x793D90", VA = "0x180794B90")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void ConfigureGoonSettings(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341B")]
		[Address(RVA = "0x795090", Offset = "0x794290", VA = "0x180795090")]
		public void Despawn()
		{
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341C")]
		[Address(RVA = "0x794E40", Offset = "0x794040", VA = "0x180794E40")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void Despawn_Client(NetworkConnection conn)
		{
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341D")]
		[Address(RVA = "0x7948E0", Offset = "0x793AE0", VA = "0x1807948E0")]
		public void AttackEntity(ICombatTargetable target, bool includeGoonMates = true)
		{
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341E")]
		[Address(RVA = "0x7947D0", Offset = "0x7939D0", VA = "0x1807947D0")]
		public void AddGoonMate(CartelGoon goonMate)
		{
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341F")]
		[Address(RVA = "0x795600", Offset = "0x794800", VA = "0x180795600")]
		public void RemoveGoonMate(CartelGoon goonMate)
		{
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x0000FC90 File Offset: 0x0000DE90
		[Token(Token = "0x6003420")]
		[Address(RVA = "0x7952B0", Offset = "0x7944B0", VA = "0x1807952B0")]
		public bool IsMatesWith(CartelGoon otherGoon)
		{
			return default(bool);
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003421")]
		[Address(RVA = "0x796900", Offset = "0x795B00", VA = "0x180796900")]
		public CartelGoon()
		{
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003422")]
		[Address(RVA = "0x795330", Offset = "0x794530", VA = "0x180795330", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003423")]
		[Address(RVA = "0x795310", Offset = "0x794510", VA = "0x180795310", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003424")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003425")]
		[Address(RVA = "0x795F10", Offset = "0x795110", VA = "0x180795F10")]
		private void RpcWriter___Observers_Spawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003426")]
		[Address(RVA = "0x7959E0", Offset = "0x794BE0", VA = "0x1807959E0")]
		private void RpcLogic___Spawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003427")]
		[Address(RVA = "0x795B40", Offset = "0x794D40", VA = "0x180795B40")]
		private void RpcReader___Observers_Spawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003428")]
		[Address(RVA = "0x7962C0", Offset = "0x7954C0", VA = "0x1807962C0")]
		private void RpcWriter___Target_Spawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003429")]
		[Address(RVA = "0x795C40", Offset = "0x794E40", VA = "0x180795C40")]
		private void RpcReader___Target_Spawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342A")]
		[Address(RVA = "0x795C80", Offset = "0x794E80", VA = "0x180795C80")]
		private void RpcWriter___Observers_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342B")]
		[Address(RVA = "0x795710", Offset = "0x794910", VA = "0x180795710")]
		private void RpcLogic___ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342C")]
		[Address(RVA = "0x795A70", Offset = "0x794C70", VA = "0x180795A70")]
		private void RpcReader___Observers_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342D")]
		[Address(RVA = "0x796030", Offset = "0x795230", VA = "0x180796030")]
		private void RpcWriter___Target_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342E")]
		[Address(RVA = "0x795B80", Offset = "0x794D80", VA = "0x180795B80")]
		private void RpcReader___Target_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342F")]
		[Address(RVA = "0x795DF0", Offset = "0x794FF0", VA = "0x180795DF0")]
		private void RpcWriter___Observers_Despawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003430")]
		[Address(RVA = "0x795950", Offset = "0x794B50", VA = "0x180795950")]
		private void RpcLogic___Despawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003431")]
		[Address(RVA = "0x795B00", Offset = "0x794D00", VA = "0x180795B00")]
		private void RpcReader___Observers_Despawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003432")]
		[Address(RVA = "0x796190", Offset = "0x795390", VA = "0x180796190")]
		private void RpcWriter___Target_Despawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003433")]
		[Address(RVA = "0x795C00", Offset = "0x794E00", VA = "0x180795C00")]
		private void RpcReader___Target_Despawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003434")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x04002617 RID: 9751
		[Token(Token = "0x4002617")]
		[FieldOffset(Offset = "0x330")]
		private List<CartelGoon> goonMates;

		// Token: 0x04002618 RID: 9752
		[Token(Token = "0x4002618")]
		[FieldOffset(Offset = "0x338")]
		private CartelGoonAppearance appearance;

		// Token: 0x04002619 RID: 9753
		[Token(Token = "0x4002619")]
		[FieldOffset(Offset = "0x340")]
		public Action onDespawn;

		// Token: 0x0400261A RID: 9754
		[Token(Token = "0x400261A")]
		[FieldOffset(Offset = "0x348")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelGoonAssembly-CSharp.dll_Excuted;

		// Token: 0x0400261B RID: 9755
		[Token(Token = "0x400261B")]
		[FieldOffset(Offset = "0x349")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelGoonAssembly-CSharp.dll_Excuted;
	}
}
