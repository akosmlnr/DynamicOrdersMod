using System;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts.Cash;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000618 RID: 1560
	[Token(Token = "0x2000618")]
	public class CashPickup : NetworkedItemPickup
	{
		// Token: 0x06002689 RID: 9865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x6BA450", Offset = "0x6B9650", VA = "0x1806BA450")]
		private void Start()
		{
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x6B9EB0", Offset = "0x6B90B0", VA = "0x1806B9EB0", Slot = "20")]
		protected override void Hovered()
		{
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "21")]
		protected override bool CanPickup()
		{
			return default(bool);
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x6BA210", Offset = "0x6B9410", VA = "0x1806BA210", Slot = "22")]
		protected override void Pickup()
		{
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x6BA450", Offset = "0x6B9650", VA = "0x1806BA450")]
		private void ValueChanged(float oldValue, float newValue, bool asServer)
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x6BA460", Offset = "0x6B9660", VA = "0x1806BA460")]
		private void UpdateCashStackVisuals()
		{
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x6BA4F0", Offset = "0x6B96F0", VA = "0x1806BA4F0")]
		public CashPickup()
		{
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x6B9FE0", Offset = "0x6B91E0", VA = "0x1806B9FE0", Slot = "23")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x6B9F80", Offset = "0x6B9180", VA = "0x1806B9F80", Slot = "24")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x6B9F40", Offset = "0x6B9140", VA = "0x1806B9F40", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		// (set) Token: 0x06002694 RID: 9876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BA")]
		public float SyncAccessor_Value
		{
			[Token(Token = "0x6002693")]
			[Address(RVA = "0x511800", Offset = "0x510A00", VA = "0x180511800")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002694")]
			[Address(RVA = "0x6BA510", Offset = "0x6B9710", VA = "0x1806BA510")]
			set
			{
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0000C810 File Offset: 0x0000AA10
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x6BA310", Offset = "0x6B9510", VA = "0x1806BA310", Slot = "26")]
		public virtual bool ReadSyncVar___ScheduleOne.ItemFramework.CashPickup(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x6B9CE0", Offset = "0x6B8EE0", VA = "0x1806B9CE0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04001E38 RID: 7736
		[Token(Token = "0x4001E38")]
		[FieldOffset(Offset = "0x150")]
		[SyncVar(OnChange = "ValueChanged")]
		public float Value;

		// Token: 0x04001E39 RID: 7737
		[Token(Token = "0x4001E39")]
		[FieldOffset(Offset = "0x154")]
		public bool PlayCashPickupSound;

		// Token: 0x04001E3A RID: 7738
		[Token(Token = "0x4001E3A")]
		[FieldOffset(Offset = "0x158")]
		[Header("References")]
		public CashStackVisuals CashStackVisuals;

		// Token: 0x04001E3B RID: 7739
		[Token(Token = "0x4001E3B")]
		[FieldOffset(Offset = "0x160")]
		public SyncVar<float> syncVar___Value;

		// Token: 0x04001E3C RID: 7740
		[Token(Token = "0x4001E3C")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted;

		// Token: 0x04001E3D RID: 7741
		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted;
	}
}
