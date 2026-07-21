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
	// Token: 0x02000B05 RID: 2821
	[Token(Token = "0x2000B05")]
	public class StartLabOvenBehaviour : Behaviour
	{
		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060052A5 RID: 21157 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060052A6 RID: 21158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5F")]
		public LabOven targetOven
		{
			[Token(Token = "0x60052A5")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60052A6")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A7")]
		[Address(RVA = "0x9716C0", Offset = "0x9708C0", VA = "0x1809716C0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A8")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void SetTargetOven(LabOven oven)
		{
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A9")]
		[Address(RVA = "0x971910", Offset = "0x970B10", VA = "0x180971910", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052AA")]
		[Address(RVA = "0x971D10", Offset = "0x970F10", VA = "0x180971D10", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052AB")]
		[Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052AC")]
		[Address(RVA = "0x9722B0", Offset = "0x9714B0", VA = "0x1809722B0")]
		[ObserversRpc(RunLocally = true)]
		private void StartCook()
		{
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x000159F0 File Offset: 0x00013BF0
		[Token(Token = "0x60052AD")]
		[Address(RVA = "0x9717D0", Offset = "0x9709D0", VA = "0x1809717D0")]
		private bool CanCookStart()
		{
			return default(bool);
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052AE")]
		[Address(RVA = "0x9723D0", Offset = "0x9715D0", VA = "0x1809723D0")]
		private void StopCook()
		{
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x00015A08 File Offset: 0x00013C08
		[Token(Token = "0x60052AF")]
		[Address(RVA = "0x9719D0", Offset = "0x970BD0", VA = "0x1809719D0")]
		private Vector3 GetStationAccessPoint()
		{
			return default(Vector3);
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00015A20 File Offset: 0x00013C20
		[Token(Token = "0x60052B0")]
		[Address(RVA = "0x971AD0", Offset = "0x970CD0", VA = "0x180971AD0")]
		private bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B1")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public StartLabOvenBehaviour()
		{
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60052B2")]
		[Address(RVA = "0x972490", Offset = "0x971690", VA = "0x180972490")]
		[CompilerGenerated]
		private IEnumerator <StartCook>g__CookRoutine|12_0()
		{
			return null;
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B3")]
		[Address(RVA = "0x971C80", Offset = "0x970E80", VA = "0x180971C80", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B4")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B5")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B6")]
		[Address(RVA = "0x9721A0", Offset = "0x9713A0", VA = "0x1809721A0")]
		private void RpcWriter___Observers_StartCook_2166136261()
		{
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B7")]
		[Address(RVA = "0x972080", Offset = "0x971280", VA = "0x180972080")]
		private void RpcLogic___StartCook_2166136261()
		{
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B8")]
		[Address(RVA = "0x972160", Offset = "0x971360", VA = "0x180972160")]
		private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B9")]
		[Address(RVA = "0x9715D0", Offset = "0x9707D0", VA = "0x1809715D0", Slot = "35")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartLabOvenBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003848 RID: 14408
		[Token(Token = "0x4003848")]
		public const float POUR_TIME = 5f;

		// Token: 0x0400384A RID: 14410
		[Token(Token = "0x400384A")]
		[FieldOffset(Offset = "0x170")]
		private Chemist chemist;

		// Token: 0x0400384B RID: 14411
		[Token(Token = "0x400384B")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine cookRoutine;

		// Token: 0x0400384C RID: 14412
		[Token(Token = "0x400384C")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartLabOvenBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x0400384D RID: 14413
		[Token(Token = "0x400384D")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartLabOvenBehaviourAssembly-CSharp.dll_Excuted;
	}
}
