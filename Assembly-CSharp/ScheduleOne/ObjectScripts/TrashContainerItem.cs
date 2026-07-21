using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009DC RID: 2524
	[Token(Token = "0x20009DC")]
	[RequireComponent(typeof(TrashContainer))]
	public class TrashContainerItem : GridItem, ITransitEntity
	{
		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B52")]
		public string Name
		{
			[Token(Token = "0x6004857")]
			[Address(RVA = "0x834FB0", Offset = "0x8341B0", VA = "0x180834FB0", Slot = "71")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004859 RID: 18521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B53")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6004858")]
			[Address(RVA = "0x803790", Offset = "0x802990", VA = "0x180803790", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004859")]
			[Address(RVA = "0x803930", Offset = "0x802B30", VA = "0x180803930", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600485B RID: 18523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B54")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x600485A")]
			[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600485B")]
			[Address(RVA = "0x66C040", Offset = "0x66B240", VA = "0x18066C040", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B55")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x600485C")]
			[Address(RVA = "0x4E0C70", Offset = "0x4DFE70", VA = "0x1804E0C70", Slot = "76")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000B56")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x600485D")]
			[Address(RVA = "0x66B670", Offset = "0x66A870", VA = "0x18066B670", Slot = "77")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x17000B57")]
		public bool Selectable
		{
			[Token(Token = "0x600485E")]
			[Address(RVA = "0x914B60", Offset = "0x913D60", VA = "0x180914B60", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x000139B0 File Offset: 0x00011BB0
		// (set) Token: 0x06004860 RID: 18528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B58")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x600485F")]
			[Address(RVA = "0x914B50", Offset = "0x913D50", VA = "0x180914B50", Slot = "79")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004860")]
			[Address(RVA = "0x914B70", Offset = "0x913D70", VA = "0x180914B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004861")]
		[Address(RVA = "0x913940", Offset = "0x912B40", VA = "0x180913940", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004862")]
		[Address(RVA = "0x914700", Offset = "0x913900", VA = "0x180914700", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004863")]
		[Address(RVA = "0x913F20", Offset = "0x913120", VA = "0x180913F20", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004864")]
		[Address(RVA = "0x914960", Offset = "0x913B60", VA = "0x180914960")]
		private void TrashLevelChanged()
		{
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x000139C8 File Offset: 0x00011BC8
		[Token(Token = "0x6004865")]
		[Address(RVA = "0x913A20", Offset = "0x912C20", VA = "0x180913A20", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004866")]
		[Address(RVA = "0x913DB0", Offset = "0x912FB0", VA = "0x180913DB0", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004867")]
		[Address(RVA = "0x914820", Offset = "0x913A20", VA = "0x180914820")]
		private void TrashAdded(string trashID)
		{
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004868")]
		[Address(RVA = "0x9146C0", Offset = "0x9138C0", VA = "0x1809146C0", Slot = "57")]
		public override void ShowOutline(Color color)
		{
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004869")]
		[Address(RVA = "0x913EE0", Offset = "0x9130E0", VA = "0x180913EE0", Slot = "58")]
		public override void HideOutline()
		{
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486A")]
		[Address(RVA = "0x913AB0", Offset = "0x912CB0", VA = "0x180913AB0")]
		private void CheckTrashItems()
		{
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486B")]
		[Address(RVA = "0x913650", Offset = "0x912850", VA = "0x180913650")]
		private void AddTrashToRadius(TrashItem trashItem)
		{
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486C")]
		[Address(RVA = "0x913490", Offset = "0x912690", VA = "0x180913490")]
		private void AddTrashBagToRadius(TrashBag trashBag)
		{
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486D")]
		[Address(RVA = "0x9143A0", Offset = "0x9135A0", VA = "0x1809143A0")]
		private void RemoveTrashItemFromRadius(TrashItem trashItem)
		{
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486E")]
		[Address(RVA = "0x914240", Offset = "0x913440", VA = "0x180914240")]
		private void RemoveTrashBagFromRadius(TrashBag trashBag)
		{
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x000139E0 File Offset: 0x00011BE0
		[Token(Token = "0x600486F")]
		[Address(RVA = "0x9140D0", Offset = "0x9132D0", VA = "0x1809140D0")]
		private bool IsTrashValid(TrashItem trashItem)
		{
			return default(bool);
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x000139F8 File Offset: 0x00011BF8
		[Token(Token = "0x6004870")]
		[Address(RVA = "0x913FE0", Offset = "0x9131E0", VA = "0x180913FE0")]
		public bool IsPointInPickupZone(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004871")]
		[Address(RVA = "0x9149F0", Offset = "0x913BF0", VA = "0x1809149F0")]
		public TrashContainerItem()
		{
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004872")]
		[Address(RVA = "0x914220", Offset = "0x913420", VA = "0x180914220", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004873")]
		[Address(RVA = "0x914200", Offset = "0x913400", VA = "0x180914200", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004874")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004875")]
		[Address(RVA = "0x913890", Offset = "0x912A90", VA = "0x180913890", Slot = "93")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.TrashContainerItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003325 RID: 13093
		[Token(Token = "0x4003325")]
		public const float MAX_VERTICAL_OFFSET = 2f;

		// Token: 0x04003326 RID: 13094
		[Token(Token = "0x4003326")]
		[FieldOffset(Offset = "0x210")]
		public TrashContainer Container;

		// Token: 0x04003327 RID: 13095
		[Token(Token = "0x4003327")]
		[FieldOffset(Offset = "0x218")]
		public ParticleSystem Flies;

		// Token: 0x04003328 RID: 13096
		[Token(Token = "0x4003328")]
		[FieldOffset(Offset = "0x220")]
		public AudioSourceController TrashAddedSound;

		// Token: 0x04003329 RID: 13097
		[Token(Token = "0x4003329")]
		[FieldOffset(Offset = "0x228")]
		public DecalProjector PickupAreaProjector;

		// Token: 0x0400332A RID: 13098
		[Token(Token = "0x400332A")]
		[FieldOffset(Offset = "0x230")]
		public Transform[] accessPoints;

		// Token: 0x0400332B RID: 13099
		[Token(Token = "0x400332B")]
		[FieldOffset(Offset = "0x238")]
		[Header("Pickup settings")]
		public bool UsableByCleaners;

		// Token: 0x0400332C RID: 13100
		[Token(Token = "0x400332C")]
		[FieldOffset(Offset = "0x23C")]
		public float PickupSquareWidth;

		// Token: 0x04003331 RID: 13105
		[Token(Token = "0x4003331")]
		[FieldOffset(Offset = "0x258")]
		public List<TrashItem> TrashItemsInRadius;

		// Token: 0x04003332 RID: 13106
		[Token(Token = "0x4003332")]
		[FieldOffset(Offset = "0x260")]
		public List<TrashBag> TrashBagsInRadius;

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		[FieldOffset(Offset = "0x268")]
		private float calculatedPickupRadius;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		[FieldOffset(Offset = "0x26C")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		[FieldOffset(Offset = "0x26D")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted;
	}
}
