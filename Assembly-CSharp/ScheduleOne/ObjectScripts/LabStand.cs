using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200099B RID: 2459
	[Token(Token = "0x200099B")]
	public class LabStand : MonoBehaviour
	{
		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06004330 RID: 17200 RVA: 0x00012C78 File Offset: 0x00010E78
		// (set) Token: 0x06004331 RID: 17201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7A")]
		public bool Interactable
		{
			[Token(Token = "0x6004330")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004331")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x00012C90 File Offset: 0x00010E90
		// (set) Token: 0x06004333 RID: 17203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7B")]
		public float CurrentPosition
		{
			[Token(Token = "0x6004332")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004333")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004334")]
		[Address(RVA = "0x89F300", Offset = "0x89E500", VA = "0x18089F300")]
		private void Start()
		{
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004335")]
		[Address(RVA = "0x89EC90", Offset = "0x89DE90", VA = "0x18089EC90")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004336")]
		[Address(RVA = "0x89EE40", Offset = "0x89E040", VA = "0x18089EE40")]
		private void Move()
		{
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004337")]
		[Address(RVA = "0x89F440", Offset = "0x89E640", VA = "0x18089F440")]
		private void UpdateSound(float difference)
		{
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004338")]
		[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
		public void SetPosition(float position)
		{
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004339")]
		[Address(RVA = "0x89F2C0", Offset = "0x89E4C0", VA = "0x18089F2C0")]
		public void SetInteractable(bool e)
		{
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433A")]
		[Address(RVA = "0x89E910", Offset = "0x89DB10", VA = "0x18089E910")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x600433B")]
		[Address(RVA = "0x89E9C0", Offset = "0x89DBC0", VA = "0x18089E9C0")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433C")]
		[Address(RVA = "0x89E900", Offset = "0x89DB00", VA = "0x18089E900")]
		public void ClickEnd()
		{
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433D")]
		[Address(RVA = "0x89F5A0", Offset = "0x89E7A0", VA = "0x18089F5A0")]
		public LabStand()
		{
		}

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float MoveSpeed;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x2C")]
		public bool FunnelEnabled;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x30")]
		public float FunnelThreshold;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Animation Anim;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0x40")]
		public Transform GripTransform;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0x48")]
		public Transform SpinnyThingy;

		// Token: 0x04003086 RID: 12422
		[Token(Token = "0x4003086")]
		[FieldOffset(Offset = "0x50")]
		public Transform RaisedTransform;

		// Token: 0x04003087 RID: 12423
		[Token(Token = "0x4003087")]
		[FieldOffset(Offset = "0x58")]
		public Transform LoweredTransform;

		// Token: 0x04003088 RID: 12424
		[Token(Token = "0x4003088")]
		[FieldOffset(Offset = "0x60")]
		public Transform PlaneNormal;

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		[FieldOffset(Offset = "0x68")]
		public Clickable HandleClickable;

		// Token: 0x0400308A RID: 12426
		[Token(Token = "0x400308A")]
		[FieldOffset(Offset = "0x70")]
		public Transform Funnel;

		// Token: 0x0400308B RID: 12427
		[Token(Token = "0x400308B")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Highlight;

		// Token: 0x0400308C RID: 12428
		[Token(Token = "0x400308C")]
		[FieldOffset(Offset = "0x80")]
		public AudioSourceController LowerSound;

		// Token: 0x0400308D RID: 12429
		[Token(Token = "0x400308D")]
		[FieldOffset(Offset = "0x88")]
		public AudioSourceController RaiseSound;

		// Token: 0x0400308E RID: 12430
		[Token(Token = "0x400308E")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 clickOffset;

		// Token: 0x0400308F RID: 12431
		[Token(Token = "0x400308F")]
		[FieldOffset(Offset = "0x9C")]
		private bool isMoving;
	}
}
