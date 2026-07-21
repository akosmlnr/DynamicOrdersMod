using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Experimental;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using ScheduleOne.Weather;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Skating
{
	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	public class Skateboard : NetworkBehaviour, IWeatherEntity
	{
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000089E8 File Offset: 0x00006BE8
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DE")]
		public float CurrentSteerInput
		{
			[Token(Token = "0x60012DA")]
			[Address(RVA = "0x5C0F90", Offset = "0x5C0190", VA = "0x1805C0F90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60012DB")]
			[Address(RVA = "0x5C0FB0", Offset = "0x5C01B0", VA = "0x1805C0FB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x170003DF")]
		public bool IsPushing
		{
			[Token(Token = "0x60012DC")]
			[Address(RVA = "0x895720", Offset = "0x894920", VA = "0x180895720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x170003E0")]
		public float TimeSincePushStart
		{
			[Token(Token = "0x60012DD")]
			[Address(RVA = "0x8DD580", Offset = "0x8DC780", VA = "0x1808DD580")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x170003E1")]
		public bool isGrounded
		{
			[Token(Token = "0x60012DE")]
			[Address(RVA = "0xB25940", Offset = "0xB24B40", VA = "0x180B25940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x170003E2")]
		public float AirTime
		{
			[Token(Token = "0x60012DF")]
			[Address(RVA = "0x66BB70", Offset = "0x66AD70", VA = "0x18066BB70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x00008A60 File Offset: 0x00006C60
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E3")]
		public float JumpBuildAmount
		{
			[Token(Token = "0x60012E0")]
			[Address(RVA = "0x5D6EB0", Offset = "0x5D60B0", VA = "0x1805D6EB0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60012E1")]
			[Address(RVA = "0xB24B70", Offset = "0xB23D70", VA = "0x180B24B70")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E4")]
		public Player Rider
		{
			[Token(Token = "0x60012E2")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012E3")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x170003E5")]
		public float TopSpeed_Ms
		{
			[Token(Token = "0x60012E4")]
			[Address(RVA = "0xB25920", Offset = "0xB24B20", VA = "0x180B25920")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E6")]
		private string ScheduleOne.Weather.IWeatherEntity.WeatherVolume
		{
			[Token(Token = "0x60012E5")]
			[Address(RVA = "0x8036E0", Offset = "0x8028E0", VA = "0x1808036E0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012E6")]
			[Address(RVA = "0xB24D20", Offset = "0xB23F20", VA = "0x180B24D20", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003E7")]
		private Transform ScheduleOne.Weather.IWeatherEntity.Transform
		{
			[Token(Token = "0x60012E7")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00008A90 File Offset: 0x00006C90
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E8")]
		public bool IsUnderCover
		{
			[Token(Token = "0x60012E8")]
			[Address(RVA = "0xB25910", Offset = "0xB24B10", VA = "0x180B25910", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60012E9")]
			[Address(RVA = "0xB25960", Offset = "0xB24B60", VA = "0x180B25960", Slot = "25")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003E9")]
		public SkateboardSettings CurentSettings
		{
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x8035E0", Offset = "0x8027E0", VA = "0x1808035E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003EA")]
		public SkateboardSettings DefaultSettings
		{
			[Token(Token = "0x60012EB")]
			[Address(RVA = "0xB258F0", Offset = "0xB24AF0", VA = "0x180B258F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EC")]
		[Address(RVA = "0xB22410", Offset = "0xB21610", VA = "0x180B22410", Slot = "26")]
		public virtual void Awake()
		{
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012ED")]
		[Address(RVA = "0xB24F50", Offset = "0xB24150", VA = "0x180B24F50")]
		private void Start()
		{
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0xB240D0", Offset = "0xB232D0", VA = "0x180B240D0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0xB256F0", Offset = "0xB248F0", VA = "0x180B256F0")]
		public void Update()
		{
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0xB23330", Offset = "0xB22530", VA = "0x180B23330")]
		private void GetInput()
		{
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0xB23130", Offset = "0xB22330", VA = "0x180B23130")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0xB23E10", Offset = "0xB23010", VA = "0x180B23E10")]
		private void LateUpdate()
		{
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0xB21200", Offset = "0xB20400", VA = "0x180B21200")]
		private void ApplyInput()
		{
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0xB21A80", Offset = "0xB20C80", VA = "0x180B21A80")]
		private void ApplyLateralFriction()
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0xB24FD0", Offset = "0xB241D0", VA = "0x180B24FD0")]
		private void UpdateHover()
		{
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0xB210B0", Offset = "0xB202B0", VA = "0x180B210B0")]
		private void ApplyGravity()
		{
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0xB22460", Offset = "0xB21660", VA = "0x180B22460")]
		private void CheckGrounded()
		{
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0xB22530", Offset = "0xB21730", VA = "0x180B22530")]
		private void CheckJump()
		{
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0xB24D40", Offset = "0xB23F40", VA = "0x180B24D40")]
		[ServerRpc(RunLocally = true)]
		private void SendJump(float jumpHeldTime)
		{
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0xB24420", Offset = "0xB23620", VA = "0x180B24420")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveJump(float _jumpHeldTime)
		{
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0xB23D10", Offset = "0xB22F10", VA = "0x180B23D10")]
		private void Jump()
		{
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0xB24230", Offset = "0xB23430", VA = "0x180B24230")]
		private void Push()
		{
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0xB23860", Offset = "0xB22A60", VA = "0x180B23860")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x60012FE")]
		[Address(RVA = "0xB23890", Offset = "0xB22A90", VA = "0x180B23890")]
		public bool IsGrounded(out RaycastHit hit)
		{
			return default(bool);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FF")]
		[Address(RVA = "0xB24EE0", Offset = "0xB240E0", VA = "0x180B24EE0")]
		public void SetVelocity(Vector3 velocity)
		{
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001300")]
		[Address(RVA = "0xB22A30", Offset = "0xB21C30", VA = "0x180B22A30")]
		private void ClampRotation()
		{
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001301")]
		[Address(RVA = "0xB21FE0", Offset = "0xB211E0", VA = "0x180B21FE0")]
		public void ApplyPlayerScale()
		{
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[Token(Token = "0x6001302")]
		[Address(RVA = "0xB237A0", Offset = "0xB229A0", VA = "0x180B237A0")]
		public float GetSurfaceSmoothness()
		{
			return 0f;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x6001303")]
		[Address(RVA = "0xB23C60", Offset = "0xB22E60", VA = "0x180B23C60")]
		public bool IsOnTerrain()
		{
			return default(bool);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001304")]
		[Address(RVA = "0xB241A0", Offset = "0xB233A0", VA = "0x180B241A0", Slot = "22")]
		public void OnWeatherChange(WeatherConditions newConditions)
		{
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "23")]
		public void OnUpdateWeatherEntity()
		{
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001306")]
		[Address(RVA = "0xB240C0", Offset = "0xB232C0", VA = "0x180B240C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001307")]
		[Address(RVA = "0xB25740", Offset = "0xB24940", VA = "0x180B25740")]
		public Skateboard()
		{
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001308")]
		[Address(RVA = "0xB24F60", Offset = "0xB24160", VA = "0x180B24F60")]
		[CompilerGenerated]
		private IEnumerator <Push>g__Push|131_0()
		{
			return null;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001309")]
		[Address(RVA = "0xB23E90", Offset = "0xB23090", VA = "0x180B23E90", Slot = "27")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130A")]
		[Address(RVA = "0xB23E40", Offset = "0xB23040", VA = "0x180B23E40", Slot = "28")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130B")]
		[Address(RVA = "0x8CE4C0", Offset = "0x8CD6C0", VA = "0x1808CE4C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130C")]
		[Address(RVA = "0xB24B70", Offset = "0xB23D70", VA = "0x180B24B70")]
		private void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
		{
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130D")]
		[Address(RVA = "0xB24600", Offset = "0xB23800", VA = "0x180B24600")]
		public void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130E")]
		[Address(RVA = "0xB24790", Offset = "0xB23990", VA = "0x180B24790")]
		private void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130F")]
		[Address(RVA = "0xB249C0", Offset = "0xB23BC0", VA = "0x180B249C0")]
		private void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001310")]
		[Address(RVA = "0xB24420", Offset = "0xB23620", VA = "0x180B24420")]
		private void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001311")]
		[Address(RVA = "0xB24700", Offset = "0xB23900", VA = "0x180B24700")]
		private void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001312")]
		[Address(RVA = "0xB24870", Offset = "0xB23A70", VA = "0x180B24870")]
		private void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001313")]
		[Address(RVA = "0xB24560", Offset = "0xB23760", VA = "0x180B24560")]
		private void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001314")]
		[Address(RVA = "0xB24690", Offset = "0xB23890", VA = "0x180B24690")]
		private void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00008B08 File Offset: 0x00006D08
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003EB")]
		public float SyncAccessor_<JumpBuildAmount>k__BackingField
		{
			[Token(Token = "0x6001315")]
			[Address(RVA = "0x5D6EB0", Offset = "0x5D60B0", VA = "0x1805D6EB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001316")]
			[Address(RVA = "0xB25970", Offset = "0xB24B70", VA = "0x180B25970")]
			set
			{
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x6001317")]
		[Address(RVA = "0xB242E0", Offset = "0xB234E0", VA = "0x180B242E0", Slot = "29")]
		public virtual bool ReadSyncVar___ScheduleOne.Skating.Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001318")]
		[Address(RVA = "0xB220E0", Offset = "0xB212E0", VA = "0x180B220E0")]
		private void Awake_UserLogic_ScheduleOne.Skating.Skateboard_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		public const float JumpCooldown = 0.3f;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		public const float JumpForceMin = 0.5f;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		public const float JumpForceBuildTime = 0.5f;

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		public const float PushCooldown = 1f;

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		public const float PushStaminaConsumption = 12.5f;

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		public const float PitchLimit = 60f;

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		public const float RollLimit = 20f;

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x118")]
		[Header("Info - Readonly")]
		public float CurrentSpeed_Kmh;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x130")]
		[Header("References")]
		public Rigidbody Rb;

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x138")]
		public Transform CoM;

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x140")]
		public Transform[] HoverPoints;

		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x148")]
		public Transform FrontAxlePosition;

		// Token: 0x04001132 RID: 4402
		[Token(Token = "0x4001132")]
		[FieldOffset(Offset = "0x150")]
		public Transform RearAxlePosition;

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x158")]
		public Transform PlayerContainer;

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x160")]
		public SkateboardAnimation Animation;

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x168")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0x170")]
		public AverageAcceleration Accelerometer;

		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x4001137")]
		[FieldOffset(Offset = "0x178")]
		[HideInInspector]
		public Skateboard_Equippable Equippable;

		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x4001138")]
		[FieldOffset(Offset = "0x180")]
		public Transform IKAlignmentsContainer;

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0x188")]
		[Header("Skateboard Settings")]
		[SerializeField]
		private SkateboardData _defaultData;

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private SkateboardOverrideData _rainOverrideData;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x198")]
		[Header("Turn Settings")]
		public float TurnForce;

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x19C")]
		public float TurnChangeRate;

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x1A0")]
		public float TurnReturnToRestRate;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x1A4")]
		public float TurnSpeedBoost;

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0x1A8")]
		public AnimationCurve TurnForceMap;

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x1B0")]
		[Header("Settings")]
		public float Gravity;

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x1B4")]
		public float BrakeForce;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x1B8")]
		public float ReverseTopSpeed_Kmh;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x1BC")]
		public LayerMask GroundDetectionMask;

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x1C0")]
		public Collider[] MainColliders;

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x1C8")]
		public float RotationClampForce;

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x1CC")]
		public bool SlowOnTerrain;

		// Token: 0x04001147 RID: 4423
		[Token(Token = "0x4001147")]
		[FieldOffset(Offset = "0x1CD")]
		[Header("Friction Settings")]
		public bool FrictionEnabled;

		// Token: 0x04001148 RID: 4424
		[Token(Token = "0x4001148")]
		[FieldOffset(Offset = "0x1D0")]
		public AnimationCurve LongitudinalFrictionCurve;

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		[FieldOffset(Offset = "0x1D8")]
		public float LongitudinalFrictionMultiplier;

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		[FieldOffset(Offset = "0x1DC")]
		public float LateralFrictionForceMultiplier;

		// Token: 0x0400114B RID: 4427
		[Token(Token = "0x400114B")]
		[FieldOffset(Offset = "0x1E0")]
		[Header("Jump Settings")]
		public float JumpForce;

		// Token: 0x0400114C RID: 4428
		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x1E4")]
		public float JumpDuration_Min;

		// Token: 0x0400114D RID: 4429
		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x1E8")]
		public float JumpDuration_Max;

		// Token: 0x0400114E RID: 4430
		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x1F0")]
		public AnimationCurve FrontAxleJumpCurve;

		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		[FieldOffset(Offset = "0x1F8")]
		public AnimationCurve RearAxleJumpCurve;

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x200")]
		public AnimationCurve JumpForwardForceCurve;

		// Token: 0x04001151 RID: 4433
		[Token(Token = "0x4001151")]
		[FieldOffset(Offset = "0x208")]
		public float JumpForwardBoost;

		// Token: 0x04001152 RID: 4434
		[Token(Token = "0x4001152")]
		[FieldOffset(Offset = "0x20C")]
		[Header("Hover Settings")]
		public float HoverForce;

		// Token: 0x04001153 RID: 4435
		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x210")]
		public float HoverRayLength;

		// Token: 0x04001154 RID: 4436
		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x214")]
		public float HoverHeight;

		// Token: 0x04001155 RID: 4437
		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x218")]
		public float Hover_P;

		// Token: 0x04001156 RID: 4438
		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x21C")]
		public float Hover_I;

		// Token: 0x04001157 RID: 4439
		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x220")]
		public float Hover_D;

		// Token: 0x04001158 RID: 4440
		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0x224")]
		[Tooltip("Top speed in m/s")]
		[Header("Pushing Setings")]
		public float TopSpeed_Kmh;

		// Token: 0x04001159 RID: 4441
		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0x228")]
		public float PushForceMultiplier;

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x230")]
		public AnimationCurve PushForceMultiplierMap;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x238")]
		public float PushForceDuration;

		// Token: 0x0400115C RID: 4444
		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0x23C")]
		public float PushDelay;

		// Token: 0x0400115D RID: 4445
		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0x240")]
		public AnimationCurve PushForceCurve;

		// Token: 0x0400115E RID: 4446
		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0x248")]
		[Header("Air Movement")]
		public bool AirMovementEnabled;

		// Token: 0x0400115F RID: 4447
		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0x24C")]
		public float AirMovementForce;

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x250")]
		public float AirMovementJumpReductionDuration;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x258")]
		public AnimationCurve AirMovementJumpReductionCurve;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x260")]
		[Header("Events")]
		public UnityEvent OnPushStart;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x268")]
		public UnityEvent<float> OnJump;

		// Token: 0x04001164 RID: 4452
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x270")]
		public UnityEvent OnLand;

		// Token: 0x04001165 RID: 4453
		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x278")]
		private float horizontalInput;

		// Token: 0x04001166 RID: 4454
		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x27C")]
		private bool jumpReleased;

		// Token: 0x04001167 RID: 4455
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x280")]
		private float timeSinceLastJump;

		// Token: 0x04001168 RID: 4456
		[Token(Token = "0x4001168")]
		[FieldOffset(Offset = "0x284")]
		private float timeGrounded;

		// Token: 0x04001169 RID: 4457
		[Token(Token = "0x4001169")]
		[FieldOffset(Offset = "0x288")]
		private float timeAirborne;

		// Token: 0x0400116A RID: 4458
		[Token(Token = "0x400116A")]
		[FieldOffset(Offset = "0x28C")]
		private float jumpHeldTime;

		// Token: 0x0400116B RID: 4459
		[Token(Token = "0x400116B")]
		[FieldOffset(Offset = "0x290")]
		private float frontAxleForce;

		// Token: 0x0400116C RID: 4460
		[Token(Token = "0x400116C")]
		[FieldOffset(Offset = "0x294")]
		private float rearAxleForce;

		// Token: 0x0400116D RID: 4461
		[Token(Token = "0x400116D")]
		[FieldOffset(Offset = "0x298")]
		private float jumpForwardForce;

		// Token: 0x0400116E RID: 4462
		[Token(Token = "0x400116E")]
		[FieldOffset(Offset = "0x2A0")]
		private List<PID> hoverPIDs;

		// Token: 0x0400116F RID: 4463
		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0x2A8")]
		private bool pushQueued;

		// Token: 0x04001170 RID: 4464
		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0x2A9")]
		private bool isPushing;

		// Token: 0x04001171 RID: 4465
		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0x2AC")]
		private float thisFramePushForce;

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x2B0")]
		private float timeSincePushStart;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x2B4")]
		private bool braking;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x2B8")]
		private SkateboardSettings _settings;

		// Token: 0x04001177 RID: 4471
		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0x2D0")]
		public SyncVar<float> syncVar___<JumpBuildAmount>k__BackingField;

		// Token: 0x04001178 RID: 4472
		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0x2D8")]
		private bool NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted;

		// Token: 0x04001179 RID: 4473
		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0x2D9")]
		private bool NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted;
	}
}
