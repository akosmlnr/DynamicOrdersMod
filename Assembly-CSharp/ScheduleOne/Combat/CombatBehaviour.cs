using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Tools;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E30 RID: 3632
	[Token(Token = "0x2000E30")]
	public class CombatBehaviour : ScheduleOne.NPCs.Behaviour.Behaviour
	{
		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06006827 RID: 26663 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006828 RID: 26664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EC9")]
		public ICombatTargetable Target
		{
			[Token(Token = "0x6006827")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006828")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x000195D8 File Offset: 0x000177D8
		// (set) Token: 0x0600682A RID: 26666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECA")]
		public bool IsSearching
		{
			[Token(Token = "0x6006829")]
			[Address(RVA = "0x5887A0", Offset = "0x5879A0", VA = "0x1805887A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600682A")]
			[Address(RVA = "0x588850", Offset = "0x587A50", VA = "0x180588850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x0600682B RID: 26667 RVA: 0x000195F0 File Offset: 0x000177F0
		// (set) Token: 0x0600682C RID: 26668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECB")]
		public float TimeSinceTargetReacquired
		{
			[Token(Token = "0x600682B")]
			[Address(RVA = "0x7458C0", Offset = "0x744AC0", VA = "0x1807458C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600682C")]
			[Address(RVA = "0x745930", Offset = "0x744B30", VA = "0x180745930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x00019608 File Offset: 0x00017808
		// (set) Token: 0x0600682E RID: 26670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECC")]
		public bool IsTargetRecentlyVisible
		{
			[Token(Token = "0x600682D")]
			[Address(RVA = "0x7B1100", Offset = "0x7B0300", VA = "0x1807B1100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600682E")]
			[Address(RVA = "0xAA85E0", Offset = "0xAA77E0", VA = "0x180AA85E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x00019620 File Offset: 0x00017820
		// (set) Token: 0x06006830 RID: 26672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECD")]
		public bool IsTargetImmediatelyVisible
		{
			[Token(Token = "0x600682F")]
			[Address(RVA = "0x7B1160", Offset = "0x7B0360", VA = "0x1807B1160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006830")]
			[Address(RVA = "0xAA85D0", Offset = "0xAA77D0", VA = "0x180AA85D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006831")]
		[Address(RVA = "0xAA29E0", Offset = "0xAA1BE0", VA = "0x180AA29E0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006832")]
		[Address(RVA = "0xAA80D0", Offset = "0xAA72D0", VA = "0x180AA80D0")]
		private void Start()
		{
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006833")]
		[Address(RVA = "0xAA5300", Offset = "0xAA4500", VA = "0x180AA5300", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006834")]
		[Address(RVA = "0xAA6A30", Offset = "0xAA5C30", VA = "0x180AA6A30")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTargetAndEnable_Server(NetworkObject target)
		{
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006835")]
		[Address(RVA = "0xAA6B70", Offset = "0xAA5D70", VA = "0x180AA6B70")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected void SetTarget_Client(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006836")]
		[Address(RVA = "0xAA6DE0", Offset = "0xAA5FE0", VA = "0x180AA6DE0", Slot = "35")]
		protected virtual void SetTarget(NetworkObject target)
		{
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006837")]
		[Address(RVA = "0xAA26C0", Offset = "0xAA18C0", VA = "0x180AA26C0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006838")]
		[Address(RVA = "0xAA5820", Offset = "0xAA4A20", VA = "0x180AA5820", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006839")]
		[Address(RVA = "0xAA5380", Offset = "0xAA4580", VA = "0x180AA5380", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683A")]
		[Address(RVA = "0xAA39B0", Offset = "0xAA2BB0", VA = "0x180AA39B0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683B")]
		[Address(RVA = "0xAA39E0", Offset = "0xAA2BE0", VA = "0x180AA39E0", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683C")]
		[Address(RVA = "0xAA7B90", Offset = "0xAA6D90", VA = "0x180AA7B90", Slot = "36")]
		protected virtual void StartCombat()
		{
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683D")]
		[Address(RVA = "0xAA3A10", Offset = "0xAA2C10", VA = "0x180AA3A10", Slot = "37")]
		protected virtual void EndCombat()
		{
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683E")]
		[Address(RVA = "0xAA2B40", Offset = "0xAA1D40", VA = "0x180AA2B40", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683F")]
		[Address(RVA = "0xAA84A0", Offset = "0xAA76A0", VA = "0x180AA84A0")]
		protected void UpdateTimeout()
		{
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006840")]
		[Address(RVA = "0xAA83D0", Offset = "0xAA75D0", VA = "0x180AA83D0", Slot = "38")]
		protected virtual void UpdateLookAt()
		{
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006841")]
		[Address(RVA = "0xAA6970", Offset = "0xAA5B70", VA = "0x180AA6970")]
		protected void SetMovementSpeed(float speed, string label = "combat", int priority = 5)
		{
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006842")]
		[Address(RVA = "0xAA3C70", Offset = "0xAA2E70", VA = "0x180AA3C70")]
		private void EnsureRangedWeaponRoutineIsRunning()
		{
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x00019638 File Offset: 0x00017838
		[Token(Token = "0x6006843")]
		[Address(RVA = "0xAA4240", Offset = "0xAA3440", VA = "0x180AA4240")]
		protected Vector3 GetPredictedFutureTargetPosition(float lead_Min = 0f, float lead_Max = 2f)
		{
			return default(Vector3);
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006844")]
		[Address(RVA = "0xAA6870", Offset = "0xAA5A70", VA = "0x180AA6870", Slot = "30")]
		protected override void SetDestination(Vector3 position, bool teleportIfFail = true, float successThreshold = 1f)
		{
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006845")]
		[Address(RVA = "0xAA7060", Offset = "0xAA6260", VA = "0x180AA7060", Slot = "39")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void SetWeapon(string weaponPath)
		{
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006846")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "40")]
		protected virtual void OnCurrentWeaponChanged(AvatarWeapon weapon)
		{
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006847")]
		[Address(RVA = "0xAA3890", Offset = "0xAA2A90", VA = "0x180AA3890")]
		[ObserversRpc(RunLocally = true)]
		protected void ClearWeapon()
		{
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x00019650 File Offset: 0x00017850
		[Token(Token = "0x6006848")]
		[Address(RVA = "0xAA54E0", Offset = "0xAA46E0", VA = "0x180AA54E0", Slot = "41")]
		protected virtual bool ReadyToAttack(bool checkTarget = true)
		{
			return default(bool);
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x00019668 File Offset: 0x00017868
		[Token(Token = "0x6006849")]
		[Address(RVA = "0xAA4860", Offset = "0xAA3A60", VA = "0x180AA4860")]
		private bool IsCurrentWeaponMelee()
		{
			return default(bool);
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684A")]
		[Address(RVA = "0xAA2780", Offset = "0xAA1980", VA = "0x180AA2780", Slot = "42")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void Attack()
		{
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684B")]
		[Address(RVA = "0xAA81D0", Offset = "0xAA73D0", VA = "0x180AA81D0")]
		protected void SucessfulHit()
		{
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600684C")]
		[Address(RVA = "0xAA5470", Offset = "0xAA4670", VA = "0x180AA5470")]
		private IEnumerator RangedWeaponRoutine()
		{
			return null;
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600684D")]
		[Address(RVA = "0xAA5630", Offset = "0xAA4830", VA = "0x180AA5630")]
		private IEnumerator RepositionToRangedWeaponRange()
		{
			return null;
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x00019680 File Offset: 0x00017880
		[Token(Token = "0x600684E")]
		[Address(RVA = "0xAA3D10", Offset = "0xAA2F10", VA = "0x180AA3D10", Slot = "43")]
		protected virtual float GetIdealRangedWeaponDistance()
		{
			return 0f;
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x00019698 File Offset: 0x00017898
		[Token(Token = "0x600684F")]
		[Address(RVA = "0xAA71A0", Offset = "0xAA63A0", VA = "0x180AA71A0")]
		private bool Shoot()
		{
			return default(bool);
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006850")]
		[Address(RVA = "0xAA6F00", Offset = "0xAA6100", VA = "0x180AA6F00")]
		private void SetWeaponRaised(bool raised)
		{
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006851")]
		[Address(RVA = "0xAA3650", Offset = "0xAA2850", VA = "0x180AA3650")]
		protected void CheckTargetVisibility()
		{
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006852")]
		[Address(RVA = "0xAA4EF0", Offset = "0xAA40F0", VA = "0x180AA4EF0")]
		public void MarkPlayerVisible()
		{
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x000196B0 File Offset: 0x000178B0
		[Token(Token = "0x6006853")]
		[Address(RVA = "0x98D6F0", Offset = "0x98C8F0", VA = "0x18098D6F0")]
		protected bool IsTargetVisibleThisFrame()
		{
			return default(bool);
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006854")]
		[Address(RVA = "0xAA53B0", Offset = "0xAA45B0", VA = "0x180AA53B0")]
		protected void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006855")]
		[Address(RVA = "0xAA8230", Offset = "0xAA7430", VA = "0x180AA8230", Slot = "44")]
		protected virtual void TargetSpotted()
		{
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006856")]
		[Address(RVA = "0xAA51F0", Offset = "0xAA43F0", VA = "0x180AA51F0")]
		[ServerRpc(RequireOwnership = false)]
		public void NotifyServerTargetSeen()
		{
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x000196C8 File Offset: 0x000178C8
		[Token(Token = "0x6006857")]
		[Address(RVA = "0x7B11C0", Offset = "0x7B03C0", VA = "0x1807B11C0", Slot = "45")]
		protected virtual float GetSearchTime()
		{
			return 0f;
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006858")]
		[Address(RVA = "0xAA7F80", Offset = "0xAA7180", VA = "0x180AA7F80")]
		private void StartSearching()
		{
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006859")]
		[Address(RVA = "0xAA8120", Offset = "0xAA7320", VA = "0x180AA8120")]
		private void StopSearching()
		{
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600685A")]
		[Address(RVA = "0xAA6800", Offset = "0xAA5A00", VA = "0x180AA6800")]
		private IEnumerator SearchRoutine()
		{
			return null;
		}

		// Token: 0x0600685B RID: 26715 RVA: 0x000196E0 File Offset: 0x000178E0
		[Token(Token = "0x600685B")]
		[Address(RVA = "0xAA3E70", Offset = "0xAA3070", VA = "0x180AA3E70")]
		private Vector3 GetNextSearchLocation()
		{
			return default(Vector3);
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x000196F8 File Offset: 0x000178F8
		[Token(Token = "0x600685C")]
		[Address(RVA = "0xAA4C60", Offset = "0xAA3E60", VA = "0x180AA4C60", Slot = "46")]
		protected virtual bool IsTargetValid()
		{
			return default(bool);
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600685D")]
		[Address(RVA = "0xAA56A0", Offset = "0xAA48A0", VA = "0x180AA56A0")]
		private void RepositionToTargetMeleeRange(Vector3 origin)
		{
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x00019710 File Offset: 0x00017910
		[Token(Token = "0x600685E")]
		[Address(RVA = "0xAA43E0", Offset = "0xAA35E0", VA = "0x180AA43E0")]
		private bool GetRandomReachablePointNear(Vector3 originPoint, float randomRadius, out Vector3 randomPoint, float minDistance = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00019728 File Offset: 0x00017928
		[Token(Token = "0x600685F")]
		[Address(RVA = "0xAA3DE0", Offset = "0xAA2FE0", VA = "0x180AA3DE0")]
		protected float GetMinTargetDistance()
		{
			return 0f;
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00019740 File Offset: 0x00017940
		[Token(Token = "0x6006860")]
		[Address(RVA = "0xAA3D50", Offset = "0xAA2F50", VA = "0x180AA3D50")]
		protected float GetMaxTargetDistance()
		{
			return 0f;
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x00019758 File Offset: 0x00017958
		[Token(Token = "0x6006861")]
		[Address(RVA = "0xAA4930", Offset = "0xAA3B30", VA = "0x180AA4930")]
		protected bool IsTargetInRange([Optional] Vector3 origin)
		{
			return default(bool);
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006862")]
		[Address(RVA = "0xAA8500", Offset = "0xAA7700", VA = "0x180AA8500")]
		public CombatBehaviour()
		{
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006863")]
		[Address(RVA = "0xAA4FB0", Offset = "0xAA41B0", VA = "0x180AA4FB0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006864")]
		[Address(RVA = "0xAA4F90", Offset = "0xAA4190", VA = "0x180AA4F90", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006865")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006866")]
		[Address(RVA = "0xAA6570", Offset = "0xAA5770", VA = "0x180AA6570")]
		private void RpcWriter___Server_SetTargetAndEnable_Server_3323014238(NetworkObject target)
		{
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006867")]
		[Address(RVA = "0xAA5AD0", Offset = "0xAA4CD0", VA = "0x180AA5AD0")]
		public void RpcLogic___SetTargetAndEnable_Server_3323014238(NetworkObject target)
		{
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006868")]
		[Address(RVA = "0xAA5FA0", Offset = "0xAA51A0", VA = "0x180AA5FA0")]
		private void RpcReader___Server_SetTargetAndEnable_Server_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006869")]
		[Address(RVA = "0xAA62F0", Offset = "0xAA54F0", VA = "0x180AA62F0")]
		private void RpcWriter___Observers_SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686A")]
		[Address(RVA = "0xAA5B00", Offset = "0xAA4D00", VA = "0x180AA5B00")]
		protected void RpcLogic___SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686B")]
		[Address(RVA = "0xAA5E90", Offset = "0xAA5090", VA = "0x180AA5E90")]
		private void RpcReader___Observers_SetTarget_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686C")]
		[Address(RVA = "0xAA66A0", Offset = "0xAA58A0", VA = "0x180AA66A0")]
		private void RpcWriter___Target_SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686D")]
		[Address(RVA = "0xAA6030", Offset = "0xAA5230", VA = "0x180AA6030")]
		private void RpcReader___Target_SetTarget_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686E")]
		[Address(RVA = "0xAA6430", Offset = "0xAA5630", VA = "0x180AA6430")]
		private void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
		{
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686F")]
		[Address(RVA = "0xAA5B20", Offset = "0xAA4D20", VA = "0x180AA5B20", Slot = "47")]
		protected virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006870")]
		[Address(RVA = "0xAA5F10", Offset = "0xAA5110", VA = "0x180AA5F10")]
		private void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006871")]
		[Address(RVA = "0xAA61D0", Offset = "0xAA53D0", VA = "0x180AA61D0")]
		private void RpcWriter___Observers_ClearWeapon_2166136261()
		{
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006872")]
		[Address(RVA = "0xAA5910", Offset = "0xAA4B10", VA = "0x180AA5910")]
		protected void RpcLogic___ClearWeapon_2166136261()
		{
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006873")]
		[Address(RVA = "0xAA5E50", Offset = "0xAA5050", VA = "0x180AA5E50")]
		private void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006874")]
		[Address(RVA = "0xAA60B0", Offset = "0xAA52B0", VA = "0x180AA60B0")]
		private void RpcWriter___Observers_Attack_2166136261()
		{
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006875")]
		[Address(RVA = "0xAA5850", Offset = "0xAA4A50", VA = "0x180AA5850", Slot = "48")]
		protected virtual void RpcLogic___Attack_2166136261()
		{
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006876")]
		[Address(RVA = "0xAA5E10", Offset = "0xAA5010", VA = "0x180AA5E10")]
		private void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006877")]
		[Address(RVA = "0xAA51F0", Offset = "0xAA43F0", VA = "0x180AA51F0")]
		private void RpcWriter___Server_NotifyServerTargetSeen_2166136261()
		{
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006878")]
		[Address(RVA = "0xAA5AB0", Offset = "0xAA4CB0", VA = "0x180AA5AB0")]
		public void RpcLogic___NotifyServerTargetSeen_2166136261()
		{
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006879")]
		[Address(RVA = "0xAA5F70", Offset = "0xAA5170", VA = "0x180AA5F70")]
		private void RpcReader___Server_NotifyServerTargetSeen_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600687A")]
		[Address(RVA = "0xAA28A0", Offset = "0xAA1AA0", VA = "0x180AA28A0", Slot = "49")]
		protected virtual void Awake_UserLogic_ScheduleOne.Combat.CombatBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040049AB RID: 18859
		[Token(Token = "0x40049AB")]
		public const float RECENT_VISIBILITY_THRESHOLD = 3.5f;

		// Token: 0x040049AC RID: 18860
		[Token(Token = "0x40049AC")]
		public const float REPOSITION_TIME = 4f;

		// Token: 0x040049AD RID: 18861
		[Token(Token = "0x40049AD")]
		public const float SEARCH_RADIUS_MIN = 25f;

		// Token: 0x040049AE RID: 18862
		[Token(Token = "0x40049AE")]
		public const float SEARCH_RADIUS_MAX = 60f;

		// Token: 0x040049AF RID: 18863
		[Token(Token = "0x40049AF")]
		public const float SEARCH_SPEED = 0.4f;

		// Token: 0x040049B0 RID: 18864
		[Token(Token = "0x40049B0")]
		public const float CONSECUTIVE_MISS_ACCURACY_BOOST = 0.1f;

		// Token: 0x040049B1 RID: 18865
		[Token(Token = "0x40049B1")]
		public const float REACHED_DESTINATION_DISTANCE = 2f;

		// Token: 0x040049B2 RID: 18866
		[Token(Token = "0x40049B2")]
		public const float DelayBeforeFirstAttack = 0.25f;

		// Token: 0x040049B6 RID: 18870
		[Token(Token = "0x40049B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool DEBUG;

		// Token: 0x040049B7 RID: 18871
		[Token(Token = "0x40049B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[Header("General Setttings")]
		public float GiveUpRange;

		// Token: 0x040049B8 RID: 18872
		[Token(Token = "0x40049B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public int GiveUpAfterSuccessfulHits;

		// Token: 0x040049B9 RID: 18873
		[Token(Token = "0x40049B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public bool PlayAngryVO;

		// Token: 0x040049BA RID: 18874
		[Token(Token = "0x40049BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[Header("Movement settings")]
		[Range(0f, 1f)]
		public float DefaultMovementSpeed;

		// Token: 0x040049BB RID: 18875
		[Token(Token = "0x40049BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Header("Weapon settings")]
		public AvatarWeapon DefaultWeapon;

		// Token: 0x040049BC RID: 18876
		[Token(Token = "0x40049BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AvatarMeleeWeapon VirtualPunchWeapon;

		// Token: 0x040049BD RID: 18877
		[Token(Token = "0x40049BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[Header("Search settings")]
		public float DefaultSearchTime;

		// Token: 0x040049BE RID: 18878
		[Token(Token = "0x40049BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[Header("References")]
		public SmoothedVelocityCalculator TargetVelocityTracker;

		// Token: 0x040049BF RID: 18879
		[Token(Token = "0x40049BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[Header("Debug settings")]
		public bool CombatOnStart;

		// Token: 0x040049C0 RID: 18880
		[Token(Token = "0x40049C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public NetworkObject DebugTarget;

		// Token: 0x040049C3 RID: 18883
		[Token(Token = "0x40049C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		protected float timeSinceLastSighting;

		// Token: 0x040049C4 RID: 18884
		[Token(Token = "0x40049C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		protected Vector3 lastKnownTargetPosition;

		// Token: 0x040049C5 RID: 18885
		[Token(Token = "0x40049C5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private float timeSinceLastReposition;

		// Token: 0x040049C6 RID: 18886
		[Token(Token = "0x40049C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private float timeWithinAttackRange;

		// Token: 0x040049C7 RID: 18887
		[Token(Token = "0x40049C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private bool visionEventReceived;

		// Token: 0x040049C8 RID: 18888
		[Token(Token = "0x40049C8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float _timeOnCombatStart;

		// Token: 0x040049C9 RID: 18889
		[Token(Token = "0x40049C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected AvatarWeapon currentWeapon;

		// Token: 0x040049CA RID: 18890
		[Token(Token = "0x40049CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		protected int successfulHits;

		// Token: 0x040049CB RID: 18891
		[Token(Token = "0x40049CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		protected int consecutiveMissedShots;

		// Token: 0x040049CC RID: 18892
		[Token(Token = "0x40049CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		protected Coroutine rangedWeaponRoutine;

		// Token: 0x040049CD RID: 18893
		[Token(Token = "0x40049CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		protected Coroutine searchRoutine;

		// Token: 0x040049CE RID: 18894
		[Token(Token = "0x40049CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		protected Vector3 currentSearchDestination;

		// Token: 0x040049CF RID: 18895
		[Token(Token = "0x40049CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		protected bool hasSearchDestination;

		// Token: 0x040049D0 RID: 18896
		[Token(Token = "0x40049D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private float nextAngryVO;

		// Token: 0x040049D1 RID: 18897
		[Token(Token = "0x40049D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public Action onSuccessfulHit;

		// Token: 0x040049D2 RID: 18898
		[Token(Token = "0x40049D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040049D3 RID: 18899
		[Token(Token = "0x40049D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x229")]
		private bool NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted;
	}
}
