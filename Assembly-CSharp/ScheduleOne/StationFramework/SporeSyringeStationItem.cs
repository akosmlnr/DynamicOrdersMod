using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008F2 RID: 2290
	[Token(Token = "0x20008F2")]
	public class SporeSyringeStationItem : StationItem
	{
		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06003D6E RID: 15726 RVA: 0x00011A30 File Offset: 0x0000FC30
		// (set) Token: 0x06003D6F RID: 15727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009AB")]
		public float PlungerPosition
		{
			[Token(Token = "0x6003D6E")]
			[Address(RVA = "0x7C2200", Offset = "0x7C1400", VA = "0x1807C2200")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003D6F")]
			[Address(RVA = "0x7C2FF0", Offset = "0x7C21F0", VA = "0x1807C2FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D70")]
		[Address(RVA = "0x84D1C0", Offset = "0x84C3C0", VA = "0x18084D1C0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D71")]
		[Address(RVA = "0x84D820", Offset = "0x84CA20", VA = "0x18084D820")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x84E3A0", Offset = "0x84D5A0", VA = "0x18084E3A0")]
		public void SetCapInteractable(bool interactable)
		{
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D73")]
		[Address(RVA = "0x6747C0", Offset = "0x6739C0", VA = "0x1806747C0")]
		public void SetInjectionPortCollider(Collider collider)
		{
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D74")]
		[Address(RVA = "0x84E170", Offset = "0x84D370", VA = "0x18084E170")]
		private void RemoveCap()
		{
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D75")]
		[Address(RVA = "0x84E5D0", Offset = "0x84D7D0", VA = "0x18084E5D0")]
		public void SetSyringeDraggable(bool draggable)
		{
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D76")]
		[Address(RVA = "0x84DE60", Offset = "0x84D060", VA = "0x18084DE60")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D77")]
		[Address(RVA = "0x84D780", Offset = "0x84C980", VA = "0x18084D780")]
		private void InsertSyringe()
		{
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D78")]
		[Address(RVA = "0x84E3E0", Offset = "0x84D5E0", VA = "0x18084E3E0")]
		public void SetPlungerInteractable(bool interactable)
		{
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D79")]
		[Address(RVA = "0x84E400", Offset = "0x84D600", VA = "0x18084E400")]
		private void SetPlungerPosition(float position)
		{
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x84DDE0", Offset = "0x84CFE0", VA = "0x18084DDE0")]
		private void OnPlungerClickStart(RaycastHit hit)
		{
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0x84DDB0", Offset = "0x84CFB0", VA = "0x18084DDB0")]
		private void OnPlungerClickEnd()
		{
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00011A48 File Offset: 0x0000FC48
		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0x84D3B0", Offset = "0x84C5B0", VA = "0x18084D3B0")]
		private Vector3 GetPlungerPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7D")]
		[Address(RVA = "0x817C60", Offset = "0x816E60", VA = "0x180817C60")]
		public SporeSyringeStationItem()
		{
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0x84E690", Offset = "0x84D890", VA = "0x18084E690")]
		[CompilerGenerated]
		private IEnumerator <InsertSyringe>g__MoveSyringe|32_0()
		{
			return null;
		}

		// Token: 0x04002CF3 RID: 11507
		[Token(Token = "0x4002CF3")]
		public const float MaxAngleDifferenceForInjection = 35f;

		// Token: 0x04002CF4 RID: 11508
		[Token(Token = "0x4002CF4")]
		public const float PlungerPushSpeed = 0.8f;

		// Token: 0x04002CF5 RID: 11509
		[Token(Token = "0x4002CF5")]
		public const float PlungerDragDistanceMultiplier = 2f;

		// Token: 0x04002CF6 RID: 11510
		[Token(Token = "0x4002CF6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _capHighlight;

		// Token: 0x04002CF7 RID: 11511
		[Token(Token = "0x4002CF7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _capContainer;

		// Token: 0x04002CF8 RID: 11512
		[Token(Token = "0x4002CF8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Clickable _capClickable;

		// Token: 0x04002CF9 RID: 11513
		[Token(Token = "0x4002CF9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Draggable _syringeDraggable;

		// Token: 0x04002CFA RID: 11514
		[Token(Token = "0x4002CFA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _plungerHighlight;

		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _plungerTransform;

		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _plungerExtendedPosition;

		// Token: 0x04002CFD RID: 11517
		[Token(Token = "0x4002CFD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _plungerCompressedPosition;

		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _liquidTransform;

		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Clickable _plungerClickable;

		// Token: 0x04002D00 RID: 11520
		[Token(Token = "0x4002D00")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSourceController _plungerSound;

		// Token: 0x04002D01 RID: 11521
		[Token(Token = "0x4002D01")]
		[FieldOffset(Offset = "0x90")]
		private Collider _injectionPortCollider;

		// Token: 0x04002D02 RID: 11522
		[Token(Token = "0x4002D02")]
		[FieldOffset(Offset = "0x98")]
		public UnityEvent onCapRemoved;

		// Token: 0x04002D03 RID: 11523
		[Token(Token = "0x4002D03")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent onInserted;

		// Token: 0x04002D04 RID: 11524
		[Token(Token = "0x4002D04")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent<float> onPlungerMoved;

		// Token: 0x04002D06 RID: 11526
		[Token(Token = "0x4002D06")]
		[FieldOffset(Offset = "0xB4")]
		private bool _capRemoved;

		// Token: 0x04002D07 RID: 11527
		[Token(Token = "0x4002D07")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 _initialPlungerHitPoint;

		// Token: 0x04002D08 RID: 11528
		[Token(Token = "0x4002D08")]
		[FieldOffset(Offset = "0xC4")]
		private float timeOnPlungerClickStart;
	}
}
