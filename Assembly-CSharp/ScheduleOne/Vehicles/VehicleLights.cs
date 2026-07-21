using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	[RequireComponent(typeof(LandVehicle))]
	public class VehicleLights : NetworkBehaviour
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000079E0 File Offset: 0x00005BE0
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036C")]
		public bool HeadlightsOn
		{
			[Token(Token = "0x6000FF2")]
			[Address(RVA = "0x9321C0", Offset = "0x9313C0", VA = "0x1809321C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FF3")]
			[Address(RVA = "0xB142D0", Offset = "0xB134D0", VA = "0x180B142D0")]
			[ServerRpc(RunLocally = true, RequireOwnership = false)]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0xB13660", Offset = "0xB12860", VA = "0x180B13660", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0xB14110", Offset = "0xB13310", VA = "0x180B14110", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0xB13CA0", Offset = "0xB12EA0", VA = "0x180B13CA0")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF7")]
		[Address(RVA = "0xB142B0", Offset = "0xB134B0", VA = "0x180B142B0")]
		public VehicleLights()
		{
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0xB13770", Offset = "0xB12970", VA = "0x180B13770", Slot = "21")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0xB13720", Offset = "0xB12920", VA = "0x180B13720", Slot = "22")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0xB136E0", Offset = "0xB128E0", VA = "0x180B136E0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0xB13B70", Offset = "0xB12D70", VA = "0x180B13B70")]
		private void RpcWriter___Server_set_HeadlightsOn_1140765316(bool value)
		{
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0xB13A50", Offset = "0xB12C50", VA = "0x180B13A50")]
		public void RpcLogic___set_HeadlightsOn_1140765316(bool value)
		{
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0xB13AE0", Offset = "0xB12CE0", VA = "0x180B13AE0")]
		private void RpcReader___Server_set_HeadlightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x000079F8 File Offset: 0x00005BF8
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036D")]
		public bool SyncAccessor_<HeadlightsOn>k__BackingField
		{
			[Token(Token = "0x6000FFE")]
			[Address(RVA = "0x9321C0", Offset = "0x9313C0", VA = "0x1809321C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FFF")]
			[Address(RVA = "0xB14400", Offset = "0xB13600", VA = "0x180B14400")]
			set
			{
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x6001000")]
		[Address(RVA = "0xB13910", Offset = "0xB12B10", VA = "0x180B13910", Slot = "23")]
		public virtual bool ReadSyncVar___ScheduleOne.Vehicles.VehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001001")]
		[Address(RVA = "0xB13610", Offset = "0xB12810", VA = "0x180B13610")]
		private void Awake_UserLogic_ScheduleOne.Vehicles.VehicleLights_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _debug;

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0x120")]
		[Header("Headlights")]
		public MeshRenderer[] headLightMeshes;

		// Token: 0x04000E3C RID: 3644
		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0x128")]
		public OptimizedLight[] headLightSources;

		// Token: 0x04000E3D RID: 3645
		[Token(Token = "0x4000E3D")]
		[FieldOffset(Offset = "0x130")]
		public Material headlightMat_On;

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000E3E")]
		[FieldOffset(Offset = "0x138")]
		public Material headLightMat_Off;

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0x140")]
		private bool headLightsApplied;

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000E40")]
		[FieldOffset(Offset = "0x148")]
		[Header("Brake lights")]
		public MeshRenderer[] brakeLightMeshes;

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000E41")]
		[FieldOffset(Offset = "0x150")]
		public Light[] brakeLightSources;

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0x158")]
		public Material brakeLightMat_On;

		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000E43")]
		[FieldOffset(Offset = "0x160")]
		public Material brakeLightMat_Off;

		// Token: 0x04000E44 RID: 3652
		[Token(Token = "0x4000E44")]
		[FieldOffset(Offset = "0x168")]
		private bool brakeLightsApplied;

		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000E45")]
		[FieldOffset(Offset = "0x169")]
		[Header("Reverse lights")]
		public bool hasReverseLights;

		// Token: 0x04000E46 RID: 3654
		[Token(Token = "0x4000E46")]
		[FieldOffset(Offset = "0x170")]
		public MeshRenderer[] reverseLightMeshes;

		// Token: 0x04000E47 RID: 3655
		[Token(Token = "0x4000E47")]
		[FieldOffset(Offset = "0x178")]
		public Light[] reverseLightSources;

		// Token: 0x04000E48 RID: 3656
		[Token(Token = "0x4000E48")]
		[FieldOffset(Offset = "0x180")]
		public Material reverseLightMat_On;

		// Token: 0x04000E49 RID: 3657
		[Token(Token = "0x4000E49")]
		[FieldOffset(Offset = "0x188")]
		public Material reverseLightMat_Off;

		// Token: 0x04000E4A RID: 3658
		[Token(Token = "0x4000E4A")]
		[FieldOffset(Offset = "0x190")]
		private bool reverseLightsApplied;

		// Token: 0x04000E4B RID: 3659
		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0x198")]
		private LandVehicle vehicle;

		// Token: 0x04000E4C RID: 3660
		[Token(Token = "0x4000E4C")]
		[FieldOffset(Offset = "0x1A0")]
		public SyncVar<bool> syncVar___<HeadlightsOn>k__BackingField;

		// Token: 0x04000E4D RID: 3661
		[Token(Token = "0x4000E4D")]
		[FieldOffset(Offset = "0x1A8")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted;

		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x1A9")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted;
	}
}
