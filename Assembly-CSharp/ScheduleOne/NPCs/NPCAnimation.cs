using System;
using FishNet.Object;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A4A RID: 2634
	[Token(Token = "0x2000A4A")]
	public class NPCAnimation : NetworkBehaviour
	{
		// Token: 0x06004B95 RID: 19349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x918970", Offset = "0x917B70", VA = "0x180918970", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x918AE0", Offset = "0x917CE0", VA = "0x180918AE0", Slot = "20")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x918DA0", Offset = "0x917FA0", VA = "0x180918DA0", Slot = "21")]
		protected virtual void UpdateMovementAnimation()
		{
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B98")]
		[Address(RVA = "0x918C30", Offset = "0x917E30", VA = "0x180918C30", Slot = "22")]
		public virtual void SetRagdollActive(bool active)
		{
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B99")]
		[Address(RVA = "0x918CE0", Offset = "0x917EE0", VA = "0x180918CE0")]
		public void StandupStart()
		{
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9A")]
		[Address(RVA = "0x918C70", Offset = "0x917E70", VA = "0x180918C70")]
		public void StandupDone()
		{
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9B")]
		[Address(RVA = "0x918BF0", Offset = "0x917DF0", VA = "0x180918BF0")]
		private void OnNPCVisibilityChanged(bool visible)
		{
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9C")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public NPCAnimation()
		{
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9D")]
		[Address(RVA = "0x918BD0", Offset = "0x917DD0", VA = "0x180918BD0", Slot = "23")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0x797060", Offset = "0x796260", VA = "0x180797060", Slot = "24")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x6B9F40", Offset = "0x6B9140", VA = "0x1806B9F40", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x918830", Offset = "0x917A30", VA = "0x180918830")]
		private void Awake_UserLogic_ScheduleOne.NPCs.NPCAnimation_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400350E RID: 13582
		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x0400350F RID: 13583
		[Token(Token = "0x400350F")]
		[FieldOffset(Offset = "0x120")]
		protected NPC npc;

		// Token: 0x04003510 RID: 13584
		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public AnimationCurve WalkMapCurve;

		// Token: 0x04003511 RID: 13585
		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0x130")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted;

		// Token: 0x04003512 RID: 13586
		[Token(Token = "0x4003512")]
		[FieldOffset(Offset = "0x131")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted;
	}
}
