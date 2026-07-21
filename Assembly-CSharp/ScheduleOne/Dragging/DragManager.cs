using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Dragging
{
	// Token: 0x020006CE RID: 1742
	[Token(Token = "0x20006CE")]
	public class DragManager : NetworkSingleton<DragManager>
	{
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B8")]
		public Draggable CurrentDraggable
		{
			[Token(Token = "0x6002E1D")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E1E")]
			[Address(RVA = "0x57F870", Offset = "0x57EA70", VA = "0x18057F870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x0000E598 File Offset: 0x0000C798
		[Token(Token = "0x170007B9")]
		public bool IsDragging
		{
			[Token(Token = "0x6002E1F")]
			[Address(RVA = "0x74A8E0", Offset = "0x749AE0", VA = "0x18074A8E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x747480", Offset = "0x746680", VA = "0x180747480", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x749EF0", Offset = "0x7490F0", VA = "0x180749EF0")]
		public void Update()
		{
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x746AB0", Offset = "0x745CB0", VA = "0x180746AB0")]
		public void FixedUpdate()
		{
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		[Token(Token = "0x6002E23")]
		[Address(RVA = "0x747060", Offset = "0x746260", VA = "0x180747060")]
		public bool IsDraggingAllowed()
		{
			return default(bool);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E24")]
		[Address(RVA = "0x747740", Offset = "0x746940", VA = "0x180747740")]
		public void RegisterDraggable(Draggable draggable)
		{
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E25")]
		[Address(RVA = "0x746840", Offset = "0x745A40", VA = "0x180746840")]
		public void Deregister(Draggable draggable)
		{
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x749610", Offset = "0x748810", VA = "0x180749610")]
		public void StartDragging(Draggable draggable)
		{
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E27")]
		[Address(RVA = "0x748ED0", Offset = "0x7480D0", VA = "0x180748ED0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x7478D0", Offset = "0x746AD0", VA = "0x1807478D0")]
		[ObserversRpc]
		private void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x749810", Offset = "0x748A10", VA = "0x180749810")]
		public void StopDragging(Vector3 velocity)
		{
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x749390", Offset = "0x748590", VA = "0x180749390")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0x7494C0", Offset = "0x7486C0", VA = "0x1807494C0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x6002E2C")]
		[Address(RVA = "0x746EC0", Offset = "0x7460C0", VA = "0x180746EC0")]
		private Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2D")]
		[Address(RVA = "0x7468D0", Offset = "0x745AD0", VA = "0x1807468D0")]
		[Button]
		public void EnsureAllDraggableGUIDsAreValid()
		{
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2E")]
		[Address(RVA = "0x74A7E0", Offset = "0x7499E0", VA = "0x18074A7E0")]
		public DragManager()
		{
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2F")]
		[Address(RVA = "0x749B20", Offset = "0x748D20", VA = "0x180749B20")]
		[CompilerGenerated]
		private void <OnSpawnServer>g__SendDraggableData|18_0(NetworkConnection conn)
		{
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E30")]
		[Address(RVA = "0x7472C0", Offset = "0x7464C0", VA = "0x1807472C0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E31")]
		[Address(RVA = "0x747270", Offset = "0x746470", VA = "0x180747270", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E32")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E33")]
		[Address(RVA = "0x748ED0", Offset = "0x7480D0", VA = "0x180748ED0")]
		private void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E34")]
		[Address(RVA = "0x7478D0", Offset = "0x746AD0", VA = "0x1807478D0")]
		private void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E35")]
		[Address(RVA = "0x7484F0", Offset = "0x7476F0", VA = "0x1807484F0")]
		private void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E36")]
		[Address(RVA = "0x7478D0", Offset = "0x746AD0", VA = "0x1807478D0")]
		private void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E37")]
		[Address(RVA = "0x747CC0", Offset = "0x746EC0", VA = "0x180747CC0")]
		private void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E38")]
		[Address(RVA = "0x7481B0", Offset = "0x7473B0", VA = "0x1807481B0")]
		private void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E39")]
		[Address(RVA = "0x748BF0", Offset = "0x747DF0", VA = "0x180748BF0")]
		private void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E3A")]
		[Address(RVA = "0x7477D0", Offset = "0x7469D0", VA = "0x1807477D0")]
		private void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E3B")]
		[Address(RVA = "0x7482D0", Offset = "0x7474D0", VA = "0x1807482D0")]
		private void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E3C")]
		[Address(RVA = "0x7488D0", Offset = "0x747AD0", VA = "0x1807488D0")]
		private void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E3D")]
		[Address(RVA = "0x747A80", Offset = "0x746C80", VA = "0x180747A80")]
		private void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E3E")]
		[Address(RVA = "0x747FE0", Offset = "0x7471E0", VA = "0x180747FE0")]
		private void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E3F")]
		[Address(RVA = "0x749070", Offset = "0x748270", VA = "0x180749070")]
		private void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E40")]
		[Address(RVA = "0x748700", Offset = "0x747900", VA = "0x180748700")]
		private void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E41")]
		[Address(RVA = "0x7467D0", Offset = "0x7459D0", VA = "0x1807467D0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0400222F RID: 8751
		[Token(Token = "0x400222F")]
		public const float DRAGGABLE_OFFSET = 1.25f;

		// Token: 0x04002230 RID: 8752
		[Token(Token = "0x4002230")]
		[FieldOffset(Offset = "0x120")]
		public AudioSourceController ThrowSound;

		// Token: 0x04002231 RID: 8753
		[Token(Token = "0x4002231")]
		[FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public float DragForce;

		// Token: 0x04002232 RID: 8754
		[Token(Token = "0x4002232")]
		[FieldOffset(Offset = "0x12C")]
		public float DampingFactor;

		// Token: 0x04002233 RID: 8755
		[Token(Token = "0x4002233")]
		[FieldOffset(Offset = "0x130")]
		public float TorqueForce;

		// Token: 0x04002234 RID: 8756
		[Token(Token = "0x4002234")]
		[FieldOffset(Offset = "0x134")]
		public float TorqueDampingFactor;

		// Token: 0x04002235 RID: 8757
		[Token(Token = "0x4002235")]
		[FieldOffset(Offset = "0x138")]
		public float ThrowForce;

		// Token: 0x04002236 RID: 8758
		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0x13C")]
		public float MassInfluence;

		// Token: 0x04002238 RID: 8760
		[Token(Token = "0x4002238")]
		[FieldOffset(Offset = "0x148")]
		private List<Draggable> AllDraggables;

		// Token: 0x04002239 RID: 8761
		[Token(Token = "0x4002239")]
		[FieldOffset(Offset = "0x150")]
		private List<Draggable> CurrentlyUpdating;

		// Token: 0x0400223A RID: 8762
		[Token(Token = "0x400223A")]
		[FieldOffset(Offset = "0x158")]
		private Draggable lastThrownDraggable;

		// Token: 0x0400223B RID: 8763
		[Token(Token = "0x400223B")]
		[FieldOffset(Offset = "0x160")]
		private Draggable lastHeldDraggable;

		// Token: 0x0400223C RID: 8764
		[Token(Token = "0x400223C")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400223D RID: 8765
		[Token(Token = "0x400223D")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted;
	}
}
