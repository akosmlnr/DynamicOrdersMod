using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Delivery;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.Money;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Tiles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Property
{
	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	public class Property : NetworkBehaviour, ISaveable
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000091F8 File Offset: 0x000073F8
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042C")]
		public bool IsOwned
		{
			[Token(Token = "0x6001555")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001556")]
			[Address(RVA = "0x5A4550", Offset = "0x5A3750", VA = "0x1805A4550")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042D")]
		public List<Employee> Employees
		{
			[Token(Token = "0x6001557")]
			[Address(RVA = "0x521AC0", Offset = "0x520CC0", VA = "0x180521AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001558")]
			[Address(RVA = "0x58D260", Offset = "0x58C460", VA = "0x18058D260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042E")]
		public RectTransform WorldspaceUIContainer
		{
			[Token(Token = "0x6001559")]
			[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600155A")]
			[Address(RVA = "0x5A45A0", Offset = "0x5A37A0", VA = "0x1805A45A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x00009210 File Offset: 0x00007410
		// (set) Token: 0x0600155C RID: 5468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042F")]
		public bool IsContentCulled
		{
			[Token(Token = "0x600155B")]
			[Address(RVA = "0x511360", Offset = "0x510560", VA = "0x180511360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600155C")]
			[Address(RVA = "0x5A4540", Offset = "0x5A3740", VA = "0x1805A4540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000430")]
		public string PropertyName
		{
			[Token(Token = "0x600155D")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000431")]
		public string PropertyCode
		{
			[Token(Token = "0x600155E")]
			[Address(RVA = "0x5A44D0", Offset = "0x5A36D0", VA = "0x1805A44D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x00009228 File Offset: 0x00007428
		// (set) Token: 0x06001560 RID: 5472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000432")]
		public float AmbientTemperature
		{
			[Token(Token = "0x600155F")]
			[Address(RVA = "0x5A4450", Offset = "0x5A3650", VA = "0x1805A4450")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001560")]
			[Address(RVA = "0x5A4500", Offset = "0x5A3700", VA = "0x1805A4500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x17000433")]
		public int LoadingDockCount
		{
			[Token(Token = "0x6001561")]
			[Address(RVA = "0x5A4490", Offset = "0x5A3690", VA = "0x1805A4490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000434")]
		public PropertyContentsContainer Container
		{
			[Token(Token = "0x6001562")]
			[Address(RVA = "0x5A4460", Offset = "0x5A3660", VA = "0x1805A4460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001563")]
			[Address(RVA = "0x5A4510", Offset = "0x5A3710", VA = "0x1805A4510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000435")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001564")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000436")]
		public string SaveFileName
		{
			[Token(Token = "0x6001565")]
			[Address(RVA = "0x5A44E0", Offset = "0x5A36E0", VA = "0x1805A44E0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000437")]
		public Loader Loader
		{
			[Token(Token = "0x6001566")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3680", VA = "0x1805A4480", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x17000438")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001567")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000439")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001568")]
			[Address(RVA = "0x5A44B0", Offset = "0x5A36B0", VA = "0x1805A44B0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001569")]
			[Address(RVA = "0x5A4560", Offset = "0x5A3760", VA = "0x1805A4560", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700043A")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x600156A")]
			[Address(RVA = "0x5A44C0", Offset = "0x5A36C0", VA = "0x1805A44C0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600156B")]
			[Address(RVA = "0x5A4580", Offset = "0x5A3780", VA = "0x1805A4580", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00009270 File Offset: 0x00007470
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700043B")]
		public bool HasChanged
		{
			[Token(Token = "0x600156C")]
			[Address(RVA = "0x5A4470", Offset = "0x5A3670", VA = "0x1805A4470", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600156D")]
			[Address(RVA = "0x5A4530", Offset = "0x5A3730", VA = "0x1805A4530", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x5A0E70", Offset = "0x5A0070", VA = "0x1805A0E70", Slot = "42")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x5A1810", Offset = "0x5A0A10", VA = "0x1805A1810", Slot = "43")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x5A38E0", Offset = "0x5A2AE0", VA = "0x1805A38E0", Slot = "44")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001571")]
		[Address(RVA = "0x5A1010", Offset = "0x5A0210", VA = "0x1805A1010", Slot = "45")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x5A00A0", Offset = "0x59F2A0", VA = "0x1805A00A0")]
		public void AddConfigurable(IConfigurable configurable)
		{
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x5A2860", Offset = "0x5A1A60", VA = "0x1805A2860")]
		public void RemoveConfigurable(IConfigurable configurable)
		{
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x5A3C80", Offset = "0x5A2E80", VA = "0x1805A3C80")]
		private void UpdateCulling()
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x5A1FF0", Offset = "0x5A11F0", VA = "0x1805A1FF0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x5A1DD0", Offset = "0x5A0FD0", VA = "0x1805A1DD0", Slot = "46")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x5A11A0", Offset = "0x5A03A0", VA = "0x1805A11A0", Slot = "47")]
		protected virtual void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x5A2100", Offset = "0x5A1300", VA = "0x1805A2100", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x5A3520", Offset = "0x5A2720", VA = "0x1805A3520")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected void SetOwned_Server()
		{
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x5A21C0", Offset = "0x5A13C0", VA = "0x1805A21C0")]
		[ObserversRpc(RunLocally = true, BufferLast = true)]
		private void ReceiveOwned_Networked()
		{
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x5A22F0", Offset = "0x5A14F0", VA = "0x1805A22F0", Slot = "48")]
		protected virtual void RecieveOwned()
		{
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x5A3890", Offset = "0x5A2A90", VA = "0x1805A3890", Slot = "49")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x5A3630", Offset = "0x5A2830", VA = "0x1805A3630")]
		public void SetOwned()
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void SetBoundsVisible(bool vis)
		{
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "50")]
		public virtual bool CanBePurchased()
		{
			return default(bool);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x5A32F0", Offset = "0x5A24F0", VA = "0x1805A32F0", Slot = "51")]
		public virtual void SetContentCulled(bool culled)
		{
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x5A2700", Offset = "0x5A1900", VA = "0x1805A2700")]
		public int RegisterEmployee(Employee emp)
		{
			return 0;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x5A0EC0", Offset = "0x5A00C0", VA = "0x1805A0EC0")]
		public void DeregisterEmployee(Employee emp)
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x5A3A40", Offset = "0x5A2C40", VA = "0x1805A3A40")]
		private void ToggleableActioned(InteractableToggleable toggleable)
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x5A2F00", Offset = "0x5A2100", VA = "0x1805A2F00")]
		[ServerRpc(RequireOwnership = false)]
		public void SendToggleableState(int index, bool state)
		{
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x5A3640", Offset = "0x5A2840", VA = "0x1805A3640")]
		[TargetRpc]
		[ObserversRpc]
		public void SetToggleableState(NetworkConnection conn, int index, bool state)
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x59FF60", Offset = "0x59F160", VA = "0x18059FF60")]
		public void AddBuildableItem(BuildableItem item)
		{
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x5A27D0", Offset = "0x5A19D0", VA = "0x1805A27D0")]
		public void RemoveBuildableItem(BuildableItem item)
		{
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x5A1360", Offset = "0x5A0560", VA = "0x1805A1360", Slot = "52")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x5A1020", Offset = "0x5A0220", VA = "0x1805A1020")]
		protected List<DynamicSaveData> GetEmployeeSaveDatas()
		{
			return null;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x5A11E0", Offset = "0x5A03E0", VA = "0x1805A11E0")]
		protected List<DynamicSaveData> GetObjectSaveDatas()
		{
			return null;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x5A3F10", Offset = "0x5A3110", VA = "0x1805A3F10", Slot = "53")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "54")]
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x5A1A70", Offset = "0x5A0C70", VA = "0x1805A1A70", Slot = "55")]
		public virtual void Load(PropertyData propertyData, string dataString)
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x5A0F20", Offset = "0x5A0120", VA = "0x1805A0F20")]
		public bool DoBoundsContainPoint(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x5A18A0", Offset = "0x5A0AA0", VA = "0x1805A18A0")]
		private bool IsPointInsideBox(Vector3 worldPoint, BoxCollider box)
		{
			return default(bool);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x5A16B0", Offset = "0x5A08B0", VA = "0x1805A16B0")]
		public List<Bed> GetUnassignedBeds()
		{
			return null;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001591")]
		public List<T> GetBuildablesOfType<T>() where T : BuildableItem
		{
			return null;
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "56")]
		public virtual bool CanDeliverToProperty()
		{
			return default(bool);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "57")]
		public virtual bool CanRespawnInsideProperty()
		{
			return default(bool);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x5A4100", Offset = "0x5A3300", VA = "0x1805A4100")]
		public Property()
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x5A3C10", Offset = "0x5A2E10", VA = "0x1805A3C10")]
		[CompilerGenerated]
		private IEnumerator <RecieveOwned>g__Wait|100_0()
		{
			return null;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x5A1C20", Offset = "0x5A0E20", VA = "0x1805A1C20", Slot = "58")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x5A1C00", Offset = "0x5A0E00", VA = "0x1805A1C00", Slot = "59")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x595D90", Offset = "0x594F90", VA = "0x180595D90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x5A3070", Offset = "0x5A2270", VA = "0x1805A3070")]
		private void RpcWriter___Server_SetOwned_Server_2166136261()
		{
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x5A21C0", Offset = "0x5A13C0", VA = "0x1805A21C0")]
		protected void RpcLogic___SetOwned_Server_2166136261()
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x5A2B60", Offset = "0x5A1D60", VA = "0x1805A2B60")]
		private void RpcReader___Server_SetOwned_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x5A2C60", Offset = "0x5A1E60", VA = "0x1805A2C60")]
		private void RpcWriter___Observers_ReceiveOwned_Networked_2166136261()
		{
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x5A28F0", Offset = "0x5A1AF0", VA = "0x1805A28F0")]
		private void RpcLogic___ReceiveOwned_Networked_2166136261()
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x5A29B0", Offset = "0x5A1BB0", VA = "0x1805A29B0")]
		private void RpcReader___Observers_ReceiveOwned_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x5A2F00", Offset = "0x5A2100", VA = "0x1805A2F00")]
		private void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state)
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x5A2910", Offset = "0x5A1B10", VA = "0x1805A2910")]
		public void RpcLogic___SendToggleableState_3658436649(int index, bool state)
		{
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x5A2AB0", Offset = "0x5A1CB0", VA = "0x1805A2AB0")]
		private void RpcReader___Server_SendToggleableState_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x5A2D80", Offset = "0x5A1F80", VA = "0x1805A2D80")]
		private void RpcWriter___Observers_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x5A2930", Offset = "0x5A1B30", VA = "0x1805A2930")]
		public void RpcLogic___SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x5A2A00", Offset = "0x5A1C00", VA = "0x1805A2A00")]
		private void RpcReader___Observers_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x5A3180", Offset = "0x5A2380", VA = "0x1805A3180")]
		private void RpcWriter___Target_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x5A2BB0", Offset = "0x5A1DB0", VA = "0x1805A2BB0")]
		private void RpcReader___Target_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x5A0180", Offset = "0x59F380", VA = "0x1805A0180", Slot = "60")]
		protected virtual void Awake_UserLogic_ScheduleOne.Property.Property_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400130F RID: 4879
		[Token(Token = "0x400130F")]
		[FieldOffset(Offset = "0x0")]
		public static List<Property> Properties;

		// Token: 0x04001310 RID: 4880
		[Token(Token = "0x4001310")]
		[FieldOffset(Offset = "0x8")]
		public static List<Property> UnownedProperties;

		// Token: 0x04001311 RID: 4881
		[Token(Token = "0x4001311")]
		[FieldOffset(Offset = "0x10")]
		public static List<Property> OwnedProperties;

		// Token: 0x04001312 RID: 4882
		[Token(Token = "0x4001312")]
		[FieldOffset(Offset = "0x18")]
		public static Property.PropertyChange onPropertyAcquired;

		// Token: 0x04001313 RID: 4883
		[Token(Token = "0x4001313")]
		[FieldOffset(Offset = "0x118")]
		public UnityEvent onThisPropertyAcquired;

		// Token: 0x04001318 RID: 4888
		[Token(Token = "0x4001318")]
		[FieldOffset(Offset = "0x140")]
		[Header("Settings")]
		[SerializeField]
		protected string propertyName;

		// Token: 0x04001319 RID: 4889
		[Token(Token = "0x4001319")]
		[FieldOffset(Offset = "0x148")]
		public bool AvailableInDemo;

		// Token: 0x0400131A RID: 4890
		[Token(Token = "0x400131A")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		protected string propertyCode;

		// Token: 0x0400131B RID: 4891
		[Token(Token = "0x400131B")]
		[FieldOffset(Offset = "0x158")]
		public float Price;

		// Token: 0x0400131C RID: 4892
		[Token(Token = "0x400131C")]
		[FieldOffset(Offset = "0x15C")]
		public float DefaultRotation;

		// Token: 0x0400131D RID: 4893
		[Token(Token = "0x400131D")]
		[FieldOffset(Offset = "0x160")]
		public int EmployeeCapacity;

		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x400131E")]
		[FieldOffset(Offset = "0x164")]
		public bool OwnedByDefault;

		// Token: 0x0400131F RID: 4895
		[Token(Token = "0x400131F")]
		[FieldOffset(Offset = "0x168")]
		public string IsOwnedVariable;

		// Token: 0x04001321 RID: 4897
		[Token(Token = "0x4001321")]
		[FieldOffset(Offset = "0x174")]
		[Header("Culling Settings")]
		public bool ContentCullingEnabled;

		// Token: 0x04001322 RID: 4898
		[Token(Token = "0x4001322")]
		[FieldOffset(Offset = "0x178")]
		public float MinimumCullingDistance;

		// Token: 0x04001323 RID: 4899
		[Token(Token = "0x4001323")]
		[FieldOffset(Offset = "0x180")]
		public GameObject[] ObjectsToCull;

		// Token: 0x04001324 RID: 4900
		[Token(Token = "0x4001324")]
		[FieldOffset(Offset = "0x188")]
		[Header("References")]
		public Transform EmployeeContainer;

		// Token: 0x04001325 RID: 4901
		[Token(Token = "0x4001325")]
		[FieldOffset(Offset = "0x190")]
		public Transform SpawnPoint;

		// Token: 0x04001326 RID: 4902
		[Token(Token = "0x4001326")]
		[FieldOffset(Offset = "0x198")]
		public Transform InteriorSpawnPoint;

		// Token: 0x04001327 RID: 4903
		[Token(Token = "0x4001327")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject ForSaleSign;

		// Token: 0x04001328 RID: 4904
		[Token(Token = "0x4001328")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject BoundingBox;

		// Token: 0x04001329 RID: 4905
		[Token(Token = "0x4001329")]
		[FieldOffset(Offset = "0x1B0")]
		public POI PoI;

		// Token: 0x0400132A RID: 4906
		[Token(Token = "0x400132A")]
		[FieldOffset(Offset = "0x1B8")]
		public Transform ListingPoster;

		// Token: 0x0400132B RID: 4907
		[Token(Token = "0x400132B")]
		[FieldOffset(Offset = "0x1C0")]
		public Transform NPCSpawnPoint;

		// Token: 0x0400132C RID: 4908
		[Token(Token = "0x400132C")]
		[FieldOffset(Offset = "0x1C8")]
		public Transform[] EmployeeIdlePoints;

		// Token: 0x0400132D RID: 4909
		[Token(Token = "0x400132D")]
		[FieldOffset(Offset = "0x1D0")]
		public List<ModularSwitch> Switches;

		// Token: 0x0400132E RID: 4910
		[Token(Token = "0x400132E")]
		[FieldOffset(Offset = "0x1D8")]
		public List<InteractableToggleable> Toggleables;

		// Token: 0x0400132F RID: 4911
		[Token(Token = "0x400132F")]
		[FieldOffset(Offset = "0x1E0")]
		public PropertyDisposalArea DisposalArea;

		// Token: 0x04001330 RID: 4912
		[Token(Token = "0x4001330")]
		[FieldOffset(Offset = "0x1E8")]
		public LoadingDock[] LoadingDocks;

		// Token: 0x04001332 RID: 4914
		[Token(Token = "0x4001332")]
		[FieldOffset(Offset = "0x1F8")]
		[HideInInspector]
		protected List<BuildableItem> BuildableItems;

		// Token: 0x04001333 RID: 4915
		[Token(Token = "0x4001333")]
		[FieldOffset(Offset = "0x200")]
		public List<IConfigurable> Configurables;

		// Token: 0x04001334 RID: 4916
		[Token(Token = "0x4001334")]
		[FieldOffset(Offset = "0x208")]
		public readonly List<Grid> Grids;

		// Token: 0x04001335 RID: 4917
		[Token(Token = "0x4001335")]
		[FieldOffset(Offset = "0x210")]
		protected BoxCollider[] propertyBoundsColliders;

		// Token: 0x04001336 RID: 4918
		[Token(Token = "0x4001336")]
		[FieldOffset(Offset = "0x218")]
		private PropertyLoader loader;

		// Token: 0x0400133A RID: 4922
		[Token(Token = "0x400133A")]
		[FieldOffset(Offset = "0x238")]
		private List<string> savedObjectPaths;

		// Token: 0x0400133B RID: 4923
		[Token(Token = "0x400133B")]
		[FieldOffset(Offset = "0x240")]
		private List<string> savedEmployeePaths;

		// Token: 0x0400133C RID: 4924
		[Token(Token = "0x400133C")]
		[FieldOffset(Offset = "0x248")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted;

		// Token: 0x0400133D RID: 4925
		[Token(Token = "0x400133D")]
		[FieldOffset(Offset = "0x249")]
		private bool NetworkInitialize__LateScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted;

		// Token: 0x02000363 RID: 867
		// (Invoke) Token: 0x060015AC RID: 5548
		[Token(Token = "0x2000363")]
		public delegate void PropertyChange(Property property);
	}
}
