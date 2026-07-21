using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Combat;
using ScheduleOne.Core;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.Core.Items.Framework;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping.Framework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts.Health;
using ScheduleOne.Product;
using ScheduleOne.Property;
using ScheduleOne.Skating;
using ScheduleOne.Tools;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005D8 RID: 1496
	[Token(Token = "0x20005D8")]
	public class Player : NetworkBehaviour, ISaveable, ICombatTargetable, IDamageable, ISightable, INetworkedEquippableUser, IEquippableUser, IEquippablePlayerUser
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x1700060C")]
		public bool IsLocalPlayer
		{
			[Token(Token = "0x6002230")]
			[Address(RVA = "0x66B810", Offset = "0x66AA10", VA = "0x18066B810", Slot = "71")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700060D")]
		public IThirdPersonReferencesProvider ThirdPersonReferences
		{
			[Token(Token = "0x6002231")]
			[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0", Slot = "70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700060E")]
		public IFirstPersonReferencesProvider FirstPersonReferences
		{
			[Token(Token = "0x6002232")]
			[Address(RVA = "0x66B6C0", Offset = "0x66A8C0", VA = "0x18066B6C0", Slot = "72")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700060F")]
		public Transform CenterPointTransform
		{
			[Token(Token = "0x6002233")]
			[Address(RVA = "0x66B510", Offset = "0x66A710", VA = "0x18066B510", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x17000610")]
		public Vector3 LookAtPoint
		{
			[Token(Token = "0x6002234")]
			[Address(RVA = "0x66B8D0", Offset = "0x66AAD0", VA = "0x18066B8D0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x17000611")]
		public bool IsCurrentlyTargetable
		{
			[Token(Token = "0x6002235")]
			[Address(RVA = "0x66B760", Offset = "0x66A960", VA = "0x18066B760", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x17000612")]
		public float RangedHitChanceMultiplier
		{
			[Token(Token = "0x6002236")]
			[Address(RVA = "0x66BA70", Offset = "0x66AC70", VA = "0x18066BA70", Slot = "47")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x0000B958 File Offset: 0x00009B58
		[Token(Token = "0x17000613")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6002237")]
			[Address(RVA = "0x66BC00", Offset = "0x66AE00", VA = "0x18066BC00", Slot = "48")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002238")]
		[Address(RVA = "0x65C520", Offset = "0x65B720", VA = "0x18065C520", Slot = "49")]
		public void RecordLastKnownPosition(bool resetTimeSinceLastSeen)
		{
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x6002239")]
		[Address(RVA = "0x654330", Offset = "0x653530", VA = "0x180654330", Slot = "50")]
		public float GetSearchTime()
		{
			return 0f;
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000614")]
		public VisionEvent HighestProgressionEvent
		{
			[Token(Token = "0x600223A")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0", Slot = "58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600223B")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280", Slot = "59")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000615")]
		public EntityVisibility VisibilityComponent
		{
			[Token(Token = "0x600223C")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0", Slot = "60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x654C20", Offset = "0x653E20", VA = "0x180654C20", Slot = "61")]
		public bool IsCurrentlySightable()
		{
			return default(bool);
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000616")]
		public Vector3 EyePosition
		{
			[Token(Token = "0x600223E")]
			[Address(RVA = "0x66B6A0", Offset = "0x66A8A0", VA = "0x18066B6A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600223F")]
			[Address(RVA = "0x66BFC0", Offset = "0x66B1C0", VA = "0x18066BFC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000617")]
		public string PlayerName
		{
			[Token(Token = "0x6002240")]
			[Address(RVA = "0x66BA60", Offset = "0x66AC60", VA = "0x18066BA60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002241")]
			[Address(RVA = "0x66C170", Offset = "0x66B370", VA = "0x18066C170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000618")]
		public string PlayerCode
		{
			[Token(Token = "0x6002242")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002243")]
			[Address(RVA = "0x66C0D0", Offset = "0x66B2D0", VA = "0x18066C0D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000619")]
		public NetworkObject CurrentVehicle
		{
			[Token(Token = "0x6002244")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002245")]
			[Address(RVA = "0x66BE20", Offset = "0x66B020", VA = "0x18066BE20")]
			[ServerRpc(RunLocally = true)]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700061A")]
		public NetworkBehaviour NetworkBehaviour
		{
			[Token(Token = "0x6002246")]
			[Address(RVA = "0x66B930", Offset = "0x66AB30", VA = "0x18066B930", Slot = "62")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061B")]
		public bool ThirdPersonMeshesVisibleToLocalPlayer
		{
			[Token(Token = "0x6002247")]
			[Address(RVA = "0x66BBD0", Offset = "0x66ADD0", VA = "0x18066BBD0", Slot = "73")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002248")]
			[Address(RVA = "0x66C270", Offset = "0x66B470", VA = "0x18066C270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600224A RID: 8778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000E")]
		public event Action<bool> OnThirdPersonMeshesVisibilityChanged
		{
			[Token(Token = "0x6002249")]
			[Address(RVA = "0x66B410", Offset = "0x66A610", VA = "0x18066B410", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600224A")]
			[Address(RVA = "0x66BC80", Offset = "0x66AE80", VA = "0x18066BC80", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x1700061C")]
		public bool IsInVehicle
		{
			[Token(Token = "0x600224B")]
			[Address(RVA = "0x66B7B0", Offset = "0x66A9B0", VA = "0x18066B7B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061D")]
		public VehicleSeat CurrentVehicleSeat
		{
			[Token(Token = "0x600224C")]
			[Address(RVA = "0x66B670", Offset = "0x66A870", VA = "0x18066B670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600224D")]
			[Address(RVA = "0x66BE00", Offset = "0x66B000", VA = "0x18066BE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061E")]
		public LandVehicle LastDrivenVehicle
		{
			[Token(Token = "0x600224E")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600224F")]
			[Address(RVA = "0x66C040", Offset = "0x66B240", VA = "0x18066C040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061F")]
		public float TimeSinceVehicleExit
		{
			[Token(Token = "0x6002250")]
			[Address(RVA = "0x66BBF0", Offset = "0x66ADF0", VA = "0x18066BBF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002251")]
			[Address(RVA = "0x66C290", Offset = "0x66B490", VA = "0x18066C290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x0000BA00 File Offset: 0x00009C00
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000620")]
		public bool Crouched
		{
			[Token(Token = "0x6002252")]
			[Address(RVA = "0x66B550", Offset = "0x66A750", VA = "0x18066B550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x669820", Offset = "0x668A20", VA = "0x180669820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000621")]
		public NetworkObject CurrentBed
		{
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x66B570", Offset = "0x66A770", VA = "0x18066B570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x667600", Offset = "0x666800", VA = "0x180667600")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x0000BA18 File Offset: 0x00009C18
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000622")]
		public bool IsReadyToSleep
		{
			[Token(Token = "0x6002256")]
			[Address(RVA = "0x66B830", Offset = "0x66AA30", VA = "0x18066B830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002257")]
			[Address(RVA = "0x6600F0", Offset = "0x65F2F0", VA = "0x1806600F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000623")]
		public bool IsSkating
		{
			[Token(Token = "0x6002258")]
			[Address(RVA = "0x66B840", Offset = "0x66AA40", VA = "0x18066B840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002259")]
			[Address(RVA = "0x667960", Offset = "0x666B60", VA = "0x180667960")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000624")]
		public Skateboard ActiveSkateboard
		{
			[Token(Token = "0x600225A")]
			[Address(RVA = "0x66B4D0", Offset = "0x66A6D0", VA = "0x18066B4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600225B")]
			[Address(RVA = "0x66BD40", Offset = "0x66AF40", VA = "0x18066BD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x0000BA48 File Offset: 0x00009C48
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000625")]
		public bool IsSleeping
		{
			[Token(Token = "0x600225C")]
			[Address(RVA = "0x66B850", Offset = "0x66AA50", VA = "0x18066B850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600225D")]
			[Address(RVA = "0x66C010", Offset = "0x66B210", VA = "0x18066C010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x0000BA60 File Offset: 0x00009C60
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000626")]
		public bool IsRagdolled
		{
			[Token(Token = "0x600225E")]
			[Address(RVA = "0x66B820", Offset = "0x66AA20", VA = "0x18066B820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600225F")]
			[Address(RVA = "0x66C000", Offset = "0x66B200", VA = "0x18066C000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x0000BA78 File Offset: 0x00009C78
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000627")]
		public bool IsArrested
		{
			[Token(Token = "0x6002260")]
			[Address(RVA = "0x66B750", Offset = "0x66A950", VA = "0x18066B750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002261")]
			[Address(RVA = "0x66BFF0", Offset = "0x66B1F0", VA = "0x18066BFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x0000BA90 File Offset: 0x00009C90
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000628")]
		public bool IsTased
		{
			[Token(Token = "0x6002262")]
			[Address(RVA = "0x66B860", Offset = "0x66AA60", VA = "0x18066B860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002263")]
			[Address(RVA = "0x66C020", Offset = "0x66B220", VA = "0x18066C020")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000629")]
		public bool IsUnconscious
		{
			[Token(Token = "0x6002264")]
			[Address(RVA = "0x66B870", Offset = "0x66AA70", VA = "0x18066B870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002265")]
			[Address(RVA = "0x66C030", Offset = "0x66B230", VA = "0x18066C030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062A")]
		public float Scale
		{
			[Token(Token = "0x6002266")]
			[Address(RVA = "0x66BB70", Offset = "0x66AD70", VA = "0x18066BB70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002267")]
			[Address(RVA = "0x66C210", Offset = "0x66B410", VA = "0x18066C210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062B")]
		public Property CurrentProperty
		{
			[Token(Token = "0x6002268")]
			[Address(RVA = "0x66B650", Offset = "0x66A850", VA = "0x18066B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002269")]
			[Address(RVA = "0x66BDD0", Offset = "0x66AFD0", VA = "0x18066BDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062C")]
		public Property LastVisitedProperty
		{
			[Token(Token = "0x600226A")]
			[Address(RVA = "0x66B890", Offset = "0x66AA90", VA = "0x18066B890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600226B")]
			[Address(RVA = "0x66C060", Offset = "0x66B260", VA = "0x18066C060")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700062D")]
		public Business CurrentBusiness
		{
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x66B580", Offset = "0x66A780", VA = "0x18066B580")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062E")]
		public EMapRegion CurrentRegion
		{
			[Token(Token = "0x600226D")]
			[Address(RVA = "0x66B660", Offset = "0x66A860", VA = "0x18066B660")]
			[CompilerGenerated]
			get
			{
				return EMapRegion.Northtown;
			}
			[Token(Token = "0x600226E")]
			[Address(RVA = "0x66BDF0", Offset = "0x66AFF0", VA = "0x18066BDF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x1700062F")]
		public Vector3 PlayerBasePosition
		{
			[Token(Token = "0x600226F")]
			[Address(RVA = "0x66B950", Offset = "0x66AB50", VA = "0x18066B950")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x0000BB08 File Offset: 0x00009D08
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000630")]
		public Vector3 CameraPosition
		{
			[Token(Token = "0x6002270")]
			[Address(RVA = "0x66B4E0", Offset = "0x66A6E0", VA = "0x18066B4E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6002271")]
			[Address(RVA = "0x66BD60", Offset = "0x66AF60", VA = "0x18066BD60")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x0000BB20 File Offset: 0x00009D20
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000631")]
		public Quaternion CameraRotation
		{
			[Token(Token = "0x6002272")]
			[Address(RVA = "0x66B500", Offset = "0x66A700", VA = "0x18066B500")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6002273")]
			[Address(RVA = "0x667440", Offset = "0x666640", VA = "0x180667440")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x0000BB38 File Offset: 0x00009D38
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000632")]
		public int EquippedItemSlotIndex
		{
			[Token(Token = "0x6002274")]
			[Address(RVA = "0x66B690", Offset = "0x66A890", VA = "0x18066B690")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002275")]
			[Address(RVA = "0x65FB10", Offset = "0x65ED10", VA = "0x18065FB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000633")]
		public BasicAvatarSettings CurrentAvatarSettings
		{
			[Token(Token = "0x6002276")]
			[Address(RVA = "0x66B560", Offset = "0x66A760", VA = "0x18066B560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002277")]
			[Address(RVA = "0x66BDB0", Offset = "0x66AFB0", VA = "0x18066BDB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000634")]
		public ProductItemInstance ConsumedProduct
		{
			[Token(Token = "0x6002278")]
			[Address(RVA = "0x66B540", Offset = "0x66A740", VA = "0x18066B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x66BD90", Offset = "0x66AF90", VA = "0x18066BD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x0000BB50 File Offset: 0x00009D50
		// (set) Token: 0x0600227B RID: 8827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000635")]
		public int TimeSinceProductConsumed
		{
			[Token(Token = "0x600227A")]
			[Address(RVA = "0x66BBE0", Offset = "0x66ADE0", VA = "0x18066BBE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600227B")]
			[Address(RVA = "0x66C280", Offset = "0x66B480", VA = "0x18066C280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227C")]
		[Address(RVA = "0x655A90", Offset = "0x654C90", VA = "0x180655A90")]
		[Button]
		public void LoadDebugAvatarSettings()
		{
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000636")]
		public string SaveFolderName
		{
			[Token(Token = "0x600227D")]
			[Address(RVA = "0x66BAF0", Offset = "0x66ACF0", VA = "0x18066BAF0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000637")]
		public string SaveFileName
		{
			[Token(Token = "0x600227E")]
			[Address(RVA = "0x66BAC0", Offset = "0x66ACC0", VA = "0x18066BAC0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000638")]
		public Loader Loader
		{
			[Token(Token = "0x600227F")]
			[Address(RVA = "0x66B8A0", Offset = "0x66AAA0", VA = "0x18066B8A0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x17000639")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6002280")]
			[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063A")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6002281")]
			[Address(RVA = "0x66B8B0", Offset = "0x66AAB0", VA = "0x18066B8B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002282")]
			[Address(RVA = "0x66C080", Offset = "0x66B280", VA = "0x18066C080", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063B")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6002283")]
			[Address(RVA = "0x66B8C0", Offset = "0x66AAC0", VA = "0x18066B8C0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002284")]
			[Address(RVA = "0x66C0A0", Offset = "0x66B2A0", VA = "0x18066C0A0", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x0000BB80 File Offset: 0x00009D80
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063C")]
		public bool HasChanged
		{
			[Token(Token = "0x6002285")]
			[Address(RVA = "0x66B740", Offset = "0x66A940", VA = "0x18066B740", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002286")]
			[Address(RVA = "0x66BFE0", Offset = "0x66B1E0", VA = "0x18066BFE0", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0000BB98 File Offset: 0x00009D98
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063D")]
		public bool avatarVisibleToLocalPlayer
		{
			[Token(Token = "0x6002287")]
			[Address(RVA = "0x66BC50", Offset = "0x66AE50", VA = "0x18066BC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002288")]
			[Address(RVA = "0x66C2A0", Offset = "0x66B4A0", VA = "0x18066C2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063E")]
		public bool playerDataRetrieveReturned
		{
			[Token(Token = "0x6002289")]
			[Address(RVA = "0x66BC60", Offset = "0x66AE60", VA = "0x18066BC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600228A")]
			[Address(RVA = "0x66C2B0", Offset = "0x66B4B0", VA = "0x18066C2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		// (set) Token: 0x0600228C RID: 8844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063F")]
		public bool playerSaveRequestReturned
		{
			[Token(Token = "0x600228B")]
			[Address(RVA = "0x66BC70", Offset = "0x66AE70", VA = "0x18066BC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600228C")]
			[Address(RVA = "0x66C2C0", Offset = "0x66B4C0", VA = "0x18066C2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000640")]
		public bool Paranoid
		{
			[Token(Token = "0x600228D")]
			[Address(RVA = "0x66B940", Offset = "0x66AB40", VA = "0x18066B940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x66C0C0", Offset = "0x66B2C0", VA = "0x18066C0C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		// (set) Token: 0x06002290 RID: 8848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000641")]
		public bool Sneaky
		{
			[Token(Token = "0x600228F")]
			[Address(RVA = "0x66BBB0", Offset = "0x66ADB0", VA = "0x18066BBB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002290")]
			[Address(RVA = "0x66C250", Offset = "0x66B450", VA = "0x18066C250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x0000BC10 File Offset: 0x00009E10
		// (set) Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000642")]
		public bool Disoriented
		{
			[Token(Token = "0x6002291")]
			[Address(RVA = "0x66B680", Offset = "0x66A880", VA = "0x18066B680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002292")]
			[Address(RVA = "0x66BFB0", Offset = "0x66B1B0", VA = "0x18066BFB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x0000BC28 File Offset: 0x00009E28
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000643")]
		public bool Seizure
		{
			[Token(Token = "0x6002293")]
			[Address(RVA = "0x66BB90", Offset = "0x66AD90", VA = "0x18066BB90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002294")]
			[Address(RVA = "0x66C230", Offset = "0x66B430", VA = "0x18066C230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x0000BC40 File Offset: 0x00009E40
		// (set) Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000644")]
		public bool Slippery
		{
			[Token(Token = "0x6002295")]
			[Address(RVA = "0x66BBA0", Offset = "0x66ADA0", VA = "0x18066BBA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002296")]
			[Address(RVA = "0x66C240", Offset = "0x66B440", VA = "0x18066C240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x0000BC58 File Offset: 0x00009E58
		// (set) Token: 0x06002298 RID: 8856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000645")]
		public bool Schizophrenic
		{
			[Token(Token = "0x6002297")]
			[Address(RVA = "0x66BB80", Offset = "0x66AD80", VA = "0x18066BB80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002298")]
			[Address(RVA = "0x66C220", Offset = "0x66B420", VA = "0x18066C220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x0000BC70 File Offset: 0x00009E70
		// (set) Token: 0x0600229A RID: 8858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000646")]
		public bool StruckByLightning
		{
			[Token(Token = "0x6002299")]
			[Address(RVA = "0x66BBC0", Offset = "0x66ADC0", VA = "0x18066BBC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600229A")]
			[Address(RVA = "0x66C260", Offset = "0x66B460", VA = "0x18066C260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600229B")]
		[Address(RVA = "0x653E30", Offset = "0x653030", VA = "0x180653E30")]
		public static Player GetPlayer(NetworkConnection conn)
		{
			return null;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600229C")]
		[Address(RVA = "0x653F80", Offset = "0x653180", VA = "0x180653F80")]
		public static Player GetRandomPlayer(bool excludeArrestedOrDead = true, bool excludeSleeping = true)
		{
			return null;
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600229D")]
		[Address(RVA = "0x653D20", Offset = "0x652F20", VA = "0x180653D20")]
		public static Player GetPlayer(string playerCode)
		{
			return null;
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600229E")]
		[Address(RVA = "0x653B00", Offset = "0x652D00", VA = "0x180653B00")]
		public static Player GetPlayerByName(string playerName)
		{
			return null;
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600229F")]
		[Address(RVA = "0x651380", Offset = "0x650580", VA = "0x180651380", Slot = "77")]
		public virtual void Awake()
		{
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A0")]
		[Address(RVA = "0x654B90", Offset = "0x653D90", VA = "0x180654B90", Slot = "78")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A1")]
		[Address(RVA = "0x658700", Offset = "0x657900", VA = "0x180658700", Slot = "79")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A2")]
		[Address(RVA = "0x6594D0", Offset = "0x6586D0", VA = "0x1806594D0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A3")]
		[Address(RVA = "0x65A390", Offset = "0x659590", VA = "0x18065A390")]
		private void PlayerLoaded()
		{
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A4")]
		[Address(RVA = "0x659270", Offset = "0x658470", VA = "0x180659270", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A5")]
		[Address(RVA = "0x65C800", Offset = "0x65BA00", VA = "0x18065C800")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void RequestSavePlayer()
		{
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A6")]
		[Address(RVA = "0x65CD50", Offset = "0x65BF50", VA = "0x18065CD50")]
		[ObserversRpc]
		[TargetRpc]
		private void ReturnSaveRequest(NetworkConnection conn, bool successful)
		{
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A7")]
		[Address(RVA = "0x654A70", Offset = "0x653C70", VA = "0x180654A70")]
		[ObserversRpc(RunLocally = true)]
		public void HostExitedGame()
		{
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A8")]
		[Address(RVA = "0x651430", Offset = "0x650630", VA = "0x180651430")]
		private void ClientConnectionStateChanged(ClientConnectionStateArgs args)
		{
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A9")]
		[Address(RVA = "0x6691C0", Offset = "0x6683C0", VA = "0x1806691C0")]
		[ServerRpc(RunLocally = true)]
		public void SendPlayerNameData(string playerName, ulong id)
		{
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AA")]
		[Address(RVA = "0x65C6D0", Offset = "0x65B8D0", VA = "0x18065C6D0")]
		[ServerRpc(RequireOwnership = false)]
		public void RequestPlayerData(string playerCode)
		{
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AB")]
		[Address(RVA = "0x65BCC0", Offset = "0x65AEC0", VA = "0x18065BCC0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ReceivePlayerData(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AC")]
		[Address(RVA = "0x669990", Offset = "0x668B90", VA = "0x180669990")]
		public void SetGravityMultiplier(float multiplier)
		{
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x65BFF0", Offset = "0x65B1F0", VA = "0x18065BFF0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void ReceivePlayerNameData(NetworkConnection conn, string playerName, string id)
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x669860", Offset = "0x668A60", VA = "0x180669860")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetFlashlightOn_Server(bool on)
		{
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x65FB90", Offset = "0x65ED90", VA = "0x18065FB90")]
		[ObserversRpc(RunLocally = true)]
		private void SetFlashlightOn_Client(bool on)
		{
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x659E90", Offset = "0x659090", VA = "0x180659E90", Slot = "12")]
		public override void OnStopClient()
		{
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x659DE0", Offset = "0x658FE0", VA = "0x180659DE0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x66A790", Offset = "0x669990", VA = "0x18066A790", Slot = "80")]
		protected virtual void Update()
		{
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B3")]
		[Address(RVA = "0x659F20", Offset = "0x659120", VA = "0x180659F20", Slot = "81")]
		protected virtual void OnUncappedMinutePass()
		{
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x655070", Offset = "0x654270", VA = "0x180655070", Slot = "82")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B5")]
		[Address(RVA = "0x65B030", Offset = "0x65A230", VA = "0x18065B030")]
		private void RecalculateCurrentProperty()
		{
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x65B290", Offset = "0x65A490", VA = "0x18065B290")]
		private void RecalculateCurrentRegion()
		{
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x653100", Offset = "0x652300", VA = "0x180653100")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x64FED0", Offset = "0x64F0D0", VA = "0x18064FED0")]
		private void ApplyMovementVisuals()
		{
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x66A310", Offset = "0x669510", VA = "0x18066A310")]
		public void SetVisible(bool vis, bool network = false)
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0x65A270", Offset = "0x659470", VA = "0x18065A270")]
		[ObserversRpc]
		public void PlayJumpAnimation()
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x60022BB")]
		[Address(RVA = "0x653890", Offset = "0x652A90", VA = "0x180653890")]
		public bool GetIsGrounded()
		{
			return default(bool);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BC")]
		[Address(RVA = "0x6688C0", Offset = "0x667AC0", VA = "0x1806688C0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendCrouched(bool crouched)
		{
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BD")]
		[Address(RVA = "0x669820", Offset = "0x668A20", VA = "0x180669820")]
		public void SetCrouchedLocal(bool crouched)
		{
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x65B590", Offset = "0x65A790", VA = "0x18065B590")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveCrouched(NetworkConnection conn, bool crouched)
		{
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x668730", Offset = "0x667930", VA = "0x180668730")]
		[ServerRpc(RunLocally = true)]
		public void SendAvatarSettings(AvatarSettings settings)
		{
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x65F060", Offset = "0x65E260", VA = "0x18065F060")]
		[ObserversRpc(BufferLast = true, RunLocally = true)]
		public void SetAvatarSettings(AvatarSettings settings)
		{
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C1")]
		[Address(RVA = "0x664800", Offset = "0x663A00", VA = "0x180664800")]
		[ObserversRpc]
		private void SetVisible_Networked(bool vis)
		{
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x652580", Offset = "0x651780", VA = "0x180652580")]
		public void EnterVehicle(LandVehicle vehicle, VehicleSeat seat)
		{
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x652CC0", Offset = "0x651EC0", VA = "0x180652CC0")]
		public void ExitVehicle(Transform exitPoint)
		{
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C4")]
		[Address(RVA = "0x65A850", Offset = "0x659A50", VA = "0x18065A850")]
		private void PreDestroyClientObjects(NetworkConnection conn)
		{
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C5")]
		[Address(RVA = "0x651B90", Offset = "0x650D90", VA = "0x180651B90")]
		private void CurrentVehicleChanged(NetworkObject oldVeh, NetworkObject newVeh, bool asServer)
		{
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x6505B0", Offset = "0x64F7B0", VA = "0x1806505B0")]
		public static bool AreAllPlayersReadyToSleep()
		{
			return default(bool);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C7")]
		[Address(RVA = "0x66A490", Offset = "0x669690", VA = "0x18066A490")]
		private void SleepStart()
		{
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C8")]
		[Address(RVA = "0x669E00", Offset = "0x669000", VA = "0x180669E00")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetReadyToSleep(bool ready)
		{
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x66A480", Offset = "0x669680", VA = "0x18066A480")]
		private void SleepEnd()
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x64FB20", Offset = "0x64ED20", VA = "0x18064FB20")]
		public static void Activate()
		{
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x652040", Offset = "0x651240", VA = "0x180652040")]
		public static void Deactivate(bool freeMouse)
		{
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x6529D0", Offset = "0x651BD0", VA = "0x1806529D0")]
		public void ExitAll()
		{
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x66A240", Offset = "0x669440", VA = "0x18066A240")]
		public void SetVisibleToLocalPlayer(bool vis)
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x666800", Offset = "0x665A00", VA = "0x180666800")]
		[ServerRpc]
		public void SendPunch()
		{
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x65AA70", Offset = "0x659C70", VA = "0x18065AA70")]
		[ObserversRpc]
		private void Punch()
		{
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x656670", Offset = "0x655870", VA = "0x180656670")]
		[ServerRpc(RunLocally = true)]
		private void MarkIntroCompleted(BasicAvatarSettings appearance)
		{
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x654C60", Offset = "0x653E60", VA = "0x180654C60")]
		public bool IsPointVisibleToPlayer(Vector3 point, float maxDistance_Visible = 30f, float minDistance_Invisible = 5f)
		{
			return default(bool);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x653460", Offset = "0x652660", VA = "0x180653460")]
		public static Player GetClosestPlayer(Vector3 point, out float distance, [Optional] List<Player> exclude)
		{
			return null;
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x669780", Offset = "0x668980", VA = "0x180669780")]
		public void SetCapsuleColliderHeight(float normalizedHeight)
		{
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x669F30", Offset = "0x669130", VA = "0x180669F30")]
		public void SetScale(float scale)
		{
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x669F50", Offset = "0x669150", VA = "0x180669F50")]
		public void SetScale(float scale, float lerpTime)
		{
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x650490", Offset = "0x64F690", VA = "0x180650490", Slot = "83")]
		protected virtual void ApplyScale()
		{
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x654210", Offset = "0x653410", VA = "0x180654210", Slot = "84")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x653C10", Offset = "0x652E10", VA = "0x180653C10")]
		public PlayerData GetPlayerData()
		{
			return null;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x66AA50", Offset = "0x669C50", VA = "0x18066AA50", Slot = "85")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022DA")]
		[Address(RVA = "0x653800", Offset = "0x652A00", VA = "0x180653800")]
		public string GetInventoryString()
		{
			return null;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x6533B0", Offset = "0x6525B0", VA = "0x1806533B0")]
		public string GetAppearanceString()
		{
			return null;
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x653710", Offset = "0x652910", VA = "0x180653710")]
		public string GetClothingString()
		{
			return null;
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x654460", Offset = "0x653660", VA = "0x180654460")]
		public string GetVariablesString()
		{
			return null;
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x655F30", Offset = "0x655130", VA = "0x180655F30", Slot = "86")]
		public virtual void Load(PlayerData data, string containerPath)
		{
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x656530", Offset = "0x655730", VA = "0x180656530", Slot = "87")]
		public virtual void Load(PlayerData data)
		{
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x655AB0", Offset = "0x654CB0", VA = "0x180655AB0", Slot = "88")]
		public virtual void LoadInventory(string contentsString)
		{
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x6558E0", Offset = "0x654AE0", VA = "0x1806558E0", Slot = "89")]
		public virtual void LoadAppearance(string appearanceString)
		{
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x6559B0", Offset = "0x654BB0", VA = "0x1806559B0", Slot = "90")]
		public virtual void LoadClothing(string contentsString)
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x669C70", Offset = "0x668E70", VA = "0x180669C70")]
		public void SetRagdolled(bool ragdolled)
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x668BF0", Offset = "0x667DF0", VA = "0x180668BF0", Slot = "91")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void SendImpact(Impact impact)
		{
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x65BB80", Offset = "0x65AD80", VA = "0x18065BB80", Slot = "92")]
		[ObserversRpc(RunLocally = true)]
		public virtual void ReceiveImpact(Impact impact)
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x65AA20", Offset = "0x659C20", VA = "0x18065AA20", Slot = "93")]
		public virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x6546D0", Offset = "0x6538D0", VA = "0x1806546D0")]
		private void HitByLightning()
		{
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x65CBB0", Offset = "0x65BDB0", VA = "0x18065CBB0")]
		private void ResetHitByLightning()
		{
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x658B70", Offset = "0x657D70", VA = "0x180658B70", Slot = "94")]
		public virtual void OnDied()
		{
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x659100", Offset = "0x658300", VA = "0x180659100", Slot = "95")]
		public virtual void OnRevived()
		{
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EB")]
		[Address(RVA = "0x650880", Offset = "0x64FA80", VA = "0x180650880")]
		[ServerRpc(RunLocally = true)]
		public void Arrest_Server()
		{
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EC")]
		[Address(RVA = "0x650760", Offset = "0x64F960", VA = "0x180650760")]
		[ObserversRpc(RunLocally = true)]
		private void Arrest_Client()
		{
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x653230", Offset = "0x652430", VA = "0x180653230")]
		[ServerRpc(RunLocally = true)]
		public void Free_Server()
		{
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x653110", Offset = "0x652310", VA = "0x180653110")]
		[ObserversRpc(RunLocally = true)]
		private void Free_Client()
		{
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x669040", Offset = "0x668240", VA = "0x180669040")]
		[ServerRpc(RunLocally = true)]
		public void SendPassOut()
		{
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x65A150", Offset = "0x659350", VA = "0x18065A150")]
		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void PassOut()
		{
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x668EC0", Offset = "0x6680C0", VA = "0x180668EC0")]
		[ServerRpc(RunLocally = true)]
		public void SendPassOutRecovery()
		{
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x65A030", Offset = "0x659230", VA = "0x18065A030")]
		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void PassOutRecovery()
		{
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0x668AC0", Offset = "0x667CC0", VA = "0x180668AC0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendEquippable_Networked(string assetPath)
		{
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F4")]
		[Address(RVA = "0x65F1E0", Offset = "0x65E3E0", VA = "0x18065F1E0")]
		[ObserversRpc(RunLocally = true)]
		private void SetEquippable_Networked(string assetPath)
		{
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x668A80", Offset = "0x667C80", VA = "0x180668A80")]
		[ServerRpc(RunLocally = true)]
		public void SendEquippableMessage_Networked(string message, int receipt)
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x65BA10", Offset = "0x65AC10", VA = "0x18065BA10")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveEquippableMessage_Networked(string message, int receipt)
		{
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F7")]
		[Address(RVA = "0x6689F0", Offset = "0x667BF0", VA = "0x1806689F0")]
		[ServerRpc(RunLocally = true)]
		public void SendEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x65B810", Offset = "0x65AA10", VA = "0x18065B810")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x6529A0", Offset = "0x651BA0", VA = "0x1806529A0", Slot = "66")]
		public IEquippedItemHandler Equip(EquippableData equippable)
		{
			return null;
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x652970", Offset = "0x651B70", VA = "0x180652970", Slot = "67")]
		public IEquippedItemHandler Equip(BaseItemInstance item)
		{
			return null;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x652940", Offset = "0x651B40", VA = "0x180652940", Slot = "63")]
		public IEquippedItemHandler EquipLocal(EquippableData equippable)
		{
			return null;
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x652910", Offset = "0x651B10", VA = "0x180652910", Slot = "64")]
		public IEquippedItemHandler EquipLocal(BaseItemInstance item)
		{
			return null;
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x66A760", Offset = "0x669960", VA = "0x18066A760", Slot = "68")]
		public void Unequip(IEquippedItemHandler equippedItem)
		{
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x66A730", Offset = "0x669930", VA = "0x18066A730", Slot = "69")]
		public void UnequipAll()
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x66A0E0", Offset = "0x6692E0", VA = "0x18066A0E0", Slot = "76")]
		public void SetThirdPersonMeshesVisibility(bool visible)
		{
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002300")]
		[Address(RVA = "0x6683F0", Offset = "0x6675F0", VA = "0x1806683F0")]
		[ServerRpc(RunLocally = true)]
		public void SendAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002301")]
		[Address(RVA = "0x669380", Offset = "0x668580", VA = "0x180669380")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002302")]
		[Address(RVA = "0x6695F0", Offset = "0x6687F0", VA = "0x1806695F0")]
		public void SetAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002303")]
		[Address(RVA = "0x65C910", Offset = "0x65BB10", VA = "0x18065C910")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002304")]
		[Address(RVA = "0x65CB80", Offset = "0x65BD80", VA = "0x18065CB80")]
		public void ResetAnimationTrigger(string trigger)
		{
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002305")]
		[Address(RVA = "0x6683A0", Offset = "0x6675A0", VA = "0x1806683A0")]
		[ServerRpc(RunLocally = true)]
		public void SendAnimationBool(string name, bool val)
		{
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002306")]
		[Address(RVA = "0x65EED0", Offset = "0x65E0D0", VA = "0x18065EED0")]
		[ObserversRpc(RunLocally = true)]
		public void SetAnimationBool(string name, bool val)
		{
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x664AB0", Offset = "0x663CB0", VA = "0x180664AB0")]
		[ObserversRpc]
		public void Taze()
		{
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002308")]
		[Address(RVA = "0x669BF0", Offset = "0x668DF0", VA = "0x180669BF0")]
		[ServerRpc(RunLocally = true)]
		public void SetInventoryItem(int index, ItemInstance item)
		{
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002309")]
		[Address(RVA = "0x669830", Offset = "0x668A30", VA = "0x180669830")]
		[ServerRpc(RunLocally = true)]
		public void SetEquippedSlotIndex(int index)
		{
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600230A")]
		[Address(RVA = "0x6537B0", Offset = "0x6529B0", VA = "0x1806537B0")]
		public ItemInstance GetEquippedItem()
		{
			return null;
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600230B")]
		[Address(RVA = "0x65C550", Offset = "0x65B750", VA = "0x18065C550")]
		[ObserversRpc]
		public void RemoveEquippedItemFromInventory(string id, int amount)
		{
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600230C")]
		[Address(RVA = "0x653A40", Offset = "0x652C40", VA = "0x180653A40")]
		private void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x668590", Offset = "0x667790", VA = "0x180668590")]
		[ServerRpc(RunLocally = true)]
		public void SendAppearance(BasicAvatarSettings settings)
		{
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600230E")]
		[Address(RVA = "0x669620", Offset = "0x668820", VA = "0x180669620")]
		[ObserversRpc(RunLocally = true)]
		public void SetAppearance(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600230F")]
		[Address(RVA = "0x656800", Offset = "0x655A00", VA = "0x180656800")]
		public void MountSkateboard(Skateboard board)
		{
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002310")]
		[Address(RVA = "0x668D30", Offset = "0x667F30", VA = "0x180668D30")]
		[ServerRpc(RunLocally = true)]
		private void SendMountedSkateboard(NetworkObject skateboardObj)
		{
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002311")]
		[Address(RVA = "0x65F350", Offset = "0x65E550", VA = "0x18065F350")]
		[ObserversRpc(RunLocally = true)]
		private void SetMountedSkateboard(NetworkObject skateboardObj)
		{
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002312")]
		[Address(RVA = "0x652230", Offset = "0x651430", VA = "0x180652230")]
		public void DismountSkateboard()
		{
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002313")]
		[Address(RVA = "0x6516A0", Offset = "0x6508A0", VA = "0x1806516A0")]
		public void ConsumeProduct(ProductItemInstance product)
		{
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002314")]
		[Address(RVA = "0x665880", Offset = "0x664A80", VA = "0x180665880")]
		[ServerRpc(RequireOwnership = false)]
		private void SendConsumeProduct(ProductItemInstance product)
		{
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002315")]
		[Address(RVA = "0x65B450", Offset = "0x65A650", VA = "0x18065B450")]
		[ObserversRpc]
		private void ReceiveConsumeProduct(ProductItemInstance product)
		{
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002316")]
		[Address(RVA = "0x651600", Offset = "0x650800", VA = "0x180651600")]
		private void ConsumeProductInternal(ProductItemInstance product)
		{
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002317")]
		[Address(RVA = "0x6513D0", Offset = "0x6505D0", VA = "0x1806513D0")]
		public void ClearProduct()
		{
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002318")]
		[Address(RVA = "0x651840", Offset = "0x650A40", VA = "0x180651840")]
		private void CreatePlayerVariables()
		{
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002319")]
		[Address(RVA = "0x654360", Offset = "0x653560", VA = "0x180654360")]
		public BaseVariable GetVariable(string variableName)
		{
			return null;
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600231A")]
		public T GetValue<T>(string variableName)
		{
			return null;
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x66A110", Offset = "0x669310", VA = "0x18066A110")]
		public void SetVariableValue(string variableName, string value, bool network = true)
		{
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231C")]
		[Address(RVA = "0x64FD10", Offset = "0x64EF10", VA = "0x18064FD10")]
		public void AddVariable(BaseVariable variable)
		{
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x669200", Offset = "0x668400", VA = "0x180669200")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(string variableName, string value, bool sendToOwner)
		{
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231E")]
		[Address(RVA = "0x65C290", Offset = "0x65B490", VA = "0x18065C290")]
		[TargetRpc]
		private void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x65C3F0", Offset = "0x65B5F0", VA = "0x18065C3F0")]
		private void ReceiveValue(string variableName, string value)
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x655D90", Offset = "0x654F90", VA = "0x180655D90")]
		public void LoadVariable(VariableData data)
		{
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002321")]
		[Address(RVA = "0x666AE0", Offset = "0x665CE0", VA = "0x180666AE0")]
		[ServerRpc(RequireOwnership = false)]
		public void SendWorldSpaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x65F7C0", Offset = "0x65E9C0", VA = "0x18065F7C0")]
		[ObserversRpc(RunLocally = true)]
		private void ShowWorldSpaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x66ADA0", Offset = "0x669FA0", VA = "0x18066ADA0")]
		public Player()
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "42")]
		private NetworkObject ScheduleOne.Combat.ICombatTargetable.get_NetworkObject()
		{
			return null;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x668390", Offset = "0x667590", VA = "0x180668390", Slot = "54")]
		private GameObject ScheduleOne.Combat.IDamageable.get_gameObject()
		{
			return null;
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430", Slot = "57")]
		private NetworkObject ScheduleOne.Vision.ISightable.get_NetworkObject()
		{
			return null;
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600232A")]
		[Address(RVA = "0x66A500", Offset = "0x669700", VA = "0x18066A500")]
		[CompilerGenerated]
		private IEnumerator <HitByLightning>g__Reset|350_0()
		{
			return null;
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600232B")]
		[Address(RVA = "0x66A6C0", Offset = "0x6698C0", VA = "0x18066A6C0")]
		[CompilerGenerated]
		private IEnumerator <Taze>g__Tase|382_0()
		{
			return null;
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232C")]
		[Address(RVA = "0x657010", Offset = "0x656210", VA = "0x180657010", Slot = "96")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232D")]
		[Address(RVA = "0x656EF0", Offset = "0x6560F0", VA = "0x180656EF0", Slot = "97")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232E")]
		[Address(RVA = "0x656EB0", Offset = "0x6560B0", VA = "0x180656EB0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232F")]
		[Address(RVA = "0x6677B0", Offset = "0x6669B0", VA = "0x1806677B0")]
		private void RpcWriter___Server_set_CurrentVehicle_3323014238(NetworkObject value)
		{
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002330")]
		[Address(RVA = "0x6604D0", Offset = "0x65F6D0", VA = "0x1806604D0")]
		public void RpcLogic___set_CurrentVehicle_3323014238(NetworkObject value)
		{
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002331")]
		[Address(RVA = "0x662910", Offset = "0x661B10", VA = "0x180662910")]
		private void RpcReader___Server_set_CurrentVehicle_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002332")]
		[Address(RVA = "0x667600", Offset = "0x666800", VA = "0x180667600")]
		private void RpcWriter___Server_set_CurrentBed_3323014238(NetworkObject value)
		{
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x660430", Offset = "0x65F630", VA = "0x180660430")]
		public void RpcLogic___set_CurrentBed_3323014238(NetworkObject value)
		{
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x662810", Offset = "0x661A10", VA = "0x180662810")]
		private void RpcReader___Server_set_CurrentBed_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x667960", Offset = "0x666B60", VA = "0x180667960")]
		private void RpcWriter___Server_set_IsSkating_1140765316(bool value)
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x660570", Offset = "0x65F770", VA = "0x180660570")]
		public void RpcLogic___set_IsSkating_1140765316(bool value)
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x6629B0", Offset = "0x661BB0", VA = "0x1806629B0")]
		private void RpcReader___Server_set_IsSkating_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x667250", Offset = "0x666450", VA = "0x180667250")]
		private void RpcWriter___Server_set_CameraPosition_4276783012(Vector3 value)
		{
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002339")]
		[Address(RVA = "0x6602E0", Offset = "0x65F4E0", VA = "0x1806602E0")]
		public void RpcLogic___set_CameraPosition_4276783012(Vector3 value)
		{
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x6625C0", Offset = "0x6617C0", VA = "0x1806625C0")]
		private void RpcReader___Server_set_CameraPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233B")]
		[Address(RVA = "0x667440", Offset = "0x666640", VA = "0x180667440")]
		private void RpcWriter___Server_set_CameraRotation_3429297120(Quaternion value)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233C")]
		[Address(RVA = "0x660390", Offset = "0x65F590", VA = "0x180660390")]
		public void RpcLogic___set_CameraRotation_3429297120(Quaternion value)
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233D")]
		[Address(RVA = "0x662720", Offset = "0x661920", VA = "0x180662720")]
		private void RpcReader___Server_set_CameraRotation_3429297120(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233E")]
		[Address(RVA = "0x665080", Offset = "0x664280", VA = "0x180665080")]
		private void RpcWriter___Server_RequestSavePlayer_2166136261()
		{
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233F")]
		[Address(RVA = "0x65ECE0", Offset = "0x65DEE0", VA = "0x18065ECE0")]
		public void RpcLogic___RequestSavePlayer_2166136261()
		{
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002340")]
		[Address(RVA = "0x6615E0", Offset = "0x6607E0", VA = "0x1806615E0")]
		private void RpcReader___Server_RequestSavePlayer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x663DA0", Offset = "0x662FA0", VA = "0x180663DA0")]
		private void RpcWriter___Observers_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002342")]
		[Address(RVA = "0x65EE20", Offset = "0x65E020", VA = "0x18065EE20")]
		private void RpcLogic___ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002343")]
		[Address(RVA = "0x660E40", Offset = "0x660040", VA = "0x180660E40")]
		private void RpcReader___Observers_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002344")]
		[Address(RVA = "0x6680D0", Offset = "0x6672D0", VA = "0x1806680D0")]
		private void RpcWriter___Target_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002345")]
		[Address(RVA = "0x662D00", Offset = "0x661F00", VA = "0x180662D00")]
		private void RpcReader___Target_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x663030", Offset = "0x662230", VA = "0x180663030")]
		private void RpcWriter___Observers_HostExitedGame_2166136261()
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x65D660", Offset = "0x65C860", VA = "0x18065D660")]
		public void RpcLogic___HostExitedGame_2166136261()
		{
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x660600", Offset = "0x65F800", VA = "0x180660600")]
		private void RpcReader___Observers_HostExitedGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002349")]
		[Address(RVA = "0x666600", Offset = "0x665800", VA = "0x180666600")]
		private void RpcWriter___Server_SendPlayerNameData_586648380(string playerName, ulong id)
		{
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x65F490", Offset = "0x65E690", VA = "0x18065F490")]
		public void RpcLogic___SendPlayerNameData_586648380(string playerName, ulong id)
		{
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x661EC0", Offset = "0x6610C0", VA = "0x180661EC0")]
		private void RpcReader___Server_SendPlayerNameData_586648380(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x65C6D0", Offset = "0x65B8D0", VA = "0x18065C6D0")]
		private void RpcWriter___Server_RequestPlayerData_3615296227(string playerCode)
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x65EA70", Offset = "0x65DC70", VA = "0x18065EA70")]
		public void RpcLogic___RequestPlayerData_3615296227(string playerCode)
		{
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234E")]
		[Address(RVA = "0x661590", Offset = "0x660790", VA = "0x180661590")]
		private void RpcReader___Server_RequestPlayerData_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600234F")]
		[Address(RVA = "0x663950", Offset = "0x662B50", VA = "0x180663950")]
		private void RpcWriter___Observers_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x65E510", Offset = "0x65D710", VA = "0x18065E510")]
		public void RpcLogic___ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x660B10", Offset = "0x65FD10", VA = "0x180660B10")]
		private void RpcReader___Observers_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x667C70", Offset = "0x666E70", VA = "0x180667C70")]
		private void RpcWriter___Target_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x662AC0", Offset = "0x661CC0", VA = "0x180662AC0")]
		private void RpcReader___Target_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002354")]
		[Address(RVA = "0x663AF0", Offset = "0x662CF0", VA = "0x180663AF0")]
		private void RpcWriter___Observers_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002355")]
		[Address(RVA = "0x65E6A0", Offset = "0x65D8A0", VA = "0x18065E6A0")]
		private void RpcLogic___ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002356")]
		[Address(RVA = "0x660BE0", Offset = "0x65FDE0", VA = "0x180660BE0")]
		private void RpcReader___Observers_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002357")]
		[Address(RVA = "0x667E10", Offset = "0x667010", VA = "0x180667E10")]
		private void RpcWriter___Target_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002358")]
		[Address(RVA = "0x662B90", Offset = "0x661D90", VA = "0x180662B90")]
		private void RpcReader___Target_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002359")]
		[Address(RVA = "0x666E00", Offset = "0x666000", VA = "0x180666E00")]
		private void RpcWriter___Server_SetFlashlightOn_Server_1140765316(bool on)
		{
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235A")]
		[Address(RVA = "0x65FB90", Offset = "0x65ED90", VA = "0x18065FB90")]
		public void RpcLogic___SetFlashlightOn_Server_1140765316(bool on)
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x6623C0", Offset = "0x6615C0", VA = "0x1806623C0")]
		private void RpcReader___Server_SetFlashlightOn_Server_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x664580", Offset = "0x663780", VA = "0x180664580")]
		private void RpcWriter___Observers_SetFlashlightOn_Client_1140765316(bool on)
		{
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x65FB20", Offset = "0x65ED20", VA = "0x18065FB20")]
		private void RpcLogic___SetFlashlightOn_Client_1140765316(bool on)
		{
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235E")]
		[Address(RVA = "0x661150", Offset = "0x660350", VA = "0x180661150")]
		private void RpcReader___Observers_SetFlashlightOn_Client_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x65A270", Offset = "0x659470", VA = "0x18065A270")]
		private void RpcWriter___Observers_PlayJumpAnimation_2166136261()
		{
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002360")]
		[Address(RVA = "0x65DCB0", Offset = "0x65CEB0", VA = "0x18065DCB0")]
		public void RpcLogic___PlayJumpAnimation_2166136261()
		{
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002361")]
		[Address(RVA = "0x6606C0", Offset = "0x65F8C0", VA = "0x1806606C0")]
		private void RpcReader___Observers_PlayJumpAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002362")]
		[Address(RVA = "0x6659B0", Offset = "0x664BB0", VA = "0x1806659B0")]
		private void RpcWriter___Server_SendCrouched_1140765316(bool crouched)
		{
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002363")]
		[Address(RVA = "0x65F1A0", Offset = "0x65E3A0", VA = "0x18065F1A0")]
		public void RpcLogic___SendCrouched_1140765316(bool crouched)
		{
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002364")]
		[Address(RVA = "0x6619F0", Offset = "0x660BF0", VA = "0x1806619F0")]
		private void RpcReader___Server_SendCrouched_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002365")]
		[Address(RVA = "0x667B10", Offset = "0x666D10", VA = "0x180667B10")]
		private void RpcWriter___Target_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002366")]
		[Address(RVA = "0x65DE20", Offset = "0x65D020", VA = "0x18065DE20")]
		private void RpcLogic___ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002367")]
		[Address(RVA = "0x662A30", Offset = "0x661C30", VA = "0x180662A30")]
		private void RpcReader___Target_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002368")]
		[Address(RVA = "0x663390", Offset = "0x662590", VA = "0x180663390")]
		private void RpcWriter___Observers_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x660870", Offset = "0x65FA70", VA = "0x180660870")]
		private void RpcReader___Observers_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x6656D0", Offset = "0x6648D0", VA = "0x1806656D0")]
		private void RpcWriter___Server_SendAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x65F060", Offset = "0x65E260", VA = "0x18065F060")]
		public void RpcLogic___SendAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x661810", Offset = "0x660A10", VA = "0x180661810")]
		private void RpcReader___Server_SendAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x664300", Offset = "0x663500", VA = "0x180664300")]
		private void RpcWriter___Observers_SetAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x65FA40", Offset = "0x65EC40", VA = "0x18065FA40")]
		public void RpcLogic___SetAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x661070", Offset = "0x660270", VA = "0x180661070")]
		private void RpcReader___Observers_SetAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x664800", Offset = "0x663A00", VA = "0x180664800")]
		private void RpcWriter___Observers_SetVisible_Networked_1140765316(bool vis)
		{
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x660180", Offset = "0x65F380", VA = "0x180660180")]
		private void RpcLogic___SetVisible_Networked_1140765316(bool vis)
		{
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002372")]
		[Address(RVA = "0x661240", Offset = "0x660440", VA = "0x180661240")]
		private void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002373")]
		[Address(RVA = "0x667120", Offset = "0x666320", VA = "0x180667120")]
		private void RpcWriter___Server_SetReadyToSleep_1140765316(bool ready)
		{
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002374")]
		[Address(RVA = "0x6600F0", Offset = "0x65F2F0", VA = "0x1806600F0")]
		public void RpcLogic___SetReadyToSleep_1140765316(bool ready)
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002375")]
		[Address(RVA = "0x662530", Offset = "0x661730", VA = "0x180662530")]
		private void RpcReader___Server_SetReadyToSleep_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002376")]
		[Address(RVA = "0x666800", Offset = "0x665A00", VA = "0x180666800")]
		private void RpcWriter___Server_SendPunch_2166136261()
		{
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002377")]
		[Address(RVA = "0x65AA70", Offset = "0x659C70", VA = "0x18065AA70")]
		public void RpcLogic___SendPunch_2166136261()
		{
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002378")]
		[Address(RVA = "0x661F60", Offset = "0x661160", VA = "0x180661F60")]
		private void RpcReader___Server_SendPunch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002379")]
		[Address(RVA = "0x65AA70", Offset = "0x659C70", VA = "0x18065AA70")]
		private void RpcWriter___Observers_Punch_2166136261()
		{
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x65DCE0", Offset = "0x65CEE0", VA = "0x18065DCE0")]
		private void RpcLogic___Punch_2166136261()
		{
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x660700", Offset = "0x65F900", VA = "0x180660700")]
		private void RpcReader___Observers_Punch_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237C")]
		[Address(RVA = "0x664ED0", Offset = "0x6640D0", VA = "0x180664ED0")]
		private void RpcWriter___Server_MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237D")]
		[Address(RVA = "0x65D7D0", Offset = "0x65C9D0", VA = "0x18065D7D0")]
		private void RpcLogic___MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237E")]
		[Address(RVA = "0x661510", Offset = "0x660710", VA = "0x180661510")]
		private void RpcReader___Server_MarkIntroCompleted_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237F")]
		[Address(RVA = "0x666020", Offset = "0x665220", VA = "0x180666020")]
		private void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002380")]
		[Address(RVA = "0x65F330", Offset = "0x65E530", VA = "0x18065F330", Slot = "98")]
		public virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x661CE0", Offset = "0x660EE0", VA = "0x180661CE0")]
		private void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x663810", Offset = "0x662A10", VA = "0x180663810")]
		private void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x65E0C0", Offset = "0x65D2C0", VA = "0x18065E0C0", Slot = "99")]
		public virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002384")]
		[Address(RVA = "0x660AB0", Offset = "0x65FCB0", VA = "0x180660AB0")]
		private void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002385")]
		[Address(RVA = "0x664BD0", Offset = "0x663DD0", VA = "0x180664BD0")]
		private void RpcWriter___Server_Arrest_Server_2166136261()
		{
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x650760", Offset = "0x64F960", VA = "0x180650760")]
		public void RpcLogic___Arrest_Server_2166136261()
		{
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x661450", Offset = "0x660650", VA = "0x180661450")]
		private void RpcReader___Server_Arrest_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x662DF0", Offset = "0x661FF0", VA = "0x180662DF0")]
		private void RpcWriter___Observers_Arrest_Client_2166136261()
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x65CF50", Offset = "0x65C150", VA = "0x18065CF50")]
		private void RpcLogic___Arrest_Client_2166136261()
		{
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x660580", Offset = "0x65F780", VA = "0x180660580")]
		private void RpcReader___Observers_Arrest_Client_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x664D50", Offset = "0x663F50", VA = "0x180664D50")]
		private void RpcWriter___Server_Free_Server_2166136261()
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x653110", Offset = "0x652310", VA = "0x180653110")]
		public void RpcLogic___Free_Server_2166136261()
		{
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x6614B0", Offset = "0x6606B0", VA = "0x1806614B0")]
		private void RpcReader___Server_Free_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x662F10", Offset = "0x662110", VA = "0x180662F10")]
		private void RpcWriter___Observers_Free_Client_2166136261()
		{
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x65D0C0", Offset = "0x65C2C0", VA = "0x18065D0C0")]
		private void RpcLogic___Free_Client_2166136261()
		{
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x6605C0", Offset = "0x65F7C0", VA = "0x1806605C0")]
		private void RpcReader___Observers_Free_Client_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x666480", Offset = "0x665680", VA = "0x180666480")]
		private void RpcWriter___Server_SendPassOut_2166136261()
		{
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002392")]
		[Address(RVA = "0x65A150", Offset = "0x659350", VA = "0x18065A150")]
		public void RpcLogic___SendPassOut_2166136261()
		{
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002393")]
		[Address(RVA = "0x661E60", Offset = "0x661060", VA = "0x180661E60")]
		private void RpcReader___Server_SendPassOut_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002394")]
		[Address(RVA = "0x663270", Offset = "0x662470", VA = "0x180663270")]
		private void RpcWriter___Observers_PassOut_2166136261()
		{
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002395")]
		[Address(RVA = "0x65DA20", Offset = "0x65CC20", VA = "0x18065DA20")]
		public void RpcLogic___PassOut_2166136261()
		{
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002396")]
		[Address(RVA = "0x660680", Offset = "0x65F880", VA = "0x180660680")]
		private void RpcReader___Observers_PassOut_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002397")]
		[Address(RVA = "0x666300", Offset = "0x665500", VA = "0x180666300")]
		private void RpcWriter___Server_SendPassOutRecovery_2166136261()
		{
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002398")]
		[Address(RVA = "0x65A030", Offset = "0x659230", VA = "0x18065A030")]
		public void RpcLogic___SendPassOutRecovery_2166136261()
		{
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002399")]
		[Address(RVA = "0x661E00", Offset = "0x661000", VA = "0x180661E00")]
		private void RpcReader___Server_SendPassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x663150", Offset = "0x662350", VA = "0x180663150")]
		private void RpcWriter___Observers_PassOutRecovery_2166136261()
		{
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x65D870", Offset = "0x65CA70", VA = "0x18065D870")]
		public void RpcLogic___PassOutRecovery_2166136261()
		{
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x660640", Offset = "0x65F840", VA = "0x180660640")]
		private void RpcReader___Observers_PassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x665EF0", Offset = "0x6650F0", VA = "0x180665EF0")]
		private void RpcWriter___Server_SendEquippable_Networked_3615296227(string assetPath)
		{
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x65F1E0", Offset = "0x65E3E0", VA = "0x18065F1E0")]
		public void RpcLogic___SendEquippable_Networked_3615296227(string assetPath)
		{
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x661C70", Offset = "0x660E70", VA = "0x180661C70")]
		private void RpcReader___Server_SendEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x664440", Offset = "0x663640", VA = "0x180664440")]
		private void RpcWriter___Observers_SetEquippable_Networked_3615296227(string assetPath)
		{
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A1")]
		[Address(RVA = "0x65FAE0", Offset = "0x65ECE0", VA = "0x18065FAE0")]
		private void RpcLogic___SetEquippable_Networked_3615296227(string assetPath)
		{
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x6610D0", Offset = "0x6602D0", VA = "0x1806610D0")]
		private void RpcReader___Observers_SetEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x665AE0", Offset = "0x664CE0", VA = "0x180665AE0")]
		private void RpcWriter___Server_SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x65BA10", Offset = "0x65AC10", VA = "0x18065BA10")]
		public void RpcLogic___SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x661A80", Offset = "0x660C80", VA = "0x180661A80")]
		private void RpcReader___Server_SendEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x6634D0", Offset = "0x6626D0", VA = "0x1806634D0")]
		private void RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x65DE70", Offset = "0x65D070", VA = "0x18065DE70")]
		private void RpcLogic___ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x660900", Offset = "0x65FB00", VA = "0x180660900")]
		private void RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x665CD0", Offset = "0x664ED0", VA = "0x180665CD0")]
		private void RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x65F1B0", Offset = "0x65E3B0", VA = "0x18065F1B0")]
		public void RpcLogic___SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x661B30", Offset = "0x660D30", VA = "0x180661B30")]
		private void RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x663650", Offset = "0x662850", VA = "0x180663650")]
		private void RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x65DF70", Offset = "0x65D170", VA = "0x18065DF70")]
		private void RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x660990", Offset = "0x65FB90", VA = "0x180660990")]
		private void RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x665370", Offset = "0x664570", VA = "0x180665370")]
		private void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B0")]
		[Address(RVA = "0x65F040", Offset = "0x65E240", VA = "0x18065F040")]
		public void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x661700", Offset = "0x660900", VA = "0x180661700")]
		private void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x664050", Offset = "0x663250", VA = "0x180664050")]
		private void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x65F960", Offset = "0x65EB60", VA = "0x18065F960")]
		public void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x660F60", Offset = "0x660160", VA = "0x180660F60")]
		private void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x668230", Offset = "0x667430", VA = "0x180668230")]
		private void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x662D80", Offset = "0x661F80", VA = "0x180662D80")]
		private void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x663C60", Offset = "0x662E60", VA = "0x180663C60")]
		private void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x65EDE0", Offset = "0x65DFE0", VA = "0x18065EDE0")]
		public void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x660DD0", Offset = "0x65FFD0", VA = "0x180660DD0")]
		private void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x667F70", Offset = "0x667170", VA = "0x180667F70")]
		private void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x662C90", Offset = "0x661E90", VA = "0x180662C90")]
		private void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0x665190", Offset = "0x664390", VA = "0x180665190")]
		private void RpcWriter___Server_SendAnimationBool_310431262(string name, bool val)
		{
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x65EED0", Offset = "0x65E0D0", VA = "0x18065EED0")]
		public void RpcLogic___SendAnimationBool_310431262(string name, bool val)
		{
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x661630", Offset = "0x660830", VA = "0x180661630")]
		private void RpcReader___Server_SendAnimationBool_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x663EE0", Offset = "0x6630E0", VA = "0x180663EE0")]
		private void RpcWriter___Observers_SetAnimationBool_310431262(string name, bool val)
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x65F930", Offset = "0x65EB30", VA = "0x18065F930")]
		public void RpcLogic___SetAnimationBool_310431262(string name, bool val)
		{
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x660EB0", Offset = "0x6600B0", VA = "0x180660EB0")]
		private void RpcReader___Observers_SetAnimationBool_310431262(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x664AB0", Offset = "0x663CB0", VA = "0x180664AB0")]
		private void RpcWriter___Observers_Taze_2166136261()
		{
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x6601E0", Offset = "0x65F3E0", VA = "0x1806601E0")]
		public void RpcLogic___Taze_2166136261()
		{
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x661340", Offset = "0x660540", VA = "0x180661340")]
		private void RpcReader___Observers_Taze_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x666F30", Offset = "0x666130", VA = "0x180666F30")]
		private void RpcWriter___Server_SetInventoryItem_2317364410(int index, ItemInstance item)
		{
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x65FD00", Offset = "0x65EF00", VA = "0x18065FD00")]
		public void RpcLogic___SetInventoryItem_2317364410(int index, ItemInstance item)
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x662450", Offset = "0x661650", VA = "0x180662450")]
		private void RpcReader___Server_SetInventoryItem_2317364410(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x666C40", Offset = "0x665E40", VA = "0x180666C40")]
		private void RpcWriter___Server_SetEquippedSlotIndex_3316948804(int index)
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x65FB10", Offset = "0x65ED10", VA = "0x18065FB10")]
		public void RpcLogic___SetEquippedSlotIndex_3316948804(int index)
		{
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x662330", Offset = "0x661530", VA = "0x180662330")]
		private void RpcReader___Server_SetEquippedSlotIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x65C550", Offset = "0x65B750", VA = "0x18065C550")]
		private void RpcWriter___Observers_RemoveEquippedItemFromInventory_3643459082(string id, int amount)
		{
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x65E940", Offset = "0x65DB40", VA = "0x18065E940")]
		public void RpcLogic___RemoveEquippedItemFromInventory_3643459082(string id, int amount)
		{
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CD")]
		[Address(RVA = "0x660C60", Offset = "0x65FE60", VA = "0x180660C60")]
		private void RpcReader___Observers_RemoveEquippedItemFromInventory_3643459082(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CE")]
		[Address(RVA = "0x665520", Offset = "0x664720", VA = "0x180665520")]
		private void RpcWriter___Server_SendAppearance_3281254764(BasicAvatarSettings settings)
		{
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x65F050", Offset = "0x65E250", VA = "0x18065F050")]
		public void RpcLogic___SendAppearance_3281254764(BasicAvatarSettings settings)
		{
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x661790", Offset = "0x660990", VA = "0x180661790")]
		private void RpcReader___Server_SendAppearance_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x664190", Offset = "0x663390", VA = "0x180664190")]
		private void RpcWriter___Observers_SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x65F9A0", Offset = "0x65EBA0", VA = "0x18065F9A0")]
		public void RpcLogic___SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x660FD0", Offset = "0x6601D0", VA = "0x180660FD0")]
		private void RpcReader___Observers_SetAppearance_2139595489(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x666150", Offset = "0x665350", VA = "0x180666150")]
		private void RpcWriter___Server_SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x65F350", Offset = "0x65E550", VA = "0x18065F350")]
		private void RpcLogic___SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x661D60", Offset = "0x660F60", VA = "0x180661D60")]
		private void RpcReader___Server_SendMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x6646C0", Offset = "0x6638C0", VA = "0x1806646C0")]
		private void RpcWriter___Observers_SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x65FD50", Offset = "0x65EF50", VA = "0x18065FD50")]
		private void RpcLogic___SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x6611D0", Offset = "0x6603D0", VA = "0x1806611D0")]
		private void RpcReader___Observers_SetMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x665880", Offset = "0x664A80", VA = "0x180665880")]
		private void RpcWriter___Server_SendConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x65B450", Offset = "0x65A650", VA = "0x18065B450")]
		private void RpcLogic___SendConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x661890", Offset = "0x660A90", VA = "0x180661890")]
		private void RpcReader___Server_SendConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x65B450", Offset = "0x65A650", VA = "0x18065B450")]
		private void RpcWriter___Observers_ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x65DD70", Offset = "0x65CF70", VA = "0x18065DD70")]
		private void RpcLogic___ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x6607A0", Offset = "0x65F9A0", VA = "0x1806607A0")]
		private void RpcReader___Observers_ReceiveConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x666980", Offset = "0x665B80", VA = "0x180666980")]
		private void RpcWriter___Server_SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x65F630", Offset = "0x65E830", VA = "0x18065F630")]
		public void RpcLogic___SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x6620B0", Offset = "0x6612B0", VA = "0x1806620B0")]
		private void RpcReader___Server_SendValue_3589193952(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x65C290", Offset = "0x65B490", VA = "0x18065C290")]
		private void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x65E920", Offset = "0x65DB20", VA = "0x18065E920")]
		private void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x662C10", Offset = "0x661E10", VA = "0x180662C10")]
		private void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x666AE0", Offset = "0x665CE0", VA = "0x180666AE0")]
		private void RpcWriter___Server_SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x65F7C0", Offset = "0x65E9C0", VA = "0x18065F7C0")]
		public void RpcLogic___SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x662180", Offset = "0x661380", VA = "0x180662180")]
		private void RpcReader___Server_SendWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x664940", Offset = "0x663B40", VA = "0x180664940")]
		private void RpcWriter___Observers_ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x6601B0", Offset = "0x65F3B0", VA = "0x1806601B0")]
		private void RpcLogic___ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x6612B0", Offset = "0x6604B0", VA = "0x1806612B0")]
		private void RpcReader___Observers_ShowWorldSpaceDialogue_606697822(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000647")]
		public string SyncAccessor_<PlayerName>k__BackingField
		{
			[Token(Token = "0x60023EC")]
			[Address(RVA = "0x66BA60", Offset = "0x66AC60", VA = "0x18066BA60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023ED")]
			[Address(RVA = "0x66C770", Offset = "0x66B970", VA = "0x18066C770")]
			set
			{
			}
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0000BD00 File Offset: 0x00009F00
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x65AB90", Offset = "0x659D90", VA = "0x18065AB90", Slot = "100")]
		public virtual bool ReadSyncVar___ScheduleOne.PlayerScripts.Player(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000648")]
		public string SyncAccessor_<PlayerCode>k__BackingField
		{
			[Token(Token = "0x60023EF")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023F0")]
			[Address(RVA = "0x66C6B0", Offset = "0x66B8B0", VA = "0x18066C6B0")]
			set
			{
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000649")]
		public NetworkObject SyncAccessor_<CurrentVehicle>k__BackingField
		{
			[Token(Token = "0x60023F1")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023F2")]
			[Address(RVA = "0x66C530", Offset = "0x66B730", VA = "0x18066C530")]
			set
			{
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064A")]
		public NetworkObject SyncAccessor_<CurrentBed>k__BackingField
		{
			[Token(Token = "0x60023F3")]
			[Address(RVA = "0x66B570", Offset = "0x66A770", VA = "0x18066B570")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023F4")]
			[Address(RVA = "0x66C470", Offset = "0x66B670", VA = "0x18066C470")]
			set
			{
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0000BD18 File Offset: 0x00009F18
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064B")]
		public bool SyncAccessor_<IsReadyToSleep>k__BackingField
		{
			[Token(Token = "0x60023F5")]
			[Address(RVA = "0x66B830", Offset = "0x66AA30", VA = "0x18066B830")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60023F6")]
			[Address(RVA = "0x66C5F0", Offset = "0x66B7F0", VA = "0x18066C5F0")]
			set
			{
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0000BD30 File Offset: 0x00009F30
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064C")]
		public Vector3 SyncAccessor_<CameraPosition>k__BackingField
		{
			[Token(Token = "0x60023F7")]
			[Address(RVA = "0x66B4E0", Offset = "0x66A6E0", VA = "0x18066B4E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60023F8")]
			[Address(RVA = "0x66C2D0", Offset = "0x66B4D0", VA = "0x18066C2D0")]
			set
			{
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0000BD48 File Offset: 0x00009F48
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064D")]
		public Quaternion SyncAccessor_<CameraRotation>k__BackingField
		{
			[Token(Token = "0x60023F9")]
			[Address(RVA = "0x66B500", Offset = "0x66A700", VA = "0x18066B500")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60023FA")]
			[Address(RVA = "0x66C3B0", Offset = "0x66B5B0", VA = "0x18066C3B0")]
			set
			{
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x650A00", Offset = "0x64FC00", VA = "0x180650A00", Slot = "101")]
		protected virtual void Awake_UserLogic_ScheduleOne.PlayerScripts.Player_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		public const string OWNER_PLAYER_CODE = "Local";

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		public const float CapColDefaultHeight = 2f;

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		private const int LightningStrikeBoostDuration = 60;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public List<NetworkObject> objectsTemporarilyOwnedByPlayer;

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action onLocalPlayerSpawned;

		// Token: 0x04001BBC RID: 7100
		[Token(Token = "0x4001BBC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Player> onPlayerSpawned;

		// Token: 0x04001BBD RID: 7101
		[Token(Token = "0x4001BBD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<Player> onPlayerDespawned;

		// Token: 0x04001BBE RID: 7102
		[Token(Token = "0x4001BBE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Player Local;

		// Token: 0x04001BBF RID: 7103
		[Token(Token = "0x4001BBF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<Player> PlayerList;

		// Token: 0x04001BC1 RID: 7105
		[Token(Token = "0x4001BC1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("References")]
		public GameObject LocalGameObject;

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AvatarAnimation Anim;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04001BC6 RID: 7110
		[Token(Token = "0x4001BC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public PlayerVisibility VisualState;

		// Token: 0x04001BC7 RID: 7111
		[Token(Token = "0x4001BC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public EntityVisibility Visibility;

		// Token: 0x04001BC8 RID: 7112
		[Token(Token = "0x4001BC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public CapsuleCollider CapCol;

		// Token: 0x04001BC9 RID: 7113
		[Token(Token = "0x4001BC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public POI PoI;

		// Token: 0x04001BCA RID: 7114
		[Token(Token = "0x4001BCA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public PlayerHealth Health;

		// Token: 0x04001BCB RID: 7115
		[Token(Token = "0x4001BCB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public PlayerCrimeData CrimeData;

		// Token: 0x04001BCC RID: 7116
		[Token(Token = "0x4001BCC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public PlayerEnergy Energy;

		// Token: 0x04001BCD RID: 7117
		[Token(Token = "0x4001BCD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public Transform MimicCamera;

		// Token: 0x04001BCE RID: 7118
		[Token(Token = "0x4001BCE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AvatarFootstepDetector FootstepDetector;

		// Token: 0x04001BCF RID: 7119
		[Token(Token = "0x4001BCF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public CharacterController CharacterController;

		// Token: 0x04001BD0 RID: 7120
		[Token(Token = "0x4001BD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public AudioSourceController PunchSound;

		// Token: 0x04001BD1 RID: 7121
		[Token(Token = "0x4001BD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public OptimizedLight ThirdPersonFlashlight;

		// Token: 0x04001BD2 RID: 7122
		[Token(Token = "0x4001BD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public WorldspaceDialogueRenderer NameLabel;

		// Token: 0x04001BD3 RID: 7123
		[Token(Token = "0x4001BD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public PlayerClothing Clothing;

		// Token: 0x04001BD4 RID: 7124
		[Token(Token = "0x4001BD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public WorldspaceDialogueRenderer WorldspaceDialogue;

		// Token: 0x04001BD5 RID: 7125
		[Token(Token = "0x4001BD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Header("Settings")]
		public LayerMask GroundDetectionMask;

		// Token: 0x04001BD6 RID: 7126
		[Token(Token = "0x4001BD6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public float AvatarOffset_Standing;

		// Token: 0x04001BD7 RID: 7127
		[Token(Token = "0x4001BD7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public float AvatarOffset_Crouched;

		// Token: 0x04001BD8 RID: 7128
		[Token(Token = "0x4001BD8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		[ColorUsage(true, true)]
		[SerializeField]
		private Color _lightningColorTint;

		// Token: 0x04001BD9 RID: 7129
		[Token(Token = "0x4001BD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[Header("Movement mapping")]
		public AnimationCurve WalkingMapCurve;

		// Token: 0x04001BDA RID: 7130
		[Token(Token = "0x4001BDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public AnimationCurve CrouchWalkMapCurve;

		// Token: 0x04001BDC RID: 7132
		[Token(Token = "0x4001BDC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public NetworkConnection Connection;

		// Token: 0x04001BE2 RID: 7138
		[Token(Token = "0x4001BE2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public Player.VehicleEvent onEnterVehicle;

		// Token: 0x04001BE3 RID: 7139
		[Token(Token = "0x4001BE3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public Player.VehicleTransformEvent onExitVehicle;

		// Token: 0x04001BEB RID: 7147
		[Token(Token = "0x4001BEB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public Action<Skateboard> onSkateboardMounted;

		// Token: 0x04001BEC RID: 7148
		[Token(Token = "0x4001BEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public Action onSkateboardDismounted;

		// Token: 0x04001BF6 RID: 7158
		[Token(Token = "0x4001BF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
		public bool HasCompletedIntro;

		// Token: 0x04001BF9 RID: 7161
		[Token(Token = "0x4001BF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public ItemSlot[] Inventory;

		// Token: 0x04001BFE RID: 7166
		[Token(Token = "0x4001BFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		[Header("Appearance debugging")]
		public BasicAvatarSettings DebugAvatarSettings;

		// Token: 0x04001BFF RID: 7167
		[Token(Token = "0x4001BFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private PlayerLoader loader;

		// Token: 0x04001C03 RID: 7171
		[Token(Token = "0x4001C03")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		public UnityEvent onRagdoll;

		// Token: 0x04001C04 RID: 7172
		[Token(Token = "0x4001C04")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public UnityEvent onRagdollEnd;

		// Token: 0x04001C05 RID: 7173
		[Token(Token = "0x4001C05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public UnityEvent onArrested;

		// Token: 0x04001C06 RID: 7174
		[Token(Token = "0x4001C06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		public UnityEvent onFreed;

		// Token: 0x04001C07 RID: 7175
		[Token(Token = "0x4001C07")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		public UnityEvent onTased;

		// Token: 0x04001C08 RID: 7176
		[Token(Token = "0x4001C08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		public UnityEvent onTasedEnd;

		// Token: 0x04001C09 RID: 7177
		[Token(Token = "0x4001C09")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		public UnityEvent onPassedOut;

		// Token: 0x04001C0A RID: 7178
		[Token(Token = "0x4001C0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		public UnityEvent onPassOutRecovery;

		// Token: 0x04001C0B RID: 7179
		[Token(Token = "0x4001C0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		public UnityEvent onStruckByLightning;

		// Token: 0x04001C0C RID: 7180
		[Token(Token = "0x4001C0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		public List<BaseVariable> PlayerVariables;

		// Token: 0x04001C0D RID: 7181
		[Token(Token = "0x4001C0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		public Dictionary<string, BaseVariable> VariableDict;

		// Token: 0x04001C0E RID: 7182
		[Token(Token = "0x4001C0E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private float standingScale;

		// Token: 0x04001C0F RID: 7183
		[Token(Token = "0x4001C0F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		private float timeAirborne;

		// Token: 0x04001C12 RID: 7186
		[Token(Token = "0x4001C12")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private Coroutine taseCoroutine;

		// Token: 0x04001C13 RID: 7187
		[Token(Token = "0x4001C13")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private List<ConstantForce> ragdollForceComponents;

		// Token: 0x04001C15 RID: 7189
		[Token(Token = "0x4001C15")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private List<int> impactHistory;

		// Token: 0x04001C1A RID: 7194
		[Token(Token = "0x4001C1A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private List<Quaternion> seizureRotations;

		// Token: 0x04001C1E RID: 7198
		[Token(Token = "0x4001C1E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private List<int> equippableMessageIDHistory;

		// Token: 0x04001C1F RID: 7199
		[Token(Token = "0x4001C1F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private NetworkedEquipper _networkedEquipper;

		// Token: 0x04001C20 RID: 7200
		[Token(Token = "0x4001C20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private Coroutine lerpScaleRoutine;

		// Token: 0x04001C21 RID: 7201
		[Token(Token = "0x4001C21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		public SyncVar<string> syncVar___<PlayerName>k__BackingField;

		// Token: 0x04001C22 RID: 7202
		[Token(Token = "0x4001C22")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		public SyncVar<string> syncVar___<PlayerCode>k__BackingField;

		// Token: 0x04001C23 RID: 7203
		[Token(Token = "0x4001C23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		public SyncVar<NetworkObject> syncVar___<CurrentVehicle>k__BackingField;

		// Token: 0x04001C24 RID: 7204
		[Token(Token = "0x4001C24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		public SyncVar<NetworkObject> syncVar___<CurrentBed>k__BackingField;

		// Token: 0x04001C25 RID: 7205
		[Token(Token = "0x4001C25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		public SyncVar<bool> syncVar___<IsReadyToSleep>k__BackingField;

		// Token: 0x04001C26 RID: 7206
		[Token(Token = "0x4001C26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		public SyncVar<Vector3> syncVar___<CameraPosition>k__BackingField;

		// Token: 0x04001C27 RID: 7207
		[Token(Token = "0x4001C27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		public SyncVar<Quaternion> syncVar___<CameraRotation>k__BackingField;

		// Token: 0x04001C28 RID: 7208
		[Token(Token = "0x4001C28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001C29 RID: 7209
		[Token(Token = "0x4001C29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x409")]
		private bool NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted;

		// Token: 0x020005D9 RID: 1497
		// (Invoke) Token: 0x060023FD RID: 9213
		[Token(Token = "0x20005D9")]
		public delegate void VehicleEvent(LandVehicle vehicle);

		// Token: 0x020005DA RID: 1498
		// (Invoke) Token: 0x06002401 RID: 9217
		[Token(Token = "0x20005DA")]
		public delegate void VehicleTransformEvent(LandVehicle vehicle, Transform exitPoint);
	}
}
