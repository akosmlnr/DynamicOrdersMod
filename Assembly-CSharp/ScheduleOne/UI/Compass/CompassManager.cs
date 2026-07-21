using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Compass
{
	// Token: 0x02000DD1 RID: 3537
	[Token(Token = "0x2000DD1")]
	public class CompassManager : Singleton<CompassManager>
	{
		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x0600658C RID: 25996 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000E76")]
		private Transform cam
		{
			[Token(Token = "0x600658C")]
			[Address(RVA = "0xA91450", Offset = "0xA90650", VA = "0x180A91450")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658D")]
		[Address(RVA = "0xA8FC40", Offset = "0xA8EE40", VA = "0x180A8FC40", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658E")]
		[Address(RVA = "0xA904B0", Offset = "0xA8F6B0", VA = "0x180A904B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600658F")]
		[Address(RVA = "0xA910F0", Offset = "0xA902F0", VA = "0x180A910F0")]
		private void Update()
		{
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006590")]
		[Address(RVA = "0x594500", Offset = "0x593700", VA = "0x180594500")]
		public void SetCompassEnabled(bool enabled)
		{
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006591")]
		[Address(RVA = "0xA90760", Offset = "0xA8F960", VA = "0x180A90760")]
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006592")]
		[Address(RVA = "0xA90FA0", Offset = "0xA901A0", VA = "0x180A90FA0")]
		private void UpdateNotches()
		{
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006593")]
		[Address(RVA = "0xA90BC0", Offset = "0xA8FDC0", VA = "0x180A90BC0")]
		private void UpdateElements()
		{
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006594")]
		[Address(RVA = "0xA908C0", Offset = "0xA8FAC0", VA = "0x180A908C0")]
		private void UpdateElement(CompassManager.Element element)
		{
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006595")]
		[Address(RVA = "0xA90160", Offset = "0xA8F360", VA = "0x180A90160")]
		public void GetCompassData(Vector3 worldPosition, out float xPos, out float alpha)
		{
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6006596")]
		[Address(RVA = "0xA8F950", Offset = "0xA8EB50", VA = "0x180A8F950")]
		public CompassManager.Element AddElement(Transform transform, RectTransform contentPrefab, bool visible = true)
		{
			return null;
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006597")]
		[Address(RVA = "0xA90640", Offset = "0xA8F840", VA = "0x180A90640")]
		public void RemoveElement(Transform transform, bool alsoDestroyRect = true)
		{
		}

		// Token: 0x06006598 RID: 26008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006598")]
		[Address(RVA = "0xA90590", Offset = "0xA8F790", VA = "0x180A90590")]
		public void RemoveElement(CompassManager.Element el, bool alsoDestroyRect = true)
		{
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006599")]
		[Address(RVA = "0xA912F0", Offset = "0xA904F0", VA = "0x180A912F0")]
		public CompassManager()
		{
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600659A")]
		[Address(RVA = "0xA90830", Offset = "0xA8FA30", VA = "0x180A90830")]
		[CompilerGenerated]
		private IEnumerator <SetVisible>g__LerpContainerPosition|28_0(float yPos, bool visible)
		{
			return null;
		}

		// Token: 0x04004771 RID: 18289
		[Token(Token = "0x4004771")]
		public const int NOTCH_COUNT = 24;

		// Token: 0x04004772 RID: 18290
		[Token(Token = "0x4004772")]
		public const float DISTANCE_LABEL_THRESHOLD = 50f;

		// Token: 0x04004773 RID: 18291
		[Token(Token = "0x4004773")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04004774 RID: 18292
		[Token(Token = "0x4004774")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform NotchUIContainer;

		// Token: 0x04004775 RID: 18293
		[Token(Token = "0x4004775")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform ElementUIContainer;

		// Token: 0x04004776 RID: 18294
		[Token(Token = "0x4004776")]
		[FieldOffset(Offset = "0x40")]
		public Canvas Canvas;

		// Token: 0x04004777 RID: 18295
		[Token(Token = "0x4004777")]
		[FieldOffset(Offset = "0x48")]
		[Header("Prefabs")]
		public GameObject DirectionIndicatorPrefab;

		// Token: 0x04004778 RID: 18296
		[Token(Token = "0x4004778")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NotchPrefab;

		// Token: 0x04004779 RID: 18297
		[Token(Token = "0x4004779")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ElementPrefab;

		// Token: 0x0400477A RID: 18298
		[Token(Token = "0x400477A")]
		[FieldOffset(Offset = "0x60")]
		[Header("Settings")]
		public bool CompassEnabled;

		// Token: 0x0400477B RID: 18299
		[Token(Token = "0x400477B")]
		[FieldOffset(Offset = "0x64")]
		public Vector2 ElementContentSize;

		// Token: 0x0400477C RID: 18300
		[Token(Token = "0x400477C")]
		[FieldOffset(Offset = "0x6C")]
		public float CompassUIRange;

		// Token: 0x0400477D RID: 18301
		[Token(Token = "0x400477D")]
		[FieldOffset(Offset = "0x70")]
		public float FullAlphaRange;

		// Token: 0x0400477E RID: 18302
		[Token(Token = "0x400477E")]
		[FieldOffset(Offset = "0x74")]
		public float AngleDivisor;

		// Token: 0x0400477F RID: 18303
		[Token(Token = "0x400477F")]
		[FieldOffset(Offset = "0x78")]
		public float ClosedYPos;

		// Token: 0x04004780 RID: 18304
		[Token(Token = "0x4004780")]
		[FieldOffset(Offset = "0x7C")]
		public float OpenYPos;

		// Token: 0x04004781 RID: 18305
		[Token(Token = "0x4004781")]
		[FieldOffset(Offset = "0x80")]
		private List<Vector3> notchPositions;

		// Token: 0x04004782 RID: 18306
		[Token(Token = "0x4004782")]
		[FieldOffset(Offset = "0x88")]
		private List<CompassManager.Notch> notches;

		// Token: 0x04004783 RID: 18307
		[Token(Token = "0x4004783")]
		[FieldOffset(Offset = "0x90")]
		private List<CompassManager.Element> elements;

		// Token: 0x04004784 RID: 18308
		[Token(Token = "0x4004784")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine lerpContainerPositionCoroutine;

		// Token: 0x02000DD2 RID: 3538
		[Token(Token = "0x2000DD2")]
		public class Notch
		{
			// Token: 0x0600659B RID: 26011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600659B")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Notch()
			{
			}

			// Token: 0x04004785 RID: 18309
			[Token(Token = "0x4004785")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform Rect;

			// Token: 0x04004786 RID: 18310
			[Token(Token = "0x4004786")]
			[FieldOffset(Offset = "0x18")]
			public CanvasGroup Group;
		}

		// Token: 0x02000DD3 RID: 3539
		[Token(Token = "0x2000DD3")]
		public class Element
		{
			// Token: 0x0600659C RID: 26012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600659C")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Element()
			{
			}

			// Token: 0x04004787 RID: 18311
			[Token(Token = "0x4004787")]
			[FieldOffset(Offset = "0x10")]
			public bool LastState;

			// Token: 0x04004788 RID: 18312
			[Token(Token = "0x4004788")]
			[FieldOffset(Offset = "0x11")]
			public bool Visible;

			// Token: 0x04004789 RID: 18313
			[Token(Token = "0x4004789")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform Rect;

			// Token: 0x0400478A RID: 18314
			[Token(Token = "0x400478A")]
			[FieldOffset(Offset = "0x20")]
			public CanvasGroup Group;

			// Token: 0x0400478B RID: 18315
			[Token(Token = "0x400478B")]
			[FieldOffset(Offset = "0x28")]
			public TextMeshProUGUI DistanceLabel;

			// Token: 0x0400478C RID: 18316
			[Token(Token = "0x400478C")]
			[FieldOffset(Offset = "0x30")]
			public Transform Transform;
		}
	}
}
