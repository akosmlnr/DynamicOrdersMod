using System;
using System.Runtime.CompilerServices;
using FishNet.Component.Ownership;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.Core.Items.Framework;
using ScheduleOne.Equipping.Framework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2000966")]
	[RequireComponent(typeof(PredictedSpawn))]
	public class EquippedItemHandler : NetworkBehaviour, IEquippedItemHandler
	{
		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A05")]
		public IEquippableUser User
		{
			[Token(Token = "0x6004057")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A06")]
		public EquippableData EquippableData
		{
			[Token(Token = "0x6004058")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x000124F8 File Offset: 0x000106F8
		// (set) Token: 0x0600405A RID: 16474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A07")]
		public bool IsEquipped
		{
			[Token(Token = "0x6004059")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600405A")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600405B RID: 16475 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600405C RID: 16476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000013")]
		public event Action OnUnequipped
		{
			[Token(Token = "0x600405B")]
			[Address(RVA = "0x85B3B0", Offset = "0x85A5B0", VA = "0x18085B3B0", Slot = "25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600405C")]
			[Address(RVA = "0x85B460", Offset = "0x85A660", VA = "0x18085B460", Slot = "26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405D")]
		[Address(RVA = "0x85A660", Offset = "0x859860", VA = "0x18085A660", Slot = "27")]
		public virtual void Equipped(IEquippableUser user, EquippableData data)
		{
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405E")]
		[Address(RVA = "0x85A640", Offset = "0x859840", VA = "0x18085A640", Slot = "28")]
		public virtual void EquippedWithItem(IEquippableUser user, EquippableData data, BaseItemInstance itemInstance)
		{
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x85B200", Offset = "0x85A400", VA = "0x18085B200", Slot = "29")]
		public virtual void Unequipped()
		{
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x85AAB0", Offset = "0x859CB0", VA = "0x18085AAB0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004061")]
		[Address(RVA = "0x85AF50", Offset = "0x85A150", VA = "0x18085AF50")]
		private void SetupParent()
		{
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004062")]
		[Address(RVA = "0x85B100", Offset = "0x85A300", VA = "0x18085B100", Slot = "30")]
		protected virtual void SetupThirdPerson()
		{
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004063")]
		[Address(RVA = "0x85AD50", Offset = "0x859F50", VA = "0x18085AD50", Slot = "31")]
		protected virtual void SetupFirstPerson()
		{
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004064")]
		[Address(RVA = "0x85B340", Offset = "0x85A540", VA = "0x18085B340", Slot = "32")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004065")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "33")]
		protected virtual void UserUpdate()
		{
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004066")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public EquippedItemHandler()
		{
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004067")]
		[Address(RVA = "0x668390", Offset = "0x667590", VA = "0x180668390", Slot = "20")]
		private GameObject ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler.get_gameObject()
		{
			return null;
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004068")]
		[Address(RVA = "0x85A8A0", Offset = "0x859AA0", VA = "0x18085A8A0", Slot = "34")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004069")]
		[Address(RVA = "0x85A830", Offset = "0x859A30", VA = "0x18085A830", Slot = "35")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406A")]
		[Address(RVA = "0x85A600", Offset = "0x859800", VA = "0x18085A600", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600406C RID: 16492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A08")]
		public INetworkedEquippableUser SyncAccessor__user
		{
			[Token(Token = "0x600406B")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600406C")]
			[Address(RVA = "0x85B5D0", Offset = "0x85A7D0", VA = "0x18085B5D0")]
			set
			{
			}
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00012510 File Offset: 0x00010710
		[Token(Token = "0x600406D")]
		[Address(RVA = "0x85AB00", Offset = "0x859D00", VA = "0x18085AB00", Slot = "36")]
		public virtual bool ReadSyncVar___ScheduleOne.Equipping.EquippedItemHandler(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A09")]
		public EquippableData SyncAccessor__equippableData
		{
			[Token(Token = "0x600406E")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600406F")]
			[Address(RVA = "0x85B510", Offset = "0x85A710", VA = "0x18085B510")]
			set
			{
			}
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004070")]
		[Address(RVA = "0x85A600", Offset = "0x859800", VA = "0x18085A600", Slot = "37")]
		public virtual void Awake()
		{
		}

		// Token: 0x04002F03 RID: 12035
		[Token(Token = "0x4002F03")]
		[FieldOffset(Offset = "0x120")]
		[SyncVar]
		public INetworkedEquippableUser _user;

		// Token: 0x04002F04 RID: 12036
		[Token(Token = "0x4002F04")]
		[FieldOffset(Offset = "0x128")]
		[SyncVar]
		[HideInInspector]
		public EquippableData _equippableData;

		// Token: 0x04002F06 RID: 12038
		[Token(Token = "0x4002F06")]
		[FieldOffset(Offset = "0x138")]
		public SyncVar<INetworkedEquippableUser> syncVar____user;

		// Token: 0x04002F07 RID: 12039
		[Token(Token = "0x4002F07")]
		[FieldOffset(Offset = "0x140")]
		public SyncVar<EquippableData> syncVar____equippableData;

		// Token: 0x04002F08 RID: 12040
		[Token(Token = "0x4002F08")]
		[FieldOffset(Offset = "0x148")]
		private bool NetworkInitialize___EarlyScheduleOne.Equipping.EquippedItemHandlerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F09 RID: 12041
		[Token(Token = "0x4002F09")]
		[FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize__LateScheduleOne.Equipping.EquippedItemHandlerAssembly-CSharp.dll_Excuted;
	}
}
