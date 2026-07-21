using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B07 RID: 2823
	[Token(Token = "0x2000B07")]
	public class StartMixingStationBehaviour : Behaviour
	{
		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060052C0 RID: 21184 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060052C1 RID: 21185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C62")]
		public MixingStation targetStation
		{
			[Token(Token = "0x60052C0")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60052C1")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C2")]
		[Address(RVA = "0x9725F0", Offset = "0x9717F0", VA = "0x1809725F0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C3")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void AssignStation(MixingStation station)
		{
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C4")]
		[Address(RVA = "0x972970", Offset = "0x971B70", VA = "0x180972970", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C5")]
		[Address(RVA = "0x9730E0", Offset = "0x9722E0", VA = "0x1809730E0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C6")]
		[Address(RVA = "0x972D70", Offset = "0x971F70", VA = "0x180972D70", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C7")]
		[Address(RVA = "0x972700", Offset = "0x971900", VA = "0x180972700", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C8")]
		[Address(RVA = "0x9733A0", Offset = "0x9725A0", VA = "0x1809733A0")]
		[ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00015A50 File Offset: 0x00013C50
		[Token(Token = "0x60052C9")]
		[Address(RVA = "0x9727B0", Offset = "0x9719B0", VA = "0x1809727B0")]
		private bool CanCookStart()
		{
			return default(bool);
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x9734C0", Offset = "0x9726C0", VA = "0x1809734C0")]
		private void StopCook()
		{
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00015A68 File Offset: 0x00013C68
		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x972A30", Offset = "0x971C30", VA = "0x180972A30")]
		private Vector3 GetStationAccessPoint()
		{
			return default(Vector3);
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00015A80 File Offset: 0x00013C80
		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x972B30", Offset = "0x971D30", VA = "0x180972B30")]
		private bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public StartMixingStationBehaviour()
		{
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60052CE")]
		[Address(RVA = "0x9735B0", Offset = "0x9727B0", VA = "0x1809735B0")]
		[CompilerGenerated]
		private IEnumerator <StartCook>g__CookRoutine|13_0()
		{
			return null;
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CF")]
		[Address(RVA = "0x972CE0", Offset = "0x971EE0", VA = "0x180972CE0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D0")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D1")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D2")]
		[Address(RVA = "0x973290", Offset = "0x972490", VA = "0x180973290")]
		private void RpcWriter___Observers_StartCook_2166136261()
		{
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D3")]
		[Address(RVA = "0x973170", Offset = "0x972370", VA = "0x180973170")]
		private void RpcLogic___StartCook_2166136261()
		{
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D4")]
		[Address(RVA = "0x973250", Offset = "0x972450", VA = "0x180973250")]
		private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D5")]
		[Address(RVA = "0x972500", Offset = "0x971700", VA = "0x180972500", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartMixingStationBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003851 RID: 14417
		[Token(Token = "0x4003851")]
		public const float INSERT_INGREDIENT_BASE_TIME = 1f;

		// Token: 0x04003853 RID: 14419
		[Token(Token = "0x4003853")]
		[FieldOffset(Offset = "0x170")]
		private Chemist chemist;

		// Token: 0x04003854 RID: 14420
		[Token(Token = "0x4003854")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine startRoutine;

		// Token: 0x04003855 RID: 14421
		[Token(Token = "0x4003855")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003856 RID: 14422
		[Token(Token = "0x4003856")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted;
	}
}
