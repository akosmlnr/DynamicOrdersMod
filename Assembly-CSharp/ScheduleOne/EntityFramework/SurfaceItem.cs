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
using ScheduleOne.Building;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	public class SurfaceItem : BuildableItem
	{
		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000726")]
		public Surface ParentSurface
		{
			[Token(Token = "0x6002956")]
			[Address(RVA = "0x6E7FA0", Offset = "0x6E71A0", VA = "0x1806E7FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002957")]
			[Address(RVA = "0x6E7FC0", Offset = "0x6E71C0", VA = "0x1806E7FC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x17000727")]
		public float RotationIncrement
		{
			[Token(Token = "0x6002958")]
			[Address(RVA = "0x6E7FB0", Offset = "0x6E71B0", VA = "0x1806E7FB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x6E6090", Offset = "0x6E5290", VA = "0x1806E6090", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295A")]
		[Address(RVA = "0x6E7820", Offset = "0x6E6A20", VA = "0x1806E7820", Slot = "54")]
		protected override void SendInitializationToServer()
		{
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295B")]
		[Address(RVA = "0x6E76B0", Offset = "0x6E68B0", VA = "0x1806E76B0", Slot = "53")]
		protected override void SendInitializationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x6E63A0", Offset = "0x6E55A0", VA = "0x1806E63A0")]
		[ServerRpc(RequireOwnership = false)]
		private void InitializeSurfaceItem_Server(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x6E6240", Offset = "0x6E5440", VA = "0x1806E6240")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void InitializeSurfaceItem_Client(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x6E6400", Offset = "0x6E5600", VA = "0x1806E6400", Slot = "66")]
		public virtual void InitializeSurfaceItem(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600295F")]
		[Address(RVA = "0x6E78E0", Offset = "0x6E6AE0", VA = "0x1806E78E0")]
		private void SetTransformData(string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x6E6230", Offset = "0x6E5430", VA = "0x1806E6230", Slot = "49")]
		protected override Property GetProperty([Optional] Transform searchTransform)
		{
			return null;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x6E60E0", Offset = "0x6E52E0", VA = "0x1806E60E0", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002962")]
		[Address(RVA = "0x6E7DD0", Offset = "0x6E6FD0", VA = "0x1806E7DD0")]
		public SurfaceItem()
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002963")]
		[Address(RVA = "0x6E7D60", Offset = "0x6E6F60", VA = "0x1806E7D60")]
		[CompilerGenerated]
		private IEnumerator <SetTransformData>g__Routine|17_0()
		{
			return null;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x6E6670", Offset = "0x6E5870", VA = "0x1806E6670", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x6E6640", Offset = "0x6E5840", VA = "0x1806E6640", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002968")]
		[Address(RVA = "0x6E70E0", Offset = "0x6E62E0", VA = "0x1806E70E0")]
		private void RpcWriter___Server_InitializeSurfaceItem_Server_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x6E6820", Offset = "0x6E5A20", VA = "0x1806E6820")]
		private void RpcLogic___InitializeSurfaceItem_Server_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x6E6A80", Offset = "0x6E5C80", VA = "0x1806E6A80")]
		private void RpcReader___Server_InitializeSurfaceItem_Server_2652836379(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x6E73B0", Offset = "0x6E65B0", VA = "0x1806E73B0")]
		private void RpcWriter___Target_InitializeSurfaceItem_Client_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x6E67A0", Offset = "0x6E59A0", VA = "0x1806E67A0")]
		private void RpcLogic___InitializeSurfaceItem_Client_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x6E6C70", Offset = "0x6E5E70", VA = "0x1806E6C70")]
		private void RpcReader___Target_InitializeSurfaceItem_Client_2932264618(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x6E6DE0", Offset = "0x6E5FE0", VA = "0x1806E6DE0")]
		private void RpcWriter___Observers_InitializeSurfaceItem_Client_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x6E6910", Offset = "0x6E5B10", VA = "0x1806E6910")]
		private void RpcReader___Observers_InitializeSurfaceItem_Client_2932264618(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x6E6080", Offset = "0x6E5280", VA = "0x1806E6080", Slot = "67")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.SurfaceItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001F78 RID: 8056
		[Token(Token = "0x4001F78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[Header("Settings")]
		public List<Surface.ESurfaceType> ValidSurfaceTypes;

		// Token: 0x04001F79 RID: 8057
		[Token(Token = "0x4001F79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool AllowRotation;

		// Token: 0x04001F7B RID: 8059
		[Token(Token = "0x4001F7B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected Vector3 RelativePosition;

		// Token: 0x04001F7C RID: 8060
		[Token(Token = "0x4001F7C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		protected Quaternion RelativeRotation;

		// Token: 0x04001F7D RID: 8061
		[Token(Token = "0x4001F7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F7E RID: 8062
		[Token(Token = "0x4001F7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x205")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted;
	}
}
