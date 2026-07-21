using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200094E RID: 2382
	[Token(Token = "0x200094E")]
	public class Equippable_TrashGrabber : Equippable_Viewmodel
	{
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003FC5 RID: 16325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EE")]
		public static Equippable_TrashGrabber Instance
		{
			[Token(Token = "0x6003FC4")]
			[Address(RVA = "0x859AC0", Offset = "0x858CC0", VA = "0x180859AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FC5")]
			[Address(RVA = "0x859B80", Offset = "0x858D80", VA = "0x180859B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x170009EF")]
		public static bool IsEquipped
		{
			[Token(Token = "0x6003FC6")]
			[Address(RVA = "0x859B00", Offset = "0x858D00", VA = "0x180859B00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06003FC7 RID: 16327 RVA: 0x00012240 File Offset: 0x00010440
		// (set) Token: 0x06003FC8 RID: 16328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F0")]
		private float currentDropTime
		{
			[Token(Token = "0x6003FC7")]
			[Address(RVA = "0x4F0950", Offset = "0x4EFB50", VA = "0x1804F0950")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003FC8")]
			[Address(RVA = "0x859BE0", Offset = "0x858DE0", VA = "0x180859BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06003FC9 RID: 16329 RVA: 0x00012258 File Offset: 0x00010458
		// (set) Token: 0x06003FCA RID: 16330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F1")]
		private float timeSinceLastDrop
		{
			[Token(Token = "0x6003FC9")]
			[Address(RVA = "0x4F0A20", Offset = "0x4EFC20", VA = "0x1804F0A20")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003FCA")]
			[Address(RVA = "0x859BF0", Offset = "0x858DF0", VA = "0x180859BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x858D20", Offset = "0x857F20", VA = "0x180858D20", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCC")]
		[Address(RVA = "0x859400", Offset = "0x858600", VA = "0x180859400", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCD")]
		[Address(RVA = "0x859560", Offset = "0x858760", VA = "0x180859560", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x858970", Offset = "0x857B70", VA = "0x180858970")]
		private void EjectTrash()
		{
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x859040", Offset = "0x858240", VA = "0x180859040")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x859110", Offset = "0x858310", VA = "0x180859110")]
		public void PickupTrash(TrashItem item)
		{
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00012270 File Offset: 0x00010470
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x859010", Offset = "0x858210", VA = "0x180859010")]
		public int GetCapacity()
		{
			return 0;
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x8591A0", Offset = "0x8583A0", VA = "0x1808591A0")]
		private void RefreshVisuals()
		{
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x859A40", Offset = "0x858C40", VA = "0x180859A40")]
		public Equippable_TrashGrabber()
		{
		}

		// Token: 0x04002E6F RID: 11887
		[Token(Token = "0x4002E6F")]
		public const float TrashDropSpacing = 0.15f;

		// Token: 0x04002E70 RID: 11888
		[Token(Token = "0x4002E70")]
		[FieldOffset(Offset = "0x60")]
		[Header("References")]
		public Transform TrashContent;

		// Token: 0x04002E71 RID: 11889
		[Token(Token = "0x4002E71")]
		[FieldOffset(Offset = "0x68")]
		public Transform TrashContent_Min;

		// Token: 0x04002E72 RID: 11890
		[Token(Token = "0x4002E72")]
		[FieldOffset(Offset = "0x70")]
		public Transform TrashContent_Max;

		// Token: 0x04002E73 RID: 11891
		[Token(Token = "0x4002E73")]
		[FieldOffset(Offset = "0x78")]
		public Animation GrabAnim;

		// Token: 0x04002E74 RID: 11892
		[Token(Token = "0x4002E74")]
		[FieldOffset(Offset = "0x80")]
		public Transform Bin;

		// Token: 0x04002E75 RID: 11893
		[Token(Token = "0x4002E75")]
		[FieldOffset(Offset = "0x88")]
		public Transform BinRaisedPosition;

		// Token: 0x04002E76 RID: 11894
		[Token(Token = "0x4002E76")]
		[FieldOffset(Offset = "0x90")]
		public AudioSourceController TrashDropSound;

		// Token: 0x04002E77 RID: 11895
		[Token(Token = "0x4002E77")]
		[FieldOffset(Offset = "0x98")]
		[Header("Settings")]
		public float DropTime;

		// Token: 0x04002E78 RID: 11896
		[Token(Token = "0x4002E78")]
		[FieldOffset(Offset = "0x9C")]
		public float DropForce;

		// Token: 0x04002E79 RID: 11897
		[Token(Token = "0x4002E79")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 TrashDropOffset;

		// Token: 0x04002E7A RID: 11898
		[Token(Token = "0x4002E7A")]
		[FieldOffset(Offset = "0xB0")]
		public UnityEvent onPickup;

		// Token: 0x04002E7D RID: 11901
		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0xC0")]
		private TrashGrabberInstance trashGrabberInstance;

		// Token: 0x04002E7E RID: 11902
		[Token(Token = "0x4002E7E")]
		[FieldOffset(Offset = "0xC8")]
		private Pose defaultBinPosition;

		// Token: 0x04002E7F RID: 11903
		[Token(Token = "0x4002E7F")]
		[FieldOffset(Offset = "0xE4")]
		private Vector3 defaultBinScale;
	}
}
