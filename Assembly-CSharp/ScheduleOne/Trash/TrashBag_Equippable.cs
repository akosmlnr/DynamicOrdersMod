using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Trash
{
	// Token: 0x020007C8 RID: 1992
	[Token(Token = "0x20007C8")]
	public class TrashBag_Equippable : Equippable_Viewmodel
	{
		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x0000FF18 File Offset: 0x0000E118
		[Token(Token = "0x17000863")]
		public static bool IsHoveringTrash
		{
			[Token(Token = "0x600352C")]
			[Address(RVA = "0x7D28D0", Offset = "0x7D1AD0", VA = "0x1807D28D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x0000FF30 File Offset: 0x0000E130
		// (set) Token: 0x0600352E RID: 13614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000864")]
		public bool IsBaggingTrash
		{
			[Token(Token = "0x600352D")]
			[Address(RVA = "0x4C0320", Offset = "0x4BF520", VA = "0x1804C0320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600352E")]
			[Address(RVA = "0x594500", Offset = "0x593700", VA = "0x180594500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x0000FF48 File Offset: 0x0000E148
		// (set) Token: 0x06003530 RID: 13616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000865")]
		public bool IsPickingUpTrash
		{
			[Token(Token = "0x600352F")]
			[Address(RVA = "0x7D2960", Offset = "0x7D1B60", VA = "0x1807D2960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003530")]
			[Address(RVA = "0x7D2970", Offset = "0x7D1B70", VA = "0x1807D2970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x7D10D0", Offset = "0x7D02D0", VA = "0x1807D10D0", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003532")]
		[Address(RVA = "0x7D1E40", Offset = "0x7D1040", VA = "0x1807D1E40", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003533")]
		[Address(RVA = "0x7D1F10", Offset = "0x7D1110", VA = "0x1807D1F10", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003534")]
		[Address(RVA = "0x7D1390", Offset = "0x7D0590", VA = "0x1807D1390")]
		private TrashContainer GetHoveredTrashContainer()
		{
			return null;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x0000FF60 File Offset: 0x0000E160
		[Token(Token = "0x6003535")]
		[Address(RVA = "0x7D17B0", Offset = "0x7D09B0", VA = "0x1807D17B0")]
		private bool RaycastLook(out RaycastHit hit)
		{
			return default(bool);
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0000FF78 File Offset: 0x0000E178
		[Token(Token = "0x6003536")]
		[Address(RVA = "0x7D1720", Offset = "0x7D0920", VA = "0x1807D1720")]
		private bool IsPickupLocationValid(RaycastHit hit)
		{
			return default(bool);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003537")]
		[Address(RVA = "0x7D1530", Offset = "0x7D0730", VA = "0x1807D1530")]
		private List<TrashItem> GetTrashItemsAtPoint(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003538")]
		[Address(RVA = "0x7D1860", Offset = "0x7D0A60", VA = "0x1807D1860")]
		private void StartBagTrash(TrashContainer container)
		{
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003539")]
		[Address(RVA = "0x7D1900", Offset = "0x7D0B00", VA = "0x1807D1900")]
		private void StopBagTrash(bool complete)
		{
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600353A")]
		[Address(RVA = "0x7D18C0", Offset = "0x7D0AC0", VA = "0x1807D18C0")]
		private void StartPickup()
		{
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600353B")]
		[Address(RVA = "0x7D19A0", Offset = "0x7D0BA0", VA = "0x1807D19A0")]
		private void StopPickup(bool complete)
		{
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600353C")]
		[Address(RVA = "0x5944E0", Offset = "0x5936E0", VA = "0x1805944E0")]
		public TrashBag_Equippable()
		{
		}

		// Token: 0x040026B2 RID: 9906
		[Token(Token = "0x40026B2")]
		public const float TRASH_CONTAINER_INTERACT_DISTANCE = 2.75f;

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		public const float BAG_TRASH_TIME = 1f;

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		public const float PICKUP_RANGE = 3f;

		// Token: 0x040026B5 RID: 9909
		[Token(Token = "0x40026B5")]
		public const float PICKUP_AREA_RADIUS = 0.5f;

		// Token: 0x040026B8 RID: 9912
		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x64")]
		public LayerMask PickupLookMask;

		// Token: 0x040026B9 RID: 9913
		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public DecalProjector PickupAreaProjector;

		// Token: 0x040026BA RID: 9914
		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0x70")]
		public AudioSourceController RustleSound;

		// Token: 0x040026BB RID: 9915
		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x78")]
		public AudioSourceController BagSound;

		// Token: 0x040026BC RID: 9916
		[Token(Token = "0x40026BC")]
		[FieldOffset(Offset = "0x80")]
		private float _bagTrashTime;

		// Token: 0x040026BD RID: 9917
		[Token(Token = "0x40026BD")]
		[FieldOffset(Offset = "0x88")]
		private TrashContainer _baggedContainer;

		// Token: 0x040026BE RID: 9918
		[Token(Token = "0x40026BE")]
		[FieldOffset(Offset = "0x90")]
		private float _pickupTrashTime;
	}
}
