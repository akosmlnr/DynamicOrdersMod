using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B0E RID: 2830
	[Token(Token = "0x2000B0E")]
	public class FaceTargetBehaviour : Behaviour
	{
		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06005325 RID: 21285 RVA: 0x00015BB8 File Offset: 0x00013DB8
		// (set) Token: 0x06005326 RID: 21286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6C")]
		public FaceTargetBehaviour.ETargetType TargetType
		{
			[Token(Token = "0x6005325")]
			[Address(RVA = "0x57F830", Offset = "0x57EA30", VA = "0x18057F830")]
			[CompilerGenerated]
			get
			{
				return FaceTargetBehaviour.ETargetType.Player;
			}
			[Token(Token = "0x6005326")]
			[Address(RVA = "0x57F8A0", Offset = "0x57EAA0", VA = "0x18057F8A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06005327 RID: 21287 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005328 RID: 21288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6D")]
		public Player TargetPlayer
		{
			[Token(Token = "0x6005327")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005328")]
			[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06005329 RID: 21289 RVA: 0x00015BD0 File Offset: 0x00013DD0
		// (set) Token: 0x0600532A RID: 21290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6E")]
		public Vector3 TargetPosition
		{
			[Token(Token = "0x6005329")]
			[Address(RVA = "0x960CE0", Offset = "0x95FEE0", VA = "0x180960CE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600532A")]
			[Address(RVA = "0x960D00", Offset = "0x95FF00", VA = "0x180960D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x0600532B RID: 21291 RVA: 0x00015BE8 File Offset: 0x00013DE8
		// (set) Token: 0x0600532C RID: 21292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6F")]
		public float Countdown
		{
			[Token(Token = "0x600532B")]
			[Address(RVA = "0x7458B0", Offset = "0x744AB0", VA = "0x1807458B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600532C")]
			[Address(RVA = "0x745920", Offset = "0x744B20", VA = "0x180745920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600532D")]
		[Address(RVA = "0x960980", Offset = "0x95FB80", VA = "0x180960980")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTarget(NetworkObject player, float countDown = 5f)
		{
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600532E")]
		[Address(RVA = "0x960840", Offset = "0x95FA40", VA = "0x180960840")]
		[ObserversRpc(RunLocally = true)]
		private void SetTargetLocal(NetworkObject player)
		{
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600532F")]
		[Address(RVA = "0x960AD0", Offset = "0x95FCD0", VA = "0x180960AD0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTarget(Vector3 position, float countDown = 5f)
		{
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005330")]
		[Address(RVA = "0x9606A0", Offset = "0x95F8A0", VA = "0x1809606A0")]
		[ObserversRpc(RunLocally = true)]
		private void SetTargetLocal(Vector3 position)
		{
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005331")]
		[Address(RVA = "0x95F5A0", Offset = "0x95E7A0", VA = "0x18095F5A0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005332")]
		[Address(RVA = "0x95F5E0", Offset = "0x95E7E0", VA = "0x18095F5E0", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x00015C00 File Offset: 0x00013E00
		[Token(Token = "0x6005333")]
		[Address(RVA = "0x95F790", Offset = "0x95E990", VA = "0x18095F790")]
		private Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005334")]
		[Address(RVA = "0x94AF80", Offset = "0x94A180", VA = "0x18094AF80", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005335")]
		[Address(RVA = "0x960C80", Offset = "0x95FE80", VA = "0x180960C80")]
		public FaceTargetBehaviour()
		{
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005336")]
		[Address(RVA = "0x95F850", Offset = "0x95EA50", VA = "0x18095F850", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005337")]
		[Address(RVA = "0x9477E0", Offset = "0x9469E0", VA = "0x1809477E0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005338")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005339")]
		[Address(RVA = "0x9603A0", Offset = "0x95F5A0", VA = "0x1809603A0")]
		private void RpcWriter___Server_SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533A")]
		[Address(RVA = "0x95FA90", Offset = "0x95EC90", VA = "0x18095FA90")]
		public void RpcLogic___SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533B")]
		[Address(RVA = "0x95FF30", Offset = "0x95F130", VA = "0x18095FF30")]
		private void RpcReader___Server_SetTarget_244313061(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533C")]
		[Address(RVA = "0x9600D0", Offset = "0x95F2D0", VA = "0x1809600D0")]
		private void RpcWriter___Observers_SetTargetLocal_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533D")]
		[Address(RVA = "0x95F9C0", Offset = "0x95EBC0", VA = "0x18095F9C0")]
		private void RpcLogic___SetTargetLocal_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533E")]
		[Address(RVA = "0x95FE10", Offset = "0x95F010", VA = "0x18095FE10")]
		private void RpcReader___Observers_SetTargetLocal_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600533F")]
		[Address(RVA = "0x960500", Offset = "0x95F700", VA = "0x180960500")]
		private void RpcWriter___Server_SetTarget_3661469815(Vector3 position, float countDown = 5f)
		{
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005340")]
		[Address(RVA = "0x95FC70", Offset = "0x95EE70", VA = "0x18095FC70")]
		public void RpcLogic___SetTarget_3661469815(Vector3 position, float countDown = 5f)
		{
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005341")]
		[Address(RVA = "0x95FFD0", Offset = "0x95F1D0", VA = "0x18095FFD0")]
		private void RpcReader___Server_SetTarget_3661469815(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005342")]
		[Address(RVA = "0x960210", Offset = "0x95F410", VA = "0x180960210")]
		private void RpcWriter___Observers_SetTargetLocal_4276783012(Vector3 position)
		{
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005343")]
		[Address(RVA = "0x95FA70", Offset = "0x95EC70", VA = "0x18095FA70")]
		private void RpcLogic___SetTargetLocal_4276783012(Vector3 position)
		{
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005344")]
		[Address(RVA = "0x95FE80", Offset = "0x95F080", VA = "0x18095FE80")]
		private void RpcReader___Observers_SetTargetLocal_4276783012(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005345")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400387B RID: 14459
		[Token(Token = "0x400387B")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FaceTargetBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400387C RID: 14460
		[Token(Token = "0x400387C")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FaceTargetBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x02000B0F RID: 2831
		[Token(Token = "0x2000B0F")]
		public enum ETargetType
		{
			// Token: 0x0400387E RID: 14462
			[Token(Token = "0x400387E")]
			Player,
			// Token: 0x0400387F RID: 14463
			[Token(Token = "0x400387F")]
			Position
		}
	}
}
