using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	public class EntityVisibility : NetworkBehaviour
	{
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x000099D8 File Offset: 0x00007BD8
		[Token(Token = "0x17000490")]
		public virtual float CurrentVisibility
		{
			[Token(Token = "0x60017C9")]
			[Address(RVA = "0x5CE650", Offset = "0x5CD850", VA = "0x1805CE650", Slot = "19")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x000099F0 File Offset: 0x00007BF0
		[Token(Token = "0x17000491")]
		public virtual float Suspiciousness
		{
			[Token(Token = "0x60017CA")]
			[Address(RVA = "0x5CE660", Offset = "0x5CD860", VA = "0x1805CE660", Slot = "20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000492")]
		public List<EntityVisualState> VisualStates
		{
			[Token(Token = "0x60017CB")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017CC")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00009A08 File Offset: 0x00007C08
		[Token(Token = "0x17000493")]
		public Vector3 CenterPoint
		{
			[Token(Token = "0x60017CD")]
			[Address(RVA = "0x5CE530", Offset = "0x5CD730", VA = "0x1805CE530")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x5CD820", Offset = "0x5CCA20", VA = "0x1805CD820", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00009A20 File Offset: 0x00007C20
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x5CD020", Offset = "0x5CC220", VA = "0x1805CD020")]
		private float CalculateVisibility()
		{
			return 0f;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x5CD570", Offset = "0x5CC770", VA = "0x1805CD570")]
		public VisibilityAttribute GetAttribute(string name)
		{
			return null;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x5CE2E0", Offset = "0x5CD4E0", VA = "0x1805CE2E0")]
		private void UpdateEnvironmentalVisibilityAttribute()
		{
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x5CC0B0", Offset = "0x5CB2B0", VA = "0x1805CC0B0")]
		public float CalculateExposureToPoint(Vector3 point, float checkRange = 50f, [Optional] NPC checkingNPC)
		{
			return 0f;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x5CC050", Offset = "0x5CB250", VA = "0x1805CC050")]
		[ServerRpc(RunLocally = true)]
		public void ApplyState(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x5CD8D0", Offset = "0x5CCAD0", VA = "0x1805CD8D0")]
		[ServerRpc(RunLocally = true)]
		public void RemoveState(string label, float delay = 0f)
		{
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x5CD650", Offset = "0x5CC850", VA = "0x1805CD650")]
		public EntityVisualState GetState(string label)
		{
			return null;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D7")]
		[Address(RVA = "0x5CD460", Offset = "0x5CC660", VA = "0x1805CD460")]
		public void ClearStates()
		{
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D8")]
		[Address(RVA = "0x5CE380", Offset = "0x5CD580", VA = "0x1805CE380")]
		public EntityVisibility()
		{
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D9")]
		[Address(RVA = "0x5CD750", Offset = "0x5CC950", VA = "0x1805CD750", Slot = "22")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x5CD730", Offset = "0x5CC930", VA = "0x1805CD730", Slot = "23")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DB")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x5CDF20", Offset = "0x5CD120", VA = "0x1805CDF20")]
		private void RpcWriter___Server_ApplyState_2910447583(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x5CD910", Offset = "0x5CCB10", VA = "0x1805CD910")]
		public void RpcLogic___ApplyState_2910447583(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x5CDDB0", Offset = "0x5CCFB0", VA = "0x1805CDDB0")]
		private void RpcReader___Server_ApplyState_2910447583(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x5CE0F0", Offset = "0x5CD2F0", VA = "0x1805CE0F0")]
		private void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
		{
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x5CDB60", Offset = "0x5CCD60", VA = "0x1805CDB60")]
		public void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x5CDE80", Offset = "0x5CD080", VA = "0x1805CDE80")]
		private void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "24")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vision.EntityVisibility_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040014DA RID: 5338
		[Token(Token = "0x40014DA")]
		public const float MAX_VISIBLITY = 100f;

		// Token: 0x040014DB RID: 5339
		[Token(Token = "0x40014DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public List<VisibilityAttribute> ActiveAttributes;

		// Token: 0x040014DD RID: 5341
		[Token(Token = "0x40014DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public LayerMask VisibilityCheckMask;

		// Token: 0x040014DE RID: 5342
		[Token(Token = "0x40014DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Header("References")]
		public Transform CentralVisibilityPoint;

		// Token: 0x040014DF RID: 5343
		[Token(Token = "0x40014DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public List<Transform> VisibilityPoints;

		// Token: 0x040014E0 RID: 5344
		[Token(Token = "0x40014E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private VisibilityAttribute environmentalVisibility;

		// Token: 0x040014E1 RID: 5345
		[Token(Token = "0x40014E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Dictionary<string, Coroutine> removalRoutinesDict;

		// Token: 0x040014E2 RID: 5346
		[Token(Token = "0x40014E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Dictionary<string, float> maxPointsChangesByUniquenessCode;

		// Token: 0x040014E3 RID: 5347
		[Token(Token = "0x40014E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<RaycastHit> hits;

		// Token: 0x040014E4 RID: 5348
		[Token(Token = "0x40014E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool NetworkInitialize___EarlyScheduleOne.Vision.EntityVisibilityAssembly-CSharp.dll_Excuted;

		// Token: 0x040014E5 RID: 5349
		[Token(Token = "0x40014E5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		private bool NetworkInitialize__LateScheduleOne.Vision.EntityVisibilityAssembly-CSharp.dll_Excuted;
	}
}
