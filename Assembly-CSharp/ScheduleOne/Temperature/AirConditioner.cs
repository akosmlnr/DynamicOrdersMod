using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Temperature
{
	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	public class AirConditioner : GridItem
	{
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D5")]
		public TemperatureEmitter TemperatureEmitter
		{
			[Token(Token = "0x60012A6")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012A7")]
			[Address(RVA = "0x876080", Offset = "0x875280", VA = "0x180876080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D6")]
		public TemperatureDisplay TemperatureDisplay
		{
			[Token(Token = "0x60012A8")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012A9")]
			[Address(RVA = "0x89E640", Offset = "0x89D840", VA = "0x18089E640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000088B0 File Offset: 0x00006AB0
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D7")]
		public AirConditioner.EMode CurrentMode
		{
			[Token(Token = "0x60012AA")]
			[Address(RVA = "0x59CEC0", Offset = "0x59C0C0", VA = "0x18059CEC0")]
			[CompilerGenerated]
			get
			{
				return AirConditioner.EMode.Off;
			}
			[Token(Token = "0x60012AB")]
			[Address(RVA = "0xB1A680", Offset = "0xB19880", VA = "0x180B1A680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0xB19480", Offset = "0xB18680", VA = "0x180B19480", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0xB19910", Offset = "0xB18B10", VA = "0x180B19910", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0xB19860", Offset = "0xB18A60", VA = "0x180B19860")]
		private void HeatmapVisibilityChanged(Property property, bool visible)
		{
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0xB194E0", Offset = "0xB186E0", VA = "0x180B194E0", Slot = "56")]
		protected override void Destroy()
		{
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0xB1A670", Offset = "0xB19870", VA = "0x180B1A670")]
		private void Update()
		{
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0xB1A380", Offset = "0xB19580", VA = "0x180B1A380")]
		private void UpdateLoopSound()
		{
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0xB1A200", Offset = "0xB19400", VA = "0x180B1A200")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetMode_Server(AirConditioner.EMode mode)
		{
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0xB1A010", Offset = "0xB19210", VA = "0x180B1A010")]
		public void SetMode(AirConditioner.EMode mode)
		{
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0xB19010", Offset = "0xB18210", VA = "0x180B19010")]
		private void ApplyMode()
		{
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B5")]
		[Address(RVA = "0xB19E80", Offset = "0xB19080", VA = "0x180B19E80")]
		private void OnModeChanged(AirConditioner.EMode previous, AirConditioner.EMode current, bool asServer)
		{
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B6")]
		[Address(RVA = "0xB1A340", Offset = "0xB19540", VA = "0x180B1A340")]
		[Button]
		public void SetOff()
		{
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0xB1A1E0", Offset = "0xB193E0", VA = "0x180B1A1E0")]
		[Button]
		public void SetCooling()
		{
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0xB1A1F0", Offset = "0xB193F0", VA = "0x180B1A1F0")]
		[Button]
		public void SetHeating()
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0xB19760", Offset = "0xB18960", VA = "0x180B19760", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x85DD20", Offset = "0x85CF20", VA = "0x18085DD20")]
		public AirConditioner()
		{
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BD")]
		[Address(RVA = "0xB19C60", Offset = "0xB18E60", VA = "0x180B19C60", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BE")]
		[Address(RVA = "0xB19C00", Offset = "0xB18E00", VA = "0x180B19C00", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0xB1A0B0", Offset = "0xB192B0", VA = "0x180B1A0B0")]
		private void RpcWriter___Server_SetMode_Server_3835190203(AirConditioner.EMode mode)
		{
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0xB1A010", Offset = "0xB19210", VA = "0x180B1A010")]
		public void RpcLogic___SetMode_Server_3835190203(AirConditioner.EMode mode)
		{
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0xB1A030", Offset = "0xB19230", VA = "0x180B1A030")]
		private void RpcReader___Server_SetMode_Server_3835190203(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x000088F8 File Offset: 0x00006AF8
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D8")]
		public AirConditioner.EMode SyncAccessor_<CurrentMode>k__BackingField
		{
			[Token(Token = "0x60012C3")]
			[Address(RVA = "0x59CEC0", Offset = "0x59C0C0", VA = "0x18059CEC0")]
			get
			{
				return AirConditioner.EMode.Off;
			}
			[Token(Token = "0x60012C4")]
			[Address(RVA = "0xB1A710", Offset = "0xB19910", VA = "0x180B1A710")]
			set
			{
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x60012C5")]
		[Address(RVA = "0xB19EF0", Offset = "0xB190F0", VA = "0x180B19EF0", Slot = "71")]
		public virtual bool ReadSyncVar___ScheduleOne.Temperature.AirConditioner(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C6")]
		[Address(RVA = "0xB19440", Offset = "0xB18640", VA = "0x180B19440", Slot = "72")]
		protected virtual void Awake_UserLogic_ScheduleOne.Temperature.AirConditioner_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		private const float CoolingTemperature = 0f;

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		private const float HeatingTemperature = 40f;

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private Light _coolingLight;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private Light _heatingLight;

		// Token: 0x0400110D RID: 4365
		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private AudioSourceController _beepSound;

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private AudioSourceController _loopSound;

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private ParticleSystem _heatParticles;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private ParticleSystem _coolParticles;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x258")]
		public SyncVar<AirConditioner.EMode> syncVar___<CurrentMode>k__BackingField;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x260")]
		private bool NetworkInitialize___EarlyScheduleOne.Temperature.AirConditionerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001114 RID: 4372
		[Token(Token = "0x4001114")]
		[FieldOffset(Offset = "0x261")]
		private bool NetworkInitialize__LateScheduleOne.Temperature.AirConditionerAssembly-CSharp.dll_Excuted;

		// Token: 0x02000316 RID: 790
		[Token(Token = "0x2000316")]
		public enum EMode
		{
			// Token: 0x04001116 RID: 4374
			[Token(Token = "0x4001116")]
			Off,
			// Token: 0x04001117 RID: 4375
			[Token(Token = "0x4001117")]
			Cooling,
			// Token: 0x04001118 RID: 4376
			[Token(Token = "0x4001118")]
			Heating
		}
	}
}
