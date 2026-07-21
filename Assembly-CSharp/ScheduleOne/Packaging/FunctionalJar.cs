using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x020008A7 RID: 2215
	[Token(Token = "0x20008A7")]
	public class FunctionalJar : FunctionalPackaging
	{
		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		// (set) Token: 0x06003A4D RID: 14925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700091C")]
		public override CursorManager.ECursorType HoveredCursor
		{
			[Token(Token = "0x6003A4C")]
			[Address(RVA = "0x7FCA10", Offset = "0x7FBC10", VA = "0x1807FCA10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return CursorManager.ECursorType.Default;
			}
			[Token(Token = "0x6003A4D")]
			[Address(RVA = "0x7FCA20", Offset = "0x7FBC20", VA = "0x1807FCA20", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A4E")]
		[Address(RVA = "0x7FC420", Offset = "0x7FB620", VA = "0x1807FC420", Slot = "14")]
		public override void Initialize(PackagingStation _station, Transform alignment, bool align = false)
		{
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A4F")]
		[Address(RVA = "0x7FC2B0", Offset = "0x7FB4B0", VA = "0x1807FC2B0", Slot = "15")]
		public override void Destroy()
		{
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A50")]
		[Address(RVA = "0x7FC360", Offset = "0x7FB560", VA = "0x1807FC360", Slot = "19")]
		protected override void EnableSealing()
		{
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A51")]
		[Address(RVA = "0x7FC700", Offset = "0x7FB900", VA = "0x1807FC700", Slot = "12")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A52")]
		[Address(RVA = "0x7FC710", Offset = "0x7FB910", VA = "0x1807FC710", Slot = "18")]
		protected override void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x7FC800", Offset = "0x7FBA00", VA = "0x1807FC800", Slot = "20")]
		public override void Seal()
		{
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A54")]
		[Address(RVA = "0x7FC3E0", Offset = "0x7FB5E0", VA = "0x1807FC3E0", Slot = "17")]
		protected override void FullyPacked()
		{
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A55")]
		[Address(RVA = "0x7FC9A0", Offset = "0x7FBBA0", VA = "0x1807FC9A0")]
		public FunctionalJar()
		{
		}

		// Token: 0x04002B21 RID: 11041
		[Token(Token = "0x4002B21")]
		[FieldOffset(Offset = "0x140")]
		[Header("References")]
		public Draggable Lid;

		// Token: 0x04002B22 RID: 11042
		[Token(Token = "0x4002B22")]
		[FieldOffset(Offset = "0x148")]
		public Transform LidStartPoint;

		// Token: 0x04002B23 RID: 11043
		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x150")]
		public Collider LidSensor;

		// Token: 0x04002B24 RID: 11044
		[Token(Token = "0x4002B24")]
		[FieldOffset(Offset = "0x158")]
		public Collider LidCollider;

		// Token: 0x04002B25 RID: 11045
		[Token(Token = "0x4002B25")]
		[FieldOffset(Offset = "0x160")]
		public GameObject FullyPackedBlocker;

		// Token: 0x04002B26 RID: 11046
		[Token(Token = "0x4002B26")]
		[FieldOffset(Offset = "0x168")]
		private GameObject LidObject;

		// Token: 0x04002B27 RID: 11047
		[Token(Token = "0x4002B27")]
		[FieldOffset(Offset = "0x170")]
		private Vector3 lidPosition;
	}
}
