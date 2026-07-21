using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.Dragging;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A56 RID: 2646
	[Token(Token = "0x2000A56")]
	public class NPCMovement : NetworkBehaviour
	{
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06004C42 RID: 19522 RVA: 0x000147F0 File Offset: 0x000129F0
		// (set) Token: 0x06004C43 RID: 19523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD4")]
		public bool HasDestination
		{
			[Token(Token = "0x6004C42")]
			[Address(RVA = "0x92AA80", Offset = "0x929C80", VA = "0x18092AA80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C43")]
			[Address(RVA = "0x92ABF0", Offset = "0x929DF0", VA = "0x18092ABF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06004C44 RID: 19524 RVA: 0x00014808 File Offset: 0x00012A08
		[Token(Token = "0x17000BD5")]
		public bool IsMoving
		{
			[Token(Token = "0x6004C44")]
			[Address(RVA = "0x92AAB0", Offset = "0x929CB0", VA = "0x18092AAB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06004C45 RID: 19525 RVA: 0x00014820 File Offset: 0x00012A20
		// (set) Token: 0x06004C46 RID: 19526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD6")]
		public bool IsPaused
		{
			[Token(Token = "0x6004C45")]
			[Address(RVA = "0x92AB80", Offset = "0x929D80", VA = "0x18092AB80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C46")]
			[Address(RVA = "0x92AC00", Offset = "0x929E00", VA = "0x18092AC00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06004C47 RID: 19527 RVA: 0x00014838 File Offset: 0x00012A38
		[Token(Token = "0x17000BD7")]
		public Vector3 FootPosition
		{
			[Token(Token = "0x6004C47")]
			[Address(RVA = "0x92AA30", Offset = "0x929C30", VA = "0x18092AA30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x00014850 File Offset: 0x00012A50
		// (set) Token: 0x06004C49 RID: 19529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD8")]
		public float GravityMultiplier
		{
			[Token(Token = "0x6004C48")]
			[Address(RVA = "0x7458D0", Offset = "0x744AD0", VA = "0x1807458D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004C49")]
			[Address(RVA = "0x745940", Offset = "0x744B40", VA = "0x180745940")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x00014868 File Offset: 0x00012A68
		// (set) Token: 0x06004C4B RID: 19531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD9")]
		public NPCMovement.EStance Stance
		{
			[Token(Token = "0x6004C4A")]
			[Address(RVA = "0x92AB90", Offset = "0x929D90", VA = "0x18092AB90")]
			[CompilerGenerated]
			get
			{
				return NPCMovement.EStance.None;
			}
			[Token(Token = "0x6004C4B")]
			[Address(RVA = "0x928820", Offset = "0x927A20", VA = "0x180928820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06004C4C RID: 19532 RVA: 0x00014880 File Offset: 0x00012A80
		// (set) Token: 0x06004C4D RID: 19533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDA")]
		public float TimeSinceHitByCar
		{
			[Token(Token = "0x6004C4C")]
			[Address(RVA = "0x92ABA0", Offset = "0x929DA0", VA = "0x18092ABA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004C4D")]
			[Address(RVA = "0x92AC30", Offset = "0x929E30", VA = "0x18092AC30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x00014898 File Offset: 0x00012A98
		[Token(Token = "0x17000BDB")]
		public bool FaceDirectionInProgress
		{
			[Token(Token = "0x6004C4E")]
			[Address(RVA = "0x92AA20", Offset = "0x929C20", VA = "0x18092AA20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06004C4F RID: 19535 RVA: 0x000148B0 File Offset: 0x00012AB0
		[Token(Token = "0x17000BDC")]
		public bool IsOnLadder
		{
			[Token(Token = "0x6004C4F")]
			[Address(RVA = "0x92AB20", Offset = "0x929D20", VA = "0x18092AB20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x000148C8 File Offset: 0x00012AC8
		// (set) Token: 0x06004C51 RID: 19537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDD")]
		public float CurrentLadderSpeed
		{
			[Token(Token = "0x6004C50")]
			[Address(RVA = "0x8DD8F0", Offset = "0x8DCAF0", VA = "0x1808DD8F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004C51")]
			[Address(RVA = "0x92ABD0", Offset = "0x929DD0", VA = "0x18092ABD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06004C52 RID: 19538 RVA: 0x000148E0 File Offset: 0x00012AE0
		[Token(Token = "0x17000BDE")]
		public bool IsClimbingUpwards
		{
			[Token(Token = "0x6004C52")]
			[Address(RVA = "0x92AA90", Offset = "0x929C90", VA = "0x18092AA90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004C54 RID: 19540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDF")]
		public Ladder CurrentLadder
		{
			[Token(Token = "0x6004C53")]
			[Address(RVA = "0x6ECFE0", Offset = "0x6EC1E0", VA = "0x1806ECFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C54")]
			[Address(RVA = "0x6ED030", Offset = "0x6EC230", VA = "0x1806ED030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06004C55 RID: 19541 RVA: 0x000148F8 File Offset: 0x00012AF8
		// (set) Token: 0x06004C56 RID: 19542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE0")]
		public Vector3 CurrentDestination
		{
			[Token(Token = "0x6004C55")]
			[Address(RVA = "0x92A9F0", Offset = "0x929BF0", VA = "0x18092A9F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6004C56")]
			[Address(RVA = "0x92ABB0", Offset = "0x929DB0", VA = "0x18092ABB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06004C57 RID: 19543 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004C58 RID: 19544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE1")]
		public NPCPathCache PathCache
		{
			[Token(Token = "0x6004C57")]
			[Address(RVA = "0x7B12D0", Offset = "0x7B04D0", VA = "0x1807B12D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C58")]
			[Address(RVA = "0x92AC10", Offset = "0x929E10", VA = "0x18092AC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x00014910 File Offset: 0x00012B10
		// (set) Token: 0x06004C5A RID: 19546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE2")]
		public bool Disoriented
		{
			[Token(Token = "0x6004C59")]
			[Address(RVA = "0x92AA10", Offset = "0x929C10", VA = "0x18092AA10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C5A")]
			[Address(RVA = "0x92ABE0", Offset = "0x929DE0", VA = "0x18092ABE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5B")]
		[Address(RVA = "0x9225F0", Offset = "0x9217F0", VA = "0x1809225F0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5C")]
		[Address(RVA = "0x928A10", Offset = "0x927C10", VA = "0x180928A10")]
		private void Start()
		{
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5D")]
		[Address(RVA = "0x925690", Offset = "0x924890", VA = "0x180925690", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5E")]
		[Address(RVA = "0x929C60", Offset = "0x928E60", VA = "0x180929C60", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5F")]
		[Address(RVA = "0x9273C0", Offset = "0x9265C0", VA = "0x1809273C0")]
		public void SetAgentEnabled(bool enabled)
		{
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C60")]
		[Address(RVA = "0x929510", Offset = "0x928710", VA = "0x180929510")]
		private void UpdateRagdoll()
		{
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C61")]
		[Address(RVA = "0x928C70", Offset = "0x927E70", VA = "0x180928C70")]
		private void Stumble()
		{
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C62")]
		[Address(RVA = "0x929260", Offset = "0x928460", VA = "0x180929260")]
		private void UpdateDestination()
		{
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C63")]
		[Address(RVA = "0x924150", Offset = "0x923350", VA = "0x180924150", Slot = "21")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C64")]
		[Address(RVA = "0x929950", Offset = "0x928B50", VA = "0x180929950")]
		private void UpdateStumble()
		{
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C65")]
		[Address(RVA = "0x929840", Offset = "0x928A40", VA = "0x180929840")]
		private void UpdateSpeed()
		{
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C66")]
		[Address(RVA = "0x925990", Offset = "0x924B90", VA = "0x180925990")]
		private void RecordVelocity()
		{
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C67")]
		[Address(RVA = "0x929690", Offset = "0x928890", VA = "0x180929690")]
		private void UpdateSlippery()
		{
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C68")]
		[Address(RVA = "0x929090", Offset = "0x928290", VA = "0x180929090")]
		private void UpdateCache()
		{
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00014928 File Offset: 0x00012B28
		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x922C30", Offset = "0x921E30", VA = "0x180922C30")]
		public bool CanRecoverFromRagdoll()
		{
			return default(bool);
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0x928F80", Offset = "0x928180", VA = "0x180928F80")]
		private void UpdateAvoidance()
		{
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x9256E0", Offset = "0x9248E0", VA = "0x1809256E0")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0x9255A0", Offset = "0x9247A0", VA = "0x1809255A0")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0x922CE0", Offset = "0x921EE0", VA = "0x180922CE0")]
		private void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint, [Optional] Collision collision)
		{
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6E")]
		[Address(RVA = "0x92A230", Offset = "0x929430", VA = "0x18092A230")]
		public void Warp(Transform target)
		{
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6F")]
		[Address(RVA = "0x92A280", Offset = "0x929480", VA = "0x18092A280")]
		public void Warp(Vector3 position)
		{
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C70")]
		[Address(RVA = "0x925800", Offset = "0x924A00", VA = "0x180925800")]
		[ObserversRpc(ExcludeServer = true)]
		private void ReceiveWarp(Vector3 position)
		{
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x92A1F0", Offset = "0x9293F0", VA = "0x18092A1F0")]
		public void VisibilityChange(bool visible)
		{
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00014940 File Offset: 0x00012B40
		[Token(Token = "0x6004C72")]
		[Address(RVA = "0x922BC0", Offset = "0x921DC0", VA = "0x180922BC0")]
		public bool CanMove()
		{
			return default(bool);
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x9274D0", Offset = "0x9266D0", VA = "0x1809274D0")]
		public void SetAgentType(NPCMovement.EAgentType type)
		{
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x928770", Offset = "0x927970", VA = "0x180928770")]
		public void SetSeat(AvatarSeat seat)
		{
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C75")]
		[Address(RVA = "0x928820", Offset = "0x927A20", VA = "0x180928820")]
		public void SetStance(NPCMovement.EStance stance)
		{
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C76")]
		[Address(RVA = "0x928460", Offset = "0x927660", VA = "0x180928460")]
		public void SetGravityMultiplier(float multiplier)
		{
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C77")]
		[Address(RVA = "0x9275C0", Offset = "0x9267C0", VA = "0x1809275C0")]
		public void SetAngularSpeedMultiplier(float multiplier)
		{
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x928690", Offset = "0x927890", VA = "0x180928690")]
		public void SetRagdollDraggable(bool draggable)
		{
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x921EF0", Offset = "0x9210F0", VA = "0x180921EF0")]
		public void ActivateRagdoll_Server()
		{
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0x921DF0", Offset = "0x920FF0", VA = "0x180921DF0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ActivateRagdoll_Server(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7B")]
		[Address(RVA = "0x922020", Offset = "0x921220", VA = "0x180922020")]
		[ObserversRpc(RunLocally = true)]
		public void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7C")]
		[Address(RVA = "0x9220E0", Offset = "0x9212E0", VA = "0x1809220E0")]
		[ObserversRpc(RunLocally = true)]
		public void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7D")]
		[Address(RVA = "0x9239B0", Offset = "0x922BB0", VA = "0x1809239B0")]
		[ObserversRpc(RunLocally = true)]
		public void DeactivateRagdoll()
		{
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x6004C7E")]
		[Address(RVA = "0x928830", Offset = "0x927A30", VA = "0x180928830")]
		private bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			return default(bool);
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0x927640", Offset = "0x926840", VA = "0x180927640")]
		public void SetDestination(Transform target)
		{
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C80")]
		[Address(RVA = "0x9275F0", Offset = "0x9267F0", VA = "0x1809275F0")]
		public void SetDestination(Vector3 pos)
		{
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C81")]
		[Address(RVA = "0x928390", Offset = "0x927590", VA = "0x180928390")]
		public void SetDestination(ITransitEntity entity)
		{
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C82")]
		[Address(RVA = "0x928340", Offset = "0x927540", VA = "0x180928340")]
		public void SetDestination(Vector3 pos, [Optional] Action<NPCMovement.WalkResult> callback, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C83")]
		[Address(RVA = "0x9276B0", Offset = "0x9268B0", VA = "0x1809276B0")]
		private void SetDestination(Vector3 pos, [Optional] Action<NPCMovement.WalkResult> callback, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x00014970 File Offset: 0x00012B70
		[Token(Token = "0x6004C84")]
		[Address(RVA = "0x925350", Offset = "0x924550", VA = "0x180925350")]
		private bool IsNPCPositionValid(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x923AD0", Offset = "0x922CD0", VA = "0x180923AD0")]
		private void EndSetDestination(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x928B40", Offset = "0x927D40", VA = "0x180928B40")]
		public void Stop()
		{
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void WarpToNavMesh()
		{
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C88")]
		[Address(RVA = "0x923F40", Offset = "0x923140", VA = "0x180923F40")]
		public void FacePoint(Vector3 point, float lerpTime = 0.5f)
		{
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C89")]
		[Address(RVA = "0x923D20", Offset = "0x922F20", VA = "0x180923D20")]
		public void FaceDirection(Vector3 forward, float lerpTime = 0.5f)
		{
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004C8A")]
		[Address(RVA = "0x923C80", Offset = "0x922E80", VA = "0x180923C80")]
		protected IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime)
		{
			return null;
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C8B")]
		[Address(RVA = "0x925770", Offset = "0x924970", VA = "0x180925770")]
		public void PauseMovement()
		{
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C8C")]
		[Address(RVA = "0x925A60", Offset = "0x924C60", VA = "0x180925A60")]
		public void ResumeMovement()
		{
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x6004C8D")]
		[Address(RVA = "0x9250F0", Offset = "0x9242F0", VA = "0x1809250F0")]
		public bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5f)
		{
			return default(bool);
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x000149A0 File Offset: 0x00012BA0
		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0x924790", Offset = "0x923990", VA = "0x180924790")]
		public bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint)
		{
			return default(bool);
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0x9229A0", Offset = "0x921BA0", VA = "0x1809229A0")]
		public bool CanGetTo(Vector3 position, float proximityReq = 1f)
		{
			return default(bool);
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x000149D0 File Offset: 0x00012BD0
		[Token(Token = "0x6004C90")]
		[Address(RVA = "0x9229E0", Offset = "0x921BE0", VA = "0x1809229E0")]
		public bool CanGetTo(ITransitEntity entity, float proximityReq = 1f)
		{
			return default(bool);
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x6004C91")]
		[Address(RVA = "0x922640", Offset = "0x921840", VA = "0x180922640")]
		public bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path)
		{
			return default(bool);
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004C92")]
		[Address(RVA = "0x924D30", Offset = "0x923F30", VA = "0x180924D30")]
		private NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1f)
		{
			return null;
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C93")]
		[Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20")]
		public void TraverseLadder(Ladder ladder)
		{
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C94")]
		[Address(RVA = "0x922C70", Offset = "0x921E70", VA = "0x180922C70")]
		private void CancelTraverseLadder()
		{
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C95")]
		[Address(RVA = "0x92A7B0", Offset = "0x9299B0", VA = "0x18092A7B0")]
		public NPCMovement()
		{
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C97")]
		[Address(RVA = "0x9253F0", Offset = "0x9245F0", VA = "0x1809253F0", Slot = "22")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C98")]
		[Address(RVA = "0x9253D0", Offset = "0x9245D0", VA = "0x1809253D0", Slot = "23")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C99")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9A")]
		[Address(RVA = "0x925800", Offset = "0x924A00", VA = "0x180925800")]
		private void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position)
		{
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9B")]
		[Address(RVA = "0x926460", Offset = "0x925660", VA = "0x180926460")]
		private void RpcLogic___ReceiveWarp_4276783012(Vector3 position)
		{
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x926A40", Offset = "0x925C40", VA = "0x180926A40")]
		private void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9D")]
		[Address(RVA = "0x9271F0", Offset = "0x9263F0", VA = "0x1809271F0")]
		private void RpcWriter___Server_ActivateRagdoll_Server_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x922020", Offset = "0x921220", VA = "0x180922020")]
		public void RpcLogic___ActivateRagdoll_Server_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9F")]
		[Address(RVA = "0x926B10", Offset = "0x925D10", VA = "0x180926B10")]
		private void RpcReader___Server_ActivateRagdoll_Server_2690242654(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x926CF0", Offset = "0x925EF0", VA = "0x180926CF0")]
		private void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x925AB0", Offset = "0x924CB0", VA = "0x180925AB0")]
		public void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x926700", Offset = "0x925900", VA = "0x180926700")]
		private void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x926EE0", Offset = "0x9260E0", VA = "0x180926EE0")]
		private void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA4")]
		[Address(RVA = "0x925EC0", Offset = "0x9250C0", VA = "0x180925EC0")]
		public void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA5")]
		[Address(RVA = "0x926880", Offset = "0x925A80", VA = "0x180926880")]
		private void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x9270D0", Offset = "0x9262D0", VA = "0x1809270D0")]
		private void RpcWriter___Observers_DeactivateRagdoll_2166136261()
		{
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x926070", Offset = "0x925270", VA = "0x180926070")]
		public void RpcLogic___DeactivateRagdoll_2166136261()
		{
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x926A00", Offset = "0x925C00", VA = "0x180926A00")]
		private void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x9221A0", Offset = "0x9213A0", VA = "0x1809221A0", Slot = "24")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCMovement_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003564 RID: 13668
		[Token(Token = "0x4003564")]
		private const float VehicleRunoverSpeed = 10f;

		// Token: 0x04003565 RID: 13669
		[Token(Token = "0x4003565")]
		private const float VehicleRunoverRelativeVelocityThreshold_Sqr = 7.71605f;

		// Token: 0x04003566 RID: 13670
		[Token(Token = "0x4003566")]
		private const float VehicleImpactCooldown = 0.25f;

		// Token: 0x04003567 RID: 13671
		[Token(Token = "0x4003567")]
		private const float VehicleImpactForceMultiplier = 5f;

		// Token: 0x04003568 RID: 13672
		[Token(Token = "0x4003568")]
		private const float SkateboardRunoverSpeed = 10f;

		// Token: 0x04003569 RID: 13673
		[Token(Token = "0x4003569")]
		private const float SkateboardImpactForceMultiplier = 4f;

		// Token: 0x0400356A RID: 13674
		[Token(Token = "0x400356A")]
		public const float LIGHT_FLINCH_THRESHOLD = 50f;

		// Token: 0x0400356B RID: 13675
		[Token(Token = "0x400356B")]
		public const float HEAVY_FLINCH_THRESHOLD = 100f;

		// Token: 0x0400356C RID: 13676
		[Token(Token = "0x400356C")]
		public const float RAGDOLL_THRESHOLD = 150f;

		// Token: 0x0400356D RID: 13677
		[Token(Token = "0x400356D")]
		public const float MOMENTUM_ANNOYED_THRESHOLD = 10f;

		// Token: 0x0400356E RID: 13678
		[Token(Token = "0x400356E")]
		public const float MOMENTUM_LIGHT_FLINCH_THRESHOLD = 20f;

		// Token: 0x0400356F RID: 13679
		[Token(Token = "0x400356F")]
		public const float MOMENTUM_HEAVY_FLINCH_THRESHOLD = 40f;

		// Token: 0x04003570 RID: 13680
		[Token(Token = "0x4003570")]
		public const float MOMENTUM_RAGDOLL_THRESHOLD = 60f;

		// Token: 0x04003571 RID: 13681
		[Token(Token = "0x4003571")]
		public const bool USE_PATH_CACHE = true;

		// Token: 0x04003572 RID: 13682
		[Token(Token = "0x4003572")]
		public const float STUMBLE_DURATION = 0.66f;

		// Token: 0x04003573 RID: 13683
		[Token(Token = "0x4003573")]
		public const float STUMBLE_FORCE = 7f;

		// Token: 0x04003574 RID: 13684
		[Token(Token = "0x4003574")]
		public const float OBSTACLE_AVOIDANCE_RANGE = 25f;

		// Token: 0x04003575 RID: 13685
		[Token(Token = "0x4003575")]
		public const float PLAYER_DIST_IMPACT_THRESHOLD = 30f;

		// Token: 0x04003576 RID: 13686
		[Token(Token = "0x4003576")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<Vector3, Vector3> cachedClosestReachablePoints;

		// Token: 0x04003577 RID: 13687
		[Token(Token = "0x4003577")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<Vector3> cachedClosestPointKeys;

		// Token: 0x04003578 RID: 13688
		[Token(Token = "0x4003578")]
		public const float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = 1f;

		// Token: 0x04003579 RID: 13689
		[Token(Token = "0x4003579")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x0400357A RID: 13690
		[Token(Token = "0x400357A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[Header("Settings")]
		public float WalkSpeed;

		// Token: 0x0400357B RID: 13691
		[Token(Token = "0x400357B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float RunSpeed;

		// Token: 0x0400357C RID: 13692
		[Token(Token = "0x400357C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float MoveSpeedMultiplier;

		// Token: 0x0400357D RID: 13693
		[Token(Token = "0x400357D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("Obstacle Avoidance")]
		public bool ObstacleAvoidanceEnabled;

		// Token: 0x0400357E RID: 13694
		[Token(Token = "0x400357E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public ObstacleAvoidanceType DefaultObstacleAvoidanceType;

		// Token: 0x0400357F RID: 13695
		[Token(Token = "0x400357F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Header("Slippery Mode")]
		public bool SlipperyMode;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float SlipperyModeMultiplier;

		// Token: 0x04003581 RID: 13697
		[Token(Token = "0x4003581")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Header("References")]
		public NavMeshAgent Agent;

		// Token: 0x04003582 RID: 13698
		[Token(Token = "0x4003582")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public NPCSpeedController SpeedController;

		// Token: 0x04003583 RID: 13699
		[Token(Token = "0x4003583")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public CapsuleCollider CapsuleCollider;

		// Token: 0x04003584 RID: 13700
		[Token(Token = "0x4003584")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public NPCAnimation Animation;

		// Token: 0x04003585 RID: 13701
		[Token(Token = "0x4003585")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04003586 RID: 13702
		[Token(Token = "0x4003586")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Draggable RagdollDraggable;

		// Token: 0x04003587 RID: 13703
		[Token(Token = "0x4003587")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Collider RagdollDraggableCollider;

		// Token: 0x04003588 RID: 13704
		[Token(Token = "0x4003588")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected NPC npc;

		// Token: 0x04003589 RID: 13705
		[Token(Token = "0x4003589")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float MovementSpeedScale;

		// Token: 0x04003591 RID: 13713
		[Token(Token = "0x4003591")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float ragdollStaticTime;

		// Token: 0x04003592 RID: 13714
		[Token(Token = "0x4003592")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UnityEvent<LandVehicle> onHitByCar;

		// Token: 0x04003593 RID: 13715
		[Token(Token = "0x4003593")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public UnityEvent onRagdollStart;

		// Token: 0x04003594 RID: 13716
		[Token(Token = "0x4003594")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public UnityEvent onRagdollEnd;

		// Token: 0x04003597 RID: 13719
		[Token(Token = "0x4003597")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool cacheNextPath;

		// Token: 0x04003598 RID: 13720
		[Token(Token = "0x4003598")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 currentDestination_Reachable;

		// Token: 0x04003599 RID: 13721
		[Token(Token = "0x4003599")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Action<NPCMovement.WalkResult> walkResultCallback;

		// Token: 0x0400359A RID: 13722
		[Token(Token = "0x400359A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private float currentMaxDistanceForSuccess;

		// Token: 0x0400359B RID: 13723
		[Token(Token = "0x400359B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private bool forceIsMoving;

		// Token: 0x0400359C RID: 13724
		[Token(Token = "0x400359C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Coroutine faceDirectionRoutine;

		// Token: 0x0400359D RID: 13725
		[Token(Token = "0x400359D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private List<ConstantForce> ragdollForceComponents;

		// Token: 0x0400359F RID: 13727
		[Token(Token = "0x400359F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float timeUntilNextStumble;

		// Token: 0x040035A0 RID: 13728
		[Token(Token = "0x40035A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private float timeSinceStumble;

		// Token: 0x040035A1 RID: 13729
		[Token(Token = "0x40035A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private Vector3 stumbleDirection;

		// Token: 0x040035A2 RID: 13730
		[Token(Token = "0x40035A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private CircularQueue<Vector3> desiredVelocityHistory;

		// Token: 0x040035A3 RID: 13731
		[Token(Token = "0x40035A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private int desiredVelocityHistoryLength;

		// Token: 0x040035A4 RID: 13732
		[Token(Token = "0x40035A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float velocityHistorySpacing;

		// Token: 0x040035A5 RID: 13733
		[Token(Token = "0x40035A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private float timeSinceLastVelocityHistoryRecord;

		// Token: 0x040035A6 RID: 13734
		[Token(Token = "0x40035A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private NavMeshPath agentCurrentPath;

		// Token: 0x040035A7 RID: 13735
		[Token(Token = "0x40035A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private float agentCurrentSpeed;

		// Token: 0x040035A8 RID: 13736
		[Token(Token = "0x40035A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Vector3[] agentCurrentPathCorners;

		// Token: 0x040035A9 RID: 13737
		[Token(Token = "0x40035A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private Coroutine ladderClimbRoutine;

		// Token: 0x040035AA RID: 13738
		[Token(Token = "0x40035AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float _defaultAngularSpeed;

		// Token: 0x040035AB RID: 13739
		[Token(Token = "0x40035AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted;

		// Token: 0x040035AC RID: 13740
		[Token(Token = "0x40035AC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x255")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted;

		// Token: 0x02000A57 RID: 2647
		[Token(Token = "0x2000A57")]
		public enum EAgentType
		{
			// Token: 0x040035AE RID: 13742
			[Token(Token = "0x40035AE")]
			Humanoid,
			// Token: 0x040035AF RID: 13743
			[Token(Token = "0x40035AF")]
			BigHumanoid,
			// Token: 0x040035B0 RID: 13744
			[Token(Token = "0x40035B0")]
			IgnoreCosts
		}

		// Token: 0x02000A58 RID: 2648
		[Token(Token = "0x2000A58")]
		public enum EStance
		{
			// Token: 0x040035B2 RID: 13746
			[Token(Token = "0x40035B2")]
			None,
			// Token: 0x040035B3 RID: 13747
			[Token(Token = "0x40035B3")]
			Stanced
		}

		// Token: 0x02000A59 RID: 2649
		[Token(Token = "0x2000A59")]
		public enum WalkResult
		{
			// Token: 0x040035B5 RID: 13749
			[Token(Token = "0x40035B5")]
			Failed,
			// Token: 0x040035B6 RID: 13750
			[Token(Token = "0x40035B6")]
			Interrupted,
			// Token: 0x040035B7 RID: 13751
			[Token(Token = "0x40035B7")]
			Stopped,
			// Token: 0x040035B8 RID: 13752
			[Token(Token = "0x40035B8")]
			Partial,
			// Token: 0x040035B9 RID: 13753
			[Token(Token = "0x40035B9")]
			Success
		}
	}
}
