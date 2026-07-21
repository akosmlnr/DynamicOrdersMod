using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts.Soil
{
	// Token: 0x020009E1 RID: 2529
	[Token(Token = "0x20009E1")]
	public class PourableSoil : Pourable
	{
		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x00013A28 File Offset: 0x00011C28
		// (set) Token: 0x06004885 RID: 18565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B59")]
		public int currentCut
		{
			[Token(Token = "0x6004884")]
			[Address(RVA = "0x6ECFF0", Offset = "0x6EC1F0", VA = "0x1806ECFF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004885")]
			[Address(RVA = "0x6ED050", Offset = "0x6EC250", VA = "0x1806ED050")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004886")]
		[Address(RVA = "0x90BA50", Offset = "0x90AC50", VA = "0x18090BA50", Slot = "8")]
		protected override void Awake()
		{
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004887")]
		[Address(RVA = "0x90C550", Offset = "0x90B750", VA = "0x18090C550", Slot = "10")]
		protected override void Update()
		{
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004888")]
		[Address(RVA = "0x90C300", Offset = "0x90B500", VA = "0x18090C300")]
		private void UpdateHighlights()
		{
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004889")]
		[Address(RVA = "0x90C190", Offset = "0x90B390", VA = "0x18090C190", Slot = "16")]
		protected override void PourAmount(float amount)
		{
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x00013A40 File Offset: 0x00011C40
		[Token(Token = "0x600488A")]
		[Address(RVA = "0x90BAD0", Offset = "0x90ACD0", VA = "0x18090BAD0", Slot = "17")]
		protected override bool CanPour()
		{
			return default(bool);
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600488B")]
		[Address(RVA = "0x90BAF0", Offset = "0x90ACF0", VA = "0x18090BAF0")]
		public void Cut()
		{
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600488C")]
		[Address(RVA = "0x90BBF0", Offset = "0x90ADF0", VA = "0x18090BBF0")]
		private void FinishCut()
		{
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600488D")]
		[Address(RVA = "0x90BEB0", Offset = "0x90B0B0", VA = "0x18090BEB0")]
		private void LerpCut(int cutIndex)
		{
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600488E")]
		[Address(RVA = "0x90C5A0", Offset = "0x90B7A0", VA = "0x18090C5A0")]
		public PourableSoil()
		{
		}

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		public const float TEAR_ANGLE = 10f;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		public const float HIGHLIGHT_CYCLE_TIME = 5f;

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[FieldOffset(Offset = "0x140")]
		public bool IsOpen;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[FieldOffset(Offset = "0x148")]
		public SoilDefinition SoilDefinition;

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x4003348")]
		[FieldOffset(Offset = "0x150")]
		[Header("References")]
		public Transform SoilBag;

		// Token: 0x04003349 RID: 13129
		[Token(Token = "0x4003349")]
		[FieldOffset(Offset = "0x158")]
		public Transform[] Bones;

		// Token: 0x0400334A RID: 13130
		[Token(Token = "0x400334A")]
		[FieldOffset(Offset = "0x160")]
		public List<Collider> TopColliders;

		// Token: 0x0400334B RID: 13131
		[Token(Token = "0x400334B")]
		[FieldOffset(Offset = "0x168")]
		public MeshRenderer[] Highlights;

		// Token: 0x0400334C RID: 13132
		[Token(Token = "0x400334C")]
		[FieldOffset(Offset = "0x170")]
		public Transform TopParent;

		// Token: 0x0400334D RID: 13133
		[Token(Token = "0x400334D")]
		[FieldOffset(Offset = "0x178")]
		public AudioSourceController SnipSound;

		// Token: 0x0400334E RID: 13134
		[Token(Token = "0x400334E")]
		[FieldOffset(Offset = "0x180")]
		public SkinnedMeshRenderer TopMesh;

		// Token: 0x04003350 RID: 13136
		[Token(Token = "0x4003350")]
		[FieldOffset(Offset = "0x190")]
		public UnityEvent onOpened;

		// Token: 0x04003351 RID: 13137
		[Token(Token = "0x4003351")]
		[FieldOffset(Offset = "0x198")]
		private Vector3 highlightScale;

		// Token: 0x04003352 RID: 13138
		[Token(Token = "0x4003352")]
		[FieldOffset(Offset = "0x1A4")]
		private float timeSinceStart;
	}
}
