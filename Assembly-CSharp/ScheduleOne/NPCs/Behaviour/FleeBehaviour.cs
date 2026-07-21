using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	public class FleeBehaviour : Behaviour
	{
		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005347 RID: 21319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C70")]
		public NetworkObject EntityToFlee
		{
			[Token(Token = "0x6005346")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005347")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x00015C18 File Offset: 0x00013E18
		[Token(Token = "0x17000C71")]
		public Vector3 PointToFlee
		{
			[Token(Token = "0x6005348")]
			[Address(RVA = "0x9624B0", Offset = "0x9616B0", VA = "0x1809624B0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06005349 RID: 21321 RVA: 0x00015C30 File Offset: 0x00013E30
		// (set) Token: 0x0600534A RID: 21322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C72")]
		public FleeBehaviour.EFleeMode FleeMode
		{
			[Token(Token = "0x6005349")]
			[Address(RVA = "0x745880", Offset = "0x744A80", VA = "0x180745880")]
			[CompilerGenerated]
			get
			{
				return FleeBehaviour.EFleeMode.Entity;
			}
			[Token(Token = "0x600534A")]
			[Address(RVA = "0x7458E0", Offset = "0x744AE0", VA = "0x1807458E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x0600534B RID: 21323 RVA: 0x00015C48 File Offset: 0x00013E48
		// (set) Token: 0x0600534C RID: 21324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C73")]
		public Vector3 FleeOrigin
		{
			[Token(Token = "0x600534B")]
			[Address(RVA = "0x962490", Offset = "0x961690", VA = "0x180962490")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600534C")]
			[Address(RVA = "0x962530", Offset = "0x961730", VA = "0x180962530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600534D")]
		[Address(RVA = "0x961EF0", Offset = "0x9610F0", VA = "0x180961EF0")]
		[ObserversRpc(RunLocally = true)]
		public void SetEntityToFlee(NetworkObject entity)
		{
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600534E")]
		[Address(RVA = "0x962040", Offset = "0x961240", VA = "0x180962040")]
		[ObserversRpc(RunLocally = true)]
		public void SetPointToFlee(Vector3 point)
		{
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600534F")]
		[Address(RVA = "0x960D20", Offset = "0x95FF20", VA = "0x180960D20", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005350")]
		[Address(RVA = "0x961A50", Offset = "0x960C50", VA = "0x180961A50", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005351")]
		[Address(RVA = "0x960E40", Offset = "0x960040", VA = "0x180960E40", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005352")]
		[Address(RVA = "0x961A30", Offset = "0x960C30", VA = "0x180961A30", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005353")]
		[Address(RVA = "0x9621E0", Offset = "0x9613E0", VA = "0x1809621E0")]
		private void StartFlee()
		{
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005354")]
		[Address(RVA = "0x9616F0", Offset = "0x9608F0", VA = "0x1809616F0", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005355")]
		[Address(RVA = "0x960D90", Offset = "0x95FF90", VA = "0x180960D90", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005356")]
		[Address(RVA = "0x962360", Offset = "0x961560", VA = "0x180962360")]
		private void Stop()
		{
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005357")]
		[Address(RVA = "0x960EC0", Offset = "0x9600C0", VA = "0x180960EC0")]
		private void Flee()
		{
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x00015C60 File Offset: 0x00013E60
		[Token(Token = "0x6005358")]
		[Address(RVA = "0x960F50", Offset = "0x960150", VA = "0x180960F50")]
		public Vector3 GetFleePosition()
		{
			return default(Vector3);
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005359")]
		[Address(RVA = "0x9623F0", Offset = "0x9615F0", VA = "0x1809623F0")]
		public FleeBehaviour()
		{
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535A")]
		[Address(RVA = "0x961610", Offset = "0x960810", VA = "0x180961610", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535B")]
		[Address(RVA = "0x94D290", Offset = "0x94C490", VA = "0x18094D290", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535C")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535D")]
		[Address(RVA = "0x961C20", Offset = "0x960E20", VA = "0x180961C20")]
		private void RpcWriter___Observers_SetEntityToFlee_3323014238(NetworkObject entity)
		{
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535E")]
		[Address(RVA = "0x961A70", Offset = "0x960C70", VA = "0x180961A70")]
		public void RpcLogic___SetEntityToFlee_3323014238(NetworkObject entity)
		{
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535F")]
		[Address(RVA = "0x961AC0", Offset = "0x960CC0", VA = "0x180961AC0")]
		private void RpcReader___Observers_SetEntityToFlee_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005360")]
		[Address(RVA = "0x961D60", Offset = "0x960F60", VA = "0x180961D60")]
		private void RpcWriter___Observers_SetPointToFlee_4276783012(Vector3 point)
		{
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005361")]
		[Address(RVA = "0x961AA0", Offset = "0x960CA0", VA = "0x180961AA0")]
		public void RpcLogic___SetPointToFlee_4276783012(Vector3 point)
		{
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005362")]
		[Address(RVA = "0x961B50", Offset = "0x960D50", VA = "0x180961B50")]
		private void RpcReader___Observers_SetPointToFlee_4276783012(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005363")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003880 RID: 14464
		[Token(Token = "0x4003880")]
		public const float FLEE_DIST_MIN = 20f;

		// Token: 0x04003881 RID: 14465
		[Token(Token = "0x4003881")]
		public const float FLEE_DIST_MAX = 40f;

		// Token: 0x04003882 RID: 14466
		[Token(Token = "0x4003882")]
		public const float FLEE_SPEED = 0.7f;

		// Token: 0x04003886 RID: 14470
		[Token(Token = "0x4003886")]
		[FieldOffset(Offset = "0x180")]
		private Vector3 currentFleeTarget;

		// Token: 0x04003887 RID: 14471
		[Token(Token = "0x4003887")]
		[FieldOffset(Offset = "0x18C")]
		private float nextVO;

		// Token: 0x04003888 RID: 14472
		[Token(Token = "0x4003888")]
		[FieldOffset(Offset = "0x190")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003889 RID: 14473
		[Token(Token = "0x4003889")]
		[FieldOffset(Offset = "0x191")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x02000B11 RID: 2833
		[Token(Token = "0x2000B11")]
		public enum EFleeMode
		{
			// Token: 0x0400388B RID: 14475
			[Token(Token = "0x400388B")]
			Entity,
			// Token: 0x0400388C RID: 14476
			[Token(Token = "0x400388C")]
			Point
		}
	}
}
